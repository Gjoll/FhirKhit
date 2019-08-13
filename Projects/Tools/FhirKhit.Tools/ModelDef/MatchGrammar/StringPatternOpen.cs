using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.Tools.MatchGrammar
{
    public class StringPatternOpen : StringPatternBase
    {
        public StringPatternOpen(String pattern) : base(pattern)
        {
        }

        public override Boolean IsMatch(String value) => value.Contains(this.pattern);

        public override String ToString() => $"... '{this.pattern}' ...";
    }
}
