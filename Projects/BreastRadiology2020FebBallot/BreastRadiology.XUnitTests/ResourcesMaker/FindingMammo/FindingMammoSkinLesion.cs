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
        String FindingMammoSkinLesion
        {
            get
            {
                if (findingMammoSkinLesion == null)
                    findingMammoSkinLesion = CreateFindingMammoSkinLesion();
                return findingMammoSkinLesion;
            }
        }
        String findingMammoSkinLesion = null;

        String CreateFindingMammoSkinLesion()
        {
            SDefEditor e = this.CreateObservationEditor("BreastRadFindingMammoSkinLesion",
                    "Breast Radiology Finding Skin Lesion (Mammography)",
                    new string[] { "Skin", "Lesion" })
                    .Description(new Markdown()
                        .Paragraph("Mammography Breast Finding Skin Lesion Observation")
                        .Paragraph("If this observation is present, and dataAbsentReason is empty, then a skin lesion was observed.")
                        .Paragraph("If this observation is present, and dataAbsentReason is not empty, then a skin lesion  " +
                                    "was not observed and dataAbsentReason contains the reason why.")
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
            return e.SDef.Url;
        }
    }
}
