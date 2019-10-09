using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FhirKhit.ProfGen.GenTests.R4
{
    public class CodeGenerationR4
    {
        /// <summary>
        /// Use FhirConstruct method to generate code for each element.
        /// </summary>
        [Fact(DisplayName = "CodeGeneration.FhirConstructC")]
        [Trait("CodeGen", "CodeGen")]
        public void FhirConstructC()
        {
            FhirConstructUse f = new FhirConstructUse();
            f.Use();
        }

    }
}
