﻿using FhirKhit.SliceGen.R4;
using FhirKhit.Tools;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace FhirKhit.SliceGen.CSApi
{
    public class CSCodeFormatter : ICodeFormatter
    {
        CodeEditor code;
        CodeBlockNested nameSpaceBlock;
        SliceGenerator gen;

        /// <summary>
        /// Type of the fhir resource class that the profile is derived from (the resource it profiles)
        /// </summary>
        Type fhirType;

        public CSCodeFormatter(SliceGenerator gen)
        {
            this.gen = gen;
            this.code = new CodeEditor();
        }


        /// <summary>
        /// Start namespace.
        /// </summary>
        public void StartNameSpace(String nameSpace)
        {
            this.nameSpaceBlock = this.code.Blocks.AppendBlock();
            this.nameSpaceBlock
                .AppendCode($"/*")
                .AppendCode($" * Code in this class was auto generated by SliceGen")
                .AppendCode($"*/")
                .AppendCode($"using System;")
                .AppendCode($"using System.Linq;")
                .AppendCode($"using System.Collections.Generic;")
                .AppendCode($"using System.Reflection;")
                .AppendCode($"using System.Text;")
                .AppendCode($"using Hl7.Fhir.Model;")
                .AppendCode($"")
                .AppendCode($"namespace {nameSpace}")
                .OpenBrace()
                ;
        }

        /// <summary>
        /// End namespace.
        /// </summary>
        public void EndNameSpace()
        {
            this.nameSpaceBlock
                .CloseBrace()
                ;
            this.nameSpaceBlock = null;
        }

        /// <summary>
        /// Start creating a class.
        /// </summary>
        public void StartClass(String className, Type fhirType)
        {
        }

        /// <summary>
        /// End creating a class.
        /// </summary>
        public void EndClass()
        {
        }

        public String GetCode() => this.code.ToString();
    }
}
