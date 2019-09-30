using FhirKhit.Tools;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
using Xunit;
using System.Reflection;
using Hl7.Fhir.Introspection;
using FhirKhit.Maker.Common;

namespace FhirKhit.Maker.XUnitTests
{
    public class MakerGenTests
    {
        void GenerateComplex(FHIRAllTypes fhirType,
            String genDir)
        {
            String fhirTypeName = ModelInfo.FhirTypeToFhirTypeName(fhirType);
            Type csType = ModelInfo.GetTypeForFhirType(fhirTypeName);
            if (csType == null)
                return;

            Trace.WriteLine($"Generating fhir complex '{fhirType}'");
            CodeEditor instanceEditor = new CodeEditor();
            CodeBlockNested instanceBlock = instanceEditor.Blocks.AppendBlock();

            String instanceName = $"{fhirType.ToString()}_Item";

            instanceBlock
                .AppendLine("using System;")
                .AppendLine("using System.Diagnostics;")
                .AppendLine("using System.IO;")
                .AppendLine("using System.Linq;")
                .AppendLine("using Hl7.Fhir.Model;")
                .BlankLine()
                .AppendCode("namespace FhirKhit.Maker.Common")
                .OpenBrace()
                .AppendCode($"public class {instanceName} : Complex_Item")
                .OpenBrace()
                .DefineBlock(out CodeBlockNested fields)
                .CloseBrace()
                .CloseBrace()
                ;

            foreach (PropertyInfo pi in csType.GetProperties())
            {
                FhirElementAttribute attribute = pi.GetCustomAttribute<FhirElementAttribute>();
                if (attribute != null)
                {
                    //String min;
                    //String max;
                    //Type csType;
                    if (pi.PropertyType.IsList())
                    {
                        //min = "0";
                        //max = "*";
                        //csType = pi.PropertyType.GenericTypeArguments[0];
                    }
                    if (pi.PropertyType.IsNullable())
                    {
                        //min = "0";
                        //max = "1";
                        //csType = pi.PropertyType.GenericTypeArguments[0];
                    }
                    else
                    {
                        //csType = pi.PropertyType;
                        //min = "1";
                        //max = "1";
                    }

                };
            }
            //fields
            //;

            instanceEditor.Save(Path.Combine(genDir, $"{instanceName}.cs"));
        }

        void GeneratePrimitive(FHIRAllTypes fhirType,
            String genDir)
        {
            Trace.WriteLine($"Generating fhir primitive '{fhirType}'");

            CodeEditor instanceEditor = new CodeEditor();
            CodeBlockNested instanceBlock = instanceEditor.Blocks.AppendBlock();

            String instanceName = $"{fhirType.ToString()}_Item";

            instanceBlock
                .AppendLine("using System;")
                .AppendLine("using System.Diagnostics;")
                .AppendLine("using System.IO;")
                .AppendLine("using System.Linq;")
                .AppendLine("using Hl7.Fhir.Model;")
                .BlankLine()
                .AppendCode("namespace FhirKhit.Maker.Common")
                .OpenBrace()
                .AppendCode($"public class {instanceName} : Primitive_Item")
                .OpenBrace()
                .CloseBrace()
                .CloseBrace()
                ;

            instanceEditor.Save(Path.Combine(genDir, $"{instanceName}.cs"));
        }

        [Fact(DisplayName = "MakerGen.CreateBaseClasses")]
        [Trait("MakerGen", "MakerGen")]
        void CreateBaseClasses()
        {
            String outputDir = Path.Combine(DirHelper.FindParentDir("Maker"), "FhirKhit.Maker.Common", "MClasses");
            MakerGen gen = new MakerGen(outputDir);
            gen.GenerateBaseClasses(outputDir);

            //foreach (FHIRAllTypes fhirType in Enum.GetValues(typeof(FHIRAllTypes)).OfType<FHIRAllTypes>())
            //{
            //    if (ModelInfo.IsPrimitive(fhirType))
            //        GeneratePrimitive(fhirType, genDir);
            //    else
            //        GenerateComplex(fhirType, genDir);
            //}
        }
    }
}
