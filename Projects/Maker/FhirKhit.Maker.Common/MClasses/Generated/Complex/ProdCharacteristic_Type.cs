using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:381
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:382
{                                                                                                                                           // MakerGen.cs:383
    /// <summary>
    /// Fhir primitive 'ProdCharacteristic'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "ProdCharacteristic",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/ProdCharacteristic",
    ///   "version": "4.0.0",
    ///   "name": "ProdCharacteristic",
    ///   "status": "draft",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for ProdCharacteristic Type: The marketing status describes the date when a medicinal product is actually put on the market or the date as of which it is no longer available.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "ProdCharacteristic",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/BackboneElement",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "ProdCharacteristic",
    ///         "path": "ProdCharacteristic",
    ///         "short": "The marketing status describes the date when a medicinal product is actually put on the market or the date as of which it is no longer available",
    ///         "definition": "The marketing status describes the date when a medicinal product is actually put on the market or the date as of which it is no longer available.",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "ProdCharacteristic.height",
    ///         "path": "ProdCharacteristic.height",
    ///         "short": "Where applicable, the height can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used",
    ///         "definition": "Where applicable, the height can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Quantity"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "ProdCharacteristic.width",
    ///         "path": "ProdCharacteristic.width",
    ///         "short": "Where applicable, the width can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used",
    ///         "definition": "Where applicable, the width can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Quantity"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "ProdCharacteristic.depth",
    ///         "path": "ProdCharacteristic.depth",
    ///         "short": "Where applicable, the depth can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used",
    ///         "definition": "Where applicable, the depth can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Quantity"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "ProdCharacteristic.weight",
    ///         "path": "ProdCharacteristic.weight",
    ///         "short": "Where applicable, the weight can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used",
    ///         "definition": "Where applicable, the weight can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Quantity"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "ProdCharacteristic.nominalVolume",
    ///         "path": "ProdCharacteristic.nominalVolume",
    ///         "short": "Where applicable, the nominal volume can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used",
    ///         "definition": "Where applicable, the nominal volume can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Quantity"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "ProdCharacteristic.externalDiameter",
    ///         "path": "ProdCharacteristic.externalDiameter",
    ///         "short": "Where applicable, the external diameter can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used",
    ///         "definition": "Where applicable, the external diameter can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Quantity"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "ProdCharacteristic.shape",
    ///         "path": "ProdCharacteristic.shape",
    ///         "short": "Where applicable, the shape can be specified An appropriate controlled vocabulary shall be used The term and the term identifier shall be used",
    ///         "definition": "Where applicable, the shape can be specified An appropriate controlled vocabulary shall be used The term and the term identifier shall be used.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "ProdCharacteristic.color",
    ///         "path": "ProdCharacteristic.color",
    ///         "short": "Where applicable, the color can be specified An appropriate controlled vocabulary shall be used The term and the term identifier shall be used",
    ///         "definition": "Where applicable, the color can be specified An appropriate controlled vocabulary shall be used The term and the term identifier shall be used.",
    ///         "min": 0,
    ///         "max": "*",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "ProdCharacteristic.imprint",
    ///         "path": "ProdCharacteristic.imprint",
    ///         "short": "Where applicable, the imprint can be specified as text",
    ///         "definition": "Where applicable, the imprint can be specified as text.",
    ///         "min": 0,
    ///         "max": "*",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "ProdCharacteristic.image",
    ///         "path": "ProdCharacteristic.image",
    ///         "short": "Where applicable, the image can be provided The format of the image attachment shall be specified by regional implementations",
    ///         "definition": "Where applicable, the image can be provided The format of the image attachment shall be specified by regional implementations.",
    ///         "min": 0,
    ///         "max": "*",
    ///         "type": [
    ///           {
    ///             "code": "Attachment"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "ProdCharacteristic.scoring",
    ///         "path": "ProdCharacteristic.scoring",
    ///         "short": "Where applicable, the scoring can be specified An appropriate controlled vocabulary shall be used The term and the term identifier shall be used",
    ///         "definition": "Where applicable, the scoring can be specified An appropriate controlled vocabulary shall be used The term and the term identifier shall be used.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "CodeableConcept"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    // 0. ProdCharacteristic
    public class ProdCharacteristic_Type : MakerComplex_Type                                                                                // MakerGen.cs:337
    {                                                                                                                                       // MakerGen.cs:338
        // 1. ProdCharacteristic.height
        public MakerElementInstance Height;                                                                                                 // MakerGen.cs:217
        // 2. ProdCharacteristic.width
        public MakerElementInstance Width;                                                                                                  // MakerGen.cs:217
        // 3. ProdCharacteristic.depth
        public MakerElementInstance Depth;                                                                                                  // MakerGen.cs:217
        // 4. ProdCharacteristic.weight
        public MakerElementInstance Weight;                                                                                                 // MakerGen.cs:217
        // 5. ProdCharacteristic.nominalVolume
        public MakerElementInstance NominalVolume;                                                                                          // MakerGen.cs:217
        // 6. ProdCharacteristic.externalDiameter
        public MakerElementInstance ExternalDiameter;                                                                                       // MakerGen.cs:217
        // 7. ProdCharacteristic.shape
        public MakerElementInstance Shape;                                                                                                  // MakerGen.cs:217
        // 8. ProdCharacteristic.color
        public MakerElementInstance Color;                                                                                                  // MakerGen.cs:217
        // 9. ProdCharacteristic.imprint
        public MakerElementInstance Imprint;                                                                                                // MakerGen.cs:217
        // 10. ProdCharacteristic.image
        public MakerElementInstance Image;                                                                                                  // MakerGen.cs:217
        // 11. ProdCharacteristic.scoring
        public MakerElementInstance Scoring;                                                                                                // MakerGen.cs:217
        public ProdCharacteristic_Type()                                                                                                    // MakerGen.cs:346
        {                                                                                                                                   // MakerGen.cs:347
            {                                                                                                                               // MakerGen.cs:228
                // 1. ProdCharacteristic.height
                this.Height = new MakerElementInstance                                                                                      // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Height",                                                                                                        // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 2. ProdCharacteristic.width
                this.Width = new MakerElementInstance                                                                                       // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Width",                                                                                                         // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 3. ProdCharacteristic.depth
                this.Depth = new MakerElementInstance                                                                                       // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Depth",                                                                                                         // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 4. ProdCharacteristic.weight
                this.Weight = new MakerElementInstance                                                                                      // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Weight",                                                                                                        // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 5. ProdCharacteristic.nominalVolume
                this.NominalVolume = new MakerElementInstance                                                                               // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "NominalVolume",                                                                                                 // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 6. ProdCharacteristic.externalDiameter
                this.ExternalDiameter = new MakerElementInstance                                                                            // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "ExternalDiameter",                                                                                              // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 7. ProdCharacteristic.shape
                this.Shape = new MakerElementInstance                                                                                       // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Shape",                                                                                                         // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new String_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 8. ProdCharacteristic.color
                this.Color = new MakerElementInstance                                                                                       // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Color",                                                                                                         // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = -1,                                                                                                               // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new String_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 9. ProdCharacteristic.imprint
                this.Imprint = new MakerElementInstance                                                                                     // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Imprint",                                                                                                       // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = -1,                                                                                                               // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new String_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 10. ProdCharacteristic.image
                this.Image = new MakerElementInstance                                                                                       // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Image",                                                                                                         // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = -1,                                                                                                               // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 11. ProdCharacteristic.scoring
                this.Scoring = new MakerElementInstance                                                                                     // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Scoring",                                                                                                       // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new CodeableConcept_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
        }                                                                                                                                   // MakerGen.cs:358
    }                                                                                                                                       // MakerGen.cs:342
}                                                                                                                                           // MakerGen.cs:389
