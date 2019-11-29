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

    public partial class ResourcesMaker : ConverterBase
    {
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
        FhirDateTime date = new FhirDateTime(2019, 11, 1);
        Dictionary<String, SDefEditor> editors = new Dictionary<String, SDefEditor>();

        String CreateUrl(String name)
        {
            return $"http://hl7.org/fhir/us/breast-radiology/StructureDefinition/{name}";
        }

        public ResourcesMaker(String resourceDir,
            String cacheDir)
        {
            const String fcn = "ResourcesMaker";

            this.resourceDir = resourceDir;
            if (Directory.Exists(this.resourceDir) == false)
                Directory.CreateDirectory(this.resourceDir);

            if (FhirStructureDefinitions.Self == null)
            {
                this.ConversionInfo(this.GetType().Name, fcn, $"Init'g 'FhirStructureDefinitions'");
                FhirStructureDefinitions.Create(cacheDir);
            }
        }

        SDefEditor CreateEditor(String name,
            String title,
            String[] mapName,
            String baseDefinition)
        {
            if (name.Contains(" "))
                throw new Exception("Structure Def name can not contains spaces");

            SDefEditor retVal = new SDefEditor(name, this.CreateUrl(name), baseDefinition, mapName, this.resourceDir)
                .Title(title)
                .Derivation(StructureDefinition.TypeDerivationRule.Constraint)
                .Abstract(false)
                .Type(baseDefinition.LastUriPart())
                .Kind(StructureDefinition.StructureDefinitionKind.Resource)
                ;

            retVal.SDef.FhirVersion = FHIRVersion.N4_0_0;

            this.editors.Add(retVal.SDef.Url, retVal);
            return retVal;
        }

        SDefEditor CreateFragment(String name,
            String title,
            String[] mapName,
            String baseDefinition)
        {
            SDefEditor retVal = this.CreateEditor(name,
                title,
                mapName,
                baseDefinition);
            retVal.SetIsFrag();
            retVal.SDef.Abstract = true;
            return retVal;
        }

        SDefEditor CreateObservationEditor(String name,
            String title,
            String[] mapName)
        {
            SDefEditor retVal = this.CreateEditor(name,
                title,
                mapName,
                ObservationUrl);
            retVal.AddFragRef(this.FindingObservationFragment);
            return retVal;
        }

        ValueSet CreateValueSet(String name,
            String title,
            Markdown description,
            IEnumerable<String> codes)
        {
            CodeSystem cs = new CodeSystem
            {
                Id = $"{name}CS",
                Url = $"http://hl7.org/fhir/us/breast-radiology/CodeSystem/{name}CS",
                Name = $"{name}CS",
                Title = title,
                Description = description,
                CaseSensitive = true,
                Content = CodeSystem.CodeSystemContentMode.Complete,
                Count = codes.Count()
            };
            cs.AddFragRef(this.HeaderFragment);

            ValueSet vs = new ValueSet
            {
                Id = $"{name}VS",
                Url = $"http://hl7.org/fhir/us/breast-radiology/CodeSystem/{name}VS",
                Name = $"{name}VS",
                Title = title,
                Description = description
            };
            vs.AddFragRef(this.HeaderFragment);


            ValueSet.ConceptSetComponent vsComp = new ValueSet.ConceptSetComponent
            {
                System = cs.Url
            };
            vs.Compose = new ValueSet.ComposeComponent();
            vs.Compose.Include.Add(vsComp);

            Int32 counter = 1;
            foreach (String code in codes)
            {
                vsComp.Concept.Add(new ValueSet.ConceptReferenceComponent
                {
                    Code = counter.ToString(),
                    Display = code
                });

                cs.Concept.Add(new CodeSystem.ConceptDefinitionComponent
                {
                    Code = counter.ToString(),
                    Display = code,
                });
                counter += 1;
            }

            resources.Add(Path.Combine(this.resourceDir, $"CodeSystem-{name}CS.json"), cs);
            resources.Add(Path.Combine(this.resourceDir, $"ValueSet-{name}VS.json"), vs);
            return vs;
        }

        class ConceptDef
        {
            public String Code;
            public String Display;
            public String Definition;

            public ConceptDef(String code, String display, String definition)
            {
                Code = code;
                Display = display;
                Definition = definition;
            }
        }

        ValueSet CreateValueSet(String name,
            String title,
            Markdown description,
            IEnumerable<ConceptDef> codes)
        {
            return CreateValueSet(name, title, description, codes, out CodeSystem cs);
        }

        ValueSet CreateValueSet(String name,
            String title,
            Markdown description,
            IEnumerable<ConceptDef> codes,
            out CodeSystem cs)
        {
            cs = new CodeSystem
            {
                Id = $"{name}CS",
                Url = $"http://hl7.org/fhir/us/breast-radiology/CodeSystem/{name}CS",
                Name = $"{name}CS",
                Title = title,
                Description = description,
                CaseSensitive = true,
                Content = CodeSystem.CodeSystemContentMode.Complete,
                Count = codes.Count()
            };
            cs.AddFragRef(this.HeaderFragment);

            ValueSet vs = new ValueSet
            {
                Id = $"{name}VS",
                Url = $"http://hl7.org/fhir/us/breast-radiology/CodeSystem/{name}VS",
                Name = $"{name}VS",
                Title = title,
                Description = description
            };
            vs.AddFragRef(this.HeaderFragment);


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

            return vs;
        }

        public void CreateResources()
        {
            this.fc.Add(this.resourceDir);

            String report = this.BreastRadiologyReport;

            this.SaveAll();
            this.fc.Dispose();
        }

        public void CreateMaps(String outputDir)
        {
            IEnumerable<MapLink> TargetLinks(MapNode n)
            {
                foreach (MapLink link in n.Links)
                {
                    switch (link.LinkType)
                    {
                        case "target":
                            yield return link;
                            break;
                    }
                }
            }
            SENode CreateNode(String url)
            {
                SENode node = new SENode(0, Color.LightGreen);

                if (this.editors.TryGetValue(url, out SDefEditor e) == false)
                    throw new Exception("Internal error. Editor not found");
                foreach (String titlePart in e.MapName)
                {
                    String s = titlePart.Trim();
                    node.AddTextLine(s);
                }
                return node;
            }
            bool DifferentChildren(MapLink[] links1, MapLink[] links2)
            {
                if (links1.Length != links2.Length)
                    return true;
                for (Int32 i = 0; i < links1.Length; i++)
                {
                    MapLink link1 = links1[i];
                    MapLink link2 = links2[i];
                    if (link1.LinkType != link2.LinkType)
                        return true;
                    if (link1.ResourceUrl != link2.ResourceUrl)
                        return true;
                }
                return false;
            }

            /*
             * Add children. If two adjacent children have same children, then dont create each in a seperate
             * group. Have the two nodes point to the same group of children.
             */
            void AddChildren(MapNode mapNode,
                MapLink[] links,
                SENodeGroup group)
            {
                MapLink[] previousChildLinks = null;
                if (links.Length > 0)
                {
                    SENodeGroup groupChild = null;
                    foreach (MapLink link in links)
                    {
                        MapNode childMapNode = ResourceMap.Self.GetMapNode(link.ResourceUrl);
                        MapLink[] childMapLinks = TargetLinks(childMapNode).ToArray();

                        if ((previousChildLinks == null) || (DifferentChildren(previousChildLinks, childMapLinks)))
                        {
                            groupChild = group.AppendChild("");
                            AddChildren(childMapNode, childMapLinks, groupChild);
                        }
                        SENode node = CreateNode(link.ResourceUrl);
                        groupChild.Nodes.Add(node);
                        previousChildLinks = childMapLinks;
                    }
                }
            }

            SvgEditor e = new SvgEditor();
            SENodeGroup rootGroup = new SENodeGroup("root");
            SENode rootNode = CreateNode(this.BreastRadiologyReport);
            rootGroup.Nodes.Add(rootNode);
            MapNode mapNode = ResourceMap.Self.GetMapNode(this.BreastRadiologyReport);
            MapLink[] links = TargetLinks(mapNode).ToArray();
            AddChildren(mapNode, links, rootGroup);
            e.Render(rootGroup);
            e.Save(Path.Combine(outputDir, "BreastRadOverview.svg"));
        }

        void SaveAll()
        {
            foreach (KeyValuePair<string, Resource> resourceItem in this.resources)
            {
                resourceItem.Value.SaveJson(resourceItem.Key);
                this.fc.Mark(resourceItem.Key);
            }

            foreach (SDefEditor ce in this.editors.Values)
            {
                this.fc.Mark(ce.Write());
            }
        }
    }
}
