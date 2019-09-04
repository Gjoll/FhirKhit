using FhirKhit.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace FhirKhit.SliceGen.R4
{
    internal static class CodeBlockNestedExtensions
    {
        /// <summary>
        /// Create common static Create method.
        /// </summary>
        public static CodeBlockNested WriteStaticCreate(this CodeBlockNested block,
            string profileClassName,
            String fhirClassName,
            [CallerFilePath] String filePath = "",
            [CallerLineNumber] Int32 lineNumber = 0)
        {
            block
                .BlankLine()
                .AppendLine($"// called from {Path.GetFileName(filePath)} #{lineNumber}")
                .Summary($"static creator")
                .AppendCode($"public static {profileClassName} Create({fhirClassName} ptr)")
                .OpenBrace()
                .AppendLine($"{profileClassName} retVal = new {profileClassName}();")
                .AppendLine($"retVal.Init(ptr);")
                .AppendLine($"return retVal;")
                .CloseBrace()
                ;
            return block;
        }

        /// <summary>
        /// Create common static constructor method.
        /// </summary>
        public static CodeBlockNested WriteConstructor(this CodeBlockNested block,
            string className,
            [CallerFilePath] String filePath = "",
            [CallerLineNumber] Int32 lineNumber = 0)
        {
            block
                .BlankLine()
                .Summary($"Constructor")
                .AppendLine($"// called from {Path.GetFileName(filePath)} #{lineNumber}")
                .AppendCode($"public {className}() : base()")
                .OpenBrace()
                .CloseBrace()
                ;
            return block;
        }

        /// <summary>
        /// Create common static constructor method.
        /// </summary>
        public static CodeBlockNested WriteInit(this CodeBlockNested block,
            string className,
            [CallerFilePath] String filePath = "",
            [CallerLineNumber] Int32 lineNumber = 0)
        {
            block.WriteInitStart(className, filePath, lineNumber);
            block.WriteInitEnd();
            return block;
        }

        /// <summary>
        /// end Create common static constructor method.
        /// </summary>
        public static CodeBlockNested WriteInitEnd(this CodeBlockNested block)
        {
            block.CloseBrace();
            return block;
        }

        /// <summary>
        /// start Create common static constructor method.
        /// </summary>
        public static CodeBlockNested WriteInitStart(this CodeBlockNested block,
            string className,
            [CallerFilePath] String filePath = "",
            [CallerLineNumber] Int32 lineNumber = 0)
        {
            block
                .BlankLine()
                .AppendLine($"// called from {Path.GetFileName(filePath)} #{lineNumber}")
                .Summary($"/// Init method")
                .AppendCode($"public override void Init({className} ptr)")
                .OpenBrace()
                .AppendCode($"base.Init(ptr);")
                ;
            return block;
        }
    }
}
