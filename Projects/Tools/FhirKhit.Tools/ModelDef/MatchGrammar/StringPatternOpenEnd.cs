using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.Tools.MatchGrammar
{
    public class StringPatternOpenEnd : StringPatternBase
    {
        public StringPatternOpenEnd(String pattern) : base(pattern)
        {
        }

        public override Boolean IsMatch(String value) => value.StartsWith(this.pattern);

        public override String ToString() => $"'{this.pattern}' ...";
    }
}
