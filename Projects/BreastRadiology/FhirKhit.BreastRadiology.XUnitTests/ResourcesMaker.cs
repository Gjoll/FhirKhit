using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace FhirKhit.BreastRadiology.XUnitTests
{
    public class ResourcesMaker : ConverterBase
    {
        const String ProfileVersion = "0.0.2";
        const PublicationStatus ProfileStatus = PublicationStatus.Draft;

        const String Loinc = "http://loinc.org";

        const String ObservationUrl = "http://hl7.org/fhir/StructureDefinition/Observation";
        const String DiagnosticReportUrl = "http://hl7.org/fhir/StructureDefinition/DiagnosticReport";
        const String ExtensionUrl = "http://hl7.org/fhir/StructureDefinition/Extension";
        const String MedicationRequestUrl = "http://hl7.org/fhir/StructureDefinition/MedicationRequest";
        const String ServiceRequestUrl = "http://hl7.org/fhir/StructureDefinition/ServiceRequest";

        const String contactUrl = "http://www.hl7.org/Special/committees/cic";

        FileCleaner fc = new FileCleaner();

        String resourceDir;
        FhirDateTime date = new FhirDateTime(2019, 11, 1);
        List<SDefEditor> editors = new List<SDefEditor>();

        String rootUrl;
        String findingsUrl;
        String findingsRightUrl;
        String findingsLeftUrl;
        String patientHistoryUrl;
        String patientRiskUrl;
        String abnormalityUltraSoundd;
        String abnormalityMRI;
        String abnormalityMammo;
        String massShape;

        String CreateUrl(String name)
        {
            return $"http://hl7.org/fhir/us/breast-radiology/StructureDefinition/{name}";
        }

        public ResourcesMaker(String resourceDir)
        {
            this.resourceDir = resourceDir;
        }

        void CreateSections()
        {
            //$ Fix me. Incorrect method!!!
            this.abnormalityMRI = this.CreateAbnormality(
                "BreastRadiologyAbnormalityMRI",
                "Breast Radiology Abnormality (MRI)",
                new Markdown().Paragraph("MRI Breast Abnormality Observation"),
                "http://snomed.info/sct",
                "115341008")
                .SDef.Url;

            //$ Fix me. Incorrect method!!!
            this.abnormalityUltraSoundd = this.CreateAbnormality(
                "BreastRadiologyAbnormalityUltraSound",
                "Breast Radiology Abnormality (UltraSound)",
                new Markdown().Paragraph("Ultra Sound Breast Abnormality Observation"),
                "http://snomed.info/sct",
                "115341008")
                .SDef.Url;

            ObservationTarget[] abnormalityTargets = new ObservationTarget[]
            {
                new ObservationTarget(abnormalityMammo, 0, "*"),
                new ObservationTarget(abnormalityMRI, 0, "*"),
                new ObservationTarget(abnormalityUltraSoundd, 0, "*")
            };

            this.patientRiskUrl = CreateObservationSection(
                "BreastRadiologySectionPatientRisk",
                "Breast Radiology Patient Risk Section",
                new Markdown().Paragraph("Patient Risk Section"))
                .SDef.Url;

            this.patientHistoryUrl = CreateObservationSection(
                "BreastRadiologySectionPatientHistory",
                "Breast Radiology Patient History Section",
                new Markdown().Paragraph("Patient History Section"))
                .SDef.Url;

            this.findingsLeftUrl = CreateObservationSection(
                "BreastRadiologySectionFindingsLeftBreast",
                "Breast Radiology Findings Left Breast",
                new Markdown().Paragraph("Findings Left Breast Section"))
                .SliceByUrl("Observation.hasMember", abnormalityTargets)
                .SDef.Url;

            this.findingsRightUrl = CreateObservationSection(
                "BreastRadiologySectionFindingsRightBreast",
                "Breast Radiology Findings Right Breast",
                new Markdown().Paragraph("Findings Right Breast Section"))
                .SliceByUrl("Observation.hasMember", abnormalityTargets)
                .SDef.Url;

            this.findingsUrl = CreateObservationSection(
                "BreastRadiologySectionFindings",
                "Breast Radiology Findings",
                new Markdown().Paragraph("Findings Section"))
                .SliceByUrl("Observation.hasMember",
                    new ObservationTarget[]
                    {
                        new ObservationTarget(findingsLeftUrl, 1, "1"),
                        new ObservationTarget(findingsRightUrl, 1, "1")
                    })
                .SDef.Url;

            this.rootUrl = CreateObservationSection(
                "BreastRadiologySectionRoot",
                "Breast Radiology Root Section",
                new Markdown().Paragraph("Root Section"))
                .SliceByUrl("Observation.hasMember",
                new ObservationTarget[]
                    {
                        new ObservationTarget(patientHistoryUrl, 1, "1"),
                        new ObservationTarget(patientRiskUrl, 1, "1")
                    })
                .FixedCodeSlice("Observation.code", "observationCode", Loinc, "10193-1")
                .SDef.Url;
        }

        public void CreateResources()
        {
            fc.Add(this.resourceDir);

            CreateCommon();
            CreateMammo();
            CreateSections();
            CreateBreastRadiologyReport(rootUrl);
            SaveAll();
            fc.Dispose();
        }

        SDefEditor CreateEditor(String name, String title, String baseUrl)
        {
            if (name.Contains(" "))
                throw new Exception("Structure Def name can not contains spaces");

            SDefEditor retVal = new SDefEditor(baseUrl, this.resourceDir)
                .Name(name)
                .Url(CreateUrl(name))
                .Status(ProfileStatus)
                .Title(title)
                .Publisher("Hl7-Clinical Interoperability Council")
                .ContactUrl(contactUrl)
                .Date(date)
                .Derivation(StructureDefinition.TypeDerivationRule.Constraint)
                .Abstract(false)
                .Type(baseUrl.LastUriPart())
                .Version(ProfileVersion)
                .Kind(StructureDefinition.StructureDefinitionKind.Resource)
                ;

            this.editors.Add(retVal);
            return retVal;
        }

        SDefEditor CreateObservationEditor(String name, String title)
        {
            SDefEditor retVal = this.CreateEditor(name, title, ObservationUrl);
            retVal.Select("Observation.subject").Single();
            retVal.Select("Observation.component").Zero();
            retVal.Select("Observation.basedOn").Zero();
            retVal.Select("Observation.derivedFrom").Zero();
            retVal.Select("Observation.partOf").Zero();
            retVal.Select("Observation.focus").Zero();
            CreateCategorySlice(retVal, "category");

            return retVal;
        }

        void CreateCategorySlice(SDefEditor sDefEditor, String path)
        {
            var eDef = sDefEditor.Find(path);
            eDef.ElementDefinition.Min(1);
            sDefEditor.FixedCodeSlice(eDef,
                "category",
                "http://terminology.hl7.org/CodeSystem/observation-category",
                "imaging");
        }

        SDefEditor CreateObservationSection(String name,
            String title,
            Markdown description)
        {
            SDefEditor e = CreateObservationEditor(name, title)
                .Description(description)
                ;
            e.Select("Observation.value[x]").Zero();
            e.Select("Observation.specimen").Zero();
            e.Select("Observation.device").Zero();
            e.Select("Observation.referenceRange").Zero();

            e.Select("Observation.interpretation").Zero();
            e.Select("Observation.note").Zero();
            e.Select("Observation.bodySite").Zero();
            e.Select("Observation.method").Zero();
            return e;
        }

        SDefEditor CreateAbnormalityCodedValue(String name,
            String title,
            Markdown description,
            String binding)
        {
            SDefEditor retVal = this.CreateObservationEditor(name, title);
            retVal
                .Description(description)
                ;

            retVal.Select("Observation.value[x]")
                .Type("CodeableConcept")
                .Binding(binding, BindingStrength.Required)
                ;
            return retVal;
        }

        SDefEditor CreateAbnormality(String name, String title,
            Markdown description,
            String methodCodeSet,
            String method)
        {
            SDefEditor e = CreateObservationEditor(name, title)
                .Description(description)
                ;

            e.Select("Observation.value[x]").Zero();
            e.Select("Observation.specimen").Zero();
            e.Select("Observation.referenceRange").Zero();
            e.Select("Observation.interpretation").Zero();
            e.Select("Observation.note").Zero();
            // todo: Add body site info.
            //e.Select("Observation.bodySite").Zero();

            e.Find("Observation.method")
             .FixedCodeSlice("method",
                             methodCodeSet,
                             method)
             .Min(1)
             ;

            return e;
        }

        List<ContactDetail> Contact()
        {
            ContactDetail cd = new ContactDetail();
            cd.Telecom.Add(new ContactPoint
            {
                System = ContactPoint.ContactPointSystem.Url,
                Value = contactUrl
            });

            List<ContactDetail> retVal = new List<ContactDetail>();
            retVal.Add(cd);
            return retVal;
        }

        String CreateValueSet(String name,
            String title,
            Markdown description,
            IEnumerable<String> codes)
        {
            CodeSystem cs = new CodeSystem
            {
                Id = $"{name}CS",
                Url = $"http://hl7.org/fhir/us/breast-radiology/CodeSystem/{name}CS",
                Version = "ProfileVersion",
                Name = $"{name}CS",
                Title = title,
                Date = date.ToString(),
                Status = ProfileStatus,
                Publisher = "Hl7-Clinical Interoperability Council",
                Contact = Contact(),
                Description = description,
                CaseSensitive = true,
                Content = CodeSystem.CodeSystemContentMode.Complete,
                Count = codes.Count()
            };

            ValueSet vs = new ValueSet
            {
                Id = $"{name}VS",
                Url = $"http://hl7.org/fhir/us/breast-radiology/CodeSystem/{name}VS",
                Version = "ProfileVersion",
                Name = $"{name}VS",
                Title = title,
                Date = date.ToString(),
                Status = ProfileStatus,
                Publisher = "Hl7-Clinical Interoperability Council",
                Contact = Contact(),
                Description = description
            };


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

            Save(cs, Path.Combine(this.resourceDir, $"CodeSystem-{name}CS.json"));
            Save(vs, Path.Combine(this.resourceDir, $"ValueSet-{name}VS.json"));
            return vs.Url;
        }

        public void Save(Resource r, String path)
        {
            r.SaveJson(path);
            fc.Mark(path);
        }

        void CreateCommon()
        {
            {
                String binding = CreateValueSet(
                    "BreastRadiologyAbnormalityMassShape",
                    "Breast Radiology Abnormality Mass Shape",
                    new Markdown()
                        .Paragraph("Breast Radiology Mass Shape"),
                    new String[]
                    {
                "a. Oval",
                "b. Round",
                "c. Irregular"
                    });

                this.massShape = this.CreateAbnormalityCodedValue(
                    "BreastRadiologyAbnormalityMassShape",
                    "Breast Radiology Abnormality Mass Shape",
                    new Markdown().Paragraph("Breast Radiology Abnormality Mass Shape Observation"),
                    binding)
                    .SDef.Url;
            }
        }

        void CreateMammo()
        {
            String massMargin;
            String massDensity;
            String mammoBreastDensity;
            String mammoMass;

            {
                String binding = CreateValueSet(
                    "BreastRadiologyAbnormalityMammographyMassMargin",
                    "BreastRadiology Abnormality Mammography Mass Margin",
                    new Markdown()
                        .Paragraph("Breast Radiology Mass Margin (Mammography)"),
                    new String[]
                    {
                            "a. Circumscribed",
                            "b. Obscured",
                            "c. Microlobulated",
                            "d. Indistinct",
                            "e. Spiculated"
                    });

                massMargin = this.CreateAbnormalityCodedValue(
                    "BreastRadiologyAbnormalityMammographyMassMargin",
                    "Breast Radiology Abnormality Mass Margin (Mammography)",
                    new Markdown().Paragraph("Breast Radiology Abnormality Mass Margin Observation (Mammography)"),
                    binding)
                    .SDef.Url;
            }

            {
                String binding = CreateValueSet(
                    "BreastRadiologyAbnormalityMammographyMassDensity",
                    "BreastRadiology Abnormality Mammography Mass Density",
                    new Markdown()
                        .Paragraph("Breast Radiology Mass Density (Mammography)"),
                    new String[]
                    {
                        "a. High density",
                        "b. Equal density",
                        "c. Low density",
                        "d. Fat-containing"
                    });

                massDensity = this.CreateAbnormalityCodedValue(
                    "BreastRadiologyAbnormalityMammographyMassDensity",
                    "Breast Radiology Abnormality Mass Density (Mammography)",
                    new Markdown().Paragraph("Breast Radiology Abnormality Mass Density Observation (Mammography)"),
                    binding)
                    .SDef.Url;
            }
            {
                String binding = CreateValueSet(
                    "BreastComposition",
                    "Breast Composition",
                    new Markdown()
                        .Paragraph("Mammography Breast Composition"),
                    new String[]
                    {
                        "a. The breasts are almost entirely fatty",
                        "b. There are scattered areas of fibroglandular density",
                        "c. The breasts are heterogeneously dense, which may obscure detection of small masses",
                        "d. The breasts are extremely dense, which lowers the sensitivity of mammography"
                    });

                mammoBreastDensity = this.CreateAbnormalityCodedValue(
                    "BreastRadiologyAbnormalityMammographyBreastDensity",
                    "Breast Radiology Abnormality Breast Density (Mammography)",
                    new Markdown().Paragraph("Mammography Breast Abnormality Breast Density Observation"),
                    binding)
                    .SDef.Url;

                mammoMass = this.CreateObservationSection(
                    "BreastRadiologyMammographyMass",
                    "Breast Radiology Mammography Mass Observation",
                    new Markdown()
                        .Paragraph("Breast Radiology Mammography Mass Observation")
                        .Paragraph("This observation has the following three member observations")
                        .List("Shape", "Margin", "Density")
                    )
                    .SliceByUrl("Observation.hasMember",
                        new ObservationTarget[]
                        {
                            new ObservationTarget(this.massShape, 1, "1"),
                            new ObservationTarget(massMargin, 1, "1"),
                            new ObservationTarget(massDensity, 1, "1")
                        })
                    .SDef.Url;
            }

            //$ Fix me. Incorrect method!!!
            this.abnormalityMammo = this.CreateAbnormality(
                "BreastRadiologyAbnormalityMammography",
                "Breast Radiology Abnormality (Mammography)",
                new Markdown().Paragraph("Mammography Breast Abnormality Observation"),
                "http://snomed.info/sct",
                "115341008")
                .SliceByUrl("Observation.hasMember",
                    new ObservationTarget[]
                    {
                        new ObservationTarget(mammoBreastDensity, 1, "1"),
                        new ObservationTarget(mammoMass, 0, "*")
                    })
                .SDef.Url;
        }

        void CreateBreastRadiologyReport(String rootObservationUrl)
        {
            String CreatePriorReportsExtension(String brrDiagnosticReportUrl)
            {
                SDefEditor e2 = CreateEditor("BreastRadiologyPriorReports", "Prior Reports", ExtensionUrl)
                    .Description(new Markdown()
                        .Paragraph("Prior Diagnostic Report extension")
                        )
                    .Kind(StructureDefinition.StructureDefinitionKind.ComplexType)
                    .Context()
                    ;

                e2.Select("extension").Zero();
                e2.Select("url")
                    .Type("uri")
                    .Fixed(new FhirUri(e2.SDef.Url));

                e2.Select("value[x]")
                    .TypeReference(brrDiagnosticReportUrl)
                    .Single()
                    ;
                return e2.SDef.Url;
            }

            String CreateRecommendationsExtension()
            {
                SDefEditor e3 = CreateEditor("BreastRadiologyRecommendations", "Recommendations", ExtensionUrl)
                    .Description(new Markdown()
                        .Paragraph("Diagnostic Report recommendations section extension")
                    )
                    .Kind(StructureDefinition.StructureDefinitionKind.ComplexType)
                    .Context()
                    ;

                e3.Select("extension").Zero();
                e3.Select("url")
                    .Type("uri")
                    .Fixed(new FhirUri(e3.SDef.Url));

                e3.Select("value[x]")
                    .TypeReference(MedicationRequestUrl, ServiceRequestUrl)
                    .Single()
                    ;
                return e3.SDef.Url;
            }
            SDefEditor e = CreateEditor("BreastRadiologyReport", "Breast Radiology Report", DiagnosticReportUrl)
                .Description(new Markdown()
                    .Paragraph("Breast Radiology Diagnostic Report.")
                    .Paragraph("This diagnostic report has links to the data that comprise a Breast Radiology Report, including")
                    .List("references to prior breast radiology reports for this patient",
                          "references to the observations of this report",
                          "references to the recommendations of this report",
                          "a summary of the report findings in a human readable format")
                )
                ;

            String recommendationsExtensionUrl = CreateRecommendationsExtension();
            String priorReportsExtensionUrl = CreatePriorReportsExtension(e.SDef.Url);

            e.Select("code").Pattern = new CodeableConcept(Loinc, "10193-1");
            CreateCategorySlice(e, "category");
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
                .TypeReference(rootObservationUrl)
                ;
        }

        void SaveAll()
        {
            foreach (SDefEditor ce in this.editors)
            {
                ce.SDef.Snapshot = null;
                fc.Mark(ce.Write());
            }
        }
    }
}
