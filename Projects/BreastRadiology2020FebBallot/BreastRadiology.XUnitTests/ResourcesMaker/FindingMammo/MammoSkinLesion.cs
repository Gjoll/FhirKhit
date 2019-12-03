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
        String MammoSkinLesion
        {
            get
            {
                if (mammoSkinLesion == null)
                    CreateMammoSkinLesion();
                return mammoSkinLesion;
            }
        }
        String mammoSkinLesion = null;

        void CreateMammoSkinLesion()
        {
            SDefEditor e = this.CreateEditor("BreastRadMammoSkinLesion",
                "Breast Radiology Mammography Skin Lesion",
                new string[] { "Mammo", "Skin", "Lesion" },
                ObservationUrl,
                out mammoSkinLesion)
                .Description(new Markdown()
                    .Paragraph("Breast Radiology Mammography Skin Lesion Observation")
                    .MissingObservation("a skin lesion")
                    .BiradHeader()
                    .BiRadLine("This finding may be described in the mammography report or annotated on the mammographic")
                    .BiRadLine("image when it projects over the breast (especially on 2 different projections), and may be mistaken")
                    .BiRadLine("for an intramammary lesion. A raised skin lesion sufficiently large to be seen at mammography")
                    .BiRadLine("should be marked by the technologist with a radiopaque device designated for use as a marker for")
                    .BiRadLine("a skin lesion.")
                    .BiradFooter()
                )
                .AddFragRef(this.BreastBodyLocationRequiredFragment)
                .AddFragRef(this.ObservationNoValueFragment)
                .AddFragRef(this.ObservationLeafFragment)
                ;
            e.Select("value[x]").Zero();
        }
    }
}
