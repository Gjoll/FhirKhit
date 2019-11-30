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
using PreFhir;

namespace BreastRadiology.XUnitTests
{
    public partial class ResourcesMaker : ConverterBase
    {
        String MammoAsymmetries
        {
            get
            {
                if (mammoAsymmetries == null)
                    CreateMammoAsymmetries();
                return mammoAsymmetries;
            }
        }
        String mammoAsymmetries = null;

        void CreateMammoAsymmetries()
        {
            String binding = this.CreateValueSet(
                    "BreastRadMemmoAsymmetries",
                    "Breast Radiology Mammography Asymmetries Observation",
                    new Markdown()
                        .Paragraph("Breast Radiology Mammography Asymmetries Observation"),
                   new ConceptDef[]
                    {
                        new ConceptDef("Asymmetry",
                            "Asymmetry",
                            "This is an area of fibroglandular-density tissue that is visible on only one mammographic projection. " +
                            "Most such findings represent summation artifact, a superimposition of normal breast structures, " +
                            "whereas those confirmed to be real lesions (by subsequent demonstration on at least one " + 
                            "more projection) may represent one of the other types of asymmetry or a mass."),
                        new ConceptDef("Asymmetry",
                            "Global Asymmetry",
                            "Global asymmetry is judged relative to the corresponding area in the contralateral breast and "+
                            "represents a large amount of fibroglandular-density tissue over a substantial portion of the "+
                            "breast (at least one quadrant). There is no mass, distorted architecture or associated suspicious "+
                            "calcifications. Global asymmetry usually represents a normal variant."),
                        new ConceptDef("FocalAsymmetry",
                            "Focal Asymmetry",
                            "A focal asymmetry is judged relative to the corresponding location in the contralateral breast, " +
                            "and represents a relatively small amount of fibroglandular-density tissue over a confined portion " +
                            "of the breast (less than one quadrant). It is visible on and has similar shape on different mammographic " +
                            "projections (hence a real finding rather than superimposition of normal breast structures), " +
                            "but it lacks the convex-outward borders and the conspicuity of a mass. Rather, the borders " +
                            "of a focal asymmetry are concave-outward, and it usually is seen to be interspersed with fat. " +
                            "Note that occasionally what is properly described as a focal asymmetry at screening (a finding visible  " +
                            "on standard MLO and CC views) is determined at diagnostic mammography to be 2 different " +
                            "findings, each visible on only 1 standard view (hence, 2 asymmetries), each of which ultimately " +
                            "is judged to represent superimposition of normal breast structures. Also, not infrequently, what " +
                            "is properly described as a focal asymmetry at screening is determined at diagnostic evaluation " +
                            "(mammography and/or ultrasound) to represent a mass."),
                        new ConceptDef("DevelopingAsymmetry",
                            "Developing Asymmetry",
                            "This is a focal asymmetry that is new, larger, or more conspicuous than on a previous examination. " +
                            "Approximately 15% of cases of developing asymmetry are found to be malignant (either " +
                            "invasive carcinoma, DCIS, or both), so these cases warrant further imaging evaluation and biopsy " +
                            "unless found to be characteristically benign (e.g., simple cyst at directed ultrasound). Absence " +
                            "of a sonographic correlate, especially for a small (< 1 cm) developing asymmetry, should not avert biopsy.")
                    }
                )
                .Url;

            SDefEditor e = this.CreateObservationEditor("BreastRadMammoAsymmetries",
                        "Breast Radiology Mammography Asymmetries Observation",
                        new string[] {"Asymmetries"},
                        out mammoAsymmetries)
                    .Description(new Markdown()
                        .Paragraph("Breast Radiology Mammography Asymmetries Observation")
                        .MissingObservation("an asymmetry")
                        .BiradHeader()
                        .MarkedDown("The several types of asymmetry involve a spectrum of mammographic findings that represent")
                        .MarkedDown("unilateral deposits of fibroglandular tissue not conforming to the definition of a radiodense mass.")
                        .MarkedDown("The asymmetry, unlike a mass, is visible on only 1 mammographic projection. The other 3 types of")
                        .MarkedDown("asymmetry, although visible on more than 1 projection, have concave-outward borders and usu-")
                        .MarkedDown("ally are seen to be interspersed with fat, whereas a radiodense mass displays completely or partially")
                        .MarkedDown("convex-outward borders and appears to be denser in the center than at the periphery.")
                        .BiradFooter()
                        )
                    .AddFragRef(this.ObservationCodedValueFragment)
                    ;

            {
                ProfileTarget[] targets = new ProfileTarget[]
                {
                    new ProfileTarget(this.MammoAssociatedFeatures, 0, "1", false)
                };
                e.Find("hasMember").SliceByUrl(targets);
                e.MapNode.AddProfileTargets(targets);
            }
            e.Select("value[x]")
                .Type("CodeableConcept")
                .Binding(binding, BindingStrength.Required)
                ;
        }
    }
}
