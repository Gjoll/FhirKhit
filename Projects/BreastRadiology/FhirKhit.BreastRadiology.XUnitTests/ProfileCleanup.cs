using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace FhirKhit.BreastRadiology
{
    public class ProfileCleanUp : ConverterBase
    {
        const String ProfileVersion = "0.0.2";
        const PublicationStatus ProfileStatus = PublicationStatus.Draft;

        FhirDateTime date = new FhirDateTime(2019, 11, 1);

        public ProfileCleanUp()
        {
        }

        public void Clean(String resourceDir)
        {
            String FixName(String path, String prefix)
            {
                String retVal = Path.GetFileNameWithoutExtension(path);
                retVal = $"{prefix}{retVal.Substring(prefix.Length)}";
                return retVal;
            }

            String Rename(String filePath, String prefix)
            {
                String dir = Path.GetDirectoryName(filePath);
                String name = Path.GetFileName(filePath);
                name = name.Replace("-brr-", "-");
                if (name.StartsWith(prefix))
                    return filePath;

                String newFilePath = Path.Combine(dir, $"{prefix}{name.Substring(prefix.Length)}");
                File.Move(filePath, "xxyyz");
                File.Move("xxyyz", newFilePath);
                return newFilePath;
            }

            List<ContactDetail> Contact()
            {
                List<ContactDetail> retVal = new List<ContactDetail>();
                retVal.Add(new ContactDetail());
                retVal[0].Telecom.Add(new ContactPoint
                {
                    System = ContactPoint.ContactPointSystem.Url,
                    Value = "http://www.hl7.org/Special/committees/cic"
                });
                return retVal;
            }

            void Save(Resource r, String outputPath)
            {
                r.SaveJson(outputPath);
            }

            void FixImaging(StructureDefinition sDef)
            {
                const string baseId = "Observation.category.coding:Fixed_imaging";
                var elements = sDef.Differential.Element;
                ElementDefinition eSystem = elements.FindById($"{baseId}.system");
                ElementDefinition eCode = elements.FindById($"{baseId}.code");

                if (eSystem == null)
                    return;

                ElementDefinition category = elements.FindById("Observation.category");
                category.Slicing = new ElementDefinition.SlicingComponent();
                category.Slicing.Discriminator.Add(new ElementDefinition.DiscriminatorComponent
                {
                    Type = ElementDefinition.DiscriminatorType.Value,
                    Path = "coding"
                });

                String system = ((FhirUri)eSystem.Fixed).Value;
                String code = ((Code)eCode.Fixed).Value;

                elements.RemoveById("Observation.category.coding")
                    .RemoveById(baseId)
                    .RemoveById($"{baseId}.system")
                    .RemoveById($"{baseId}.code")
                    ;

                ElementDefinition coding = new ElementDefinition
                {
                    ElementId = "Observation.category.coding",
                    Path = "Observation.category.coding"
                };
                ElementDefinition codingSlice = new ElementDefinition
                {
                    ElementId = "Observation.category.coding:Imaging",
                    Path = "Observation.category.coding",
                    SliceName = "Imaging",
                    Pattern = new Coding(system, code)
                };

                elements.InsertAfter(category, coding, codingSlice);
            }

            void CleanObservation(StructureDefinition sDef)
            {
                sDef.Differential.Element
                    //.RemoveById("Observation.performer")
                    .RemoveById("Observation.basedOn")
                    .RemoveByPath("Observation.bodySite.extension")
                    .RemoveByPath("Observation.encounter")
                    //.RemoveById("Observation.focus")
                    //.RemoveById("Observation.partOf")
                    //.RemoveById("Observation.note")
                    //.RemoveById("Observation.effective[x]")
                    //.RemoveById("Observation.device")
                    //.RemoveById("Observation.referenceRange")
                    //.RemoveById("Observation.referenceRange.type")
                    //.RemoveById("Observation.referenceRange.appliesTo")
                    //.RemoveById("Observation.derivedFrom")
                    //.RemoveById("Observation.component.value[x]")
                    //.RemoveById("Observation.component.referenceRange")
                    //.RemoveById("Observation.component.referenceRange.type")
                    //.RemoveById("Observation.component.referenceRange.appliesTo")
                    ;

                if (
                    (sDef.Name != "BreastRadiologyAbnormality") &&
                    (sDef.Name != "BreastRadiologyObservation")
                    )
                {
                    //sDef.Differential.Element
                    //    .RemoveById("Observation.bodySite")
                    //    .RemoveById("Observation.bodySite.extension")
                    //    ;
                }

                ElementDefinition s = sDef.Differential.Element.FindById("Observation.category");
                if (
                    (s != null) &&
                    (s.Slicing != null)
                    )
                {
                    s.Slicing.Rules = ElementDefinition.SlicingRules.OpenAtEnd;
                }
                FixImaging(sDef);
            }

            void Clean(StructureDefinition sDef)
            {
                String text = sDef.Text.Div;
                Int32 mapIndex = text.IndexOf("<p><b>Mapping Summary</b>");
                if (mapIndex > 0)
                    sDef.Text.Div = text.Substring(0, mapIndex) + "</div>";
                sDef.Mapping = null;
                SDefCleaner c = new SDefCleaner(this);
                c.CleanupDifferential(sDef);
                if (sDef.Type == "Observation")
                    CleanObservation(sDef);
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
                            String outputPath = Rename(file, typeName);
                            String fixedName = FixName(file, typeName);
                            String htmlPage = $"{fixedName}.html";
                            structureDefinition.Date = this.date.Value;
                            structureDefinition.Version = ProfileVersion;
                            structureDefinition.Status = ProfileStatus;
                            structureDefinition.Contact = Contact();
                            structureDefinition.Snapshot = null;
                            Clean(structureDefinition);
                            Save(structureDefinition, outputPath);
                        }
                        break;

                    case CodeSystem codeSystem:
                        {
                            String typeName = "CodeSystem";
                            String outputPath = Rename(file, typeName);
                            String fixedName = FixName(file, typeName);
                            String htmlPage = $"{fixedName}.html";
                            codeSystem.Date = this.date.Value;

                            codeSystem.Version = ProfileVersion;

                            codeSystem.Status = ProfileStatus;

                            codeSystem.Contact = Contact();

                            Save(codeSystem, outputPath);
                        }
                        break;

                    case ValueSet valueSet:
                        {
                            String typeName = "ValueSet";
                            String outputPath = Rename(file, typeName);
                            String fixedName = FixName(file, typeName);
                            String htmlPage = $"{fixedName}.html";
                            valueSet.Date = this.date.Value;

                            valueSet.Version = ProfileVersion;

                            valueSet.Status = ProfileStatus;

                            valueSet.Contact = Contact();

                            Save(valueSet, outputPath);
                        }
                        break;

                    default:
                        throw new NotImplementedException($"Unknown resource type '{file}'");
                }

            }
        }
    }
}
