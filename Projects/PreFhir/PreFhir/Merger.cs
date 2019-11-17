using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace PreFhir
{
    class Merger
    {
        ProcessItem baseItem;
        ProcessItem mergeItem;

        DomainResource mergeResource => mergeItem.Resource;
        DomainResource baseResource => baseItem.Resource;

        PreFhirGenerator preFhir;

        public Merger(PreFhirGenerator preFhir,
            ProcessItem baseItem,
            ProcessItem mergeItem)
        {
            this.preFhir = preFhir;
            this.baseItem = baseItem;
            this.mergeItem = mergeItem;
        }

        public bool Merge()
        {
            const String fcn = "Merge";

            try
            {
                if (this.preFhir.DebugFlag)
                    this.preFhir.ConversionInfo(this.GetType().Name,
                        fcn,
                        $"Merging Fragment '{mergeResource.GetName()}' into {baseResource.GetName()}");

                if (!MergeBase())
                    return false;

                switch (this.mergeResource)
                {
                    case StructureDefinition mergeSDef:
                        if (this.mergeItem.FragmentFlag == false)
                        {
                            this.preFhir.ConversionError(this.GetType().Name,
                                fcn,
                                $"Merge structure definition '{mergeSDef.GetName()}' must be a fragment ");
                            return false;
                        }

                        StructureDefinition baseSDef = baseResource as StructureDefinition;
                        if (baseSDef == null)
                        {
                            // Trying to merge a structured definition resource into a resource that is not
                            // a structured definition. Cane merge element definitions in this case.

                            // Dont declare an error if there are no ElementDefinition's defined in the merge resource.
                            if (mergeSDef.Differential.Element.Count <= 1)
                                return true;

                            // otherwise, we cant merge structuredef into non sdef.
                            this.preFhir.ConversionError(this.GetType().Name,
                                fcn,
                                $"Can not merge StructureDefinition fragment {mergeSDef.GetName()} into non StructureDefinition base {baseResource.GetName()}.");
                            return false;
                        }

                        if (!MergeElementDefinitions())
                            return false;
                        break;
                }
                return true;
            }
            catch (Exception err)
            {
                this.preFhir.ConversionError(this.GetType().Name,
                    fcn,
                    $"Exception processing fragment. {err.Message}");
                return false;
            }
        }

        public bool MergeBase()
        {
            bool retVal = true;
            FHIRVersion? fhirVersion = this.mergeResource.GetFhirVersion();
            String version = this.mergeResource.GetVersion();
            String date = this.mergeResource.GetDate();
            PublicationStatus? status = this.mergeResource.GetStatus();
            String publisher = this.mergeResource.GetPublisher();
            List<ContactDetail> contactDetail = this.mergeResource.GetContact();

            switch (baseResource)
            {
                case StructureDefinition sDef:
                    if (fhirVersion != null)
                    {
                        if ((sDef.FhirVersion != null) && (sDef.FhirVersion != fhirVersion))
                            throw new NotImplementedException($"Can not overwrite existing FhirVersion value in {sDef.Name} with value in {this.mergeResource.GetName()}");
                        sDef.FhirVersion = fhirVersion;
                    }
                    if (version != null)
                    {
                        if ((sDef.Version != null) && (sDef.Version != version))
                            throw new NotImplementedException($"Can not overwrite existing Version value in {sDef.Name} with value in {this.mergeResource.GetName()}");
                        sDef.Version = version;
                    }
                    if (date != null)
                    {
                        if ((sDef.Date != null) && (sDef.Date != date))
                            throw new NotImplementedException($"Can not overwrite existing Date value in {sDef.Name} with value in {this.mergeResource.GetName()}");
                        sDef.Date = date;
                    }
                    if (status != null)
                    {
                        if ((sDef.Status != null) && (sDef.Status != status))
                            throw new NotImplementedException($"Can not overwrite existing Status value in {sDef.Name} with value in {this.mergeResource.GetName()}");
                        sDef.Status = status;
                    }
                    if (publisher != null)
                    {
                        if ((sDef.Publisher != null) && (sDef.Status != status))
                            throw new NotImplementedException($"Can not overwrite existing Publisher value in {sDef.Name} with value in {this.mergeResource.GetName()}");
                        sDef.Publisher = publisher;
                    }
                    if (contactDetail != null)
                    {
                        if ((sDef.Contact != null) && (!sDef.Contact.Matches(contactDetail)))
                            throw new NotImplementedException($"Can not overwrite existing Contact value in {sDef.Name} with value in {this.mergeResource.GetName()}");
                        sDef.Contact = contactDetail;
                    }
                    break;

                case CodeSystem codeSys:
                    if (version != null)
                    {
                        if ((codeSys.Version != null) && (codeSys.Version != version))
                            throw new NotImplementedException($"Can not overwrite existing Version value in {codeSys.Name} with value in {this.mergeResource.GetName()}");
                        codeSys.Version = version;
                    }
                    if (date != null)
                    {
                        if ((codeSys.Date != null) && (codeSys.Date != date))
                            throw new NotImplementedException($"Can not overwrite existing Date value in {codeSys.Name} with value in {this.mergeResource.GetName()}");
                        codeSys.Date = date;
                    }
                    if (status != null)
                    {
                        if ((codeSys.Status != null) && (codeSys.Status != status))
                            throw new NotImplementedException($"Can not overwrite existing Status value in {codeSys.Name} with value in {this.mergeResource.GetName()}");
                        codeSys.Status = status;
                    }
                    if (publisher != null)
                    {
                        if ((codeSys.Publisher != null) && (codeSys.Status != status))
                            throw new NotImplementedException($"Can not overwrite existing Publisher value in {codeSys.Name} with value in {this.mergeResource.GetName()}");
                        codeSys.Publisher = publisher;
                    }
                    if (contactDetail != null)
                    {
                        if ((codeSys.Contact != null) && (!codeSys.Contact.Matches(contactDetail)))
                            throw new NotImplementedException($"Can not overwrite existing Contact value in {codeSys.Name} with value in {this.mergeResource.GetName()}");
                        codeSys.Contact = contactDetail;
                    }
                    break;

                case ValueSet valueSet:
                    if (version != null)
                    {
                        if ((valueSet.Version != null) && (valueSet.Version != version))
                            throw new NotImplementedException($"Can not overwrite existing Version value in {valueSet.Name} with value in {this.mergeResource.GetName()}");
                        valueSet.Version = version;
                    }
                    if (date != null)
                    {
                        if ((valueSet.Date != null) && (valueSet.Date != date))
                            throw new NotImplementedException($"Can not overwrite existing Date value in {valueSet.Name} with value in {this.mergeResource.GetName()}");
                        valueSet.Date = date;
                    }
                    if (status != null)
                    {
                        if ((valueSet.Status != null) && (valueSet.Status != status))
                            throw new NotImplementedException($"Can not overwrite existing Status value in {valueSet.Name} with value in {this.mergeResource.GetName()}");
                        valueSet.Status = status;
                    }
                    if (publisher != null)
                    {
                        if ((valueSet.Publisher != null) && (valueSet.Status != status))
                            throw new NotImplementedException($"Can not overwrite existing Publisher value in {valueSet.Name} with value in {this.mergeResource.GetName()}");
                        valueSet.Publisher = publisher;
                    }
                    if (contactDetail != null)
                    {
                        if ((valueSet.Contact != null) && (!valueSet.Contact.Matches(contactDetail)))
                            throw new NotImplementedException($"Can not overwrite existing Contact value in {valueSet.Name} with value in {this.mergeResource.GetName()}");
                        valueSet.Contact = contactDetail;
                    }
                    break;

                default:
                    throw new NotImplementedException($"Can not get value on unimplemented type {baseResource.GetType().Name}");
            }

            return retVal;
        }

        bool MergeElementDefinitions()
        {
            //const String fcn = "MergeElementDefinitions";

            ElementTreeLoader l = new ElementTreeLoader(this.preFhir);
            if (!MergeElementTreeSlice(baseItem.TreeNode.DefaultSlice, this.mergeItem.TreeNode.DefaultSlice))
                return false;
            return true;
        }

        bool MergeElementTreeNode(ElementTreeNode baseNode,
            ElementTreeNode mergeNode)
        {
            const String fcn = "MergeElementTreeNode";

            //this.preFhir.ConversionError(this.GetType().Name,
            //    fcn,
            //    $"Error constraining {mergeNode.Path}. Matching element not found in base profile's snapshot");

            bool retVal = true;
            foreach (ElementTreeSlice mergeSlice in mergeNode.Slices)
            {
                if (!baseNode.Slices.TryGetItem(mergeSlice.Name, out ElementTreeSlice baseSlice))
                {
                    // slice doesn't exist in base, so copy it whole.
                    if (this.preFhir.DebugFlag)
                        this.preFhir.ConversionInfo(this.GetType().Name,
                            fcn,
                            $"Slice '{mergeSlice.Name}' not found in base. Cloning node");
                    baseSlice = mergeSlice.Clone(baseNode);
                    baseSlice.ReplaceBasePath(this.baseItem.BasePath);
                    baseNode.Slices.Add(baseSlice);
                }
                else
                {
                    if (this.preFhir.DebugFlag)
                        this.preFhir.ConversionInfo(this.GetType().Name,
                            fcn,
                            $"Slice '{mergeSlice.Name}' found in base. Merging slice");
                    if (!Constrain(baseNode.ElementDefinition, mergeNode.ElementDefinition))
                        retVal = false;
                    if (!MergeElementTreeSlice(baseSlice, mergeSlice))
                        retVal = false;
                }
            }
            return retVal;
        }

        bool MergeElementTreeSlice(ElementTreeSlice baseSlice,
            ElementTreeSlice mergeSlice)
        {
            const String fcn = "MergeElementTreeSlice";

            bool retVal = true;
            foreach (ElementTreeNode mergeNode in mergeSlice.Nodes)
            {
                ElementTreeNode baseNode = null;
                if (!baseSlice.Nodes.TryGetItem(mergeNode.Name, out baseNode))
                {
                    // If base is not a fragment, we can not add new elements...
                    if (baseItem.FragmentFlag == false)
                    {
                        // see if element definition is something like {CodeableConcept}.coding.
                        ElementDefinition baseElement = baseItem.SBaseDef.Snapshot.Element.FindByPath(baseSlice.ElementDefinition.Path);
                        if (
                            (baseElement == null) ||
                            (this.IsElementPart(baseElement, mergeNode.Name) == false)
                            )
                        {
                            this.preFhir.ConversionError(this.GetType().Name,
                                fcn,
                                $"Node '{mergeNode.Path}' does not exist in base. Can not add element to non-fragment");
                            return false;
                        }
                    }

                    if (this.preFhir.DebugFlag)
                        this.preFhir.ConversionInfo(this.GetType().Name,
                            fcn,
                            $"Node '{mergeNode.Path}' does not exist in base. Copying whole node");
                    // Node doesnt exist in base, so copy it whole.
                    baseNode = mergeNode.Clone();
                    baseNode.ReplaceBasePath(this.baseItem.BasePath);
                    baseSlice.Nodes.Add(baseNode);
                }
                else
                {
                    if (this.preFhir.DebugFlag)
                        this.preFhir.ConversionInfo(this.GetType().Name,
                            fcn,
                            $"Node '{mergeNode.Path}' found in base. Merging node");

                    if (!MergeElementTreeNode(baseNode, mergeNode))
                        retVal = false;
                }
            }
            return retVal;
        }

        bool Constrain(ElementDefinition baseElement,
            ElementDefinition mergeElement)
        {
            const String fcn = "Constrain";

            if (mergeElement == null)
                return true;

            if (baseElement == null)
            {
                this.preFhir.ConversionError(this.GetType().Name,
                    fcn,
                    $"ElementDefinition '{mergeElement.Path}' missing from base");
                return false;
            }

            if (this.preFhir.DebugFlag)
                this.preFhir.ConversionInfo(this.GetType().Name,
                    fcn,
                    $"Merging '{mergeElement.Path}'");

            bool retVal = true;
            this.ConstrainCardinality(baseElement, mergeElement, ref retVal);
            this.ConstrainType(baseElement, mergeElement, ref retVal);
            baseElement.SliceNameElement = this.ConstrainSingleElement(baseElement.Path, "SliceName", baseElement.SliceNameElement, mergeElement.SliceNameElement, ref retVal);
            this.ConstrainCode(baseElement, mergeElement, ref retVal);
            baseElement.SliceIsConstrainingElement = this.ConstrainSingleElement(baseElement.Path, "SliceIsConstraining", baseElement.SliceIsConstrainingElement, mergeElement.SliceIsConstrainingElement, ref retVal);
            baseElement.LabelElement = this.ConstrainSingleElement(baseElement.Path, "Label", baseElement.LabelElement, mergeElement.LabelElement, ref retVal);
            ConstrainSlicing(baseElement, mergeElement, ref retVal);

            baseElement.ShortElement = this.ConstrainSingleElement(baseElement.Path, "Short", baseElement.ShortElement, mergeElement.ShortElement, ref retVal);
            baseElement.Definition = this.ConstrainSingleElement(baseElement.Path, "Definition", baseElement.Definition, mergeElement.Definition, ref retVal);
            baseElement.Comment = this.ConstrainSingleElement(baseElement.Path, "Comment", baseElement.Comment, mergeElement.Comment, ref retVal);
            baseElement.Requirements = this.ConstrainSingleElement(baseElement.Path, "Requirements", baseElement.Requirements, mergeElement.Requirements, ref retVal);
            // TODO: Alias
            //       ContentReference
            //        Example
            //        condition
            //        constraint
            //        XXYYmustSupport
            //        isModifier
            //        isModifierReason
            //        isSummary
            //        mapping

            baseElement.DefaultValue = this.ConstrainSingleElement(baseElement.Path, "DefaultValue", baseElement.DefaultValue, mergeElement.DefaultValue, ref retVal);
            baseElement.Fixed = this.ConstrainSingleElement(baseElement.Path, "Fixed", baseElement.Fixed, mergeElement.Fixed, ref retVal);
            baseElement.Pattern = this.ConstrainSingleElement(baseElement.Path, "Pattern", baseElement.Pattern, mergeElement.Pattern, ref retVal);
            baseElement.Pattern = this.ConstrainSingleElement(baseElement.Path, "Pattern", baseElement.Pattern, mergeElement.Pattern, ref retVal);
            baseElement.MinValue = this.ConstrainSingleElement(baseElement.Path, "MinValue", baseElement.MinValue, mergeElement.MinValue, ref retVal);
            baseElement.MaxValue = this.ConstrainSingleElement(baseElement.Path, "MaxValue", baseElement.MaxValue, mergeElement.MaxValue, ref retVal);
            baseElement.Binding = this.ConstrainSingleElement(baseElement.Path, "Binding", baseElement.Binding, mergeElement.Binding, ref retVal);
            return retVal;
        }

        /// <summary>
        /// Constrain element types. Error if constrain types are not a subset of base types.
        /// </summary>
        void ConstrainType(ElementDefinition baseElement,
                    ElementDefinition mergeElement,
                    ref bool success)
        {
            const String fcn = "MergeType";

            Dictionary<String, ElementDefinition.TypeRefComponent> baseTypes = new Dictionary<string, ElementDefinition.TypeRefComponent>();
            foreach (ElementDefinition.TypeRefComponent typeRef in baseElement.Type)
                baseTypes.Add(typeRef.Code, typeRef);

            bool retVal = true;
            foreach (ElementDefinition.TypeRefComponent typeRef in mergeElement.Type)
            {
                if (baseTypes.TryGetValue(typeRef.Code, out ElementDefinition.TypeRefComponent baseTypeRef) == false)
                {
                    // Fragment contains a type that is not in base profile. Cant add types, only constrain.
                    this.preFhir.ConversionError(this.GetType().Name,
                        fcn,
                        $"Error constaining type. Element [{mergeElement.Path}] does not contain type '{typeRef.Code}' not found in base");
                    success = false;
                    return;
                }
                baseTypes.Remove(typeRef.Code);

                // TODO: Put in code to constrain typeRef.profile.
                if (typeRef.Profile.Count() > 0)
                {
                    this.preFhir.ConversionError(this.GetType().Name,
                        fcn,
                        $"Merge typeRef.Profile unimplemented");
                    success = false;
                    return;
                }

                // TODO: Put in code to constrain typeRef.targetProfile.
                if (typeRef.TargetProfile.Count() > 0)
                {
                    this.preFhir.ConversionError(this.GetType().Name,
                        fcn,
                        $"Merge typeRef.targetProfile unimplemented");
                    success = false;
                    return;
                }

                // TODO: Put in code to constrain typeRef.aggregation.
                if (typeRef.Aggregation.Count() > 0)
                {
                    this.preFhir.ConversionError(this.GetType().Name,
                        fcn,
                        $"Merge typeRef.aggregation unimplemented");
                    success = false;
                    return;
                }

                // TODO: Put in code to constrain typeRef.versioning.
                if (typeRef.Versioning.HasValue == true)
                {
                    this.preFhir.ConversionError(this.GetType().Name,
                        fcn,
                        $"Merge typeRef.versioning unimplemented");
                    success = false;
                    return;
                }
            }

            // Remove all types in base that are not also in merged (constrain them out...)
            foreach (ElementDefinition.TypeRefComponent typeRef in baseTypes.Values)
                baseElement.Type.Remove(typeRef);
        }

        /// <summary>
        /// This is for elements that have only one value, and can only be set if
        /// they are not already set.
        /// </summary>
        /// <param name="baseElement"></param>
        /// <param name="mergeElement"></param>
        /// <returns></returns>
        T ConstrainSingleElement<T>(String path,
            String valueName,
            T baseElement,
            T mergeElement,
            ref bool success)
            where T : Element
        {
            const String fcn = "ConstrainElement";

            // if nothing to set.
            if (mergeElement == null)
                return baseElement;

            // If base is null, then just set it.
            if (baseElement == null)
                return (T)mergeElement.DeepCopy();

            // both base and merge have values. If the values are identical, then no worries.
            if (baseElement.IsExactly(mergeElement))
                return baseElement;

            // otherwise, the values are different and we hav a problem.
            this.preFhir.ConversionError(this.GetType().Name,
                fcn,
                $"Error constaining {path}:{valueName}. Merge Element and Base Element both contain distinct values that can not be reconciled. ");
            success = false;
            return baseElement;
        }

        void ConstrainCode(ElementDefinition baseElement,
            ElementDefinition mergeElement,
            ref bool success)
        {
            const String fcn = "ConstrainCode";

            if (mergeElement.Code.Count == 0)
                return;

            // TODO: we need to check each value in merge and add it only if there is not an identical
            // value already in base.
            baseElement.Code.AddRange(mergeElement.Code);
            return;
        }

        /// <summary>
        /// Constrain element cardinalities. Error if merge cardinalities are not a subset of base
        /// </summary>
        void ConstrainSlicing(ElementDefinition baseElement,
            ElementDefinition mergeElement,
            ref bool success)
        {
            const String fcn = "ConstrainSlicing";

            if (mergeElement.Slicing == null)
                return;

            if (baseElement.Slicing != null)
            {
                this.preFhir.ConversionError(this.GetType().Name,
                    fcn,
                    $"Error constaining {mergeElement.Path}. Not Supported (yet). Merge Element and Base Element both define a slicing component. ");
                success = false;
                return;
            }
            baseElement.Slicing = (ElementDefinition.SlicingComponent)mergeElement.Slicing.DeepCopy();
        }

        /// <summary>
        /// Constrain element cardinalities. Error if merge cardinalities are not a subset of base
        /// </summary>
        void ConstrainCardinality(ElementDefinition baseElement,
            ElementDefinition mergeElement,
            ref bool success)
        {
            const String fcn = "ConstrainCardinality";

            Int32 MaxCmp(String a, String b)
            {
                Int32 aVal;
                Int32 bVal;
                if (a == "*")
                    aVal = Int32.MaxValue;
                else
                    aVal = Int32.Parse(a);

                if (b == "*")
                    bVal = Int32.MaxValue;
                else
                    bVal = Int32.Parse(b);
                return aVal.CompareTo(bVal);
            }

            if (mergeElement.Min.HasValue == true)
            {
                if (
                    (baseElement.Min.HasValue) &&
                    (mergeElement.Min.Value < baseElement.Min.Value)
                    )
                {
                    this.preFhir.ConversionError(this.GetType().Name,
                        fcn,
                        $"Error constraining [{mergeElement.Path}].Min. Fragment min {mergeElement.Min} < base min {baseElement.Min}");
                    success = false;
                    return;
                }
                baseElement.Min = mergeElement.Min.Value;
            }

            if (String.IsNullOrEmpty(mergeElement.Max) == false)
            {
                if (
                    (String.IsNullOrEmpty(baseElement.Max) == false) &&
                    (MaxCmp(baseElement.Max, mergeElement.Max) < 0)
                    )
                {
                    this.preFhir.ConversionError(this.GetType().Name,
                         fcn,
                         $"Error constraining [{mergeElement.Path}].Max. Fragment max {mergeElement.Max} < base max {baseElement.Max}");
                    success = false;
                    return;
                }
                baseElement.Max = mergeElement.Max;
            }
        }

        /// <summary>
        /// Add data type items(like.coding)
        /// </summary>
        public bool IsElementPart(ElementDefinition element,
            String partName)
        {
            foreach (ElementDefinition.TypeRefComponent type in element.Type)
            {
                switch (type.Code)
                {
                    default:
                        String url = $"http://hl7.org/fhir/StructureDefinition/{type.Code}";
                        StructureDefinition typeDef = FhirStructureDefinitions.Self.GetResource(url);
                        if (typeDef == null)
                            throw new Exception($"'Fhir type {type.Code}' not found");
                        foreach (ElementDefinition e in typeDef.Differential.Element.Skip(1))
                        {
                            String pathName = e.Path.LastPathPart();
                            if (pathName == partName)
                                return true;
                        }
                        break;
                }
            }
            return false;
        }
    }
}
