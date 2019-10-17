using System;                                                                                                                               // MakerGen.cs:490
using System.Diagnostics;                                                                                                                   // MakerGen.cs:491
using System.IO;                                                                                                                            // MakerGen.cs:492
using System.Linq;                                                                                                                          // MakerGen.cs:493
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:494
                                                                                                                                            // MakerGen.cs:495
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:496
{                                                                                                                                           // MakerGen.cs:497
    #region Json                                                                                                                            // MakerGen.cs:498
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
    #endregion                                                                                                                              // MakerGen.cs:502
    /// <summary>
    /// Fhir complex 'Narrative'
    /// </summary>
    // 0. Narrative
    public partial class Type_Narrative : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:381
    {                                                                                                                                       // MakerGen.cs:382
        // 1. Narrative.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:217
        // 2. Narrative.div
        public ElementDefinitionInfo Element_Div;                                                                                           // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:388
        {                                                                                                                                   // MakerGen.cs:389
            base.Write(sDef);                                                                                                               // MakerGen.cs:390
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:391
            {                                                                                                                               // MakerGen.cs:392
                Path = "Narrative",                                                                                                         // MakerGen.cs:393
                ElementId = "Narrative"                                                                                                     // MakerGen.cs:394
            });                                                                                                                             // MakerGen.cs:395
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_Div.Write(sDef);                                                                                                        // MakerGen.cs:221
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
        public Type_Narrative()                                                                                                             // MakerGen.cs:400
        {                                                                                                                                   // MakerGen.cs:401
            {                                                                                                                               // MakerGen.cs:232
                // 1. Narrative.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Status",                                                                                                // MakerGen.cs:236
                    Path= "Narrative.status",                                                                                               // MakerGen.cs:237
                    Id = "Narrative.status",                                                                                                // MakerGen.cs:238
                    Min = 1,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 2. Narrative.div
                this.Element_Div = new ElementDefinitionInfo                                                                                // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Div",                                                                                                   // MakerGen.cs:236
                    Path= "Narrative.div",                                                                                                  // MakerGen.cs:237
                    Id = "Narrative.div",                                                                                                   // MakerGen.cs:238
                    Min = 1,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Xhtml                                                                 // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
        }                                                                                                                                   // MakerGen.cs:403
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:507
