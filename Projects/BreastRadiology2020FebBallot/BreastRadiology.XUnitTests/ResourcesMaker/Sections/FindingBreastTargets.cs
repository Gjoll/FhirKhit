using FhirKhit.Tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    public partial class ResourcesMaker : ConverterBase
    {
        ProfileTarget[] FindingBreastTargets
        {
            get
            {
                if (findingBreastTargets == null)
                    findingBreastTargets = CreateFindingBreastTargets();
                return findingBreastTargets;
            }
        }

        ProfileTarget[] findingBreastTargets = null;

        ProfileTarget[] CreateFindingBreastTargets()
        {
            ProfileTarget[] retVal = new ProfileTarget[]
            {
                new ProfileTarget(this.FindingMammo, 0, "*"),
                new ProfileTarget(this.FindingMri, 0, "*"),
                new ProfileTarget(this.FindingUltraSound, 0, "*")
            };
            return retVal;
        }
    }
}
