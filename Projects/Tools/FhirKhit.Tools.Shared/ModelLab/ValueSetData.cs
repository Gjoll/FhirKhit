using System;
using System.Collections.Generic;
using System.Text;
using FhirKhit.Tools;
using Hl7.Fhir.Model;

#if FHIR_R4
namespace FhirKhit.Tools.R4
#elif FHIR_R3
namespace FhirKhit.Tools.R3
#elif FHIR_R2
namespace FhirKhit.Tools.R2
#endif
{
    /// <summary>
    /// Reads ModeLab model (v3) data.
    /// </summary>
    public class ValueSetData
    {
        public String Url => this.ConfigData.GetModelProperty("modelDef", "url");
        public Guid Guid => this.ConfigData.Guid;

        public ConfigData ConfigData { get; }
        public ValueSet ValueSet { get; set; }

        public ValueSetData(ConfigData configData, String fhirVersion)
        {
            this.ConfigData = configData;
            this.ValueSet = new ValueSet
            {
                Version = fhirVersion
            };
        }
    }
}
