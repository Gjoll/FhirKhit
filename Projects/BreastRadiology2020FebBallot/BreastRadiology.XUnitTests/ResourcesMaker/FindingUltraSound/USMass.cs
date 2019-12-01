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
    // todo: add mass size measurements (3 dimensional) like US?
    // same for asymmetry, lesion, calcification?

    partial class ResourcesMaker : ConverterBase
    {
        String USMass
        {
            get
            {
                if (usMass == null)
                    CreateUSMass();
                return usMass;
            }
        }
        String usMass = null;

        void CreateUSMass()
        {
            SDefEditor e = this.CreateEditor("BreastRadUSMass",
                    "Breast Radiology Mammography Mass Observation",
                    new string[] { "Mass" },
                    ObservationUrl,
                    out usMass)
                .Description(new Markdown()
                    .Paragraph("Breast Radiology Mammography Mass Observation")
                    .MissingObservation("a mass", "and no Shape, Orientation, Margin, Echo Pattern, or Posterior Acoustic Feature observations should be referenced by this observation")
                    .BiradHeader()
                    .MarkedDown("A mass is three dimensional and occupies space. With 2-D ultrasound, it should be seen in two")
                    .MarkedDown("different planes, and in three planes with volumetric acquisitions. Masses can be distinguished")
                    .MarkedDown("from normal anatomic structures, such as ribs or fat lobules, using two or more projections and")
                    .MarkedDown("real-time scanning.")
                    .BiradFooter()
                    .Paragraph("This observation has the following three member observations")
                    .List("Shape", "Orientation", "Margin", "Echo Pattern", "Posterior acoustic features")
                )
                .AddFragRef(this.BreastBodyLocationRequiredFragment)
                .AddFragRef(this.ObservationSectionFragment)
                ;
            {
                ProfileTargetSlice[] targets = new ProfileTargetSlice[]
                {
                    new ProfileTargetSlice(this.MassSize, 0, "1"),
                    new ProfileTargetSlice(this.MassShape, 0, "1"),
                    new ProfileTargetSlice(this.USMassOrientation, 0, "1"),
                    new ProfileTargetSlice(this.USMassMargin, 0, "1"),
                    //new ProfileTargetSlice(this.MammoAssociatedFeatures, 0, "1", false)
                };
                e.Find("hasMember").SliceByUrl(targets);
                e.MapNode.AddProfileTargets(targets);
            }
            e.Select("value[x]").Zero();
        }
    }
}
