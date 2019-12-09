using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadiology.XUnitTests
{
    public class IGBuilder : ConverterBase
    {
        FileCleaner fc = new FileCleaner();

        String outputDir;
        String resourceDir => Path.Combine(this.outputDir, "resources");
        String pagecontentDir => Path.Combine(this.outputDir, "pagecontent");
        String imagesDir => Path.Combine(this.outputDir, "images");
        //String IgPath => Path.Combine(this.outputDir, "IGBreastRad.json");
        String ImpGuidePath => Path.Combine(this.outputDir, "IGBreastRad.xml");

        //ProfilesEditor profilesEditor;
        //ExamplesEditor examplesEditor;
        //ExtensionsEditor extensionsEditor;
        //CodeSystemsEditor codeSystemsEditor;
        //ValueSetsEditor valueSetsEditor;
        ImplementationGuideEditor implementationGuide;
        //IGEditor igEditor;

        public IGBuilder(String outputDir)
        {
            this.outputDir = outputDir;
            this.fc.Add(this.resourceDir);
            this.fc.Add(this.pagecontentDir);
            this.fc.Add(this.imagesDir);
        }

        void AddIGStructureDefinition(StructureDefinition sDef)
        {
            String htmlName = $"StructureDefinition-{sDef.Name}.html";

            this.implementationGuide.AddIGResource($"StructureDefinition/{sDef.Name}", sDef.Name, false);
            //this.igEditor.AddResource($"StructureDefinition/{sDef.Name}",
            //    htmlName);
            switch (sDef.BaseDefinition)
            {
                case "":
                case null:
                    {
                    //List < Tuple<String, String>> references = new List<Tuple<String, string>>();
                    //    references.Add(new Tuple<String, String>(sDef.Name, htmlName));
                    //this.profilesEditor.AddFragment(references, sDef.Description);
                    }
                    break;

                case "http://hl7.org/fhir/StructureDefinition/Extension":
                    //this.extensionsEditor.AddExtension(sDef.Name,
                    //    htmlName,
                    //    sDef.Description);
                    break;

                default:
                    //this.profilesEditor.AddProfile(sDef.Name,
                    //    htmlName,
                    //    sDef.BaseDefinition,
                    //    sDef.BaseDefinition.LastUriPart(),
                    //    sDef.Description);
                    break;
            }
        }


        public void SaveAll()
        {
            this.implementationGuide.Save(this.ImpGuidePath);
            this.fc.Mark(this.ImpGuidePath);

            //this.igEditor.Save(this.IgPath);
            //this.fc.Mark(this.IgPath);

            //this.examplesEditor.Save();
            //this.profilesEditor.Save();
            //this.extensionsEditor.Save();
            //this.codeSystemsEditor.Save();
            //this.valueSetsEditor.Save();

            this.fc.Dispose();
        }

        public void Start()
        {
            //this.examplesEditor = new ExamplesEditor(this.outputDir);
            //this.profilesEditor = new ProfilesEditor(this.outputDir);
            //this.extensionsEditor = new ExtensionsEditor(this.outputDir);
            //this.codeSystemsEditor = new CodeSystemsEditor(this.outputDir);
            //this.valueSetsEditor = new ValueSetsEditor(this.outputDir);

            //this.igEditor = IGEditor.Load(this.IgPath);
            //this.igEditor.dependencyListJson?.Clear();
            this.implementationGuide = new ImplementationGuideEditor(this.ImpGuidePath);
        }

        void CopyFiles(String inputDir, String inputMask, String outputDir)
        {
            foreach (String inputPath in Directory.GetFiles(inputDir, inputMask))
            {
                String outputPath = Path.Combine(outputDir, Path.GetFileName(inputPath));
                File.Copy(inputPath, outputPath, true);
                fc.Mark(outputPath);
            }
        }

        public void AddPageContent(String inputDir)
        {
            CopyFiles(inputDir, "*.xml", this.pagecontentDir);
        }

        public void AddImages(String inputDir)
        {
            CopyFiles(inputDir, "*.svg", this.imagesDir);
        }

        public void AddResources(String inputDir)
        {
            const String IsFragmentExtensionUrl = "http://www.fragment.com/isFragment";

            void Save(Resource r, String outputName)
            {
                String outputPath = Path.Combine(this.resourceDir, outputName);
                r.SaveJson(outputPath);
                this.fc.Mark(outputPath);
            }

            String FixName(String path, String prefix)
            {
                String retVal = Path.GetFileNameWithoutExtension(path);
                retVal = $"{prefix}{retVal.Substring(prefix.Length)}";
                return retVal;
            }

            foreach (String file in Directory.GetFiles(inputDir))
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
                            Extension isFragmentExtension = structureDefinition.GetExtension(IsFragmentExtensionUrl);
                            if (isFragmentExtension != null)
                                structureDefinition.RemoveExtension(IsFragmentExtensionUrl);
                            Save(structureDefinition, $"{fixedName}.json");
                            // Dont add fragments to IG.
                            if (isFragmentExtension == null)
                                this.AddIGStructureDefinition(structureDefinition);
                        }
                        break;

                    case CodeSystem codeSystem:
                        {
                            String typeName = "CodeSystem";
                            String fixedName = FixName(file, typeName);
                            String htmlPage = $"{fixedName}.html";

                            Save(codeSystem, $"{fixedName}.json");
                            this.implementationGuide.AddIGResource($"{typeName}/{codeSystem.Name}", codeSystem.Name, false);
                            //this.igEditor.AddResource($"{typeName}/{codeSystem.Name}",
                            //    htmlPage);
                            //this.codeSystemsEditor.AddCodeSystem(codeSystem.Name,
                            //    htmlPage,
                            //    codeSystem.Description);
                        }
                        break;

                    case ValueSet valueSet:
                        {
                            String typeName = "ValueSet";
                            String fixedName = FixName(file, typeName);
                            String htmlPage = $"{fixedName}.html";

                            Save(valueSet, $"{fixedName}.json");
                            this.implementationGuide.AddIGResource($"{typeName}/{valueSet.Name}", valueSet.Name, false);
                            //this.igEditor.AddResource($"{typeName}/{valueSet.Name}",
                            //    htmlPage);
                            //this.valueSetsEditor.AddValueSet(valueSet.Name,
                            //    htmlPage,
                            //    valueSet.Description);
                        }
                        break;

                    default:
                        throw new NotImplementedException($"Unknown resource type '{file}'");
                }
            }
        }
    }
}
