using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using FhirKhit.ProfGen.PGShared;
using FhirKhit.ProfGen.PGShared.CodeGen.CSApi.Extensions;
using FhirKhit.Tools;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using Hl7.Fhir.Support.Model;
using System.Diagnostics;
using Hl7.FhirPath;

namespace FhirKhit.ProfGen.CSApi
{                                                                                                                                           // CodeGeneration.cs:399
    public static class FhirConstruct
    {                                                                                                                                       // CodeGeneration.cs:401
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,
            Element fix,                                                                                                                    // CodeGeneration.cs:416
            String methodName,                                                                                                              // CodeGeneration.cs:417
            out String propertyType)                                                                                                        // CodeGeneration.cs:418
        {                                                                                                                                   // CodeGeneration.cs:419
            propertyType = String.Empty;
            return false;
        }
    }                                                                                                                                       // CodeGeneration.cs:407
}                                                                                                                                           // CodeGeneration.cs:408
