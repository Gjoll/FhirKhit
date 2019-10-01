using System;                                                                                                                               // MakerGen.cs:511
using System.Diagnostics;                                                                                                                   // MakerGen.cs:512
using System.IO;                                                                                                                            // MakerGen.cs:513
using System.Linq;                                                                                                                          // MakerGen.cs:514
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:515
                                                                                                                                            // MakerGen.cs:516
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:517
{                                                                                                                                           // MakerGen.cs:518
    #region Json                                                                                                                            // MakerGen.cs:519
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
    #endregion                                                                                                                              // MakerGen.cs:523
    /// <summary>
    /// Fhir complex 'Narrative'
    /// </summary>
    // 0. Narrative
    public class Narrative : FhirKhit.Maker.Common.Complex.ComplexBase                                                                      // MakerGen.cs:379
    {                                                                                                                                       // MakerGen.cs:380
        public class Narrative_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                       // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 1. Narrative.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:211
            // 2. Narrative.div
            public ElementDefinitionInfo Div;                                                                                               // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
            public Narrative_Elements()                                                                                                     // MakerGen.cs:387
            {                                                                                                                               // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:226
                    // 1. Narrative.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Status",                                                                                                    // MakerGen.cs:230
                        Path= "Narrative.status",                                                                                           // MakerGen.cs:231
                        Id = "Narrative.status",                                                                                            // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. Narrative.div
                    this.Div = new ElementDefinitionInfo                                                                                    // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Div",                                                                                                       // MakerGen.cs:230
                        Path= "Narrative.div",                                                                                              // MakerGen.cs:231
                        Id = "Narrative.div",                                                                                               // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Xhtml                                                                       // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                base.Write(sDef);                                                                                                           // MakerGen.cs:395
                Status.Write(sDef);                                                                                                         // MakerGen.cs:215
                Div.Write(sDef);                                                                                                            // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:397
        }                                                                                                                                   // MakerGen.cs:399
        public Narrative_Elements Elements                                                                                                  // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            get                                                                                                                             // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:404
                if (this.elements == null)                                                                                                  // MakerGen.cs:405
                    this.elements = new Narrative_Elements();                                                                               // MakerGen.cs:406
                return this.elements;                                                                                                       // MakerGen.cs:407
            }                                                                                                                               // MakerGen.cs:408
        }                                                                                                                                   // MakerGen.cs:409
        Narrative_Elements elements;                                                                                                        // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
        public Narrative()                                                                                                                  // MakerGen.cs:413
        {                                                                                                                                   // MakerGen.cs:414
        }                                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:419
        {                                                                                                                                   // MakerGen.cs:420
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:421
            {                                                                                                                               // MakerGen.cs:422
                Path = "Narrative",                                                                                                         // MakerGen.cs:423
                ElementId = "Narrative"                                                                                                     // MakerGen.cs:424
            });                                                                                                                             // MakerGen.cs:425
            if (this.elements != null)                                                                                                      // MakerGen.cs:426
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:427
        }                                                                                                                                   // MakerGen.cs:428
    }                                                                                                                                       // MakerGen.cs:429
}                                                                                                                                           // MakerGen.cs:528
