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
        String MammoSkinLesion
        {
            get
            {
                if (mammoSkinLesion == null)
                    CreateMammoSkinLesion();
                return mammoSkinLesion;
            }
        }
        String mammoSkinLesion = null;

        void CreateMammoSkinLesion()
        {
            SDefEditor e = this.CreateEditor("BreastRadMammoSkinLesion",
                "Mammo Skin Lesion",
                new string[] { "Skin", "Lesion" },
                ObservationUrl,
                out mammoSkinLesion)
                .Description(new Markdown()
                    .ReviewedStatus(ReviewStatus.NotReviewed)
                    .Paragraph("Breast Radiology Mammography Skin Lesion Observation")
                    .MissingObservation("a skin lesion")
                    .BiradHeader()
                    .BlockQuote("This finding may be described in the mammography report or annotated on the mammographic")
                    .BlockQuote("image when it projects over the breast (especially on 2 different projections), and may be mistaken")
                    .BlockQuote("for an intramammary lesion. A raised skin lesion sufficiently large to be seen at mammography")
                    .BlockQuote("should be marked by the technologist with a radiopaque device designated for use as a marker for")
                    .BlockQuote("a skin lesion.")
                    .BiradFooter()
                )
                .AddFragRef(this.BreastBodyLocationRequiredFragment)
                .AddExtensionLink(this.BreastBodyLocationExtension)
                .AddFragRef(this.ObservationNoValueFragment)
                .AddFragRef(this.ObservationSectionFragment)
                ;

            {
                ProfileTargetSlice[] targets = new ProfileTargetSlice[]
                {
                    new ProfileTargetSlice(this.BreastRadSize, 0, "1"),
                    new ProfileTargetSlice(this.BreastRadCount, 0, "1"),
                    new ProfileTargetSlice(this.BreastRadObservedChanges, 0, "*"),
                    new ProfileTargetSlice(this.BreastRadObservedState, 0, "1", false)
                };
                e.Find("hasMember").SliceByUrl(targets);
                e.MapNode.AddProfileTargets(targets);
            }

            e.IntroDoc.ObservationLeafNode($"Skin Lesion");
        }
    }
}
