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
        String CategoryFragment
        {
            get
            {
                if (findingCategoryFragment == null)
                    findingCategoryFragment = CreateCategoryFragment();
                return findingCategoryFragment;
            }
        }
        String findingCategoryFragment = null;

        /// <summary>
        /// Create Category fragment.
        /// This fragment creates a slice that is bound to the 'imaging' category.
        /// </summary>
        /// <returns></returns>
        String CreateCategoryFragment()
        {
            SDefEditor e = this.CreateFragment("CategoryFragment",
                    "Category Fragment",
                    new string[] {"Category","Fragment"},
                    ObservationUrl)
                .Description(new Markdown("Fragment definition that slices category and adds the observation code value"))
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
