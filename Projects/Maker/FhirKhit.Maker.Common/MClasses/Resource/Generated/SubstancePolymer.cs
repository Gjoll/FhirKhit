using System;                                                                                                                               // MakerGen.cs:413
using System.Diagnostics;                                                                                                                   // MakerGen.cs:414
using System.IO;                                                                                                                            // MakerGen.cs:415
using System.Linq;                                                                                                                          // MakerGen.cs:416
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:417
                                                                                                                                            // MakerGen.cs:418
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:419
{                                                                                                                                           // MakerGen.cs:420
    #region Json                                                                                                                            // MakerGen.cs:421
    #if NEVER                                                                                                                               // MakerGen.cs:422
    {
      "resourceType": "StructureDefinition",
      "id": "SubstancePolymer",
      "url": "http://hl7.org/fhir/StructureDefinition/SubstancePolymer",
      "version": "4.0.0",
      "name": "SubstancePolymer",
      "status": "draft",
      "publisher": "Health Level Seven International (Biomedical Research and Regulation)",
      "description": "Todo.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "SubstancePolymer",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "SubstancePolymer",
            "path": "SubstancePolymer",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "SubstancePolymer.class",
            "path": "SubstancePolymer.class",
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
            "id": "SubstancePolymer.geometry",
            "path": "SubstancePolymer.geometry",
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
            "id": "SubstancePolymer.copolymerConnectivity",
            "path": "SubstancePolymer.copolymerConnectivity",
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
            "id": "SubstancePolymer.modification",
            "path": "SubstancePolymer.modification",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstancePolymer.monomerSet",
            "path": "SubstancePolymer.monomerSet",
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
            "id": "SubstancePolymer.monomerSet.ratioType",
            "path": "SubstancePolymer.monomerSet.ratioType",
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
            "id": "SubstancePolymer.monomerSet.startingMaterial",
            "path": "SubstancePolymer.monomerSet.startingMaterial",
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
            "id": "SubstancePolymer.monomerSet.startingMaterial.material",
            "path": "SubstancePolymer.monomerSet.startingMaterial.material",
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
            "id": "SubstancePolymer.monomerSet.startingMaterial.type",
            "path": "SubstancePolymer.monomerSet.startingMaterial.type",
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
            "id": "SubstancePolymer.monomerSet.startingMaterial.isDefining",
            "path": "SubstancePolymer.monomerSet.startingMaterial.isDefining",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstancePolymer.monomerSet.startingMaterial.amount",
            "path": "SubstancePolymer.monomerSet.startingMaterial.amount",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "SubstanceAmount"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstancePolymer.repeat",
            "path": "SubstancePolymer.repeat",
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
            "id": "SubstancePolymer.repeat.numberOfUnits",
            "path": "SubstancePolymer.repeat.numberOfUnits",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "integer"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstancePolymer.repeat.averageMolecularFormula",
            "path": "SubstancePolymer.repeat.averageMolecularFormula",
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
            "id": "SubstancePolymer.repeat.repeatUnitAmountType",
            "path": "SubstancePolymer.repeat.repeatUnitAmountType",
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
            "id": "SubstancePolymer.repeat.repeatUnit",
            "path": "SubstancePolymer.repeat.repeatUnit",
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
            "id": "SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation",
            "path": "SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation",
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
            "id": "SubstancePolymer.repeat.repeatUnit.repeatUnit",
            "path": "SubstancePolymer.repeat.repeatUnit.repeatUnit",
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
            "id": "SubstancePolymer.repeat.repeatUnit.amount",
            "path": "SubstancePolymer.repeat.repeatUnit.amount",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "SubstanceAmount"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation",
            "path": "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation",
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
            "id": "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree",
            "path": "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree",
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
            "id": "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount",
            "path": "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "SubstanceAmount"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstancePolymer.repeat.repeatUnit.structuralRepresentation",
            "path": "SubstancePolymer.repeat.repeatUnit.structuralRepresentation",
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
            "id": "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type",
            "path": "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type",
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
            "id": "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.representation",
            "path": "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.representation",
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
            "id": "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment",
            "path": "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Attachment"
              }
            ],
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:425
    /// <summary>
    /// Fhir resource 'SubstancePolymer'
    /// </summary>
    // 0. SubstancePolymer
    public class SubstancePolymer : FhirKhit.Maker.Common.Resource.ResourceBase                                                             // MakerGen.cs:374
    {                                                                                                                                       // MakerGen.cs:375
        // 5. SubstancePolymer.monomerSet
        public class Type_MonomerSet : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:374
        {                                                                                                                                   // MakerGen.cs:375
            // 7. SubstancePolymer.monomerSet.startingMaterial
            public class Type_StartingMaterial : FhirKhit.Maker.Common.Complex.ComplexBase                                                  // MakerGen.cs:374
            {                                                                                                                               // MakerGen.cs:375
                // 8. SubstancePolymer.monomerSet.startingMaterial.material
                public MakerElementInstance Element_Material;                                                                               // MakerGen.cs:232
                // 9. SubstancePolymer.monomerSet.startingMaterial.type
                public MakerElementInstance Element_Type;                                                                                   // MakerGen.cs:232
                // 10. SubstancePolymer.monomerSet.startingMaterial.isDefining
                public MakerElementInstance Element_IsDefining;                                                                             // MakerGen.cs:232
                // 11. SubstancePolymer.monomerSet.startingMaterial.amount
                public MakerElementInstance Element_Amount;                                                                                 // MakerGen.cs:232
                public Type_StartingMaterial()                                                                                              // MakerGen.cs:383
                {                                                                                                                           // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:243
                        // 8. SubstancePolymer.monomerSet.startingMaterial.material
                        this.Element_Material = new MakerElementInstance                                                                    // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Material",                                                                                      // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept                                                           // MakerGen.cs:304
                                {                                                                                                           // MakerGen.cs:305
                                }                                                                                                           // MakerGen.cs:308
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:356
                    {                                                                                                                       // MakerGen.cs:243
                        // 9. SubstancePolymer.monomerSet.startingMaterial.type
                        this.Element_Type = new MakerElementInstance                                                                        // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Type",                                                                                          // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept                                                           // MakerGen.cs:304
                                {                                                                                                           // MakerGen.cs:305
                                }                                                                                                           // MakerGen.cs:308
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:356
                    {                                                                                                                       // MakerGen.cs:243
                        // 10. SubstancePolymer.monomerSet.startingMaterial.isDefining
                        this.Element_IsDefining = new MakerElementInstance                                                                  // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_IsDefining",                                                                                    // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Boolean                                                                 // MakerGen.cs:289
                                {                                                                                                           // MakerGen.cs:290
                                }                                                                                                           // MakerGen.cs:293
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:356
                    {                                                                                                                       // MakerGen.cs:243
                        // 11. SubstancePolymer.monomerSet.startingMaterial.amount
                        this.Element_Amount = new MakerElementInstance                                                                      // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Amount",                                                                                        // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.SubstanceAmount                                                           // MakerGen.cs:347
                                {                                                                                                           // MakerGen.cs:348
                                }                                                                                                           // MakerGen.cs:349
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:356
                }                                                                                                                           // MakerGen.cs:395
            }                                                                                                                               // MakerGen.cs:379
            // 6. SubstancePolymer.monomerSet.ratioType
            public MakerElementInstance Element_RatioType;                                                                                  // MakerGen.cs:232
            public Type_MonomerSet()                                                                                                        // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                {                                                                                                                           // MakerGen.cs:243
                    // 6. SubstancePolymer.monomerSet.ratioType
                    this.Element_RatioType = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_RatioType",                                                                                         // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:304
                            {                                                                                                               // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:308
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
            }                                                                                                                               // MakerGen.cs:395
        }                                                                                                                                   // MakerGen.cs:379
        // 12. SubstancePolymer.repeat
        public class Type_Repeat : FhirKhit.Maker.Common.Complex.ComplexBase                                                                // MakerGen.cs:374
        {                                                                                                                                   // MakerGen.cs:375
            // 16. SubstancePolymer.repeat.repeatUnit
            public class Type_RepeatUnit : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:374
            {                                                                                                                               // MakerGen.cs:375
                // 20. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation
                public class Type_DegreeOfPolymerisation : FhirKhit.Maker.Common.Complex.ComplexBase                                        // MakerGen.cs:374
                {                                                                                                                           // MakerGen.cs:375
                    // 21. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree
                    public MakerElementInstance Element_Degree;                                                                             // MakerGen.cs:232
                    // 22. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount
                    public MakerElementInstance Element_Amount;                                                                             // MakerGen.cs:232
                    public Type_DegreeOfPolymerisation()                                                                                    // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        {                                                                                                                   // MakerGen.cs:243
                            // 21. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree
                            this.Element_Degree = new MakerElementInstance                                                                  // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Degree",                                                                                    // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBaseType[]                                                                                 // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:304
                                    {                                                                                                       // MakerGen.cs:305
                                    }                                                                                                       // MakerGen.cs:308
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:243
                            // 22. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount
                            this.Element_Amount = new MakerElementInstance                                                                  // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Amount",                                                                                    // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBaseType[]                                                                                 // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Complex.SubstanceAmount                                                       // MakerGen.cs:347
                                    {                                                                                                       // MakerGen.cs:348
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:356
                    }                                                                                                                       // MakerGen.cs:395
                }                                                                                                                           // MakerGen.cs:379
                // 23. SubstancePolymer.repeat.repeatUnit.structuralRepresentation
                public class Type_StructuralRepresentation : FhirKhit.Maker.Common.Complex.ComplexBase                                      // MakerGen.cs:374
                {                                                                                                                           // MakerGen.cs:375
                    // 24. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type
                    public MakerElementInstance Element_Type;                                                                               // MakerGen.cs:232
                    // 25. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.representation
                    public MakerElementInstance Element_Representation;                                                                     // MakerGen.cs:232
                    // 26. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment
                    public MakerElementInstance Element_Attachment;                                                                         // MakerGen.cs:232
                    public Type_StructuralRepresentation()                                                                                  // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        {                                                                                                                   // MakerGen.cs:243
                            // 24. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type
                            this.Element_Type = new MakerElementInstance                                                                    // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Type",                                                                                      // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBaseType[]                                                                                 // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:304
                                    {                                                                                                       // MakerGen.cs:305
                                    }                                                                                                       // MakerGen.cs:308
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:243
                            // 25. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.representation
                            this.Element_Representation = new MakerElementInstance                                                          // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Representation",                                                                            // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBaseType[]                                                                                 // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    }                                                                                                       // MakerGen.cs:293
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:243
                            // 26. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment
                            this.Element_Attachment = new MakerElementInstance                                                              // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Attachment",                                                                                // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBaseType[]                                                                                 // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Complex.Attachment                                                            // MakerGen.cs:347
                                    {                                                                                                       // MakerGen.cs:348
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:356
                    }                                                                                                                       // MakerGen.cs:395
                }                                                                                                                           // MakerGen.cs:379
                // 17. SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation
                public MakerElementInstance Element_OrientationOfPolymerisation;                                                            // MakerGen.cs:232
                // 18. SubstancePolymer.repeat.repeatUnit.repeatUnit
                public MakerElementInstance Element_RepeatUnit;                                                                             // MakerGen.cs:232
                // 19. SubstancePolymer.repeat.repeatUnit.amount
                public MakerElementInstance Element_Amount;                                                                                 // MakerGen.cs:232
                public Type_RepeatUnit()                                                                                                    // MakerGen.cs:383
                {                                                                                                                           // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:243
                        // 17. SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation
                        this.Element_OrientationOfPolymerisation = new MakerElementInstance                                                 // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_OrientationOfPolymerisation",                                                                   // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept                                                           // MakerGen.cs:304
                                {                                                                                                           // MakerGen.cs:305
                                }                                                                                                           // MakerGen.cs:308
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:356
                    {                                                                                                                       // MakerGen.cs:243
                        // 18. SubstancePolymer.repeat.repeatUnit.repeatUnit
                        this.Element_RepeatUnit = new MakerElementInstance                                                                  // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_RepeatUnit",                                                                                    // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.String                                                                  // MakerGen.cs:289
                                {                                                                                                           // MakerGen.cs:290
                                }                                                                                                           // MakerGen.cs:293
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:356
                    {                                                                                                                       // MakerGen.cs:243
                        // 19. SubstancePolymer.repeat.repeatUnit.amount
                        this.Element_Amount = new MakerElementInstance                                                                      // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Amount",                                                                                        // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.SubstanceAmount                                                           // MakerGen.cs:347
                                {                                                                                                           // MakerGen.cs:348
                                }                                                                                                           // MakerGen.cs:349
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:356
                }                                                                                                                           // MakerGen.cs:395
            }                                                                                                                               // MakerGen.cs:379
            // 13. SubstancePolymer.repeat.numberOfUnits
            public MakerElementInstance Element_NumberOfUnits;                                                                              // MakerGen.cs:232
            // 14. SubstancePolymer.repeat.averageMolecularFormula
            public MakerElementInstance Element_AverageMolecularFormula;                                                                    // MakerGen.cs:232
            // 15. SubstancePolymer.repeat.repeatUnitAmountType
            public MakerElementInstance Element_RepeatUnitAmountType;                                                                       // MakerGen.cs:232
            public Type_Repeat()                                                                                                            // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                {                                                                                                                           // MakerGen.cs:243
                    // 13. SubstancePolymer.repeat.numberOfUnits
                    this.Element_NumberOfUnits = new MakerElementInstance                                                                   // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_NumberOfUnits",                                                                                     // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Integer                                                                     // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            }                                                                                                               // MakerGen.cs:293
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 14. SubstancePolymer.repeat.averageMolecularFormula
                    this.Element_AverageMolecularFormula = new MakerElementInstance                                                         // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_AverageMolecularFormula",                                                                           // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            }                                                                                                               // MakerGen.cs:293
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 15. SubstancePolymer.repeat.repeatUnitAmountType
                    this.Element_RepeatUnitAmountType = new MakerElementInstance                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_RepeatUnitAmountType",                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:304
                            {                                                                                                               // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:308
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
            }                                                                                                                               // MakerGen.cs:395
        }                                                                                                                                   // MakerGen.cs:379
        // 1. SubstancePolymer.class
        public MakerElementInstance Element_Class;                                                                                          // MakerGen.cs:232
        // 2. SubstancePolymer.geometry
        public MakerElementInstance Element_Geometry;                                                                                       // MakerGen.cs:232
        // 3. SubstancePolymer.copolymerConnectivity
        public MakerElementInstance Element_CopolymerConnectivity;                                                                          // MakerGen.cs:232
        // 4. SubstancePolymer.modification
        public MakerElementInstance Element_Modification;                                                                                   // MakerGen.cs:232
        public SubstancePolymer()                                                                                                           // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:243
                // 1. SubstancePolymer.class
                this.Element_Class = new MakerElementInstance                                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Class",                                                                                                 // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:304
                        {                                                                                                                   // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:308
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 2. SubstancePolymer.geometry
                this.Element_Geometry = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Geometry",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:304
                        {                                                                                                                   // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:308
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 3. SubstancePolymer.copolymerConnectivity
                this.Element_CopolymerConnectivity = new MakerElementInstance                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_CopolymerConnectivity",                                                                                 // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:304
                        {                                                                                                                   // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:308
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 4. SubstancePolymer.modification
                this.Element_Modification = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Modification",                                                                                          // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String                                                                          // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
        }                                                                                                                                   // MakerGen.cs:395
    }                                                                                                                                       // MakerGen.cs:379
}                                                                                                                                           // MakerGen.cs:430
