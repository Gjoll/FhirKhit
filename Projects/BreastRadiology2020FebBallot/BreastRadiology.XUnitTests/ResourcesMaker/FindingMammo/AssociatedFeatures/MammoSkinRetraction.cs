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
        String MammoSkinRetraction
        {
            get
            {
                if (mammoSkinRetraction == null)
                    CreateMammoSkinRetraction();
                return mammoSkinRetraction;
            }
        }
        String mammoSkinRetraction = null;

        void CreateMammoSkinRetraction()
        {
            SDefEditor e = this.CreateEditor("BreastRadMammoSkinRetraction",
                "Mammo Skin Retraction",
                new string[] { "Mammo", "Skin", "Retraction" },
                ObservationUrl,
                $"{Group_MammoResources}/AssociatedFeature/SkinRetraction",
                out mammoSkinRetraction)
                .Description("Mammography Skin Retraction Observation",
                    new Markdown()
                        .Paragraph()
                        .BiradHeader()
                        .BlockQuote("The skin is pulled in abnormally")
                        .BiradFooter()
                        .MissingObservation("a skin retraction")
                        .Todo(
                        )
                )
                .AddFragRef(this.ObservationNoDeviceFragment)
                .AddFragRef(this.ObservationNoValueFragment)
                .AddFragRef(this.BreastBodyLocationRequiredFragment)
                .AddExtensionLink(this.BreastBodyLocationExtension)
                ;

            e.IntroDoc.ReviewedStatus(ReviewStatus.NotReviewed).ObservationLeafNode("Skin Retraction");
        }
    }
}
