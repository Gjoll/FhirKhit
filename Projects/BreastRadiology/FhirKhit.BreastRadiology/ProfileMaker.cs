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
    public class ProfileMaker : ConverterBase
    {
        const String ProfileVersion = "0.0.2";
        const PublicationStatus ProfileStatus = PublicationStatus.Draft;

        ProfilesEditor profilesEditor;
        ExamplesEditor examplesEditor;
        ExtensionsEditor extensionsEditor;
        CodeSystemsEditor codeSystemsEditor;
        ValueSetsEditor valueSetsEditor;

        String outputDir;
        String resourceDir => Path.Combine(this.outputDir, "resources");
        String IgPath => Path.Combine(outputDir, "IG.json");
        String ImpGuidePath => Path.Combine(outputDir, "Resources", "ig.xml");

        const String Loinc = "http://loinc.org";
        const String DiagSvcSects = "http://terminology.hl7.org/CodeSystem/v2-0074";

        const String ObservationUrl = "http://hl7.org/fhir/StructureDefinition/Observation";
        const String DiagnosticReportUrl = "http://hl7.org/fhir/StructureDefinition/DiagnosticReport";
        const String ExtensionUrl = "http://hl7.org/fhir/StructureDefinition/Extension";
        const String MedicationRequestUrl = "http://hl7.org/fhir/StructureDefinition/MedicationRequest";
        const String ServiceRequestUrl = "http://hl7.org/fhir/StructureDefinition/ServiceRequest";

        FhirDateTime date = new FhirDateTime(2019, 11, 1);
        ImplementationGuide implementationGuide;
        IGEditor igEditor;

        List<SDefEditor> editors = new List<SDefEditor>();

        String CreateUrl(String name)
        {
            return $"http://hl7.org/fhir/us/breast-radiology/StructureDefinition/{name}";
        }

        public ProfileMaker(String outputDir)
        {
            this.outputDir = outputDir;
        }

        SDefEditor CreateEditor(String name, String baseUrl)
        {
            SDefEditor retVal = new SDefEditor(baseUrl, this.resourceDir)
                .Name(name)
                .Url(CreateUrl(name))
                .Status(ProfileStatus)
                .Title(name)
                .Publisher("Hl7 - Clinical Interoperability Council")
                .ContactUrl("http://www.hl7.org/Special/committees/cic")
                .Date(date)
                .Derivation(StructureDefinition.TypeDerivationRule.Constraint)
                .Abstract(false)
                .Type(baseUrl.LastUriPart())
                .Version(ProfileVersion)
                ;

            this.editors.Add(retVal);
            return retVal;
        }

        String CreatePriorReportsExtension(String brrDiagnosticReportUrl)
        {
            SDefEditor e = CreateEditor("PriorReports", ExtensionUrl)
                .Description("Breast Radiology Prior Diagnostic Report extension")
                .Kind(StructureDefinition.StructureDefinitionKind.ComplexType)
                .Context()
                ;

            e.Select("extension").Zero();
            e.Select("url")
                .Type("uri")
                .Fixed(new FhirUri(e.SDef.Url));

            String[] targets = new string[]
            {
                brrDiagnosticReportUrl
            };
            e.Select("value[x]")
                .Type("Reference", null, targets)
                .Single()
                ;
            this.AddIGStructureDefinition(e, true);
            return e.SDef.Url;
        }

        String CreateRecommendationsExtension()
        {
            SDefEditor e = CreateEditor("Recommendations", ExtensionUrl)
                .Description("Breast Radiology Diagnostic Report recommendations section extension")
                .Kind(StructureDefinition.StructureDefinitionKind.ComplexType)
                .Context()
                ;

            e.Select("extension").Zero();
            e.Select("url")
                .Type("uri")
                .Fixed(new FhirUri(e.SDef.Url));

            String[] targets = new string[]
            {
                MedicationRequestUrl,
                ServiceRequestUrl
            };
            e.Select("value[x]")
                .Type("Reference", null, targets)
                .Single()
                ;
            this.AddIGStructureDefinition(e, true);
            return e.SDef.Url;
        }

        void CreateBreastRadiologyReport()
        {
            SDefEditor e = CreateEditor("BreastRadiologyReport", DiagnosticReportUrl)
                .Description(
                    "Breast Radiology Diagnostic Report." +
                    "<br>" +
                    "This diagnostic report is the base of the Breast Radiology Report, " +
                    " and contains a summary of the report findings." +
                    "<br>" +
                    "Detailed information about the results of the exam are contained in the " +
                    "Breast Radiology Observation linked to by the 'result' field."
                )
                .Kind(StructureDefinition.StructureDefinitionKind.Resource)
                ;

            String recommendationsExtensionUrl = CreateRecommendationsExtension();
            String priorReportsExtensionUrl = CreatePriorReportsExtension(e.SDef.Url);

            e.Select("code").Pattern = new CodeableConcept(Loinc, "10193-1");
            e.Select("category").Pattern = new CodeableConcept(Loinc, "10193-1");
            e.Select("specimen").Zero();
            e.Select("conclusion").Single();
            e.Select("conclusionCode").Single();
            e.SimpleExtension("Recommendations", recommendationsExtensionUrl)
                .Short("Recommendations for future care")
                .Definition("Recommendations for future care")
                .ZeroToMany();
            e.SimpleExtension("PriorReports", priorReportsExtensionUrl)
                .Short("Recommendations for future care")
                .Definition("Recommendations for future care")
                .ZeroToMany();

            e.Select("result")
                .Single()
                .Type("Reference", null, new String[] { ObservationUrl })
                ;

            this.AddIGStructureDefinition(e, false);
        }

        void AddIGStructureDefinition(SDefEditor e, bool extensionFlag)
        {
            StructureDefinition sDef = e.SDef;

            String htmlName = $"StructureDefinition-{sDef.Name}.html";

            this.AddIGResource($"StructureDefinition/{sDef.Name}", sDef.Name, false);
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

        void AddIGResource(String path,
            String name,
            bool example)
        {
            this.implementationGuide.Definition.Resource.Add(new ImplementationGuide.ResourceComponent
            {
                Reference = new ResourceReference(path),
                Name = name,
                Example = new FhirBoolean(example)
            });
        }

        public void SaveAll()
        {
            foreach (SDefEditor ce in this.editors)
            {
                StructureDefinition sDef = ce.SDef;
                SnapshotCreator.Create(sDef);
                ce.Write();
            }

            implementationGuide.SaveXml(this.ImpGuidePath);
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
            this.igEditor.dependencyList?.Clear();
            {
                String xmlText = File.ReadAllText($"{this.ImpGuidePath}.template");
                FhirXmlParser parser = new FhirXmlParser();
                this.implementationGuide = (ImplementationGuide)parser.Parse(xmlText, typeof(Resource));
                this.implementationGuide.Definition.Resource.Clear();
            }
        }

        public void AddResources(String resourceDir)
        {
            String FixName(String path, String prefix)
            {
                String retVal = Path.GetFileNameWithoutExtension(path);
                retVal = $"{prefix}{retVal.Substring(prefix.Length)}";
                return retVal;
            }

            void Rename(String filePath, String prefix)
            {
                String dir = Path.GetDirectoryName(filePath);
                String name = Path.GetFileName(filePath);
                name = name.Replace("-brr-", "-");
                if (name.StartsWith(prefix))
                    return;

                String newFilePath = Path.Combine(dir, $"{prefix}{name.Substring(prefix.Length)}");
                File.Move(filePath, "xxyyz");
                File.Move("xxyyz", newFilePath);
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

            void Save(Resource r, String fileName)
            {
                String outputPath = Path.Combine(this.resourceDir, fileName);
                r.SaveJson(outputPath);
            }

            void Clean(StructureDefinition sDef)
            {
                SDefCleaner c = new SDefCleaner(this);
                c.CleanupDifferential(sDef);
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
                            Rename(file, typeName);
                            String fixedName = FixName(file, typeName);
                            String htmlPage = $"{fixedName}.html";
                            structureDefinition.Date = this.date.Value;
                            structureDefinition.Version = ProfileVersion;
                            structureDefinition.Status = ProfileStatus;
                            structureDefinition.Contact = Contact();
                            structureDefinition.Snapshot = null;
                            Clean(structureDefinition);
                            Save(structureDefinition, $"{fixedName}.json");
                            this.AddIGResource($"{typeName}/{structureDefinition.Name}", structureDefinition.Name, false);
                            this.igEditor.AddResource($"{typeName}/{structureDefinition.Name}",
                                htmlPage);
                        }
                        break;

                    case CodeSystem codeSystem:
                        {
                            String typeName = "CodeSystem";
                            Rename(file, typeName);
                            String fixedName = FixName(file, typeName);
                            String htmlPage = $"{fixedName}.html";
                            codeSystem.Date = this.date.Value;
                            codeSystem.Version = ProfileVersion;
                            codeSystem.Status = ProfileStatus;
                            codeSystem.Contact = Contact();
                            Save(codeSystem, $"{fixedName}.json");
                            this.AddIGResource($"{typeName}/{codeSystem.Name}", codeSystem.Name, false);
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
                            Rename(file, typeName);
                            String fixedName = FixName(file, typeName);
                            String htmlPage = $"{fixedName}.html";
                            valueSet.Date = this.date.Value;
                            valueSet.Version = ProfileVersion;
                            valueSet.Status = ProfileStatus;
                            valueSet.Contact = Contact();
                            Save(valueSet, $"{fixedName}.json");
                            this.AddIGResource($"{typeName}/{valueSet.Name}", valueSet.Name, false);
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

        public void CreateProfiles()
        {
            //CreateBreastRadiologyReport();
        }
    }
}
