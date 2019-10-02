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
      "id": "SubstanceAmount",
      "url": "http://hl7.org/fhir/StructureDefinition/SubstanceAmount",
      "version": "4.0.0",
      "name": "SubstanceAmount",
      "status": "draft",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for SubstanceAmount Type: Chemical substances are a single substance type whose primary defining element is the molecular structure. Chemical substances shall be defined on the basis of their complete covalent molecular structure; the presence of a salt (counter-ion) and/or solvates (water, alcohols) is also captured. Purity, grade, physical form or particle size are not taken into account in the definition of a chemical substance or in the assignment of a Substance ID.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "SubstanceAmount",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/BackboneElement",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "SubstanceAmount",
            "path": "SubstanceAmount",
            "short": "Chemical substances are a single substance type whose primary defining element is the molecular structure. Chemical substances shall be defined on the basis of their complete covalent molecular structure; the presence of a salt (counter-ion) and/or solvates (water, alcohols) is also captured. Purity, grade, physical form or particle size are not taken into account in the definition of a chemical substance or in the assignment of a Substance ID",
            "definition": "Chemical substances are a single substance type whose primary defining element is the molecular structure. Chemical substances shall be defined on the basis of their complete covalent molecular structure; the presence of a salt (counter-ion) and/or solvates (water, alcohols) is also captured. Purity, grade, physical form or particle size are not taken into account in the definition of a chemical substance or in the assignment of a Substance ID.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "SubstanceAmount.amount[x]",
            "path": "SubstanceAmount.amount[x]",
            "short": "Used to capture quantitative values for a variety of elements. If only limits are given, the arithmetic mean would be the average. If only a single definite value for a given element is given, it would be captured in this field",
            "definition": "Used to capture quantitative values for a variety of elements. If only limits are given, the arithmetic mean would be the average. If only a single definite value for a given element is given, it would be captured in this field.",
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
            "id": "SubstanceAmount.amountType",
            "path": "SubstanceAmount.amountType",
            "short": "Most elements that require a quantitative value will also have a field called amount type. Amount type should always be specified because the actual value of the amount is often dependent on it. EXAMPLE: In capturing the actual relative amounts of substances or molecular fragments it is essential to indicate whether the amount refers to a mole ratio or weight ratio. For any given element an effort should be made to use same the amount type for all related definitional elements",
            "definition": "Most elements that require a quantitative value will also have a field called amount type. Amount type should always be specified because the actual value of the amount is often dependent on it. EXAMPLE: In capturing the actual relative amounts of substances or molecular fragments it is essential to indicate whether the amount refers to a mole ratio or weight ratio. For any given element an effort should be made to use same the amount type for all related definitional elements.",
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
            "id": "SubstanceAmount.amountText",
            "path": "SubstanceAmount.amountText",
            "short": "A textual comment on a numeric value",
            "definition": "A textual comment on a numeric value.",
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
            "id": "SubstanceAmount.referenceRange",
            "path": "SubstanceAmount.referenceRange",
            "short": "Reference range of possible or expected values",
            "definition": "Reference range of possible or expected values.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Element"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceAmount.referenceRange.lowLimit",
            "path": "SubstanceAmount.referenceRange.lowLimit",
            "short": "Lower limit possible or expected",
            "definition": "Lower limit possible or expected.",
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
            "id": "SubstanceAmount.referenceRange.highLimit",
            "path": "SubstanceAmount.referenceRange.highLimit",
            "short": "Upper limit possible or expected",
            "definition": "Upper limit possible or expected.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity"
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
    /// Fhir complex 'SubstanceAmount'
    /// </summary>
    // 0. SubstanceAmount
    public class Type_SubstanceAmount : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        // 4. SubstanceAmount.referenceRange
        public class Type_ReferenceRange : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 5. SubstanceAmount.referenceRange.lowLimit
            public ElementDefinitionInfo Element_LowLimit;                                                                                  // MakerGen.cs:219
            // 6. SubstanceAmount.referenceRange.highLimit
            public ElementDefinitionInfo Element_HighLimit;                                                                                 // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "SubstanceAmount.referenceRange",                                                                                // MakerGen.cs:395
                    ElementId = "SubstanceAmount.referenceRange"                                                                            // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_LowLimit.Write(sDef);                                                                                               // MakerGen.cs:223
                Element_HighLimit.Write(sDef);                                                                                              // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_ReferenceRange()                                                                                                    // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 5. SubstanceAmount.referenceRange.lowLimit
                    this.Element_LowLimit = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_LowLimit",                                                                                          // MakerGen.cs:238
                        Path= "SubstanceAmount.referenceRange.lowLimit",                                                                    // MakerGen.cs:239
                        Id = "SubstanceAmount.referenceRange.lowLimit",                                                                     // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 6. SubstanceAmount.referenceRange.highLimit
                    this.Element_HighLimit = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_HighLimit",                                                                                         // MakerGen.cs:238
                        Path= "SubstanceAmount.referenceRange.highLimit",                                                                   // MakerGen.cs:239
                        Id = "SubstanceAmount.referenceRange.highLimit",                                                                    // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 1. SubstanceAmount.amount[x]
        public ElementDefinitionInfo Element_Amount;                                                                                        // MakerGen.cs:219
        // 2. SubstanceAmount.amountType
        public ElementDefinitionInfo Element_AmountType;                                                                                    // MakerGen.cs:219
        // 3. SubstanceAmount.amountText
        public ElementDefinitionInfo Element_AmountText;                                                                                    // MakerGen.cs:219
        // 4. SubstanceAmount.referenceRange
        public ElementDefinitionInfo Element_ReferenceRange;                                                                                // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:390
        {                                                                                                                                   // MakerGen.cs:391
            base.Write(sDef);                                                                                                               // MakerGen.cs:392
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                Path = "SubstanceAmount",                                                                                                   // MakerGen.cs:395
                ElementId = "SubstanceAmount"                                                                                               // MakerGen.cs:396
            });                                                                                                                             // MakerGen.cs:397
            Element_Amount.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_AmountType.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_AmountText.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_ReferenceRange.Write(sDef);                                                                                             // MakerGen.cs:223
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
        public Type_SubstanceAmount()                                                                                                       // MakerGen.cs:402
        {                                                                                                                                   // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:234
                // 1. SubstanceAmount.amount[x]
                this.Element_Amount = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Amount",                                                                                                // MakerGen.cs:238
                    Path= "SubstanceAmount.amount[x]",                                                                                      // MakerGen.cs:239
                    Id = "SubstanceAmount.amount[x]",                                                                                       // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                     // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        },                                                                                                                  // MakerGen.cs:360
                        new FhirKhit.Maker.Common.Complex.Type_Range                                                                        // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        },                                                                                                                  // MakerGen.cs:360
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 2. SubstanceAmount.amountType
                this.Element_AmountType = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_AmountType",                                                                                            // MakerGen.cs:238
                    Path= "SubstanceAmount.amountType",                                                                                     // MakerGen.cs:239
                    Id = "SubstanceAmount.amountType",                                                                                      // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
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
                // 3. SubstanceAmount.amountText
                this.Element_AmountText = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_AmountText",                                                                                            // MakerGen.cs:238
                    Path= "SubstanceAmount.amountText",                                                                                     // MakerGen.cs:239
                    Id = "SubstanceAmount.amountText",                                                                                      // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 4. SubstanceAmount.referenceRange
                this.Element_ReferenceRange = new ElementDefinitionInfo                                                                     // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_ReferenceRange",                                                                                        // MakerGen.cs:238
                    Path= "SubstanceAmount.referenceRange",                                                                                 // MakerGen.cs:239
                    Id = "SubstanceAmount.referenceRange",                                                                                  // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_ReferenceRange                                                                                             // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:407
}                                                                                                                                           // MakerGen.cs:515
