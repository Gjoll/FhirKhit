using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Specification.Source;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;

namespace FriendlyFhir
{
    public class FriendlyFhirGenerator : ConverterBase, IDisposable
    {

        HashSet<String> sliceFields = new HashSet<string>();
        List<String> resourcesToProcess = new List<string>();
        HashSet<String> processedResources = new HashSet<string>();
        HashSet<String> resourcesToIgnore = new HashSet<string>();

        public bool IsSliceField(String s) => this.sliceFields.Contains(s);

        public String OutputDir
        {
            get { return this.outputDir; }
            set
            {
                this.outputDir = value;
                if (Directory.Exists(this.GeneratedPath) == false)
                    Directory.CreateDirectory(this.GeneratedPath);
                else
                    DirHelper.CleanDir(this.GeneratedPath);
            }
        }
        String outputDir;

        public Dictionary<String, CodeEditor> editorDict = new Dictionary<string, CodeEditor>();
        Dictionary<String, String> fieldMaps = new Dictionary<string, string>();

        public String GetFieldMap(string path)
        {
            if (fieldMaps.TryGetValue(path, out String retVal) == false)
                retVal = path.LastPathPart();
            return retVal.ToMachineName();
        }

        public void AddFieldMap(string path, String name)
        {
            fieldMaps.Add(path, name);
        }
        public String NSBase => "fhir";

        public void AddSpliceField(String path)
        {
            this.sliceFields.Add(path);
        }

        public bool IgnoreResource(string path)
        {
            return this.resourcesToIgnore.Contains(path);
        }

        public void AddResourcePathToIgnore(String path)
        {
            if (path.StartsWith("http:") == false)
                path = $"http://hl7.org/fhir/StructureDefinition/{path}";
            this.resourcesToIgnore.Add(path);
        }

        /// <summary>
        /// Add path filter. if pathsToProcess has any members, then
        /// only resource paths that start with this will be processed.
        /// </summary>
        public void AddResource(String path)
        {
            if (processedResources.Contains(path) == true)
                return;
            if (path.StartsWith("http:") == false)
                path = $"http://hl7.org/fhir/StructureDefinition/{path}";
            this.resourcesToProcess.Add(path);
        }

        public String GeneratedPath => Path.Combine(this.OutputDir, "Generated");

        Dictionary<String, SDefInfo> items;

        public FriendlyFhirGenerator(String outputDir)
        {
            this.OutputDir = outputDir;
            String specPath = Path.GetFullPath("specification.zip");
            this.items = new Dictionary<string, SDefInfo>();

            FhirStructureDefinitions.Create(Path.Combine(this.OutputDir, "Cache"));
        }

        /// <summary>
        /// Converrt string to a desciption string
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public String ToDescription(Markdown description)
        {
            if (description is null)
                throw new ArgumentNullException(nameof(description));

            return description.ToString().Replace("\"", "'");
        }

        public CodeEditor CreateMapEditor(String path)
        {
            const String fcn = "CreateMapEditor";

            String mapName = $"{path}_map_r4";
            if (this.editorDict.ContainsKey(mapName) == true)
                throw new ConvertErrorException(this.GetType().Name, fcn, $"Path {path} has already been processed.");

            CodeEditor mapEditor = new CodeEditor();
            mapEditor.SavePath = Path.Combine(this.GeneratedPath, $"{mapName}.txt");

            CodeBlockNested mapBlock = mapEditor.Blocks.AppendBlock();
            mapBlock
                .AppendLine($"Grammar: Map 5.1")
                .AppendLine($"Namespace: fhir")
                .AppendLine($"Target: FHIR_R4")
                .BlankLine()
                ;

            this.editorDict.Add(mapName, mapEditor);
            return mapEditor;
        }

        /// <summary>
        /// Create code editor for new entry and save it in save editor list.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public CodeEditor CreateEntryEditor(String path)
        {
            const String fcn = "CreateEntryEditor";

            if (this.editorDict.ContainsKey(path) == true)
                throw new ConvertErrorException(this.GetType().Name, fcn, $"Path {path} has already been processed.");

            CodeEditor codeEditor = new CodeEditor();
            codeEditor.SavePath = Path.Combine(this.GeneratedPath, $"{path}.txt");
            CodeBlockNested block = codeEditor.Blocks.AppendBlock();
            block
                .AppendLine($"Grammar: DataElement 6.0")
                .AppendLine($"Namespace: fhir")
                .AppendLine($"Description: \"Fhir {path} definition. Autogenerated\"")
                .BlankLine()
                ;

            this.editorDict.Add(path, codeEditor);
            return codeEditor;
        }

        /// <summary>
        /// This creates a new class that is a constraint of the base class (no new elements except exceptions).
        /// </summary>
        /// <param name="sDefInfo"></param>
        void DoProcessFhirElementConstraint(SDefInfo sDefInfo)
        {
            const string fcn = "DoProcessFhirElementConstraint";

            StructureDefinition sDef = sDefInfo.SDef;
            this.ConversionInfo(this.GetType().Name, fcn, $"Processing Constraint {sDef.Url}");

            String parent = sDef.BaseDefinition?.LastUriPart();
            String description = this.ToDescription(sDef.Description);
            // remove items that derive directly from primitives.
            switch (parent)
            {
                case "boolean":
                case "integer":
                case "decimal":
                case "uri":
                case "string":
                case "base64Binary":
                case "instant":
                case "dateTime":
                case "time":
                case "oid":
                case "id":
                case "markdown":
                case "unsignedInt":
                case "positiveInt":
                case "xhtml":
                    this.ConversionInfo(this.GetType().Name, fcn, $"Ignoring '{sDef.Url}' because it derives from primitive '{parent}'");
                    return;
            }
            ClassGenerator cfc = new ClassGenerator(this, sDefInfo);
            cfc.Constrain();
        }

        void DoProcessFhirElementSpecialization(SDefInfo sDefInfo)
        {
            const string fcn = "ProcessSpecialiation";

            StructureDefinition sDef = sDefInfo.SDef;
            this.ConversionInfo(this.GetType().Name, fcn, $"Processing Specialization {sDef.Url}");

            String parent = sDef.BaseDefinition?.LastUriPart();
            String description = this.ToDescription(sDef.Description);
            // remove items that derive directly from primitives.
            switch (parent)
            {
                case "boolean":
                case "integer":
                case "decimal":
                case "uri":
                case "string":
                case "base64Binary":
                case "instant":
                case "dateTime":
                case "time":
                case "oid":
                case "id":
                case "markdown":
                case "unsignedInt":
                case "positiveInt":
                case "xhtml":
                    this.ConversionInfo(this.GetType().Name, fcn, $"Ignoring '{sDef.Url}' because it derives from primitive '{parent}'");
                    return;
            }

            ClassGenerator cfc = new ClassGenerator(this, sDefInfo);
            cfc.Specialize();
        }

        /// <summary>
        /// Process one fhir element
        /// </summary>
        void ProcessFhirElement(SDefInfo sDefInfo)
        {
            const string fcn = "ProcessFhirElement";

            StructureDefinition sDef = sDefInfo.SDef;
            if (this.IgnoreResource(sDef.Url) == true)
                return;

            sDef.SaveJson(Path.Combine(this.GeneratedPath, $"{sDef.Id}.json"));

            String baseDefinition = sDef.BaseDefinition;
            switch (baseDefinition)
            {
                case null:
                    this.DoProcessFhirElementSpecialization(sDefInfo);
                    break;

                case "http://hl7.org/fhir/StructureDefinition/Extension":
                    break;

                default:
                    switch (sDef.Derivation)
                    {
                        case null:
                            return;

                        case StructureDefinition.TypeDerivationRule.Specialization:
                            this.DoProcessFhirElementSpecialization(sDefInfo);
                            break;

                        case StructureDefinition.TypeDerivationRule.Constraint:
                            //this.DoProcessFhirElementConstraint(sDefInfo);
                            break;

                        default:
                            throw new ConvertErrorException(this.GetType().Name, fcn, $"Internal error. Unknown derivation {sDef.Derivation}");
                    }
                    break;
            }
        }

        void LoadFhirElementResource(StructureDefinition sDef)
        {
            //const String fcn = "LoadFhirElement";

            // This is to eliminate the derived types. For now, 
            // we only want to do that base resource types.
            //if (sDef.Type != sDef.Name)
            //{
            //    this.ConversionWarn(this.GetType().Name, fcn, $"Skipping derived class {sDef.Name}");
            //    return;
            //}
            SDefInfo sDefInfo = new SDefInfo(sDef);
            this.items.Add(sDef.Url, sDefInfo);
        }

        void LoadFhirElement(StructureDefinition sDef)
        {
            switch (sDef.Kind)
            {
                case StructureDefinition.StructureDefinitionKind.ComplexType:
                case StructureDefinition.StructureDefinitionKind.PrimitiveType:
                case StructureDefinition.StructureDefinitionKind.Resource:
                    LoadFhirElementResource(sDef);
                    break;
#if FHIR_R2
                    case StructureDefinition.StructureDefinitionKind.Datatype:
#endif
                case StructureDefinition.StructureDefinitionKind.Logical:
                    break;

                default:
                    throw new NotImplementedException($"{sDef.Name} hs Unknown kind '{sDef.Kind}");
            }
        }

        void LoadFhirElements()
        {
            const String fcn = "LoadFhirElements";

            this.ConversionInfo(this.GetType().Name, fcn, "Loading Fhir structure definitions");
            foreach (StructureDefinition sDef in FhirStructureDefinitions.Self.FhirSDefs.GetResources())
            {
                try
                {
                    LoadFhirElement(sDef);
                }
                catch (Exception err)
                {
                    this.ConversionWarn(this.GetType().Name, fcn, $"{sDef.Name} load failed. {err.Message}");
                }
            }
        }

        SDefInfo GetTypedSDef(String path)
        {
            const String fcn = "GetTypedSDef";

            this.AddResource(path);
            if (this.items.TryGetValue(path, out SDefInfo sDef) == false)
                throw new ConvertErrorException(this.GetType().Name, fcn, $"Internal error. Item {path} not in dictionary");

            return sDef;
        }

        void ProcessRequestedFhirElements()
        {
            Int32 index = 0;
            while (index < this.resourcesToProcess.Count)
            {
                String key = this.resourcesToProcess.ElementAt(index++);
                if (processedResources.Contains(key) == false)
                {
                    processedResources.Add(key);
                    SDefInfo sDef = this.GetTypedSDef(key);
                    this.ProcessFhirElement(sDef);
                }
            }
        }

        public Int32 CreateBundle()
        {
            try
            {
                FhirStructureDefinitions.Self.StoreFhirElements();
            }
            catch (ConvertErrorException err)
            {
                this.ConversionError(err.FileName, err.MethodName, err.Message);
            }
            catch (Exception err)
            {
                this.ConversionError(this.GetType().Name, "Execute", err.Message);
            }

            return this.Errors.Any() ? -1 : 0;
        }

        public Int32 GenerateBaseClasses()
        {
            const String fcn = "GenerateBaseClasses";

            try
            {
                if (String.IsNullOrEmpty(outputDir))
                    throw new ConvertErrorException(this.GetType().Name, fcn, $"OutputDir not set");

                this.ConversionInfo(this.GetType().Name, fcn, "Starting generation of CIMPL classes");

                this.LoadFhirElements();

                // if no elements to process defined, do them all.
                if (this.resourcesToProcess.Count == 0)
                {
                    foreach (string path in this.items.Keys)
                        this.resourcesToProcess.Add(path);
                }

                this.ProcessRequestedFhirElements();

                this.ConversionInfo(this.GetType().Name, fcn, "Saving CIMPL classes");
                foreach (CodeEditor ce in this.editorDict.Values)
                    ce.Save();
                this.editorDict.Clear();
                this.ConversionInfo(this.GetType().Name, fcn, "Completed generation of CIMPL classes");
            }
            catch (ConvertErrorException err)
            {
                this.ConversionError(err.FileName, err.MethodName, err.Message);
            }
            catch (Exception err)
            {
                this.ConversionError(this.GetType().Name, "Execute", err.Message);
            }

            return this.Errors.Any() ? -1 : 0;
        }

        public void Dispose()
        {
        }
    }
}
