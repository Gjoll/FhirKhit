using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Specification.Source;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

#if FHIR_R4
namespace FhirKhit.Tools.R4
#elif FHIR_R3
namespace FhirKhit.Tools.R3
#elif FHIR_R2
namespace FhirKhit.Tools.R2
#endif
{

    public static class MarkDownExtensions
    {
        public static Markdown Paragraph(this Markdown md, params string[] lines)
        {
            foreach (String line in lines)
                md.Value += $"{line}\n";
            md.Value += $"\n\n";
            return md;
        }

        public static Markdown Todo(this Markdown md, params string[] lines)
        {
            if (lines.Length > 0)
            {
                md.Value += $"*** TODO Items ***";
                md.List(lines);
            }
            return md;
        }

        public static Markdown List(this Markdown md, params string[] items)
        {
            foreach (String item in items)
                md.Value += $"** {item}\n";
            return md;
        }
    }
}
