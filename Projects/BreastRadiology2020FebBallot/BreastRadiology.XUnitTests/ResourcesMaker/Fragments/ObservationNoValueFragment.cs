using FhirKhit.Tools.R4;
using PreFhir;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker
    {
        String ObservationNoValueFragment
        {
            get
            {
                if (observationNoValueFragment == null)
                    CreateObservationNoValueFragment();
                return observationNoValueFragment;
            }
        }
        String observationNoValueFragment = null;

        void CreateObservationNoValueFragment()
        {
            SDefEditor e = this.CreateFragment("BreastRadObservationNoValueFragment",
                "BreastRad Observation NoValue Fragment",
                    new string[] { "NoValue", "Observation", "Fragment" },
                ObservationUrl,
                out observationNoValueFragment)
                .Description(new Hl7.Fhir.Model.Markdown("Base fragment for all BreastRad observations that have no explicit value."))
                .AddFragRef(this.ObservationFragment)
            ;
            e.Select("value[x]").Zero().NoTypes();
            e.Select("interpretation").Zero();
            e.Select("referenceRange").Zero();
        }
    }
}
