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
        /// Create Valu set that defines the codes for existance.
        /// </summary>
        String ExistanceValueSet()
        {
            ValueSet vs = this.CreateValueSet(
                    "BreastRadExistance",
                    "Breast Radiology Existance Value",
                    new Markdown()
                        .Paragraph("Breast Radiology codes to define existance of a value"),
                    new ConceptDef[]
                    {
                        new ConceptDef("Present", "Value is present", "Value was observed and is present."),
                        new ConceptDef("NotPresent", "Value was found to be not present", "An observation for the value was made and found to not be present."),
                        new ConceptDef("NotChecked", "No attempt was made tt observe value", "An observation for the value was not made. Its existance is indeterminate.")
                    })
                    ;

            return vs.Url;
        }
    }
}
