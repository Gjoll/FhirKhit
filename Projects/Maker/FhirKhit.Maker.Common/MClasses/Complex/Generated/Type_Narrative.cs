using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.Common.Complex
{
    #region Json
    #if NEVER
    {
      "resourceType": "StructureDefinition",
      "id": "Narrative",
      "url": "http://hl7.org/fhir/StructureDefinition/Narrative",
      "version": "4.0.0",
      "name": "Narrative",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for Narrative Type: A human-readable summary of the resource conveying the essential clinical and business information for the resource.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "Narrative",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Narrative",
            "path": "Narrative",
            "short": "Human-readable summary of the resource (essential clinical and business information)",
            "definition": "A human-readable summary of the resource conveying the essential clinical and business information for the resource.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Narrative.status",
            "path": "Narrative.status",
            "short": "generated | extensions | additional | empty",
            "definition": "The status of the narrative - whether it's entirely generated (from just the defined data or the extensions too), or whether a human authored it and it may contain additional data.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "NarrativeStatus"
                }
              ],
              "strength": "required",
              "description": "The status of a resource narrative.",
              "valueSet": "http://hl7.org/fhir/ValueSet/narrative-status|4.0.0"
            }
          },
          {
            "id": "Narrative.div",
            "path": "Narrative.div",
            "short": "Limited xhtml content",
            "definition": "The actual narrative content, a stripped down version of XHTML.",
            "comment": "The contents of the html element are an XHTML fragment containing only the basic html formatting elements described in chapters 7-11 and 15 of the HTML 4.0 standard, <a> elements (either name or href), images and internally contained stylesheets. The XHTML content SHALL NOT contain a head, a body, external stylesheet references, scripts, forms, base/link/xlink, frames, iframes and objects.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "xhtml"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir complex 'Narrative'
    /// </summary>
    // 0. Narrative
    public partial class Type_Narrative : FhirKhit.Maker.Common.Complex.ComplexBase
    {
        // 1. Narrative.status
        public ElementDefinitionInfo Element_Status;
        // 2. Narrative.div
        public ElementDefinitionInfo Element_Div;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "Narrative",
                ElementId = "Narrative"
            });
            Element_Status.Write(sDef);
            Element_Div.Write(sDef);
        }
        
        public Type_Narrative()
        {
            {
                // 1. Narrative.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "Narrative.status",
                    Id = "Narrative.status",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code
                        {
                        }
                    }
                };
            }
            {
                // 2. Narrative.div
                this.Element_Div = new ElementDefinitionInfo
                {
                    Name = "Element_Div",
                    Path= "Narrative.div",
                    Id = "Narrative.div",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Xhtml
                        {
                        }
                    }
                };
            }
        }
    }
}
