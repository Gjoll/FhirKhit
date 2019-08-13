using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.Tools.MatchGrammar
{
    public class StringPatternSimple : StringPatternBase
    {
        public StringPatternSimple(String pattern) : base(pattern)
        {
        }

        public override Boolean IsMatch(String value) => string.Compare(value, this.pattern, StringComparison.InvariantCulture) == 0;

        public override String ToString() => $"'{this.pattern}'";
    }
}
