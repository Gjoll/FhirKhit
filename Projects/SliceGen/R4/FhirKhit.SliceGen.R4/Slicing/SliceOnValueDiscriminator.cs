using Hl7.Fhir.ElementModel;
using Hl7.Fhir.FhirPath;
using Hl7.Fhir.Model;
using Hl7.Fhir.Model.Primitives;
using Hl7.FhirPath;
using Hl7.FhirPath.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FhirKhit.SliceGen.ShareLib
{
    /// <summary>
    /// Slice on value discriminator.
    /// Implemented slicing on an items values.
    /// </summary>
    /// <typeparam name="TBase">Type of base item that is being sliced</typeparam>
    /// <typeparam name="TValue">Type of child item that is the slice value</typeparam>
    public class SliceOnValueDiscriminator<TBase, TValue> : ISliceDiscriminator<TBase> 
        where TBase : Element
        where TValue : Element
    {
        public delegate IEnumerable<TValue> ValueFilterDel(IEnumerable<TBase> item);
        
        /// <summary>
        /// Path to the elements that are the discriminator values.
        /// </summary>
        public String Path {get; set; }

        /// <summary>
        /// discriminator values must match this pattern.
        /// </summary>
        public Element Pattern { get; set; }

        /// <summary>
        /// Filter to return the value elements of the discriminator.
        /// </summary>

        public ValueFilterDel ValueFilter {get; set;}

        /// <summary>
        /// Return <see langword="true"/>if item is in slice.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool IsSlice(TBase item)
        {
            //var nav = item.ToTypedElement();
            //EvaluationContext ctx = new FhirEvaluationContext();
            //ITypedElement[] results = nav.Select(Path, ctx).ToArray();
            //if ((results == null) || (results.Length == 0))
            //    return false;
            //if (results.Length > 1)
            //    throw new NotImplementedException($"SliceOnValueDiscriminator.GetValue: Multiple elements found at path '{this.Path}'");
            //ITypedElement result = results[0];
            //Element value = result.Value as Element;
            //if (value == null)
            //    throw new NotImplementedException($"SliceOnValueDiscriminator.GetValue: Value is not an Element '{this.Path}'");
            ////# TODO: I am using Matches here. SHould I be using IsExactly?
            //return value.Matches(this.Pattern);
            throw new NotImplementedException();
        }
    }
}
