using FhirKhit.SliceGen;
using FhirKhit.Tools;
using Hl7.Fhir.Model;
using System;
using System.Linq;
using System.IO;
using Xunit;
using System.Text;
using Hl7.Fhir.Serialization;
using FhirKhit.SliceGen.CSApi;
using System.Reflection;
using Hl7.Fhir.Introspection;
using System.Collections.Generic;
using System.Diagnostics;
using System.Collections;
using FhirKhit.SliceGen.R4;


#if FHIR_R2
using FhirKhit.Tools.R2;
#elif FHIR_R3
using FhirKhit.Tools.R3;
#elif FHIR_R4
using FhirKhit.Tools.R4;
#endif

namespace FhirKhit.SliceGen.XUnitTestsA
{
    /// <summary>
    /// Test the output test files generated in FhirKhit.SliceGen.XUnitTests.
    /// XUnitTests generated files in this project which are compiled and then
    /// tests are executed on the compiled output classes.
    /// </summary>
    public class CodeGenerationTest
    {

        /// <summary>
        /// Generate Fix code method.
        /// </summary>
        [Fact(DisplayName = "CodeGen.GenerateElementFixCode")]
        [Trait("CodeGen", "CodeGen")]
        public void GenerateElementFixCode()
        {
            String outputPath = Path.Combine(DirHelper.FindParentDir("Projects"),
                "SliceGen",
                "R4",
                "FhirKhit.SliceGen.R4",
                "CSApi",
                "ElementFixCode.cs");

            GenerateFixCode g = new GenerateFixCode();
            g.Generate(outputPath);
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
                    if (pi.PropertyType.IsCode())
                    {
                        Array enumValues = Enum.GetValues(pi.PropertyType.GenericTypeArguments[0]);
                        var code = Activator.CreateInstance(pi.PropertyType, enumValues.GetValue(0));
                        pi.SetValue(retVal, code);
                    }
                    else if (pi.PropertyType.IsList())
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
                    else if (pi.PropertyType.IsNullable())
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

        void GenerateFindCommonChild(CodeBlockNested construct,
            CodeBlockNested methods,
            FHIRAllTypes fhirType)
        {
            Trace.WriteLine($"fhirType {fhirType}");
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
                .AppendCode($"ElementNode {methodName}(String parentPath, String childName)")
                .OpenBrace()
                .AppendCode($"ElementNode retVal;")
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
                        .AppendCode($"retVal = new ElementNode(this, e, typeof({pi.PropertyType.FriendlyName()}), nameof({fhirCSType.FriendlyName()}.{pi.Name}));")
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

        /// <summary>
        /// Create the AddChildXXX methods of ElementNode.
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
                .AppendLine($"namespace FhirKhit.SliceGen.R4")
                .OpenBrace()
                .AppendCode($"public partial class ElementNode")
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
                .Summary($"Create ElementNode for child of common/primitive Fhir data type elements")
                .SummaryClose()
                .AppendCode($"public ElementNode FindCommonChild(String parentPath, String childName)")
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
            GenerateFindCommonChild(construct, methods, FHIRAllTypes.MoneyQuantity);
            GenerateFindCommonChild(construct, methods, FHIRAllTypes.SimpleQuantity);

            GenerateFindCommonChild(construct, methods, FHIRAllTypes.Extension);

            construct
                .AppendCode($"default: return null;")
                .CloseBrace()
                .CloseBrace()
                ;

#if FHIR_R2
            String outputPath = Path.Combine(DirHelper.FindParentDir("Projects"),
                "SliceGen",
                "R2",
                "FhirKhit.SliceGen.R2",
                "CodeGen",
                "ElementNode.FindChild.cs");
#elif FHIR_R3
            String outputPath = Path.Combine(DirHelper.FindParentDir("Projects"),
                "SliceGen",
                "R3",
                "FhirKhit.SliceGen.R3",
                "CodeGen",
                "ElementNode.FindChild.cs");
#elif FHIR_R4
            String outputPath = Path.Combine(DirHelper.FindParentDir("Projects"),
                "SliceGen",
                "R4",
                "FhirKhit.SliceGen.R4",
                "CodeGen",
                "ElementNode.FindChild.cs");
#endif
            editor.Save(outputPath);
        }

        /// <summary>
        /// Print out all primitive values used in api.
        /// </summary>
        [Fact(DisplayName = "CodeGen.ShowPrimitiveValues")]
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

        [Fact(DisplayName = "CodeGen.ShowPrimitives")]
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
