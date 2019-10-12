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
    public partial class ResourcesMaker : ConverterBase
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
        //String breastBodyLocation;

        String CreateUrl(String name)
        {
            return $"http://hl7.org/fhir/us/breast-radiology/StructureDefinition/{name}";
        }

        public ResourcesMaker(String resourceDir)
        {
            this.resourceDir = resourceDir;
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

        SDefEditor CreateAbnormalityBooleanValue(String name,
            String title,
            Markdown description)
        {
            SDefEditor retVal = this.CreateObservationEditor(name, title);
            retVal
                .Description(description)
                ;

            retVal.Select("Observation.value[x]")
                .Type("boolean")
                ;
            return retVal;
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



        public void CreateResources()
        {
            fc.Add(this.resourceDir);

            String abnMassShape = AbnormalityMassShape();
            //this.breastBodyLocation = this.BreastBodyLocation();

            //
            // Mammo
            //
            String abnMammo;
            {
                String massMargin = AbnormalityMammographyMassMargin();
                String massDensity = AbnormalityMammographyMassDensity();
                String breastDensity = AbnormalityMammographyBreastDensity();
                String mass = AbnormalityMammographyMass(abnMassShape, massMargin, massDensity);
                //String calcType = AbnormalityMammographyCalcificationType();
                //String calcDist = AbnormalityMammographyCalcificationDistribution();
                //String calc = AbnormalityMammographyCalcifications(calcType, calcDist);
                //String archDist = AbnormalityMammographyArchitecturalDistortion();
                //String assymetries = AbnormalityMammographyAssymetries();
                abnMammo = AbnormalityMammography(breastDensity, mass, /*calc*/ null, /*archDist*/ null, /*assymetries*/ null);
            }
            //
            // MRI
            //
            String abnMRI = AbnormalityMRI();


            //
            // Ultra Sound
            //
            String abnUltraSound = AbnormalityUltraSound();


            ObservationTarget[] abnormalityTargets = new ObservationTarget[]
            {
                new ObservationTarget(abnMammo, 0, "*"),
                new ObservationTarget(abnMRI, 0, "*"),
                new ObservationTarget(abnUltraSound, 0, "*")
            };

            String patientRiskUrl = SectionPatientRisk();
            String patientHistoryUrl = SectionPatientHistory();
            String findingsLeftUrl = SectionFindingsLeftBreast(abnormalityTargets);
            String findingsRightUrl = SectionFindingsRightBreast(abnormalityTargets);
            String findingsUrl = SectionFindings(findingsLeftUrl, findingsRightUrl);
            String rootUrl = SectionRoot(patientHistoryUrl, findingsUrl, patientRiskUrl);
            BreastRadiologyReport(rootUrl);

            SaveAll();
            fc.Dispose();
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
