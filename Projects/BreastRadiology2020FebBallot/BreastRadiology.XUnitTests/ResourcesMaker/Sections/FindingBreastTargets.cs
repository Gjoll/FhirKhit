using FhirKhit.Tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker : ConverterBase
    {
        ProfileTargetSlice[] FindingBreastTargets
        {
            get
            {
                if (findingBreastTargets == null)
                    findingBreastTargets = CreateFindingBreastTargets();
                return findingBreastTargets;
            }
        }

        ProfileTargetSlice[] findingBreastTargets = null;

        ProfileTargetSlice[] CreateFindingBreastTargets()
        {
            ProfileTargetSlice[] retVal = new ProfileTargetSlice[]
            {
                new ProfileTargetSlice(this.FindingMammo, 0, "*"),
                new ProfileTargetSlice(this.FindingMri, 0, "*"),
                new ProfileTargetSlice(this.FindingUltraSound, 0, "*")
            };
            return retVal;
        }
    }
}
