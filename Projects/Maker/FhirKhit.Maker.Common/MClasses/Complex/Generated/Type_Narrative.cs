using System;                                                                                                                               // MakerGen.cs:482
using System.Diagnostics;                                                                                                                   // MakerGen.cs:483
using System.IO;                                                                                                                            // MakerGen.cs:484
using System.Linq;                                                                                                                          // MakerGen.cs:485
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:486
                                                                                                                                            // MakerGen.cs:487
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:488
{                                                                                                                                           // MakerGen.cs:489
    #region Json                                                                                                                            // MakerGen.cs:490
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
    #endregion                                                                                                                              // MakerGen.cs:494
    /// <summary>
    /// Fhir complex 'Narrative'
    /// </summary>
    // 0. Narrative
    public class Type_Narrative : FhirKhit.Maker.Common.Complex.ComplexBase                                                                 // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 1. Narrative.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:212
        // 2. Narrative.div
        public ElementDefinitionInfo Element_Div;                                                                                           // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "Narrative",                                                                                                         // MakerGen.cs:388
                ElementId = "Narrative"                                                                                                     // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Div.Write(sDef);                                                                                                        // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Type_Narrative()                                                                                                             // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. Narrative.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Status",                                                                                                // MakerGen.cs:231
                    Path= "Narrative.status",                                                                                               // MakerGen.cs:232
                    Id = "Narrative.status",                                                                                                // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 2. Narrative.div
                this.Element_Div = new ElementDefinitionInfo                                                                                // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Div",                                                                                                   // MakerGen.cs:231
                    Path= "Narrative.div",                                                                                                  // MakerGen.cs:232
                    Id = "Narrative.div",                                                                                                   // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Xhtml                                                                 // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:499
