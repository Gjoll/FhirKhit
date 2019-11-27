using FhirKhit.Tools.R4;
using PreFhir;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    public partial class ResourcesMaker
    {
        /// <summary>
        /// Create AbnormalityObservationCodedValueFragment.
        /// </summary>
        /// <returns></returns>
        String AbnormalityObservationCodedValueFragment()
        {
            SDefEditor e = this.CreateFragment("AbnormalityCodedValueObservationFragment",
                    "Abnormality CodedValue Observation Fragment",
                    new string[] {"Abnormality","CodedValue", "Fragment"},
                    ObservationUrl)
                .Description(new Hl7.Fhir.Model.Markdown("Fragment that defines values for coded abnormality observations."))
                .AddFragRef(this.headerFragUrl)
                .AddFragRef(this.breastBodyLocationRequiredFragmentUrl)
                ;

            e.Select("value[x]")
                .Type("CodeableConcept")
                ;

            return e.SDef.Url;
        }
    }
}
