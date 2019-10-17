﻿using System;
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
        String SectionFindings(String findingsLeftUrl,
            String findingsRightUrl)
        {
            return this.CreateObservationSection(
                "BreastRadSectionFindings",
                "Breast Radiology Findings",
                new Markdown().Paragraph("Findings Section"))
                .SliceByUrl("hasMember",
                    new ObservationTarget[]
                    {
                        new ObservationTarget(findingsLeftUrl, 1, "1"),
                        new ObservationTarget(findingsRightUrl, 1, "1")
                    })
                .SDef.Url;
        }
    }
}