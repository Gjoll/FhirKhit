using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace PreFhir
{
    /*
        c)	ElementDefinition.sliceName & ElementDefinition.sliceConstraining & ElementDefinition.slicing TBD.
        e)	ElementDefinition.code. All the code values defined in the profile fragments and the base profile would end up in the code field.
        f)	ElementDefinition.short, ElementDefinition.definition, ElementDefinition.comment, ElementDefinition.requirements. All the strings in each profile fragment would be collated together into the output profile comment field of the same name.
        g)	ElementDefinition.alias. All the aliases defined in the base profile and the profile fragments would be collated and output in the output profile’s alias field.
        l)	ElementDefinition.defaultValue, ElementDefinition.fixed, ElementDefinition.pattern, ElementDefinition.minValue and ElementDefinition.maxValue must be empty or must be identical to the same field value defined in any other fragment or the profile base
        m)	example. All exampled defined will be included in output example.
        n)	ElementDefinition.maxLength. The minimum ElementDefinition.maxLength of all fragments will be output.
        o)	ElementDefinition.Condition. All condition items will be collated and output.
        p)	ElementDefinition.mustSupport. If any fragment or the base defines ElementDefinition.mustSupport, then this will be true in the output.
        q)	ElementDefinition.isModifier. If any fragment or the base defines ElementDefinition.isModifier , then this will be true in the output.
        ElementDefinition.isModifiedReason will all be collated and output in one string.
        r)	ElementDefinition.isSummary??
        s)	ElementDefinition.binding??
        t)	ElementDefinition.Mapping. All mapping elements will be collated and output.
     */
    public class PreFhirGenerator : ConverterBase
    {
        public bool DebugFlag { get; set; } = true;
        Dictionary<String, ProcessItem> processed = new Dictionary<string, ProcessItem>();
        Dictionary<String, ProcessItem> unProcessed = new Dictionary<string, ProcessItem>();
        public String CacheDir;

        public const String FragmentUrl = "http://www.fragment.com/fragment";

        static bool initFlag = false;

        public PreFhirGenerator()
        {
        }

        DomainResource Load(String path)
        {
            const String fcn = "Load";

            try
            {
                switch (Path.GetExtension(path).ToUpper())
                {
                    case ".XML":
                        {
                            FhirXmlParser parser = new FhirXmlParser();
                            return parser.Parse<DomainResource>(File.ReadAllText(path));
                        }
                    case ".JSON":
                        {
                            FhirJsonParser parser = new FhirJsonParser();
                            return parser.Parse<DomainResource>(File.ReadAllText(path));
                        }

                    default:
                        {
                            this.ConversionError(this.GetType().Name, fcn, $"Unknown extension for serialized fhir resource '{path}'");
                            return null;
                        }
                }
            }
            catch (Exception err)
            {
                this.ConversionError(this.GetType().Name, fcn, $"Error loading '{path}'. {err.Message}");
                return null;
            }
        }

        public void AddDir(String path, String searchPattern)
        {
            foreach (String filePath in Directory.GetFiles(path, searchPattern))
                this.AddFragment(filePath);

            foreach (String subDir in Directory.GetDirectories(path))
                AddDir(subDir, searchPattern);
        }

        public void AddFragment(String path)
        {
            DomainResource domainResource = this.Load(path);
            AddFragment(domainResource.GetUrl(), domainResource);
        }

        public void AddFragment(ValueSet frag)
        {
            AddFragment(frag.Url, frag);
        }

        public void AddFragment(CodeSystem frag)
        {
            AddFragment(frag.Url, frag);
        }

        public void AddFragment(StructureDefinition frag)
        {
            AddFragment(frag.Url, frag);
        }

        public void AddFragment(String url, DomainResource frag)
        {
            if (frag != null)
            {
                ProcessItem pi = new ProcessItem(this, frag);
                this.unProcessed.Add(url, pi);
            }
        }

        public bool Process()
        {
            const String fcn = "Process";

            if (initFlag == false)
            {
                if (this.CacheDir == null)
                    throw new Exception($"Cache dir must be set");
                FhirStructureDefinitions.Create(Path.Combine(CacheDir, "DefinitionCache"));
                initFlag = true;
            }

            bool retVal = true;
            // Process each unprocessed item, until none are left or we cant process any more...
            while (this.unProcessed.Values.Count > 0)
            {
                ProcessItem processable = this.FindProcessable();
                if (processable == null)
                {
                    this.ConversionError(this.GetType().Name,
                        fcn,
                        $"Unprocessable fragments. Possible circular reference in fragments");
                    foreach (var fragment in this.unProcessed.Values)
                    {
                        this.ConversionError(this.GetType().Name,
                            fcn,
                            $"Unprocessed fragment: {fragment.Resource.GetName()}");
                        return false;
                    }
                }

                if (Process(processable) == false)
                    retVal = false;
                else
                    this.processed.Add(processable.Resource.GetUrl(), processable);
            }
            if (retVal == true)
                FixDifferentials();
            return retVal;
        }

        void FixDifferentials()
        {
            foreach (ProcessItem processedItem in this.processed.Values)
            {
                switch (processedItem.Resource)
                {
                    case StructureDefinition sDef:
                        // Fragments just have all their elements in the differential.
                        // Profiles have differences from base in differential.
                        // Compute differences from base.
                        if (processedItem.FragmentFlag == false)
                        {
                            ElementTreeDiffer differ = new ElementTreeDiffer(this);
                            if (differ.Process(processedItem.TreeNodeOriginal, processedItem.TreeNode) == false)
                                return;
                        }
                        List<ElementDefinition> elementDefinitions = new List<ElementDefinition>();
                        processedItem.TreeNode.CopyTo(elementDefinitions);
                        sDef.Differential.Element = elementDefinitions;
                        SnapshotCreator.Create(sDef);
                        break;
                }
            }
        }

        /// <summary>
        /// Save all processed resources to the indicated dir.
        /// </summary>
        /// <param name="outputDir"></param>
        public void SaveResources(String outputDir)
        {
            foreach (ProcessItem processedItem in this.processed.Values)
                SaveResource(outputDir, processedItem);
        }

        /// <summary>
        /// Save resource to the indicated dir.
        /// </summary>
        /// <param name="outputDir"></param>
        void SaveResource(String outputDir,
            ProcessItem processedItem)
        {
            processedItem.Resource.RemoveExtension(FragmentUrl);
            switch (processedItem.Resource)
            {
                case StructureDefinition sDef:
                    processedItem.Resource.SaveJson(Path.Combine(outputDir, $"StructureDefinition-{sDef.Name}.json"));
                    break;

                case CodeSystem codeSys:
                    processedItem.Resource.SaveJson(Path.Combine(outputDir, $"CodeSystem-{codeSys.Name}.json"));
                    break;

                case ValueSet valueSet:
                    processedItem.Resource.SaveJson(Path.Combine(outputDir, $"ValueSet-{valueSet.Name}.json"));
                    break;

                default:
                    throw new NotImplementedException($"Unimplemented type {processedItem.GetType().Name}");
            }
        }

        ProcessItem FindProcessable()
        {
            // keep list of ones we are checking to stop infinite circular references.
            HashSet<String> checking = new HashSet<string>();

            bool IsParentProcessed(StructureDefinition structureDefinition)
            {
                // processable if base definition is DomainResource or has already been processed.
                String baseDef = structureDefinition.BaseDefinition;
                if (checking.Contains(baseDef))
                    return false;

                switch (baseDef)
                {
                    case null:
                    case "":
                    case "http://hl7.org/fhir/StructureDefinition/DomainResource":
                        return true;

                    default:
                        if (this.processed.ContainsKey(baseDef) == true)
                            return true;
                        if (FhirStructureDefinitions.Self.GetResource(baseDef) != null)
                            return true;
                        return false;
                }
            }

            bool Processable(DomainResource domainResource)
            {
                switch (domainResource)
                {
                    case StructureDefinition structureDefinition:
                        // processable if base definition is DmainResource or has already been processed.
                        if (IsParentProcessed(structureDefinition) == false)
                            return false;
                        break;
                }

                // Can only process this fragment if all referenced fragments have been processed.
                foreach (String referencedFragment in domainResource.ReferencedFragments())
                {
                    if (this.processed.ContainsKey(referencedFragment) == false)
                        return false;
                }
                return true;
            }

            foreach (ProcessItem item in this.unProcessed.Values)
            {
                if (checking.Contains(item.Resource.GetUrl()) == false)
                {
                    checking.Add(item.Resource.GetUrl());
                    if (Processable(item.Resource))
                    {
                        this.unProcessed.Remove(item.Resource.GetUrl());
                        return item;
                    }
                }
            }
            return null;
        }

        bool Process(ProcessItem processItem)
        {
            const String fcn = "Process";

            String type = processItem.FragmentFlag ? "fragment" : "resource";
            this.ConversionInfo(this.GetType().Name,
                fcn,
                $"Processing {type} {processItem.Resource.GetName()}");
            foreach (String fragmentUrl in processItem.Resource.ReferencedFragments())
            {
                if (this.processed.TryGetValue(fragmentUrl, out ProcessItem fragment) == false)
                    throw new Exception("Processed fragment {fragmentUrl} not found in processed dictionary");
                this.ConversionInfo(this.GetType().Name,
                    fcn,
                    $"Merging fragment {fragment.SDef.Name} into {processItem.Resource.GetName()}");
                Merger m = new Merger(this, processItem, fragment);
                if (m.Merge() == false)
                {
                    this.ConversionError(this.GetType().Name, fcn, $"Merge of fragment {fragment.Resource.GetName()} into {processItem.Resource.GetName()} failed ");
                    return false;
                }
            }
            return true;
        }
    }
}
