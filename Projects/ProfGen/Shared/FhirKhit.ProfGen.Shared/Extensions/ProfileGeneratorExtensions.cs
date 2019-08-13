using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.ProfGen.Shared
{
    /// <summary>
    /// Extensions on profile generator class
    /// </summary>
    public static class ProfileGeneratorExtensions
    {
        public static ProfileGenerator.OutputLanguages ToOutputLang(this String language)
        {
            switch (language.ToLower())
            {
                case "csharp": return  ProfileGenerator.OutputLanguages.CSharp;
                    default: throw new Exception($"Unknown output language '{language}'");
            }
        }
    }
}
