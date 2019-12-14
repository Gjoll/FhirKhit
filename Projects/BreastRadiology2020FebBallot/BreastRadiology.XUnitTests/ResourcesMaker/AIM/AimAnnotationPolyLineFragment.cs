using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using PreFhir;
using System;
using System.Collections.Generic;
using System.Text;
using VTask = System.Threading.Tasks.Task;
using StringTask = System.Threading.Tasks.Task<string>;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker
    {
        async StringTask AimAnnotationPolyLineFragment()
        {
            if (aimAnnotationPolyLineFragment == null)
                await CreateAimAnnotationPolyLineFragment();
            return aimAnnotationPolyLineFragment;
        }
        String aimAnnotationPolyLineFragment = null;


        /// <summary>
        /// Create BreastBodyLocationFragment.
        /// </summary>
        /// <returns></returns>
        async VTask CreateAimAnnotationPolyLineFragment()
        {
            await VTask.Run(async () =>
            {
                SDefEditor e = this.CreateFragment("AimAnnotationPolyLineFragment",
                        "Aim Annotation PolyLine Fragment",
                        new string[] { "Annotation", "PolyLine", "Fragment" },
                        ObservationUrl,
                        out aimAnnotationPolyLineFragment)
                    .Description("Fragment definition to include AIM Annotation extension",
                        new Markdown()
                        .Paragraph("This fragment adds the references for the AIM Annotation PolyLine extension.")
                        .Todo(
                        )
                     )
                    .AddFragRef(await this.HeaderFragment());
                ;
                e
                    .ApplyExtension("polyLineAnnotation", await this.AimAnnotationPolyLineExtension(), true, false)
                    .Single()
                    ;
                e.IntroDoc
                .ReviewedStatus(ReviewStatus.NotReviewed)
                .Fragment($"Resource fragment that includes the Annotation PolyGonLine extension.");
            });
        }
    }
}
