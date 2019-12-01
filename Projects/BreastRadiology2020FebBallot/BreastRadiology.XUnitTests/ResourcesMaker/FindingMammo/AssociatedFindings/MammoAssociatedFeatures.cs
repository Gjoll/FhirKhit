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
        String MammoAssociatedFeatures
        {
            get
            {
                if (mammoAssociatedFeatures == null)
                    CreateMammoAssociatedFeatures();
                return mammoAssociatedFeatures;
            }
        }
        String mammoAssociatedFeatures = null;

        void CreateMammoAssociatedFeatures()
        {
            SDefEditor e = this.CreateEditor("BreastRadMammoAssociatedFeatures",
                    "Breast Radiology Mammography Associated Features",
                    new string[] { "Associated", "Features" },
                    ObservationUrl,
                    out mammoAssociatedFeatures)
                .Description(new Markdown()
                            .Paragraph("Mammography Associated Features Observation")
                            .Paragraph("Used with masses, asymmetries, or calcifications, or may stand alone as " +
                            "Features when no other abnormality is present.")
                            )
                .AddFragRef(this.ObservationSectionFragment)
                ;
            {
                //todo: Cardinality of targets?
                ProfileTargetSlice[] targets = new ProfileTargetSlice[]
                {
                    new ProfileTargetSlice(this.MammoSkinRetraction, 0, "1"),
                    new ProfileTargetSlice(this.MammoNippleRetraction, 0, "1"),
                    new ProfileTargetSlice(this.MammoSkinThickening, 0, "*"),
                    new ProfileTargetSlice(this.MammoAxillaryAdenopathy, 0, "1"),
                    new ProfileTargetSlice(this.MammoArchitecturalDistortion, 0, "*"),
                    new ProfileTargetSlice(this.MammoCalcification, 0, "*")
                };
                e.Find("hasMember").SliceByUrl(targets);
                e.MapNode.AddProfileTargets(targets);
            }
        }
    }
}
