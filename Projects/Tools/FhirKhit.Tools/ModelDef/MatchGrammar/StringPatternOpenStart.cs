using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.Tools.MatchGrammar
{
    public class StringPatternOpenStart : StringPatternBase
    {
        public StringPatternOpenStart(String pattern) : base(pattern)
        {
        }

        public override Boolean IsMatch(String value) => value.EndsWith(this.pattern);

        public override String ToString() => $"... '{this.pattern}'";
    }
}
