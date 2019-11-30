using FhirKhit.Tools.R4;
using PreFhir;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    public partial class ResourcesMaker
    {
        String FindingSectionFragment
        {
            get
            {
                if (findingSectionFragment == null)
                    CreateFindingSectionFragment ();
                return findingSectionFragment ;
            }
        }
        String findingSectionFragment  = null;


        void CreateFindingSectionFragment()
        {
            SDefEditor e = this.CreateFragment("FindingSectionFragment",
                    "Finding Section Fragment",
                    new string[] {"Finding", "Section", "Fragment"},
                    ObservationUrl,
                    out findingSectionFragment)
                .Description(new Hl7.Fhir.Model.Markdown("Fragment that defines values for finding sections (Mammo, MRI, ETc)."))
                ;

            e.Select("value[x]").Zero();
            e.Select("specimen").Zero();
            e.Select("referenceRange").Zero();
            e.Select("interpretation").Zero();
            e.Select("note").Zero();
            // todo: Add body site info.
            //e.Select("bodySite").Zero();
        }
    }
}
