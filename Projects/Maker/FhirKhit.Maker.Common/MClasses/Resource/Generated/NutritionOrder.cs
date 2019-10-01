using System;                                                                                                                               // MakerGen.cs:413
using System.Diagnostics;                                                                                                                   // MakerGen.cs:414
using System.IO;                                                                                                                            // MakerGen.cs:415
using System.Linq;                                                                                                                          // MakerGen.cs:416
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:417
                                                                                                                                            // MakerGen.cs:418
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:419
{                                                                                                                                           // MakerGen.cs:420
    #region Json                                                                                                                            // MakerGen.cs:421
    #if NEVER                                                                                                                               // MakerGen.cs:422
    {
      "resourceType": "StructureDefinition",
      "id": "NutritionOrder",
      "url": "http://hl7.org/fhir/StructureDefinition/NutritionOrder",
      "version": "4.0.0",
      "name": "NutritionOrder",
      "status": "draft",
      "publisher": "Health Level Seven International (Orders and Observations)",
      "description": "A request to supply a diet, formula feeding (enteral) or oral nutritional supplement to a patient/resident.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "NutritionOrder",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "NutritionOrder",
            "path": "NutritionOrder",
            "short": "Diet, formula or nutritional supplement request",
            "definition": "A request to supply a diet, formula feeding (enteral) or oral nutritional supplement to a patient/resident.",
            "comment": "Referenced by an Order Request (workflow).",
            "alias": [
              "Nutrition Order",
              "Diet Order",
              "Diet",
              "Nutritional Supplement",
              "Enteral Nutrition"
            ],
            "min": 0,
            "max": "*"
          },
          {
            "id": "NutritionOrder.identifier",
            "path": "NutritionOrder.identifier",
            "short": "Identifiers assigned to this order",
            "definition": "Identifiers assigned to this order by the order sender or by the order receiver.",
            "comment": "The Identifier.type element can be to indicate filler vs. placer if needed.  This is explained in further detail [here](servicerequest.html#notes).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ]
          },
          {
            "id": "NutritionOrder.instantiatesCanonical",
            "path": "NutritionOrder.instantiatesCanonical",
            "short": "Instantiates FHIR protocol or definition",
            "definition": "The URL pointing to a FHIR-defined protocol, guideline, orderset or other definition that is adhered to in whole or in part by this NutritionOrder.",
            "comment": "Note: This is a business identifier, not a resource identifier (see [discussion](resource.html#identifiers)).  It is best practice for the identifier to only appear on a single resource instance, however business practices may occasionally dictate that multiple resource instances with the same identifier can exist - possibly even with different resource types.  For example, multiple Patient and a Person resource instance might share the same social insurance number.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ActivityDefinition",
                  "http://hl7.org/fhir/StructureDefinition/PlanDefinition"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "NutritionOrder.instantiatesUri",
            "path": "NutritionOrder.instantiatesUri",
            "short": "Instantiates external protocol or definition",
            "definition": "The URL pointing to an externally maintained protocol, guideline, orderset or other definition that is adhered to in whole or in part by this NutritionOrder.",
            "comment": "This might be an HTML page, PDF, etc. or could just be a non-resolvable URI identifier.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "uri"
              }
            ],
            "isSummary": true
          },
          {
            "id": "NutritionOrder.instantiates",
            "path": "NutritionOrder.instantiates",
            "short": "Instantiates protocol or definition",
            "definition": "The URL pointing to a protocol, guideline, orderset or other definition that is adhered to in whole or in part by this NutritionOrder.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "uri"
              }
            ]
          },
          {
            "id": "NutritionOrder.status",
            "path": "NutritionOrder.status",
            "short": "proposed | draft | planned | requested | active | on-hold | completed | cancelled | entered-in-error",
            "definition": "The workflow status of the nutrition order/request.",
            "comment": "Typically the system placing the order sets the status to \"requested\". Thereafter, the order is maintained by the receiver that updates the status as the request is handled.  This element is labeled as a modifier because the status contains codes that mark the resource as not currently valid.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element is labeled as a modifier because it is a status element that contains status entered-in-error which means that the resource should not be treated as valid",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "NutritionOrderStatus"
                }
              ],
              "strength": "required",
              "description": "Codes identifying the lifecycle stage of the nutrition order.",
              "valueSet": "http://hl7.org/fhir/ValueSet/request-status|4.0.0"
            }
          },
          {
            "id": "NutritionOrder.intent",
            "path": "NutritionOrder.intent",
            "short": "proposal | plan | order",
            "definition": "Indicates the level of authority/intentionality associated with the NutrionOrder and where the request fits into the workflow chain.",
            "comment": "When resources map to this element, they are free to define as many codes as necessary to cover their space and will map to \"proposal, plan or order\".  Can have multiple codes that map to one of these.  E.g. \"original order\", \"encoded order\", \"reflex order\" would all map to \"order\".  Expectation is that the set of codes is mutually exclusive or a strict all-encompassing hierarchy.",
            "requirements": "Proposals/recommendations, plans and orders all use the same structure and can exist in the same fulfillment chain.",
            "alias": [
              "category"
            ],
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element changes the interpretation of all descriptive attributes. For example \"the time the request is recommended to occur\" vs. \"the time the request is authorized to occur\" or \"who is recommended to perform the request\" vs. \"who is authorized to perform the request",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "NutritiionOrderIntent"
                }
              ],
              "strength": "required",
              "description": "Codes indicating the degree of authority/intentionality associated with a nutrition order.",
              "valueSet": "http://hl7.org/fhir/ValueSet/request-intent|4.0.0"
            }
          },
          {
            "id": "NutritionOrder.patient",
            "path": "NutritionOrder.patient",
            "short": "The person who requires the diet, formula or nutritional supplement",
            "definition": "The person (patient) who needs the nutrition order for an oral diet, nutritional supplement and/or enteral or formula feeding.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "NutritionOrder.encounter",
            "path": "NutritionOrder.encounter",
            "short": "The encounter associated with this nutrition order",
            "definition": "An encounter that provides additional information about the healthcare context in which this request is made.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Encounter"
                ]
              }
            ]
          },
          {
            "id": "NutritionOrder.dateTime",
            "path": "NutritionOrder.dateTime",
            "short": "Date and time the nutrition order was requested",
            "definition": "The date and time that this nutrition order was requested.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ],
            "isSummary": true
          },
          {
            "id": "NutritionOrder.orderer",
            "path": "NutritionOrder.orderer",
            "short": "Who ordered the diet, formula or nutritional supplement",
            "definition": "The practitioner that holds legal responsibility for ordering the diet, nutritional supplement, or formula feedings.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "NutritionOrder.allergyIntolerance",
            "path": "NutritionOrder.allergyIntolerance",
            "short": "List of the patient's food and nutrition-related allergies and intolerances",
            "definition": "A link to a record of allergies or intolerances  which should be included in the nutrition order.",
            "comment": "Information on a patient's food allergies and intolerances to inform healthcare personnel about the type of foods that the patient shouldn't receive or consume.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/AllergyIntolerance"
                ]
              }
            ]
          },
          {
            "id": "NutritionOrder.foodPreferenceModifier",
            "path": "NutritionOrder.foodPreferenceModifier",
            "short": "Order-specific modifier about the type of food that should be given",
            "definition": "This modifier is used to convey order-specific modifiers about the type of food that should be given. These can be derived from patient allergies, intolerances, or preferences such as Halal, Vegan or Kosher. This modifier applies to the entire nutrition order inclusive of the oral diet, nutritional supplements and enteral formula feedings.",
            "comment": "Information on a patient's food preferences that inform healthcare personnel about the food that the patient should receive or consume.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "PatientDiet"
                }
              ],
              "strength": "example",
              "description": "Medical, cultural or ethical food preferences to help with catering requirements.",
              "valueSet": "http://hl7.org/fhir/ValueSet/encounter-diet"
            }
          },
          {
            "id": "NutritionOrder.excludeFoodModifier",
            "path": "NutritionOrder.excludeFoodModifier",
            "short": "Order-specific modifier about the type of food that should not be given",
            "definition": "This modifier is used to convey Order-specific modifier about the type of oral food or oral fluids that should not be given. These can be derived from patient allergies, intolerances, or preferences such as No Red Meat, No Soy or No Wheat or  Gluten-Free.  While it should not be necessary to repeat allergy or intolerance information captured in the referenced AllergyIntolerance resource in the excludeFoodModifier, this element may be used to convey additional specificity related to foods that should be eliminated from the patient’s diet for any reason.  This modifier applies to the entire nutrition order inclusive of the oral diet, nutritional supplements and enteral formula feedings.",
            "comment": "Information on a patient's food allergies, intolerances and preferences to inform healthcare personnel about the type  of foods that the patient shouldn't receive or consume.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "FoodType"
                }
              ],
              "strength": "example",
              "description": "Codes used to indicate the type of food that should NOT be given to the patient.",
              "valueSet": "http://hl7.org/fhir/ValueSet/food-type"
            }
          },
          {
            "id": "NutritionOrder.oralDiet",
            "path": "NutritionOrder.oralDiet",
            "short": "Oral diet components",
            "definition": "Diet given orally in contrast to enteral (tube) feeding.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "condition": [
              "nor-1"
            ]
          },
          {
            "id": "NutritionOrder.oralDiet.type",
            "path": "NutritionOrder.oralDiet.type",
            "short": "Type of oral diet or diet restrictions that describe what can be consumed orally",
            "definition": "The kind of diet or dietary restriction such as fiber restricted diet or diabetic diet.",
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
                  "valueString": "OralDiet"
                }
              ],
              "strength": "example",
              "description": "Codes used to indicate the type of diet being ordered for a patient.",
              "valueSet": "http://hl7.org/fhir/ValueSet/diet-type"
            }
          },
          {
            "id": "NutritionOrder.oralDiet.schedule",
            "path": "NutritionOrder.oralDiet.schedule",
            "short": "Scheduled frequency of diet",
            "definition": "The time period and frequency at which the diet should be given.  The diet should be given for the combination of all schedules if more than one schedule is present.",
            "alias": [
              "Frequency"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Timing"
              }
            ]
          },
          {
            "id": "NutritionOrder.oralDiet.nutrient",
            "path": "NutritionOrder.oralDiet.nutrient",
            "short": "Required  nutrient modifications",
            "definition": "Class that defines the quantity and type of nutrient modifications (for example carbohydrate, fiber or sodium) required for the oral diet.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "NutritionOrder.oralDiet.nutrient.modifier",
            "path": "NutritionOrder.oralDiet.nutrient.modifier",
            "short": "Type of nutrient that is being modified",
            "definition": "The nutrient that is being modified such as carbohydrate or sodium.",
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
                  "valueString": "NutrientModifier"
                }
              ],
              "strength": "example",
              "description": "Codes for types of nutrients that are being modified such as carbohydrate or sodium.",
              "valueSet": "http://hl7.org/fhir/ValueSet/nutrient-code"
            }
          },
          {
            "id": "NutritionOrder.oralDiet.nutrient.amount",
            "path": "NutritionOrder.oralDiet.nutrient.amount",
            "short": "Quantity of the specified nutrient",
            "definition": "The quantity of the specified nutrient to include in diet.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity",
                "profile": [
                  "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
                ]
              }
            ]
          },
          {
            "id": "NutritionOrder.oralDiet.texture",
            "path": "NutritionOrder.oralDiet.texture",
            "short": "Required  texture modifications",
            "definition": "Class that describes any texture modifications required for the patient to safely consume various types of solid foods.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "NutritionOrder.oralDiet.texture.modifier",
            "path": "NutritionOrder.oralDiet.texture.modifier",
            "short": "Code to indicate how to alter the texture of the foods, e.g. pureed",
            "definition": "Any texture modifications (for solid foods) that should be made, e.g. easy to chew, chopped, ground, and pureed.",
            "comment": "Coupled with the foodType (Meat).",
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
                  "valueString": "TextureModifier"
                }
              ],
              "strength": "example",
              "description": "Codes for food consistency types or texture modifications to apply to foods.",
              "valueSet": "http://hl7.org/fhir/ValueSet/texture-code"
            }
          },
          {
            "id": "NutritionOrder.oralDiet.texture.foodType",
            "path": "NutritionOrder.oralDiet.texture.foodType",
            "short": "Concepts that are used to identify an entity that is ingested for nutritional purposes",
            "definition": "The food type(s) (e.g. meats, all foods)  that the texture modification applies to.  This could be all foods types.",
            "comment": "Coupled with the `texture.modifier`; could be (All Foods).",
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
                  "valueString": "TextureModifiedFoodType"
                }
              ],
              "strength": "example",
              "description": "Codes for types of foods that are texture-modified.",
              "valueSet": "http://hl7.org/fhir/ValueSet/modified-foodtype"
            }
          },
          {
            "id": "NutritionOrder.oralDiet.fluidConsistencyType",
            "path": "NutritionOrder.oralDiet.fluidConsistencyType",
            "short": "The required consistency of fluids and liquids provided to the patient",
            "definition": "The required consistency (e.g. honey-thick, nectar-thick, thin, thickened.) of liquids or fluids served to the patient.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "FluidConsistencyType"
                }
              ],
              "strength": "example",
              "description": "Codes used to represent the consistency of fluids and liquids provided to the patient.",
              "valueSet": "http://hl7.org/fhir/ValueSet/consistency-type"
            }
          },
          {
            "id": "NutritionOrder.oralDiet.instruction",
            "path": "NutritionOrder.oralDiet.instruction",
            "short": "Instructions or additional information about the oral diet",
            "definition": "Free text or additional instructions or information pertaining to the oral diet.",
            "comment": "Free text dosage instructions can be used for cases where the instructions are too complex to code.",
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
            "id": "NutritionOrder.supplement",
            "path": "NutritionOrder.supplement",
            "short": "Supplement components",
            "definition": "Oral nutritional products given in order to add further nutritional value to the patient's diet.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "condition": [
              "nor-1"
            ]
          },
          {
            "id": "NutritionOrder.supplement.type",
            "path": "NutritionOrder.supplement.type",
            "short": "Type of supplement product requested",
            "definition": "The kind of nutritional supplement product required such as a high protein or pediatric clear liquid supplement.",
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
                  "valueString": "SupplementType"
                }
              ],
              "strength": "example",
              "description": "Codes for nutritional supplements to be provided to the patient.",
              "valueSet": "http://hl7.org/fhir/ValueSet/supplement-type"
            }
          },
          {
            "id": "NutritionOrder.supplement.productName",
            "path": "NutritionOrder.supplement.productName",
            "short": "Product or brand name of the nutritional supplement",
            "definition": "The product or brand name of the nutritional supplement such as \"Acme Protein Shake\".",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "NutritionOrder.supplement.schedule",
            "path": "NutritionOrder.supplement.schedule",
            "short": "Scheduled frequency of supplement",
            "definition": "The time period and frequency at which the supplement(s) should be given.  The supplement should be given for the combination of all schedules if more than one schedule is present.",
            "alias": [
              "Frequency"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Timing"
              }
            ]
          },
          {
            "id": "NutritionOrder.supplement.quantity",
            "path": "NutritionOrder.supplement.quantity",
            "short": "Amount of the nutritional supplement",
            "definition": "The amount of the nutritional supplement to be given.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity",
                "profile": [
                  "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
                ]
              }
            ]
          },
          {
            "id": "NutritionOrder.supplement.instruction",
            "path": "NutritionOrder.supplement.instruction",
            "short": "Instructions or additional information about the oral supplement",
            "definition": "Free text or additional instructions or information pertaining to the oral supplement.",
            "comment": "Free text dosage instructions can be used for cases where the instructions are too complex to code.",
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
            "id": "NutritionOrder.enteralFormula",
            "path": "NutritionOrder.enteralFormula",
            "short": "Enteral formula components",
            "definition": "Feeding provided through the gastrointestinal tract via a tube, catheter, or stoma that delivers nutrition distal to the oral cavity.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "condition": [
              "nor-1"
            ]
          },
          {
            "id": "NutritionOrder.enteralFormula.baseFormulaType",
            "path": "NutritionOrder.enteralFormula.baseFormulaType",
            "short": "Type of enteral or infant formula",
            "definition": "The type of enteral or infant formula such as an adult standard formula with fiber or a soy-based infant formula.",
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
                  "valueString": "EnteralFormulaType"
                }
              ],
              "strength": "example",
              "description": "Codes for type of enteral formula to be administered to patient.",
              "valueSet": "http://hl7.org/fhir/ValueSet/entformula-type"
            }
          },
          {
            "id": "NutritionOrder.enteralFormula.baseFormulaProductName",
            "path": "NutritionOrder.enteralFormula.baseFormulaProductName",
            "short": "Product or brand name of the enteral or infant formula",
            "definition": "The product or brand name of the enteral or infant formula product such as \"ACME Adult Standard Formula\".",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "NutritionOrder.enteralFormula.additiveType",
            "path": "NutritionOrder.enteralFormula.additiveType",
            "short": "Type of modular component to add to the feeding",
            "definition": "Indicates the type of modular component such as protein, carbohydrate, fat or fiber to be provided in addition to or mixed with the base formula.",
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
                  "valueString": "EnteralFormulaAdditiveType"
                }
              ],
              "strength": "example",
              "description": "Codes for the type of modular component such as protein, carbohydrate or fiber to be provided in addition to or mixed with the base formula.",
              "valueSet": "http://hl7.org/fhir/ValueSet/entformula-additive"
            }
          },
          {
            "id": "NutritionOrder.enteralFormula.additiveProductName",
            "path": "NutritionOrder.enteralFormula.additiveProductName",
            "short": "Product or brand name of the modular additive",
            "definition": "The product or brand name of the type of modular component to be added to the formula.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "NutritionOrder.enteralFormula.caloricDensity",
            "path": "NutritionOrder.enteralFormula.caloricDensity",
            "short": "Amount of energy per specified volume that is required",
            "definition": "The amount of energy (calories) that the formula should provide per specified volume, typically per mL or fluid oz.  For example, an infant may require a formula that provides 24 calories per fluid ounce or an adult may require an enteral formula that provides 1.5 calorie/mL.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity",
                "profile": [
                  "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
                ]
              }
            ]
          },
          {
            "id": "NutritionOrder.enteralFormula.routeofAdministration",
            "path": "NutritionOrder.enteralFormula.routeofAdministration",
            "short": "How the formula should enter the patient's gastrointestinal tract",
            "definition": "The route or physiological path of administration into the patient's gastrointestinal  tract for purposes of providing the formula feeding, e.g. nasogastric tube.",
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
                  "valueString": "EnteralRouteOfAdministration"
                }
              ],
              "strength": "extensible",
              "description": "Codes specifying the route of administration of enteral formula.",
              "valueSet": "http://hl7.org/fhir/ValueSet/enteral-route"
            }
          },
          {
            "id": "NutritionOrder.enteralFormula.administration",
            "path": "NutritionOrder.enteralFormula.administration",
            "short": "Formula feeding instruction as structured data",
            "definition": "Formula administration instructions as structured data.  This repeating structure allows for changing the administration rate or volume over time for both bolus and continuous feeding.  An example of this would be an instruction to increase the rate of continuous feeding every 2 hours.",
            "comment": "See implementation notes below for further discussion on how to order continuous vs bolus enteral feeding using this resource.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "NutritionOrder.enteralFormula.administration.schedule",
            "path": "NutritionOrder.enteralFormula.administration.schedule",
            "short": "Scheduled frequency of enteral feeding",
            "definition": "The time period and frequency at which the enteral formula should be delivered to the patient.",
            "alias": [
              "Frequency"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Timing"
              }
            ]
          },
          {
            "id": "NutritionOrder.enteralFormula.administration.quantity",
            "path": "NutritionOrder.enteralFormula.administration.quantity",
            "short": "The volume of formula to provide",
            "definition": "The volume of formula to provide to the patient per the specified administration schedule.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity",
                "profile": [
                  "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
                ]
              }
            ]
          },
          {
            "id": "NutritionOrder.enteralFormula.administration.rate[x]",
            "path": "NutritionOrder.enteralFormula.administration.rate[x]",
            "short": "Speed with which the formula is provided per period of time",
            "definition": "The rate of administration of formula via a feeding pump, e.g. 60 mL per hour, according to the specified schedule.",
            "comment": "Ratio is used when the quantity value in the denominator is not \"1\", otherwise use Quantity. For example, the Ratio datatype is used for \"200 mL/4 hrs\" versus the Quantity datatype for \"50 mL/hr\".",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity",
                "profile": [
                  "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
                ]
              },
              {
                "code": "Ratio"
              }
            ]
          },
          {
            "id": "NutritionOrder.enteralFormula.maxVolumeToDeliver",
            "path": "NutritionOrder.enteralFormula.maxVolumeToDeliver",
            "short": "Upper limit on formula volume per unit of time",
            "definition": "The maximum total quantity of formula that may be administered to a subject over the period of time, e.g. 1440 mL over 24 hours.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity",
                "profile": [
                  "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
                ]
              }
            ]
          },
          {
            "id": "NutritionOrder.enteralFormula.administrationInstruction",
            "path": "NutritionOrder.enteralFormula.administrationInstruction",
            "short": "Formula feeding instructions expressed as text",
            "definition": "Free text formula administration, feeding instructions or additional instructions or information.",
            "comment": "Free text dosage instructions can be used for cases where the instructions are too complex to code.",
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
            "id": "NutritionOrder.note",
            "path": "NutritionOrder.note",
            "short": "Comments",
            "definition": "Comments made about the {{title}} by the requester, performer, subject or other participants.",
            "comment": "This element SHALL NOT be used to supply free text instructions for the diet which are represented in the `.oralDiet.instruction`, `supplement.instruction`, or `enteralFormula.administrationInstruction` elements.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Annotation"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:425
    /// <summary>
    /// Fhir resource 'NutritionOrder'
    /// </summary>
    // 0. NutritionOrder
    public class NutritionOrder : FhirKhit.Maker.Common.Resource.ResourceBase                                                               // MakerGen.cs:374
    {                                                                                                                                       // MakerGen.cs:375
        // 14. NutritionOrder.oralDiet
        public class Type_OralDiet : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:374
        {                                                                                                                                   // MakerGen.cs:375
            // 17. NutritionOrder.oralDiet.nutrient
            public class Type_Nutrient : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:374
            {                                                                                                                               // MakerGen.cs:375
                // 18. NutritionOrder.oralDiet.nutrient.modifier
                public MakerElementInstance Element_Modifier;                                                                               // MakerGen.cs:232
                // 19. NutritionOrder.oralDiet.nutrient.amount
                public MakerElementInstance Element_Amount;                                                                                 // MakerGen.cs:232
                public Type_Nutrient()                                                                                                      // MakerGen.cs:383
                {                                                                                                                           // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:243
                        // 18. NutritionOrder.oralDiet.nutrient.modifier
                        this.Element_Modifier = new MakerElementInstance                                                                    // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Modifier",                                                                                      // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept                                                           // MakerGen.cs:304
                                {                                                                                                           // MakerGen.cs:305
                                }                                                                                                           // MakerGen.cs:308
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:356
                    {                                                                                                                       // MakerGen.cs:243
                        // 19. NutritionOrder.oralDiet.nutrient.amount
                        this.Element_Amount = new MakerElementInstance                                                                      // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Amount",                                                                                        // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.Quantity                                                                  // MakerGen.cs:347
                                {                                                                                                           // MakerGen.cs:348
                                }                                                                                                           // MakerGen.cs:349
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:356
                }                                                                                                                           // MakerGen.cs:395
            }                                                                                                                               // MakerGen.cs:379
            // 20. NutritionOrder.oralDiet.texture
            public class Type_Texture : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:374
            {                                                                                                                               // MakerGen.cs:375
                // 21. NutritionOrder.oralDiet.texture.modifier
                public MakerElementInstance Element_Modifier;                                                                               // MakerGen.cs:232
                // 22. NutritionOrder.oralDiet.texture.foodType
                public MakerElementInstance Element_FoodType;                                                                               // MakerGen.cs:232
                public Type_Texture()                                                                                                       // MakerGen.cs:383
                {                                                                                                                           // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:243
                        // 21. NutritionOrder.oralDiet.texture.modifier
                        this.Element_Modifier = new MakerElementInstance                                                                    // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Modifier",                                                                                      // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept                                                           // MakerGen.cs:304
                                {                                                                                                           // MakerGen.cs:305
                                }                                                                                                           // MakerGen.cs:308
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:356
                    {                                                                                                                       // MakerGen.cs:243
                        // 22. NutritionOrder.oralDiet.texture.foodType
                        this.Element_FoodType = new MakerElementInstance                                                                    // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_FoodType",                                                                                      // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept                                                           // MakerGen.cs:304
                                {                                                                                                           // MakerGen.cs:305
                                }                                                                                                           // MakerGen.cs:308
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:356
                }                                                                                                                           // MakerGen.cs:395
            }                                                                                                                               // MakerGen.cs:379
            // 15. NutritionOrder.oralDiet.type
            public MakerElementInstance Element_Type;                                                                                       // MakerGen.cs:232
            // 16. NutritionOrder.oralDiet.schedule
            public MakerElementInstance Element_Schedule;                                                                                   // MakerGen.cs:232
            // 23. NutritionOrder.oralDiet.fluidConsistencyType
            public MakerElementInstance Element_FluidConsistencyType;                                                                       // MakerGen.cs:232
            // 24. NutritionOrder.oralDiet.instruction
            public MakerElementInstance Element_Instruction;                                                                                // MakerGen.cs:232
            public Type_OralDiet()                                                                                                          // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                {                                                                                                                           // MakerGen.cs:243
                    // 15. NutritionOrder.oralDiet.type
                    this.Element_Type = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Type",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:304
                            {                                                                                                               // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:308
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 16. NutritionOrder.oralDiet.schedule
                    this.Element_Schedule = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Schedule",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.Timing                                                                        // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 23. NutritionOrder.oralDiet.fluidConsistencyType
                    this.Element_FluidConsistencyType = new MakerElementInstance                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_FluidConsistencyType",                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:304
                            {                                                                                                               // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:308
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 24. NutritionOrder.oralDiet.instruction
                    this.Element_Instruction = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Instruction",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            }                                                                                                               // MakerGen.cs:293
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
            }                                                                                                                               // MakerGen.cs:395
        }                                                                                                                                   // MakerGen.cs:379
        // 25. NutritionOrder.supplement
        public class Type_Supplement : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:374
        {                                                                                                                                   // MakerGen.cs:375
            // 26. NutritionOrder.supplement.type
            public MakerElementInstance Element_Type;                                                                                       // MakerGen.cs:232
            // 27. NutritionOrder.supplement.productName
            public MakerElementInstance Element_ProductName;                                                                                // MakerGen.cs:232
            // 28. NutritionOrder.supplement.schedule
            public MakerElementInstance Element_Schedule;                                                                                   // MakerGen.cs:232
            // 29. NutritionOrder.supplement.quantity
            public MakerElementInstance Element_Quantity;                                                                                   // MakerGen.cs:232
            // 30. NutritionOrder.supplement.instruction
            public MakerElementInstance Element_Instruction;                                                                                // MakerGen.cs:232
            public Type_Supplement()                                                                                                        // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                {                                                                                                                           // MakerGen.cs:243
                    // 26. NutritionOrder.supplement.type
                    this.Element_Type = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Type",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:304
                            {                                                                                                               // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:308
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 27. NutritionOrder.supplement.productName
                    this.Element_ProductName = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_ProductName",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            }                                                                                                               // MakerGen.cs:293
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 28. NutritionOrder.supplement.schedule
                    this.Element_Schedule = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Schedule",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.Timing                                                                        // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 29. NutritionOrder.supplement.quantity
                    this.Element_Quantity = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Quantity",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.Quantity                                                                      // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 30. NutritionOrder.supplement.instruction
                    this.Element_Instruction = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Instruction",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            }                                                                                                               // MakerGen.cs:293
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
            }                                                                                                                               // MakerGen.cs:395
        }                                                                                                                                   // MakerGen.cs:379
        // 31. NutritionOrder.enteralFormula
        public class Type_EnteralFormula : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:374
        {                                                                                                                                   // MakerGen.cs:375
            // 38. NutritionOrder.enteralFormula.administration
            public class Type_Administration : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:374
            {                                                                                                                               // MakerGen.cs:375
                // 39. NutritionOrder.enteralFormula.administration.schedule
                public MakerElementInstance Element_Schedule;                                                                               // MakerGen.cs:232
                // 40. NutritionOrder.enteralFormula.administration.quantity
                public MakerElementInstance Element_Quantity;                                                                               // MakerGen.cs:232
                // 41. NutritionOrder.enteralFormula.administration.rate[x]
                public MakerElementInstance Element_Rate;                                                                                   // MakerGen.cs:232
                public Type_Administration()                                                                                                // MakerGen.cs:383
                {                                                                                                                           // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:243
                        // 39. NutritionOrder.enteralFormula.administration.schedule
                        this.Element_Schedule = new MakerElementInstance                                                                    // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Schedule",                                                                                      // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.Timing                                                                    // MakerGen.cs:347
                                {                                                                                                           // MakerGen.cs:348
                                }                                                                                                           // MakerGen.cs:349
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:356
                    {                                                                                                                       // MakerGen.cs:243
                        // 40. NutritionOrder.enteralFormula.administration.quantity
                        this.Element_Quantity = new MakerElementInstance                                                                    // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Quantity",                                                                                      // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.Quantity                                                                  // MakerGen.cs:347
                                {                                                                                                           // MakerGen.cs:348
                                }                                                                                                           // MakerGen.cs:349
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:356
                    {                                                                                                                       // MakerGen.cs:243
                        // 41. NutritionOrder.enteralFormula.administration.rate[x]
                        this.Element_Rate = new MakerElementInstance                                                                        // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Rate",                                                                                          // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.Quantity                                                                  // MakerGen.cs:347
                                {                                                                                                           // MakerGen.cs:348
                                },                                                                                                          // MakerGen.cs:349
                                new FhirKhit.Maker.Common.Complex.Ratio                                                                     // MakerGen.cs:347
                                {                                                                                                           // MakerGen.cs:348
                                }                                                                                                           // MakerGen.cs:349
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:356
                }                                                                                                                           // MakerGen.cs:395
            }                                                                                                                               // MakerGen.cs:379
            // 32. NutritionOrder.enteralFormula.baseFormulaType
            public MakerElementInstance Element_BaseFormulaType;                                                                            // MakerGen.cs:232
            // 33. NutritionOrder.enteralFormula.baseFormulaProductName
            public MakerElementInstance Element_BaseFormulaProductName;                                                                     // MakerGen.cs:232
            // 34. NutritionOrder.enteralFormula.additiveType
            public MakerElementInstance Element_AdditiveType;                                                                               // MakerGen.cs:232
            // 35. NutritionOrder.enteralFormula.additiveProductName
            public MakerElementInstance Element_AdditiveProductName;                                                                        // MakerGen.cs:232
            // 36. NutritionOrder.enteralFormula.caloricDensity
            public MakerElementInstance Element_CaloricDensity;                                                                             // MakerGen.cs:232
            // 37. NutritionOrder.enteralFormula.routeofAdministration
            public MakerElementInstance Element_RouteofAdministration;                                                                      // MakerGen.cs:232
            // 42. NutritionOrder.enteralFormula.maxVolumeToDeliver
            public MakerElementInstance Element_MaxVolumeToDeliver;                                                                         // MakerGen.cs:232
            // 43. NutritionOrder.enteralFormula.administrationInstruction
            public MakerElementInstance Element_AdministrationInstruction;                                                                  // MakerGen.cs:232
            public Type_EnteralFormula()                                                                                                    // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                {                                                                                                                           // MakerGen.cs:243
                    // 32. NutritionOrder.enteralFormula.baseFormulaType
                    this.Element_BaseFormulaType = new MakerElementInstance                                                                 // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_BaseFormulaType",                                                                                   // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:304
                            {                                                                                                               // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:308
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 33. NutritionOrder.enteralFormula.baseFormulaProductName
                    this.Element_BaseFormulaProductName = new MakerElementInstance                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_BaseFormulaProductName",                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            }                                                                                                               // MakerGen.cs:293
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 34. NutritionOrder.enteralFormula.additiveType
                    this.Element_AdditiveType = new MakerElementInstance                                                                    // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_AdditiveType",                                                                                      // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:304
                            {                                                                                                               // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:308
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 35. NutritionOrder.enteralFormula.additiveProductName
                    this.Element_AdditiveProductName = new MakerElementInstance                                                             // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_AdditiveProductName",                                                                               // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            }                                                                                                               // MakerGen.cs:293
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 36. NutritionOrder.enteralFormula.caloricDensity
                    this.Element_CaloricDensity = new MakerElementInstance                                                                  // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_CaloricDensity",                                                                                    // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.Quantity                                                                      // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 37. NutritionOrder.enteralFormula.routeofAdministration
                    this.Element_RouteofAdministration = new MakerElementInstance                                                           // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_RouteofAdministration",                                                                             // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:304
                            {                                                                                                               // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:308
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 42. NutritionOrder.enteralFormula.maxVolumeToDeliver
                    this.Element_MaxVolumeToDeliver = new MakerElementInstance                                                              // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_MaxVolumeToDeliver",                                                                                // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.Quantity                                                                      // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 43. NutritionOrder.enteralFormula.administrationInstruction
                    this.Element_AdministrationInstruction = new MakerElementInstance                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_AdministrationInstruction",                                                                         // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            }                                                                                                               // MakerGen.cs:293
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
            }                                                                                                                               // MakerGen.cs:395
        }                                                                                                                                   // MakerGen.cs:379
        // 1. NutritionOrder.identifier
        public MakerElementInstance Element_Identifier;                                                                                     // MakerGen.cs:232
        // 2. NutritionOrder.instantiatesCanonical
        public MakerElementInstance Element_InstantiatesCanonical;                                                                          // MakerGen.cs:232
        // 3. NutritionOrder.instantiatesUri
        public MakerElementInstance Element_InstantiatesUri;                                                                                // MakerGen.cs:232
        // 4. NutritionOrder.instantiates
        public MakerElementInstance Element_Instantiates;                                                                                   // MakerGen.cs:232
        // 5. NutritionOrder.status
        public MakerElementInstance Element_Status;                                                                                         // MakerGen.cs:232
        // 6. NutritionOrder.intent
        public MakerElementInstance Element_Intent;                                                                                         // MakerGen.cs:232
        // 7. NutritionOrder.patient
        public MakerElementInstance Element_Patient;                                                                                        // MakerGen.cs:232
        // 8. NutritionOrder.encounter
        public MakerElementInstance Element_Encounter;                                                                                      // MakerGen.cs:232
        // 9. NutritionOrder.dateTime
        public MakerElementInstance Element_DateTime;                                                                                       // MakerGen.cs:232
        // 10. NutritionOrder.orderer
        public MakerElementInstance Element_Orderer;                                                                                        // MakerGen.cs:232
        // 11. NutritionOrder.allergyIntolerance
        public MakerElementInstance Element_AllergyIntolerance;                                                                             // MakerGen.cs:232
        // 12. NutritionOrder.foodPreferenceModifier
        public MakerElementInstance Element_FoodPreferenceModifier;                                                                         // MakerGen.cs:232
        // 13. NutritionOrder.excludeFoodModifier
        public MakerElementInstance Element_ExcludeFoodModifier;                                                                            // MakerGen.cs:232
        // 44. NutritionOrder.note
        public MakerElementInstance Element_Note;                                                                                           // MakerGen.cs:232
        public NutritionOrder()                                                                                                             // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:243
                // 1. NutritionOrder.identifier
                this.Element_Identifier = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Identifier                                                                        // MakerGen.cs:347
                        {                                                                                                                   // MakerGen.cs:348
                        }                                                                                                                   // MakerGen.cs:349
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 2. NutritionOrder.instantiatesCanonical
                this.Element_InstantiatesCanonical = new MakerElementInstance                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_InstantiatesCanonical",                                                                                 // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Canonical                                                                       // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:292
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/ActivityDefinition",                                               // MakerGen.cs:292
                                "http://hl7.org/fhir/StructureDefinition/PlanDefinition"                                                    // MakerGen.cs:292
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 3. NutritionOrder.instantiatesUri
                this.Element_InstantiatesUri = new MakerElementInstance                                                                     // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_InstantiatesUri",                                                                                       // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Uri                                                                             // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 4. NutritionOrder.instantiates
                this.Element_Instantiates = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Instantiates",                                                                                          // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Uri                                                                             // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 5. NutritionOrder.status
                this.Element_Status = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Status",                                                                                                // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code                                                                            // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 6. NutritionOrder.intent
                this.Element_Intent = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Intent",                                                                                                // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code                                                                            // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 7. NutritionOrder.patient
                this.Element_Patient = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Patient",                                                                                               // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:335
                        {                                                                                                                   // MakerGen.cs:336
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:338
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Patient"                                                           // MakerGen.cs:338
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:339
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 8. NutritionOrder.encounter
                this.Element_Encounter = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Encounter",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:335
                        {                                                                                                                   // MakerGen.cs:336
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:338
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Encounter"                                                         // MakerGen.cs:338
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:339
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 9. NutritionOrder.dateTime
                this.Element_DateTime = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_DateTime",                                                                                              // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.DateTime                                                                        // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 10. NutritionOrder.orderer
                this.Element_Orderer = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Orderer",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:335
                        {                                                                                                                   // MakerGen.cs:336
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:338
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:338
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                                  // MakerGen.cs:338
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:339
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 11. NutritionOrder.allergyIntolerance
                this.Element_AllergyIntolerance = new MakerElementInstance                                                                  // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_AllergyIntolerance",                                                                                    // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:335
                        {                                                                                                                   // MakerGen.cs:336
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:338
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/AllergyIntolerance"                                                // MakerGen.cs:338
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:339
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 12. NutritionOrder.foodPreferenceModifier
                this.Element_FoodPreferenceModifier = new MakerElementInstance                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_FoodPreferenceModifier",                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:304
                        {                                                                                                                   // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:308
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 13. NutritionOrder.excludeFoodModifier
                this.Element_ExcludeFoodModifier = new MakerElementInstance                                                                 // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ExcludeFoodModifier",                                                                                   // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:304
                        {                                                                                                                   // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:308
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 44. NutritionOrder.note
                this.Element_Note = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Note",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Annotation                                                                        // MakerGen.cs:347
                        {                                                                                                                   // MakerGen.cs:348
                        }                                                                                                                   // MakerGen.cs:349
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
        }                                                                                                                                   // MakerGen.cs:395
    }                                                                                                                                       // MakerGen.cs:379
}                                                                                                                                           // MakerGen.cs:430
