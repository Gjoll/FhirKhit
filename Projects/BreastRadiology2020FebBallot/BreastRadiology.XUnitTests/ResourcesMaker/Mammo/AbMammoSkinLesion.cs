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
        String AbMammoSkinLesion()
        {
            SDefEditor e = this.CreateObservationEditor("BreastRadAbnormalityMammoSkinLesion",
                    "Breast Radiology Abnormality Skin Lesion (Mammography)",
                    new string[] { "Skin", "Lesion" })
                    .Description(new Markdown()
                        .Paragraph("Mammography Breast Abnormality Skin Lesion Observation")
                        .BiradHeader()
                        .MarkedDown("This finding may be described in the mammography report or annotated on the mammographic")
                        .MarkedDown("image when it projects over the breast (especially on 2 different projections), and may be mistaken")
                        .MarkedDown("for an intramammary lesion. A raised skin lesion sufficiently large to be seen at mammography")
                        .MarkedDown("should be marked by the technologist with a radiopaque device designated for use as a marker for")
                        .MarkedDown("a skin lesion.")
                        .BiradFooter()
                    )
                .AddFragRef(this.breastBodyLocationRequiredFragmentUrl)
                .AddFragRef(this.observationExistanceFragmentUrl)
                    ;
            return e.SDef.Url;
        }
    }
}
