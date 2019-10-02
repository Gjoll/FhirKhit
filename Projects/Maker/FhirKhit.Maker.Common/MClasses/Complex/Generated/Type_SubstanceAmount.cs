using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.Common.Complex
{
    #region Json
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
    #endregion
    /// <summary>
    /// Fhir complex 'SubstanceAmount'
    /// </summary>
    // 0. SubstanceAmount
    public class Type_SubstanceAmount : FhirKhit.Maker.Common.Complex.ComplexBase
    {
        // 4. SubstanceAmount.referenceRange
        public class Type_ReferenceRange : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 5. SubstanceAmount.referenceRange.lowLimit
            public ElementDefinitionInfo Element_LowLimit;
            // 6. SubstanceAmount.referenceRange.highLimit
            public ElementDefinitionInfo Element_HighLimit;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "SubstanceAmount.referenceRange",
                    ElementId = "SubstanceAmount.referenceRange"
                });
                Element_LowLimit.Write(sDef);
                Element_HighLimit.Write(sDef);
            }
            
            public Type_ReferenceRange()
            {
                {
                    // 5. SubstanceAmount.referenceRange.lowLimit
                    this.Element_LowLimit = new ElementDefinitionInfo
                    {
                        Name = "Element_LowLimit",
                        Path= "SubstanceAmount.referenceRange.lowLimit",
                        Id = "SubstanceAmount.referenceRange.lowLimit",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Quantity
                            {
                            }
                        }
                    };
                }
                {
                    // 6. SubstanceAmount.referenceRange.highLimit
                    this.Element_HighLimit = new ElementDefinitionInfo
                    {
                        Name = "Element_HighLimit",
                        Path= "SubstanceAmount.referenceRange.highLimit",
                        Id = "SubstanceAmount.referenceRange.highLimit",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Quantity
                            {
                            }
                        }
                    };
                }
            }
        }
        // 1. SubstanceAmount.amount[x]
        public ElementDefinitionInfo Element_Amount;
        // 2. SubstanceAmount.amountType
        public ElementDefinitionInfo Element_AmountType;
        // 3. SubstanceAmount.amountText
        public ElementDefinitionInfo Element_AmountText;
        // 4. SubstanceAmount.referenceRange
        public ElementDefinitionInfo Element_ReferenceRange;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "SubstanceAmount",
                ElementId = "SubstanceAmount"
            });
            Element_Amount.Write(sDef);
            Element_AmountType.Write(sDef);
            Element_AmountText.Write(sDef);
            Element_ReferenceRange.Write(sDef);
        }
        
        public Type_SubstanceAmount()
        {
            {
                // 1. SubstanceAmount.amount[x]
                this.Element_Amount = new ElementDefinitionInfo
                {
                    Name = "Element_Amount",
                    Path= "SubstanceAmount.amount[x]",
                    Id = "SubstanceAmount.amount[x]",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Quantity
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Range
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_String
                        {
                        }
                    }
                };
            }
            {
                // 2. SubstanceAmount.amountType
                this.Element_AmountType = new ElementDefinitionInfo
                {
                    Name = "Element_AmountType",
                    Path= "SubstanceAmount.amountType",
                    Id = "SubstanceAmount.amountType",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                        {
                        }
                    }
                };
            }
            {
                // 3. SubstanceAmount.amountText
                this.Element_AmountText = new ElementDefinitionInfo
                {
                    Name = "Element_AmountText",
                    Path= "SubstanceAmount.amountText",
                    Id = "SubstanceAmount.amountText",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_String
                        {
                        }
                    }
                };
            }
            {
                // 4. SubstanceAmount.referenceRange
                this.Element_ReferenceRange = new ElementDefinitionInfo
                {
                    Name = "Element_ReferenceRange",
                    Path= "SubstanceAmount.referenceRange",
                    Id = "SubstanceAmount.referenceRange",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_ReferenceRange
                        {
                        }
                    }
                };
            }
        }
    }
}
