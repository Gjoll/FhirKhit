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

namespace BreastRadiology.XUnitTests
{
    public partial class ResourcesMaker : ConverterBase
    {
        String FindingMammoArchitecturalDistortion
        {
            get
            {
                if (findingMammoArchitecturalDistortion == null)
                    findingMammoArchitecturalDistortion = CreateFindingMammoArchitecturalDistortion();
                return findingMammoArchitecturalDistortion;
            }
        }
        String findingMammoArchitecturalDistortion = null;

        String CreateFindingMammoArchitecturalDistortion()
        {
            SDefEditor e = this.CreateObservationEditor("BreastRadFindingMammoArchitecturalDistortion",
                        "Breast Radiology Finding Architectural Distortion (Mammography)",
                    new string[] {"Arch.","Distortion"})
                .Description(
                    new Markdown()
                        .Paragraph("Mammography Breast Finding Architectural Distortion Observation")
                        .Paragraph("If this observation is present, and dataAbsentReason is empty, then an architectural distortion was observed.")
                        .Paragraph("If this observation is present, and dataAbsentReason is not empty, then an architectural distortion " +
                                    "was not observed and dataAbsentReason contains the reason why.")
                        .BiradHeader()
                        .MarkedDown("The parenchyma is distorted with no definite mass visible. For mammography, this includes thin")
                        .MarkedDown("straight lines or spiculations radiating from a point, and focal retraction, distortion or straightening")
                        .MarkedDown("at the anterior or posterior edge of the parenchyma. Architectural distortion may also be associ-")
                        .MarkedDown("ated with a mass, asymmetry, or calcifications. In the absence of appropriate history of trauma or")
                        .MarkedDown("surgery, architectural distortion is suspicious for malignancy or radial scar, and tissue diagnosis is")
                        .MarkedDown("appropriate.")
                        .BiradFooter()
                    )
                ;

            e.Select("value[x]").Zero();
            return e.SDef.Url;
        }
    }
}
