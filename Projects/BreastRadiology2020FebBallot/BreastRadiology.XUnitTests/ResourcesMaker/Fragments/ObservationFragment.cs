using FhirKhit.Tools.R4;
using PreFhir;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    public partial class ResourcesMaker
    {
        String ObservationFragment
        {
            get
            {
                if (observationFragment == null)
                    CreateObservationFragment();
                return observationFragment;
            }
        }
        String observationFragment = null;

        /// <summary>
        /// Create FindingObservationFragment.
        /// </summary>
        /// <returns></returns>
        void CreateObservationFragment()
        {
            SDefEditor e = this.CreateFragment("BreastRadObservationFragment",
                "BreastRad Observation Fragment",
                    new string[] { "BreastRad", "Observation", "Fragment" },
                ObservationUrl,
                out observationFragment)
                .Description(new Hl7.Fhir.Model.Markdown("Base fragment for all BreastRad observations."))
                .AddFragRef(this.HeaderFragment)
                .AddFragRef(this.CategoryFragment)
            ;
            e.Select("subject").Single();
            e.Select("component").Zero();
            e.Select("basedOn").Zero();
            e.Select("derivedFrom").Zero();
            e.Select("partOf").Zero();
            e.Select("focus").Zero();
        }
    }
}
