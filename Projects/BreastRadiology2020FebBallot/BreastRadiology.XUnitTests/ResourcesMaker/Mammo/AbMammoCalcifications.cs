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
        String AbMammoCalcifications(String calcType,
            String calcDistribution)
        {
            SDefEditor e = this.CreateObservationEditor("BreastRadMammoCalcifications",
                    "Breast Radiology Mammography Calcifications Observation",
                    new string[] {"Calcifications"})
                .Description(
                    new Markdown()
                        .Paragraph("Breast Radiology Mammography Calcifications Observation")
                        .BiradHeader()
                        .MarkedDown("Calcifications that are assessed as benign at mammography are typically larger, coarser, round with")
                        .MarkedDown("smooth margins, and more easily seen than malignant calcifications. Calcifications associated with")
                        .MarkedDown("malignancy (and many benign calcifications as well) are usually very small and often require the use")
                        .MarkedDown("of magnification to be seen well. When a specific typically benign etiology cannot be assigned, a")
                        .MarkedDown("description of calcifications should include their morphology and distribution. Calcifications that are")
                        .MarkedDown("obviously benign need not be reported, especially if the interpreting physician is concerned that")
                        .MarkedDown("the referring clinician or patient might infer anything other than absolute confidence in benignity")
                        .MarkedDown("were such calcifications described in the report. However, typically benign calcifications should be")
                        .MarkedDown("reported if the interpreting physician is concerned that other observers might misinterpret them as")
                        .MarkedDown("anything but benign were such calcifications not described in the report.")
                        .BiradFooter()
                        .Paragraph("This observation has the following two member observations")
                        .List("Calcification Type", "Calcification Distribution")
                    )
                .AddFragRef(this.breastBodyLocationRequiredFragmentUrl)
                .AddFragRef(this.observationSectionFragmentUrl)
                .AddFragRef(this.observationExistanceFragmentUrl)
                ;

            {
                ProfileTarget[] targets = new ProfileTarget[]
                {
                            new ProfileTarget(calcType, 1, "1"),
                            new ProfileTarget(calcDistribution, 1, "1")
                };
                e.Find("hasMember").SliceByUrl(targets);
                e.MapNode.AddProfileTargets(targets);
            }
            return e.SDef.Url;
        }
    }
}
