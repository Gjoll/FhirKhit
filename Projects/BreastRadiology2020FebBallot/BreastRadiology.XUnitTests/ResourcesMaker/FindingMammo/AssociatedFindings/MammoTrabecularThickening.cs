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
    // Todo:
    // - Add body location?
    // - Add size measurement?
    // - cardinality 0..1 or 0..*?

    partial class ResourcesMaker : ConverterBase
    {
        String MammoTrabecularThickening
        {
            get
            {
                if (mammoTrabecularThickening == null)
                    CreateMammoTrabecularThickening();
                return mammoTrabecularThickening;
            }
        }
        String mammoTrabecularThickening = null;

        void CreateMammoTrabecularThickening()
        {
            SDefEditor e = this.CreateEditor("BreastRadMammoTrabecularThickening",
                "Breast Radiology Skin Retraction Observation",
                new string[] {"Trabecular","Thickening"},
                ObservationUrl,
                out mammoTrabecularThickening)
                .Description(new Markdown()
                    .Paragraph("Trabecular Thickening Observation")
                    .BiradHeader()
                    .BiRadLine("This is a thickening of the fibrous septa of the breast.")
                    .BiradFooter()
                    .MissingObservation("a trabecular thickening")
                )
                .AddFragRef(this.BreastBodyLocationRequiredFragment)
                .AddFragRef(this.ObservationNoValueFragment)
                ;

            e.Select("value[x]").Zero();
        }
    }
}
