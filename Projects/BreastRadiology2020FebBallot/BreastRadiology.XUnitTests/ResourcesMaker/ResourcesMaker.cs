using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using PreFhir;

namespace FhirKhit.BreastRadiology.XUnitTests
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

        String resourceDir;
        FhirDateTime date = new FhirDateTime(2019, 11, 1);
        List<SDefEditor> editors = new List<SDefEditor>();
        String breastBodyLocationExtensionUrl;
        String breastBodyLocationOptionalFragmentUrl;
        String breastBodyLocationRequiredFragmentUrl;
        String categoryFragmentUrl;
        String observationSectionFragment;

        String headerFragUrl;
        string abnormalityObservationFragmentUrl;
        string abnormalityCodedValueObservationFragmentUrl;
        String observationSectionFragmentUrl;

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
            String baseDefinition)
        {
            if (name.Contains(" "))
                throw new Exception("Structure Def name can not contains spaces");

            SDefEditor retVal = new SDefEditor(baseDefinition, this.resourceDir)
                .Name(name)
                .Url(this.CreateUrl(name))
                .Title(title)
                .Derivation(StructureDefinition.TypeDerivationRule.Constraint)
                .Abstract(false)
                .Type(baseDefinition.LastUriPart())
                .Kind(StructureDefinition.StructureDefinitionKind.Resource)
                ;

            retVal.SDef.FhirVersion = FHIRVersion.N4_0_0;

            this.editors.Add(retVal);
            return retVal;
        }

        SDefEditor CreateFragment(String name,
            String title,
            String baseDefinition)
        {
            name += "-Fragment";

            SDefEditor retVal = this.CreateEditor(name,
                title,
                baseDefinition);
            retVal.SetIsFrag();
            retVal.SDef.Abstract = true;
            return retVal;
        }

        SDefEditor CreateObservationEditor(String name, String title)
        {
            SDefEditor retVal = this.CreateEditor(name,
                title,
                ObservationUrl);
            retVal.AddFragRef(this.abnormalityObservationFragmentUrl);
            return retVal;
        }

        SDefEditor CreateAbnormality(String name, String title,
            Markdown description,
            String methodCodeSet,
            String method)
        {
            SDefEditor e = this.CreateObservationEditor(name, title)
                .Description(description)
                ;

            e.Select("value[x]").Zero();
            e.Select("specimen").Zero();
            e.Select("referenceRange").Zero();
            e.Select("interpretation").Zero();
            e.Select("note").Zero();
            // todo: Add body site info.
            //e.Select("bodySite").Zero();

            e.Find("method")
             .FixedCodeSlice("method",
                             methodCodeSet,
                             method)
             .Card(1, "*")
             ;

            return e;
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
                Name = $"{name}CS",
                Title = title,
                Description = description,
                CaseSensitive = true,
                Content = CodeSystem.CodeSystemContentMode.Complete,
                Count = codes.Count()
            };
            cs.AddFragRef(this.headerFragUrl);

            ValueSet vs = new ValueSet
            {
                Id = $"{name}VS",
                Url = $"http://hl7.org/fhir/us/breast-radiology/CodeSystem/{name}VS",
                Name = $"{name}VS",
                Title = title,
                Description = description
            };
            vs.AddFragRef(this.headerFragUrl);


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

            this.Save(cs, Path.Combine(this.resourceDir, $"CodeSystem-{name}CS.json"));
            this.Save(vs, Path.Combine(this.resourceDir, $"ValueSet-{name}VS.json"));
            return vs.Url;
        }

        public void Save(Resource r, String path)
        {
            r.SaveJson(path);
            this.fc.Mark(path);
        }



        public void CreateResources()
        {
            this.fc.Add(this.resourceDir);

            this.headerFragUrl = this.HeaderFragment();

            this.categoryFragmentUrl = this.CategoryFragment();
            this.observationSectionFragment = this.ObservationSectionFragment();


            this.breastBodyLocationExtensionUrl = this.BreastBodyLocationExtension();
            this.breastBodyLocationOptionalFragmentUrl = this.BreastBodyLocationOptionalFragment();
            this.breastBodyLocationRequiredFragmentUrl = this.BreastBodyLocationRequiredFragment();

            this.abnormalityObservationFragmentUrl = this.AbnormalityObservationFragment();
            this.abnormalityCodedValueObservationFragmentUrl = this.AbnormalityObservationCodedValueFragment();
            this.observationSectionFragmentUrl = ObservationSectionFragment();

            String abnMassShape = this.AbMassShape();

            //
            // Mammo
            //
            String abnMammo;
            {
                String massMargin = this.AbMammoMassMargin();
                String massDensity = this.AbMammoMassDensity();
                String breastDensity = this.AbMammoBreastDensity();
                String mass = this.AbMammoMass(abnMassShape, massMargin, massDensity);
                String calcType = this.AbMammoCalcificationsType();
                String calcDist = this.AbMammoCalcificationDistribution();
                String calc = this.AbMammoCalcifications(calcType, calcDist);
                String archDist = this.AbMammoArchitecturalDistortion();
                String assymetries = this.AbMammoAssymetries();

                String intraMammaryLymphNode = this.AbMammoIntramammaryLymphNode();
                String skinLesion = this.AbMammoSkinLesion();
                String solitaryDilatedDuct = this.AbMammoSolitaryDilatedDuct();

                abnMammo = this.AbMammo(breastDensity, mass, calc, archDist, assymetries,
                                   intraMammaryLymphNode, skinLesion, solitaryDilatedDuct);
            }

            //
            // MRI
            //
            String abnMRI = this.AbnormalityMRI();


            //
            // Ultra Sound
            //
            String abnUltraSound = this.AbUltraSound();


            ObservationTarget[] abnormalityTargets = new ObservationTarget[]
            {
                new ObservationTarget(abnMammo, 0, "*"),
                new ObservationTarget(abnMRI, 0, "*"),
                new ObservationTarget(abnUltraSound, 0, "*")
            };

            String patientRiskUrl = this.SectionPatientRisk();
            String patientHistoryUrl = this.SectionPatientHistory();
            String findingsLeftUrl = this.SectionFindingsLeftBreast(abnormalityTargets);
            String findingsRightUrl = this.SectionFindingsRightBreast(abnormalityTargets);
            String findingsUrl = this.SectionFindings(findingsLeftUrl, findingsRightUrl);
            String rootUrl = this.SectionRoot(patientHistoryUrl, findingsUrl, patientRiskUrl);
            this.BreastRadiologyReport(rootUrl);

            this.SaveAll();
            this.fc.Dispose();
        }

        void SaveAll()
        {
            foreach (SDefEditor ce in this.editors)
            {
                this.fc.Mark(ce.Write());
            }
        }
    }
}
