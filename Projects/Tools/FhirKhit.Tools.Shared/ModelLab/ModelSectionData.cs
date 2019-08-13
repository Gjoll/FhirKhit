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
    public class ModelSectionData : ISection
    {
        public Guid Guid => this.ConfigData.Guid;
        public String DefaultMap = null;
        public String DefaultMatch = null;
        public String TypeName => this.ConfigData.Id.ToMachineName();

        public ConfigData ConfigData { get; set; }
        public StructureDefinition StructureDefinition { get; set; }

        public ModelSectionData(ConfigData sectionData)
        {
            this.ConfigData = sectionData;
        }
    }
}
