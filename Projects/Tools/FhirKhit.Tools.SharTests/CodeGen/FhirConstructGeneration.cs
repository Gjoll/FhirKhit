using Hl7.Fhir.Model;
using System;
using System.Linq;
using System.IO;
using Xunit;
using System.Text;
using System.Reflection;
using Hl7.Fhir.Introspection;
using System.Collections.Generic;
using System.Diagnostics;
using System.Collections;


#if FHIR_R3
using FhirKhit.Tools.R3;
#elif FHIR_R4
using FhirKhit.Tools.R4;
#endif

namespace FhirKhit.Tools.FhirConstructTests
{
    /// <summary>
    /// Test the output test files generated in FhirKhit.ProfGen.XUnitTests.
    /// XUnitTests generated files in this project which are compiled and then
    /// tests are executed on the compiled output classes.
    /// </summary>
    public class CodeGenerationTest
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
            //FhirElementAttribute attribute = pi.GetCustomAttribute<FhirElementAttribute>();
            //if (attribute == null)
            //    return;
            //if (attribute.IsPrimitiveValue)
            //{
            //    FixElementPrimitive(code, pi, varName, attribute);
            //    return;
            //}

            FhirElementAttribute attribute = pi.GetCustomAttribute<FhirElementAttribute>();
            if (attribute == null)
                return;


            String name = pi.PropertyType.FriendlyName();
            //code.AppendCode($"block.AppendCode(\"// Set {pi.Name} of type {name})\");");
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
                            .AppendCode($"    block.AppendCode($\"{retValName}.{pi.Name} = new {typeName}();\");")
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
                .AppendCode($"return Construct(block, ({csTypeName})fix, methodName, methodAccess);")
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
                .AppendCode($"    String methodAccess = \"public\")")
                .OpenBrace()
                //.AppendCode($"const String fcn = \"Construct({fhirTypeName})\";")
                .BlankLine()
                .AppendCode($"block")
                .AppendCode($"    .AppendCode($\"{{methodAccess}} {csTypeName} {{methodName}}()\")")
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

        bool Ignore(FHIRAllTypes fhirType)
        {
            switch (fhirType)
            {
                case FHIRAllTypes.Resource:
                case FHIRAllTypes.DomainResource:
                case FHIRAllTypes.BackboneElement:
                case FHIRAllTypes.Element:
                    return true;
                default:
                    return false;
            }
        }

        void ConstructDataType(CodeBlockNested methods,
        CodeBlockNested construct,
        FHIRAllTypes fhirType)
        {
            if (Ignore(fhirType))
                return;

            String fhirTypeName = ModelInfo.FhirTypeToFhirTypeName(fhirType);
            Type csType = ModelInfo.GetTypeForFhirType(fhirTypeName);
            String csTypeName = csType.FriendlyName();

            construct
                .AppendCode($"case \"{fhirTypeName}\": // {fhirType}  - DataType")
                .OpenBrace()
                .AppendCode($"propertyType = \"{fhirTypeName}\";")
                .AppendCode($"return Construct(block, ({csTypeName})fix, methodName, methodAccess);")
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
                .AppendCode($"    String methodAccess = \"public\")")
                .OpenBrace()
                //.AppendCode($"const String fcn = \"Construct({fhirTypeName})\";")
                .BlankLine()
                .AppendCode($"block")
                .AppendCode($"    .AppendCode($\"{{methodAccess}} {csTypeName} {{methodName}}()\")")
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

        /// <summary>
        /// Generate Construct method.
        /// </summary>
        [Fact(DisplayName = "CodeGeneration.FhirConstructA")]
        [Trait("CodeGen", "CodeGen")]
        public void FhirConstructA()
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
                .AppendLine($"using System.Diagnostics;")
                .AppendLine($"using Hl7.FhirPath;")
                .AppendLine($"using Range = Hl7.Fhir.Model.Range;")
                .BlankLine()
#if FHIR_R3
                .AppendLine($"namespace FhirKhit.Tools.R3")
#elif FHIR_R4
                .AppendLine($"namespace FhirKhit.Tools.R4")
#endif
                .OpenBrace()
                .AppendCode($"public static class FhirConstruct")
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
                .AppendCode($"    out String propertyType,")
                .AppendCode($"    String methodAccess = \"public\")")
                .OpenBrace()
                //.AppendCode($"const String fcn = \"Construct\";")
                .BlankLine()
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

            String outputPath = Path.Combine(DirHelper.FindParentDir("Tools"),
#if FHIR_R3
                "FhirKhit.Tools.R3",
#elif FHIR_R4
                "FhirKhit.Tools.R4",
#endif
                "FhirConstruct.cs");
            editor.Save(outputPath);
        }


        void SetFixFields(Base item)
        {
            foreach (PropertyInfo pi in item.GetType().GetProperties())
                SetFixField(pi, item);
        }

        void SetFixField(PropertyInfo pi,
            Base retVal)
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
                    pi.SetValue(retVal, new Nullable<bool>(true));
                    break;

                case "byte[]":
                    pi.SetValue(retVal, new byte[] { 1, 2, 3, 4 });
                    break;

                case "DateTimeOffset?":
                    pi.SetValue(retVal, DateTimeOffset.Now);
                    break;

                case "decimal?":
                    pi.SetValue(retVal, new Nullable<Decimal>((decimal)2.1));
                    break;

                case "int?":
                    pi.SetValue(retVal, new Nullable<Int32>(5));
                    break;

                case "string":
                    pi.SetValue(retVal, "String");
                    break;

                default:
                    if (name.StartsWith("Code<"))
                    {
                        Array enumValues = Enum.GetValues(pi.PropertyType.GenericTypeArguments[0]);
                        var code = Activator.CreateInstance(pi.PropertyType, enumValues.GetValue(0));
                        pi.SetValue(retVal, code);
                    }
                    else if (name.StartsWith("List<"))
                    {
                        Type listType = pi.PropertyType.GenericTypeArguments[0];
                        IList list = (IList)Activator.CreateInstance(pi.PropertyType);
                        for (Int32 i = 0; i < 5; i++)
                        {
                            Base item = (Base)Activator.CreateInstance(listType);
                            SetFixFields(item);
                            list.Add(item);
                        }
                        pi.SetValue(retVal, list);
                    }
                    else if (name.EndsWith("?"))
                    {
                        Type nullableType = pi.PropertyType.GenericTypeArguments[0];
                        if (nullableType.IsEnum)
                        {
                            var enumValue = Enum.GetValues(nullableType).GetValue(0);
                            pi.SetValue(retVal, Activator.CreateInstance(pi.PropertyType, enumValue));
                        }
                        else if (nullableType.IsClass)
                        {
                            Base nullableItem = (Base)Activator.CreateInstance(nullableType);
                            SetFixFields(nullableItem);
                            pi.SetValue(retVal, Activator.CreateInstance(pi.PropertyType, nullableItem));
                        }
                        else
                            throw new NotImplementedException();
                    }
                    else
                    {
                        Base item = (Base)Activator.CreateInstance(pi.PropertyType);
                        pi.SetValue(retVal, item);
                        SetFixFields(item);
                    }
                    return;
            }
        }

        Element CreateFix(Type fhirCSType)
        {
            Trace.WriteLine("CreateFix");
            Element retVal = (Element)Activator.CreateInstance(fhirCSType);
            SetFixFields(retVal);
            return retVal;
        }

        /// <summary>
        /// Use FhirConstruct method to generate code to test each element.
        /// There is no test to run the code, but compiling it shows that the
        /// code generated is correct syntactically, if not semantically.
        /// </summary>
        [Fact(DisplayName = "CodeGeneration.FhirConstructB")]
        [Trait("CodeGen", "CodeGen")]
        public void FhirConstructB()
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
                .AppendLine($"using System.Diagnostics;")
                .AppendLine($"using Hl7.FhirPath;")
                .AppendLine($"using Range = Hl7.Fhir.Model.Range;")
                .BlankLine()
#if FHIR_R3
                .AppendLine($"namespace FhirKhit.Tools.R3")
#elif FHIR_R4
                .AppendLine($"namespace FhirKhit.Tools.R4")
#endif
                .OpenBrace()
                .AppendCode($"public class FhirConstructUse")
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
                .AppendLine($"/// generate code for eqch fhri element. Makes sure it compiles.")
                .AppendLine($"/// </summary>")
                .AppendCode($"public void Use()")
                .OpenBrace()
                .BlankLine()
                ;

            Int32 varNum = 0;
            foreach (FHIRAllTypes fhirType in Enum.GetValues(typeof(FHIRAllTypes)).OfType<FHIRAllTypes>())
            {
                Trace.WriteLine($"fhirType {fhirType}");
                String fhirTypeName = ModelInfo.FhirTypeToFhirTypeName(fhirType);
                Type fhirCSType = ModelInfo.GetTypeForFhirType(fhirTypeName);

                if (ModelInfo.IsPrimitive(fhirType))
                {
                    String varName1 = $"x{++varNum}";
                    String methodName1 = $"Method{++varNum}";

                    construct
                        .AppendCode($"{fhirCSType} {varName1} = {methodName1}();")
                        ;

                    Element fix = CreateFix(fhirCSType);
                    FhirConstruct.Construct(methods, fix, methodName1, out String propertyType1);
                }
                else if (ModelInfo.IsDataType(fhirType))
                {
                    if (Ignore(fhirType) == false)
                    {
                        String varName1 = $"x{++varNum}";
                        String methodName1 = $"Method{++varNum}";

                        construct
                        .AppendCode($"{fhirCSType} {varName1} = {methodName1}();")
                            ;

                        Element fix = CreateFix(fhirCSType);
                        FhirConstruct.Construct(methods, fix, methodName1, out String propertyType1);
                    }
                }
            }

            construct
                .CloseBrace()
                ;


            String outputPath = Path.Combine(DirHelper.FindParentDir("Tools"),
#if FHIR_R3
                "FhirKhit.Tools.R3.XUnitTests",
#elif FHIR_R4
                "FhirKhit.Tools.R4.XUnitTests",
#endif
            "FhirConstructUseTests.cs");
            editor.Save(outputPath);
        }

        /// <summary>
        /// Print out all primitive values used in api.
        /// </summary>
        [Fact(DisplayName = "CodeGeneration.ShowPrimitiveValues")]
        [Trait("CodeGen", "CodeGen")]
        void ShowPrimitiveValues()
        {
            List<String> primitives = new List<string>();
            List<String> nonPrimitives = new List<string>();

            foreach (FHIRAllTypes fhirType in Enum.GetValues(typeof(FHIRAllTypes)).OfType<FHIRAllTypes>())
            {
                String fhirTypeName = ModelInfo.FhirTypeToFhirTypeName(fhirType);
                Type csType = ModelInfo.GetTypeForFhirType(fhirTypeName);
                if (csType != null)
                {
                    foreach (PropertyInfo pi in csType.GetProperties())
                    {
                        FhirElementAttribute attribute = pi.GetCustomAttribute<FhirElementAttribute>();
                        if (attribute != null)
                        {
                            String friendlyName = pi.PropertyType.FriendlyName();
                            if (attribute.IsPrimitiveValue)
                            {
                                if (primitives.Contains(friendlyName) == false)
                                    primitives.Add(friendlyName);
                            }
                            else
                            {
                                if (nonPrimitives.Contains(friendlyName) == false)
                                    nonPrimitives.Add(friendlyName);
                            }
                        }
                    }
                }
            }

            Trace.WriteLine($"");
            Trace.WriteLine($"");
            Trace.WriteLine($"");
            Trace.WriteLine($"primitives");
            primitives.Sort();
            foreach (String primitive in primitives)
            {
                Trace.WriteLine($"case \"{primitive}\":");
            }


            Trace.WriteLine($"");
            Trace.WriteLine($"");
            Trace.WriteLine($"");
            Trace.WriteLine($"nonPrimitives");
            nonPrimitives.Sort();
            foreach (String nonPrimitive in nonPrimitives)
            {
                Trace.WriteLine($"case \"{nonPrimitive}\":");
            }
        }

        [Fact(DisplayName = "CodeGeneration.ShowPrimitives")]
        [Trait("CodeGen", "CodeGen")]
        void ShowPrimitives()
        {
            foreach (FHIRAllTypes fhirType in Enum.GetValues(typeof(FHIRAllTypes)).OfType<FHIRAllTypes>())
            {
                if (ModelInfo.IsPrimitive(fhirType))
                {
                    String fhirTypeName = ModelInfo.FhirTypeToFhirTypeName(fhirType);
                    if (ModelInfo.FhirTypeToCsType.TryGetValue(fhirTypeName, out Type csType) == false)
                        throw new Exception("");
                    Trace.WriteLine($"FHIRAllTypes.{fhirType}  FhirType {fhirTypeName} CSType {csType.FriendlyName()}");
                }
            }
        }
    }
}
