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
        async StringTask AimAnnotatedImagingStudy()
        {
            if (aimAnnotatedImagingStudy == null)
                await CreateAimAnnotatedImagingStudy();
            return aimAnnotatedImagingStudy;
        }
        String aimAnnotatedImagingStudy = null;

        async VTask CreateAimAnnotatedImagingStudy()
        {
            await VTask.Run(async () =>
            {
                SDefEditor e = this.CreateEditor("AimAnnotatedImagingStudy",
                    "AIM Annotated Imaging Study",
                    new string[] { "Aim", "Annotated", "Imaging", "Study" },
                    ImagingStudyUrl,
                    $"{Group_AimResources}/Aim/AimAnnotatedImagingStudy",
                    out aimAnnotatedImagingStudy)
                    .Description("AIM Annotated Imaging Study",
                        new Markdown()
                            .Todo(
                            )
                    )
                    .AddFragRef(await this.AimHeaderFragment())
                    .AddFragRef(await this.AimAnnotationPolyLineFragment())
                    .AddExtensionLink(await this.AimAnnotationPolyLineExtension())
                    ;
                e.IntroDoc
                    .ReviewedStatus(ReviewStatus.NotReviewed)
                    .ObservationLeafNode("AIM Annotated Imaging Study");
            });
        }
    }
}
