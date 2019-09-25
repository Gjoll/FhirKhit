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

namespace FhirKhit.CIMPL.DirectFhir
{
    public class DirectFhirGenerator : ConverterBase, IDisposable
    {
        public class SDefInfo
        {
            public enum TypeFlag
            {
                Unknown,
                Group,
                Entry
            }
            public TypeFlag TFlag = TypeFlag.Unknown;

            public StructureDefinition SDef;
        };


        Bundle fhirSDefsBundle;
        HashSet<String> sliceFields = new HashSet<string>();
        HashSet<String> abbreviatedResourcesToProcess = new HashSet<string>();
        HashSet<String> resourcesToProcess = new HashSet<string>();
        HashSet<String> processedResources = new HashSet<string>();
        
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

        public String NSBase => "fhir";

        public void AddSpliceField(String path)
        {
            this.sliceFields.Add(path);
        }

        public String NameSpace(params String[] path)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{NSBase}");
            foreach (String pathItem in path)
                sb.Append($".{pathItem.ToLower()}");

            return sb.ToString();
        }


        /// <summary>
        /// Add path filter. if pathsToProcess has any members, then
        /// only resource paths that start with this will be processed.
        /// </summary>
        public void AddResourcePathToProcess(String path, bool abbrevFlag)
        {
            if (processedResources.Contains(path) == true)
                return;
            if (abbrevFlag == true)
                this.abbreviatedResourcesToProcess.Add(path);
            else
                this.resourcesToProcess.Add(path);
        }

        public void AddResourceToProcess(String name, bool abbrevFlag)
        {
            this.AddResourcePathToProcess($"http://hl7.org/fhir/StructureDefinition/{name}", abbrevFlag);
        }

        String FhirSDefsPath => Path.Combine(this.OutputDir, "StructureDefinitions.json");
        public String GeneratedPath => Path.Combine(this.OutputDir, "Generated");

        Bundle FhirSDefsBundle
        {
            get
            {
                if (this.fhirSDefsBundle == null)
                {
                    if (File.Exists(this.FhirSDefsPath) == false)
                        return null;

                    FhirJsonParser parser = new FhirJsonParser();
                    this.fhirSDefsBundle = parser.Parse<Bundle>(File.ReadAllText(this.FhirSDefsPath));
                }
                return this.fhirSDefsBundle;
            }
        }

        Dictionary<String, SDefInfo> items;
        ZipSource source;

        public DirectFhirGenerator()
        {
            this.source = new ZipSource("specification.zip");
            this.items = new Dictionary<string, SDefInfo>();
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
                .AppendLine($"Namespace: {this.NameSpace(path)}")
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
                .AppendLine($"Namespace: {this.NameSpace(path)}")
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
            ConvertFhirClass cfc = new ConvertFhirClass(this, sDefInfo);
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

            ConvertFhirClass cfc = new ConvertFhirClass(this, sDefInfo);
            cfc.Specialize();
        }

        /// <summary>
        /// Process one fhir element
        /// </summary>
        void ProcessFhirElementAbbreviated(SDefInfo sDefInfo)
        {
            const string fcn = "ProcessFhirElementAbbreviated";

            StructureDefinition sDef = sDefInfo.SDef;
            {
                CodeEditor entryEditor = this.CreateEntryEditor(sDef.Id);
                CodeBlockNested entryBlock = entryEditor.Blocks.AppendBlock();
                String typeName;
                switch (sDefInfo.TFlag)
                {
                    case DirectFhirGenerator.SDefInfo.TypeFlag.Entry:
                        typeName = "Entry";
                        break;
                    case DirectFhirGenerator.SDefInfo.TypeFlag.Group:
                        typeName = "Group";
                        break;
                    default:
                        throw new ConvertErrorException(this.GetType().Name, fcn, $"Invalid TFlag value");
                }
                entryBlock
                    .BlankLine()
                    .AppendCode($"{typeName}: {sDef.Id}")
                    ;
            }
            {
                CodeEditor mapEditor = this.CreateMapEditor(sDef.Id);
                CodeBlockNested mapBlock = mapEditor.Blocks.AppendBlock();
                mapBlock
                    .BlankLine()
                    .AppendCode($"{sDef.Id} maps to {sDef.Id}:")
                    ;
            }
        }

        /// <summary>
        /// Process one fhir element
        /// </summary>
        void ProcessFhirElement(SDefInfo sDefInfo)
        {
            const string fcn = "ProcessFhirElement";

            StructureDefinition sDef = sDefInfo.SDef;
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

        /// <summary>
        /// To save time, store all structure definitions in a fhir bundle file. This need only be run when we get a new 
        /// FHIR version.
        /// </summary>
        void StoreFhirElements()
        {
            // const String fcn = "StoreFhirElements";

            this.fhirSDefsBundle = new Bundle();
            foreach (string uri in this.source.ListResourceUris())
            {
                StructureDefinition sDef = this.source.ResolveByUri(uri) as StructureDefinition;
                if (sDef != null)
                {
                    // This is to get rid of the http://....//de-... entries.
                    if (sDef.Snapshot.Element[0].Path.Split('.').Length == 1)
                        this.fhirSDefsBundle.AddResourceEntry(sDef, sDef.Url);
                }
            }
            this.fhirSDefsBundle.SaveJson(this.FhirSDefsPath);
        }

        void LoadFhirElements()
        {
            const String fcn = "LoadFhirElements";

            this.ConversionInfo(this.GetType().Name, fcn, "Loading Fhir structure definitions");
            foreach (StructureDefinition sDef in this.FhirSDefsBundle.GetResources())
            {
                SDefInfo sDefInfo = new SDefInfo
                {
                    SDef = sDef
                };

                switch (sDef.Url)
                {
                    case "http://hl7.org/fhir/StructureDefinition/Element":
                        sDefInfo.TFlag = SDefInfo.TypeFlag.Group;
                        break;

                    case "http://hl7.org/fhir/StructureDefinition/Resource":
                        sDefInfo.TFlag = SDefInfo.TypeFlag.Entry;
                        break;
                    default:
                        sDefInfo.TFlag = SDefInfo.TypeFlag.Unknown;
                        break;
                }

                this.items.Add(sDef.Url, sDefInfo);
            }
        }

        SDefInfo GetTypedSDef(String path)
        {
            const String fcn = "GetTypedSDef";

            this.AddResourcePathToProcess(path, false);
            if (this.items.TryGetValue(path, out SDefInfo sDef) == false)
                throw new ConvertErrorException(this.GetType().Name, fcn, $"Internal error. Item {path} not in dictionary");

            // If TFlag s unknown, use parents TFlag value.
            if (sDef.TFlag == SDefInfo.TypeFlag.Unknown)
            {
                SDefInfo parentInfo = this.GetTypedSDef(sDef.SDef.BaseDefinition);
                sDef.TFlag = parentInfo.TFlag;
            }

            return sDef;
        }

        void ProcessAllFhirElements()
        {
            foreach (string path in this.items.Keys)
            {
                SDefInfo sDef = this.GetTypedSDef(path);
                this.ProcessFhirElement(sDef);
            }
        }

        void ProcessRequestedFhirElements()
        {
            while (this.resourcesToProcess.Count > 0)
            {
                String key = this.resourcesToProcess.ElementAt(0);
                this.resourcesToProcess.Remove(key);
                if (processedResources.Contains(key) == false)
                {
                    processedResources.Add(key);
                    SDefInfo sDef = this.GetTypedSDef(key);
                    this.ProcessFhirElement(sDef);
                }
            }


            // Output those resources that we just create an entry for (no properties).
            // These will define entries that we can reference, w/o the overhead of defining
            // the properties and such.
            while (this.abbreviatedResourcesToProcess.Count > 0)
            {
                String key = this.abbreviatedResourcesToProcess.ElementAt(0);
                this.abbreviatedResourcesToProcess.Remove(key);
                if (processedResources.Contains(key) == false)
                {
                    processedResources.Add(key);
                    SDefInfo sDef = this.GetTypedSDef(key);
                    this.ProcessFhirElementAbbreviated(sDef);
                }
            }
        }

        /// <summary>
        /// Process all fhir elements.
        /// </summary>
        void ProcessFhirElements()
        {
            const String fcn = "ProcessFhirElements";
            if (this.resourcesToProcess.Count > 0)
                ProcessRequestedFhirElements();
            else
                ProcessAllFhirElements();

            this.ConversionInfo(this.GetType().Name, fcn, "Saving CIMPL classes");
            foreach (CodeEditor ce in this.editorDict.Values)
                ce.Save();
            this.editorDict.Clear();
        }

        public Int32 CreateBundle()
        {
            try
            {
                this.StoreFhirElements();
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

                if (File.Exists(this.FhirSDefsPath) == false)
                    this.StoreFhirElements();

                this.LoadFhirElements();
                this.ProcessFhirElements();
            }
            catch (ConvertErrorException err)
            {
                this.ConversionError(err.FileName, err.MethodName, err.Message);
            }
            catch (Exception err)
            {
                this.ConversionError(this.GetType().Name, "Execute", err.Message);
            }

            this.ConversionInfo(this.GetType().Name, fcn, "Completed generation of CIMPL classes");
            return this.Errors.Any() ? -1 : 0;
        }

        public void Dispose()
        {
        }
    }
}
