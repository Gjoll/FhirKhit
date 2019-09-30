using FhirKhit.Tools;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
using Xunit;

namespace FhirKhit.Maker.XUnitTests
{
    public class MakerGen
    {
        void GenerateComplex(FHIRAllTypes fhirType,
            String genDir)
        {
            Trace.WriteLine($"Generating fhir primitive '{fhirType}'");

            CodeEditor instanceEditor = new CodeEditor();
            CodeBlockNested instanceBlock = instanceEditor.Blocks.AppendBlock();

            CodeEditor collectionEditor = new CodeEditor();
            CodeBlockNested collectionBlock = collectionEditor.Blocks.AppendBlock();

            String instanceName = $"{fhirType.ToString()}_Instance";
            String collectionName = $"{fhirType.ToString()}_Collection";

            instanceBlock
                .AppendLine("using System;")
                .AppendLine("using System.Diagnostics;")
                .AppendLine("using System.IO;")
                .AppendLine("using System.Linq;")
                .AppendLine("using Hl7.Fhir.Model;")
                .BlankLine()
                .AppendCode("namespace FhirKhit.Maker.Common")
                .OpenBrace()
                .AppendCode($"public class {instanceName} : Complex_Instance")
                .OpenBrace()
                .DefineBlock(out CodeBlockNested fields)
                .CloseBrace()
                .CloseBrace()
                ;

            String fhirTypeName = ModelInfo.FhirTypeToFhirTypeName(fhirType);
            Type csType = ModelInfo.GetTypeForFhirType(fhirTypeName);

            //fields
            //;

            collectionBlock
                .AppendLine("using System;")
                .AppendLine("using System.Diagnostics;")
                .AppendLine("using System.IO;")
                .AppendLine("using System.Linq;")
                .AppendLine("using Hl7.Fhir.Model;")
                .BlankLine()
                .AppendCode("namespace FhirKhit.Maker.Common")
                .OpenBrace()
                .AppendCode($"public class {collectionName} : Complex_List<{instanceName}>")
                .OpenBrace()
                .CloseBrace()
                .CloseBrace()
                ;

            instanceEditor.Save(Path.Combine(genDir, $"{instanceName}.cs"));
            collectionEditor.Save(Path.Combine(genDir, $"{collectionName}.cs"));
        }

        void GeneratePrimitive(FHIRAllTypes fhirType,
            String genDir)
        {
            Trace.WriteLine($"Generating fhir primitive '{fhirType}'");

            CodeEditor instanceEditor = new CodeEditor();
            CodeBlockNested instanceBlock = instanceEditor.Blocks.AppendBlock();

            CodeEditor collectionEditor = new CodeEditor();
            CodeBlockNested collectionBlock = collectionEditor.Blocks.AppendBlock();

            String instanceName = $"{fhirType.ToString()}_Instance";
            String collectionName = $"{fhirType.ToString()}_Collection";

            instanceBlock
                .AppendLine("using System;")
                .AppendLine("using System.Diagnostics;")
                .AppendLine("using System.IO;")
                .AppendLine("using System.Linq;")
                .AppendLine("using Hl7.Fhir.Model;")
                .BlankLine()
                .AppendCode("namespace FhirKhit.Maker.Common")
                .OpenBrace()
                .AppendCode($"public class {instanceName} : Primitive_Instance")
                .OpenBrace()
                .CloseBrace()
                .CloseBrace()
                ;

            collectionBlock
                .AppendLine("using System;")
                .AppendLine("using System.Diagnostics;")
                .AppendLine("using System.IO;")
                .AppendLine("using System.Linq;")
                .AppendLine("using Hl7.Fhir.Model;")
                .BlankLine()
                .AppendCode("namespace FhirKhit.Maker.Common")
                .OpenBrace()
                .AppendCode($"public class {collectionName} : Primitive_List<{instanceName}>")
                .OpenBrace()
                .CloseBrace()
                .CloseBrace()
                ;

            instanceEditor.Save(Path.Combine(genDir, $"{instanceName}.cs"));
            collectionEditor.Save(Path.Combine(genDir, $"{collectionName}.cs"));
        }

        [Fact(DisplayName = "MakerGen.CreateBaseClasses")]
        [Trait("MakerGen", "MakerGen")]
        void CreateBaseClasses()
        {
            String primGenDir = Path.Combine(DirHelper.FindParentDir("Maker"), "FhirKhit.Maker.Common", "MClasses", "PrimitiveGen");
            DirHelper.CreateDirPath(primGenDir);
            DirHelper.CleanDir(primGenDir);

            String complexGenDir = Path.Combine(DirHelper.FindParentDir("Maker"), "FhirKhit.Maker.Common", "MClasses", "ComplexGen");
            DirHelper.CreateDirPath(complexGenDir);
            DirHelper.CleanDir(complexGenDir);

            foreach (FHIRAllTypes fhirType in Enum.GetValues(typeof(FHIRAllTypes)).OfType<FHIRAllTypes>())
            {
                if (ModelInfo.IsPrimitive(fhirType))
                    GeneratePrimitive(fhirType, primGenDir);
                else
                    GenerateComplex(fhirType, complexGenDir);
            }
        }
    }
}
