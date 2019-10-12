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
        String AbnormalityMammography(String mammoBreastDensity, 
            String mammoMass,
            String calc, 
            String archDist,
            String assymetries)
        {
            //$ todo. Incorrect method!!!
            return this.CreateAbnormality(
                "BreastRadiologyAbnormalityMammography",
                "Breast Radiology Abnormality (Mammography)",
                new Markdown().Paragraph("Mammography Breast Abnormality Observation"),
                "http://snomed.info/sct",
                "115341008")
                .SliceByUrl("Observation.hasMember",
                    new ObservationTarget[]
                    {
                        new ObservationTarget(mammoBreastDensity, 1, "1"),
                        new ObservationTarget(mammoMass, 0, "*"),
                        //new ObservationTarget(calc, 0, "*")
                        //new ObservationTarget(archDist, 0, "1"),
                        //new ObservationTarget(assymetries, 0, "*")
                    })
                .SDef.Url;
        }
    }
}
