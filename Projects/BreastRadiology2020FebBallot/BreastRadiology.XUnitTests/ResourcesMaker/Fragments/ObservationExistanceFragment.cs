using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using PreFhir;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    public partial class ResourcesMaker
    {
        /// <summary>
        /// Create AbnormalityObservationExistanceFragment.
        /// This fragment binds an observation to the existance value set.
        /// </summary>
        /// <returns></returns>
        String ObservationExistanceFragment()
        {
            SDefEditor e = this.CreateFragment("ObservationExistanceFragment",
                "Observation Existance Fragment",
                    new string[] { "Observation", "Existance", "Fragment" },
                ObservationUrl)
                .Description(new Hl7.Fhir.Model.Markdown("Fragment that defines binds the observations value to the existance value set."))
            ;

             e.Select("value[x]")
                .Type("CodeableConcept")
                .Binding(this.existanceValueSetUrl, BindingStrength.Required)
                ;
           return e.SDef.Url;
        }
    }
}
