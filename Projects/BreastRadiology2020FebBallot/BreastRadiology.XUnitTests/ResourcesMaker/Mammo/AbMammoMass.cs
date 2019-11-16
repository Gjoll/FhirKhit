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

namespace FhirKhit.BreastRadiology.XUnitTests
{
    public partial class ResourcesMaker : ConverterBase
    {
        String AbMammoMass(String massShape,
            String massMargin,
            String massDensity)
        {
            SDefEditor s = this.CreateObservationSection(
                "BreastRadMammoMass",
                "Breast Radiology Mammography Mass Observation",
                new Markdown()
                    .Paragraph("Breast Radiology Mammography Mass Observation")
                    .Paragraph("This observation has the following three member observations")
                    .List("Shape", "Margin", "Density")
                )
                .ApplyBreastBodyLocation(this.breastBodyLocation, false)
                ;

            s.Find("hasMember")
                .SliceByUrl(new ObservationTarget[]
                    {
                                new ObservationTarget(massShape, 1, "1"),
                                new ObservationTarget(massMargin, 1, "1"),
                                new ObservationTarget(massDensity, 1, "1")
                    });
            return s.SDef.Url;
        }
    }
}
