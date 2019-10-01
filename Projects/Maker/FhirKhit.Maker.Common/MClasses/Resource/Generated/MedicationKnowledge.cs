using System;                                                                                                                               // MakerGen.cs:451
using System.Diagnostics;                                                                                                                   // MakerGen.cs:452
using System.IO;                                                                                                                            // MakerGen.cs:453
using System.Linq;                                                                                                                          // MakerGen.cs:454
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:455
                                                                                                                                            // MakerGen.cs:456
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:457
{                                                                                                                                           // MakerGen.cs:458
    #region Json                                                                                                                            // MakerGen.cs:459
    #if NEVER                                                                                                                               // MakerGen.cs:460
    {
      "resourceType": "StructureDefinition",
      "id": "MedicationKnowledge",
      "url": "http://hl7.org/fhir/StructureDefinition/MedicationKnowledge",
      "version": "4.0.0",
      "name": "MedicationKnowledge",
      "status": "draft",
      "publisher": "Health Level Seven International (Pharmacy)",
      "description": "Information about a medication that is used to support knowledge.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "MedicationKnowledge",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "MedicationKnowledge",
            "path": "MedicationKnowledge",
            "short": "Definition of Medication Knowledge",
            "definition": "Information about a medication that is used to support knowledge.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "MedicationKnowledge.code",
            "path": "MedicationKnowledge.code",
            "short": "Code that identifies this medication",
            "definition": "A code that specifies this medication, or a textual description if no code is available. Usage note: This could be a standard medication code such as a code from RxNorm, SNOMED CT, IDMP etc. It could also be a national or local formulary code, optionally with translations to other code systems.",
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
            "id": "MedicationKnowledge.status",
            "path": "MedicationKnowledge.status",
            "short": "active | inactive | entered-in-error",
            "definition": "A code to indicate if the medication is in active use.  The status refers to the validity about the information of the medication and not to its medicinal properties.",
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
                  "valueString": "MedicationKnowledgeStatus"
                }
              ],
              "strength": "required",
              "description": "A coded concept defining if the medication is in active use.",
              "valueSet": "http://hl7.org/fhir/ValueSet/medicationknowledge-status|4.0.0"
            }
          },
          {
            "id": "MedicationKnowledge.manufacturer",
            "path": "MedicationKnowledge.manufacturer",
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
            "id": "MedicationKnowledge.doseForm",
            "path": "MedicationKnowledge.doseForm",
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
            "id": "MedicationKnowledge.amount",
            "path": "MedicationKnowledge.amount",
            "short": "Amount of drug in package",
            "definition": "Specific amount of the drug in the packaged product.  For example, when specifying a product that has the same strength (For example, Insulin glargine 100 unit per mL solution for injection), this attribute provides additional clarification of the package amount (For example, 3 mL, 10mL, etc.).",
            "comment": "This is the quantity of medication in a package.  To specify the strength of the medication, the Ingredient.strength attribute is used.",
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
            "id": "MedicationKnowledge.synonym",
            "path": "MedicationKnowledge.synonym",
            "short": "Additional names for a medication",
            "definition": "Additional names for a medication, for example, the name(s) given to a medication in different countries.  For example, acetaminophen and paracetamol or salbutamol and albuterol.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicationKnowledge.relatedMedicationKnowledge",
            "path": "MedicationKnowledge.relatedMedicationKnowledge",
            "short": "Associated or related medication information",
            "definition": "Associated or related knowledge about a medication.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "MedicationKnowledge.relatedMedicationKnowledge.type",
            "path": "MedicationKnowledge.relatedMedicationKnowledge.type",
            "short": "Category of medicationKnowledge",
            "definition": "The category of the associated medication knowledge reference.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "MedicationKnowledge.relatedMedicationKnowledge.reference",
            "path": "MedicationKnowledge.relatedMedicationKnowledge.reference",
            "short": "Associated documentation about the associated medication knowledge",
            "definition": "Associated documentation about the associated medication knowledge.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/MedicationKnowledge"
                ]
              }
            ]
          },
          {
            "id": "MedicationKnowledge.associatedMedication",
            "path": "MedicationKnowledge.associatedMedication",
            "short": "A medication resource that is associated with this medication",
            "definition": "Associated or related medications.  For example, if the medication is a branded product (e.g. Crestor), this is the Therapeutic Moeity (e.g. Rosuvastatin) or if this is a generic medication (e.g. Rosuvastatin), this would link to a branded product (e.g. Crestor).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Medication"
                ]
              }
            ]
          },
          {
            "id": "MedicationKnowledge.productType",
            "path": "MedicationKnowledge.productType",
            "short": "Category of the medication or product",
            "definition": "Category of the medication or product (e.g. branded product, therapeutic moeity, generic product, innovator product, etc.).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "MedicationKnowledge.monograph",
            "path": "MedicationKnowledge.monograph",
            "short": "Associated documentation about the medication",
            "definition": "Associated documentation about the medication.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "MedicationKnowledge.monograph.type",
            "path": "MedicationKnowledge.monograph.type",
            "short": "The category of medication document",
            "definition": "The category of documentation about the medication. (e.g. professional monograph, patient education monograph).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "MedicationKnowledge.monograph.source",
            "path": "MedicationKnowledge.monograph.source",
            "short": "Associated documentation about the medication",
            "definition": "Associated documentation about the medication.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/DocumentReference",
                  "http://hl7.org/fhir/StructureDefinition/Media"
                ]
              }
            ]
          },
          {
            "id": "MedicationKnowledge.ingredient",
            "path": "MedicationKnowledge.ingredient",
            "short": "Active or inactive ingredient",
            "definition": "Identifies a particular constituent of interest in the product.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "MedicationKnowledge.ingredient.item[x]",
            "path": "MedicationKnowledge.ingredient.item[x]",
            "short": "Medication(s) or substance(s) contained in the medication",
            "definition": "The actual ingredient - either a substance (simple ingredient) or another medication.",
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
            ]
          },
          {
            "id": "MedicationKnowledge.ingredient.isActive",
            "path": "MedicationKnowledge.ingredient.isActive",
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
            "id": "MedicationKnowledge.ingredient.strength",
            "path": "MedicationKnowledge.ingredient.strength",
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
            "id": "MedicationKnowledge.preparationInstruction",
            "path": "MedicationKnowledge.preparationInstruction",
            "short": "The instructions for preparing the medication",
            "definition": "The instructions for preparing the medication.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "MedicationKnowledge.intendedRoute",
            "path": "MedicationKnowledge.intendedRoute",
            "short": "The intended or approved route of administration",
            "definition": "The intended or approved route of administration.",
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
                  "valueString": "MedicationRoute"
                }
              ],
              "strength": "example",
              "description": "A coded concept defining the intended route of administration.",
              "valueSet": "http://hl7.org/fhir/ValueSet/route-codes"
            }
          },
          {
            "id": "MedicationKnowledge.cost",
            "path": "MedicationKnowledge.cost",
            "short": "The pricing of the medication",
            "definition": "The price of the medication.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "MedicationKnowledge.cost.type",
            "path": "MedicationKnowledge.cost.type",
            "short": "The category of the cost information",
            "definition": "The category of the cost information.  For example, manufacturers' cost, patient cost, claim reimbursement cost, actual acquisition cost.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "MedicationKnowledge.cost.source",
            "path": "MedicationKnowledge.cost.source",
            "short": "The source or owner for the price information",
            "definition": "The source or owner that assigns the price to the medication.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "MedicationKnowledge.cost.cost",
            "path": "MedicationKnowledge.cost.cost",
            "short": "The price of the medication",
            "definition": "The price of the medication.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Money"
              }
            ]
          },
          {
            "id": "MedicationKnowledge.monitoringProgram",
            "path": "MedicationKnowledge.monitoringProgram",
            "short": "Program under which a medication is reviewed",
            "definition": "The program under which the medication is reviewed.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "MedicationKnowledge.monitoringProgram.type",
            "path": "MedicationKnowledge.monitoringProgram.type",
            "short": "Type of program under which the medication is monitored",
            "definition": "Type of program under which the medication is monitored.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "MedicationKnowledge.monitoringProgram.name",
            "path": "MedicationKnowledge.monitoringProgram.name",
            "short": "Name of the reviewing program",
            "definition": "Name of the reviewing program.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "MedicationKnowledge.administrationGuidelines",
            "path": "MedicationKnowledge.administrationGuidelines",
            "short": "Guidelines for administration of the medication",
            "definition": "Guidelines for the administration of the medication.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "MedicationKnowledge.administrationGuidelines.dosage",
            "path": "MedicationKnowledge.administrationGuidelines.dosage",
            "short": "Dosage for the medication for the specific guidelines",
            "definition": "Dosage for the medication for the specific guidelines.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "MedicationKnowledge.administrationGuidelines.dosage.type",
            "path": "MedicationKnowledge.administrationGuidelines.dosage.type",
            "short": "Type of dosage",
            "definition": "The type of dosage (for example, prophylaxis, maintenance, therapeutic, etc.).",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "MedicationKnowledge.administrationGuidelines.dosage.dosage",
            "path": "MedicationKnowledge.administrationGuidelines.dosage.dosage",
            "short": "Dosage for the medication for the specific guidelines",
            "definition": "Dosage for the medication for the specific guidelines.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "Dosage"
              }
            ]
          },
          {
            "id": "MedicationKnowledge.administrationGuidelines.indication[x]",
            "path": "MedicationKnowledge.administrationGuidelines.indication[x]",
            "short": "Indication for use that apply to the specific administration guidelines",
            "definition": "Indication for use that apply to the specific administration guidelines.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ObservationDefinition"
                ]
              }
            ]
          },
          {
            "id": "MedicationKnowledge.administrationGuidelines.patientCharacteristics",
            "path": "MedicationKnowledge.administrationGuidelines.patientCharacteristics",
            "short": "Characteristics of the patient that are relevant to the administration guidelines",
            "definition": "Characteristics of the patient that are relevant to the administration guidelines (for example, height, weight, gender, etc.).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "MedicationKnowledge.administrationGuidelines.patientCharacteristics.characteristic[x]",
            "path": "MedicationKnowledge.administrationGuidelines.patientCharacteristics.characteristic[x]",
            "short": "Specific characteristic that is relevant to the administration guideline",
            "definition": "Specific characteristic that is relevant to the administration guideline (e.g. height, weight, gender).",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              },
              {
                "code": "Quantity",
                "profile": [
                  "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
                ]
              }
            ]
          },
          {
            "id": "MedicationKnowledge.administrationGuidelines.patientCharacteristics.value",
            "path": "MedicationKnowledge.administrationGuidelines.patientCharacteristics.value",
            "short": "The specific characteristic",
            "definition": "The specific characteristic (e.g. height, weight, gender, etc.).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "MedicationKnowledge.medicineClassification",
            "path": "MedicationKnowledge.medicineClassification",
            "short": "Categorization of the medication within a formulary or classification system",
            "definition": "Categorization of the medication within a formulary or classification system.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "MedicationKnowledge.medicineClassification.type",
            "path": "MedicationKnowledge.medicineClassification.type",
            "short": "The type of category for the medication (for example, therapeutic classification, therapeutic sub-classification)",
            "definition": "The type of category for the medication (for example, therapeutic classification, therapeutic sub-classification).",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "MedicationKnowledge.medicineClassification.classification",
            "path": "MedicationKnowledge.medicineClassification.classification",
            "short": "Specific category assigned to the medication",
            "definition": "Specific category assigned to the medication (e.g. anti-infective, anti-hypertensive, antibiotic, etc.).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "MedicationKnowledge.packaging",
            "path": "MedicationKnowledge.packaging",
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
            "id": "MedicationKnowledge.packaging.type",
            "path": "MedicationKnowledge.packaging.type",
            "short": "A code that defines the specific type of packaging that the medication can be found in",
            "definition": "A code that defines the specific type of packaging that the medication can be found in (e.g. blister sleeve, tube, bottle).",
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
                  "valueString": "MedicationPackageType"
                }
              ],
              "strength": "example",
              "description": "A coded concept defining the type of packaging of a medication.",
              "valueSet": "http://hl7.org/fhir/ValueSet/medicationknowledge-package-type"
            }
          },
          {
            "id": "MedicationKnowledge.packaging.quantity",
            "path": "MedicationKnowledge.packaging.quantity",
            "short": "The number of product units the package would contain if fully loaded",
            "definition": "The number of product units the package would contain if fully loaded.",
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
            "id": "MedicationKnowledge.drugCharacteristic",
            "path": "MedicationKnowledge.drugCharacteristic",
            "short": "Specifies descriptive properties of the medicine",
            "definition": "Specifies descriptive properties of the medicine, such as color, shape, imprints, etc.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "MedicationKnowledge.drugCharacteristic.type",
            "path": "MedicationKnowledge.drugCharacteristic.type",
            "short": "Code specifying the type of characteristic of medication",
            "definition": "A code specifying which characteristic of the medicine is being described (for example, colour, shape, imprint).",
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
                  "valueString": "MedicationCharacteristic"
                }
              ],
              "strength": "example",
              "description": "A coded concept defining the characteristic types of a medication.",
              "valueSet": "http://hl7.org/fhir/ValueSet/medicationknowledge-characteristic"
            }
          },
          {
            "id": "MedicationKnowledge.drugCharacteristic.value[x]",
            "path": "MedicationKnowledge.drugCharacteristic.value[x]",
            "short": "Description of the characteristic",
            "definition": "Description of the characteristic.",
            "comment": "The description should be provided as a CodeableConcept, SimpleQuantity or an image.  The description can be a string only when these others are not available.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              },
              {
                "code": "string"
              },
              {
                "code": "Quantity",
                "profile": [
                  "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
                ]
              },
              {
                "code": "base64Binary"
              }
            ]
          },
          {
            "id": "MedicationKnowledge.contraindication",
            "path": "MedicationKnowledge.contraindication",
            "short": "Potential clinical issue with or between medication(s)",
            "definition": "Potential clinical issue with or between medication(s) (for example, drug-drug interaction, drug-disease contraindication, drug-allergy interaction, etc.).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/DetectedIssue"
                ]
              }
            ]
          },
          {
            "id": "MedicationKnowledge.regulatory",
            "path": "MedicationKnowledge.regulatory",
            "short": "Regulatory information about a medication",
            "definition": "Regulatory information about a medication.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "MedicationKnowledge.regulatory.regulatoryAuthority",
            "path": "MedicationKnowledge.regulatory.regulatoryAuthority",
            "short": "Specifies the authority of the regulation",
            "definition": "The authority that is specifying the regulations.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ]
          },
          {
            "id": "MedicationKnowledge.regulatory.substitution",
            "path": "MedicationKnowledge.regulatory.substitution",
            "short": "Specifies if changes are allowed when dispensing a medication from a regulatory perspective",
            "definition": "Specifies if changes are allowed when dispensing a medication from a regulatory perspective.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "MedicationKnowledge.regulatory.substitution.type",
            "path": "MedicationKnowledge.regulatory.substitution.type",
            "short": "Specifies the type of substitution allowed",
            "definition": "Specifies the type of substitution allowed.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "MedicationKnowledge.regulatory.substitution.allowed",
            "path": "MedicationKnowledge.regulatory.substitution.allowed",
            "short": "Specifies if regulation allows for changes in the medication when dispensing",
            "definition": "Specifies if regulation allows for changes in the medication when dispensing.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "MedicationKnowledge.regulatory.schedule",
            "path": "MedicationKnowledge.regulatory.schedule",
            "short": "Specifies the schedule of a medication in jurisdiction",
            "definition": "Specifies the schedule of a medication in jurisdiction.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "MedicationKnowledge.regulatory.schedule.schedule",
            "path": "MedicationKnowledge.regulatory.schedule.schedule",
            "short": "Specifies the specific drug schedule",
            "definition": "Specifies the specific drug schedule.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "MedicationKnowledge.regulatory.maxDispense",
            "path": "MedicationKnowledge.regulatory.maxDispense",
            "short": "The maximum number of units of the medication that can be dispensed in a period",
            "definition": "The maximum number of units of the medication that can be dispensed in a period.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "MedicationKnowledge.regulatory.maxDispense.quantity",
            "path": "MedicationKnowledge.regulatory.maxDispense.quantity",
            "short": "The maximum number of units of the medication that can be dispensed",
            "definition": "The maximum number of units of the medication that can be dispensed.",
            "min": 1,
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
            "id": "MedicationKnowledge.regulatory.maxDispense.period",
            "path": "MedicationKnowledge.regulatory.maxDispense.period",
            "short": "The period that applies to the maximum number of units",
            "definition": "The period that applies to the maximum number of units.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Duration"
              }
            ]
          },
          {
            "id": "MedicationKnowledge.kinetics",
            "path": "MedicationKnowledge.kinetics",
            "short": "The time course of drug absorption, distribution, metabolism and excretion of a medication from the body",
            "definition": "The time course of drug absorption, distribution, metabolism and excretion of a medication from the body.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "MedicationKnowledge.kinetics.areaUnderCurve",
            "path": "MedicationKnowledge.kinetics.areaUnderCurve",
            "short": "The drug concentration measured at certain discrete points in time",
            "definition": "The drug concentration measured at certain discrete points in time.",
            "min": 0,
            "max": "*",
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
            "id": "MedicationKnowledge.kinetics.lethalDose50",
            "path": "MedicationKnowledge.kinetics.lethalDose50",
            "short": "The median lethal dose of a drug",
            "definition": "The median lethal dose of a drug.",
            "min": 0,
            "max": "*",
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
            "id": "MedicationKnowledge.kinetics.halfLifePeriod",
            "path": "MedicationKnowledge.kinetics.halfLifePeriod",
            "short": "Time required for concentration in the body to decrease by half",
            "definition": "The time required for any specified property (e.g., the concentration of a substance in the body) to decrease by half.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Duration"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:463
    /// <summary>
    /// Fhir resource 'MedicationKnowledge'
    /// </summary>
    // 0. MedicationKnowledge
    public class MedicationKnowledge : FhirKhit.Maker.Common.Resource.ResourceBase                                                          // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class MedicationKnowledge_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                             // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 7. MedicationKnowledge.relatedMedicationKnowledge
            public class Type_RelatedMedicationKnowledge : FhirKhit.Maker.Common.Complex.ComplexBase                                        // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_RelatedMedicationKnowledge_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                         // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 8. MedicationKnowledge.relatedMedicationKnowledge.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:236
                    // 9. MedicationKnowledge.relatedMedicationKnowledge.reference
                    public ElementDefinitionInfo Reference;                                                                                 // MakerGen.cs:236
                    public Type_RelatedMedicationKnowledge_Elements()                                                                       // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 8. MedicationKnowledge.relatedMedicationKnowledge.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Type",                                                                                              // MakerGen.cs:255
                                Path= "MedicationKnowledge.relatedMedicationKnowledge.type",                                                // MakerGen.cs:256
                                Id = "MedicationKnowledge.relatedMedicationKnowledge.type",                                                 // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 9. MedicationKnowledge.relatedMedicationKnowledge.reference
                            this.Reference = new ElementDefinitionInfo                                                                      // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Reference",                                                                                         // MakerGen.cs:255
                                Path= "MedicationKnowledge.relatedMedicationKnowledge.reference",                                           // MakerGen.cs:256
                                Id = "MedicationKnowledge.relatedMedicationKnowledge.reference",                                            // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/MedicationKnowledge"                                   // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Reference.Write(sDef);                                                                                              // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_RelatedMedicationKnowledge_Elements Elements { get; }                                                           // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_RelatedMedicationKnowledge()                                                                                    // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_RelatedMedicationKnowledge_Elements();                                                         // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 12. MedicationKnowledge.monograph
            public class Type_Monograph : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Monograph_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                          // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 13. MedicationKnowledge.monograph.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:236
                    // 14. MedicationKnowledge.monograph.source
                    public ElementDefinitionInfo Source;                                                                                    // MakerGen.cs:236
                    public Type_Monograph_Elements()                                                                                        // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 13. MedicationKnowledge.monograph.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Type",                                                                                              // MakerGen.cs:255
                                Path= "MedicationKnowledge.monograph.type",                                                                 // MakerGen.cs:256
                                Id = "MedicationKnowledge.monograph.type",                                                                  // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 14. MedicationKnowledge.monograph.source
                            this.Source = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Source",                                                                                            // MakerGen.cs:255
                                Path= "MedicationKnowledge.monograph.source",                                                               // MakerGen.cs:256
                                Id = "MedicationKnowledge.monograph.source",                                                                // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/DocumentReference",                                    // MakerGen.cs:348
                                            "http://hl7.org/fhir/StructureDefinition/Media"                                                 // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Source.Write(sDef);                                                                                                 // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Monograph_Elements Elements { get; }                                                                            // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Monograph()                                                                                                     // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Monograph_Elements();                                                                          // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 15. MedicationKnowledge.ingredient
            public class Type_Ingredient : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Ingredient_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                         // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 16. MedicationKnowledge.ingredient.item[x]
                    public ElementDefinitionInfo Item;                                                                                      // MakerGen.cs:236
                    // 17. MedicationKnowledge.ingredient.isActive
                    public ElementDefinitionInfo IsActive;                                                                                  // MakerGen.cs:236
                    // 18. MedicationKnowledge.ingredient.strength
                    public ElementDefinitionInfo Strength;                                                                                  // MakerGen.cs:236
                    public Type_Ingredient_Elements()                                                                                       // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 16. MedicationKnowledge.ingredient.item[x]
                            this.Item = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Item",                                                                                              // MakerGen.cs:255
                                Path= "MedicationKnowledge.ingredient.item[x]",                                                             // MakerGen.cs:256
                                Id = "MedicationKnowledge.ingredient.item[x]",                                                              // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    },                                                                                                      // MakerGen.cs:318
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Substance"                                             // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 17. MedicationKnowledge.ingredient.isActive
                            this.IsActive = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "IsActive",                                                                                          // MakerGen.cs:255
                                Path= "MedicationKnowledge.ingredient.isActive",                                                            // MakerGen.cs:256
                                Id = "MedicationKnowledge.ingredient.isActive",                                                             // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 18. MedicationKnowledge.ingredient.strength
                            this.Strength = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Strength",                                                                                          // MakerGen.cs:255
                                Path= "MedicationKnowledge.ingredient.strength",                                                            // MakerGen.cs:256
                                Id = "MedicationKnowledge.ingredient.strength",                                                             // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Ratio                                                                 // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Item.Write(sDef);                                                                                                   // MakerGen.cs:240
                        IsActive.Write(sDef);                                                                                               // MakerGen.cs:240
                        Strength.Write(sDef);                                                                                               // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Ingredient_Elements Elements { get; }                                                                           // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Ingredient()                                                                                                    // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Ingredient_Elements();                                                                         // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 21. MedicationKnowledge.cost
            public class Type_Cost : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Cost_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                               // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 22. MedicationKnowledge.cost.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:236
                    // 23. MedicationKnowledge.cost.source
                    public ElementDefinitionInfo Source;                                                                                    // MakerGen.cs:236
                    // 24. MedicationKnowledge.cost.cost
                    public ElementDefinitionInfo Cost;                                                                                      // MakerGen.cs:236
                    public Type_Cost_Elements()                                                                                             // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 22. MedicationKnowledge.cost.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Type",                                                                                              // MakerGen.cs:255
                                Path= "MedicationKnowledge.cost.type",                                                                      // MakerGen.cs:256
                                Id = "MedicationKnowledge.cost.type",                                                                       // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 23. MedicationKnowledge.cost.source
                            this.Source = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Source",                                                                                            // MakerGen.cs:255
                                Path= "MedicationKnowledge.cost.source",                                                                    // MakerGen.cs:256
                                Id = "MedicationKnowledge.cost.source",                                                                     // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 24. MedicationKnowledge.cost.cost
                            this.Cost = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Cost",                                                                                              // MakerGen.cs:255
                                Path= "MedicationKnowledge.cost.cost",                                                                      // MakerGen.cs:256
                                Id = "MedicationKnowledge.cost.cost",                                                                       // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Money                                                                 // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Source.Write(sDef);                                                                                                 // MakerGen.cs:240
                        Cost.Write(sDef);                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Cost_Elements Elements { get; }                                                                                 // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Cost()                                                                                                          // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Cost_Elements();                                                                               // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 25. MedicationKnowledge.monitoringProgram
            public class Type_MonitoringProgram : FhirKhit.Maker.Common.Complex.ComplexBase                                                 // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_MonitoringProgram_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                  // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 26. MedicationKnowledge.monitoringProgram.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:236
                    // 27. MedicationKnowledge.monitoringProgram.name
                    public ElementDefinitionInfo Name;                                                                                      // MakerGen.cs:236
                    public Type_MonitoringProgram_Elements()                                                                                // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 26. MedicationKnowledge.monitoringProgram.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Type",                                                                                              // MakerGen.cs:255
                                Path= "MedicationKnowledge.monitoringProgram.type",                                                         // MakerGen.cs:256
                                Id = "MedicationKnowledge.monitoringProgram.type",                                                          // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 27. MedicationKnowledge.monitoringProgram.name
                            this.Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Name",                                                                                              // MakerGen.cs:255
                                Path= "MedicationKnowledge.monitoringProgram.name",                                                         // MakerGen.cs:256
                                Id = "MedicationKnowledge.monitoringProgram.name",                                                          // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Name.Write(sDef);                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_MonitoringProgram_Elements Elements { get; }                                                                    // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_MonitoringProgram()                                                                                             // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_MonitoringProgram_Elements();                                                                  // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 28. MedicationKnowledge.administrationGuidelines
            public class Type_AdministrationGuidelines : FhirKhit.Maker.Common.Complex.ComplexBase                                          // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_AdministrationGuidelines_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                           // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 29. MedicationKnowledge.administrationGuidelines.dosage
                    public class Type_Dosage : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:385
                    {                                                                                                                       // MakerGen.cs:386
                        public class Type_Dosage_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                     // MakerGen.cs:387
                        {                                                                                                                   // MakerGen.cs:388
                            // 30. MedicationKnowledge.administrationGuidelines.dosage.type
                            public ElementDefinitionInfo Type;                                                                              // MakerGen.cs:236
                            // 31. MedicationKnowledge.administrationGuidelines.dosage.dosage
                            public ElementDefinitionInfo Dosage;                                                                            // MakerGen.cs:236
                            public Type_Dosage_Elements()                                                                                   // MakerGen.cs:409
                            {                                                                                                               // MakerGen.cs:410
                                {                                                                                                           // MakerGen.cs:251
                                    // 30. MedicationKnowledge.administrationGuidelines.dosage.type
                                    this.Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Type",                                                                                      // MakerGen.cs:255
                                        Path= "MedicationKnowledge.administrationGuidelines.dosage.type",                                   // MakerGen.cs:256
                                        Id = "MedicationKnowledge.administrationGuidelines.dosage.type",                                    // MakerGen.cs:257
                                        Min = 1,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:314
                                            {                                                                                               // MakerGen.cs:315
                                            }                                                                                               // MakerGen.cs:318
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 31. MedicationKnowledge.administrationGuidelines.dosage.dosage
                                    this.Dosage = new ElementDefinitionInfo                                                                 // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Dosage",                                                                                    // MakerGen.cs:255
                                        Path= "MedicationKnowledge.administrationGuidelines.dosage.dosage",                                 // MakerGen.cs:256
                                        Id = "MedicationKnowledge.administrationGuidelines.dosage.dosage",                                  // MakerGen.cs:257
                                        Min = 1,                                                                                            // MakerGen.cs:258
                                        Max = -1,                                                                                           // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.Dosage                                                        // MakerGen.cs:357
                                            {                                                                                               // MakerGen.cs:358
                                            }                                                                                               // MakerGen.cs:359
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                            }                                                                                                               // MakerGen.cs:429
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:414
                            {                                                                                                               // MakerGen.cs:415
                                base.Write(sDef);                                                                                           // MakerGen.cs:416
                                Type.Write(sDef);                                                                                           // MakerGen.cs:240
                                Dosage.Write(sDef);                                                                                         // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:433
                        }                                                                                                                   // MakerGen.cs:393
                        public Type_Dosage_Elements Elements { get; }                                                                       // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                        public Type_Dosage()                                                                                                // MakerGen.cs:396
                        {                                                                                                                   // MakerGen.cs:397
                            this.Elements = new Type_Dosage_Elements();                                                                     // MakerGen.cs:398
                        }                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:403
                        }                                                                                                                   // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                    // 33. MedicationKnowledge.administrationGuidelines.patientCharacteristics
                    public class Type_PatientCharacteristics : FhirKhit.Maker.Common.Complex.ComplexBase                                    // MakerGen.cs:385
                    {                                                                                                                       // MakerGen.cs:386
                        public class Type_PatientCharacteristics_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                     // MakerGen.cs:387
                        {                                                                                                                   // MakerGen.cs:388
                            // 34. MedicationKnowledge.administrationGuidelines.patientCharacteristics.characteristic[x]
                            public ElementDefinitionInfo Characteristic;                                                                    // MakerGen.cs:236
                            // 35. MedicationKnowledge.administrationGuidelines.patientCharacteristics.value
                            public ElementDefinitionInfo Value;                                                                             // MakerGen.cs:236
                            public Type_PatientCharacteristics_Elements()                                                                   // MakerGen.cs:409
                            {                                                                                                               // MakerGen.cs:410
                                {                                                                                                           // MakerGen.cs:251
                                    // 34. MedicationKnowledge.administrationGuidelines.patientCharacteristics.characteristic[x]
                                    this.Characteristic = new ElementDefinitionInfo                                                         // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Characteristic",                                                                            // MakerGen.cs:255
                                        Path= "MedicationKnowledge.administrationGuidelines.patientCharacteristics.characteristic[x]",      // MakerGen.cs:256
                                        Id = "MedicationKnowledge.administrationGuidelines.patientCharacteristics.characteristic[x]",       // MakerGen.cs:257
                                        Min = 1,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:314
                                            {                                                                                               // MakerGen.cs:315
                                            },                                                                                              // MakerGen.cs:318
                                            new FhirKhit.Maker.Common.Complex.Quantity                                                      // MakerGen.cs:357
                                            {                                                                                               // MakerGen.cs:358
                                            }                                                                                               // MakerGen.cs:359
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 35. MedicationKnowledge.administrationGuidelines.patientCharacteristics.value
                                    this.Value = new ElementDefinitionInfo                                                                  // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Value",                                                                                     // MakerGen.cs:255
                                        Path= "MedicationKnowledge.administrationGuidelines.patientCharacteristics.value",                  // MakerGen.cs:256
                                        Id = "MedicationKnowledge.administrationGuidelines.patientCharacteristics.value",                   // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = -1,                                                                                           // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                            }                                                                                                               // MakerGen.cs:429
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:414
                            {                                                                                                               // MakerGen.cs:415
                                base.Write(sDef);                                                                                           // MakerGen.cs:416
                                Characteristic.Write(sDef);                                                                                 // MakerGen.cs:240
                                Value.Write(sDef);                                                                                          // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:433
                        }                                                                                                                   // MakerGen.cs:393
                        public Type_PatientCharacteristics_Elements Elements { get; }                                                       // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                        public Type_PatientCharacteristics()                                                                                // MakerGen.cs:396
                        {                                                                                                                   // MakerGen.cs:397
                            this.Elements = new Type_PatientCharacteristics_Elements();                                                     // MakerGen.cs:398
                        }                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:403
                        }                                                                                                                   // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                    // 32. MedicationKnowledge.administrationGuidelines.indication[x]
                    public ElementDefinitionInfo Indication;                                                                                // MakerGen.cs:236
                    public Type_AdministrationGuidelines_Elements()                                                                         // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 32. MedicationKnowledge.administrationGuidelines.indication[x]
                            this.Indication = new ElementDefinitionInfo                                                                     // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Indication",                                                                                        // MakerGen.cs:255
                                Path= "MedicationKnowledge.administrationGuidelines.indication[x]",                                         // MakerGen.cs:256
                                Id = "MedicationKnowledge.administrationGuidelines.indication[x]",                                          // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    },                                                                                                      // MakerGen.cs:318
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/ObservationDefinition"                                 // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Indication.Write(sDef);                                                                                             // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_AdministrationGuidelines_Elements Elements { get; }                                                             // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_AdministrationGuidelines()                                                                                      // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_AdministrationGuidelines_Elements();                                                           // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 36. MedicationKnowledge.medicineClassification
            public class Type_MedicineClassification : FhirKhit.Maker.Common.Complex.ComplexBase                                            // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_MedicineClassification_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                             // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 37. MedicationKnowledge.medicineClassification.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:236
                    // 38. MedicationKnowledge.medicineClassification.classification
                    public ElementDefinitionInfo Classification;                                                                            // MakerGen.cs:236
                    public Type_MedicineClassification_Elements()                                                                           // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 37. MedicationKnowledge.medicineClassification.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Type",                                                                                              // MakerGen.cs:255
                                Path= "MedicationKnowledge.medicineClassification.type",                                                    // MakerGen.cs:256
                                Id = "MedicationKnowledge.medicineClassification.type",                                                     // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 38. MedicationKnowledge.medicineClassification.classification
                            this.Classification = new ElementDefinitionInfo                                                                 // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Classification",                                                                                    // MakerGen.cs:255
                                Path= "MedicationKnowledge.medicineClassification.classification",                                          // MakerGen.cs:256
                                Id = "MedicationKnowledge.medicineClassification.classification",                                           // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Classification.Write(sDef);                                                                                         // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_MedicineClassification_Elements Elements { get; }                                                               // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_MedicineClassification()                                                                                        // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_MedicineClassification_Elements();                                                             // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 39. MedicationKnowledge.packaging
            public class Type_Packaging : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Packaging_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                          // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 40. MedicationKnowledge.packaging.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:236
                    // 41. MedicationKnowledge.packaging.quantity
                    public ElementDefinitionInfo Quantity;                                                                                  // MakerGen.cs:236
                    public Type_Packaging_Elements()                                                                                        // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 40. MedicationKnowledge.packaging.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Type",                                                                                              // MakerGen.cs:255
                                Path= "MedicationKnowledge.packaging.type",                                                                 // MakerGen.cs:256
                                Id = "MedicationKnowledge.packaging.type",                                                                  // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 41. MedicationKnowledge.packaging.quantity
                            this.Quantity = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Quantity",                                                                                          // MakerGen.cs:255
                                Path= "MedicationKnowledge.packaging.quantity",                                                             // MakerGen.cs:256
                                Id = "MedicationKnowledge.packaging.quantity",                                                              // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Quantity                                                              // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Quantity.Write(sDef);                                                                                               // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Packaging_Elements Elements { get; }                                                                            // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Packaging()                                                                                                     // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Packaging_Elements();                                                                          // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 42. MedicationKnowledge.drugCharacteristic
            public class Type_DrugCharacteristic : FhirKhit.Maker.Common.Complex.ComplexBase                                                // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_DrugCharacteristic_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                 // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 43. MedicationKnowledge.drugCharacteristic.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:236
                    // 44. MedicationKnowledge.drugCharacteristic.value[x]
                    public ElementDefinitionInfo Value;                                                                                     // MakerGen.cs:236
                    public Type_DrugCharacteristic_Elements()                                                                               // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 43. MedicationKnowledge.drugCharacteristic.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Type",                                                                                              // MakerGen.cs:255
                                Path= "MedicationKnowledge.drugCharacteristic.type",                                                        // MakerGen.cs:256
                                Id = "MedicationKnowledge.drugCharacteristic.type",                                                         // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 44. MedicationKnowledge.drugCharacteristic.value[x]
                            this.Value = new ElementDefinitionInfo                                                                          // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Value",                                                                                             // MakerGen.cs:255
                                Path= "MedicationKnowledge.drugCharacteristic.value[x]",                                                    // MakerGen.cs:256
                                Id = "MedicationKnowledge.drugCharacteristic.value[x]",                                                     // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    },                                                                                                      // MakerGen.cs:318
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Complex.Quantity                                                              // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Primitive.Base64Binary                                                        // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Value.Write(sDef);                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_DrugCharacteristic_Elements Elements { get; }                                                                   // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_DrugCharacteristic()                                                                                            // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_DrugCharacteristic_Elements();                                                                 // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 46. MedicationKnowledge.regulatory
            public class Type_Regulatory : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Regulatory_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                         // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 48. MedicationKnowledge.regulatory.substitution
                    public class Type_Substitution : FhirKhit.Maker.Common.Complex.ComplexBase                                              // MakerGen.cs:385
                    {                                                                                                                       // MakerGen.cs:386
                        public class Type_Substitution_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                               // MakerGen.cs:387
                        {                                                                                                                   // MakerGen.cs:388
                            // 49. MedicationKnowledge.regulatory.substitution.type
                            public ElementDefinitionInfo Type;                                                                              // MakerGen.cs:236
                            // 50. MedicationKnowledge.regulatory.substitution.allowed
                            public ElementDefinitionInfo Allowed;                                                                           // MakerGen.cs:236
                            public Type_Substitution_Elements()                                                                             // MakerGen.cs:409
                            {                                                                                                               // MakerGen.cs:410
                                {                                                                                                           // MakerGen.cs:251
                                    // 49. MedicationKnowledge.regulatory.substitution.type
                                    this.Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Type",                                                                                      // MakerGen.cs:255
                                        Path= "MedicationKnowledge.regulatory.substitution.type",                                           // MakerGen.cs:256
                                        Id = "MedicationKnowledge.regulatory.substitution.type",                                            // MakerGen.cs:257
                                        Min = 1,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:314
                                            {                                                                                               // MakerGen.cs:315
                                            }                                                                                               // MakerGen.cs:318
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 50. MedicationKnowledge.regulatory.substitution.allowed
                                    this.Allowed = new ElementDefinitionInfo                                                                // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Allowed",                                                                                   // MakerGen.cs:255
                                        Path= "MedicationKnowledge.regulatory.substitution.allowed",                                        // MakerGen.cs:256
                                        Id = "MedicationKnowledge.regulatory.substitution.allowed",                                         // MakerGen.cs:257
                                        Min = 1,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.Boolean                                                     // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                            }                                                                                                               // MakerGen.cs:429
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:414
                            {                                                                                                               // MakerGen.cs:415
                                base.Write(sDef);                                                                                           // MakerGen.cs:416
                                Type.Write(sDef);                                                                                           // MakerGen.cs:240
                                Allowed.Write(sDef);                                                                                        // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:433
                        }                                                                                                                   // MakerGen.cs:393
                        public Type_Substitution_Elements Elements { get; }                                                                 // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                        public Type_Substitution()                                                                                          // MakerGen.cs:396
                        {                                                                                                                   // MakerGen.cs:397
                            this.Elements = new Type_Substitution_Elements();                                                               // MakerGen.cs:398
                        }                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:403
                        }                                                                                                                   // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                    // 51. MedicationKnowledge.regulatory.schedule
                    public class Type_Schedule : FhirKhit.Maker.Common.Complex.ComplexBase                                                  // MakerGen.cs:385
                    {                                                                                                                       // MakerGen.cs:386
                        public class Type_Schedule_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                   // MakerGen.cs:387
                        {                                                                                                                   // MakerGen.cs:388
                            // 52. MedicationKnowledge.regulatory.schedule.schedule
                            public ElementDefinitionInfo Schedule;                                                                          // MakerGen.cs:236
                            public Type_Schedule_Elements()                                                                                 // MakerGen.cs:409
                            {                                                                                                               // MakerGen.cs:410
                                {                                                                                                           // MakerGen.cs:251
                                    // 52. MedicationKnowledge.regulatory.schedule.schedule
                                    this.Schedule = new ElementDefinitionInfo                                                               // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Schedule",                                                                                  // MakerGen.cs:255
                                        Path= "MedicationKnowledge.regulatory.schedule.schedule",                                           // MakerGen.cs:256
                                        Id = "MedicationKnowledge.regulatory.schedule.schedule",                                            // MakerGen.cs:257
                                        Min = 1,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:314
                                            {                                                                                               // MakerGen.cs:315
                                            }                                                                                               // MakerGen.cs:318
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                            }                                                                                                               // MakerGen.cs:429
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:414
                            {                                                                                                               // MakerGen.cs:415
                                base.Write(sDef);                                                                                           // MakerGen.cs:416
                                Schedule.Write(sDef);                                                                                       // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:433
                        }                                                                                                                   // MakerGen.cs:393
                        public Type_Schedule_Elements Elements { get; }                                                                     // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                        public Type_Schedule()                                                                                              // MakerGen.cs:396
                        {                                                                                                                   // MakerGen.cs:397
                            this.Elements = new Type_Schedule_Elements();                                                                   // MakerGen.cs:398
                        }                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:403
                        }                                                                                                                   // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                    // 53. MedicationKnowledge.regulatory.maxDispense
                    public class Type_MaxDispense : FhirKhit.Maker.Common.Complex.ComplexBase                                               // MakerGen.cs:385
                    {                                                                                                                       // MakerGen.cs:386
                        public class Type_MaxDispense_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                // MakerGen.cs:387
                        {                                                                                                                   // MakerGen.cs:388
                            // 54. MedicationKnowledge.regulatory.maxDispense.quantity
                            public ElementDefinitionInfo Quantity;                                                                          // MakerGen.cs:236
                            // 55. MedicationKnowledge.regulatory.maxDispense.period
                            public ElementDefinitionInfo Period;                                                                            // MakerGen.cs:236
                            public Type_MaxDispense_Elements()                                                                              // MakerGen.cs:409
                            {                                                                                                               // MakerGen.cs:410
                                {                                                                                                           // MakerGen.cs:251
                                    // 54. MedicationKnowledge.regulatory.maxDispense.quantity
                                    this.Quantity = new ElementDefinitionInfo                                                               // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Quantity",                                                                                  // MakerGen.cs:255
                                        Path= "MedicationKnowledge.regulatory.maxDispense.quantity",                                        // MakerGen.cs:256
                                        Id = "MedicationKnowledge.regulatory.maxDispense.quantity",                                         // MakerGen.cs:257
                                        Min = 1,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.Quantity                                                      // MakerGen.cs:357
                                            {                                                                                               // MakerGen.cs:358
                                            }                                                                                               // MakerGen.cs:359
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 55. MedicationKnowledge.regulatory.maxDispense.period
                                    this.Period = new ElementDefinitionInfo                                                                 // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Period",                                                                                    // MakerGen.cs:255
                                        Path= "MedicationKnowledge.regulatory.maxDispense.period",                                          // MakerGen.cs:256
                                        Id = "MedicationKnowledge.regulatory.maxDispense.period",                                           // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.Duration                                                      // MakerGen.cs:357
                                            {                                                                                               // MakerGen.cs:358
                                            }                                                                                               // MakerGen.cs:359
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                            }                                                                                                               // MakerGen.cs:429
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:414
                            {                                                                                                               // MakerGen.cs:415
                                base.Write(sDef);                                                                                           // MakerGen.cs:416
                                Quantity.Write(sDef);                                                                                       // MakerGen.cs:240
                                Period.Write(sDef);                                                                                         // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:433
                        }                                                                                                                   // MakerGen.cs:393
                        public Type_MaxDispense_Elements Elements { get; }                                                                  // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                        public Type_MaxDispense()                                                                                           // MakerGen.cs:396
                        {                                                                                                                   // MakerGen.cs:397
                            this.Elements = new Type_MaxDispense_Elements();                                                                // MakerGen.cs:398
                        }                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:403
                        }                                                                                                                   // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                    // 47. MedicationKnowledge.regulatory.regulatoryAuthority
                    public ElementDefinitionInfo RegulatoryAuthority;                                                                       // MakerGen.cs:236
                    public Type_Regulatory_Elements()                                                                                       // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 47. MedicationKnowledge.regulatory.regulatoryAuthority
                            this.RegulatoryAuthority = new ElementDefinitionInfo                                                            // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "RegulatoryAuthority",                                                                               // MakerGen.cs:255
                                Path= "MedicationKnowledge.regulatory.regulatoryAuthority",                                                 // MakerGen.cs:256
                                Id = "MedicationKnowledge.regulatory.regulatoryAuthority",                                                  // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Organization"                                          // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        RegulatoryAuthority.Write(sDef);                                                                                    // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Regulatory_Elements Elements { get; }                                                                           // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Regulatory()                                                                                                    // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Regulatory_Elements();                                                                         // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 56. MedicationKnowledge.kinetics
            public class Type_Kinetics : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Kinetics_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                           // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 57. MedicationKnowledge.kinetics.areaUnderCurve
                    public ElementDefinitionInfo AreaUnderCurve;                                                                            // MakerGen.cs:236
                    // 58. MedicationKnowledge.kinetics.lethalDose50
                    public ElementDefinitionInfo LethalDose50;                                                                              // MakerGen.cs:236
                    // 59. MedicationKnowledge.kinetics.halfLifePeriod
                    public ElementDefinitionInfo HalfLifePeriod;                                                                            // MakerGen.cs:236
                    public Type_Kinetics_Elements()                                                                                         // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 57. MedicationKnowledge.kinetics.areaUnderCurve
                            this.AreaUnderCurve = new ElementDefinitionInfo                                                                 // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "AreaUnderCurve",                                                                                    // MakerGen.cs:255
                                Path= "MedicationKnowledge.kinetics.areaUnderCurve",                                                        // MakerGen.cs:256
                                Id = "MedicationKnowledge.kinetics.areaUnderCurve",                                                         // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Quantity                                                              // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 58. MedicationKnowledge.kinetics.lethalDose50
                            this.LethalDose50 = new ElementDefinitionInfo                                                                   // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "LethalDose50",                                                                                      // MakerGen.cs:255
                                Path= "MedicationKnowledge.kinetics.lethalDose50",                                                          // MakerGen.cs:256
                                Id = "MedicationKnowledge.kinetics.lethalDose50",                                                           // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Quantity                                                              // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 59. MedicationKnowledge.kinetics.halfLifePeriod
                            this.HalfLifePeriod = new ElementDefinitionInfo                                                                 // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "HalfLifePeriod",                                                                                    // MakerGen.cs:255
                                Path= "MedicationKnowledge.kinetics.halfLifePeriod",                                                        // MakerGen.cs:256
                                Id = "MedicationKnowledge.kinetics.halfLifePeriod",                                                         // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Duration                                                              // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        AreaUnderCurve.Write(sDef);                                                                                         // MakerGen.cs:240
                        LethalDose50.Write(sDef);                                                                                           // MakerGen.cs:240
                        HalfLifePeriod.Write(sDef);                                                                                         // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Kinetics_Elements Elements { get; }                                                                             // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Kinetics()                                                                                                      // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Kinetics_Elements();                                                                           // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 1. MedicationKnowledge.code
            public ElementDefinitionInfo Code;                                                                                              // MakerGen.cs:236
            // 2. MedicationKnowledge.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:236
            // 3. MedicationKnowledge.manufacturer
            public ElementDefinitionInfo Manufacturer;                                                                                      // MakerGen.cs:236
            // 4. MedicationKnowledge.doseForm
            public ElementDefinitionInfo DoseForm;                                                                                          // MakerGen.cs:236
            // 5. MedicationKnowledge.amount
            public ElementDefinitionInfo Amount;                                                                                            // MakerGen.cs:236
            // 6. MedicationKnowledge.synonym
            public ElementDefinitionInfo Synonym;                                                                                           // MakerGen.cs:236
            // 10. MedicationKnowledge.associatedMedication
            public ElementDefinitionInfo AssociatedMedication;                                                                              // MakerGen.cs:236
            // 11. MedicationKnowledge.productType
            public ElementDefinitionInfo ProductType;                                                                                       // MakerGen.cs:236
            // 19. MedicationKnowledge.preparationInstruction
            public ElementDefinitionInfo PreparationInstruction;                                                                            // MakerGen.cs:236
            // 20. MedicationKnowledge.intendedRoute
            public ElementDefinitionInfo IntendedRoute;                                                                                     // MakerGen.cs:236
            // 45. MedicationKnowledge.contraindication
            public ElementDefinitionInfo Contraindication;                                                                                  // MakerGen.cs:236
            public MedicationKnowledge_Elements()                                                                                           // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. MedicationKnowledge.code
                    this.Code = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Code",                                                                                                      // MakerGen.cs:255
                        Path= "MedicationKnowledge.code",                                                                                   // MakerGen.cs:256
                        Id = "MedicationKnowledge.code",                                                                                    // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 2. MedicationKnowledge.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Status",                                                                                                    // MakerGen.cs:255
                        Path= "MedicationKnowledge.status",                                                                                 // MakerGen.cs:256
                        Id = "MedicationKnowledge.status",                                                                                  // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 3. MedicationKnowledge.manufacturer
                    this.Manufacturer = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Manufacturer",                                                                                              // MakerGen.cs:255
                        Path= "MedicationKnowledge.manufacturer",                                                                           // MakerGen.cs:256
                        Id = "MedicationKnowledge.manufacturer",                                                                            // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 4. MedicationKnowledge.doseForm
                    this.DoseForm = new ElementDefinitionInfo                                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "DoseForm",                                                                                                  // MakerGen.cs:255
                        Path= "MedicationKnowledge.doseForm",                                                                               // MakerGen.cs:256
                        Id = "MedicationKnowledge.doseForm",                                                                                // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 5. MedicationKnowledge.amount
                    this.Amount = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Amount",                                                                                                    // MakerGen.cs:255
                        Path= "MedicationKnowledge.amount",                                                                                 // MakerGen.cs:256
                        Id = "MedicationKnowledge.amount",                                                                                  // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Quantity                                                                      // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 6. MedicationKnowledge.synonym
                    this.Synonym = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Synonym",                                                                                                   // MakerGen.cs:255
                        Path= "MedicationKnowledge.synonym",                                                                                // MakerGen.cs:256
                        Id = "MedicationKnowledge.synonym",                                                                                 // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 10. MedicationKnowledge.associatedMedication
                    this.AssociatedMedication = new ElementDefinitionInfo                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "AssociatedMedication",                                                                                      // MakerGen.cs:255
                        Path= "MedicationKnowledge.associatedMedication",                                                                   // MakerGen.cs:256
                        Id = "MedicationKnowledge.associatedMedication",                                                                    // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Medication"                                                    // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 11. MedicationKnowledge.productType
                    this.ProductType = new ElementDefinitionInfo                                                                            // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "ProductType",                                                                                               // MakerGen.cs:255
                        Path= "MedicationKnowledge.productType",                                                                            // MakerGen.cs:256
                        Id = "MedicationKnowledge.productType",                                                                             // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 19. MedicationKnowledge.preparationInstruction
                    this.PreparationInstruction = new ElementDefinitionInfo                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "PreparationInstruction",                                                                                    // MakerGen.cs:255
                        Path= "MedicationKnowledge.preparationInstruction",                                                                 // MakerGen.cs:256
                        Id = "MedicationKnowledge.preparationInstruction",                                                                  // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Markdown                                                                    // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 20. MedicationKnowledge.intendedRoute
                    this.IntendedRoute = new ElementDefinitionInfo                                                                          // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "IntendedRoute",                                                                                             // MakerGen.cs:255
                        Path= "MedicationKnowledge.intendedRoute",                                                                          // MakerGen.cs:256
                        Id = "MedicationKnowledge.intendedRoute",                                                                           // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 45. MedicationKnowledge.contraindication
                    this.Contraindication = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Contraindication",                                                                                          // MakerGen.cs:255
                        Path= "MedicationKnowledge.contraindication",                                                                       // MakerGen.cs:256
                        Id = "MedicationKnowledge.contraindication",                                                                        // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/DetectedIssue"                                                 // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:429
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                Code.Write(sDef);                                                                                                           // MakerGen.cs:240
                Status.Write(sDef);                                                                                                         // MakerGen.cs:240
                Manufacturer.Write(sDef);                                                                                                   // MakerGen.cs:240
                DoseForm.Write(sDef);                                                                                                       // MakerGen.cs:240
                Amount.Write(sDef);                                                                                                         // MakerGen.cs:240
                Synonym.Write(sDef);                                                                                                        // MakerGen.cs:240
                AssociatedMedication.Write(sDef);                                                                                           // MakerGen.cs:240
                ProductType.Write(sDef);                                                                                                    // MakerGen.cs:240
                PreparationInstruction.Write(sDef);                                                                                         // MakerGen.cs:240
                IntendedRoute.Write(sDef);                                                                                                  // MakerGen.cs:240
                Contraindication.Write(sDef);                                                                                               // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public MedicationKnowledge_Elements Elements { get; }                                                                               // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public MedicationKnowledge()                                                                                                        // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new MedicationKnowledge_Elements();                                                                             // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:468
