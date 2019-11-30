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
        String MammoNippleRetraction
        {
            get
            {
                if (mammoNippleRetraction == null)
                    CreateMammoNippleRetraction();
                return mammoNippleRetraction;
            }
        }
        String mammoNippleRetraction = null;

        void CreateMammoNippleRetraction()
        {
            SDefEditor e = this.CreateObservationEditor("BreastRadMammoNippleRetraction",
                    "Breast Radiology Mammography Nipple Retraction Observation",
                    new string[] { "Nipple", "Retraction" },
                    out mammoNippleRetraction)
                    .Description(new Markdown()
                        .Paragraph("Breast Radiology Mammography Nipple Retraction Observation")
                        .MissingObservation("a nipple retraction")
                        .BiradHeader()
                        .MarkedDown("The nipple is pulled in. This should not be confused with nipple inversion, which is often bilateral ")
                        .MarkedDown("and which in the absence of any suspicious findings and when stable for a long period of time, ")
                        .MarkedDown("is not a sign of malignancy. However, if nipple retraction is new, suspicion for underlying malignancy is increased.")
                        .BiradFooter()
                    )
                    .AddFragRef(this.BreastBodyLocationRequiredFragment)
                    ;

            e.Select("value[x]").Zero();
        }
    }
}