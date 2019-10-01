using System;                                                                                                                               // MakerGen.cs:508
using System.Diagnostics;                                                                                                                   // MakerGen.cs:509
using System.IO;                                                                                                                            // MakerGen.cs:510
using System.Linq;                                                                                                                          // MakerGen.cs:511
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:512
                                                                                                                                            // MakerGen.cs:513
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:514
{                                                                                                                                           // MakerGen.cs:515
    #region Json                                                                                                                            // MakerGen.cs:516
    #if NEVER
    {
      "resourceType": "StructureDefinition",
      "id": "ProdCharacteristic",
      "url": "http://hl7.org/fhir/StructureDefinition/ProdCharacteristic",
      "version": "4.0.0",
      "name": "ProdCharacteristic",
      "status": "draft",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for ProdCharacteristic Type: The marketing status describes the date when a medicinal product is actually put on the market or the date as of which it is no longer available.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "ProdCharacteristic",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/BackboneElement",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "ProdCharacteristic",
            "path": "ProdCharacteristic",
            "short": "The marketing status describes the date when a medicinal product is actually put on the market or the date as of which it is no longer available",
            "definition": "The marketing status describes the date when a medicinal product is actually put on the market or the date as of which it is no longer available.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "ProdCharacteristic.height",
            "path": "ProdCharacteristic.height",
            "short": "Where applicable, the height can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used",
            "definition": "Where applicable, the height can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ProdCharacteristic.width",
            "path": "ProdCharacteristic.width",
            "short": "Where applicable, the width can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used",
            "definition": "Where applicable, the width can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ProdCharacteristic.depth",
            "path": "ProdCharacteristic.depth",
            "short": "Where applicable, the depth can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used",
            "definition": "Where applicable, the depth can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ProdCharacteristic.weight",
            "path": "ProdCharacteristic.weight",
            "short": "Where applicable, the weight can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used",
            "definition": "Where applicable, the weight can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ProdCharacteristic.nominalVolume",
            "path": "ProdCharacteristic.nominalVolume",
            "short": "Where applicable, the nominal volume can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used",
            "definition": "Where applicable, the nominal volume can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ProdCharacteristic.externalDiameter",
            "path": "ProdCharacteristic.externalDiameter",
            "short": "Where applicable, the external diameter can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used",
            "definition": "Where applicable, the external diameter can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ProdCharacteristic.shape",
            "path": "ProdCharacteristic.shape",
            "short": "Where applicable, the shape can be specified An appropriate controlled vocabulary shall be used The term and the term identifier shall be used",
            "definition": "Where applicable, the shape can be specified An appropriate controlled vocabulary shall be used The term and the term identifier shall be used.",
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
            "id": "ProdCharacteristic.color",
            "path": "ProdCharacteristic.color",
            "short": "Where applicable, the color can be specified An appropriate controlled vocabulary shall be used The term and the term identifier shall be used",
            "definition": "Where applicable, the color can be specified An appropriate controlled vocabulary shall be used The term and the term identifier shall be used.",
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
            "id": "ProdCharacteristic.imprint",
            "path": "ProdCharacteristic.imprint",
            "short": "Where applicable, the imprint can be specified as text",
            "definition": "Where applicable, the imprint can be specified as text.",
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
            "id": "ProdCharacteristic.image",
            "path": "ProdCharacteristic.image",
            "short": "Where applicable, the image can be provided The format of the image attachment shall be specified by regional implementations",
            "definition": "Where applicable, the image can be provided The format of the image attachment shall be specified by regional implementations.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Attachment"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ProdCharacteristic.scoring",
            "path": "ProdCharacteristic.scoring",
            "short": "Where applicable, the scoring can be specified An appropriate controlled vocabulary shall be used The term and the term identifier shall be used",
            "definition": "Where applicable, the scoring can be specified An appropriate controlled vocabulary shall be used The term and the term identifier shall be used.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:520
    /// <summary>
    /// Fhir complex 'ProdCharacteristic'
    /// </summary>
    // 0. ProdCharacteristic
    public class Type_ProdCharacteristic : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        public class Type_ProdCharacteristic_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                         // MakerGen.cs:378
        {                                                                                                                                   // MakerGen.cs:379
            // 1. ProdCharacteristic.height
            public ElementDefinitionInfo Element_Height;                                                                                    // MakerGen.cs:211
            // 2. ProdCharacteristic.width
            public ElementDefinitionInfo Element_Width;                                                                                     // MakerGen.cs:211
            // 3. ProdCharacteristic.depth
            public ElementDefinitionInfo Element_Depth;                                                                                     // MakerGen.cs:211
            // 4. ProdCharacteristic.weight
            public ElementDefinitionInfo Element_Weight;                                                                                    // MakerGen.cs:211
            // 5. ProdCharacteristic.nominalVolume
            public ElementDefinitionInfo Element_NominalVolume;                                                                             // MakerGen.cs:211
            // 6. ProdCharacteristic.externalDiameter
            public ElementDefinitionInfo Element_ExternalDiameter;                                                                          // MakerGen.cs:211
            // 7. ProdCharacteristic.shape
            public ElementDefinitionInfo Element_Shape;                                                                                     // MakerGen.cs:211
            // 8. ProdCharacteristic.color
            public ElementDefinitionInfo Element_Color;                                                                                     // MakerGen.cs:211
            // 9. ProdCharacteristic.imprint
            public ElementDefinitionInfo Element_Imprint;                                                                                   // MakerGen.cs:211
            // 10. ProdCharacteristic.image
            public ElementDefinitionInfo Element_Image;                                                                                     // MakerGen.cs:211
            // 11. ProdCharacteristic.scoring
            public ElementDefinitionInfo Element_Scoring;                                                                                   // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
            public Type_ProdCharacteristic_Elements()                                                                                       // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:226
                    // 1. ProdCharacteristic.height
                    this.Element_Height = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Height",                                                                                            // MakerGen.cs:230
                        Path= "ProdCharacteristic.height",                                                                                  // MakerGen.cs:231
                        Id = "ProdCharacteristic.height",                                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. ProdCharacteristic.width
                    this.Element_Width = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Width",                                                                                             // MakerGen.cs:230
                        Path= "ProdCharacteristic.width",                                                                                   // MakerGen.cs:231
                        Id = "ProdCharacteristic.width",                                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 3. ProdCharacteristic.depth
                    this.Element_Depth = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Depth",                                                                                             // MakerGen.cs:230
                        Path= "ProdCharacteristic.depth",                                                                                   // MakerGen.cs:231
                        Id = "ProdCharacteristic.depth",                                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 4. ProdCharacteristic.weight
                    this.Element_Weight = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Weight",                                                                                            // MakerGen.cs:230
                        Path= "ProdCharacteristic.weight",                                                                                  // MakerGen.cs:231
                        Id = "ProdCharacteristic.weight",                                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. ProdCharacteristic.nominalVolume
                    this.Element_NominalVolume = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_NominalVolume",                                                                                     // MakerGen.cs:230
                        Path= "ProdCharacteristic.nominalVolume",                                                                           // MakerGen.cs:231
                        Id = "ProdCharacteristic.nominalVolume",                                                                            // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 6. ProdCharacteristic.externalDiameter
                    this.Element_ExternalDiameter = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_ExternalDiameter",                                                                                  // MakerGen.cs:230
                        Path= "ProdCharacteristic.externalDiameter",                                                                        // MakerGen.cs:231
                        Id = "ProdCharacteristic.externalDiameter",                                                                         // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 7. ProdCharacteristic.shape
                    this.Element_Shape = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Shape",                                                                                             // MakerGen.cs:230
                        Path= "ProdCharacteristic.shape",                                                                                   // MakerGen.cs:231
                        Id = "ProdCharacteristic.shape",                                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 8. ProdCharacteristic.color
                    this.Element_Color = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Color",                                                                                             // MakerGen.cs:230
                        Path= "ProdCharacteristic.color",                                                                                   // MakerGen.cs:231
                        Id = "ProdCharacteristic.color",                                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 9. ProdCharacteristic.imprint
                    this.Element_Imprint = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Imprint",                                                                                           // MakerGen.cs:230
                        Path= "ProdCharacteristic.imprint",                                                                                 // MakerGen.cs:231
                        Id = "ProdCharacteristic.imprint",                                                                                  // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 10. ProdCharacteristic.image
                    this.Element_Image = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Image",                                                                                             // MakerGen.cs:230
                        Path= "ProdCharacteristic.image",                                                                                   // MakerGen.cs:231
                        Id = "ProdCharacteristic.image",                                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Attachment                                                               // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 11. ProdCharacteristic.scoring
                    this.Element_Scoring = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Scoring",                                                                                           // MakerGen.cs:230
                        Path= "ProdCharacteristic.scoring",                                                                                 // MakerGen.cs:231
                        Id = "ProdCharacteristic.scoring",                                                                                  // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                Element_Height.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_Width.Write(sDef);                                                                                                  // MakerGen.cs:215
                Element_Depth.Write(sDef);                                                                                                  // MakerGen.cs:215
                Element_Weight.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_NominalVolume.Write(sDef);                                                                                          // MakerGen.cs:215
                Element_ExternalDiameter.Write(sDef);                                                                                       // MakerGen.cs:215
                Element_Shape.Write(sDef);                                                                                                  // MakerGen.cs:215
                Element_Color.Write(sDef);                                                                                                  // MakerGen.cs:215
                Element_Imprint.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_Image.Write(sDef);                                                                                                  // MakerGen.cs:215
                Element_Scoring.Write(sDef);                                                                                                // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:394
        }                                                                                                                                   // MakerGen.cs:396
        public Type_ProdCharacteristic_Elements Elements                                                                                    // MakerGen.cs:398
        {                                                                                                                                   // MakerGen.cs:399
            get                                                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                if (this.elements == null)                                                                                                  // MakerGen.cs:402
                    this.elements = new Type_ProdCharacteristic_Elements();                                                                 // MakerGen.cs:403
                return this.elements;                                                                                                       // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:406
        Type_ProdCharacteristic_Elements elements;                                                                                          // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
        public Type_ProdCharacteristic()                                                                                                    // MakerGen.cs:410
        {                                                                                                                                   // MakerGen.cs:411
        }                                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:416
        {                                                                                                                                   // MakerGen.cs:417
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:418
            {                                                                                                                               // MakerGen.cs:419
                Path = "ProdCharacteristic",                                                                                                // MakerGen.cs:420
                ElementId = "ProdCharacteristic"                                                                                            // MakerGen.cs:421
            });                                                                                                                             // MakerGen.cs:422
            if (this.elements != null)                                                                                                      // MakerGen.cs:423
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:424
        }                                                                                                                                   // MakerGen.cs:425
    }                                                                                                                                       // MakerGen.cs:426
}                                                                                                                                           // MakerGen.cs:525
