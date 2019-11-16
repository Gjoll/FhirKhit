using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.BreastRadiology.XUnitTests
{
    public class ObservationTarget
    {
        public String Profile { get; }
        public Int32 Min { get; }
        public String Max { get; }

        public ObservationTarget(String profile, Int32 min, String max)
        {
            this.Profile = profile;
            this.Min = min;
            this.Max = max;
        }
    }
}
