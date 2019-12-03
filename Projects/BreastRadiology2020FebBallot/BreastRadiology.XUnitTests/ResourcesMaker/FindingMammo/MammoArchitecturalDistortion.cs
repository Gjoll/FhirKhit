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
    partial class ResourcesMaker : ConverterBase
    {
        String MammoArchitecturalDistortion
        {
            get
            {
                if (mammoArchitecturalDistortion == null)
                    CreateMammoArchitecturalDistortion();
                return mammoArchitecturalDistortion;
            }
        }
        String mammoArchitecturalDistortion = null;

        void CreateMammoArchitecturalDistortion()
        {
            SDefEditor e = this.CreateEditor("BreastRadMammoArchitecturalDistortion",
                        "Breast Radiology Mammography Architectural Distortion Observation",
                    new string[] {"Mammo", "Arch.","Distortion"},
                    ObservationUrl,
                    out mammoArchitecturalDistortion)
                .Description(
                    new Markdown()
                        .Paragraph("Breast Radiology Mammography Architectural Distortion Observation")
                        .MissingObservation("an architectural distortion")
                        .BiradHeader()
                        .BiRadLine("The parenchyma is distorted with no definite mass visible. For mammography, this includes thin")
                        .BiRadLine("straight lines or spiculations radiating from a point, and focal retraction, distortion or straightening")
                        .BiRadLine("at the anterior or posterior edge of the parenchyma. Architectural distortion may also be associ-")
                        .BiRadLine("ated with a mass, asymmetry, or calcifications. In the absence of appropriate history of trauma or")
                        .BiRadLine("surgery, architectural distortion is suspicious for malignancy or radial scar, and tissue diagnosis is")
                        .BiRadLine("appropriate.")
                        .BiRadLine("As an ASSOCIATED FEATURE, architectural distortion may be used in conjunction with another")
                        .BiRadLine("finding to indicate that the parenchyma is distorted or retracted adjacent to the FINDING")
                        .BiradFooter()
                    )
                .AddFragRef(this.ObservationNoValueFragment)
                .AddFragRef(this.ObservationLeafFragment)
                ;

            e.Select("value[x]").Zero();
        }
    }
}
