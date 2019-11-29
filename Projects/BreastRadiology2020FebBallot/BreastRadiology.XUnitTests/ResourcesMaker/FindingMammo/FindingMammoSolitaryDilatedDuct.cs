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

namespace BreastRadiology.XUnitTests
{
    public partial class ResourcesMaker : ConverterBase
    {
        String FindingMammoSolitaryDilatedDuct
        {
            get
            {
                if (findingMammoSolitaryDilatedDuct == null)
                    findingMammoSolitaryDilatedDuct = CreateFindingMammoSolitaryDilatedDuct();
                return findingMammoSolitaryDilatedDuct;
            }
        }
        String findingMammoSolitaryDilatedDuct = null;

        String CreateFindingMammoSolitaryDilatedDuct()
        {
            SDefEditor e = this.CreateObservationEditor("BreastRadFindingMammoSolitaryDilatedDuct",
                    "Breast Radiology Finding Solitary Dilated Duct (Mammography)",
                    new string[] {"Dialated","Duct"})
                    .Description(new Markdown()
                        .Paragraph("Mammography Breast Finding Solitary Dilated Duct Observation")
                        .Paragraph("If this observation is present, and dataAbsentReason is empty, then a solitary dilated duct was observed.")
                        .Paragraph("If this observation is present, and dataAbsentReason is not empty, then a solitary dilated duct " +
                                    "was not observed and dataAbsentReason contains the reason why.")
                        .BiradHeader()
                        .MarkedDown("This is a unilateral tubular or branching structure that likely represents a dilated or otherwise en-")
                        .MarkedDown("larged duct. It is a rare finding. Even if unassociated with other suspicious clinical or mammographic")
                        .MarkedDown("findings, it has been reported to be associated with noncalcified DCIS.")
                        .BiradFooter()
                    )
                    .AddFragRef(this.BreastBodyLocationRequiredFragment)
                    ;

            e.Select("value[x]").Zero();
            return e.SDef.Url;        }
    }
}
