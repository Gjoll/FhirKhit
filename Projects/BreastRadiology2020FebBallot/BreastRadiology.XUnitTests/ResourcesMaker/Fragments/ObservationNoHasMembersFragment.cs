﻿using FhirKhit.Tools.R4;
using PreFhir;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    public partial class ResourcesMaker
    {
        String ObservationNoHasMembersFragment
        {
            get
            {
                if (observationNoHasMembersFragment == null)
                    observationNoHasMembersFragment = CreateObservationNoHasMembersFragment();
                return observationNoHasMembersFragment;
            }
        }
        String observationNoHasMembersFragment = null;

        String CreateObservationNoHasMembersFragment()
        {
            SDefEditor e = this.CreateFragment("ObservationNoHasMembersFragment",
                "Observation with no hasMember's Fragment",
                    new string[] {"Observation", "No hasMember's", "Fragment" },
                ObservationUrl)
                .Description(new Hl7.Fhir.Model.Markdown("Fragment that defines restricts observations to have no hasMember references."))
                .AddFragRef(this.HeaderFragment)
                .AddFragRef(this.CategoryFragment)
            ;
            e.Select("hasMember").Single();
            return e.SDef.Url;
        }
    }
}
