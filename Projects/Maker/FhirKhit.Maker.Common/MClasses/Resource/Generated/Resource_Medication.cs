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
      "id": "Medication",
      "url": "http://hl7.org/fhir/StructureDefinition/Medication",
      "version": "4.0.0",
      "name": "Medication",
      "status": "draft",
      "publisher": "Health Level Seven International (Pharmacy)",
      "description": "This resource is primarily used for the identification and definition of a medication for the purposes of prescribing, dispensing, and administering a medication as well as for making statements about medication use.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Medication",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Medication",
            "path": "Medication",
            "short": "Definition of a Medication",
            "definition": "This resource is primarily used for the identification and definition of a medication for the purposes of prescribing, dispensing, and administering a medication as well as for making statements about medication use.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Medication.identifier",
            "path": "Medication.identifier",
            "short": "Business identifier for this medication",
            "definition": "Business identifier for this medication.",
            "comment": "The serial number could be included as an identifier.",
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
            "id": "Medication.code",
            "path": "Medication.code",
            "short": "Codes that identify this medication",
            "definition": "A code (or set of codes) that specify this medication, or a textual description if no code is available. Usage note: This could be a standard medication code such as a code from RxNorm, SNOMED CT, IDMP etc. It could also be a national or local formulary code, optionally with translations to other code systems.",
            "comment": "Depending on the context of use, the code that was actually selected by the user (prescriber, dispenser, etc.) will have the coding.userSelected set to true.  As described in the coding datatype: \"A coding may be marked as a \"userSelected\" if a user selected the particular coded value in a user interface (e.g. the user selects an item in a pick-list). If a user selected coding exists, it is the preferred choice for performing translations etc. Other codes can only be literal translations to alternative code systems, or codes at a lower level of granularity (e.g. a generic code for a vendor-specific primary one).",
            "min": 0,
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
                  "valueString": "MedicationFormalRepresentation"
                }
              ],
              "strength": "example",
              "description": "A coded concept that defines the type of a medication.",
              "valueSet": "http://hl7.org/fhir/ValueSet/medication-codes"
            }
          },
          {
            "id": "Medication.status",
            "path": "Medication.status",
            "short": "active | inactive | entered-in-error",
            "definition": "A code to indicate if the medication is in active use.",
            "comment": "This status is intended to identify if the medication in a local system is in active use within a drug database or inventory.  For example, a pharmacy system may create a new drug file record for a compounded product \"ABC Hospital Special Cream\" with an active status.  At some point in the future, it may be determined that the drug record was created with an error and the status is changed to \"entered in error\".   This status is not intended to specify if a medication is part of a particular formulary.  It is possible that the drug record may be referenced by multiple formularies or catalogues and each of those entries would have a separate status.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element changes the interpretation of all descriptive attributes.",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "MedicationStatus"
                }
              ],
              "strength": "required",
              "description": "A coded concept defining if the medication is in active use.",
              "valueSet": "http://hl7.org/fhir/ValueSet/medication-status|4.0.0"
            }
          },
          {
            "id": "Medication.manufacturer",
            "path": "Medication.manufacturer",
            "short": "Manufacturer of the item",
            "definition": "Describes the details of the manufacturer of the medication product.  This is not intended to represent the distributor of a medication product.",
            "min": 0,
            "max": "1",
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
            "id": "Medication.form",
            "path": "Medication.form",
            "short": "powder | tablets | capsule +",
            "definition": "Describes the form of the item.  Powder; tablets; capsule.",
            "comment": "When Medication is referenced from MedicationRequest, this is the ordered form.  When Medication is referenced within MedicationDispense, this is the dispensed form.  When Medication is referenced within MedicationAdministration, this is administered form.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "MedicationForm"
                }
              ],
              "strength": "example",
              "description": "A coded concept defining the form of a medication.",
              "valueSet": "http://hl7.org/fhir/ValueSet/medication-form-codes"
            }
          },
          {
            "id": "Medication.amount",
            "path": "Medication.amount",
            "short": "Amount of drug in package",
            "definition": "Specific amount of the drug in the packaged product.  For example, when specifying a product that has the same strength (For example, Insulin glargine 100 unit per mL solution for injection), this attribute provides additional clarification of the package amount (For example, 3 mL, 10mL, etc.).",
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
            "id": "Medication.ingredient",
            "path": "Medication.ingredient",
            "short": "Active or inactive ingredient",
            "definition": "Identifies a particular constituent of interest in the product.",
            "comment": "The ingredients need not be a complete list.  If an ingredient is not specified, this does not indicate whether an ingredient is present or absent.  If an ingredient is specified it does not mean that all ingredients are specified.  It is possible to specify both inactive and active ingredients.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Medication.ingredient.item[x]",
            "path": "Medication.ingredient.item[x]",
            "short": "The actual ingredient or content",
            "definition": "The actual ingredient - either a substance (simple ingredient) or another medication of a medication.",
            "requirements": "The ingredient may reference a substance (for example, amoxicillin) or another medication (for example in the case of a compounded product, Glaxal Base).",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Substance",
                  "http://hl7.org/fhir/StructureDefinition/Medication"
                ]
              }
            ]
          },
          {
            "id": "Medication.ingredient.isActive",
            "path": "Medication.ingredient.isActive",
            "short": "Active ingredient indicator",
            "definition": "Indication of whether this ingredient affects the therapeutic action of the drug.",
            "requirements": "True indicates that the ingredient affects the therapeutic action of the drug (i.e. active). \rFalse indicates that the ingredient does not affect the therapeutic action of the drug (i.e. inactive).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "Medication.ingredient.strength",
            "path": "Medication.ingredient.strength",
            "short": "Quantity of ingredient present",
            "definition": "Specifies how many (or how much) of the items there are in this Medication.  For example, 250 mg per tablet.  This is expressed as a ratio where the numerator is 250mg and the denominator is 1 tablet.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Ratio"
              }
            ]
          },
          {
            "id": "Medication.batch",
            "path": "Medication.batch",
            "short": "Details about packaged medications",
            "definition": "Information that only applies to packages (not products).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Medication.batch.lotNumber",
            "path": "Medication.batch.lotNumber",
            "short": "Identifier assigned to batch",
            "definition": "The assigned lot number of a batch of the specified product.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Medication.batch.expirationDate",
            "path": "Medication.batch.expirationDate",
            "short": "When batch will expire",
            "definition": "When this specific batch of product will expire.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir resource 'Medication'
    /// </summary>
    // 0. Medication
    public class Resource_Medication : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 7. Medication.ingredient
        public class Type_Ingredient : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 8. Medication.ingredient.item[x]
            public ElementDefinitionInfo Element_Item;
            // 9. Medication.ingredient.isActive
            public ElementDefinitionInfo Element_IsActive;
            // 10. Medication.ingredient.strength
            public ElementDefinitionInfo Element_Strength;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Medication.ingredient",
                    ElementId = "Medication.ingredient"
                });
                Element_Item.Write(sDef);
                Element_IsActive.Write(sDef);
                Element_Strength.Write(sDef);
            }
            
            public Type_Ingredient()
            {
                {
                    // 8. Medication.ingredient.item[x]
                    this.Element_Item = new ElementDefinitionInfo
                    {
                        Name = "Element_Item",
                        Path= "Medication.ingredient.item[x]",
                        Id = "Medication.ingredient.item[x]",
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
                                    "http://hl7.org/fhir/StructureDefinition/Substance",
                                    "http://hl7.org/fhir/StructureDefinition/Medication"
                                }
                            }
                        }
                    };
                }
                {
                    // 9. Medication.ingredient.isActive
                    this.Element_IsActive = new ElementDefinitionInfo
                    {
                        Name = "Element_IsActive",
                        Path= "Medication.ingredient.isActive",
                        Id = "Medication.ingredient.isActive",
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
                    // 10. Medication.ingredient.strength
                    this.Element_Strength = new ElementDefinitionInfo
                    {
                        Name = "Element_Strength",
                        Path= "Medication.ingredient.strength",
                        Id = "Medication.ingredient.strength",
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
            }
        }
        // 11. Medication.batch
        public class Type_Batch : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 12. Medication.batch.lotNumber
            public ElementDefinitionInfo Element_LotNumber;
            // 13. Medication.batch.expirationDate
            public ElementDefinitionInfo Element_ExpirationDate;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Medication.batch",
                    ElementId = "Medication.batch"
                });
                Element_LotNumber.Write(sDef);
                Element_ExpirationDate.Write(sDef);
            }
            
            public Type_Batch()
            {
                {
                    // 12. Medication.batch.lotNumber
                    this.Element_LotNumber = new ElementDefinitionInfo
                    {
                        Name = "Element_LotNumber",
                        Path= "Medication.batch.lotNumber",
                        Id = "Medication.batch.lotNumber",
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
                    // 13. Medication.batch.expirationDate
                    this.Element_ExpirationDate = new ElementDefinitionInfo
                    {
                        Name = "Element_ExpirationDate",
                        Path= "Medication.batch.expirationDate",
                        Id = "Medication.batch.expirationDate",
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
            }
        }
        // 1. Medication.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. Medication.code
        public ElementDefinitionInfo Element_Code;
        // 3. Medication.status
        public ElementDefinitionInfo Element_Status;
        // 4. Medication.manufacturer
        public ElementDefinitionInfo Element_Manufacturer;
        // 5. Medication.form
        public ElementDefinitionInfo Element_Form;
        // 6. Medication.amount
        public ElementDefinitionInfo Element_Amount;
        // 7. Medication.ingredient
        public ElementDefinitionInfo Element_Ingredient;
        // 11. Medication.batch
        public ElementDefinitionInfo Element_Batch;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "Medication",
                ElementId = "Medication"
            });
            Element_Identifier.Write(sDef);
            Element_Code.Write(sDef);
            Element_Status.Write(sDef);
            Element_Manufacturer.Write(sDef);
            Element_Form.Write(sDef);
            Element_Amount.Write(sDef);
            Element_Ingredient.Write(sDef);
            Element_Batch.Write(sDef);
        }
        
        public Resource_Medication()
        {
            {
                // 1. Medication.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "Medication.identifier",
                    Id = "Medication.identifier",
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
                // 2. Medication.code
                this.Element_Code = new ElementDefinitionInfo
                {
                    Name = "Element_Code",
                    Path= "Medication.code",
                    Id = "Medication.code",
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
                // 3. Medication.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "Medication.status",
                    Id = "Medication.status",
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
                // 4. Medication.manufacturer
                this.Element_Manufacturer = new ElementDefinitionInfo
                {
                    Name = "Element_Manufacturer",
                    Path= "Medication.manufacturer",
                    Id = "Medication.manufacturer",
                    Min = 0,
                    Max = 1,
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
                // 5. Medication.form
                this.Element_Form = new ElementDefinitionInfo
                {
                    Name = "Element_Form",
                    Path= "Medication.form",
                    Id = "Medication.form",
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
                // 6. Medication.amount
                this.Element_Amount = new ElementDefinitionInfo
                {
                    Name = "Element_Amount",
                    Path= "Medication.amount",
                    Id = "Medication.amount",
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
                // 7. Medication.ingredient
                this.Element_Ingredient = new ElementDefinitionInfo
                {
                    Name = "Element_Ingredient",
                    Path= "Medication.ingredient",
                    Id = "Medication.ingredient",
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
            {
                // 11. Medication.batch
                this.Element_Batch = new ElementDefinitionInfo
                {
                    Name = "Element_Batch",
                    Path= "Medication.batch",
                    Id = "Medication.batch",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_Batch
                        {
                        }
                    }
                };
            }
            this.Name = "Medication";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Medication";
        }
    }
}
