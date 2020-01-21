using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

#if FHIR_R4
namespace FhirKhit.Tools.R4
#elif FHIR_R3
namespace FhirKhit.Tools.R3
#endif
{
    public static class StringExtensions
{
    /// <summary>
    /// Create Markdown instance from a string.
    /// </summary>
    /// <param name="description"></param>
    /// <returns></returns>
    public static Markdown ConvertToMarkdown(this String description)
    {
        Markdown retVal = new Markdown();
        retVal.Value = description;
        return retVal;
    }

#if FHIR_R4 || FHIR_R3
        public static PublicationStatus ToPublicationStatus(this String value)
        {
            if (value is null)
                throw new ArgumentNullException(nameof(value));

            switch (value.ToUpper().Trim())
            {
                case "UNKNOWN": return PublicationStatus.Unknown;
                case "ACTIVE": return PublicationStatus.Active;
                case "DRAFT": return PublicationStatus.Draft;
                case "RETIRED": return PublicationStatus.Retired;
                default:
                    Log.Error("StringExtensions.ToPublicationStatus", $"Unknown publication status {value}");
                    return PublicationStatus.Unknown;
            }
        }
#endif

    public static void ProcessSystem(this String modelLabSystem,
        String modelLabCode,
        String modelLabDisplay,
        out String fhirSystem,
        out String fhirCode,
        out String fhirDisplay)
    {
        const String fcn = nameof(ProcessSystem);

        fhirCode = modelLabCode;
        fhirDisplay = modelLabDisplay;
        if (String.IsNullOrWhiteSpace(fhirDisplay))
            fhirDisplay = modelLabCode;

        switch (modelLabSystem?.ToUpper())
        {
            case null:
                fhirSystem = "http://test.com";
                break;

            case "LOINC":
                fhirSystem = "http://loinc.org";
                break;

            case "SNOMED-CT":
                fhirSystem = "http://snomed.info/sct";
                break;

            case "RADLEX":
                fhirSystem = "http://www.radlex.org";
                break;

            case "RXNORM":
                fhirSystem = "http://www.nlm.nih.gov/research/umls/rxnorm";
                break;

            default:
                Log.Warn(fcn, $"Unimplemented model lab system {modelLabSystem}");
                fhirSystem = modelLabSystem;
                break;
        }
    }
}
}
