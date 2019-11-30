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
            SDefEditor e = this.CreateObservationEditor("BreastRadMammoSkinLesion",
                    "Breast Radiology Mammography Skin Lesion",
                    new string[] { "Skin", "Lesion" },
                    out mammoSkinLesion)
                    .Description(new Markdown()
                        .Paragraph("Breast Radiology Mammography Skin Lesion Observation")
                        .MissingObservation("a skin lesion")
                        .BiradHeader()
                        .MarkedDown("This finding may be described in the mammography report or annotated on the mammographic")
                        .MarkedDown("image when it projects over the breast (especially on 2 different projections), and may be mistaken")
                        .MarkedDown("for an intramammary lesion. A raised skin lesion sufficiently large to be seen at mammography")
                        .MarkedDown("should be marked by the technologist with a radiopaque device designated for use as a marker for")
                        .MarkedDown("a skin lesion.")
                        .BiradFooter()
                    )
                .AddFragRef(this.BreastBodyLocationRequiredFragment)
                ;
            e.Select("value[x]").Zero();
        }
    }
}
