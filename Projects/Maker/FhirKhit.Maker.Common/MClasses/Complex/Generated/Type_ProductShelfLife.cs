using System;                                                                                                                               // MakerGen.cs:498
using System.Diagnostics;                                                                                                                   // MakerGen.cs:499
using System.IO;                                                                                                                            // MakerGen.cs:500
using System.Linq;                                                                                                                          // MakerGen.cs:501
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:502
                                                                                                                                            // MakerGen.cs:503
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:504
{                                                                                                                                           // MakerGen.cs:505
    #region Json                                                                                                                            // MakerGen.cs:506
    #if NEVER
    {
      "resourceType": "StructureDefinition",
      "id": "ProductShelfLife",
      "url": "http://hl7.org/fhir/StructureDefinition/ProductShelfLife",
      "version": "4.0.0",
      "name": "ProductShelfLife",
      "status": "draft",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for ProductShelfLife Type: The shelf-life and storage information for a medicinal product item or container can be described using this class.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "ProductShelfLife",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/BackboneElement",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "ProductShelfLife",
            "path": "ProductShelfLife",
            "short": "The shelf-life and storage information for a medicinal product item or container can be described using this class",
            "definition": "The shelf-life and storage information for a medicinal product item or container can be described using this class.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "ProductShelfLife.identifier",
            "path": "ProductShelfLife.identifier",
            "short": "Unique identifier for the packaged Medicinal Product",
            "definition": "Unique identifier for the packaged Medicinal Product.",
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
            "id": "ProductShelfLife.type",
            "path": "ProductShelfLife.type",
            "short": "This describes the shelf life, taking into account various scenarios such as shelf life of the packaged Medicinal Product itself, shelf life after transformation where necessary and shelf life after the first opening of a bottle, etc. The shelf life type shall be specified using an appropriate controlled vocabulary The controlled term and the controlled term identifier shall be specified",
            "definition": "This describes the shelf life, taking into account various scenarios such as shelf life of the packaged Medicinal Product itself, shelf life after transformation where necessary and shelf life after the first opening of a bottle, etc. The shelf life type shall be specified using an appropriate controlled vocabulary The controlled term and the controlled term identifier shall be specified.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ProductShelfLife.period",
            "path": "ProductShelfLife.period",
            "short": "The shelf life time period can be specified using a numerical value for the period of time and its unit of time measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used",
            "definition": "The shelf life time period can be specified using a numerical value for the period of time and its unit of time measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Quantity"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ProductShelfLife.specialPrecautionsForStorage",
            "path": "ProductShelfLife.specialPrecautionsForStorage",
            "short": "Special precautions for storage, if any, can be specified using an appropriate controlled vocabulary The controlled term and the controlled term identifier shall be specified",
            "definition": "Special precautions for storage, if any, can be specified using an appropriate controlled vocabulary The controlled term and the controlled term identifier shall be specified.",
            "min": 0,
            "max": "*",
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
    #endregion                                                                                                                              // MakerGen.cs:510
    /// <summary>
    /// Fhir complex 'ProductShelfLife'
    /// </summary>
    // 0. ProductShelfLife
    public class Type_ProductShelfLife : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        // 1. ProductShelfLife.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:219
        // 2. ProductShelfLife.type
        public ElementDefinitionInfo Element_Type;                                                                                          // MakerGen.cs:219
        // 3. ProductShelfLife.period
        public ElementDefinitionInfo Element_Period;                                                                                        // MakerGen.cs:219
        // 4. ProductShelfLife.specialPrecautionsForStorage
        public ElementDefinitionInfo Element_SpecialPrecautionsForStorage;                                                                  // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:390
        {                                                                                                                                   // MakerGen.cs:391
            base.Write(sDef);                                                                                                               // MakerGen.cs:392
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                Path = "ProductShelfLife",                                                                                                  // MakerGen.cs:395
                ElementId = "ProductShelfLife"                                                                                              // MakerGen.cs:396
            });                                                                                                                             // MakerGen.cs:397
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Type.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_Period.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_SpecialPrecautionsForStorage.Write(sDef);                                                                               // MakerGen.cs:223
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
        public Type_ProductShelfLife()                                                                                                      // MakerGen.cs:402
        {                                                                                                                                   // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:234
                // 1. ProductShelfLife.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:238
                    Path= "ProductShelfLife.identifier",                                                                                    // MakerGen.cs:239
                    Id = "ProductShelfLife.identifier",                                                                                     // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 2. ProductShelfLife.type
                this.Element_Type = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:238
                    Path= "ProductShelfLife.type",                                                                                          // MakerGen.cs:239
                    Id = "ProductShelfLife.type",                                                                                           // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 3. ProductShelfLife.period
                this.Element_Period = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Period",                                                                                                // MakerGen.cs:238
                    Path= "ProductShelfLife.period",                                                                                        // MakerGen.cs:239
                    Id = "ProductShelfLife.period",                                                                                         // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                     // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 4. ProductShelfLife.specialPrecautionsForStorage
                this.Element_SpecialPrecautionsForStorage = new ElementDefinitionInfo                                                       // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_SpecialPrecautionsForStorage",                                                                          // MakerGen.cs:238
                    Path= "ProductShelfLife.specialPrecautionsForStorage",                                                                  // MakerGen.cs:239
                    Id = "ProductShelfLife.specialPrecautionsForStorage",                                                                   // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:407
}                                                                                                                                           // MakerGen.cs:515
