using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
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
                .Description("Fragment that constrains Observations to be sections.",
                    new Markdown()
                        .Paragraph("this fragment constrains a generic observation to be a observation section.")
                        .Todo(
                        )
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
