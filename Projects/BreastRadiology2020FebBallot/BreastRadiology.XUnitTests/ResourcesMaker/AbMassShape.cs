using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using PreFhir;

namespace BreastRadiology.XUnitTests
{
    public partial class ResourcesMaker
    {
        String AbMassShape()
        {
            ValueSet vs = this.CreateValueSet(
                    "BreastRadAbnormalityMassShape",
                    "Breast Radiology Abnormality Mass Shape",
                    new Markdown()
                        .Paragraph("Breast Radiology Mass Shape"),
                    new ConceptDef[]
                    {
                        new ConceptDef("Oval", "Elliptical/Egg-shaped Mass", "A mass that is elliptical or egg-shaped (may include 2 or 3 undulations)."),
                        new ConceptDef("Round", "Round Mass", "A mass that is spherical, ball-shaped, circular, or globular in shape."),
                        new ConceptDef("Irregular", "Irregular Mass", "The shape of the mass is neither round nor oval. For mammography, use of this descriptor usually implies a suspicious finding.")
                    })
                .AddFragRef(this.existanceValueSetUrl)
                ;

            String binding = vs.Url;

            SDefEditor e = this.CreateObservationEditor("BreastRadAbnormalityMassShape",
                    "Breast Radiology Abnormality Mass Shape",
                    new string[] { "Shape" })
                .Description(new Markdown().Paragraph("Breast Radiology Abnormality Mass Shape Observation"))
                .AddFragRef(this.abnormalityObservationNoHasMembersFragmentUrl)
                ;

            e.Select("value[x]")
                .Type("CodeableConcept")
                .Binding(binding, BindingStrength.Required)
                ;
            return e.SDef.Url;
        }
    }
}
