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
      "id": "Substance",
      "url": "http://hl7.org/fhir/StructureDefinition/Substance",
      "version": "4.0.0",
      "name": "Substance",
      "status": "draft",
      "publisher": "Health Level Seven International (Orders and Observations)",
      "description": "A homogeneous material with a definite composition.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Substance",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Substance",
            "path": "Substance",
            "short": "A homogeneous material with a definite composition",
            "definition": "A homogeneous material with a definite composition.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Substance.identifier",
            "path": "Substance.identifier",
            "short": "Unique identifier",
            "definition": "Unique identifier for the substance.",
            "comment": "This identifier is associated with the kind of substance in contrast to the  Substance.instance.identifier which is associated with the package/container.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Substance.status",
            "path": "Substance.status",
            "short": "active | inactive | entered-in-error",
            "definition": "A code to indicate if the substance is actively used.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element is labelled as a modifier because it is a status element that contains status entered-in-error which means that the resource should not be treated as valid",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "FHIRSubstanceStatus"
                }
              ],
              "strength": "required",
              "description": "A code to indicate if the substance is actively used.",
              "valueSet": "http://hl7.org/fhir/ValueSet/substance-status|4.0.0"
            }
          },
          {
            "id": "Substance.category",
            "path": "Substance.category",
            "short": "What class/type of substance this is",
            "definition": "A code that classifies the general type of substance.  This is used  for searching, sorting and display purposes.",
            "comment": "The level of granularity is defined by the category concepts in the value set.   More fine-grained filtering can be performed using the metadata and/or terminology hierarchy in Substance.code.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "SubstanceCategory"
                }
              ],
              "strength": "extensible",
              "description": "Category or classification of substance.",
              "valueSet": "http://hl7.org/fhir/ValueSet/substance-category"
            }
          },
          {
            "id": "Substance.code",
            "path": "Substance.code",
            "short": "What substance this is",
            "definition": "A code (or set of codes) that identify this substance.",
            "comment": "This could be a reference to an externally defined code.  It could also be a locally assigned code (e.g. a formulary),  optionally with translations to the standard drug codes.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "SubstanceCode"
                }
              ],
              "strength": "example",
              "description": "Substance codes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/substance-code"
            }
          },
          {
            "id": "Substance.description",
            "path": "Substance.description",
            "short": "Textual description of the substance, comments",
            "definition": "A description of the substance - its appearance, handling requirements, and other usage notes.",
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
            "id": "Substance.instance",
            "path": "Substance.instance",
            "short": "If this describes a specific package/container of the substance",
            "definition": "Substance may be used to describe a kind of substance, or a specific package/container of the substance: an instance.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "meaningWhenMissing": "If this element is not present, then the substance resource describes a kind of substance",
            "isSummary": true
          },
          {
            "id": "Substance.instance.identifier",
            "path": "Substance.instance.identifier",
            "short": "Identifier of the package/container",
            "definition": "Identifier associated with the package/container (usually a label affixed directly).",
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
            "id": "Substance.instance.expiry",
            "path": "Substance.instance.expiry",
            "short": "When no longer valid to use",
            "definition": "When the substance is no longer valid to use. For some substances, a single arbitrary date is used for expiry.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Substance.instance.quantity",
            "path": "Substance.instance.quantity",
            "short": "Amount of substance in the package",
            "definition": "The amount of the substance.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity",
                "profile": [
                  "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Substance.ingredient",
            "path": "Substance.ingredient",
            "short": "Composition information about the substance",
            "definition": "A substance can be composed of other substances.",
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
            "id": "Substance.ingredient.quantity",
            "path": "Substance.ingredient.quantity",
            "short": "Optional amount (concentration)",
            "definition": "The amount of the ingredient in the substance - a concentration ratio.",
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
            "id": "Substance.ingredient.substance[x]",
            "path": "Substance.ingredient.substance[x]",
            "short": "A component of the substance",
            "definition": "Another substance that is a component of this substance.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Substance"
                ]
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "SubstanceIngredient"
                }
              ],
              "strength": "example",
              "description": "Substance Ingredient codes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/substance-code"
            }
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir resource 'Substance'
    /// </summary>
    // 0. Substance
    public class Resource_Substance : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 6. Substance.instance
        public class Type_Instance : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 7. Substance.instance.identifier
            public ElementDefinitionInfo Element_Identifier;
            // 8. Substance.instance.expiry
            public ElementDefinitionInfo Element_Expiry;
            // 9. Substance.instance.quantity
            public ElementDefinitionInfo Element_Quantity;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Substance.instance",
                    ElementId = "Substance.instance"
                });
                Element_Identifier.Write(sDef);
                Element_Expiry.Write(sDef);
                Element_Quantity.Write(sDef);
            }
            
            public Type_Instance()
            {
                {
                    // 7. Substance.instance.identifier
                    this.Element_Identifier = new ElementDefinitionInfo
                    {
                        Name = "Element_Identifier",
                        Path= "Substance.instance.identifier",
                        Id = "Substance.instance.identifier",
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
                    // 8. Substance.instance.expiry
                    this.Element_Expiry = new ElementDefinitionInfo
                    {
                        Name = "Element_Expiry",
                        Path= "Substance.instance.expiry",
                        Id = "Substance.instance.expiry",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                            {
                            }
                        }
                    };
                }
                {
                    // 9. Substance.instance.quantity
                    this.Element_Quantity = new ElementDefinitionInfo
                    {
                        Name = "Element_Quantity",
                        Path= "Substance.instance.quantity",
                        Id = "Substance.instance.quantity",
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
        // 10. Substance.ingredient
        public class Type_Ingredient : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 11. Substance.ingredient.quantity
            public ElementDefinitionInfo Element_Quantity;
            // 12. Substance.ingredient.substance[x]
            public ElementDefinitionInfo Element_Substance;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Substance.ingredient",
                    ElementId = "Substance.ingredient"
                });
                Element_Quantity.Write(sDef);
                Element_Substance.Write(sDef);
            }
            
            public Type_Ingredient()
            {
                {
                    // 11. Substance.ingredient.quantity
                    this.Element_Quantity = new ElementDefinitionInfo
                    {
                        Name = "Element_Quantity",
                        Path= "Substance.ingredient.quantity",
                        Id = "Substance.ingredient.quantity",
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
                    // 12. Substance.ingredient.substance[x]
                    this.Element_Substance = new ElementDefinitionInfo
                    {
                        Name = "Element_Substance",
                        Path= "Substance.ingredient.substance[x]",
                        Id = "Substance.ingredient.substance[x]",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Substance"
                                }
                            }
                        }
                    };
                }
            }
        }
        // 1. Substance.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. Substance.status
        public ElementDefinitionInfo Element_Status;
        // 3. Substance.category
        public ElementDefinitionInfo Element_Category;
        // 4. Substance.code
        public ElementDefinitionInfo Element_Code;
        // 5. Substance.description
        public ElementDefinitionInfo Element_Description;
        // 6. Substance.instance
        public ElementDefinitionInfo Element_Instance;
        // 10. Substance.ingredient
        public ElementDefinitionInfo Element_Ingredient;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "Substance",
                ElementId = "Substance"
            });
            Element_Identifier.Write(sDef);
            Element_Status.Write(sDef);
            Element_Category.Write(sDef);
            Element_Code.Write(sDef);
            Element_Description.Write(sDef);
            Element_Instance.Write(sDef);
            Element_Ingredient.Write(sDef);
        }
        
        public Resource_Substance()
        {
            {
                // 1. Substance.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "Substance.identifier",
                    Id = "Substance.identifier",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Identifier
                        {
                        }
                    }
                };
            }
            {
                // 2. Substance.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "Substance.status",
                    Id = "Substance.status",
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
                // 3. Substance.category
                this.Element_Category = new ElementDefinitionInfo
                {
                    Name = "Element_Category",
                    Path= "Substance.category",
                    Id = "Substance.category",
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
                // 4. Substance.code
                this.Element_Code = new ElementDefinitionInfo
                {
                    Name = "Element_Code",
                    Path= "Substance.code",
                    Id = "Substance.code",
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
                // 5. Substance.description
                this.Element_Description = new ElementDefinitionInfo
                {
                    Name = "Element_Description",
                    Path= "Substance.description",
                    Id = "Substance.description",
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
                // 6. Substance.instance
                this.Element_Instance = new ElementDefinitionInfo
                {
                    Name = "Element_Instance",
                    Path= "Substance.instance",
                    Id = "Substance.instance",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Instance
                        {
                        }
                    }
                };
            }
            {
                // 10. Substance.ingredient
                this.Element_Ingredient = new ElementDefinitionInfo
                {
                    Name = "Element_Ingredient",
                    Path= "Substance.ingredient",
                    Id = "Substance.ingredient",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Ingredient
                        {
                        }
                    }
                };
            }
            this.Name = "Substance";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Substance";
        }
    }
}
