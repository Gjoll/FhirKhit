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

namespace FhirKhit.ProfGen.SharedLib
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class SliceOnValue : ISliceDiscriminator
    {
        Element discriminator;
        String path;

        public SliceOnValue(String path, Element discriminator)
        {
            this.path = path;
            this.discriminator = discriminator;
        }

        /// <summary>
        /// Return <see langword="true"/>if item is in slice.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool IsSlice(Element item)
        {
            var nav = item.ToTypedElement();
            EvaluationContext ctx = new FhirEvaluationContext();
            ITypedElement[] results = nav.Select(path, ctx).ToArray();
            if ((results == null) || (results.Length == 0))
                return false;
            if (results.Length > 1)
                throw new NotImplementedException($"SliceOnValue.GetValue: Multiple elements found at path '{this.path}'");
            ITypedElement result = results[0];
            Element value = result.Value as Element;
            if (value == null)
                throw new NotImplementedException($"SliceOnValue.GetValue: Value is not an Element '{this.path}'");
            //# TODO: I am using Matches here. SHould I be using IsExactly?
            return value.Matches(this.discriminator);
        }
    }
}
