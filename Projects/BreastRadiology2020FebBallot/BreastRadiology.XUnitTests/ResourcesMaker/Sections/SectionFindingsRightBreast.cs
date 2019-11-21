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
        String SectionFindingsRightBreast(ObservationTarget[] abnormalityTargets)
        {
            SDefEditor e = this.CreateObservationSection(
                "BreastRadSectionFindingsRightBreast",
                "Breast Radiology Findings Right Breast",
                new Markdown().Paragraph("Findings Right Breast Section"))
                ;
            e.Select("bodySite").Zero();
            e.Find("hasMember").SliceByUrl(abnormalityTargets);
            return e.SDef.Url;
        }
    }
}