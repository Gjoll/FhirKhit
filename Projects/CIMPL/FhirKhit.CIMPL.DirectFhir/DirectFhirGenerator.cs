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
        List<String> abbreviatedResourcesToProcess = new List<string>();
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

        /// <summary>
        /// Add path filter. if pathsToProcess has any members, then
        /// only resource paths that start with this will be processed.
        /// </summary>
        public void AddAbbreviatedResource(String path)
        {
            if (processedResources.Contains(path) == true)
                return;
            if (path.StartsWith("http:") == false)
                path = $"http://hl7.org/fhir/StructureDefinition/{path}";
            this.abbreviatedResourcesToProcess.Add(path);
        }

        public String GeneratedPath => Path.Combine(this.OutputDir, "Generated");

        Dictionary<String, SDefInfo> items;

        FhirStructureDefinitions sDefs;

        public DirectFhirGenerator()
        {
            String sDefsPath = Path.Combine(this.OutputDir, "StructureDefinitions.json");
            String specPath = Path.GetFullPath("specification.zip");
            sDefs = new FhirStructureDefinitions();
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

        void LoadFirEntryNames()
        {

        }

        void LoadFhirElements()
        {
            const String fcn = "LoadFhirElements";

            this.ConversionInfo(this.GetType().Name, fcn, "Loading Fhir structure definitions");
            foreach (StructureDefinition sDef in this.sDefs.FhirSDefs.GetResources())
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

            this.AddResource(path);
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

        void ProcessAbbreviatedResource(String key)
        {
            if (processedResources.Contains(key) == true)
                return;
            if (this.IgnoreResource(key) == true)
                return;

            processedResources.Add(key);
            SDefInfo sDef = this.GetTypedSDef(key);
            this.ProcessFhirElementAbbreviated(sDef);
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

            // Output those resources that we just create an entry for (no properties).
            // These will define entries that we can reference, w/o the overhead of defining
            // the properties and such.
            index = 0;
            while (index < this.abbreviatedResourcesToProcess.Count)
            {
                String key = this.abbreviatedResourcesToProcess.ElementAt(index++);
                ProcessAbbreviatedResource(key);
            }
        }

        public Int32 CreateBundle()
        {
            try
            {
                this.sDefs.StoreFhirElements();
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

        void CheckNameCollisions()
        {
            foreach (String key in propertyNames.Keys)
            {
                propertyNames.TryGetValue(key, out List<TypePathTuple> collisions);
                if (collisions.Count != 1)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("-");
                    sb.AppendLine($"Name collision: {key}");
                    foreach (TypePathTuple collision in collisions)
                    {
                        foreach (ElementDefinition.TypeRefComponent type in collision.types)
                        {
                            sb.AppendLine($"    Type: '{type.Code}'");
                            foreach (String profile in type.Profile)
                                sb.AppendLine($"        Profile={profile}");
                            foreach (String profile in type.TargetProfile)
                                sb.AppendLine($"        TargetProfile={profile}");
                        }
                        sb.AppendLine($"");
                        foreach (String path in collision.paths)
                            sb.AppendLine($"    Path: '{path}'");
                        sb.AppendLine($"-");
                    }
                    this.ConversionError(this.GetType().Name, "", sb.ToString());
                }
            }
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

                // Add each fhir property name as a unique name so no
                // properties are named the same.
                foreach (SDefInfo sDefInfo in this.items.Values)
                    this.UniquePropertyName(sDefInfo.SDef.Snapshot.Element[0], out bool dummy);

                this.ProcessRequestedFhirElements();

                this.ConversionInfo(this.GetType().Name, fcn, "Saving CIMPL classes");
                foreach (CodeEditor ce in this.editorDict.Values)
                    ce.Save();
                this.editorDict.Clear();
                this.ConversionInfo(this.GetType().Name, fcn, "Completed generation of CIMPL classes");
                CheckNameCollisions();
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

        // Keep track of property names assigned to items of a specific type, 
        // defined by the Fhir TypeRef{} array
        public class TypePathTuple
        {
            public List<ElementDefinition.TypeRefComponent> types;
            public List<String> paths = new List<string>();

            public TypePathTuple(ElementDefinition ed)
            {
                this.types = ed.Type;
                paths.Add(ed.Path);
            }

            public TypePathTuple(List<ElementDefinition.TypeRefComponent> types, string path)
            {
                this.types = types;
                paths.Add(path);
            }
        }

        Dictionary<String, List<TypePathTuple>> propertyNames = new Dictionary<String, List<TypePathTuple>>();

        String UniquePropertyName(String pName, ElementDefinition ed, out bool createFlag)
        {
            if (this.propertyNames.TryGetValue(pName, out List<TypePathTuple> nameTypes) == false)
            {
                createFlag = true;
                List<TypePathTuple> tupleList = new List<TypePathTuple>();
                tupleList.Add(new TypePathTuple(ed));
                this.propertyNames.Add(pName, tupleList);
                return pName;
            }

            foreach (TypePathTuple tuple in nameTypes)
            {
                // if old element and this one have same type, then use same definition.
                if (ed.Type.IsExactly(tuple.types))
                {
                    createFlag = false;
                    tuple.paths.Add(ed.Path);
                    return pName;
                }
            }

            nameTypes.Add(new TypePathTuple(ed));
            createFlag = true;
            return pName;
        }

        public String UniquePropertyName(ElementDefinition ed, out bool createFlag)
        {
            String pName = this.GetFieldMap(ed.Path);
            String retVal = UniquePropertyName(pName, ed, out createFlag);
            return retVal;
        }
    }
}
