using FhirKhit.Tools.R4;
using PreFhir;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    public partial class ResourcesMaker
    {
        String FindingObservationFragment
        {
            get
            {
                if (findingObservationFragment == null)
                    findingObservationFragment = CreateFindingObservationFragment();
                return findingObservationFragment;
            }
        }
        String findingObservationFragment = null;

        /// <summary>
        /// Create FindingObservationFragment.
        /// </summary>
        /// <returns></returns>
        String CreateFindingObservationFragment()
        {
            SDefEditor e = this.CreateFragment("FindingObservationFragment",
                "Finding Observation Fragment",
                    new string[] { "Finding", "Observation", "Fragment" },
                ObservationUrl)
                .Description(new Hl7.Fhir.Model.Markdown("Fragment that defines values for finding observations values."))
                .AddFragRef(this.HeaderFragment)
                .AddFragRef(this.CategoryFragment)
            ;
            e.Select("subject").Single();
            e.Select("component").Zero();
            e.Select("basedOn").Zero();
            e.Select("derivedFrom").Zero();
            e.Select("partOf").Zero();
            e.Select("focus").Zero();
            return e.SDef.Url;
        }
    }
}
