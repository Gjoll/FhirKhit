using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.ProfGen.PGShared
{
    /// <summary>
    /// Extensions on profile generator class
    /// </summary>
    public static class ProfileGeneratorExtensions
    {
        public static ProfileGenerator.OutputLanguageType ToOutputLang(this String language)
        {
            if (language is null)
                throw new ArgumentNullException(nameof(language));

            switch (language.ToLower())
            {
                case "csharp": return  ProfileGenerator.OutputLanguageType.CSharp;
                    default: throw new Exception($"Unknown output language '{language}'");
            }
        }
    }
}
