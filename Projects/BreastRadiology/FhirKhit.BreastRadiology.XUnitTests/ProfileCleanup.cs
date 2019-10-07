using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

            void FixCoding(StructureDefinition sDef)
            {
                var elements = sDef.Differential.Element;
                ElementDefinition[] codeFixed = elements.FindIdStartsWith("Observation.code.coding:Fixed_").ToArray();

                if (codeFixed.Length == 0)
                    return;

                String system = ((FhirUri)codeFixed[1].Fixed).Value;
                String code = ((Code)codeFixed[2].Fixed).Value;

                elements.RemoveById("Observation.code.coding")
                    .RemoveById(codeFixed[0].ElementId)
                    .RemoveById(codeFixed[1].ElementId)
                    .RemoveById(codeFixed[2].ElementId)
                    ;

                ElementDefinition codeDef = elements.FindById("Observation.code");
                codeDef.Slicing = new ElementDefinition.SlicingComponent
                {
                    Rules = ElementDefinition.SlicingRules.OpenAtEnd
                };
                codeDef.Slicing.Discriminator.Add(new ElementDefinition.DiscriminatorComponent
                {
                    Type = ElementDefinition.DiscriminatorType.Value,
                    Path = "coding"
                });

                ElementDefinition coding = new ElementDefinition
                {
                    ElementId = "Observation.code.coding",
                    Path = "Observation.code.coding"
                };
                String sliceName = "ObservationCode";
                ElementDefinition codingSlice = new ElementDefinition
                {
                    ElementId = $"Observation.code.coding:{sliceName}",
                    Path = "Observation.code.coding",
                    SliceName = sliceName,
                    Pattern = new Coding(system, code)
                };

                elements.InsertAfter(codeDef, coding, codingSlice);
            }

            void CleanObservation(StructureDefinition sDef)
            {
                //sDef.Differential.Element
                //    .RemoveById("Observation.performer")
                //    .RemoveById("Observation.basedOn")
                //    .RemoveByPath("Observation.bodySite.extension")
                //    .RemoveByPath("Observation.encounter")
                //    .RemoveById("Observation.focus")
                //    .RemoveById("Observation.partOf")
                //    .RemoveById("Observation.note")
                //    .RemoveById("Observation.effective[x]")
                //    .RemoveById("Observation.device")
                //    .RemoveById("Observation.referenceRange")
                //    .RemoveById("Observation.referenceRange.type")
                //    .RemoveById("Observation.referenceRange.appliesTo")
                //    .RemoveById("Observation.derivedFrom")
                //    .RemoveById("Observation.component.value[x]")
                //    .RemoveById("Observation.component.referenceRange")
                //    .RemoveById("Observation.component.referenceRange.type")
                //    .RemoveById("Observation.component.referenceRange.appliesTo")
                //    ;

                //if (
                //    (sDef.Name != "BreastRadiologyAbnormality") &&
                //    (sDef.Name != "BreastRadiologyObservation")
                //    )
                //{
                //    sDef.Differential.Element
                //        .RemoveById("Observation.bodySite")
                //        .RemoveById("Observation.bodySite.extension")
                //        ;
                //}

                //ElementDefinition s = sDef.Differential.Element.FindById("Observation.category");
                //if (
                //    (s != null) &&
                //    (s.Slicing != null)
                //    )
                //{
                //    s.Slicing.Rules = ElementDefinition.SlicingRules.OpenAtEnd;
                //}
                FixCoding(sDef);
            }

            void CleanFixed(List<ElementDefinition> elements)
            {
                Int32 i = 0;
                while (i < elements.Count)
                {
                    ElementDefinition e = elements[i];
                    if (e.Fixed != null)
                    {
                    }
                    i += 1;
                }
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
                //    if (sDef.Type == "Observation")
                //        CleanObservation(sDef);
                CleanFixed(sDef.Differential.Element);
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
