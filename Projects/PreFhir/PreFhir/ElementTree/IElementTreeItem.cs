using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Linq;
using FhirKhit.Tools;
using FhirKhit.Tools.R4;

namespace PreFhir
{
    public interface IElementTreeItem
    {
        String Name { get; }
    }
}
