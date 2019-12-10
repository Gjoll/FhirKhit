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
        String ImpGuidePath => Path.Combine(this.outputDir, impGuideName);
        String impGuideName;


        //ProfilesEditor profilesEditor;
        //ExamplesEditor examplesEditor;
        //ExtensionsEditor extensionsEditor;
        //CodeSystemsEditor codeSystemsEditor;
        //ValueSetsEditor valueSetsEditor;
        ImplementationGuideEditor implementationGuide;

        public IGBuilder(String outputDir)
        {
            this.outputDir = outputDir;
            this.fc.Add(this.resourceDir);
            this.fc.Add(this.pagecontentDir);
            this.fc.Add(this.imagesDir);
        }

        void AddIGStructureDefinition(StructureDefinition sDef, String groupId)
        {
            this.implementationGuide.AddIGResource($"StructureDefinition/{sDef.Name}", sDef.Title, sDef.Description.ToString(), groupId, false);
        }


        public void SaveAll()
        {
            this.implementationGuide.Save(this.ImpGuidePath);
            this.fc.Mark(this.ImpGuidePath);

            //this.fc.Mark(this.IgPath);

            //this.examplesEditor.Save();
            //this.profilesEditor.Save();
            //this.extensionsEditor.Save();
            //this.codeSystemsEditor.Save();
            //this.valueSetsEditor.Save();

            this.fc.Dispose();
        }

        public void Start(String impGuidePath)
        {
            //this.examplesEditor = new ExamplesEditor(this.outputDir);
            //this.profilesEditor = new ProfilesEditor(this.outputDir);
            //this.extensionsEditor = new ExtensionsEditor(this.outputDir);
            //this.codeSystemsEditor = new CodeSystemsEditor(this.outputDir);
            //this.valueSetsEditor = new ValueSetsEditor(this.outputDir);

            this.impGuideName = Path.GetFileName(impGuidePath);
            this.implementationGuide = new ImplementationGuideEditor(impGuidePath);
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

        HashSet<String> groupIds = new HashSet<string>();
        public void AddGrouping(String groupId, String name, String description)
        {
            this.implementationGuide.AddGrouping(groupId, name, description);
            if (this.groupIds.Contains(groupId))
                throw new Exception($"Group already added");
            this.groupIds.Add(groupId);
        }

        public void AddResources(params String[] inputDirs)
        {
            const String fcn = "AddResources";
            const String IsFragmentExtensionUrl = "http://www.fragment.com/isFragment";
            const String GroupExtensionUrl = "http://www.ResourceMaker.com/Group";

            String Group(StructureDefinition sd)
            {
                Extension groupExtension = sd.GetExtension(GroupExtensionUrl);
                if (sd == null)
                    throw new Exception($"StructureDefinition {sd.Url} lacks group extension");
                FhirString value = groupExtension.Value as FhirString;
                if (value == null)
                    throw new Exception($"StructureDefinition {sd.Url} lacks group extension value");
                return value.Value;
            }

            void Save(Resource r, String outputName)
            {
                String outputPath = Path.Combine(this.resourceDir, outputName);
                r.SaveJson(outputPath);
                this.fc.Mark(outputPath);
            }

            List<StructureDefinition> structureDefinitions = new List<StructureDefinition>();
            List<ValueSet> valueSets = new List<ValueSet>();
            List<CodeSystem> codeSystems = new List<CodeSystem>();

            foreach (String inputDir in inputDirs)
            {
                foreach (String file in Directory.GetFiles(inputDir))
                {
                    String fhirText = File.ReadAllText(file);
                    FhirJsonParser parser = new FhirJsonParser();
                    var resource = parser.Parse(fhirText, typeof(Resource));
                    switch (resource)
                    {
                        case StructureDefinition structureDefinition:
                            structureDefinitions.Add(structureDefinition);
                            break;

                        case CodeSystem codeSystem:
                            codeSystems.Add(codeSystem);
                            break;

                        case ValueSet valueSet:
                            valueSets.Add(valueSet);
                            break;

                        default:
                            throw new NotImplementedException($"Unknown resource type '{file}'");
                    }
                }
            }

            structureDefinitions.Sort((a, b) => String.Compare(Group(a), Group(b)));
            valueSets.Sort((a, b) => String.Compare(a.Name, b.Name));
            codeSystems.Sort((a, b) => String.Compare(a.Name, b.Name));

            foreach (CodeSystem codeSystem in codeSystems)
            {
                Save(codeSystem, $"CodeSystem-{codeSystem.Name}.json");
                this.implementationGuide.AddIGResource($"CodeSystem/{codeSystem.Name}", codeSystem.Title, codeSystem.Description.ToString(), null, false);
            }

            foreach (ValueSet valueSet in valueSets)
            {
                Save(valueSet, $"ValueSet-{valueSet.Name}.json");
                this.implementationGuide.AddIGResource($"ValueSet/{valueSet.Name}", valueSet.Title, valueSet.Description.ToString(), null, false);
            }

            foreach (StructureDefinition structureDefinition in structureDefinitions)
            {
                String fixedName = $"StructureDefinition-{structureDefinition.Name}";

                if (structureDefinition.Snapshot == null)
                    SnapshotCreator.Create(structureDefinition);
                Extension isFragmentExtension = structureDefinition.GetExtension(IsFragmentExtensionUrl);
                if (isFragmentExtension != null)
                    structureDefinition.RemoveExtension(IsFragmentExtensionUrl);

                // Dont add fragments to IG.
                if (isFragmentExtension == null)
                {
                    String groupPath = Group(structureDefinition);
                    structureDefinition.RemoveExtension(GroupExtensionUrl);

                    Save(structureDefinition, $"{fixedName}.json");
                    String groupId = groupPath.BaseUriPart();
                    if (this.groupIds.Contains(groupId) == false)
                    {
                        this.ConversionError(this.GetType().Name,
                           fcn,
                           $"Group {groupId} not defined");
                        return;
                    }
                    this.AddIGStructureDefinition(structureDefinition, groupId);
                }
                else
                {
                }
            }
        }
    }
}
