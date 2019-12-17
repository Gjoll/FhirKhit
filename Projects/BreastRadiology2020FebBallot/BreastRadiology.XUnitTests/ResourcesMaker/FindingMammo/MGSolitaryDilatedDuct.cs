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
using VTask = System.Threading.Tasks.Task;
using StringTask = System.Threading.Tasks.Task<string>;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker : ConverterBase
    {
        async StringTask MGSolitaryDilatedDuct()
        {
            if (this.mgSolitaryDilatedDuct == null)
                await this.CreateMGSolitaryDilatedDuct();
            return this.mgSolitaryDilatedDuct;
        }
        String mgSolitaryDilatedDuct = null;

        async VTask CreateMGSolitaryDilatedDuct()
        {
            await VTask.Run(async () =>
            {
                SDefEditor e = this.CreateEditor("BreastRadMammoSolitaryDilatedDuct",
                        "Mammo Solitary Dilated Duct",
                        "Mammo/Solitary/Dialated/Duct",
                        ObservationUrl,
                        $"{Group_MammoResources}/SolitaryDilatedDuct",
                        out this.mgSolitaryDilatedDuct)
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
                    .AddFragRef(await this.ObservationNoDeviceFragment())
                    .AddFragRef(await this.ObservationNoValueFragment())
                    .AddFragRef(await this.ObservationLeafFragment())
                    .AddFragRef(await this.BreastBodyLocationRequiredFragment())
                    ;

                e.IntroDoc
                    .ReviewedStatus(ReviewStatus.NotReviewed)
                    .ObservationLeafNode($"Solitary Dilated Duct")
                    ;
            });
        }
    }
}
