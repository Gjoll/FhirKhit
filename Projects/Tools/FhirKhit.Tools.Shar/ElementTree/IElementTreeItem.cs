using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Linq;
using FhirKhit.Tools;

#if FHIR_R4
namespace FhirKhit.Tools.R4
#elif FHIR_R3
namespace FhirKhit.Tools.R3
#endif
{
    public interface IElementTreeItem
    {
        String Name { get; }
    }
}
