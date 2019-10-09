using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace FhirKhit.BreastRadiology.XUnitTests
{
    public class IGBuilder : ConverterBase
    {
        const PublicationStatus ProfileStatus = PublicationStatus.Draft;

        String outputDir;
        String resourceDir => Path.Combine(this.outputDir, "resources");
        String IgPath => Path.Combine(outputDir, "IG.json");
        String ImpGuidePath => Path.Combine(outputDir, "Resources", "ig.xml");

        ProfilesEditor profilesEditor;
        ExamplesEditor examplesEditor;
        ExtensionsEditor extensionsEditor;
        CodeSystemsEditor codeSystemsEditor;
        ValueSetsEditor valueSetsEditor;
        ImplementationGuideEditor implementationGuide;
        IGEditor igEditor;

        List<SDefEditor> editors = new List<SDefEditor>();

        public IGBuilder(String outputDir)
        {
            this.outputDir = outputDir;
        }

        void AddIGStructureDefinition(StructureDefinition sDef, bool extensionFlag)
        {
            String htmlName = $"StructureDefinition-{sDef.Name}.html";

            this.implementationGuide.AddIGResource($"StructureDefinition/{sDef.Name}", sDef.Name, false);
            this.igEditor.AddResource($"StructureDefinition/{sDef.Name}",
                htmlName);
            if (extensionFlag == false)
                this.profilesEditor.AddProfile(sDef.Name,
                    htmlName,
                    sDef.BaseDefinition,
                    sDef.BaseDefinition.LastUriPart(),
                    sDef.Description);
            else
                this.extensionsEditor.AddExtension(sDef.Name,
                    htmlName,
                    sDef.Description);
        }


        public void SaveAll()
        {
            foreach (SDefEditor ce in this.editors)
            {
                StructureDefinition sDef = ce.SDef;
                SnapshotCreator.Create(sDef);
                ce.Write();
            }

            implementationGuide.Save(this.ImpGuidePath);
            this.igEditor.Save(this.IgPath);
            this.examplesEditor.Save();
            this.profilesEditor.Save();
            this.extensionsEditor.Save();
            this.codeSystemsEditor.Save();
            this.valueSetsEditor.Save();
        }

        public void Start()
        {
            this.examplesEditor = new ExamplesEditor(this.outputDir);
            this.profilesEditor = new ProfilesEditor(this.outputDir);
            this.extensionsEditor = new ExtensionsEditor(this.outputDir);
            this.codeSystemsEditor = new CodeSystemsEditor(this.outputDir);
            this.valueSetsEditor = new ValueSetsEditor(this.outputDir);

            this.igEditor = IGEditor.Load(this.IgPath);
            this.igEditor.dependencyListJson?.Clear();
            this.implementationGuide = new ImplementationGuideEditor(this.ImpGuidePath);
        }

        public void AddResources(String resourceDir)
        {
            void Save(Resource r, String outputName)
            {
                r.SaveJson(Path.Combine(this.resourceDir, outputName));
            }

            String FixName(String path, String prefix)
            {
                String retVal = Path.GetFileNameWithoutExtension(path);
                retVal = $"{prefix}{retVal.Substring(prefix.Length)}";
                return retVal;
            }

            foreach (String file in Directory.GetFiles(resourceDir))
            {
                String fhirText = File.ReadAllText(file);
                FhirJsonParser parser = new FhirJsonParser();
                var resource = parser.Parse(fhirText, typeof(Resource));
                switch (resource)
                {
                    case StructureDefinition structureDefinition:
                        {
                            String typeName = "StructureDefinition";
                            String fixedName = FixName(file, typeName);
                            String htmlPage = $"{fixedName}.html";
                            SnapshotCreator.Create(structureDefinition);
                            Save(structureDefinition, $"{fixedName}.json");
                            bool extensionFlag = structureDefinition.BaseDefinition == "http://hl7.org/fhir/StructureDefinition/Extension";
                            this.AddIGStructureDefinition(structureDefinition, extensionFlag);
                        }
                        break;

                    case CodeSystem codeSystem:
                        {
                            String typeName = "CodeSystem";
                            String fixedName = FixName(file, typeName);
                            String htmlPage = $"{fixedName}.html";
                            Save(codeSystem, $"{fixedName}.json");
                            this.implementationGuide.AddIGResource($"{typeName}/{codeSystem.Name}", codeSystem.Name, false);
                            this.igEditor.AddResource($"{typeName}/{codeSystem.Name}",
                                htmlPage);
                            this.codeSystemsEditor.AddCodeSystem(codeSystem.Name,
                                htmlPage,
                                codeSystem.Description);
                        }
                        break;

                    case ValueSet valueSet:
                        {
                            String typeName = "ValueSet";
                            String fixedName = FixName(file, typeName);
                            String htmlPage = $"{fixedName}.html";
                            Save(valueSet, $"{fixedName}.json");
                            this.implementationGuide.AddIGResource($"{typeName}/{valueSet.Name}", valueSet.Name, false);
                            this.igEditor.AddResource($"{typeName}/{valueSet.Name}",
                                htmlPage);
                            this.valueSetsEditor.AddValueSet(valueSet.Name,
                                htmlPage,
                                valueSet.Description);
                        }
                        break;

                    default:
                        throw new NotImplementedException($"Unknown resource type '{file}'");
                }
            }
        }
    }
}
