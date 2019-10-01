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
    #endregion                                                                                                                              // MakerGen.cs:494
    /// <summary>
    /// Fhir complex 'ProdCharacteristic'
    /// </summary>
    // 0. ProdCharacteristic
    public class Type_ProdCharacteristic : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 1. ProdCharacteristic.height
        public ElementDefinitionInfo Element_Height;                                                                                        // MakerGen.cs:212
        // 2. ProdCharacteristic.width
        public ElementDefinitionInfo Element_Width;                                                                                         // MakerGen.cs:212
        // 3. ProdCharacteristic.depth
        public ElementDefinitionInfo Element_Depth;                                                                                         // MakerGen.cs:212
        // 4. ProdCharacteristic.weight
        public ElementDefinitionInfo Element_Weight;                                                                                        // MakerGen.cs:212
        // 5. ProdCharacteristic.nominalVolume
        public ElementDefinitionInfo Element_NominalVolume;                                                                                 // MakerGen.cs:212
        // 6. ProdCharacteristic.externalDiameter
        public ElementDefinitionInfo Element_ExternalDiameter;                                                                              // MakerGen.cs:212
        // 7. ProdCharacteristic.shape
        public ElementDefinitionInfo Element_Shape;                                                                                         // MakerGen.cs:212
        // 8. ProdCharacteristic.color
        public ElementDefinitionInfo Element_Color;                                                                                         // MakerGen.cs:212
        // 9. ProdCharacteristic.imprint
        public ElementDefinitionInfo Element_Imprint;                                                                                       // MakerGen.cs:212
        // 10. ProdCharacteristic.image
        public ElementDefinitionInfo Element_Image;                                                                                         // MakerGen.cs:212
        // 11. ProdCharacteristic.scoring
        public ElementDefinitionInfo Element_Scoring;                                                                                       // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "ProdCharacteristic",                                                                                                // MakerGen.cs:388
                ElementId = "ProdCharacteristic"                                                                                            // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Height.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Width.Write(sDef);                                                                                                      // MakerGen.cs:216
            Element_Depth.Write(sDef);                                                                                                      // MakerGen.cs:216
            Element_Weight.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_NominalVolume.Write(sDef);                                                                                              // MakerGen.cs:216
            Element_ExternalDiameter.Write(sDef);                                                                                           // MakerGen.cs:216
            Element_Shape.Write(sDef);                                                                                                      // MakerGen.cs:216
            Element_Color.Write(sDef);                                                                                                      // MakerGen.cs:216
            Element_Imprint.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Image.Write(sDef);                                                                                                      // MakerGen.cs:216
            Element_Scoring.Write(sDef);                                                                                                    // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Type_ProdCharacteristic()                                                                                                    // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. ProdCharacteristic.height
                this.Element_Height = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Height",                                                                                                // MakerGen.cs:231
                    Path= "ProdCharacteristic.height",                                                                                      // MakerGen.cs:232
                    Id = "ProdCharacteristic.height",                                                                                       // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                     // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 2. ProdCharacteristic.width
                this.Element_Width = new ElementDefinitionInfo                                                                              // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Width",                                                                                                 // MakerGen.cs:231
                    Path= "ProdCharacteristic.width",                                                                                       // MakerGen.cs:232
                    Id = "ProdCharacteristic.width",                                                                                        // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                     // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 3. ProdCharacteristic.depth
                this.Element_Depth = new ElementDefinitionInfo                                                                              // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Depth",                                                                                                 // MakerGen.cs:231
                    Path= "ProdCharacteristic.depth",                                                                                       // MakerGen.cs:232
                    Id = "ProdCharacteristic.depth",                                                                                        // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                     // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 4. ProdCharacteristic.weight
                this.Element_Weight = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Weight",                                                                                                // MakerGen.cs:231
                    Path= "ProdCharacteristic.weight",                                                                                      // MakerGen.cs:232
                    Id = "ProdCharacteristic.weight",                                                                                       // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                     // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 5. ProdCharacteristic.nominalVolume
                this.Element_NominalVolume = new ElementDefinitionInfo                                                                      // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_NominalVolume",                                                                                         // MakerGen.cs:231
                    Path= "ProdCharacteristic.nominalVolume",                                                                               // MakerGen.cs:232
                    Id = "ProdCharacteristic.nominalVolume",                                                                                // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                     // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 6. ProdCharacteristic.externalDiameter
                this.Element_ExternalDiameter = new ElementDefinitionInfo                                                                   // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_ExternalDiameter",                                                                                      // MakerGen.cs:231
                    Path= "ProdCharacteristic.externalDiameter",                                                                            // MakerGen.cs:232
                    Id = "ProdCharacteristic.externalDiameter",                                                                             // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                     // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 7. ProdCharacteristic.shape
                this.Element_Shape = new ElementDefinitionInfo                                                                              // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Shape",                                                                                                 // MakerGen.cs:231
                    Path= "ProdCharacteristic.shape",                                                                                       // MakerGen.cs:232
                    Id = "ProdCharacteristic.shape",                                                                                        // MakerGen.cs:233
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
                // 8. ProdCharacteristic.color
                this.Element_Color = new ElementDefinitionInfo                                                                              // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Color",                                                                                                 // MakerGen.cs:231
                    Path= "ProdCharacteristic.color",                                                                                       // MakerGen.cs:232
                    Id = "ProdCharacteristic.color",                                                                                        // MakerGen.cs:233
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
                // 9. ProdCharacteristic.imprint
                this.Element_Imprint = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Imprint",                                                                                               // MakerGen.cs:231
                    Path= "ProdCharacteristic.imprint",                                                                                     // MakerGen.cs:232
                    Id = "ProdCharacteristic.imprint",                                                                                      // MakerGen.cs:233
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
                // 10. ProdCharacteristic.image
                this.Element_Image = new ElementDefinitionInfo                                                                              // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Image",                                                                                                 // MakerGen.cs:231
                    Path= "ProdCharacteristic.image",                                                                                       // MakerGen.cs:232
                    Id = "ProdCharacteristic.image",                                                                                        // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Attachment                                                                   // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 11. ProdCharacteristic.scoring
                this.Element_Scoring = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Scoring",                                                                                               // MakerGen.cs:231
                    Path= "ProdCharacteristic.scoring",                                                                                     // MakerGen.cs:232
                    Id = "ProdCharacteristic.scoring",                                                                                      // MakerGen.cs:233
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
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:499
