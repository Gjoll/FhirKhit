using FhirKhit.Tools;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#if FHIR_R4
namespace FhirKhit.Tools.R4
#elif FHIR_R3
namespace FhirKhit.Tools.R3
#endif
{
    /// <summary>
    /// Remove all elements from modified that are the same as the matching element in original.
    /// </summary>
    public class ElementTreeDiffer
    {
        IConversionInfo info;
        bool successFlag;

        public ElementTreeDiffer(IConversionInfo info)
        {
            this.info = info;
        }

        public bool Process(ElementTreeNode original,
            ElementTreeNode modified)
        {
            successFlag = true;
            this.ProcessNode(original, modified);
            return successFlag;
        }

        void Info(string className, string method, string msg)
        {
            if (this.info != null)
                this.info.ConversionInfo(className, method, msg);
        }

        void Warn(string className, string method, string msg)
        {
            if (this.info != null)
                this.info.ConversionWarn(className, method, msg);
        }

        void Error(string className, string method, string msg)
        {
            successFlag = false;
            if (this.info != null)
                this.info.ConversionError(className, method, msg);
        }

        void ProcessNode(ElementTreeNode originalNode,
            ElementTreeNode modifiedNode)
        {
            foreach (ElementTreeSlice modifiedSlice in modifiedNode.Slices)
            {
                // If slice was not found in original, then it was added.
                // leave it.
                if (originalNode.Slices.TryGetItem(modifiedSlice.Name, out ElementTreeSlice originalSlice) == true)
                {
                    if (originalSlice.SameAs(modifiedSlice) == true)
                    {
                        modifiedSlice.Clear();
                    }
                    else
                    {
                        // Slices are different. Drill down....
                        ProcessSlice(originalSlice, modifiedSlice);
                    }
                }
            }
        }

        void ProcessSlice(ElementTreeSlice originalSlice,
            ElementTreeSlice modifiedSlice)
        {
            //const String fcn = "ProcessSlice";

            if ((originalSlice.ElementDefinition != null) && (modifiedSlice.ElementDefinition != null))
            {
                if (originalSlice.ElementDefinition.IsExactly(modifiedSlice.ElementDefinition))
                {
                    // Clear all fields except for Path and Id and SliceName
                    ElementDefinition newE = new ElementDefinition
                    {
                        Path = modifiedSlice.ElementDefinition.Path,
                        ElementId = modifiedSlice.ElementDefinition.ElementId,
                        SliceName = modifiedSlice.ElementDefinition.SliceName
                    };
                    modifiedSlice.ElementDefinition = newE;
                }
                else
                {
                    ElementDefinition originalElement = originalSlice.ElementDefinition;
                    ElementDefinition modifiedElement = modifiedSlice.ElementDefinition;
                    modifiedElement.Base = new ElementDefinition.BaseComponent
                    {
                        Path = originalElement.Path,
                        Min = originalElement.Min,
                        Max = originalElement.Max
                    };

                    if ((originalElement.Min == modifiedElement.Min) && (originalElement.Max == modifiedElement.Max))
                    {
                        modifiedElement.Min = null;
                        modifiedElement.Max = null;
                    }
                    modifiedElement.RepresentationElement = Compare.ClearIfSame(originalElement.RepresentationElement, modifiedElement.RepresentationElement);
#if FHIR_R4
                    modifiedElement.SliceIsConstraining = Compare.ClearIfSame(originalElement.SliceIsConstraining, modifiedElement.SliceIsConstraining);
#endif
                    modifiedElement.Label = Compare.ClearIfSame(originalElement.Label, modifiedElement.Label);
                    modifiedElement.Code = Compare.ClearIfSame(originalElement.Code, modifiedElement.Code);
                    modifiedElement.Constraint = Compare.ClearIfSame(originalElement.Constraint, modifiedElement.Constraint);
                    modifiedElement.Slicing = Compare.ClearIfSame(originalElement.Slicing, modifiedElement.Slicing);
                    modifiedElement.Short = Compare.ClearIfSame(originalElement.Short, modifiedElement.Short);
                    modifiedElement.Definition = Compare.ClearIfSame(originalElement.Definition, modifiedElement.Definition);
                    modifiedElement.Comment = Compare.ClearIfSame(originalElement.Comment, modifiedElement.Comment);
                    modifiedElement.Requirements = Compare.ClearIfSame(originalElement.Requirements, modifiedElement.Requirements);
                    modifiedElement.AliasElement = Compare.ClearIfSame(originalElement.AliasElement, modifiedElement.AliasElement);
                    modifiedElement.ContentReference = Compare.ClearIfSame(originalElement.ContentReference, modifiedElement.ContentReference);
                    modifiedElement.Type = Compare.ClearIfSame(originalElement.Type, modifiedElement.Type);
                    modifiedElement.DefaultValue = Compare.ClearIfSame(originalElement.DefaultValue, modifiedElement.DefaultValue);
                    modifiedElement.MeaningWhenMissing = Compare.ClearIfSame(originalElement.MeaningWhenMissing, modifiedElement.MeaningWhenMissing);
                    modifiedElement.OrderMeaning = Compare.ClearIfSame(originalElement.OrderMeaning, modifiedElement.OrderMeaning);
                    modifiedElement.Fixed = Compare.ClearIfSame(originalElement.Fixed, modifiedElement.Fixed);
                    modifiedElement.Pattern = Compare.ClearIfSame(originalElement.Pattern, modifiedElement.Pattern);
                    modifiedElement.Example = Compare.ClearIfSame(originalElement.Example, modifiedElement.Example);
                    modifiedElement.MinValue = Compare.ClearIfSame(originalElement.MinValue, modifiedElement.MinValue);
                    modifiedElement.MaxValue = Compare.ClearIfSame(originalElement.MaxValue, modifiedElement.MaxValue);
                    modifiedElement.MaxLengthElement = Compare.ClearIfSame(originalElement.MaxLengthElement, modifiedElement.MaxLengthElement);
                    modifiedElement.ConditionElement = Compare.ClearIfSame(originalElement.ConditionElement, modifiedElement.ConditionElement);
                    modifiedElement.ConditionElement = Compare.ClearIfSame(originalElement.ConditionElement, modifiedElement.ConditionElement);
                    modifiedElement.MustSupportElement = Compare.ClearIfSame(originalElement.MustSupportElement, modifiedElement.MustSupportElement);
                    modifiedElement.IsModifierElement = Compare.ClearIfSame(originalElement.IsModifierElement, modifiedElement.IsModifierElement);
#if FHIR_R4
                    modifiedElement.IsModifierReasonElement = Compare.ClearIfSame(originalElement.IsModifierReasonElement, modifiedElement.IsModifierReasonElement);
#endif
                    modifiedElement.IsSummaryElement = Compare.ClearIfSame(originalElement.IsSummaryElement, modifiedElement.IsSummaryElement);
                    modifiedElement.Binding = Compare.ClearIfSame(originalElement.Binding, modifiedElement.Binding);
                    modifiedElement.Mapping = Compare.ClearIfSame(originalElement.Mapping, modifiedElement.Mapping);
                }
            }

            foreach (ElementTreeNode modifiedNode in modifiedSlice.Nodes.ToArray())
            {
                if (originalSlice.Nodes.TryGetItem(modifiedNode.Name, out ElementTreeNode originalNode) == true)
                {
                    if (originalNode.SameAs(modifiedNode) == true)
                    {
                        modifiedSlice.Nodes.Remove(modifiedNode);
                    }
                    else
                    {
                        // Slices are different. Drill down....
                        ProcessNode(originalNode, modifiedNode);
                    }
                }
            }
        }
    }
}
