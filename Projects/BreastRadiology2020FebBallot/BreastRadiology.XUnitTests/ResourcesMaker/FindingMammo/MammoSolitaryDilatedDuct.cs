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
        String MammoSolitaryDilatedDuct
        {
            get
            {
                if (mammoSolitaryDilatedDuct == null)
                    CreateMammoSolitaryDilatedDuct();
                return mammoSolitaryDilatedDuct;
            }
        }
        String mammoSolitaryDilatedDuct = null;

        void CreateMammoSolitaryDilatedDuct()
        {
            SDefEditor e = this.CreateObservationEditor("BreastRadMammoSolitaryDilatedDuct",
                    "Breast Radiology Mammography Solitary Dilated Duct Observation",
                    new string[] { "Dialated", "Duct" },
                    out mammoSolitaryDilatedDuct)
                    .Description(new Markdown()
                        .Paragraph("Breat Radiology Mammography Solitary Dilated Duct Observation")
                        .MissingObservation("a solitary dilated duct")
                        .BiradHeader()
                        .MarkedDown("This is a unilateral tubular or branching structure that likely represents a dilated or otherwise en-")
                        .MarkedDown("larged duct. It is a rare finding. Even if unassociated with other suspicious clinical or mammographic")
                        .MarkedDown("findings, it has been reported to be associated with noncalcified DCIS.")
                        .BiradFooter()
                    )
                    .AddFragRef(this.BreastBodyLocationRequiredFragment)
                    ;

            e.Select("value[x]").Zero();
        }
    }
}