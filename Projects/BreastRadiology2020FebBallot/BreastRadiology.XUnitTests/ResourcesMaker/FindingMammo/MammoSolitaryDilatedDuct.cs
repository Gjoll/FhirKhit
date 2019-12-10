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
    partial class ResourcesMaker : ConverterBase
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
            SDefEditor e = this.CreateEditor("BreastRadMammoSolitaryDilatedDuct",
                    "Mammo Solitary Dilated Duct",
                    new string[] { "Solitary", "Dialated", "Duct" },
                    ObservationUrl,
                    $"{Group_MammoResources}/SolitaryDilatedDuct",
                    out mammoSolitaryDilatedDuct)
                .Description("Breat Radiology Mammography Solitary Dilated Duct Observation",
                    new Markdown()
                        .MissingObservation("a solitary dilated duct")
                        .BiradHeader()
                        .BlockQuote("This is a unilateral tubular or branching structure that likely represents a dilated or otherwise en-")
                        .BlockQuote("larged duct. It is a rare finding. Even if unassociated with other suspicious clinical or mammographic")
                        .BlockQuote("findings, it has been reported to be associated with noncalcified DCIS.")
                        .BiradFooter()
                        .Todo(
                            "should this be a leaf node (how about shape, density, location, etc)."
                        )
                )
                .AddFragRef(this.ObservationNoDeviceFragment)
                .AddFragRef(this.ObservationNoValueFragment)
                .AddFragRef(this.ObservationLeafFragment)
                .AddFragRef(this.BreastBodyLocationRequiredFragment)
                .AddExtensionLink(this.BreastBodyLocationExtension)
                ;

            e.IntroDoc.ReviewedStatus(ReviewStatus.NotReviewed).ObservationLeafNode($"Solitary Dilated Duct");
        }
    }
}
