using FhirKhit.Tools.R4;
using PreFhir;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker
    {
        String ObservationSectionFragment
        {
            get
            {
                if (observationSectionFragment == null)
                    CreateObservationSectionFragment ();
                return observationSectionFragment ;
            }
        }
        String observationSectionFragment  = null;


        void CreateObservationSectionFragment()
        {
            SDefEditor e = this.CreateFragment("ObservationSectionFragment",
                    "Observation Section Fragment",
                    new string[] {"Section", "Fragment"},
                    ObservationUrl,
                    out observationSectionFragment)
                .Description(new Hl7.Fhir.Model.Markdown()
                    .Paragraph("Fragment that constrains Observations to be sections.")
                    )
                .AddFragRef(this.ObservationFragment)
                ;

            e.Select("value[x]").Zero();
            e.Select("interpretation").Zero();
            e.Select("note").Zero();
            e.Select("method").Zero();

            e.IntroDoc.ReviewedStatus(ReviewStatus.NotReviewed).Fragment($"Resource fragment used by observations that are used as report sections.");
        }
    }
}
