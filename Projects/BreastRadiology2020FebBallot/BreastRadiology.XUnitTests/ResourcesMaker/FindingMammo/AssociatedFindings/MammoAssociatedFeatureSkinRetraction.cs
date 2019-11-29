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
        String MammoSkinRetraction
        {
            get
            {
                if (mammoSkinRetraction == null)
                    mammoSkinRetraction = CreateMammoSkinRetraction();
                return mammoSkinRetraction;
            }
        }
        String mammoSkinRetraction = null;

        String CreateMammoSkinRetraction()
        {
            SDefEditor e = this.CreateObservationEditor("BreastRadMammoSkinRetraction",
                    "Breast Radiology Skin Retraction Observation",
                    new string[] {"Skin","Retraction"})
                    .Description(new Markdown()
                        .Paragraph("Skin Retraction Observation")
                        .MissingObservation("a skin retraction")
                    )
                    .AddFragRef(this.BreastBodyLocationRequiredFragment)
                    ;

            e.Select("value[x]").Zero();
            return e.SDef.Url;        }
    }
}
