using Hl7.Fhir.Model;
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
    public static class ModelDefBases
    {
        static ModelDefBases()
        {
            ModelDefBases.bases = new ModelDefProject();
            ModelDefBases.bases.ProjectData.AbbreviatedProjectName = "FhirBases";
        }

        static ModelDefProject bases;

        public static Boolean FindModelByUrl(String url, out StructureDefinition sdef)
        {
            if (bases.FindModelByUrl(url.ToUpper(), out sdef) == true)
                return true;
            return Create(url, out sdef);
        }

        public static Boolean Create(String url, out StructureDefinition sdef)
        {
            lock (typeof(ModelDefBases))
            {
                ResourceToModelDefConverter converter = new ResourceToModelDefConverter();
                converter.Load("http://hl7.org/fhir/StructureDefinition/Observation");
                converter.ZeroCardinality("target.path[1...] == 'value[x]'");
                converter.Map();
                ModelDefBases.bases.AddModelDef(converter.ModelDef);
                sdef = converter.ModelDef;
                return true;
            }
        }
    }
}
