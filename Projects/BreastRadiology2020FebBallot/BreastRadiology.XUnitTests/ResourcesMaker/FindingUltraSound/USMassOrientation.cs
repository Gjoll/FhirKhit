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
    public partial class ResourcesMaker : ConverterBase
    {
        String USMassOrientation
        {
            get
            {
                if (usMassOrientation == null)
                    CreateUSMassOrientation();
                return usMassOrientation;
            }
        }
        String usMassOrientation = null;

        void CreateUSMassOrientation()
        {
            String binding = this.CreateValueSet(
                "BreastRadUSMassOrientation",
                "Breast Radiology Ultra-Sound Mass Orientation",
                new Markdown()
                    .Paragraph("Breast Radiology Ultra-Sound Mass Orientation"),
                    new ConceptDef[]
                    {
                        new ConceptDef("Parallel ",
                            "Parallel",
                            "(historically, “wider-than-tall” or “horizontal”) " +
                            "The long axis of the mass parallels the skin line. Masses that are only slightly obiquely oriented " +
                            "might be considered parallel."),
                        new ConceptDef("NotParallel",
                            "Not Parallel",
                            "(historically, \"isodense\") " +
                            "The long axis of the mass does not lie parallel to the skin line. The anterior–posterior or vertical " +
                            "dimension is greater than the transverse or horizontal dimension. These masses can also be " +
                            "obliquely oriented to the skin line. Round masses are NOT PARALLEL in their orientation.")
                    })
                .Url;

            SDefEditor e = this.CreateEditor("BreastRadUSMassOrientation",
                        "Breast Radiology Ultra-Sound Mass Orientation",
                        new string[] { "Orientation" },
                        ObservationUrl,
                        out usMassOrientation)
                    .Description(new Markdown()
                        .Paragraph("Breast Radiology Ultra-Sound Mass Orientation Observation")
                        .MissingObservation("a mass orientation")
                        .BiradHeader()
                        .MarkedDown("This feature of masses is unique to US imaging. Orientation is defined with reference to the skin")
                        .MarkedDown("line. Obliquely situated masses may follow a radial pattern, and their long axes will help determine")
                        .MarkedDown("classification as parallel or not parallel. Parallel or \"wider-than-tall\" orientation is a property of most")
                        .MarkedDown("benign masses, notably fibroadenomas; however, many carcinomas have this orientation as well.")
                        .MarkedDown("Orientation alone should not be used as an isolated feature in assessing a mass for its likelihood of")
                        .MarkedDown("malignancy.")
                        .BiradFooter()
                        )
                    .AddFragRef(this.ObservationCodedValueFragment)
                .AddFragRef(this.ObservationLeafFragment)
                    ;

            e.Select("value[x]")
                .Type("CodeableConcept")
                .Binding(binding, BindingStrength.Required)
                ;
        }
    }
}
