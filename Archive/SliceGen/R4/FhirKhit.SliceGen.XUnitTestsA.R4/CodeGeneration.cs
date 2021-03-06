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
