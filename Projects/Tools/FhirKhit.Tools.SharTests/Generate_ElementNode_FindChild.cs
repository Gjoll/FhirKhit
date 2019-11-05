﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using Xunit;
using System.IO;
using System.Diagnostics;

#if FHIR_R2
using FhirKhit.Tools.R2;
#elif FHIR_R3
using FhirKhit.Tools.R3;
#elif FHIR_R4
using FhirKhit.Tools.R4;
#endif

#if FHIR_R2
namespace FhirKhit.Tools.R2.XUnitTests
#elif FHIR_R3
namespace FhirKhit.Tools.R3.XUnitTests
#elif FHIR_R4
namespace FhirKhit.Tools.R4.XUnitTests
#endif
{
    public class Generate_ElementDefinitionNode_FindChild
    {
#if FHIR_R4 || FHIR_R3
        void GenerateFindCommonChild(CodeBlockNested construct,
            CodeBlockNested methods,
            FHIRAllTypes fhirType)
        {
            String fhirTypeName = ModelInfo.FhirTypeToFhirTypeName(fhirType);
            Type fhirCSType = ModelInfo.GetTypeForFhirType(fhirTypeName);

            String methodName = $"FindChild{fhirTypeName}";
            construct
                .AppendCode($"case \"{fhirCSType.FriendlyName()}\": return {methodName}(parentPath, childName);")
                ;

            methods
                .BlankLine()
                .SummaryOpen()
                .Summary($"Manually add the children of a Coding element.")
                .SummaryClose()
                .AppendCode($"ElementDefinitionNode {methodName}(String parentPath, String childName)")
                .OpenBrace()
                .AppendCode($"ElementDefinitionNode retVal;")
                .AppendCode($"switch (childName)")
                .OpenBrace()
                ;

            foreach (PropertyInfo pi in fhirCSType.GetProperties())
            {
                FhirElementAttribute attribute = pi.GetCustomAttribute<FhirElementAttribute>();
                if (attribute != null)
                {
                    String min;
                    String max;
                    if (pi.PropertyType.IsList())
                    {
                        min = "0";
                        max = "*";
                    }
                    if (pi.PropertyType.IsNullable())
                    {
                        min = "0";
                        max = "1";
                    }
                    else
                    {
                        min = "1";
                        max = "1";

                    }
                    String varName = $"{attribute.Name}Var";
                    methods
                        .AppendCode($"case \"{attribute.Name}\":")
                        .OpenBrace()
                        .AppendCode($"ElementDefinition e = new ElementDefinition")
                        .OpenBrace()
                        .AppendCode($"Path = $\"{{parentPath}}.{attribute.Name}\",")
                        .AppendCode($"Short = \"{fhirType}.{attribute.Name} common attribute\",")
                        .AppendCode($"Min = {min},")
                        .AppendCode($"Max = \"{max}\"")
                        .CloseBrace(";")
                        .AppendCode($"retVal = new ElementDefinitionNode(this, e, typeof({pi.PropertyType.FriendlyName()}), nameof({fhirCSType.FriendlyName()}.{pi.Name}));")
                        .AppendCode($"retVal.AutoGeneratedFlag = true;")
                        .AppendCode($"break;")
                        .CloseBrace(";")
                        ;
                }
            }

            methods
                .AppendCode($"default: return null;")
                .CloseBrace()
                .AppendCode($"this.childNodeDictionary.Add(childName, retVal);")
                .AppendCode($"return retVal;")
                .CloseBrace()
                ;
        }

        [Fact(DisplayName = "CodeGen.Validate")]
        void Validate()
        {
            String savePath = $"\\Temp\\test.json";
            FhirValidator fv = new FhirValidator();
            fv.Validate("4.0.0", savePath);
            StringBuilder sb = new StringBuilder();
            bool success = fv.FormatMessages(sb);
            Trace.WriteLine(sb.ToString());
            Assert.True(success);
            Trace.WriteLine("Validation complete");
        }

        /// <summary>
        /// Create the AddChildXXX methods of ElementDefinitionNode.
        /// </summary>
        [Fact(DisplayName = "CodeGen.GenerateFindCommonChildren")]
        [Trait("CodeGen", "CodeGen")]
        void GenerateFindCommonChildren()
        {
            CodeEditor editor = new CodeEditor();

            CodeBlockNested main = editor.Blocks.AppendBlock();
            main
                .AppendLine($"using System;")
                .AppendLine($"using System.Linq;")
                .AppendLine($"using System.Collections.Generic;")
                .AppendLine($"using System.Reflection;")
                .AppendLine($"using System.Text;")
                .AppendLine($"using FhirKhit.Tools;")
                .AppendLine($"using Hl7.Fhir.Introspection;")
                .AppendLine($"using Hl7.Fhir.Model;")
                .AppendLine($"using Hl7.Fhir.Support.Model;")
                .AppendLine($"using System.Diagnostics;")
                .AppendLine($"using Hl7.FhirPath;")
                .BlankLine()
#if FHIR_R2
                .AppendLine($"namespace FhirKhit.Tools.R2")
#elif FHIR_R3
                .AppendLine($"namespace FhirKhit.Tools.R3")
#elif FHIR_R4
                .AppendLine($"namespace FhirKhit.Tools.R4")
#endif
                .OpenBrace()
                .AppendCode($"public partial class ElementDefinitionNode")
                .OpenBrace()
                ;
            CodeBlockNested construct = main.AppendBlock();
            CodeBlockNested methods = main.AppendBlock();

            main
                .CloseBrace()
                .CloseBrace()
                ;

            construct
                .SummaryOpen()
                .Summary($"Create ElementDefinitionNode for child of common/primitive Fhir data type elements")
                .SummaryClose()
                .AppendCode($"public ElementDefinitionNode FindCommonChild(String parentPath, String childName)")
                .OpenBrace()
                .AppendCode($"switch (this.FhirItemType.FriendlyName())")
                .OpenBrace()
                ;

            GenerateFindCommonChild(construct, methods, FHIRAllTypes.Ratio);
            GenerateFindCommonChild(construct, methods, FHIRAllTypes.Period);
            GenerateFindCommonChild(construct, methods, FHIRAllTypes.Range);
            GenerateFindCommonChild(construct, methods, FHIRAllTypes.Attachment);
            GenerateFindCommonChild(construct, methods, FHIRAllTypes.Identifier);
            GenerateFindCommonChild(construct, methods, FHIRAllTypes.Annotation);
            GenerateFindCommonChild(construct, methods, FHIRAllTypes.HumanName);
            GenerateFindCommonChild(construct, methods, FHIRAllTypes.CodeableConcept);

            GenerateFindCommonChild(construct, methods, FHIRAllTypes.ContactPoint);
            GenerateFindCommonChild(construct, methods, FHIRAllTypes.Coding);
            GenerateFindCommonChild(construct, methods, FHIRAllTypes.Money);
            GenerateFindCommonChild(construct, methods, FHIRAllTypes.Address);
            GenerateFindCommonChild(construct, methods, FHIRAllTypes.Timing);
            GenerateFindCommonChild(construct, methods, FHIRAllTypes.Quantity);
            GenerateFindCommonChild(construct, methods, FHIRAllTypes.SampledData);
            GenerateFindCommonChild(construct, methods, FHIRAllTypes.Signature);
            GenerateFindCommonChild(construct, methods, FHIRAllTypes.Age);
            GenerateFindCommonChild(construct, methods, FHIRAllTypes.Distance);
            GenerateFindCommonChild(construct, methods, FHIRAllTypes.Duration);
            GenerateFindCommonChild(construct, methods, FHIRAllTypes.Count);
#if FHIR_R4
            GenerateFindCommonChild(construct, methods, FHIRAllTypes.MoneyQuantity);
#endif
            GenerateFindCommonChild(construct, methods, FHIRAllTypes.SimpleQuantity);
            GenerateFindCommonChild(construct, methods, FHIRAllTypes.Extension);

            construct
                .AppendCode($"default: return null;")
                .CloseBrace()
                .CloseBrace()
                ;

#if FHIR_R2
            String outputPath = Path.Combine(DirHelper.FindParentDir("Tools"),
                "FhirKhit.Tools.R2",
                "ElementDefinitionNode.FindChild.cs");
#elif FHIR_R3
            String outputPath = Path.Combine(DirHelper.FindParentDir("Tools"),
                "FhirKhit.Tools.R3",
                "ElementDefinitionNode.FindChild.cs");
#elif FHIR_R4
            String outputPath = Path.Combine(DirHelper.FindParentDir("Tools"),
                "FhirKhit.Tools.R4",
                "ElementDefinitionNode.FindChild.cs");
#endif
            editor.Save(outputPath);
        }
#endif
    }
}
