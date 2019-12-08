using FhirKhit.Tools.R4;
using PreFhir;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker
    {
        String ObservationLeafFragment
        {
            get
            {
                if (observationLeafFragment == null)
                    CreateObservationLeafFragment();
                return observationLeafFragment;
            }
        }
        String observationLeafFragment = null;

        void CreateObservationLeafFragment()
        {
            SDefEditor e = this.CreateFragment("ObservationLeafFragment",
                "Observation Leaf Fragment",
                    new string[] {"Observation", "Leaf", "Fragment" },
                ObservationUrl,
                out observationLeafFragment)
                .Description(new Hl7.Fhir.Model.Markdown()
                    .ReviewedStatus(ReviewStatus.NotReviewed)
                    .Paragraph("Fragment that constrains observations leaf nodes (no hasMembers references).")
                    )
                .AddFragRef(this.HeaderFragment)
                .AddFragRef(this.CategoryFragment)
                .AddFragRef(this.ObservationFragment)
            ;
            e.Select("hasMember").Zero();

            e.IntroDoc.Fragment($"Resource fragment used by resources that are leaf node observations.");
        }
    }
}
