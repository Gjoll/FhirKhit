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
        String AbMammo(String mammoBreastDensity,
            String mammoMass,
            String calc,
            String archDist,
            String assymetries,
            String intramammaryLymphNode,
            String skinLesions,
            String solitaryDilatedDuct)
        {
            //$ todo. Incorrect method!!!
            SDefEditor e = this.CreateObservationEditor("BreastRadAbnormalityMammo",
                                                        "Breast Radiology Abnormality (Mammography)")
                .Description(new Markdown().Paragraph("Mammography Breast Abnormality Observation"))
                .AddFragRef(this.abnormalityFragmentUrl)
                ;
            e.Find("method")
             .FixedCodeSlice("method", "http://snomed.info/sct", "115341008")
             .Card(1, "*")
             ;
            e.Find("hasMember")
                .SliceByUrl(new ObservationTarget[]
                {
                        new ObservationTarget(mammoBreastDensity, 1, "1"),
                        new ObservationTarget(mammoMass, 0, "*"),
                        new ObservationTarget(calc, 0, "*"),
                        new ObservationTarget(archDist, 0, "1"),
                        new ObservationTarget(assymetries, 0, "*"),
                        new ObservationTarget(intramammaryLymphNode, 1, "1"),
                        new ObservationTarget(skinLesions, 0, "*"),
                        new ObservationTarget(solitaryDilatedDuct, 1, "1")
                });
            return e.SDef.Url;
        }
    }
}
