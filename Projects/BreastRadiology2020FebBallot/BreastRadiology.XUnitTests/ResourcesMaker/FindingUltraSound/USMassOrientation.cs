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
    partial class ResourcesMaker : ConverterBase
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
            ValueSet binding = this.CreateValueSet(
                "BreastRadUSMassOrientation",
                "US Mass Orientation",
                new Markdown()
                    .Paragraph("Breast Radiology Ultra-Sound Mass Orientation"),
                    new ConceptDef[]
                    {
                        new ConceptDef("Parallel ",
                            "Parallel",
                            new Definition()
                            .CiteStart()
                                .Line("(historically, “wider-than-tall” or “horizontal”)")
                                .Line("The long axis of the mass parallels the skin line. Masses that are only slightly obiquely oriented")
                                .Line("might be considered parallel.")
                            .CiteEnd(BiRadCitation)
                            ),
                        new ConceptDef("NotParallel",
                            "Not Parallel",
                            new Definition()
                            .CiteStart()
                                .Line("(historically, \"isodense\")")
                                .Line("The long axis of the mass does not lie parallel to the skin line. The anterior–posterior or vertical")
                                .Line("dimension is greater than the transverse or horizontal dimension. These masses can also be")
                                .Line("obliquely oriented to the skin line. Round masses are NOT PARALLEL in their orientation.")
                            .CiteEnd(BiRadCitation)
                            )
                    });

            SDefEditor e = this.CreateEditor("BreastRadUSMassOrientation",
                    "US Mass Orientation",
                    new string[] { "Orientation" },
                    ObservationUrl,
                    out usMassOrientation)
                .Description(new Markdown()
                    .ReviewedStatus(ReviewStatus.NotReviewed)
                    .Paragraph("Breast Radiology Ultra-Sound Mass Orientation Observation")
                    .MissingObservation("a mass orientation")
                    .BiradHeader()
                    .BlockQuote("This feature of masses is unique to US imaging. Orientation is defined with reference to the skin")
                    .BlockQuote("line. Obliquely situated masses may follow a radial pattern, and their long axes will help determine")
                    .BlockQuote("classification as parallel or not parallel. Parallel or \"wider-than-tall\" orientation is a property of most")
                    .BlockQuote("benign masses, notably fibroadenomas; however, many carcinomas have this orientation as well.")
                    .BlockQuote("Orientation alone should not be used as an isolated feature in assessing a mass for its likelihood of")
                    .BlockQuote("malignancy.")
                    .BiradFooter()
                    )
                .AddFragRef(this.ObservationCodedValueFragment)
                .AddFragRef(this.ObservationLeafFragment)
                ;

            e.Select("value[x]")
                .Type("CodeableConcept")
                .Binding(binding.Url, BindingStrength.Required)
                ;
            e.IntroDoc.CodedObservationLeafNode(e, "an ultra-sound mass orientation", binding);
        }
    }
}
