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
    #endregion                                                                                                                              // MakerGen.cs:440
    /// <summary>
    /// Fhir resource 'SubstancePolymer'
    /// </summary>
    // 0. SubstancePolymer
    public class Resource_SubstancePolymer : FhirKhit.Maker.Common.Resource.ResourceBase                                                    // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 5. SubstancePolymer.monomerSet
        public class Type_MonomerSet : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 7. SubstancePolymer.monomerSet.startingMaterial
            public class Type_StartingMaterial : FhirKhit.Maker.Common.Complex.ComplexBase                                                  // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                // 8. SubstancePolymer.monomerSet.startingMaterial.material
                public ElementDefinitionInfo Element_Material;                                                                              // MakerGen.cs:212
                // 9. SubstancePolymer.monomerSet.startingMaterial.type
                public ElementDefinitionInfo Element_Type;                                                                                  // MakerGen.cs:212
                // 10. SubstancePolymer.monomerSet.startingMaterial.isDefining
                public ElementDefinitionInfo Element_IsDefining;                                                                            // MakerGen.cs:212
                // 11. SubstancePolymer.monomerSet.startingMaterial.amount
                public ElementDefinitionInfo Element_Amount;                                                                                // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:383
                {                                                                                                                           // MakerGen.cs:384
                    base.Write(sDef);                                                                                                       // MakerGen.cs:385
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:386
                    {                                                                                                                       // MakerGen.cs:387
                        Path = "SubstancePolymer.monomerSet.startingMaterial",                                                              // MakerGen.cs:388
                        ElementId = "SubstancePolymer.monomerSet.startingMaterial"                                                          // MakerGen.cs:389
                    });                                                                                                                     // MakerGen.cs:390
                    Element_Material.Write(sDef);                                                                                           // MakerGen.cs:216
                    Element_Type.Write(sDef);                                                                                               // MakerGen.cs:216
                    Element_IsDefining.Write(sDef);                                                                                         // MakerGen.cs:216
                    Element_Amount.Write(sDef);                                                                                             // MakerGen.cs:216
                }                                                                                                                           // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
                public Type_StartingMaterial()                                                                                              // MakerGen.cs:395
                {                                                                                                                           // MakerGen.cs:396
                    {                                                                                                                       // MakerGen.cs:227
                        // 8. SubstancePolymer.monomerSet.startingMaterial.material
                        this.Element_Material = new ElementDefinitionInfo                                                                   // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Material",                                                                                      // MakerGen.cs:231
                            Path= "SubstancePolymer.monomerSet.startingMaterial.material",                                                  // MakerGen.cs:232
                            Id = "SubstancePolymer.monomerSet.startingMaterial.material",                                                   // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:311
                                {                                                                                                           // MakerGen.cs:312
                                }                                                                                                           // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 9. SubstancePolymer.monomerSet.startingMaterial.type
                        this.Element_Type = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Type",                                                                                          // MakerGen.cs:231
                            Path= "SubstancePolymer.monomerSet.startingMaterial.type",                                                      // MakerGen.cs:232
                            Id = "SubstancePolymer.monomerSet.startingMaterial.type",                                                       // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:311
                                {                                                                                                           // MakerGen.cs:312
                                }                                                                                                           // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 10. SubstancePolymer.monomerSet.startingMaterial.isDefining
                        this.Element_IsDefining = new ElementDefinitionInfo                                                                 // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_IsDefining",                                                                                    // MakerGen.cs:231
                            Path= "SubstancePolymer.monomerSet.startingMaterial.isDefining",                                                // MakerGen.cs:232
                            Id = "SubstancePolymer.monomerSet.startingMaterial.isDefining",                                                 // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                       // MakerGen.cs:296
                                {                                                                                                           // MakerGen.cs:297
                                }                                                                                                           // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 11. SubstancePolymer.monomerSet.startingMaterial.amount
                        this.Element_Amount = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Amount",                                                                                        // MakerGen.cs:231
                            Path= "SubstancePolymer.monomerSet.startingMaterial.amount",                                                    // MakerGen.cs:232
                            Id = "SubstancePolymer.monomerSet.startingMaterial.amount",                                                     // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Complex.Type_SubstanceAmount                                                      // MakerGen.cs:351
                                {                                                                                                           // MakerGen.cs:352
                                }                                                                                                           // MakerGen.cs:353
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                }                                                                                                                           // MakerGen.cs:398
            }                                                                                                                               // MakerGen.cs:400
            // 6. SubstancePolymer.monomerSet.ratioType
            public ElementDefinitionInfo Element_RatioType;                                                                                 // MakerGen.cs:212
            // 7. SubstancePolymer.monomerSet.startingMaterial
            public ElementDefinitionInfo Element_StartingMaterial;                                                                          // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "SubstancePolymer.monomerSet",                                                                                   // MakerGen.cs:388
                    ElementId = "SubstancePolymer.monomerSet"                                                                               // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_RatioType.Write(sDef);                                                                                              // MakerGen.cs:216
                Element_StartingMaterial.Write(sDef);                                                                                       // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_MonomerSet()                                                                                                        // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 6. SubstancePolymer.monomerSet.ratioType
                    this.Element_RatioType = new ElementDefinitionInfo                                                                      // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_RatioType",                                                                                         // MakerGen.cs:231
                        Path= "SubstancePolymer.monomerSet.ratioType",                                                                      // MakerGen.cs:232
                        Id = "SubstancePolymer.monomerSet.ratioType",                                                                       // MakerGen.cs:233
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
                    // 7. SubstancePolymer.monomerSet.startingMaterial
                    this.Element_StartingMaterial = new ElementDefinitionInfo                                                               // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_StartingMaterial",                                                                                  // MakerGen.cs:231
                        Path= "SubstancePolymer.monomerSet.startingMaterial",                                                               // MakerGen.cs:232
                        Id = "SubstancePolymer.monomerSet.startingMaterial",                                                                // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new Type_StartingMaterial                                                                                       // MakerGen.cs:255
                            {                                                                                                               // MakerGen.cs:256
                            }                                                                                                               // MakerGen.cs:257
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 12. SubstancePolymer.repeat
        public class Type_Repeat : FhirKhit.Maker.Common.Complex.ComplexBase                                                                // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 16. SubstancePolymer.repeat.repeatUnit
            public class Type_RepeatUnit : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                // 20. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation
                public class Type_DegreeOfPolymerisation : FhirKhit.Maker.Common.Complex.ComplexBase                                        // MakerGen.cs:376
                {                                                                                                                           // MakerGen.cs:377
                    // 21. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree
                    public ElementDefinitionInfo Element_Degree;                                                                            // MakerGen.cs:212
                    // 22. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount
                    public ElementDefinitionInfo Element_Amount;                                                                            // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        base.Write(sDef);                                                                                                   // MakerGen.cs:385
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                  // MakerGen.cs:386
                        {                                                                                                                   // MakerGen.cs:387
                            Path = "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation",                                             // MakerGen.cs:388
                            ElementId = "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation"                                         // MakerGen.cs:389
                        });                                                                                                                 // MakerGen.cs:390
                        Element_Degree.Write(sDef);                                                                                         // MakerGen.cs:216
                        Element_Amount.Write(sDef);                                                                                         // MakerGen.cs:216
                    }                                                                                                                       // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
                    public Type_DegreeOfPolymerisation()                                                                                    // MakerGen.cs:395
                    {                                                                                                                       // MakerGen.cs:396
                        {                                                                                                                   // MakerGen.cs:227
                            // 21. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree
                            this.Element_Degree = new ElementDefinitionInfo                                                                 // MakerGen.cs:229
                            {                                                                                                               // MakerGen.cs:230
                                Name = "Element_Degree",                                                                                    // MakerGen.cs:231
                                Path= "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree",                                   // MakerGen.cs:232
                                Id = "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree",                                    // MakerGen.cs:233
                                Min = 0,                                                                                                    // MakerGen.cs:234
                                Max = 1,                                                                                                    // MakerGen.cs:235
                                Types = new BaseType[]                                                                                      // MakerGen.cs:236
                                {                                                                                                           // MakerGen.cs:237
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:311
                                    {                                                                                                       // MakerGen.cs:312
                                    }                                                                                                       // MakerGen.cs:315
                                }                                                                                                           // MakerGen.cs:239
                            };                                                                                                              // MakerGen.cs:240
                        }                                                                                                                   // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:227
                            // 22. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount
                            this.Element_Amount = new ElementDefinitionInfo                                                                 // MakerGen.cs:229
                            {                                                                                                               // MakerGen.cs:230
                                Name = "Element_Amount",                                                                                    // MakerGen.cs:231
                                Path= "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount",                                   // MakerGen.cs:232
                                Id = "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount",                                    // MakerGen.cs:233
                                Min = 0,                                                                                                    // MakerGen.cs:234
                                Max = 1,                                                                                                    // MakerGen.cs:235
                                Types = new BaseType[]                                                                                      // MakerGen.cs:236
                                {                                                                                                           // MakerGen.cs:237
                                    new FhirKhit.Maker.Common.Complex.Type_SubstanceAmount                                                  // MakerGen.cs:351
                                    {                                                                                                       // MakerGen.cs:352
                                    }                                                                                                       // MakerGen.cs:353
                                }                                                                                                           // MakerGen.cs:239
                            };                                                                                                              // MakerGen.cs:240
                        }                                                                                                                   // MakerGen.cs:241
                    }                                                                                                                       // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:400
                // 23. SubstancePolymer.repeat.repeatUnit.structuralRepresentation
                public class Type_StructuralRepresentation : FhirKhit.Maker.Common.Complex.ComplexBase                                      // MakerGen.cs:376
                {                                                                                                                           // MakerGen.cs:377
                    // 24. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type
                    public ElementDefinitionInfo Element_Type;                                                                              // MakerGen.cs:212
                    // 25. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.representation
                    public ElementDefinitionInfo Element_Representation;                                                                    // MakerGen.cs:212
                    // 26. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment
                    public ElementDefinitionInfo Element_Attachment;                                                                        // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        base.Write(sDef);                                                                                                   // MakerGen.cs:385
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                  // MakerGen.cs:386
                        {                                                                                                                   // MakerGen.cs:387
                            Path = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation",                                           // MakerGen.cs:388
                            ElementId = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation"                                       // MakerGen.cs:389
                        });                                                                                                                 // MakerGen.cs:390
                        Element_Type.Write(sDef);                                                                                           // MakerGen.cs:216
                        Element_Representation.Write(sDef);                                                                                 // MakerGen.cs:216
                        Element_Attachment.Write(sDef);                                                                                     // MakerGen.cs:216
                    }                                                                                                                       // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
                    public Type_StructuralRepresentation()                                                                                  // MakerGen.cs:395
                    {                                                                                                                       // MakerGen.cs:396
                        {                                                                                                                   // MakerGen.cs:227
                            // 24. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type
                            this.Element_Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:229
                            {                                                                                                               // MakerGen.cs:230
                                Name = "Element_Type",                                                                                      // MakerGen.cs:231
                                Path= "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type",                                   // MakerGen.cs:232
                                Id = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type",                                    // MakerGen.cs:233
                                Min = 0,                                                                                                    // MakerGen.cs:234
                                Max = 1,                                                                                                    // MakerGen.cs:235
                                Types = new BaseType[]                                                                                      // MakerGen.cs:236
                                {                                                                                                           // MakerGen.cs:237
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:311
                                    {                                                                                                       // MakerGen.cs:312
                                    }                                                                                                       // MakerGen.cs:315
                                }                                                                                                           // MakerGen.cs:239
                            };                                                                                                              // MakerGen.cs:240
                        }                                                                                                                   // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:227
                            // 25. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.representation
                            this.Element_Representation = new ElementDefinitionInfo                                                         // MakerGen.cs:229
                            {                                                                                                               // MakerGen.cs:230
                                Name = "Element_Representation",                                                                            // MakerGen.cs:231
                                Path= "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.representation",                         // MakerGen.cs:232
                                Id = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.representation",                          // MakerGen.cs:233
                                Min = 0,                                                                                                    // MakerGen.cs:234
                                Max = 1,                                                                                                    // MakerGen.cs:235
                                Types = new BaseType[]                                                                                      // MakerGen.cs:236
                                {                                                                                                           // MakerGen.cs:237
                                    new FhirKhit.Maker.Common.Primitive.Primitive_String                                                    // MakerGen.cs:296
                                    {                                                                                                       // MakerGen.cs:297
                                    }                                                                                                       // MakerGen.cs:300
                                }                                                                                                           // MakerGen.cs:239
                            };                                                                                                              // MakerGen.cs:240
                        }                                                                                                                   // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:227
                            // 26. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment
                            this.Element_Attachment = new ElementDefinitionInfo                                                             // MakerGen.cs:229
                            {                                                                                                               // MakerGen.cs:230
                                Name = "Element_Attachment",                                                                                // MakerGen.cs:231
                                Path= "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment",                             // MakerGen.cs:232
                                Id = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment",                              // MakerGen.cs:233
                                Min = 0,                                                                                                    // MakerGen.cs:234
                                Max = 1,                                                                                                    // MakerGen.cs:235
                                Types = new BaseType[]                                                                                      // MakerGen.cs:236
                                {                                                                                                           // MakerGen.cs:237
                                    new FhirKhit.Maker.Common.Complex.Type_Attachment                                                       // MakerGen.cs:351
                                    {                                                                                                       // MakerGen.cs:352
                                    }                                                                                                       // MakerGen.cs:353
                                }                                                                                                           // MakerGen.cs:239
                            };                                                                                                              // MakerGen.cs:240
                        }                                                                                                                   // MakerGen.cs:241
                    }                                                                                                                       // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:400
                // 17. SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation
                public ElementDefinitionInfo Element_OrientationOfPolymerisation;                                                           // MakerGen.cs:212
                // 18. SubstancePolymer.repeat.repeatUnit.repeatUnit
                public ElementDefinitionInfo Element_RepeatUnit;                                                                            // MakerGen.cs:212
                // 19. SubstancePolymer.repeat.repeatUnit.amount
                public ElementDefinitionInfo Element_Amount;                                                                                // MakerGen.cs:212
                // 20. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation
                public ElementDefinitionInfo Element_DegreeOfPolymerisation;                                                                // MakerGen.cs:212
                // 23. SubstancePolymer.repeat.repeatUnit.structuralRepresentation
                public ElementDefinitionInfo Element_StructuralRepresentation;                                                              // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:383
                {                                                                                                                           // MakerGen.cs:384
                    base.Write(sDef);                                                                                                       // MakerGen.cs:385
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:386
                    {                                                                                                                       // MakerGen.cs:387
                        Path = "SubstancePolymer.repeat.repeatUnit",                                                                        // MakerGen.cs:388
                        ElementId = "SubstancePolymer.repeat.repeatUnit"                                                                    // MakerGen.cs:389
                    });                                                                                                                     // MakerGen.cs:390
                    Element_OrientationOfPolymerisation.Write(sDef);                                                                        // MakerGen.cs:216
                    Element_RepeatUnit.Write(sDef);                                                                                         // MakerGen.cs:216
                    Element_Amount.Write(sDef);                                                                                             // MakerGen.cs:216
                    Element_DegreeOfPolymerisation.Write(sDef);                                                                             // MakerGen.cs:216
                    Element_StructuralRepresentation.Write(sDef);                                                                           // MakerGen.cs:216
                }                                                                                                                           // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
                public Type_RepeatUnit()                                                                                                    // MakerGen.cs:395
                {                                                                                                                           // MakerGen.cs:396
                    {                                                                                                                       // MakerGen.cs:227
                        // 17. SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation
                        this.Element_OrientationOfPolymerisation = new ElementDefinitionInfo                                                // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_OrientationOfPolymerisation",                                                                   // MakerGen.cs:231
                            Path= "SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation",                                         // MakerGen.cs:232
                            Id = "SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation",                                          // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:311
                                {                                                                                                           // MakerGen.cs:312
                                }                                                                                                           // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 18. SubstancePolymer.repeat.repeatUnit.repeatUnit
                        this.Element_RepeatUnit = new ElementDefinitionInfo                                                                 // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_RepeatUnit",                                                                                    // MakerGen.cs:231
                            Path= "SubstancePolymer.repeat.repeatUnit.repeatUnit",                                                          // MakerGen.cs:232
                            Id = "SubstancePolymer.repeat.repeatUnit.repeatUnit",                                                           // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Primitive.Primitive_String                                                        // MakerGen.cs:296
                                {                                                                                                           // MakerGen.cs:297
                                }                                                                                                           // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 19. SubstancePolymer.repeat.repeatUnit.amount
                        this.Element_Amount = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Amount",                                                                                        // MakerGen.cs:231
                            Path= "SubstancePolymer.repeat.repeatUnit.amount",                                                              // MakerGen.cs:232
                            Id = "SubstancePolymer.repeat.repeatUnit.amount",                                                               // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Complex.Type_SubstanceAmount                                                      // MakerGen.cs:351
                                {                                                                                                           // MakerGen.cs:352
                                }                                                                                                           // MakerGen.cs:353
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 20. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation
                        this.Element_DegreeOfPolymerisation = new ElementDefinitionInfo                                                     // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_DegreeOfPolymerisation",                                                                        // MakerGen.cs:231
                            Path= "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation",                                              // MakerGen.cs:232
                            Id = "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation",                                               // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = -1,                                                                                                       // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new Type_DegreeOfPolymerisation                                                                             // MakerGen.cs:255
                                {                                                                                                           // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:257
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 23. SubstancePolymer.repeat.repeatUnit.structuralRepresentation
                        this.Element_StructuralRepresentation = new ElementDefinitionInfo                                                   // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_StructuralRepresentation",                                                                      // MakerGen.cs:231
                            Path= "SubstancePolymer.repeat.repeatUnit.structuralRepresentation",                                            // MakerGen.cs:232
                            Id = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation",                                             // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = -1,                                                                                                       // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new Type_StructuralRepresentation                                                                           // MakerGen.cs:255
                                {                                                                                                           // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:257
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                }                                                                                                                           // MakerGen.cs:398
            }                                                                                                                               // MakerGen.cs:400
            // 13. SubstancePolymer.repeat.numberOfUnits
            public ElementDefinitionInfo Element_NumberOfUnits;                                                                             // MakerGen.cs:212
            // 14. SubstancePolymer.repeat.averageMolecularFormula
            public ElementDefinitionInfo Element_AverageMolecularFormula;                                                                   // MakerGen.cs:212
            // 15. SubstancePolymer.repeat.repeatUnitAmountType
            public ElementDefinitionInfo Element_RepeatUnitAmountType;                                                                      // MakerGen.cs:212
            // 16. SubstancePolymer.repeat.repeatUnit
            public ElementDefinitionInfo Element_RepeatUnit;                                                                                // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "SubstancePolymer.repeat",                                                                                       // MakerGen.cs:388
                    ElementId = "SubstancePolymer.repeat"                                                                                   // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_NumberOfUnits.Write(sDef);                                                                                          // MakerGen.cs:216
                Element_AverageMolecularFormula.Write(sDef);                                                                                // MakerGen.cs:216
                Element_RepeatUnitAmountType.Write(sDef);                                                                                   // MakerGen.cs:216
                Element_RepeatUnit.Write(sDef);                                                                                             // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Repeat()                                                                                                            // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 13. SubstancePolymer.repeat.numberOfUnits
                    this.Element_NumberOfUnits = new ElementDefinitionInfo                                                                  // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_NumberOfUnits",                                                                                     // MakerGen.cs:231
                        Path= "SubstancePolymer.repeat.numberOfUnits",                                                                      // MakerGen.cs:232
                        Id = "SubstancePolymer.repeat.numberOfUnits",                                                                       // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_Integer                                                           // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 14. SubstancePolymer.repeat.averageMolecularFormula
                    this.Element_AverageMolecularFormula = new ElementDefinitionInfo                                                        // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_AverageMolecularFormula",                                                                           // MakerGen.cs:231
                        Path= "SubstancePolymer.repeat.averageMolecularFormula",                                                            // MakerGen.cs:232
                        Id = "SubstancePolymer.repeat.averageMolecularFormula",                                                             // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 15. SubstancePolymer.repeat.repeatUnitAmountType
                    this.Element_RepeatUnitAmountType = new ElementDefinitionInfo                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_RepeatUnitAmountType",                                                                              // MakerGen.cs:231
                        Path= "SubstancePolymer.repeat.repeatUnitAmountType",                                                               // MakerGen.cs:232
                        Id = "SubstancePolymer.repeat.repeatUnitAmountType",                                                                // MakerGen.cs:233
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
                    // 16. SubstancePolymer.repeat.repeatUnit
                    this.Element_RepeatUnit = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_RepeatUnit",                                                                                        // MakerGen.cs:231
                        Path= "SubstancePolymer.repeat.repeatUnit",                                                                         // MakerGen.cs:232
                        Id = "SubstancePolymer.repeat.repeatUnit",                                                                          // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new Type_RepeatUnit                                                                                             // MakerGen.cs:255
                            {                                                                                                               // MakerGen.cs:256
                            }                                                                                                               // MakerGen.cs:257
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 1. SubstancePolymer.class
        public ElementDefinitionInfo Element_Class;                                                                                         // MakerGen.cs:212
        // 2. SubstancePolymer.geometry
        public ElementDefinitionInfo Element_Geometry;                                                                                      // MakerGen.cs:212
        // 3. SubstancePolymer.copolymerConnectivity
        public ElementDefinitionInfo Element_CopolymerConnectivity;                                                                         // MakerGen.cs:212
        // 4. SubstancePolymer.modification
        public ElementDefinitionInfo Element_Modification;                                                                                  // MakerGen.cs:212
        // 5. SubstancePolymer.monomerSet
        public ElementDefinitionInfo Element_MonomerSet;                                                                                    // MakerGen.cs:212
        // 12. SubstancePolymer.repeat
        public ElementDefinitionInfo Element_Repeat;                                                                                        // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "SubstancePolymer",                                                                                                  // MakerGen.cs:388
                ElementId = "SubstancePolymer"                                                                                              // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Class.Write(sDef);                                                                                                      // MakerGen.cs:216
            Element_Geometry.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_CopolymerConnectivity.Write(sDef);                                                                                      // MakerGen.cs:216
            Element_Modification.Write(sDef);                                                                                               // MakerGen.cs:216
            Element_MonomerSet.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_Repeat.Write(sDef);                                                                                                     // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Resource_SubstancePolymer()                                                                                                  // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. SubstancePolymer.class
                this.Element_Class = new ElementDefinitionInfo                                                                              // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Class",                                                                                                 // MakerGen.cs:231
                    Path= "SubstancePolymer.class",                                                                                         // MakerGen.cs:232
                    Id = "SubstancePolymer.class",                                                                                          // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 2. SubstancePolymer.geometry
                this.Element_Geometry = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Geometry",                                                                                              // MakerGen.cs:231
                    Path= "SubstancePolymer.geometry",                                                                                      // MakerGen.cs:232
                    Id = "SubstancePolymer.geometry",                                                                                       // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 3. SubstancePolymer.copolymerConnectivity
                this.Element_CopolymerConnectivity = new ElementDefinitionInfo                                                              // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_CopolymerConnectivity",                                                                                 // MakerGen.cs:231
                    Path= "SubstancePolymer.copolymerConnectivity",                                                                         // MakerGen.cs:232
                    Id = "SubstancePolymer.copolymerConnectivity",                                                                          // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 4. SubstancePolymer.modification
                this.Element_Modification = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Modification",                                                                                          // MakerGen.cs:231
                    Path= "SubstancePolymer.modification",                                                                                  // MakerGen.cs:232
                    Id = "SubstancePolymer.modification",                                                                                   // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 5. SubstancePolymer.monomerSet
                this.Element_MonomerSet = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_MonomerSet",                                                                                            // MakerGen.cs:231
                    Path= "SubstancePolymer.monomerSet",                                                                                    // MakerGen.cs:232
                    Id = "SubstancePolymer.monomerSet",                                                                                     // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_MonomerSet                                                                                                 // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 12. SubstancePolymer.repeat
                this.Element_Repeat = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Repeat",                                                                                                // MakerGen.cs:231
                    Path= "SubstancePolymer.repeat",                                                                                        // MakerGen.cs:232
                    Id = "SubstancePolymer.repeat",                                                                                         // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Repeat                                                                                                     // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            this.Name = "SubstancePolymer";                                                                                                 // MakerGen.cs:458
            this.Uri = "http://hl7.org/fhir/StructureDefinition/SubstancePolymer";                                                          // MakerGen.cs:459
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:445
