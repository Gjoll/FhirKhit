using System;                                                                                                                               // MakerGen.cs:451
using System.Diagnostics;                                                                                                                   // MakerGen.cs:452
using System.IO;                                                                                                                            // MakerGen.cs:453
using System.Linq;                                                                                                                          // MakerGen.cs:454
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:455
                                                                                                                                            // MakerGen.cs:456
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:457
{                                                                                                                                           // MakerGen.cs:458
    #region Json                                                                                                                            // MakerGen.cs:459
    #if NEVER                                                                                                                               // MakerGen.cs:460
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
    #endregion                                                                                                                              // MakerGen.cs:463
    /// <summary>
    /// Fhir resource 'SubstanceReferenceInformation'
    /// </summary>
    // 0. SubstanceReferenceInformation
    public class SubstanceReferenceInformation : FhirKhit.Maker.Common.Resource.ResourceBase                                                // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class SubstanceReferenceInformation_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                   // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 2. SubstanceReferenceInformation.gene
            public class Type_Gene : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Gene_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                               // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 3. SubstanceReferenceInformation.gene.geneSequenceOrigin
                    public ElementDefinitionInfo GeneSequenceOrigin;                                                                        // MakerGen.cs:236
                    // 4. SubstanceReferenceInformation.gene.gene
                    public ElementDefinitionInfo Gene;                                                                                      // MakerGen.cs:236
                    // 5. SubstanceReferenceInformation.gene.source
                    public ElementDefinitionInfo Source;                                                                                    // MakerGen.cs:236
                    public Type_Gene_Elements()                                                                                             // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 3. SubstanceReferenceInformation.gene.geneSequenceOrigin
                            this.GeneSequenceOrigin = new ElementDefinitionInfo                                                             // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "GeneSequenceOrigin",                                                                                // MakerGen.cs:255
                                Path= "SubstanceReferenceInformation.gene.geneSequenceOrigin",                                              // MakerGen.cs:256
                                Id = "SubstanceReferenceInformation.gene.geneSequenceOrigin",                                               // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 4. SubstanceReferenceInformation.gene.gene
                            this.Gene = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Gene",                                                                                              // MakerGen.cs:255
                                Path= "SubstanceReferenceInformation.gene.gene",                                                            // MakerGen.cs:256
                                Id = "SubstanceReferenceInformation.gene.gene",                                                             // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 5. SubstanceReferenceInformation.gene.source
                            this.Source = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Source",                                                                                            // MakerGen.cs:255
                                Path= "SubstanceReferenceInformation.gene.source",                                                          // MakerGen.cs:256
                                Id = "SubstanceReferenceInformation.gene.source",                                                           // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                     // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        GeneSequenceOrigin.Write(sDef);                                                                                     // MakerGen.cs:240
                        Gene.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Source.Write(sDef);                                                                                                 // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Gene_Elements Elements { get; }                                                                                 // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Gene()                                                                                                          // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Gene_Elements();                                                                               // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 6. SubstanceReferenceInformation.geneElement
            public class Type_GeneElement : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_GeneElement_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                        // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 7. SubstanceReferenceInformation.geneElement.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:236
                    // 8. SubstanceReferenceInformation.geneElement.element
                    public ElementDefinitionInfo Element;                                                                                   // MakerGen.cs:236
                    // 9. SubstanceReferenceInformation.geneElement.source
                    public ElementDefinitionInfo Source;                                                                                    // MakerGen.cs:236
                    public Type_GeneElement_Elements()                                                                                      // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 7. SubstanceReferenceInformation.geneElement.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Type",                                                                                              // MakerGen.cs:255
                                Path= "SubstanceReferenceInformation.geneElement.type",                                                     // MakerGen.cs:256
                                Id = "SubstanceReferenceInformation.geneElement.type",                                                      // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 8. SubstanceReferenceInformation.geneElement.element
                            this.Element = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Element",                                                                                           // MakerGen.cs:255
                                Path= "SubstanceReferenceInformation.geneElement.element",                                                  // MakerGen.cs:256
                                Id = "SubstanceReferenceInformation.geneElement.element",                                                   // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Identifier                                                            // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 9. SubstanceReferenceInformation.geneElement.source
                            this.Source = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Source",                                                                                            // MakerGen.cs:255
                                Path= "SubstanceReferenceInformation.geneElement.source",                                                   // MakerGen.cs:256
                                Id = "SubstanceReferenceInformation.geneElement.source",                                                    // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                     // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Element.Write(sDef);                                                                                                // MakerGen.cs:240
                        Source.Write(sDef);                                                                                                 // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_GeneElement_Elements Elements { get; }                                                                          // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_GeneElement()                                                                                                   // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_GeneElement_Elements();                                                                        // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 10. SubstanceReferenceInformation.classification
            public class Type_Classification : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Classification_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                     // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 11. SubstanceReferenceInformation.classification.domain
                    public ElementDefinitionInfo Domain;                                                                                    // MakerGen.cs:236
                    // 12. SubstanceReferenceInformation.classification.classification
                    public ElementDefinitionInfo Classification;                                                                            // MakerGen.cs:236
                    // 13. SubstanceReferenceInformation.classification.subtype
                    public ElementDefinitionInfo Subtype;                                                                                   // MakerGen.cs:236
                    // 14. SubstanceReferenceInformation.classification.source
                    public ElementDefinitionInfo Source;                                                                                    // MakerGen.cs:236
                    public Type_Classification_Elements()                                                                                   // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 11. SubstanceReferenceInformation.classification.domain
                            this.Domain = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Domain",                                                                                            // MakerGen.cs:255
                                Path= "SubstanceReferenceInformation.classification.domain",                                                // MakerGen.cs:256
                                Id = "SubstanceReferenceInformation.classification.domain",                                                 // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 12. SubstanceReferenceInformation.classification.classification
                            this.Classification = new ElementDefinitionInfo                                                                 // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Classification",                                                                                    // MakerGen.cs:255
                                Path= "SubstanceReferenceInformation.classification.classification",                                        // MakerGen.cs:256
                                Id = "SubstanceReferenceInformation.classification.classification",                                         // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 13. SubstanceReferenceInformation.classification.subtype
                            this.Subtype = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Subtype",                                                                                           // MakerGen.cs:255
                                Path= "SubstanceReferenceInformation.classification.subtype",                                               // MakerGen.cs:256
                                Id = "SubstanceReferenceInformation.classification.subtype",                                                // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 14. SubstanceReferenceInformation.classification.source
                            this.Source = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Source",                                                                                            // MakerGen.cs:255
                                Path= "SubstanceReferenceInformation.classification.source",                                                // MakerGen.cs:256
                                Id = "SubstanceReferenceInformation.classification.source",                                                 // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                     // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Domain.Write(sDef);                                                                                                 // MakerGen.cs:240
                        Classification.Write(sDef);                                                                                         // MakerGen.cs:240
                        Subtype.Write(sDef);                                                                                                // MakerGen.cs:240
                        Source.Write(sDef);                                                                                                 // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Classification_Elements Elements { get; }                                                                       // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Classification()                                                                                                // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Classification_Elements();                                                                     // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 15. SubstanceReferenceInformation.target
            public class Type_Target : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Target_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                             // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 16. SubstanceReferenceInformation.target.target
                    public ElementDefinitionInfo Target;                                                                                    // MakerGen.cs:236
                    // 17. SubstanceReferenceInformation.target.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:236
                    // 18. SubstanceReferenceInformation.target.interaction
                    public ElementDefinitionInfo Interaction;                                                                               // MakerGen.cs:236
                    // 19. SubstanceReferenceInformation.target.organism
                    public ElementDefinitionInfo Organism;                                                                                  // MakerGen.cs:236
                    // 20. SubstanceReferenceInformation.target.organismType
                    public ElementDefinitionInfo OrganismType;                                                                              // MakerGen.cs:236
                    // 21. SubstanceReferenceInformation.target.amount[x]
                    public ElementDefinitionInfo Amount;                                                                                    // MakerGen.cs:236
                    // 22. SubstanceReferenceInformation.target.amountType
                    public ElementDefinitionInfo AmountType;                                                                                // MakerGen.cs:236
                    // 23. SubstanceReferenceInformation.target.source
                    public ElementDefinitionInfo Source;                                                                                    // MakerGen.cs:236
                    public Type_Target_Elements()                                                                                           // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 16. SubstanceReferenceInformation.target.target
                            this.Target = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Target",                                                                                            // MakerGen.cs:255
                                Path= "SubstanceReferenceInformation.target.target",                                                        // MakerGen.cs:256
                                Id = "SubstanceReferenceInformation.target.target",                                                         // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Identifier                                                            // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 17. SubstanceReferenceInformation.target.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Type",                                                                                              // MakerGen.cs:255
                                Path= "SubstanceReferenceInformation.target.type",                                                          // MakerGen.cs:256
                                Id = "SubstanceReferenceInformation.target.type",                                                           // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 18. SubstanceReferenceInformation.target.interaction
                            this.Interaction = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Interaction",                                                                                       // MakerGen.cs:255
                                Path= "SubstanceReferenceInformation.target.interaction",                                                   // MakerGen.cs:256
                                Id = "SubstanceReferenceInformation.target.interaction",                                                    // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 19. SubstanceReferenceInformation.target.organism
                            this.Organism = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Organism",                                                                                          // MakerGen.cs:255
                                Path= "SubstanceReferenceInformation.target.organism",                                                      // MakerGen.cs:256
                                Id = "SubstanceReferenceInformation.target.organism",                                                       // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 20. SubstanceReferenceInformation.target.organismType
                            this.OrganismType = new ElementDefinitionInfo                                                                   // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "OrganismType",                                                                                      // MakerGen.cs:255
                                Path= "SubstanceReferenceInformation.target.organismType",                                                  // MakerGen.cs:256
                                Id = "SubstanceReferenceInformation.target.organismType",                                                   // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 21. SubstanceReferenceInformation.target.amount[x]
                            this.Amount = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Amount",                                                                                            // MakerGen.cs:255
                                Path= "SubstanceReferenceInformation.target.amount[x]",                                                     // MakerGen.cs:256
                                Id = "SubstanceReferenceInformation.target.amount[x]",                                                      // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Quantity                                                              // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Range                                                                 // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 22. SubstanceReferenceInformation.target.amountType
                            this.AmountType = new ElementDefinitionInfo                                                                     // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "AmountType",                                                                                        // MakerGen.cs:255
                                Path= "SubstanceReferenceInformation.target.amountType",                                                    // MakerGen.cs:256
                                Id = "SubstanceReferenceInformation.target.amountType",                                                     // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 23. SubstanceReferenceInformation.target.source
                            this.Source = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Source",                                                                                            // MakerGen.cs:255
                                Path= "SubstanceReferenceInformation.target.source",                                                        // MakerGen.cs:256
                                Id = "SubstanceReferenceInformation.target.source",                                                         // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                     // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Target.Write(sDef);                                                                                                 // MakerGen.cs:240
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Interaction.Write(sDef);                                                                                            // MakerGen.cs:240
                        Organism.Write(sDef);                                                                                               // MakerGen.cs:240
                        OrganismType.Write(sDef);                                                                                           // MakerGen.cs:240
                        Amount.Write(sDef);                                                                                                 // MakerGen.cs:240
                        AmountType.Write(sDef);                                                                                             // MakerGen.cs:240
                        Source.Write(sDef);                                                                                                 // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Target_Elements Elements { get; }                                                                               // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Target()                                                                                                        // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Target_Elements();                                                                             // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 1. SubstanceReferenceInformation.comment
            public ElementDefinitionInfo Comment;                                                                                           // MakerGen.cs:236
            public SubstanceReferenceInformation_Elements()                                                                                 // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. SubstanceReferenceInformation.comment
                    this.Comment = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Comment",                                                                                                   // MakerGen.cs:255
                        Path= "SubstanceReferenceInformation.comment",                                                                      // MakerGen.cs:256
                        Id = "SubstanceReferenceInformation.comment",                                                                       // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:429
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                Comment.Write(sDef);                                                                                                        // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public SubstanceReferenceInformation_Elements Elements { get; }                                                                     // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public SubstanceReferenceInformation()                                                                                              // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new SubstanceReferenceInformation_Elements();                                                                   // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:468
