using FhirKhit.Tools;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace FhirKhit.SliceGen.R4
{
    public class GenerateFhirConstruct
    {
        Int32 tempCounter = 0;
        String TempName()
        {
            tempCounter += 1;
            return $"temp{tempCounter}";
        }

        void FixElement(CodeBlockNested code,
            PropertyInfo pi,
            String varName,
            String retValName)
        {
            FhirElementAttribute attribute = pi.GetCustomAttribute<FhirElementAttribute>();
            if (attribute == null)
                return;

            String name = pi.PropertyType.FriendlyName();
            switch (name)
            {
                case "Element":
                case "Extension":
                case "ResourceReference":
                case "List<Extension>":
                case "List<Element>":
                case "List<ResourceReference>":
                    return;

                case "bool?":
                    code
                        .AppendCode($"if ({varName}.{pi.Name}.HasValue == true)")
                        .OpenBrace()
                        .AppendCode($"if ({varName}.{pi.Name}.Value == true)")
                        .AppendCode($"    block.AppendCode($\"{retValName}.{pi.Name} = true;\");")
                        .AppendCode($"else")
                        .AppendCode($"    block.AppendCode($\"{retValName}.{pi.Name} = false;\");")
                        .CloseBrace()
                        ;
                    break;

                case "byte[]":
                    code
                        .AppendCode($"if ({varName}.{pi.Name} != null)")
                        .OpenBrace()
                        .AppendCode($"block.OpenBrace();")
                        .AppendCode($"block.AppendCode($\"byte[] data = new byte[]\");")
                        .AppendCode($"block.OpenBrace();")
                        .AppendCode($"Int32 i = 0;")
                        .AppendCode($"while (i < {varName}.{pi.Name}.Length)")
                        .OpenBrace()
                        .AppendCode($"Int32 j = 0;")
                        .AppendCode($"StringBuilder sb = new StringBuilder();")
                        .AppendCode($"while ((i < {varName}.{pi.Name}.Length) && (j < 32))")
                        .OpenBrace()
                        .AppendCode($"sb.Append($\"{{{varName}.{pi.Name}[i]}}\");")
                        .AppendCode($"if (i < {varName}.{pi.Name}.Length - 1) sb.Append(\",\");")
                        .AppendCode($"j += 1;")
                        .AppendCode($"i += 1;")
                        .CloseBrace()
                        .AppendCode($"block.AppendCode($\"{{sb.ToString()}}\");")
                        .CloseBrace()
                        .AppendCode($"block.CloseBrace(\";\");")
                        .AppendCode($"block.AppendCode($\"{retValName}.{pi.Name} = data;\");")
                        .AppendCode($"block.CloseBrace(\";\");")
                        .CloseBrace()
                        ;
                    break;

                case "DateTimeOffset?":
                    code
                        .AppendCode($"if ({varName}.{pi.Name}.HasValue == true)")
                        .OpenBrace()
                        .AppendCode($"DateTimeOffset x = {varName}.{pi.Name}.Value;")
                        .AppendCode($"block")
                        .AppendCode($"    .AppendCode($\"{retValName}.{pi.Name} = new DateTimeOffset({{x.Year}}, {{x.Month}}, {{x.Day}},\")")
                        .AppendCode($"    .AppendCode($\"    {{x.Hour}}, {{x.Minute}}, {{x.Second}}, {{x.Millisecond}},\")")
                        .AppendCode($"    .AppendCode($\"    new TimeSpan({{x.Offset.Hours}}, {{x.Offset.Minutes}}, {{x.Offset.Seconds}}));\")")
                        .AppendCode($";")
                        .CloseBrace()
                        ;
                    break;

                case "decimal?":
                    code
                        .AppendCode($"if ({varName}.{pi.Name}.HasValue == true)")
                        .AppendCode($"    block.AppendCode($\"{retValName}.{pi.Name} = new Nullable<decimal>((decimal) {{{varName}.{pi.Name}.Value}});\");")
                        ;
                    break;

                case "int?":
                    code
                        .AppendCode($"if ({varName}.{pi.Name}.HasValue == true)")
                        .AppendCode($"    block.AppendCode($\"{retValName}.{pi.Name} = new Nullable<int>((int) {{{varName}.{pi.Name}.Value}});\");")
                        ;
                    break;

                case "string":
                    code
                        .AppendCode($"if ({varName}.{pi.Name} != null)")
                        .AppendCode($"    block.AppendCode($\"{retValName}.{pi.Name} = \\\"{{{varName}.{pi.Name}}}\\\";\");")
                        ;
                    break;

                default:
                    if (name.StartsWith("Code<"))
                    {
                        String enumName = pi.PropertyType.GenericTypeArguments[0].FriendlyName();
                        code
                            .AppendCode($"if ({varName}.{pi.Name} != null)")
                            .AppendCode($"    block.AppendCode($\"{retValName}.{pi.Name} = new {name}({enumName}.{{{varName}.{pi.Name}.Value}});\");")
                            ;
                    }
                    else if (name.StartsWith("List<"))
                    {
                        String source = TempName();
                        String target = TempName();
                        Type listType = pi.PropertyType.GenericTypeArguments[0];
                        String listTypeName = listType.FriendlyName();

                        code
                            .AppendCode($"if ({varName}.{pi.Name} != null)")
                            .OpenBrace()
                            .AppendCode($"block.AppendCode($\"{retValName}.{pi.Name} = new {name}();\");")
                            .AppendCode($"foreach (var {source} in {varName}.{pi.Name})")
                            .OpenBrace()
                            .AppendCode($"block.OpenBrace();")
                            .AppendCode($"block.AppendCode(\"var {target} = new {listTypeName}();\");")
                            ;

                        this.FixElements(code, listType, $"{source}", $"{target}");

                        code
                            .AppendCode($"block.AppendCode($\"{retValName}.{pi.Name}.Add({target});\");")
                            .AppendCode($"block.CloseBrace();")
                            .CloseBrace()
                            .CloseBrace()
                            ;
                    }
                    else if (name.EndsWith("?"))
                    {
                        Type nullableType = pi.PropertyType.GenericTypeArguments[0];
                        String nullableTypeName = nullableType.FriendlyName();
                        if (nullableType.IsEnum)
                        {
                            code
                                .AppendCode($"if ({varName}.{pi.Name}.HasValue == true)")
                                .AppendCode($"    block.AppendCode($\"{retValName}.{pi.Name} = {nullableTypeName}.{{{varName}.{pi.Name}.Value}};\");")
                                ;
                        }
                        else if (nullableType.IsClass)
                        {
                            code
                                .AppendCode($"if ({varName}.{pi.Name}.HasValue == true)")
                                .OpenBrace()
                                .AppendCode($"    block.AppendCode($\"{retValName}.{pi.Name} = new {nullableTypeName}();\");")
                                ;
                            this.FixElements(code, nullableType, $"{varName}.{pi.Name}", $"{retValName}.{pi.Name}");
                            code
                                .CloseBrace()
                                ;
                        }
                        else
                            throw new NotImplementedException();
                    }
                    else
                    {
                        String typeName = pi.PropertyType.FriendlyName();
                        code
                            .AppendCode($"if ({varName}.{pi.Name} != null)")
                            .OpenBrace()
                            .AppendCode($"block.AppendCode($\"{retValName}.{pi.Name} = new {typeName}();\");")
                            ;
                        this.FixElements(code, pi.PropertyType, $"{varName}.{pi.Name}", $"{retValName}.{pi.Name}");
                        code
                            .CloseBrace()
                            ;
                    }
                    return;
            }
        }

        void FixElements(CodeBlockNested code,
            Type csType,
            String varName,
            String retValName)
        {
            foreach (PropertyInfo pi in csType.GetProperties())
                FixElement(code, pi, varName, retValName);
        }

        void ConstructPrimitive(CodeBlockNested methods,
            CodeBlockNested construct,
            FHIRAllTypes fhirType)
        {
            String fhirTypeName = ModelInfo.FhirTypeToFhirTypeName(fhirType);
            Type csType = ModelInfo.GetTypeForFhirType(fhirTypeName);
            String csTypeName = csType.FriendlyName();
            construct
                .AppendCode($"case \"{fhirTypeName}\": // {fhirType}  - primitive")
                .OpenBrace()
                .AppendCode($"propertyType = \"{fhirTypeName}\";")
                .AppendCode($"return Construct(block, ({csTypeName})fix, methodName, methodPrefix);")
                .CloseBrace()
                .BlankLine()
                ;
            CodeBlockNested m = methods.AppendBlock();
            m
                .BlankLine()
                .AppendLine($"/// <summary>")
                .AppendLine($"/// Return c# text to create indicated element.")
                .AppendLine($"/// </summary>")
                .AppendCode($"static public bool Construct(CodeBlockNested block,")
                .AppendCode($"    {csTypeName} fix,")
                .AppendCode($"    String methodName,")
                .AppendCode($"    String methodPrefix)")
                .OpenBrace()
                //.AppendCode($"const String fcn = \"Construct({fhirTypeName})\";")
                .BlankLine()
                .AppendCode($"if (block is null)")
                .AppendCode($"    throw new ArgumentNullException(nameof(block));")
                .AppendCode($"block")
                .AppendCode($"    .AppendCode($\"{{methodPrefix}} {csTypeName} {{methodName}}()\")")
                .AppendCode($"    .OpenBrace()")
                .AppendCode($"    .AppendCode(\"{csTypeName} retVal = new {csTypeName}();\")")
                .AppendCode($"    ;")
                .AppendCode($"if (fix != null)")
                .OpenBrace()
                ;

            FixElements(m, csType, "fix", "retVal");

            m
                .CloseBrace()
                .AppendCode($"block")
                .AppendCode($"    .AppendCode(\"return retVal;\")")
                .AppendCode($"    .CloseBrace()")
                .AppendCode($"    ;")
                .AppendCode($"return  true;")
                .CloseBrace()
                ;
        }

        void ConstructDataType(CodeBlockNested methods,
        CodeBlockNested construct,
        FHIRAllTypes fhirType)
        {
            if (GenerateCommon.Ignore(fhirType))
                return;

            this.tempCounter = 0;
            String fhirTypeName = ModelInfo.FhirTypeToFhirTypeName(fhirType);
            Type csType = ModelInfo.GetTypeForFhirType(fhirTypeName);
            String csTypeName = csType.FriendlyName();

            construct
                .AppendCode($"case \"{fhirTypeName}\": // {fhirType}  - DataType")
                .OpenBrace()
                .AppendCode($"propertyType = \"{fhirTypeName}\";")
                .AppendCode($"return Construct(block, ({csTypeName})fix, methodName, methodPrefix);")
                .CloseBrace()
                .BlankLine()
                ;

            CodeBlockNested m = methods.AppendBlock();
            m
                .BlankLine()
                .AppendLine($"/// <summary>")
                .AppendLine($"/// Return c# text to create indicated element.")
                .AppendLine($"/// </summary>")
                .AppendCode($"static public bool Construct(CodeBlockNested block,")
                .AppendCode($"    {csTypeName} fix,")
                .AppendCode($"    String methodName,")
                .AppendCode($"    String methodPrefix)")
               .OpenBrace()
                //.AppendCode($"const String fcn = \"Construct({fhirTypeName})\";")
                .BlankLine()
                .AppendCode($"if (block is null)")
                .AppendCode($"    throw new ArgumentNullException(nameof(block));")
                .AppendCode($"block")
                .AppendCode($"    .AppendCode($\"{{methodPrefix}} {csTypeName} {{methodName}}()\")")
                .AppendCode($"    .OpenBrace()")
                .AppendCode($"    .AppendCode(\"{csTypeName} retVal = new {csTypeName}();\")")
                .AppendCode($"    ;")
                .AppendCode($"if (fix != null)")
                .OpenBrace()
                ;

            FixElements(m, csType, "fix", "retVal");

            m
                .CloseBrace()
                .AppendCode($"block")
                .AppendCode($"    .AppendCode(\"return retVal = new {csTypeName}();\")")
                .AppendCode($"    .CloseBrace()")
                .AppendCode($"    ;")
                .AppendCode($"return  true;")
                .CloseBrace()
                ;
        }

        /// <summary>
        /// Generate Construct method.
        /// </summary>
        public void Generate(String outputPath)
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
                .AppendLine($"namespace FhirKhit.SliceGen.CSApi")
                .OpenBrace()
                .AppendLine($"public static class FhirConstruct")
                .OpenBrace()
                ;
            CodeBlockNested construct = main.AppendBlock();
            CodeBlockNested methods = main.AppendBlock();

            main
                .CloseBrace()
                .CloseBrace()
                ;

            construct
                .AppendLine($"/// <summary>")
                .AppendLine($"/// Return c# text to create indicated element.")
                .AppendLine($"/// </summary>")
                .AppendLine($"static public bool Construct(CodeBlockNested block,")
                .AppendCode($"    Element fix,")
                .AppendCode($"    String methodName,")
                .AppendCode($"    String methodPrefix,")
                .AppendCode($"    out String propertyType)")
                .OpenBrace()
                //.AppendCode($"const String fcn = \"Construct\";")
                .BlankLine()
                .AppendCode($"if (fix is null)")
                .AppendCode($"    throw new ArgumentNullException(nameof(fix));")
                .AppendCode($"propertyType = null;")
                .AppendCode($"switch (fix.TypeName)")
                .OpenBrace()
                ;

            foreach (FHIRAllTypes fhirType in Enum.GetValues(typeof(FHIRAllTypes)).OfType<FHIRAllTypes>())
            {
                String fhirTypeName = ModelInfo.FhirTypeToFhirTypeName(fhirType);

                if (ModelInfo.IsPrimitive(fhirType))
                    ConstructPrimitive(methods, construct, fhirType);
                else if (ModelInfo.IsDataType(fhirType))
                    ConstructDataType(methods, construct, fhirType);
            }

            construct
                .CloseBrace()
                .AppendCode($"return false;")
                .CloseBrace()
                ;

            editor.Save(outputPath);
        }
    }
}
