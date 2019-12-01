using FhirKhit.Tools.R4;
using PreFhir;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    public partial class ResourcesMaker
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
                .Description(new Hl7.Fhir.Model.Markdown("Fragment that defines restricts observations leaf nodes (no hasMembers references)."))
                .AddFragRef(this.HeaderFragment)
                .AddFragRef(this.CategoryFragment)
                .AddFragRef(this.ObservationFragment)
            ;
            e.Select("hasMember").Single();
        }
    }
}
