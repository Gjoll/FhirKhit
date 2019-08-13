using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.Tools
{
    public enum SaveTypes
    {
        Json,
        Xml
    }

    public static class SaveTypeExtensions
    {
        public static String ToFileExtension(this SaveTypes saveType)
        {
            switch (saveType)
            {
                case SaveTypes.Json: return ".json";
                case SaveTypes.Xml: return ".xml";
                default: throw new NotImplementedException();
            }
        }
    }
}
