﻿using System;
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
            SDefEditor e = this.CreateObservationEditor("BreastRadMammoArchitecturalDistortion",
                        "Breast Radiology Mammography Architectural Distortion Observation",
                    new string[] {"Arch.","Distortion"},
                    out mammoArchitecturalDistortion)
                .Description(
                    new Markdown()
                        .Paragraph("Breast Radiology Mammography Architectural Distortion Observation")
                        .MissingObservation("an architectural distortion")
                        .BiradHeader()
                        .MarkedDown("The parenchyma is distorted with no definite mass visible. For mammography, this includes thin")
                        .MarkedDown("straight lines or spiculations radiating from a point, and focal retraction, distortion or straightening")
                        .MarkedDown("at the anterior or posterior edge of the parenchyma. Architectural distortion may also be associ-")
                        .MarkedDown("ated with a mass, asymmetry, or calcifications. In the absence of appropriate history of trauma or")
                        .MarkedDown("surgery, architectural distortion is suspicious for malignancy or radial scar, and tissue diagnosis is")
                        .MarkedDown("appropriate.")
                        .MarkedDown("As an ASSOCIATED FEATURE, architectural distortion may be used in conjunction with another")
                        .MarkedDown("finding to indicate that the parenchyma is distorted or retracted adjacent to the FINDING")
                        .BiradFooter()
                    )
                ;

            e.Select("value[x]").Zero();
        }
    }
}