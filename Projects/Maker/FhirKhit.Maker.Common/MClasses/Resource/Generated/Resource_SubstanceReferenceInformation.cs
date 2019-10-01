using System;                                                                                                                               // MakerGen.cs:428
using System.Diagnostics;                                                                                                                   // MakerGen.cs:429
using System.IO;                                                                                                                            // MakerGen.cs:430
using System.Linq;                                                                                                                          // MakerGen.cs:431
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:432
                                                                                                                                            // MakerGen.cs:433
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:434
{                                                                                                                                           // MakerGen.cs:435
    #region Json                                                                                                                            // MakerGen.cs:436
    #if NEVER                                                                                                                               // MakerGen.cs:437
    {
      "resourceType": "StructureDefinition",
      "id": "SubstanceReferenceInformation",
      "url": "http://hl7.org/fhir/StructureDefinition/SubstanceReferenceInformation",
      "version": "4.0.0",
      "name": "SubstanceReferenceInformation",
      "status": "draft",
      "publisher": "Health Level Seven International (Biomedical Research and Regulation)",
      "description": "Todo.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "SubstanceReferenceInformation",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "SubstanceReferenceInformation",
            "path": "SubstanceReferenceInformation",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "SubstanceReferenceInformation.comment",
            "path": "SubstanceReferenceInformation.comment",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceReferenceInformation.gene",
            "path": "SubstanceReferenceInformation.gene",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceReferenceInformation.gene.geneSequenceOrigin",
            "path": "SubstanceReferenceInformation.gene.geneSequenceOrigin",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceReferenceInformation.gene.gene",
            "path": "SubstanceReferenceInformation.gene.gene",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceReferenceInformation.gene.source",
            "path": "SubstanceReferenceInformation.gene.source",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceReferenceInformation.geneElement",
            "path": "SubstanceReferenceInformation.geneElement",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceReferenceInformation.geneElement.type",
            "path": "SubstanceReferenceInformation.geneElement.type",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceReferenceInformation.geneElement.element",
            "path": "SubstanceReferenceInformation.geneElement.element",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Identifier"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceReferenceInformation.geneElement.source",
            "path": "SubstanceReferenceInformation.geneElement.source",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceReferenceInformation.classification",
            "path": "SubstanceReferenceInformation.classification",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceReferenceInformation.classification.domain",
            "path": "SubstanceReferenceInformation.classification.domain",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceReferenceInformation.classification.classification",
            "path": "SubstanceReferenceInformation.classification.classification",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceReferenceInformation.classification.subtype",
            "path": "SubstanceReferenceInformation.classification.subtype",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceReferenceInformation.classification.source",
            "path": "SubstanceReferenceInformation.classification.source",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceReferenceInformation.target",
            "path": "SubstanceReferenceInformation.target",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceReferenceInformation.target.target",
            "path": "SubstanceReferenceInformation.target.target",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Identifier"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceReferenceInformation.target.type",
            "path": "SubstanceReferenceInformation.target.type",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceReferenceInformation.target.interaction",
            "path": "SubstanceReferenceInformation.target.interaction",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceReferenceInformation.target.organism",
            "path": "SubstanceReferenceInformation.target.organism",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceReferenceInformation.target.organismType",
            "path": "SubstanceReferenceInformation.target.organismType",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceReferenceInformation.target.amount[x]",
            "path": "SubstanceReferenceInformation.target.amount[x]",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity"
              },
              {
                "code": "Range"
              },
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceReferenceInformation.target.amountType",
            "path": "SubstanceReferenceInformation.target.amountType",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceReferenceInformation.target.source",
            "path": "SubstanceReferenceInformation.target.source",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                ]
              }
            ],
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:440
    /// <summary>
    /// Fhir resource 'SubstanceReferenceInformation'
    /// </summary>
    // 0. SubstanceReferenceInformation
    public class Resource_SubstanceReferenceInformation : FhirKhit.Maker.Common.Resource.ResourceBase                                       // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 2. SubstanceReferenceInformation.gene
        public class Type_Gene : FhirKhit.Maker.Common.Complex.ComplexBase                                                                  // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 3. SubstanceReferenceInformation.gene.geneSequenceOrigin
            public ElementDefinitionInfo Element_GeneSequenceOrigin;                                                                        // MakerGen.cs:212
            // 4. SubstanceReferenceInformation.gene.gene
            public ElementDefinitionInfo Element_Gene;                                                                                      // MakerGen.cs:212
            // 5. SubstanceReferenceInformation.gene.source
            public ElementDefinitionInfo Element_Source;                                                                                    // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "SubstanceReferenceInformation.gene",                                                                            // MakerGen.cs:388
                    ElementId = "SubstanceReferenceInformation.gene"                                                                        // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_GeneSequenceOrigin.Write(sDef);                                                                                     // MakerGen.cs:216
                Element_Gene.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_Source.Write(sDef);                                                                                                 // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Gene()                                                                                                              // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 3. SubstanceReferenceInformation.gene.geneSequenceOrigin
                    this.Element_GeneSequenceOrigin = new ElementDefinitionInfo                                                             // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_GeneSequenceOrigin",                                                                                // MakerGen.cs:231
                        Path= "SubstanceReferenceInformation.gene.geneSequenceOrigin",                                                      // MakerGen.cs:232
                        Id = "SubstanceReferenceInformation.gene.geneSequenceOrigin",                                                       // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 4. SubstanceReferenceInformation.gene.gene
                    this.Element_Gene = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Gene",                                                                                              // MakerGen.cs:231
                        Path= "SubstanceReferenceInformation.gene.gene",                                                                    // MakerGen.cs:232
                        Id = "SubstanceReferenceInformation.gene.gene",                                                                     // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 5. SubstanceReferenceInformation.gene.source
                    this.Element_Source = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Source",                                                                                            // MakerGen.cs:231
                        Path= "SubstanceReferenceInformation.gene.source",                                                                  // MakerGen.cs:232
                        Id = "SubstanceReferenceInformation.gene.source",                                                                   // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:339
                            {                                                                                                               // MakerGen.cs:340
                                TargetProfile = new String[]                                                                                // MakerGen.cs:342
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                             // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:343
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 6. SubstanceReferenceInformation.geneElement
        public class Type_GeneElement : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 7. SubstanceReferenceInformation.geneElement.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:212
            // 8. SubstanceReferenceInformation.geneElement.element
            public ElementDefinitionInfo Element_Element;                                                                                   // MakerGen.cs:212
            // 9. SubstanceReferenceInformation.geneElement.source
            public ElementDefinitionInfo Element_Source;                                                                                    // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "SubstanceReferenceInformation.geneElement",                                                                     // MakerGen.cs:388
                    ElementId = "SubstanceReferenceInformation.geneElement"                                                                 // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_Element.Write(sDef);                                                                                                // MakerGen.cs:216
                Element_Source.Write(sDef);                                                                                                 // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_GeneElement()                                                                                                       // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 7. SubstanceReferenceInformation.geneElement.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Type",                                                                                              // MakerGen.cs:231
                        Path= "SubstanceReferenceInformation.geneElement.type",                                                             // MakerGen.cs:232
                        Id = "SubstanceReferenceInformation.geneElement.type",                                                              // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 8. SubstanceReferenceInformation.geneElement.element
                    this.Element_Element = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Element",                                                                                           // MakerGen.cs:231
                        Path= "SubstanceReferenceInformation.geneElement.element",                                                          // MakerGen.cs:232
                        Id = "SubstanceReferenceInformation.geneElement.element",                                                           // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Identifier                                                               // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            }                                                                                                               // MakerGen.cs:353
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 9. SubstanceReferenceInformation.geneElement.source
                    this.Element_Source = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Source",                                                                                            // MakerGen.cs:231
                        Path= "SubstanceReferenceInformation.geneElement.source",                                                           // MakerGen.cs:232
                        Id = "SubstanceReferenceInformation.geneElement.source",                                                            // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:339
                            {                                                                                                               // MakerGen.cs:340
                                TargetProfile = new String[]                                                                                // MakerGen.cs:342
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                             // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:343
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 10. SubstanceReferenceInformation.classification
        public class Type_Classification : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 11. SubstanceReferenceInformation.classification.domain
            public ElementDefinitionInfo Element_Domain;                                                                                    // MakerGen.cs:212
            // 12. SubstanceReferenceInformation.classification.classification
            public ElementDefinitionInfo Element_Classification;                                                                            // MakerGen.cs:212
            // 13. SubstanceReferenceInformation.classification.subtype
            public ElementDefinitionInfo Element_Subtype;                                                                                   // MakerGen.cs:212
            // 14. SubstanceReferenceInformation.classification.source
            public ElementDefinitionInfo Element_Source;                                                                                    // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "SubstanceReferenceInformation.classification",                                                                  // MakerGen.cs:388
                    ElementId = "SubstanceReferenceInformation.classification"                                                              // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Domain.Write(sDef);                                                                                                 // MakerGen.cs:216
                Element_Classification.Write(sDef);                                                                                         // MakerGen.cs:216
                Element_Subtype.Write(sDef);                                                                                                // MakerGen.cs:216
                Element_Source.Write(sDef);                                                                                                 // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Classification()                                                                                                    // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 11. SubstanceReferenceInformation.classification.domain
                    this.Element_Domain = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Domain",                                                                                            // MakerGen.cs:231
                        Path= "SubstanceReferenceInformation.classification.domain",                                                        // MakerGen.cs:232
                        Id = "SubstanceReferenceInformation.classification.domain",                                                         // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 12. SubstanceReferenceInformation.classification.classification
                    this.Element_Classification = new ElementDefinitionInfo                                                                 // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Classification",                                                                                    // MakerGen.cs:231
                        Path= "SubstanceReferenceInformation.classification.classification",                                                // MakerGen.cs:232
                        Id = "SubstanceReferenceInformation.classification.classification",                                                 // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 13. SubstanceReferenceInformation.classification.subtype
                    this.Element_Subtype = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Subtype",                                                                                           // MakerGen.cs:231
                        Path= "SubstanceReferenceInformation.classification.subtype",                                                       // MakerGen.cs:232
                        Id = "SubstanceReferenceInformation.classification.subtype",                                                        // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 14. SubstanceReferenceInformation.classification.source
                    this.Element_Source = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Source",                                                                                            // MakerGen.cs:231
                        Path= "SubstanceReferenceInformation.classification.source",                                                        // MakerGen.cs:232
                        Id = "SubstanceReferenceInformation.classification.source",                                                         // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:339
                            {                                                                                                               // MakerGen.cs:340
                                TargetProfile = new String[]                                                                                // MakerGen.cs:342
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                             // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:343
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 15. SubstanceReferenceInformation.target
        public class Type_Target : FhirKhit.Maker.Common.Complex.ComplexBase                                                                // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 16. SubstanceReferenceInformation.target.target
            public ElementDefinitionInfo Element_Target;                                                                                    // MakerGen.cs:212
            // 17. SubstanceReferenceInformation.target.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:212
            // 18. SubstanceReferenceInformation.target.interaction
            public ElementDefinitionInfo Element_Interaction;                                                                               // MakerGen.cs:212
            // 19. SubstanceReferenceInformation.target.organism
            public ElementDefinitionInfo Element_Organism;                                                                                  // MakerGen.cs:212
            // 20. SubstanceReferenceInformation.target.organismType
            public ElementDefinitionInfo Element_OrganismType;                                                                              // MakerGen.cs:212
            // 21. SubstanceReferenceInformation.target.amount[x]
            public ElementDefinitionInfo Element_Amount;                                                                                    // MakerGen.cs:212
            // 22. SubstanceReferenceInformation.target.amountType
            public ElementDefinitionInfo Element_AmountType;                                                                                // MakerGen.cs:212
            // 23. SubstanceReferenceInformation.target.source
            public ElementDefinitionInfo Element_Source;                                                                                    // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "SubstanceReferenceInformation.target",                                                                          // MakerGen.cs:388
                    ElementId = "SubstanceReferenceInformation.target"                                                                      // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Target.Write(sDef);                                                                                                 // MakerGen.cs:216
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_Interaction.Write(sDef);                                                                                            // MakerGen.cs:216
                Element_Organism.Write(sDef);                                                                                               // MakerGen.cs:216
                Element_OrganismType.Write(sDef);                                                                                           // MakerGen.cs:216
                Element_Amount.Write(sDef);                                                                                                 // MakerGen.cs:216
                Element_AmountType.Write(sDef);                                                                                             // MakerGen.cs:216
                Element_Source.Write(sDef);                                                                                                 // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Target()                                                                                                            // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 16. SubstanceReferenceInformation.target.target
                    this.Element_Target = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Target",                                                                                            // MakerGen.cs:231
                        Path= "SubstanceReferenceInformation.target.target",                                                                // MakerGen.cs:232
                        Id = "SubstanceReferenceInformation.target.target",                                                                 // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Identifier                                                               // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            }                                                                                                               // MakerGen.cs:353
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 17. SubstanceReferenceInformation.target.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Type",                                                                                              // MakerGen.cs:231
                        Path= "SubstanceReferenceInformation.target.type",                                                                  // MakerGen.cs:232
                        Id = "SubstanceReferenceInformation.target.type",                                                                   // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 18. SubstanceReferenceInformation.target.interaction
                    this.Element_Interaction = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Interaction",                                                                                       // MakerGen.cs:231
                        Path= "SubstanceReferenceInformation.target.interaction",                                                           // MakerGen.cs:232
                        Id = "SubstanceReferenceInformation.target.interaction",                                                            // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 19. SubstanceReferenceInformation.target.organism
                    this.Element_Organism = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Organism",                                                                                          // MakerGen.cs:231
                        Path= "SubstanceReferenceInformation.target.organism",                                                              // MakerGen.cs:232
                        Id = "SubstanceReferenceInformation.target.organism",                                                               // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 20. SubstanceReferenceInformation.target.organismType
                    this.Element_OrganismType = new ElementDefinitionInfo                                                                   // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_OrganismType",                                                                                      // MakerGen.cs:231
                        Path= "SubstanceReferenceInformation.target.organismType",                                                          // MakerGen.cs:232
                        Id = "SubstanceReferenceInformation.target.organismType",                                                           // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 21. SubstanceReferenceInformation.target.amount[x]
                    this.Element_Amount = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Amount",                                                                                            // MakerGen.cs:231
                        Path= "SubstanceReferenceInformation.target.amount[x]",                                                             // MakerGen.cs:232
                        Id = "SubstanceReferenceInformation.target.amount[x]",                                                              // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            },                                                                                                              // MakerGen.cs:353
                            new FhirKhit.Maker.Common.Complex.Type_Range                                                                    // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            },                                                                                                              // MakerGen.cs:353
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 22. SubstanceReferenceInformation.target.amountType
                    this.Element_AmountType = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_AmountType",                                                                                        // MakerGen.cs:231
                        Path= "SubstanceReferenceInformation.target.amountType",                                                            // MakerGen.cs:232
                        Id = "SubstanceReferenceInformation.target.amountType",                                                             // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 23. SubstanceReferenceInformation.target.source
                    this.Element_Source = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Source",                                                                                            // MakerGen.cs:231
                        Path= "SubstanceReferenceInformation.target.source",                                                                // MakerGen.cs:232
                        Id = "SubstanceReferenceInformation.target.source",                                                                 // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:339
                            {                                                                                                               // MakerGen.cs:340
                                TargetProfile = new String[]                                                                                // MakerGen.cs:342
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                             // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:343
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 1. SubstanceReferenceInformation.comment
        public ElementDefinitionInfo Element_Comment;                                                                                       // MakerGen.cs:212
        // 2. SubstanceReferenceInformation.gene
        public ElementDefinitionInfo Element_Gene;                                                                                          // MakerGen.cs:212
        // 6. SubstanceReferenceInformation.geneElement
        public ElementDefinitionInfo Element_GeneElement;                                                                                   // MakerGen.cs:212
        // 10. SubstanceReferenceInformation.classification
        public ElementDefinitionInfo Element_Classification;                                                                                // MakerGen.cs:212
        // 15. SubstanceReferenceInformation.target
        public ElementDefinitionInfo Element_Target;                                                                                        // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "SubstanceReferenceInformation",                                                                                     // MakerGen.cs:388
                ElementId = "SubstanceReferenceInformation"                                                                                 // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Comment.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Gene.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_GeneElement.Write(sDef);                                                                                                // MakerGen.cs:216
            Element_Classification.Write(sDef);                                                                                             // MakerGen.cs:216
            Element_Target.Write(sDef);                                                                                                     // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Resource_SubstanceReferenceInformation()                                                                                     // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. SubstanceReferenceInformation.comment
                this.Element_Comment = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Comment",                                                                                               // MakerGen.cs:231
                    Path= "SubstanceReferenceInformation.comment",                                                                          // MakerGen.cs:232
                    Id = "SubstanceReferenceInformation.comment",                                                                           // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 2. SubstanceReferenceInformation.gene
                this.Element_Gene = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Gene",                                                                                                  // MakerGen.cs:231
                    Path= "SubstanceReferenceInformation.gene",                                                                             // MakerGen.cs:232
                    Id = "SubstanceReferenceInformation.gene",                                                                              // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Gene                                                                                                       // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 6. SubstanceReferenceInformation.geneElement
                this.Element_GeneElement = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_GeneElement",                                                                                           // MakerGen.cs:231
                    Path= "SubstanceReferenceInformation.geneElement",                                                                      // MakerGen.cs:232
                    Id = "SubstanceReferenceInformation.geneElement",                                                                       // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_GeneElement                                                                                                // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 10. SubstanceReferenceInformation.classification
                this.Element_Classification = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Classification",                                                                                        // MakerGen.cs:231
                    Path= "SubstanceReferenceInformation.classification",                                                                   // MakerGen.cs:232
                    Id = "SubstanceReferenceInformation.classification",                                                                    // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Classification                                                                                             // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 15. SubstanceReferenceInformation.target
                this.Element_Target = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Target",                                                                                                // MakerGen.cs:231
                    Path= "SubstanceReferenceInformation.target",                                                                           // MakerGen.cs:232
                    Id = "SubstanceReferenceInformation.target",                                                                            // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Target                                                                                                     // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            this.Name = "SubstanceReferenceInformation";                                                                                    // MakerGen.cs:458
            this.Uri = "http://hl7.org/fhir/StructureDefinition/SubstanceReferenceInformation";                                             // MakerGen.cs:459
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:445
