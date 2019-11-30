using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    public class ProfileTarget
    {
        public String Profile { get; }
        public Int32 Min { get; }
        public String Max { get; }

        public bool ShowChildren { get; }
        public ProfileTarget(String profile, Int32 min, String max, bool showChildren = true)
        {
            this.Profile = profile;
            this.Min = min;
            this.Max = max;
            this.ShowChildren = showChildren;
        }
    }
}
