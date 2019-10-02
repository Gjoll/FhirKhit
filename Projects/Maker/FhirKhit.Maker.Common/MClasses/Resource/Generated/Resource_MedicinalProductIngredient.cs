using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.Common.Resource
{
    #region Json
    #if NEVER
    {
      "resourceType": "StructureDefinition",
      "id": "MedicinalProductIngredient",
      "url": "http://hl7.org/fhir/StructureDefinition/MedicinalProductIngredient",
      "version": "4.0.0",
      "name": "MedicinalProductIngredient",
      "status": "draft",
      "publisher": "Health Level Seven International (Biomedical Research and Regulation)",
      "description": "An ingredient of a manufactured item or pharmaceutical product.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "MedicinalProductIngredient",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "MedicinalProductIngredient",
            "path": "MedicinalProductIngredient",
            "short": "An ingredient of a manufactured item or pharmaceutical product",
            "definition": "An ingredient of a manufactured item or pharmaceutical product.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "MedicinalProductIngredient.identifier",
            "path": "MedicinalProductIngredient.identifier",
            "short": "Identifier for the ingredient",
            "definition": "The identifier(s) of this Ingredient that are assigned by business processes and/or used to refer to it when a direct URL reference to the resource itself is not appropriate.",
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
            "id": "MedicinalProductIngredient.role",
            "path": "MedicinalProductIngredient.role",
            "short": "Ingredient role e.g. Active ingredient, excipient",
            "definition": "Ingredient role e.g. Active ingredient, excipient.",
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
            "id": "MedicinalProductIngredient.allergenicIndicator",
            "path": "MedicinalProductIngredient.allergenicIndicator",
            "short": "If the ingredient is a known or suspected allergen",
            "definition": "If the ingredient is a known or suspected allergen.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductIngredient.manufacturer",
            "path": "MedicinalProductIngredient.manufacturer",
            "short": "Manufacturer of this Ingredient",
            "definition": "Manufacturer of this Ingredient.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductIngredient.specifiedSubstance",
            "path": "MedicinalProductIngredient.specifiedSubstance",
            "short": "A specified substance that comprises this ingredient",
            "definition": "A specified substance that comprises this ingredient.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductIngredient.specifiedSubstance.code",
            "path": "MedicinalProductIngredient.specifiedSubstance.code",
            "short": "The specified substance",
            "definition": "The specified substance.",
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
            "id": "MedicinalProductIngredient.specifiedSubstance.group",
            "path": "MedicinalProductIngredient.specifiedSubstance.group",
            "short": "The group of specified substance, e.g. group 1 to 4",
            "definition": "The group of specified substance, e.g. group 1 to 4.",
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
            "id": "MedicinalProductIngredient.specifiedSubstance.confidentiality",
            "path": "MedicinalProductIngredient.specifiedSubstance.confidentiality",
            "short": "Confidentiality level of the specified substance as the ingredient",
            "definition": "Confidentiality level of the specified substance as the ingredient.",
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
            "id": "MedicinalProductIngredient.specifiedSubstance.strength",
            "path": "MedicinalProductIngredient.specifiedSubstance.strength",
            "short": "Quantity of the substance or specified substance present in the manufactured item or pharmaceutical product",
            "definition": "Quantity of the substance or specified substance present in the manufactured item or pharmaceutical product.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductIngredient.specifiedSubstance.strength.presentation",
            "path": "MedicinalProductIngredient.specifiedSubstance.strength.presentation",
            "short": "The quantity of substance in the unit of presentation, or in the volume (or mass) of the single pharmaceutical product or manufactured item",
            "definition": "The quantity of substance in the unit of presentation, or in the volume (or mass) of the single pharmaceutical product or manufactured item.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Ratio"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductIngredient.specifiedSubstance.strength.presentationLowLimit",
            "path": "MedicinalProductIngredient.specifiedSubstance.strength.presentationLowLimit",
            "short": "A lower limit for the quantity of substance in the unit of presentation. For use when there is a range of strengths, this is the lower limit, with the presentation attribute becoming the upper limit",
            "definition": "A lower limit for the quantity of substance in the unit of presentation. For use when there is a range of strengths, this is the lower limit, with the presentation attribute becoming the upper limit.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Ratio"
              }
            ],
            "isModifier": true,
            "isModifierReason": "If this is present it implies that the whole strength is expressed as a range, due to uncertainty or variation",
            "isSummary": true
          },
          {
            "id": "MedicinalProductIngredient.specifiedSubstance.strength.concentration",
            "path": "MedicinalProductIngredient.specifiedSubstance.strength.concentration",
            "short": "The strength per unitary volume (or mass)",
            "definition": "The strength per unitary volume (or mass).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Ratio"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductIngredient.specifiedSubstance.strength.concentrationLowLimit",
            "path": "MedicinalProductIngredient.specifiedSubstance.strength.concentrationLowLimit",
            "short": "A lower limit for the strength per unitary volume (or mass), for when there is a range. The concentration attribute then becomes the upper limit",
            "definition": "A lower limit for the strength per unitary volume (or mass), for when there is a range. The concentration attribute then becomes the upper limit.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Ratio"
              }
            ],
            "isModifier": true,
            "isModifierReason": "If this is present it implies that the whole strength is expressed as a range, due to uncertainty or variation",
            "isSummary": true
          },
          {
            "id": "MedicinalProductIngredient.specifiedSubstance.strength.measurementPoint",
            "path": "MedicinalProductIngredient.specifiedSubstance.strength.measurementPoint",
            "short": "For when strength is measured at a particular point or distance",
            "definition": "For when strength is measured at a particular point or distance.",
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
            "id": "MedicinalProductIngredient.specifiedSubstance.strength.country",
            "path": "MedicinalProductIngredient.specifiedSubstance.strength.country",
            "short": "The country or countries for which the strength range applies",
            "definition": "The country or countries for which the strength range applies.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength",
            "path": "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength",
            "short": "Strength expressed in terms of a reference substance",
            "definition": "Strength expressed in terms of a reference substance.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.substance",
            "path": "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.substance",
            "short": "Relevant reference substance",
            "definition": "Relevant reference substance.",
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
            "id": "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strength",
            "path": "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strength",
            "short": "Strength expressed in terms of a reference substance",
            "definition": "Strength expressed in terms of a reference substance.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Ratio"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strengthLowLimit",
            "path": "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strengthLowLimit",
            "short": "Strength expressed in terms of a reference substance",
            "definition": "Strength expressed in terms of a reference substance.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Ratio"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.measurementPoint",
            "path": "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.measurementPoint",
            "short": "For when strength is measured at a particular point or distance",
            "definition": "For when strength is measured at a particular point or distance.",
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
            "id": "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.country",
            "path": "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.country",
            "short": "The country or countries for which the strength range applies",
            "definition": "The country or countries for which the strength range applies.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductIngredient.substance",
            "path": "MedicinalProductIngredient.substance",
            "short": "The ingredient substance",
            "definition": "The ingredient substance.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductIngredient.substance.code",
            "path": "MedicinalProductIngredient.substance.code",
            "short": "The ingredient substance",
            "definition": "The ingredient substance.",
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
            "id": "MedicinalProductIngredient.substance.strength",
            "path": "MedicinalProductIngredient.substance.strength",
            "short": "Quantity of the substance or specified substance present in the manufactured item or pharmaceutical product",
            "definition": "Quantity of the substance or specified substance present in the manufactured item or pharmaceutical product.",
            "min": 0,
            "max": "*",
            "contentReference": "#MedicinalProductIngredient.specifiedSubstance.strength",
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir resource 'MedicinalProductIngredient'
    /// </summary>
    // 0. MedicinalProductIngredient
    public class Resource_MedicinalProductIngredient : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 5. MedicinalProductIngredient.specifiedSubstance
        public class Type_SpecifiedSubstance : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 9. MedicinalProductIngredient.specifiedSubstance.strength
            public class Type_Strength : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 16. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength
                public class Type_ReferenceStrength : FhirKhit.Maker.Common.Complex.ComplexBase
                {
                    // 17. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.substance
                    public ElementDefinitionInfo Element_Substance;
                    // 18. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strength
                    public ElementDefinitionInfo Element_Strength;
                    // 19. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strengthLowLimit
                    public ElementDefinitionInfo Element_StrengthLowLimit;
                    // 20. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.measurementPoint
                    public ElementDefinitionInfo Element_MeasurementPoint;
                    // 21. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.country
                    public ElementDefinitionInfo Element_Country;
                    
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                    {
                        base.Write(sDef);
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                        {
                            Path = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength",
                            ElementId = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength"
                        });
                        Element_Substance.Write(sDef);
                        Element_Strength.Write(sDef);
                        Element_StrengthLowLimit.Write(sDef);
                        Element_MeasurementPoint.Write(sDef);
                        Element_Country.Write(sDef);
                    }
                    
                    public Type_ReferenceStrength()
                    {
                        {
                            // 17. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.substance
                            this.Element_Substance = new ElementDefinitionInfo
                            {
                                Name = "Element_Substance",
                                Path= "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.substance",
                                Id = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.substance",
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
                            // 18. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strength
                            this.Element_Strength = new ElementDefinitionInfo
                            {
                                Name = "Element_Strength",
                                Path= "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strength",
                                Id = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strength",
                                Min = 1,
                                Max = 1,
                                Types = new BaseType[]
                                {
                                    new FhirKhit.Maker.Common.Complex.Type_Ratio
                                    {
                                    }
                                }
                            };
                        }
                        {
                            // 19. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strengthLowLimit
                            this.Element_StrengthLowLimit = new ElementDefinitionInfo
                            {
                                Name = "Element_StrengthLowLimit",
                                Path= "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strengthLowLimit",
                                Id = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strengthLowLimit",
                                Min = 0,
                                Max = 1,
                                Types = new BaseType[]
                                {
                                    new FhirKhit.Maker.Common.Complex.Type_Ratio
                                    {
                                    }
                                }
                            };
                        }
                        {
                            // 20. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.measurementPoint
                            this.Element_MeasurementPoint = new ElementDefinitionInfo
                            {
                                Name = "Element_MeasurementPoint",
                                Path= "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.measurementPoint",
                                Id = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.measurementPoint",
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
                            // 21. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.country
                            this.Element_Country = new ElementDefinitionInfo
                            {
                                Name = "Element_Country",
                                Path= "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.country",
                                Id = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.country",
                                Min = 0,
                                Max = -1,
                                Types = new BaseType[]
                                {
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                                    {
                                    }
                                }
                            };
                        }
                    }
                }
                // 10. MedicinalProductIngredient.specifiedSubstance.strength.presentation
                public ElementDefinitionInfo Element_Presentation;
                // 11. MedicinalProductIngredient.specifiedSubstance.strength.presentationLowLimit
                public ElementDefinitionInfo Element_PresentationLowLimit;
                // 12. MedicinalProductIngredient.specifiedSubstance.strength.concentration
                public ElementDefinitionInfo Element_Concentration;
                // 13. MedicinalProductIngredient.specifiedSubstance.strength.concentrationLowLimit
                public ElementDefinitionInfo Element_ConcentrationLowLimit;
                // 14. MedicinalProductIngredient.specifiedSubstance.strength.measurementPoint
                public ElementDefinitionInfo Element_MeasurementPoint;
                // 15. MedicinalProductIngredient.specifiedSubstance.strength.country
                public ElementDefinitionInfo Element_Country;
                // 16. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength
                public ElementDefinitionInfo Element_ReferenceStrength;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "MedicinalProductIngredient.specifiedSubstance.strength",
                        ElementId = "MedicinalProductIngredient.specifiedSubstance.strength"
                    });
                    Element_Presentation.Write(sDef);
                    Element_PresentationLowLimit.Write(sDef);
                    Element_Concentration.Write(sDef);
                    Element_ConcentrationLowLimit.Write(sDef);
                    Element_MeasurementPoint.Write(sDef);
                    Element_Country.Write(sDef);
                    Element_ReferenceStrength.Write(sDef);
                }
                
                public Type_Strength()
                {
                    {
                        // 10. MedicinalProductIngredient.specifiedSubstance.strength.presentation
                        this.Element_Presentation = new ElementDefinitionInfo
                        {
                            Name = "Element_Presentation",
                            Path= "MedicinalProductIngredient.specifiedSubstance.strength.presentation",
                            Id = "MedicinalProductIngredient.specifiedSubstance.strength.presentation",
                            Min = 1,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_Ratio
                                {
                                }
                            }
                        };
                    }
                    {
                        // 11. MedicinalProductIngredient.specifiedSubstance.strength.presentationLowLimit
                        this.Element_PresentationLowLimit = new ElementDefinitionInfo
                        {
                            Name = "Element_PresentationLowLimit",
                            Path= "MedicinalProductIngredient.specifiedSubstance.strength.presentationLowLimit",
                            Id = "MedicinalProductIngredient.specifiedSubstance.strength.presentationLowLimit",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_Ratio
                                {
                                }
                            }
                        };
                    }
                    {
                        // 12. MedicinalProductIngredient.specifiedSubstance.strength.concentration
                        this.Element_Concentration = new ElementDefinitionInfo
                        {
                            Name = "Element_Concentration",
                            Path= "MedicinalProductIngredient.specifiedSubstance.strength.concentration",
                            Id = "MedicinalProductIngredient.specifiedSubstance.strength.concentration",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_Ratio
                                {
                                }
                            }
                        };
                    }
                    {
                        // 13. MedicinalProductIngredient.specifiedSubstance.strength.concentrationLowLimit
                        this.Element_ConcentrationLowLimit = new ElementDefinitionInfo
                        {
                            Name = "Element_ConcentrationLowLimit",
                            Path= "MedicinalProductIngredient.specifiedSubstance.strength.concentrationLowLimit",
                            Id = "MedicinalProductIngredient.specifiedSubstance.strength.concentrationLowLimit",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_Ratio
                                {
                                }
                            }
                        };
                    }
                    {
                        // 14. MedicinalProductIngredient.specifiedSubstance.strength.measurementPoint
                        this.Element_MeasurementPoint = new ElementDefinitionInfo
                        {
                            Name = "Element_MeasurementPoint",
                            Path= "MedicinalProductIngredient.specifiedSubstance.strength.measurementPoint",
                            Id = "MedicinalProductIngredient.specifiedSubstance.strength.measurementPoint",
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
                        // 15. MedicinalProductIngredient.specifiedSubstance.strength.country
                        this.Element_Country = new ElementDefinitionInfo
                        {
                            Name = "Element_Country",
                            Path= "MedicinalProductIngredient.specifiedSubstance.strength.country",
                            Id = "MedicinalProductIngredient.specifiedSubstance.strength.country",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                                {
                                }
                            }
                        };
                    }
                    {
                        // 16. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength
                        this.Element_ReferenceStrength = new ElementDefinitionInfo
                        {
                            Name = "Element_ReferenceStrength",
                            Path= "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength",
                            Id = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new Type_ReferenceStrength
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 6. MedicinalProductIngredient.specifiedSubstance.code
            public ElementDefinitionInfo Element_Code;
            // 7. MedicinalProductIngredient.specifiedSubstance.group
            public ElementDefinitionInfo Element_Group;
            // 8. MedicinalProductIngredient.specifiedSubstance.confidentiality
            public ElementDefinitionInfo Element_Confidentiality;
            // 9. MedicinalProductIngredient.specifiedSubstance.strength
            public ElementDefinitionInfo Element_Strength;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "MedicinalProductIngredient.specifiedSubstance",
                    ElementId = "MedicinalProductIngredient.specifiedSubstance"
                });
                Element_Code.Write(sDef);
                Element_Group.Write(sDef);
                Element_Confidentiality.Write(sDef);
                Element_Strength.Write(sDef);
            }
            
            public Type_SpecifiedSubstance()
            {
                {
                    // 6. MedicinalProductIngredient.specifiedSubstance.code
                    this.Element_Code = new ElementDefinitionInfo
                    {
                        Name = "Element_Code",
                        Path= "MedicinalProductIngredient.specifiedSubstance.code",
                        Id = "MedicinalProductIngredient.specifiedSubstance.code",
                        Min = 1,
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
                    // 7. MedicinalProductIngredient.specifiedSubstance.group
                    this.Element_Group = new ElementDefinitionInfo
                    {
                        Name = "Element_Group",
                        Path= "MedicinalProductIngredient.specifiedSubstance.group",
                        Id = "MedicinalProductIngredient.specifiedSubstance.group",
                        Min = 1,
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
                    // 8. MedicinalProductIngredient.specifiedSubstance.confidentiality
                    this.Element_Confidentiality = new ElementDefinitionInfo
                    {
                        Name = "Element_Confidentiality",
                        Path= "MedicinalProductIngredient.specifiedSubstance.confidentiality",
                        Id = "MedicinalProductIngredient.specifiedSubstance.confidentiality",
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
                    // 9. MedicinalProductIngredient.specifiedSubstance.strength
                    this.Element_Strength = new ElementDefinitionInfo
                    {
                        Name = "Element_Strength",
                        Path= "MedicinalProductIngredient.specifiedSubstance.strength",
                        Id = "MedicinalProductIngredient.specifiedSubstance.strength",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Strength
                            {
                            }
                        }
                    };
                }
            }
        }
        // 22. MedicinalProductIngredient.substance
        public class Type_Substance : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 23. MedicinalProductIngredient.substance.code
            public ElementDefinitionInfo Element_Code;
            // 24. MedicinalProductIngredient.substance.strength
            public ElementDefinitionInfo Element_Strength;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "MedicinalProductIngredient.substance",
                    ElementId = "MedicinalProductIngredient.substance"
                });
                Element_Code.Write(sDef);
                Element_Strength.Write(sDef);
            }
            
            public Type_Substance()
            {
                {
                    // 23. MedicinalProductIngredient.substance.code
                    this.Element_Code = new ElementDefinitionInfo
                    {
                        Name = "Element_Code",
                        Path= "MedicinalProductIngredient.substance.code",
                        Id = "MedicinalProductIngredient.substance.code",
                        Min = 1,
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
                    // 24. MedicinalProductIngredient.substance.strength
                    this.Element_Strength = new ElementDefinitionInfo
                    {
                        Name = "Element_Strength",
                        Path= "MedicinalProductIngredient.substance.strength",
                        Id = "MedicinalProductIngredient.substance.strength",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                        }
                    };
                }
            }
        }
        // 1. MedicinalProductIngredient.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. MedicinalProductIngredient.role
        public ElementDefinitionInfo Element_Role;
        // 3. MedicinalProductIngredient.allergenicIndicator
        public ElementDefinitionInfo Element_AllergenicIndicator;
        // 4. MedicinalProductIngredient.manufacturer
        public ElementDefinitionInfo Element_Manufacturer;
        // 5. MedicinalProductIngredient.specifiedSubstance
        public ElementDefinitionInfo Element_SpecifiedSubstance;
        // 22. MedicinalProductIngredient.substance
        public ElementDefinitionInfo Element_Substance;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "MedicinalProductIngredient",
                ElementId = "MedicinalProductIngredient"
            });
            Element_Identifier.Write(sDef);
            Element_Role.Write(sDef);
            Element_AllergenicIndicator.Write(sDef);
            Element_Manufacturer.Write(sDef);
            Element_SpecifiedSubstance.Write(sDef);
            Element_Substance.Write(sDef);
        }
        
        public Resource_MedicinalProductIngredient()
        {
            {
                // 1. MedicinalProductIngredient.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "MedicinalProductIngredient.identifier",
                    Id = "MedicinalProductIngredient.identifier",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Identifier
                        {
                        }
                    }
                };
            }
            {
                // 2. MedicinalProductIngredient.role
                this.Element_Role = new ElementDefinitionInfo
                {
                    Name = "Element_Role",
                    Path= "MedicinalProductIngredient.role",
                    Id = "MedicinalProductIngredient.role",
                    Min = 1,
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
                // 3. MedicinalProductIngredient.allergenicIndicator
                this.Element_AllergenicIndicator = new ElementDefinitionInfo
                {
                    Name = "Element_AllergenicIndicator",
                    Path= "MedicinalProductIngredient.allergenicIndicator",
                    Id = "MedicinalProductIngredient.allergenicIndicator",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Boolean
                        {
                        }
                    }
                };
            }
            {
                // 4. MedicinalProductIngredient.manufacturer
                this.Element_Manufacturer = new ElementDefinitionInfo
                {
                    Name = "Element_Manufacturer",
                    Path= "MedicinalProductIngredient.manufacturer",
                    Id = "MedicinalProductIngredient.manufacturer",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Organization"
                            }
                        }
                    }
                };
            }
            {
                // 5. MedicinalProductIngredient.specifiedSubstance
                this.Element_SpecifiedSubstance = new ElementDefinitionInfo
                {
                    Name = "Element_SpecifiedSubstance",
                    Path= "MedicinalProductIngredient.specifiedSubstance",
                    Id = "MedicinalProductIngredient.specifiedSubstance",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_SpecifiedSubstance
                        {
                        }
                    }
                };
            }
            {
                // 22. MedicinalProductIngredient.substance
                this.Element_Substance = new ElementDefinitionInfo
                {
                    Name = "Element_Substance",
                    Path= "MedicinalProductIngredient.substance",
                    Id = "MedicinalProductIngredient.substance",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_Substance
                        {
                        }
                    }
                };
            }
            this.Name = "MedicinalProductIngredient";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MedicinalProductIngredient";
        }
    }
}
