using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.Tools
{
    public interface IConverter
    {
        IEnumerable<String> Errors {get; }
        IEnumerable<String> Warnings {get; }
        IEnumerable<String> Info {get; }
    }
}
