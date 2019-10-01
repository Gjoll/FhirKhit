using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:381
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:382
{                                                                                                                                           // MakerGen.cs:383
    /// <summary>
    /// Fhir primitive 'SubstanceAmount'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "SubstanceAmount",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/SubstanceAmount",
    ///   "version": "4.0.0",
    ///   "name": "SubstanceAmount",
    ///   "status": "draft",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for SubstanceAmount Type: Chemical substances are a single substance type whose primary defining element is the molecular structure. Chemical substances shall be defined on the basis of their complete covalent molecular structure; the presence of a salt (counter-ion) and/or solvates (water, alcohols) is also captured. Purity, grade, physical form or particle size are not taken into account in the definition of a chemical substance or in the assignment of a Substance ID.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "SubstanceAmount",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/BackboneElement",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "SubstanceAmount",
    ///         "path": "SubstanceAmount",
    ///         "short": "Chemical substances are a single substance type whose primary defining element is the molecular structure. Chemical substances shall be defined on the basis of their complete covalent molecular structure; the presence of a salt (counter-ion) and/or solvates (water, alcohols) is also captured. Purity, grade, physical form or particle size are not taken into account in the definition of a chemical substance or in the assignment of a Substance ID",
    ///         "definition": "Chemical substances are a single substance type whose primary defining element is the molecular structure. Chemical substances shall be defined on the basis of their complete covalent molecular structure; the presence of a salt (counter-ion) and/or solvates (water, alcohols) is also captured. Purity, grade, physical form or particle size are not taken into account in the definition of a chemical substance or in the assignment of a Substance ID.",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "SubstanceAmount.amount[x]",
    ///         "path": "SubstanceAmount.amount[x]",
    ///         "short": "Used to capture quantitative values for a variety of elements. If only limits are given, the arithmetic mean would be the average. If only a single definite value for a given element is given, it would be captured in this field",
    ///         "definition": "Used to capture quantitative values for a variety of elements. If only limits are given, the arithmetic mean would be the average. If only a single definite value for a given element is given, it would be captured in this field.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Quantity"
    ///           },
    ///           {
    ///             "code": "Range"
    ///           },
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "SubstanceAmount.amountType",
    ///         "path": "SubstanceAmount.amountType",
    ///         "short": "Most elements that require a quantitative value will also have a field called amount type. Amount type should always be specified because the actual value of the amount is often dependent on it. EXAMPLE: In capturing the actual relative amounts of substances or molecular fragments it is essential to indicate whether the amount refers to a mole ratio or weight ratio. For any given element an effort should be made to use same the amount type for all related definitional elements",
    ///         "definition": "Most elements that require a quantitative value will also have a field called amount type. Amount type should always be specified because the actual value of the amount is often dependent on it. EXAMPLE: In capturing the actual relative amounts of substances or molecular fragments it is essential to indicate whether the amount refers to a mole ratio or weight ratio. For any given element an effort should be made to use same the amount type for all related definitional elements.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "CodeableConcept"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "SubstanceAmount.amountText",
    ///         "path": "SubstanceAmount.amountText",
    ///         "short": "A textual comment on a numeric value",
    ///         "definition": "A textual comment on a numeric value.",
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
    ///         "id": "SubstanceAmount.referenceRange",
    ///         "path": "SubstanceAmount.referenceRange",
    ///         "short": "Reference range of possible or expected values",
    ///         "definition": "Reference range of possible or expected values.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Element"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "SubstanceAmount.referenceRange.lowLimit",
    ///         "path": "SubstanceAmount.referenceRange.lowLimit",
    ///         "short": "Lower limit possible or expected",
    ///         "definition": "Lower limit possible or expected.",
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
    ///         "id": "SubstanceAmount.referenceRange.highLimit",
    ///         "path": "SubstanceAmount.referenceRange.highLimit",
    ///         "short": "Upper limit possible or expected",
    ///         "definition": "Upper limit possible or expected.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Quantity"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    // 0. SubstanceAmount
    public class SubstanceAmount_Type : MakerComplex_Type                                                                                   // MakerGen.cs:337
    {                                                                                                                                       // MakerGen.cs:338
        // 4. SubstanceAmount.referenceRange
        public class ReferenceRange_Type : MakerComplex_Type                                                                                // MakerGen.cs:337
        {                                                                                                                                   // MakerGen.cs:338
            // 5. SubstanceAmount.referenceRange.lowLimit
            public MakerElementInstance LowLimit;                                                                                           // MakerGen.cs:217
            // 6. SubstanceAmount.referenceRange.highLimit
            public MakerElementInstance HighLimit;                                                                                          // MakerGen.cs:217
            public ReferenceRange_Type()                                                                                                    // MakerGen.cs:346
            {                                                                                                                               // MakerGen.cs:347
                {                                                                                                                           // MakerGen.cs:228
                    // 5. SubstanceAmount.referenceRange.lowLimit
                    this.LowLimit = new MakerElementInstance                                                                                // MakerGen.cs:230
                    {                                                                                                                       // MakerGen.cs:231
                        Name = "LowLimit",                                                                                                  // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:320
                {                                                                                                                           // MakerGen.cs:228
                    // 6. SubstanceAmount.referenceRange.highLimit
                    this.HighLimit = new MakerElementInstance                                                                               // MakerGen.cs:230
                    {                                                                                                                       // MakerGen.cs:231
                        Name = "HighLimit",                                                                                                 // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:320
            }                                                                                                                               // MakerGen.cs:358
        }                                                                                                                                   // MakerGen.cs:342
        // 1. SubstanceAmount.amount[x]
        public MakerElementInstance Amount;                                                                                                 // MakerGen.cs:217
        // 2. SubstanceAmount.amountType
        public MakerElementInstance AmountType;                                                                                             // MakerGen.cs:217
        // 3. SubstanceAmount.amountText
        public MakerElementInstance AmountText;                                                                                             // MakerGen.cs:217
        public SubstanceAmount_Type()                                                                                                       // MakerGen.cs:346
        {                                                                                                                                   // MakerGen.cs:347
            {                                                                                                                               // MakerGen.cs:228
                // 1. SubstanceAmount.amount[x]
                this.Amount = new MakerElementInstance                                                                                      // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Amount",                                                                                                        // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new String_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 2. SubstanceAmount.amountType
                this.AmountType = new MakerElementInstance                                                                                  // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "AmountType",                                                                                                    // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new CodeableConcept_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 3. SubstanceAmount.amountText
                this.AmountText = new MakerElementInstance                                                                                  // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "AmountText",                                                                                                    // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new String_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
        }                                                                                                                                   // MakerGen.cs:358
    }                                                                                                                                       // MakerGen.cs:342
}                                                                                                                                           // MakerGen.cs:389
