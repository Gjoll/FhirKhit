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
    #endregion
    /// <summary>
    /// Fhir resource 'NutritionOrder'
    /// </summary>
    // 0. NutritionOrder
    public class Resource_NutritionOrder : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 14. NutritionOrder.oralDiet
        public class Type_OralDiet : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 17. NutritionOrder.oralDiet.nutrient
            public class Type_Nutrient : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 18. NutritionOrder.oralDiet.nutrient.modifier
                public ElementDefinitionInfo Element_Modifier;
                // 19. NutritionOrder.oralDiet.nutrient.amount
                public ElementDefinitionInfo Element_Amount;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "NutritionOrder.oralDiet.nutrient",
                        ElementId = "NutritionOrder.oralDiet.nutrient"
                    });
                    Element_Modifier.Write(sDef);
                    Element_Amount.Write(sDef);
                }
                
                public Type_Nutrient()
                {
                    {
                        // 18. NutritionOrder.oralDiet.nutrient.modifier
                        this.Element_Modifier = new ElementDefinitionInfo
                        {
                            Name = "Element_Modifier",
                            Path= "NutritionOrder.oralDiet.nutrient.modifier",
                            Id = "NutritionOrder.oralDiet.nutrient.modifier",
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
                        // 19. NutritionOrder.oralDiet.nutrient.amount
                        this.Element_Amount = new ElementDefinitionInfo
                        {
                            Name = "Element_Amount",
                            Path= "NutritionOrder.oralDiet.nutrient.amount",
                            Id = "NutritionOrder.oralDiet.nutrient.amount",
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
            // 20. NutritionOrder.oralDiet.texture
            public class Type_Texture : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 21. NutritionOrder.oralDiet.texture.modifier
                public ElementDefinitionInfo Element_Modifier;
                // 22. NutritionOrder.oralDiet.texture.foodType
                public ElementDefinitionInfo Element_FoodType;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "NutritionOrder.oralDiet.texture",
                        ElementId = "NutritionOrder.oralDiet.texture"
                    });
                    Element_Modifier.Write(sDef);
                    Element_FoodType.Write(sDef);
                }
                
                public Type_Texture()
                {
                    {
                        // 21. NutritionOrder.oralDiet.texture.modifier
                        this.Element_Modifier = new ElementDefinitionInfo
                        {
                            Name = "Element_Modifier",
                            Path= "NutritionOrder.oralDiet.texture.modifier",
                            Id = "NutritionOrder.oralDiet.texture.modifier",
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
                        // 22. NutritionOrder.oralDiet.texture.foodType
                        this.Element_FoodType = new ElementDefinitionInfo
                        {
                            Name = "Element_FoodType",
                            Path= "NutritionOrder.oralDiet.texture.foodType",
                            Id = "NutritionOrder.oralDiet.texture.foodType",
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
                }
            }
            // 15. NutritionOrder.oralDiet.type
            public ElementDefinitionInfo Element_Type;
            // 16. NutritionOrder.oralDiet.schedule
            public ElementDefinitionInfo Element_Schedule;
            // 17. NutritionOrder.oralDiet.nutrient
            public ElementDefinitionInfo Element_Nutrient;
            // 20. NutritionOrder.oralDiet.texture
            public ElementDefinitionInfo Element_Texture;
            // 23. NutritionOrder.oralDiet.fluidConsistencyType
            public ElementDefinitionInfo Element_FluidConsistencyType;
            // 24. NutritionOrder.oralDiet.instruction
            public ElementDefinitionInfo Element_Instruction;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "NutritionOrder.oralDiet",
                    ElementId = "NutritionOrder.oralDiet"
                });
                Element_Type.Write(sDef);
                Element_Schedule.Write(sDef);
                Element_Nutrient.Write(sDef);
                Element_Texture.Write(sDef);
                Element_FluidConsistencyType.Write(sDef);
                Element_Instruction.Write(sDef);
            }
            
            public Type_OralDiet()
            {
                {
                    // 15. NutritionOrder.oralDiet.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "NutritionOrder.oralDiet.type",
                        Id = "NutritionOrder.oralDiet.type",
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
                    // 16. NutritionOrder.oralDiet.schedule
                    this.Element_Schedule = new ElementDefinitionInfo
                    {
                        Name = "Element_Schedule",
                        Path= "NutritionOrder.oralDiet.schedule",
                        Id = "NutritionOrder.oralDiet.schedule",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Timing
                            {
                            }
                        }
                    };
                }
                {
                    // 17. NutritionOrder.oralDiet.nutrient
                    this.Element_Nutrient = new ElementDefinitionInfo
                    {
                        Name = "Element_Nutrient",
                        Path= "NutritionOrder.oralDiet.nutrient",
                        Id = "NutritionOrder.oralDiet.nutrient",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Nutrient
                            {
                            }
                        }
                    };
                }
                {
                    // 20. NutritionOrder.oralDiet.texture
                    this.Element_Texture = new ElementDefinitionInfo
                    {
                        Name = "Element_Texture",
                        Path= "NutritionOrder.oralDiet.texture",
                        Id = "NutritionOrder.oralDiet.texture",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Texture
                            {
                            }
                        }
                    };
                }
                {
                    // 23. NutritionOrder.oralDiet.fluidConsistencyType
                    this.Element_FluidConsistencyType = new ElementDefinitionInfo
                    {
                        Name = "Element_FluidConsistencyType",
                        Path= "NutritionOrder.oralDiet.fluidConsistencyType",
                        Id = "NutritionOrder.oralDiet.fluidConsistencyType",
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
                    // 24. NutritionOrder.oralDiet.instruction
                    this.Element_Instruction = new ElementDefinitionInfo
                    {
                        Name = "Element_Instruction",
                        Path= "NutritionOrder.oralDiet.instruction",
                        Id = "NutritionOrder.oralDiet.instruction",
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
            }
        }
        // 25. NutritionOrder.supplement
        public class Type_Supplement : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 26. NutritionOrder.supplement.type
            public ElementDefinitionInfo Element_Type;
            // 27. NutritionOrder.supplement.productName
            public ElementDefinitionInfo Element_ProductName;
            // 28. NutritionOrder.supplement.schedule
            public ElementDefinitionInfo Element_Schedule;
            // 29. NutritionOrder.supplement.quantity
            public ElementDefinitionInfo Element_Quantity;
            // 30. NutritionOrder.supplement.instruction
            public ElementDefinitionInfo Element_Instruction;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "NutritionOrder.supplement",
                    ElementId = "NutritionOrder.supplement"
                });
                Element_Type.Write(sDef);
                Element_ProductName.Write(sDef);
                Element_Schedule.Write(sDef);
                Element_Quantity.Write(sDef);
                Element_Instruction.Write(sDef);
            }
            
            public Type_Supplement()
            {
                {
                    // 26. NutritionOrder.supplement.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "NutritionOrder.supplement.type",
                        Id = "NutritionOrder.supplement.type",
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
                    // 27. NutritionOrder.supplement.productName
                    this.Element_ProductName = new ElementDefinitionInfo
                    {
                        Name = "Element_ProductName",
                        Path= "NutritionOrder.supplement.productName",
                        Id = "NutritionOrder.supplement.productName",
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
                    // 28. NutritionOrder.supplement.schedule
                    this.Element_Schedule = new ElementDefinitionInfo
                    {
                        Name = "Element_Schedule",
                        Path= "NutritionOrder.supplement.schedule",
                        Id = "NutritionOrder.supplement.schedule",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Timing
                            {
                            }
                        }
                    };
                }
                {
                    // 29. NutritionOrder.supplement.quantity
                    this.Element_Quantity = new ElementDefinitionInfo
                    {
                        Name = "Element_Quantity",
                        Path= "NutritionOrder.supplement.quantity",
                        Id = "NutritionOrder.supplement.quantity",
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
                    // 30. NutritionOrder.supplement.instruction
                    this.Element_Instruction = new ElementDefinitionInfo
                    {
                        Name = "Element_Instruction",
                        Path= "NutritionOrder.supplement.instruction",
                        Id = "NutritionOrder.supplement.instruction",
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
            }
        }
        // 31. NutritionOrder.enteralFormula
        public class Type_EnteralFormula : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 38. NutritionOrder.enteralFormula.administration
            public class Type_Administration : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 39. NutritionOrder.enteralFormula.administration.schedule
                public ElementDefinitionInfo Element_Schedule;
                // 40. NutritionOrder.enteralFormula.administration.quantity
                public ElementDefinitionInfo Element_Quantity;
                // 41. NutritionOrder.enteralFormula.administration.rate[x]
                public ElementDefinitionInfo Element_Rate;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "NutritionOrder.enteralFormula.administration",
                        ElementId = "NutritionOrder.enteralFormula.administration"
                    });
                    Element_Schedule.Write(sDef);
                    Element_Quantity.Write(sDef);
                    Element_Rate.Write(sDef);
                }
                
                public Type_Administration()
                {
                    {
                        // 39. NutritionOrder.enteralFormula.administration.schedule
                        this.Element_Schedule = new ElementDefinitionInfo
                        {
                            Name = "Element_Schedule",
                            Path= "NutritionOrder.enteralFormula.administration.schedule",
                            Id = "NutritionOrder.enteralFormula.administration.schedule",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_Timing
                                {
                                }
                            }
                        };
                    }
                    {
                        // 40. NutritionOrder.enteralFormula.administration.quantity
                        this.Element_Quantity = new ElementDefinitionInfo
                        {
                            Name = "Element_Quantity",
                            Path= "NutritionOrder.enteralFormula.administration.quantity",
                            Id = "NutritionOrder.enteralFormula.administration.quantity",
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
                        // 41. NutritionOrder.enteralFormula.administration.rate[x]
                        this.Element_Rate = new ElementDefinitionInfo
                        {
                            Name = "Element_Rate",
                            Path= "NutritionOrder.enteralFormula.administration.rate[x]",
                            Id = "NutritionOrder.enteralFormula.administration.rate[x]",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_Quantity
                                {
                                },
                                new FhirKhit.Maker.Common.Complex.Type_Ratio
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 32. NutritionOrder.enteralFormula.baseFormulaType
            public ElementDefinitionInfo Element_BaseFormulaType;
            // 33. NutritionOrder.enteralFormula.baseFormulaProductName
            public ElementDefinitionInfo Element_BaseFormulaProductName;
            // 34. NutritionOrder.enteralFormula.additiveType
            public ElementDefinitionInfo Element_AdditiveType;
            // 35. NutritionOrder.enteralFormula.additiveProductName
            public ElementDefinitionInfo Element_AdditiveProductName;
            // 36. NutritionOrder.enteralFormula.caloricDensity
            public ElementDefinitionInfo Element_CaloricDensity;
            // 37. NutritionOrder.enteralFormula.routeofAdministration
            public ElementDefinitionInfo Element_RouteofAdministration;
            // 38. NutritionOrder.enteralFormula.administration
            public ElementDefinitionInfo Element_Administration;
            // 42. NutritionOrder.enteralFormula.maxVolumeToDeliver
            public ElementDefinitionInfo Element_MaxVolumeToDeliver;
            // 43. NutritionOrder.enteralFormula.administrationInstruction
            public ElementDefinitionInfo Element_AdministrationInstruction;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "NutritionOrder.enteralFormula",
                    ElementId = "NutritionOrder.enteralFormula"
                });
                Element_BaseFormulaType.Write(sDef);
                Element_BaseFormulaProductName.Write(sDef);
                Element_AdditiveType.Write(sDef);
                Element_AdditiveProductName.Write(sDef);
                Element_CaloricDensity.Write(sDef);
                Element_RouteofAdministration.Write(sDef);
                Element_Administration.Write(sDef);
                Element_MaxVolumeToDeliver.Write(sDef);
                Element_AdministrationInstruction.Write(sDef);
            }
            
            public Type_EnteralFormula()
            {
                {
                    // 32. NutritionOrder.enteralFormula.baseFormulaType
                    this.Element_BaseFormulaType = new ElementDefinitionInfo
                    {
                        Name = "Element_BaseFormulaType",
                        Path= "NutritionOrder.enteralFormula.baseFormulaType",
                        Id = "NutritionOrder.enteralFormula.baseFormulaType",
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
                    // 33. NutritionOrder.enteralFormula.baseFormulaProductName
                    this.Element_BaseFormulaProductName = new ElementDefinitionInfo
                    {
                        Name = "Element_BaseFormulaProductName",
                        Path= "NutritionOrder.enteralFormula.baseFormulaProductName",
                        Id = "NutritionOrder.enteralFormula.baseFormulaProductName",
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
                    // 34. NutritionOrder.enteralFormula.additiveType
                    this.Element_AdditiveType = new ElementDefinitionInfo
                    {
                        Name = "Element_AdditiveType",
                        Path= "NutritionOrder.enteralFormula.additiveType",
                        Id = "NutritionOrder.enteralFormula.additiveType",
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
                    // 35. NutritionOrder.enteralFormula.additiveProductName
                    this.Element_AdditiveProductName = new ElementDefinitionInfo
                    {
                        Name = "Element_AdditiveProductName",
                        Path= "NutritionOrder.enteralFormula.additiveProductName",
                        Id = "NutritionOrder.enteralFormula.additiveProductName",
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
                    // 36. NutritionOrder.enteralFormula.caloricDensity
                    this.Element_CaloricDensity = new ElementDefinitionInfo
                    {
                        Name = "Element_CaloricDensity",
                        Path= "NutritionOrder.enteralFormula.caloricDensity",
                        Id = "NutritionOrder.enteralFormula.caloricDensity",
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
                    // 37. NutritionOrder.enteralFormula.routeofAdministration
                    this.Element_RouteofAdministration = new ElementDefinitionInfo
                    {
                        Name = "Element_RouteofAdministration",
                        Path= "NutritionOrder.enteralFormula.routeofAdministration",
                        Id = "NutritionOrder.enteralFormula.routeofAdministration",
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
                    // 38. NutritionOrder.enteralFormula.administration
                    this.Element_Administration = new ElementDefinitionInfo
                    {
                        Name = "Element_Administration",
                        Path= "NutritionOrder.enteralFormula.administration",
                        Id = "NutritionOrder.enteralFormula.administration",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Administration
                            {
                            }
                        }
                    };
                }
                {
                    // 42. NutritionOrder.enteralFormula.maxVolumeToDeliver
                    this.Element_MaxVolumeToDeliver = new ElementDefinitionInfo
                    {
                        Name = "Element_MaxVolumeToDeliver",
                        Path= "NutritionOrder.enteralFormula.maxVolumeToDeliver",
                        Id = "NutritionOrder.enteralFormula.maxVolumeToDeliver",
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
                    // 43. NutritionOrder.enteralFormula.administrationInstruction
                    this.Element_AdministrationInstruction = new ElementDefinitionInfo
                    {
                        Name = "Element_AdministrationInstruction",
                        Path= "NutritionOrder.enteralFormula.administrationInstruction",
                        Id = "NutritionOrder.enteralFormula.administrationInstruction",
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
            }
        }
        // 1. NutritionOrder.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. NutritionOrder.instantiatesCanonical
        public ElementDefinitionInfo Element_InstantiatesCanonical;
        // 3. NutritionOrder.instantiatesUri
        public ElementDefinitionInfo Element_InstantiatesUri;
        // 4. NutritionOrder.instantiates
        public ElementDefinitionInfo Element_Instantiates;
        // 5. NutritionOrder.status
        public ElementDefinitionInfo Element_Status;
        // 6. NutritionOrder.intent
        public ElementDefinitionInfo Element_Intent;
        // 7. NutritionOrder.patient
        public ElementDefinitionInfo Element_Patient;
        // 8. NutritionOrder.encounter
        public ElementDefinitionInfo Element_Encounter;
        // 9. NutritionOrder.dateTime
        public ElementDefinitionInfo Element_DateTime;
        // 10. NutritionOrder.orderer
        public ElementDefinitionInfo Element_Orderer;
        // 11. NutritionOrder.allergyIntolerance
        public ElementDefinitionInfo Element_AllergyIntolerance;
        // 12. NutritionOrder.foodPreferenceModifier
        public ElementDefinitionInfo Element_FoodPreferenceModifier;
        // 13. NutritionOrder.excludeFoodModifier
        public ElementDefinitionInfo Element_ExcludeFoodModifier;
        // 14. NutritionOrder.oralDiet
        public ElementDefinitionInfo Element_OralDiet;
        // 25. NutritionOrder.supplement
        public ElementDefinitionInfo Element_Supplement;
        // 31. NutritionOrder.enteralFormula
        public ElementDefinitionInfo Element_EnteralFormula;
        // 44. NutritionOrder.note
        public ElementDefinitionInfo Element_Note;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "NutritionOrder",
                ElementId = "NutritionOrder"
            });
            Element_Identifier.Write(sDef);
            Element_InstantiatesCanonical.Write(sDef);
            Element_InstantiatesUri.Write(sDef);
            Element_Instantiates.Write(sDef);
            Element_Status.Write(sDef);
            Element_Intent.Write(sDef);
            Element_Patient.Write(sDef);
            Element_Encounter.Write(sDef);
            Element_DateTime.Write(sDef);
            Element_Orderer.Write(sDef);
            Element_AllergyIntolerance.Write(sDef);
            Element_FoodPreferenceModifier.Write(sDef);
            Element_ExcludeFoodModifier.Write(sDef);
            Element_OralDiet.Write(sDef);
            Element_Supplement.Write(sDef);
            Element_EnteralFormula.Write(sDef);
            Element_Note.Write(sDef);
        }
        
        public Resource_NutritionOrder()
        {
            {
                // 1. NutritionOrder.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "NutritionOrder.identifier",
                    Id = "NutritionOrder.identifier",
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
                // 2. NutritionOrder.instantiatesCanonical
                this.Element_InstantiatesCanonical = new ElementDefinitionInfo
                {
                    Name = "Element_InstantiatesCanonical",
                    Path= "NutritionOrder.instantiatesCanonical",
                    Id = "NutritionOrder.instantiatesCanonical",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Canonical
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/ActivityDefinition",
                                "http://hl7.org/fhir/StructureDefinition/PlanDefinition"
                            }
                        }
                    }
                };
            }
            {
                // 3. NutritionOrder.instantiatesUri
                this.Element_InstantiatesUri = new ElementDefinitionInfo
                {
                    Name = "Element_InstantiatesUri",
                    Path= "NutritionOrder.instantiatesUri",
                    Id = "NutritionOrder.instantiatesUri",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uri
                        {
                        }
                    }
                };
            }
            {
                // 4. NutritionOrder.instantiates
                this.Element_Instantiates = new ElementDefinitionInfo
                {
                    Name = "Element_Instantiates",
                    Path= "NutritionOrder.instantiates",
                    Id = "NutritionOrder.instantiates",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uri
                        {
                        }
                    }
                };
            }
            {
                // 5. NutritionOrder.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "NutritionOrder.status",
                    Id = "NutritionOrder.status",
                    Min = 1,
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
                // 6. NutritionOrder.intent
                this.Element_Intent = new ElementDefinitionInfo
                {
                    Name = "Element_Intent",
                    Path= "NutritionOrder.intent",
                    Id = "NutritionOrder.intent",
                    Min = 1,
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
                // 7. NutritionOrder.patient
                this.Element_Patient = new ElementDefinitionInfo
                {
                    Name = "Element_Patient",
                    Path= "NutritionOrder.patient",
                    Id = "NutritionOrder.patient",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Patient"
                            }
                        }
                    }
                };
            }
            {
                // 8. NutritionOrder.encounter
                this.Element_Encounter = new ElementDefinitionInfo
                {
                    Name = "Element_Encounter",
                    Path= "NutritionOrder.encounter",
                    Id = "NutritionOrder.encounter",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Encounter"
                            }
                        }
                    }
                };
            }
            {
                // 9. NutritionOrder.dateTime
                this.Element_DateTime = new ElementDefinitionInfo
                {
                    Name = "Element_DateTime",
                    Path= "NutritionOrder.dateTime",
                    Id = "NutritionOrder.dateTime",
                    Min = 1,
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
                // 10. NutritionOrder.orderer
                this.Element_Orderer = new ElementDefinitionInfo
                {
                    Name = "Element_Orderer",
                    Path= "NutritionOrder.orderer",
                    Id = "NutritionOrder.orderer",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                            }
                        }
                    }
                };
            }
            {
                // 11. NutritionOrder.allergyIntolerance
                this.Element_AllergyIntolerance = new ElementDefinitionInfo
                {
                    Name = "Element_AllergyIntolerance",
                    Path= "NutritionOrder.allergyIntolerance",
                    Id = "NutritionOrder.allergyIntolerance",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/AllergyIntolerance"
                            }
                        }
                    }
                };
            }
            {
                // 12. NutritionOrder.foodPreferenceModifier
                this.Element_FoodPreferenceModifier = new ElementDefinitionInfo
                {
                    Name = "Element_FoodPreferenceModifier",
                    Path= "NutritionOrder.foodPreferenceModifier",
                    Id = "NutritionOrder.foodPreferenceModifier",
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
                // 13. NutritionOrder.excludeFoodModifier
                this.Element_ExcludeFoodModifier = new ElementDefinitionInfo
                {
                    Name = "Element_ExcludeFoodModifier",
                    Path= "NutritionOrder.excludeFoodModifier",
                    Id = "NutritionOrder.excludeFoodModifier",
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
                // 14. NutritionOrder.oralDiet
                this.Element_OralDiet = new ElementDefinitionInfo
                {
                    Name = "Element_OralDiet",
                    Path= "NutritionOrder.oralDiet",
                    Id = "NutritionOrder.oralDiet",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_OralDiet
                        {
                        }
                    }
                };
            }
            {
                // 25. NutritionOrder.supplement
                this.Element_Supplement = new ElementDefinitionInfo
                {
                    Name = "Element_Supplement",
                    Path= "NutritionOrder.supplement",
                    Id = "NutritionOrder.supplement",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Supplement
                        {
                        }
                    }
                };
            }
            {
                // 31. NutritionOrder.enteralFormula
                this.Element_EnteralFormula = new ElementDefinitionInfo
                {
                    Name = "Element_EnteralFormula",
                    Path= "NutritionOrder.enteralFormula",
                    Id = "NutritionOrder.enteralFormula",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_EnteralFormula
                        {
                        }
                    }
                };
            }
            {
                // 44. NutritionOrder.note
                this.Element_Note = new ElementDefinitionInfo
                {
                    Name = "Element_Note",
                    Path= "NutritionOrder.note",
                    Id = "NutritionOrder.note",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Annotation
                        {
                        }
                    }
                };
            }
            this.Name = "NutritionOrder";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/NutritionOrder";
        }
    }
}
