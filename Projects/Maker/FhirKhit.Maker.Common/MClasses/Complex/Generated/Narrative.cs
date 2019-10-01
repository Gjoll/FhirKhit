using System;                                                                                                                               // MakerGen.cs:497
using System.Diagnostics;                                                                                                                   // MakerGen.cs:498
using System.IO;                                                                                                                            // MakerGen.cs:499
using System.Linq;                                                                                                                          // MakerGen.cs:500
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:501
                                                                                                                                            // MakerGen.cs:502
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:503
{                                                                                                                                           // MakerGen.cs:504
    #region Json                                                                                                                            // MakerGen.cs:505
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
    #endregion                                                                                                                              // MakerGen.cs:509
    /// <summary>
    /// Fhir complex 'Narrative'
    /// </summary>
    // 0. Narrative
    public class Narrative : FhirKhit.Maker.Common.Complex.ComplexBase                                                                      // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        public class Narrative_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                       // MakerGen.cs:385
        {                                                                                                                                   // MakerGen.cs:386
            // 1. Narrative.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:216
            // 2. Narrative.div
            public ElementDefinitionInfo Div;                                                                                               // MakerGen.cs:216
            public Narrative_Elements()                                                                                                     // MakerGen.cs:407
            {                                                                                                                               // MakerGen.cs:408
                {                                                                                                                           // MakerGen.cs:231
                    // 1. Narrative.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Status",                                                                                                    // MakerGen.cs:235
                        Path= "Narrative.status",                                                                                           // MakerGen.cs:236
                        Id = "Narrative.status",                                                                                            // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 2. Narrative.div
                    this.Div = new ElementDefinitionInfo                                                                                    // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Div",                                                                                                       // MakerGen.cs:235
                        Path= "Narrative.div",                                                                                              // MakerGen.cs:236
                        Id = "Narrative.div",                                                                                               // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Xhtml                                                                       // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:427
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:412
            {                                                                                                                               // MakerGen.cs:413
                base.Write(sDef);                                                                                                           // MakerGen.cs:414
                Status.Write(sDef);                                                                                                         // MakerGen.cs:220
                Div.Write(sDef);                                                                                                            // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:431
        }                                                                                                                                   // MakerGen.cs:391
        public Narrative_Elements Elements { get; }                                                                                         // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
        public Narrative()                                                                                                                  // MakerGen.cs:394
        {                                                                                                                                   // MakerGen.cs:395
            this.Elements = new Narrative_Elements();                                                                                       // MakerGen.cs:396
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:399
        {                                                                                                                                   // MakerGen.cs:400
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:401
        }                                                                                                                                   // MakerGen.cs:402
    }                                                                                                                                       // MakerGen.cs:403
}                                                                                                                                           // MakerGen.cs:514
