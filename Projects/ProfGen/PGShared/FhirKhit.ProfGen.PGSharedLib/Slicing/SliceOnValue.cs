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

namespace FhirKhit.ProfGen.PGSharedLib
{
    /// <summary>
    /// 
    /// </summary>
    public class SliceOnValue : ISliceDiscriminator 
    {
        /*
        if (FhirConstruct(elementNode, elementSlice, this.subClassBlock, discriminator.,
            String varName,
            bool singleton,
            out String propertyType)

            
            this.subClassBlock
         */
        protected String path {get; set; }

        public SliceOnValue(String path)
        {
            this.path = path;
        }

        /// <summary>
        /// Return <see langword="true"/>if item is in slice.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool IsSlice(Element discriminator,
            Element item)
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
            return value.Matches(discriminator);
        }
    }
}
