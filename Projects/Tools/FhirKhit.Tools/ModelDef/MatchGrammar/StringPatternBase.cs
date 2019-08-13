using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.Tools.MatchGrammar
{
    public abstract class StringPatternBase
    {
        protected String pattern;

        public StringPatternBase(String pattern)
        {
            this.pattern = pattern.ToUpper();
        }

        public abstract Boolean IsMatch(String value);
    }
}
