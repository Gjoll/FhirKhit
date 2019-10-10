using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.Tools.R4
{
    /// <summary>
    /// A group of element definitions that will be copied to the output 
    /// StructureDefinition as a group, in the order that they are included in this
    /// group.
    /// </summary>
    public class ElementDefGroup
    {
        /// <summary>
        /// Index that orders where they are places in the output structure definitions.
        /// This keeps the order in the differentialt he same as the order in the base definition.
        /// </summary>
        public Int32 Index { get; set; }

        /// <summary>
        /// Base element definition. Null if none...
        /// </summary>
        public ElementDefinition BaseElementDefinition { get; set; }

        /// <summary>
        /// This is the element that has a one for one match to one in thebase defintion.
        /// </summary>
        public ElementDefinition ElementDefinition { get; set; }

        /// <summary>
        /// Elements to be added to output sdef after element definition. These typically
        /// include slices and such. They are not found in the base definition.
        /// </summary>
        public List<ElementDefinition> RelatedElements { get; set; } = new List<ElementDefinition>();

        public ElementDefGroup(Int32 index, ElementDefinition elementDef, ElementDefinition eBase)
        {
            this.Index = index;
            this.ElementDefinition = elementDef;
            this.BaseElementDefinition = eBase;
            if (eBase != null)
            {
                elementDef.Base = new ElementDefinition.BaseComponent
                {
                    Path = eBase.Path,
                    Min = eBase.Min,
                    Max = eBase.Max
                };
            }
        }

        public ElementDefinition AppendSlice(String sliceName,
            Int32 min = 0,
            String max = "*")
        {
            ElementDefinition retVal = new ElementDefinition
            {
                Path = this.ElementDefinition.Path,
                ElementId = $"{this.ElementDefinition.Path}:{sliceName}",
                SliceName = sliceName,
                Min = min,
                Max = max
            };
            if (this.BaseElementDefinition != null)
            {
                retVal.Base = new ElementDefinition.BaseComponent
                {
                    Min = this.BaseElementDefinition.Min,
                    Max = this.BaseElementDefinition.Max,
                    Path = this.BaseElementDefinition.Path
                };
            }
            this.RelatedElements.Add(retVal);
            return retVal;
        }

        /// <summary>
        /// Add the indicated slice by url.
        /// </summary>
        public ElementDefinition FixedCodeSlice(String sliceName,
            String system,
            String code)
        {
            sliceName = sliceName.UncapFirstLetter();
            this.ElementDefinition.Slicing = new ElementDefinition.SlicingComponent
            {
                Rules = ElementDefinition.SlicingRules.Open
            };

            this.ElementDefinition.Slicing.Discriminator.Add(new ElementDefinition.DiscriminatorComponent
            {
                Type = ElementDefinition.DiscriminatorType.Value,
                Path = "coding"
            });

            ElementDefinition coding = new ElementDefinition
            {
                ElementId = $"{this.ElementDefinition.Path}.coding",
                Path = $"{this.ElementDefinition.Path}.coding",
            };
            this.RelatedElements.Add(coding);

            ElementDefinition slice = new ElementDefinition
            {
                ElementId = $"{this.ElementDefinition.Path}.coding:{sliceName}",
                Path = $"{this.ElementDefinition.Path}.coding",
                SliceName = sliceName,
                Min = 1,
                Max = "1",
                Pattern = new Coding(system, code),
                Base = new ElementDefinition.BaseComponent
                {
                    Min = this.BaseElementDefinition.Min,
                    Max = this.BaseElementDefinition.Max,
                    Path = $"{this.BaseElementDefinition.Path}"
                }
            };
            this.RelatedElements.Add(slice);
            return slice;
        }
    }
}

