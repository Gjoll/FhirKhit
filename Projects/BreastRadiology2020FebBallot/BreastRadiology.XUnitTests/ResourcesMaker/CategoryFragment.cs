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
        /// Create Category fragment.
        /// This fragment creates a slice that is bound to the 'imaging' category.
        /// </summary>
        /// <returns></returns>
        String CategoryFragment()
        {
            SDefEditor e = this.CreateFragment("CategoryFragment",
                                                    "Category Fragment",
                                                     ObservationUrl)
                ;
            ElementDefGroup eDef = e.Find("category");
            eDef.ElementDefinition.Card(1, eDef.BaseElementDefinition.Max);
            eDef.FixedCodeSlice("category",
                "http://terminology.hl7.org/CodeSystem/observation-category",
                "imaging");
            return e.SDef.Url;
        }
    }
}
