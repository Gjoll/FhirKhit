using FhirKhit.Tools;
using System;
using System.Collections.Generic;
using System.Text;
using VTask = System.Threading.Tasks.Task;

namespace BreastRadiology.XUnitTests
{
    using XTask = System.Threading.Tasks.Task<ProfileTargetSlice[]>;
    partial class ResourcesMaker : ConverterBase
    {
        async XTask FindingBreastTargets()
        {
            if (findingBreastTargets == null)
                await CreateFindingBreastTargets();
            return findingBreastTargets;
        }

        ProfileTargetSlice[] findingBreastTargets = null;

        async VTask CreateFindingBreastTargets()
        {
            findingBreastTargets = new ProfileTargetSlice[]
            {
                new ProfileTargetSlice(await this.BiRadsAssessmentCategory(), 1, "1"),
                new ProfileTargetSlice(await this.FindingMammo(), 0, "*"),
                new ProfileTargetSlice(await this.FindingMri(), 0, "*"),
                new ProfileTargetSlice(await this.FindingUltraSound(), 0, "*")
            };
        }
    }
}
