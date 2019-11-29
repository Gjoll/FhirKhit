using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Specification.Source;
using System;
using System.Collections.Generic;
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
        public static Markdown BiradHeader(this Markdown md)
        {
            md.Value += "### BI-RADS® ATLAS — MAMMOGRAPHY";
            md.Value += "### FIFTH EDITION — 2013";
            return md;
        }

        public static Markdown BiradFooter(this Markdown md)
        {
            md.Value += "### END BI-RADS® ATLAS — MAMMOGRAPHY TEXT";
            return md;
        }

        // TODO: Should it be a AbMammoIntramammaryLymphNode be required with dataAbsent Reason set to a value if
        // this was looked for and not seen?
        // See other 'If this observation is present, and dataAbsentReason is empty's
        public static Markdown MissingObservation(this Markdown md, String articleAndName, String term = ".")
        {
            md
                .Paragraph("If this observation is present, and dataAbsentReason is empty, then {articleAndName} was observed.")
                .Paragraph("If this observation is present, and dataAbsentReason is not empty, then {articleAndName} " +
                        "was not observed and dataAbsentReason contains the reason why{term}")
            ;
            return md;
        }

        public static Markdown Paragraph(this Markdown md, params string[] lines)
        {
            foreach (String line in lines)
                md.Value += $"{line}\n";
            md.Value += $"\n\n";
            return md;
        }

        /// <summary>
        /// Preformatted markdown
        /// </summary>
        /// <returns></returns>
        public static Markdown MarkedDown(this Markdown md, params string[] lines)
        {
            foreach (String line in lines)
                md.Value += $"{line}\n";
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
