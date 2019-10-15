using FhirKhit.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace FriendlyFhir.Maker
{
    public static class CodeEditorExtensions
    {
        public static CodeBlockNested AppendStringArray(this CodeBlockNested block,
            string fieldName,
            IEnumerable<String> strings,
            ref String sep,
             [CallerFilePath] String filePath = "",
             [CallerLineNumber] Int32 lineNumber = 0)
        {
            if (strings.Any() == false)
                return block;
            String[] profileArr = strings.ToArray();

            if (String.IsNullOrEmpty(sep) == false)
                block.AppendCode($"{sep}", filePath, lineNumber);
            sep = ",";
            block
                .AppendCode($"{fieldName} = new String[]", filePath, lineNumber)
                .OpenBrace()
                ;
            for (Int32 i = 0; i < profileArr.Length - 1; i++)
                block.AppendCode($"\"{profileArr[i]}\",", filePath, lineNumber);
            block
                .AppendCode($"\"{profileArr[profileArr.Length - 1]}\"", filePath, lineNumber)
                .CloseBrace()
                ;
            return block;
        }

        public static CodeBlockNested AppendTargetProfiles(this CodeBlockNested block,
            IEnumerable<String> profiles,
            ref String sep,
             [CallerFilePath] String filePath = "",
             [CallerLineNumber] Int32 lineNumber = 0)
        {
            return AppendStringArray(block, "TargetProfile", profiles, ref sep, filePath, lineNumber);
        }

        public static CodeBlockNested AppendProfiles(this CodeBlockNested block,
            IEnumerable<String> profiles,
            ref String sep,
             [CallerFilePath] String filePath = "",
             [CallerLineNumber] Int32 lineNumber = 0)
        {
            return AppendStringArray(block, "Profile", profiles, ref sep, filePath, lineNumber);
        }
    }
}
