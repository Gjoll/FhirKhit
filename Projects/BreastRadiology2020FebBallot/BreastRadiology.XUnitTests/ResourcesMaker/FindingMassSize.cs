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
        String MassSize
        {
            get
            {
                if (massSize == null)
                    CreateMassSize();
                return massSize;
            }
        }
        String massSize = null;

        void CreateMassSize()
        {
            SDefEditor e = this.CreateObservationEditor("BreastRadMassSize",
                        "Breast Radiology Mass Size",
                        new string[] { "Size" },
                        out massSize)
                    .Description(new Markdown()
                        .Paragraph("Breast Radiology Mass Size Observation")
                        .MissingObservation("a mass size")
                        )
                    ;
            // TODO: Should this be SimpleQuantity.
            e.Select("value[x]")
                .Type("Quantity")
                .SetCardinality(0, "3")
                .SetDefinition(new Markdown()
                    .Paragraph("Size of mass in centimeters.")
                    .Paragraph("Record measurements to the nearest millimeter or centimeter. For example, 0.45 cm–0.49 cm " +
                               "should be rounded up to 0.5 cm and 0.11–0.14 cm should be rounded down to 0.1 cm.")
                    .Paragraph("When possible, three measurements of a lesion should be given. The largest measurement " +
                               "should represent the longest axis of a lesion if there is one. The next measurement should be the " +
                               "one perpendicular to the first. The third measurement should be taken from a view orthogonal " +
                               "to the first image, and it should represent a plane different from the first two.")
                 )
                .Pattern(new Quantity
                        {
                            System = "http://unitsofmeasure.org",
                            Unit = "cm",
                            Code = "cm"
                        }
                )
                ;
        }
    }
}
