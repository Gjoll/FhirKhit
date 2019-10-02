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
      "id": "Money",
      "url": "http://hl7.org/fhir/StructureDefinition/Money",
      "version": "4.0.0",
      "name": "Money",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for Money Type: An amount of economic utility in some recognized currency.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "Money",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Money",
            "path": "Money",
            "short": "An amount of economic utility in some recognized currency",
            "definition": "An amount of economic utility in some recognized currency.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Money.value",
            "path": "Money.value",
            "short": "Numerical value (with implicit precision)",
            "definition": "Numerical value (with implicit precision).",
            "comment": "Monetary values have their own rules for handling precision (refer to standard accounting text books).",
            "requirements": "The amount of the currency. The value includes an implicit precision in the presentation of the value.",
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
            "id": "Money.currency",
            "path": "Money.currency",
            "short": "ISO 4217 Currency Code",
            "definition": "ISO 4217 Currency Code.",
            "requirements": "A code indicating the currency, taken from ISO 4217.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "CurrencyCode"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "required",
              "description": "A code indicating the currency, taken from ISO 4217.",
              "valueSet": "http://hl7.org/fhir/ValueSet/currencies|4.0.0"
            }
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir complex 'Money'
    /// </summary>
    // 0. Money
    public partial class Type_Money : FhirKhit.Maker.Common.Complex.ComplexBase
    {
        // 1. Money.value
        public ElementDefinitionInfo Element_Value;
        // 2. Money.currency
        public ElementDefinitionInfo Element_Currency;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "Money",
                ElementId = "Money"
            });
            Element_Value.Write(sDef);
            Element_Currency.Write(sDef);
        }
        
        public Type_Money()
        {
            {
                // 1. Money.value
                this.Element_Value = new ElementDefinitionInfo
                {
                    Name = "Element_Value",
                    Path= "Money.value",
                    Id = "Money.value",
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
                // 2. Money.currency
                this.Element_Currency = new ElementDefinitionInfo
                {
                    Name = "Element_Currency",
                    Path= "Money.currency",
                    Id = "Money.currency",
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
