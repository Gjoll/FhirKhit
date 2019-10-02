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
      "id": "Quantity",
      "url": "http://hl7.org/fhir/StructureDefinition/Quantity",
      "version": "4.0.0",
      "name": "Quantity",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for Quantity Type: A measured amount (or an amount that can potentially be measured). Note that measured amounts include amounts that are not precisely quantified, including amounts involving arbitrary units and floating currencies.",
      "purpose": "Need to able to capture all sorts of measured values, even if the measured value are not precisely quantified. Values include exact measures such as 3.51g, customary units such as 3 tablets, and currencies such as $100.32USD.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "Quantity",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Quantity",
            "path": "Quantity",
            "short": "A measured or measurable amount",
            "definition": "A measured amount (or an amount that can potentially be measured). Note that measured amounts include amounts that are not precisely quantified, including amounts involving arbitrary units and floating currencies.",
            "comment": "The context of use may frequently define what kind of quantity this is and therefore what kind of units can be used. The context of use may also restrict the values for the comparator.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Quantity.value",
            "path": "Quantity.value",
            "short": "Numerical value (with implicit precision)",
            "definition": "The value of the measured amount. The value includes an implicit precision in the presentation of the value.",
            "comment": "The implicit precision in the value should always be honored. Monetary values have their own rules for handling precision (refer to standard accounting text books).",
            "requirements": "Precision is handled implicitly in almost all cases of measurement.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Quantity.comparator",
            "path": "Quantity.comparator",
            "short": "< | <= | >= | > - how to understand the value",
            "definition": "How the value should be understood and represented - whether the actual value is greater or less than the stated value due to measurement issues; e.g. if the comparator is \"<\" , then the real value is < stated value.",
            "requirements": "Need a framework for handling measures where the value is <5ug/L or >400mg/L due to the limitations of measuring methodology.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "meaningWhenMissing": "If there is no comparator, then there is no modification of the value",
            "isModifier": true,
            "isModifierReason": "This is labeled as \"Is Modifier\" because the comparator modifies the interpretation of the value significantly. If there is no comparator, then there is no modification of the value",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "QuantityComparator"
                }
              ],
              "strength": "required",
              "description": "How the Quantity should be understood and represented.",
              "valueSet": "http://hl7.org/fhir/ValueSet/quantity-comparator|4.0.0"
            }
          },
          {
            "id": "Quantity.unit",
            "path": "Quantity.unit",
            "short": "Unit representation",
            "definition": "A human-readable form of the unit.",
            "requirements": "There are many representations for units of measure and in many contexts, particular representations are fixed and required. I.e. mcg for micrograms.",
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
            "id": "Quantity.system",
            "path": "Quantity.system",
            "short": "System that defines coded unit form",
            "definition": "The identification of the system that provides the coded form of the unit.",
            "requirements": "Need to know the system that defines the coded form of the unit.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ],
            "condition": [
              "qty-3"
            ],
            "isSummary": true
          },
          {
            "id": "Quantity.code",
            "path": "Quantity.code",
            "short": "Coded form of the unit",
            "definition": "A computer processable form of the unit in some unit representation system.",
            "comment": "The preferred system is UCUM, but SNOMED CT can also be used (for customary units) or ISO 4217 for currency.  The context of use may additionally require a code from a particular system.",
            "requirements": "Need a computable form of the unit that is fixed across all forms. UCUM provides this for quantities, but SNOMED CT provides many units of interest.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
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
    /// Fhir complex 'Quantity'
    /// </summary>
    // 0. Quantity
    public class Type_Quantity : FhirKhit.Maker.Common.Complex.ComplexBase
    {
        // 1. Quantity.value
        public ElementDefinitionInfo Element_Value;
        // 2. Quantity.comparator
        public ElementDefinitionInfo Element_Comparator;
        // 3. Quantity.unit
        public ElementDefinitionInfo Element_Unit;
        // 4. Quantity.system
        public ElementDefinitionInfo Element_System;
        // 5. Quantity.code
        public ElementDefinitionInfo Element_Code;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "Quantity",
                ElementId = "Quantity"
            });
            Element_Value.Write(sDef);
            Element_Comparator.Write(sDef);
            Element_Unit.Write(sDef);
            Element_System.Write(sDef);
            Element_Code.Write(sDef);
        }
        
        public Type_Quantity()
        {
            {
                // 1. Quantity.value
                this.Element_Value = new ElementDefinitionInfo
                {
                    Name = "Element_Value",
                    Path= "Quantity.value",
                    Id = "Quantity.value",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                        {
                        }
                    }
                };
            }
            {
                // 2. Quantity.comparator
                this.Element_Comparator = new ElementDefinitionInfo
                {
                    Name = "Element_Comparator",
                    Path= "Quantity.comparator",
                    Id = "Quantity.comparator",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code
                        {
                        }
                    }
                };
            }
            {
                // 3. Quantity.unit
                this.Element_Unit = new ElementDefinitionInfo
                {
                    Name = "Element_Unit",
                    Path= "Quantity.unit",
                    Id = "Quantity.unit",
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
                // 4. Quantity.system
                this.Element_System = new ElementDefinitionInfo
                {
                    Name = "Element_System",
                    Path= "Quantity.system",
                    Id = "Quantity.system",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uri
                        {
                        }
                    }
                };
            }
            {
                // 5. Quantity.code
                this.Element_Code = new ElementDefinitionInfo
                {
                    Name = "Element_Code",
                    Path= "Quantity.code",
                    Id = "Quantity.code",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code
                        {
                        }
                    }
                };
            }
        }
    }
}
