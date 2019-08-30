using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.SliceGen.Share
{
    /// <summary>
    /// Extensions on profile generator class
    /// </summary>
    public static class SliceGeneratorExtensions
    {
        public static SliceGenerator.OutputLanguageType ToOutputLang(this String language)
        {
            if (language is null)
                throw new ArgumentNullException(nameof(language));

            switch (language.ToLower())
            {
                case "csharp": return  SliceGenerator.OutputLanguageType.CSharp;
                    default: throw new Exception($"Unknown output language '{language}'");
            }
        }
    }
}
