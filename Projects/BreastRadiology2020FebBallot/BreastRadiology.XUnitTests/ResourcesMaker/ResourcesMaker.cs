using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using PreFhir;

namespace BreastRadiology.XUnitTests
{
    /*
     $ todo. Add negation items (mass, calc, etc).
     $ todo. Add condition that if item is not present, then body site is empty.
     $ todo. Add condition that if body site is empty, then breast body site extension is
             also empty and vice versa.
     */

    partial class ResourcesMaker : ConverterBase
    {
        public const String Group_BaseResources = "BaseResources";
        public const String Group_CommonResources = "CommonResources";
        public const String Group_CommonCodes = "CommonCodes";

        public const String Group_MammoResources = "MammoResources";
        public const String Group_MammoCodes = "MammoCodes";

        public const String Group_MRIResources = "MRIResources";
        public const String Group_MRICodes= "MRICodes";

        public const String Group_USResources = "USResources";
        public const String Group_USCodes = "USCodes";

        public const String Group_ExtensionResources = "ExtensionResources";

        public const String GroupExtensionUrl = "http://www.ResourceMaker.com/Group";
        public static String BiRadCitation = "Bi-Rads® Atlas — Mammography Fifth Ed. 2013";
        const FHIRVersion FVersion = FHIRVersion.N4_0_0;

        const String ProfileVersion = "0.0.2";
        const PublicationStatus ProfileStatus = PublicationStatus.Draft;

        const String Loinc = "http://loinc.org";

        const String ObservationUrl = "http://hl7.org/fhir/StructureDefinition/Observation";
        const String DiagnosticReportUrl = "http://hl7.org/fhir/StructureDefinition/DiagnosticReport";
        const String ExtensionUrl = "http://hl7.org/fhir/StructureDefinition/Extension";
        const String MedicationRequestUrl = "http://hl7.org/fhir/StructureDefinition/MedicationRequest";
        const String ServiceRequestUrl = "http://hl7.org/fhir/StructureDefinition/ServiceRequest";
        const String ResourceUrl = "http://hl7.org/fhir/StructureDefinition/Resource";

        const String contactUrl = "http://www.hl7.org/Special/committees/cic";

        FileCleaner fc = new FileCleaner();
        Dictionary<String, Resource> resources = new Dictionary<string, Resource>();

        String resourceDir;
        String pageDir;
        FhirDateTime date = new FhirDateTime(2019, 11, 1);
        public Dictionary<String, SDefEditor> editors = new Dictionary<String, SDefEditor>();

        String CreateUrl(String name)
        {
            return $"http://hl7.org/fhir/us/breast-radiology/StructureDefinition/{name}";
        }

        public ResourcesMaker(String resourceDir,
            String pageDir,
            String cacheDir)
        {
            const String fcn = "ResourcesMaker";

            this.resourceDir = resourceDir;
            this.pageDir = pageDir;

            if (Directory.Exists(this.resourceDir) == false)
                Directory.CreateDirectory(this.resourceDir);

            if (Directory.Exists(this.pageDir) == false)
                Directory.CreateDirectory(this.pageDir);

            if (FhirStructureDefinitions.Self == null)
            {
                this.ConversionInfo(this.GetType().Name, fcn, $"Init'g 'FhirStructureDefinitions'");
                FhirStructureDefinitions.Create(cacheDir);
            }
        }

        SDefEditor CreateEditor(String name,
            String title,
            String[] mapName,
            String baseDefinition,
            String groupPath,
            out String url)
        {
            if (name.Contains(" "))
                throw new Exception("Structure Def name can not contains spaces");

            SDefEditor retVal = new SDefEditor(name, this.CreateUrl(name), baseDefinition, mapName, this.resourceDir, this.pageDir)
                .Title(title)
                .Derivation(StructureDefinition.TypeDerivationRule.Constraint)
                .Abstract(false)
                .Type(baseDefinition.LastUriPart())
                .Kind(StructureDefinition.StructureDefinitionKind.Resource)
                .Status(PublicationStatus.Draft)
                ;

            retVal.SDef.FhirVersion = FHIRVersion.N4_0_0;

            this.editors.Add(retVal.SDef.Url, retVal);
            url = retVal.SDef.Url;

            // store groupPath as an extension. This is an unregistered extension that will be removed before
            // processing is complete.
            retVal.SDef.Extension.Add(new Extension
            {
                Url = GroupExtensionUrl,
                Value = new FhirString(groupPath)
            });

            return retVal;
        }

        SDefEditor CreateFragment(String name,
            String title,
            String[] mapName,
            String baseDefinition,
            out String url)
        {
            SDefEditor retVal = this.CreateEditor(name,
                title,
                mapName,
                baseDefinition,
                "Fragment/{name}",
                out url);
            retVal.SetIsFrag();
            retVal.SDef.Abstract = true;
            return retVal;
        }

        class Definition
        {
            StringBuilder sb = new StringBuilder();
            //bool citeFlag = false;

            public Definition CiteStart()
            {
                return this;
            }

            public Definition CiteEnd(String citationSource)
            {
                sb.AppendLine($"    -- {citationSource}");
                return this;
            }

            public Definition Line(String line)
            {
                sb.AppendLine(line);
                return this;
            }

            public String ToText()
            {
                return sb.ToString();
            }
        }

        class ConceptDef
        {
            public String Code;
            public String Display;
            public String Definition;

            public ConceptDef(String code, String display, String definition)
            {
                if (String.IsNullOrWhiteSpace(code) == true)
                    throw new Exception("Empty code");
                if (String.IsNullOrWhiteSpace(display) == true)
                    throw new Exception("Empty Display");
                if (String.IsNullOrWhiteSpace(definition) == true)
                    throw new Exception("Empty definition");
                Code = code;
                Display = display;
                Definition = definition;
            }

            public ConceptDef(String code, String display, Definition definition) : this(code, display, definition.ToText())
            {
            }
        }

        ValueSet CreateValueSet(String name,
            String title,
            String[] mapName,
            String description,
            String groupPath,
            IEnumerable<ConceptDef> codes)
        {
            return CreateValueSet(name, title, mapName, description, groupPath, codes, out CodeSystem cs);
        }

        ValueSet CreateValueSet(String name,
            String title,
            String[] mapName,
            String description,
            String groupPath,
            IEnumerable<ConceptDef> codes,
            out CodeSystem cs)
        {
            cs = new CodeSystem
            {
                Id = $"{name}CS",
                Url = $"http://hl7.org/fhir/us/breast-radiology/CodeSystem/{name}CS",
                Name = $"{name}CS",
                Title = $"{title} CodeSystem",
                Description = new Markdown(description),
                CaseSensitive = true,
                Content = CodeSystem.CodeSystemContentMode.Complete,
                Count = codes.Count(),
            };
            cs.AddFragRef(this.HeaderFragment);

            // store groupPath as an extension. This is an unregistered extension that will be removed before
            // processing is complete.
            cs.Extension.Add(new Extension
            {
                Url = GroupExtensionUrl,
                Value = new FhirString($"{groupPath}CS")
            });

            ValueSet vs = new ValueSet
            {
                Id = $"{name}VS",
                Url = $"http://hl7.org/fhir/us/breast-radiology/ValueSet/{name}VS",
                Name = $"{name}VS",
                Title = $"{title} ValueSet",
                Description = new Markdown(description)
            };
            vs.AddFragRef(this.HeaderFragment);

            // store groupPath as an extension. This is an unregistered extension that will be removed before
            // processing is complete.
            vs.Extension.Add(new Extension
            {
                Url = GroupExtensionUrl,
                Value = new FhirString($"{groupPath}VS")
            });


            ValueSet.ConceptSetComponent vsComp = new ValueSet.ConceptSetComponent
            {
                System = cs.Url
            };
            vs.Compose = new ValueSet.ComposeComponent();
            vs.Compose.Include.Add(vsComp);

            foreach (ConceptDef code in codes)
            {
                vsComp.Concept.Add(new ValueSet.ConceptReferenceComponent
                {
                    Code = code.Code,
                    Display = code.Display
                });

                cs.Concept.Add(new CodeSystem.ConceptDefinitionComponent
                {
                    Code = code.Code,
                    Display = code.Display,
                    Definition = code.Definition
                });
            }

            resources.Add(Path.Combine(this.resourceDir, $"CodeSystem-{name}CS.json"), cs);
            resources.Add(Path.Combine(this.resourceDir, $"ValueSet-{name}VS.json"), vs);

            ResourceMap.Self.CreateMapNode(vs.Url, mapName);
            return vs;
        }

        public void CreateResources()
        {
            this.fc.Add(this.resourceDir);
            this.fc.Add(this.pageDir);

            String report = this.BreastRadiologyReport;

            this.SaveAll();
            this.fc.Dispose();
        }

        public void CreateFocusMaps(String graphicsDir)
        {
            if (Directory.Exists(graphicsDir) == false)
                Directory.CreateDirectory(graphicsDir);

            FocusMapMaker focusMapMaker = new FocusMapMaker(this, graphicsDir, this.pageDir);
            focusMapMaker.Create();
        }

        public void CreateResourceMap(String mapDir)
        {
            if (Directory.Exists(mapDir) == false)
                Directory.CreateDirectory(mapDir);
            ResourceMapMaker resourceMapMaker = new ResourceMapMaker(this);
            resourceMapMaker.Create(Path.Combine(mapDir, "ProfileOverview.svg"));

            //FragmentMapMaker fragmentMapMaker = new FragmentMapMaker(this, mapDir);
            //fragmentMapMaker.Create();
        }

        void SaveAll()
        {
            const String fcn = "SaveAll";

            foreach (KeyValuePair<string, Resource> resourceItem in this.resources)
            {
                resourceItem.Value.SaveJson(resourceItem.Key);
                this.fc.Mark(resourceItem.Key);
            }

            foreach (SDefEditor ce in this.editors.Values)
            {
                if (ce.WriteFragment(out String fragmentName))
                    this.fc.Mark(fragmentName);
                if (ce.WriteIntro(out String introName) == false)
                {
                    this.ConversionError(this.GetType().Name,
                        fcn,
                        $"{ce.SDef.Name} has no intro section");
                }
                else
                    this.fc.Mark(introName);
            }
        }
    }
}
