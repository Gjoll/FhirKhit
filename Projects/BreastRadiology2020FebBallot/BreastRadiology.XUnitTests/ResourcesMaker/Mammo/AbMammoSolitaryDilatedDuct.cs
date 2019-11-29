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

namespace BreastRadiology.XUnitTests
{
    public partial class ResourcesMaker : ConverterBase
    {
        String AbMammoSolitaryDilatedDuct()
        {
            SDefEditor e = this.CreateObservationEditor("BreastRadAbnormalityMammoSolitaryDilatedDuct",
                    "Breast Radiology Abnormality Solitary Dilated Duct (Mammography)",
                    new string[] {"Dialated","Duct"})
                    .Description(new Markdown()
                        .Paragraph("Mammography Breast Abnormality Solitary Dilated Duct Observation")
                        .BiradHeader()
                        .MarkedDown("This is a unilateral tubular or branching structure that likely represents a dilated or otherwise en-")
                        .MarkedDown("larged duct. It is a rare finding. Even if unassociated with other suspicious clinical or mammographic")
                        .MarkedDown("findings, it has been reported to be associated with noncalcified DCIS.")
                        .BiradFooter()
                    )
                    .AddFragRef(this.breastBodyLocationRequiredFragmentUrl)
                    .AddFragRef(this.observationExistanceFragmentUrl)
                    ;

                return e.SDef.Url;        }
    }
}
