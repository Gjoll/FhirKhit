using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PreFhir
{
    public static class ElementDefinitionExtensions
    {
        public static void ApplySlicing(this ElementDefinition e,
            ElementDefinition.SlicingComponent slicingComponent,
            bool overrideExistingSliceDiscriminator)
        {
            bool NonCompatible()
            {
                if (e.Slicing == null)
                    return false;
                if (e.Slicing.Ordered != slicingComponent.Ordered)
                    return true;
                if (e.Slicing.Rules != slicingComponent.Rules)
                    return true;
                if (e.Slicing.Discriminator.Count != slicingComponent.Discriminator.Count)
                    return true;
                for (Int32 i = 0; i < slicingComponent.Discriminator.Count; i++)
                {
                    if (slicingComponent.Discriminator[i].Type != e.Slicing.Discriminator[i].Type)
                        return true;
                    if (slicingComponent.Discriminator[i].Path != e.Slicing.Discriminator[i].Path)
                        return true;
                }

                return false;
            }

            if (overrideExistingSliceDiscriminator)
                e.Slicing = null;
            if (e.Slicing != null)
            {
                if (NonCompatible() == true)
                    throw new Exception($"Slicing already defined in a noncompatible manner");
                return;
            }
            e.Slicing = slicingComponent;
        }
    }
}
