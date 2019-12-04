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
        String MammoSkinRetraction
        {
            get
            {
                if (mammoSkinRetraction == null)
                    CreateMammoSkinRetraction();
                return mammoSkinRetraction;
            }
        }
        String mammoSkinRetraction = null;

        void CreateMammoSkinRetraction()
        {
            SDefEditor e = this.CreateEditor("BreastRadMammoSkinRetraction",
                "Breast Radiology Skin Retraction Observation",
                new string[] { "Skin", "Retraction" },
                ObservationUrl,
                out mammoSkinRetraction)
                .Description(new Markdown()
                    .Paragraph("Skin Retraction Observation")
                    .BiradHeader()
                    .BlockQuote("The skin is pulled in abnormally")
                    .BiradFooter()
                    .MissingObservation("a skin retraction")
                )
                .AddFragRef(this.BreastBodyLocationRequiredFragment)
                .AddFragRef(this.ObservationNoValueFragment)
                ;

            e.Select("value[x]").Zero();
        }
    }
}