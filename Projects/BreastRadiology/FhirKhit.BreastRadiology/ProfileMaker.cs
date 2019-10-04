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
    public class ProfileMaker
    {
        ProfilesEditor profilesEditor;

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
                .Status(PublicationStatus.Draft)
                .Title(name)
                .Publisher("Hl7 - Clinical Interoperability Council")
                .ContactUrl("http://www.hl7.org/Special/committees/cic")
                .Date(date)
                .Derivation(StructureDefinition.TypeDerivationRule.Constraint)
                .Abstract(false)
                .Type(baseUrl.LastUriPart())
                ;

            this.editors.Add(retVal);
            return retVal;
        }

        String CreatePriorReportsExtension(String brrDiagnosticReportUrl)
        {
            SDefEditor e = CreateEditor("PriorReports", ExtensionUrl)
                .Description("Breast Radiology Prior Diagnostic Report extension")
                .Kind(StructureDefinition.StructureDefinitionKind.ComplexType)
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
            this.AddIGStructureDefinition(e);
            return e.SDef.Url;
        }

        String CreateRecommendationsExtension()
        {
            SDefEditor e = CreateEditor("Recommendations", ExtensionUrl)
                .Description("Breast Radiology Diagnostic Report recommendations section extension")
                .Kind(StructureDefinition.StructureDefinitionKind.ComplexType)
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
            this.AddIGStructureDefinition(e);
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
                .Type("Reference", null, new String[] {ObservationUrl})
                ;

            this.AddIGStructureDefinition(e);
        }

        void AddIGStructureDefinition(SDefEditor e)
        {
            StructureDefinition sDef = e.SDef;

            String htmlName = $"StructureDefinition-{sDef.Name}.html";

            this.AddIGResource($"StructureDefinition/{sDef.Name}", sDef.Name, false);
            this.igEditor.AddResource($"StructureDefinition/{sDef.Name}",
                htmlName);
            this.profilesEditor.AddProfile(sDef.Name,
                htmlName,
                sDef.BaseDefinition,
                sDef.BaseDefinition.LastUriPart(),
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

        void SaveAll()
        {
            foreach (SDefEditor ce in this.editors)
            {
                StructureDefinition sDef = ce.SDef;
                SnapshotCreator.Create(sDef);
                ce.Write();
            }

            implementationGuide.SaveXml(this.ImpGuidePath);
            this.igEditor.Save(this.IgPath);
            this.profilesEditor.Save();
        }

        public void CreateProfiles()
        {
            this.profilesEditor = new ProfilesEditor(this.outputDir);

            this.igEditor = IGEditor.Load(this.IgPath);
            var xxx = this.igEditor.dependencyList;
            this.igEditor.dependencyList?.Clear();
            {
                String xmlText = File.ReadAllText($"{this.ImpGuidePath}.template");
                FhirXmlParser parser = new FhirXmlParser();
                this.implementationGuide = (ImplementationGuide)parser.Parse(xmlText, typeof(Resource));
                this.implementationGuide.Definition.Resource.Clear();
            }

            CreateBreastRadiologyReport();
            SaveAll();
        }
    }
}
