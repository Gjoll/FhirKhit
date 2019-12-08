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
using PreFhir;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker : ConverterBase
    {
        String BreastRadCount
        {
            get
            {
                if (breastRadCount == null)
                    CreateBreastRadCount();
                return breastRadCount;
            }
        }
        String breastRadCount = null;

        void CreateBreastRadCount()
        {
            SDefEditor e = this.CreateEditor("BreastRadCount",
                    "Count",
                    new string[] { "Count" },
                    ObservationUrl,
                    out breastRadCount)
                .Description(new Markdown()
                    .ReviewedStatus(ReviewStatus.NotReviewed)
                    .Paragraph("Breast Radiology Count Observation")
                    .MissingObservation("an objects Count")
                    )
                .AddFragRef(this.ObservationLeafFragment)
                ;
            // TODO: Should this be SimpleQuantity.
            // todo: is 'tot' correct ucum units for count?
            e.Select("value[x]")
                .Types("integer", "Range")
                .SetCardinality(1, "1")
                .SetDefinition(new Markdown()
                    .Paragraph("Count of an object")
                    .Paragraph("This is either an integer count, or a Range (min..max) count")
                    .Paragraph($"A range value with no maximum specified implies count is min or more.")
                    .Paragraph($"A range value with no minimum specified implies count is max or less.")
                 )
                ;

            e.IntroDoc.ObservationLeafNode($"Count");
        }
    }
}
