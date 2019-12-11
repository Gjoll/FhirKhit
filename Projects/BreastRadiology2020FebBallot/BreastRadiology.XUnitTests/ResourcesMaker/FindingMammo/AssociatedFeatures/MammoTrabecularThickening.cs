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
                "Mammo Trabecular Thickening",
                new string[] {"Trabecular","Thickening"},
                ObservationUrl,
                $"{Group_MammoResources}/AssociatedFeature/TrabecularThickening",
                out mammoTrabecularThickening)
                .Description("Trabecular Thickening Observation",
                    new Markdown()
                        .BiradHeader()
                        .BlockQuote("This is a thickening of the fibrous septa of the breast.")
                        .BiradFooter()
                        .MissingObservation("a trabecular thickening")
                        .Todo(
                            "Add body location?",
                            "Add size measurement?",
                            "cardinality 0..1 or 0..*?"
                        )
                )
                .AddFragRef(this.ObservationNoDeviceFragment)
                .AddFragRef(this.BreastBodyLocationRequiredFragment)
                .AddLinks(this.BreastBodyLocationMapLinks)
                .AddFragRef(this.ObservationNoValueFragment)
                ;
            e.IntroDoc.ReviewedStatus(ReviewStatus.NotReviewed).ObservationLeafNode("Trabecular Thickening");
        }
    }
}
