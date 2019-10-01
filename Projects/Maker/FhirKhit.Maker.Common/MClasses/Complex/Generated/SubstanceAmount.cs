using System;                                                                                                                               // MakerGen.cs:471
using System.Diagnostics;                                                                                                                   // MakerGen.cs:472
using System.IO;                                                                                                                            // MakerGen.cs:473
using System.Linq;                                                                                                                          // MakerGen.cs:474
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:475
                                                                                                                                            // MakerGen.cs:476
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:477
{                                                                                                                                           // MakerGen.cs:478
    #region Json                                                                                                                            // MakerGen.cs:479
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
    #endregion                                                                                                                              // MakerGen.cs:483
    /// <summary>
    /// Fhir complex 'SubstanceAmount'
    /// </summary>
    // 0. SubstanceAmount
    public class SubstanceAmount : FhirKhit.Maker.Common.Complex.ComplexBase                                                                // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        // 4. SubstanceAmount.referenceRange
        public class Type_ReferenceRange : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:384
        {                                                                                                                                   // MakerGen.cs:385
            // 5. SubstanceAmount.referenceRange.lowLimit
            public MakerElementInstance Element_LowLimit;                                                                                   // MakerGen.cs:232
            // 6. SubstanceAmount.referenceRange.highLimit
            public MakerElementInstance Element_HighLimit;                                                                                  // MakerGen.cs:232
            public Type_ReferenceRange()                                                                                                    // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:243
                    // 5. SubstanceAmount.referenceRange.lowLimit
                    this.Element_LowLimit = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_LowLimit",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.Quantity                                                                      // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:243
                    // 6. SubstanceAmount.referenceRange.highLimit
                    this.Element_HighLimit = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_HighLimit",                                                                                         // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.Quantity                                                                      // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:389
        // 1. SubstanceAmount.amount[x]
        public MakerElementInstance Element_Amount;                                                                                         // MakerGen.cs:232
        // 2. SubstanceAmount.amountType
        public MakerElementInstance Element_AmountType;                                                                                     // MakerGen.cs:232
        // 3. SubstanceAmount.amountText
        public MakerElementInstance Element_AmountText;                                                                                     // MakerGen.cs:232
        public SubstanceAmount()                                                                                                            // MakerGen.cs:393
        {                                                                                                                                   // MakerGen.cs:394
            {                                                                                                                               // MakerGen.cs:243
                // 1. SubstanceAmount.amount[x]
                this.Element_Amount = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Amount",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Quantity                                                                          // MakerGen.cs:343
                        {                                                                                                                   // MakerGen.cs:344
                        },                                                                                                                  // MakerGen.cs:345
                        new FhirKhit.Maker.Common.Complex.Range                                                                             // MakerGen.cs:343
                        {                                                                                                                   // MakerGen.cs:344
                        },                                                                                                                  // MakerGen.cs:345
                        new FhirKhit.Maker.Common.Primitive.String                                                                          // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 2. SubstanceAmount.amountType
                this.Element_AmountType = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_AmountType",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 3. SubstanceAmount.amountText
                this.Element_AmountText = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_AmountText",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String                                                                          // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:389
}                                                                                                                                           // MakerGen.cs:488
