using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.SliceGen.ShareLib
{
    /// <summary>
    /// Base class for all slice accessor classes.
    /// </summary>
    public class SliceAccessor
    {
        protected Slicing Slicing {get; set; }
    }
}
