using System;                                                                                                                               // MakerGen.cs:435
using System.Diagnostics;                                                                                                                   // MakerGen.cs:436
using System.IO;                                                                                                                            // MakerGen.cs:437
using System.Linq;                                                                                                                          // MakerGen.cs:438
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:439
                                                                                                                                            // MakerGen.cs:440
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:441
{                                                                                                                                           // MakerGen.cs:442
    #region Json                                                                                                                            // MakerGen.cs:443
    #if NEVER                                                                                                                               // MakerGen.cs:444
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
    #endregion                                                                                                                              // MakerGen.cs:447
    /// <summary>
    /// Fhir resource 'MedicationKnowledge'
    /// </summary>
    // 0. MedicationKnowledge
    public class Resource_MedicationKnowledge : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                      // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        // 7. MedicationKnowledge.relatedMedicationKnowledge
        public class Type_RelatedMedicationKnowledge : FhirKhit.Maker.Common.Complex.ComplexBase                                            // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 8. MedicationKnowledge.relatedMedicationKnowledge.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:219
            // 9. MedicationKnowledge.relatedMedicationKnowledge.reference
            public ElementDefinitionInfo Element_Reference;                                                                                 // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "MedicationKnowledge.relatedMedicationKnowledge",                                                                // MakerGen.cs:395
                    ElementId = "MedicationKnowledge.relatedMedicationKnowledge"                                                            // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:223
                Element_Reference.Write(sDef);                                                                                              // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_RelatedMedicationKnowledge()                                                                                        // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 8. MedicationKnowledge.relatedMedicationKnowledge.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Type",                                                                                              // MakerGen.cs:238
                        Path= "MedicationKnowledge.relatedMedicationKnowledge.type",                                                        // MakerGen.cs:239
                        Id = "MedicationKnowledge.relatedMedicationKnowledge.type",                                                         // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 9. MedicationKnowledge.relatedMedicationKnowledge.reference
                    this.Element_Reference = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Reference",                                                                                         // MakerGen.cs:238
                        Path= "MedicationKnowledge.relatedMedicationKnowledge.reference",                                                   // MakerGen.cs:239
                        Id = "MedicationKnowledge.relatedMedicationKnowledge.reference",                                                    // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/MedicationKnowledge"                                           // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 12. MedicationKnowledge.monograph
        public class Type_Monograph : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 13. MedicationKnowledge.monograph.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:219
            // 14. MedicationKnowledge.monograph.source
            public ElementDefinitionInfo Element_Source;                                                                                    // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "MedicationKnowledge.monograph",                                                                                 // MakerGen.cs:395
                    ElementId = "MedicationKnowledge.monograph"                                                                             // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:223
                Element_Source.Write(sDef);                                                                                                 // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Monograph()                                                                                                         // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 13. MedicationKnowledge.monograph.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Type",                                                                                              // MakerGen.cs:238
                        Path= "MedicationKnowledge.monograph.type",                                                                         // MakerGen.cs:239
                        Id = "MedicationKnowledge.monograph.type",                                                                          // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 14. MedicationKnowledge.monograph.source
                    this.Element_Source = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Source",                                                                                            // MakerGen.cs:238
                        Path= "MedicationKnowledge.monograph.source",                                                                       // MakerGen.cs:239
                        Id = "MedicationKnowledge.monograph.source",                                                                        // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference",                                            // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Media"                                                         // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 15. MedicationKnowledge.ingredient
        public class Type_Ingredient : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 16. MedicationKnowledge.ingredient.item[x]
            public ElementDefinitionInfo Element_Item;                                                                                      // MakerGen.cs:219
            // 17. MedicationKnowledge.ingredient.isActive
            public ElementDefinitionInfo Element_IsActive;                                                                                  // MakerGen.cs:219
            // 18. MedicationKnowledge.ingredient.strength
            public ElementDefinitionInfo Element_Strength;                                                                                  // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "MedicationKnowledge.ingredient",                                                                                // MakerGen.cs:395
                    ElementId = "MedicationKnowledge.ingredient"                                                                            // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Item.Write(sDef);                                                                                                   // MakerGen.cs:223
                Element_IsActive.Write(sDef);                                                                                               // MakerGen.cs:223
                Element_Strength.Write(sDef);                                                                                               // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Ingredient()                                                                                                        // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 16. MedicationKnowledge.ingredient.item[x]
                    this.Element_Item = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Item",                                                                                              // MakerGen.cs:238
                        Path= "MedicationKnowledge.ingredient.item[x]",                                                                     // MakerGen.cs:239
                        Id = "MedicationKnowledge.ingredient.item[x]",                                                                      // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            },                                                                                                              // MakerGen.cs:322
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Substance"                                                     // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 17. MedicationKnowledge.ingredient.isActive
                    this.Element_IsActive = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_IsActive",                                                                                          // MakerGen.cs:238
                        Path= "MedicationKnowledge.ingredient.isActive",                                                                    // MakerGen.cs:239
                        Id = "MedicationKnowledge.ingredient.isActive",                                                                     // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                           // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 18. MedicationKnowledge.ingredient.strength
                    this.Element_Strength = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Strength",                                                                                          // MakerGen.cs:238
                        Path= "MedicationKnowledge.ingredient.strength",                                                                    // MakerGen.cs:239
                        Id = "MedicationKnowledge.ingredient.strength",                                                                     // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Ratio                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 21. MedicationKnowledge.cost
        public class Type_Cost : FhirKhit.Maker.Common.Complex.ComplexBase                                                                  // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 22. MedicationKnowledge.cost.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:219
            // 23. MedicationKnowledge.cost.source
            public ElementDefinitionInfo Element_Source;                                                                                    // MakerGen.cs:219
            // 24. MedicationKnowledge.cost.cost
            public ElementDefinitionInfo Element_Cost;                                                                                      // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "MedicationKnowledge.cost",                                                                                      // MakerGen.cs:395
                    ElementId = "MedicationKnowledge.cost"                                                                                  // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:223
                Element_Source.Write(sDef);                                                                                                 // MakerGen.cs:223
                Element_Cost.Write(sDef);                                                                                                   // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Cost()                                                                                                              // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 22. MedicationKnowledge.cost.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Type",                                                                                              // MakerGen.cs:238
                        Path= "MedicationKnowledge.cost.type",                                                                              // MakerGen.cs:239
                        Id = "MedicationKnowledge.cost.type",                                                                               // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 23. MedicationKnowledge.cost.source
                    this.Element_Source = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Source",                                                                                            // MakerGen.cs:238
                        Path= "MedicationKnowledge.cost.source",                                                                            // MakerGen.cs:239
                        Id = "MedicationKnowledge.cost.source",                                                                             // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 24. MedicationKnowledge.cost.cost
                    this.Element_Cost = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Cost",                                                                                              // MakerGen.cs:238
                        Path= "MedicationKnowledge.cost.cost",                                                                              // MakerGen.cs:239
                        Id = "MedicationKnowledge.cost.cost",                                                                               // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Money                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 25. MedicationKnowledge.monitoringProgram
        public class Type_MonitoringProgram : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 26. MedicationKnowledge.monitoringProgram.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:219
            // 27. MedicationKnowledge.monitoringProgram.name
            public ElementDefinitionInfo Element_Name;                                                                                      // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "MedicationKnowledge.monitoringProgram",                                                                         // MakerGen.cs:395
                    ElementId = "MedicationKnowledge.monitoringProgram"                                                                     // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:223
                Element_Name.Write(sDef);                                                                                                   // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_MonitoringProgram()                                                                                                 // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 26. MedicationKnowledge.monitoringProgram.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Type",                                                                                              // MakerGen.cs:238
                        Path= "MedicationKnowledge.monitoringProgram.type",                                                                 // MakerGen.cs:239
                        Id = "MedicationKnowledge.monitoringProgram.type",                                                                  // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 27. MedicationKnowledge.monitoringProgram.name
                    this.Element_Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Name",                                                                                              // MakerGen.cs:238
                        Path= "MedicationKnowledge.monitoringProgram.name",                                                                 // MakerGen.cs:239
                        Id = "MedicationKnowledge.monitoringProgram.name",                                                                  // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 28. MedicationKnowledge.administrationGuidelines
        public class Type_AdministrationGuidelines : FhirKhit.Maker.Common.Complex.ComplexBase                                              // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 29. MedicationKnowledge.administrationGuidelines.dosage
            public class Type_Dosage : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                // 30. MedicationKnowledge.administrationGuidelines.dosage.type
                public ElementDefinitionInfo Element_Type;                                                                                  // MakerGen.cs:219
                // 31. MedicationKnowledge.administrationGuidelines.dosage.dosage
                public ElementDefinitionInfo Element_Dosage;                                                                                // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:390
                {                                                                                                                           // MakerGen.cs:391
                    base.Write(sDef);                                                                                                       // MakerGen.cs:392
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        Path = "MedicationKnowledge.administrationGuidelines.dosage",                                                       // MakerGen.cs:395
                        ElementId = "MedicationKnowledge.administrationGuidelines.dosage"                                                   // MakerGen.cs:396
                    });                                                                                                                     // MakerGen.cs:397
                    Element_Type.Write(sDef);                                                                                               // MakerGen.cs:223
                    Element_Dosage.Write(sDef);                                                                                             // MakerGen.cs:223
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
                public Type_Dosage()                                                                                                        // MakerGen.cs:402
                {                                                                                                                           // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:234
                        // 30. MedicationKnowledge.administrationGuidelines.dosage.type
                        this.Element_Type = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Type",                                                                                          // MakerGen.cs:238
                            Path= "MedicationKnowledge.administrationGuidelines.dosage.type",                                               // MakerGen.cs:239
                            Id = "MedicationKnowledge.administrationGuidelines.dosage.type",                                                // MakerGen.cs:240
                            Min = 1,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:318
                                {                                                                                                           // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:322
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 31. MedicationKnowledge.administrationGuidelines.dosage.dosage
                        this.Element_Dosage = new ElementDefinitionInfo                                                                     // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Dosage",                                                                                        // MakerGen.cs:238
                            Path= "MedicationKnowledge.administrationGuidelines.dosage.dosage",                                             // MakerGen.cs:239
                            Id = "MedicationKnowledge.administrationGuidelines.dosage.dosage",                                              // MakerGen.cs:240
                            Min = 1,                                                                                                        // MakerGen.cs:241
                            Max = -1,                                                                                                       // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_Dosage                                                               // MakerGen.cs:358
                                {                                                                                                           // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:360
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                }                                                                                                                           // MakerGen.cs:405
            }                                                                                                                               // MakerGen.cs:407
            // 33. MedicationKnowledge.administrationGuidelines.patientCharacteristics
            public class Type_PatientCharacteristics : FhirKhit.Maker.Common.Complex.ComplexBase                                            // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                // 34. MedicationKnowledge.administrationGuidelines.patientCharacteristics.characteristic[x]
                public ElementDefinitionInfo Element_Characteristic;                                                                        // MakerGen.cs:219
                // 35. MedicationKnowledge.administrationGuidelines.patientCharacteristics.value
                public ElementDefinitionInfo Element_Value;                                                                                 // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:390
                {                                                                                                                           // MakerGen.cs:391
                    base.Write(sDef);                                                                                                       // MakerGen.cs:392
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        Path = "MedicationKnowledge.administrationGuidelines.patientCharacteristics",                                       // MakerGen.cs:395
                        ElementId = "MedicationKnowledge.administrationGuidelines.patientCharacteristics"                                   // MakerGen.cs:396
                    });                                                                                                                     // MakerGen.cs:397
                    Element_Characteristic.Write(sDef);                                                                                     // MakerGen.cs:223
                    Element_Value.Write(sDef);                                                                                              // MakerGen.cs:223
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
                public Type_PatientCharacteristics()                                                                                        // MakerGen.cs:402
                {                                                                                                                           // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:234
                        // 34. MedicationKnowledge.administrationGuidelines.patientCharacteristics.characteristic[x]
                        this.Element_Characteristic = new ElementDefinitionInfo                                                             // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Characteristic",                                                                                // MakerGen.cs:238
                            Path= "MedicationKnowledge.administrationGuidelines.patientCharacteristics.characteristic[x]",                  // MakerGen.cs:239
                            Id = "MedicationKnowledge.administrationGuidelines.patientCharacteristics.characteristic[x]",                   // MakerGen.cs:240
                            Min = 1,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:318
                                {                                                                                                           // MakerGen.cs:319
                                },                                                                                                          // MakerGen.cs:322
                                new FhirKhit.Maker.Common.Complex.Type_Quantity                                                             // MakerGen.cs:358
                                {                                                                                                           // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:360
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 35. MedicationKnowledge.administrationGuidelines.patientCharacteristics.value
                        this.Element_Value = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Value",                                                                                         // MakerGen.cs:238
                            Path= "MedicationKnowledge.administrationGuidelines.patientCharacteristics.value",                              // MakerGen.cs:239
                            Id = "MedicationKnowledge.administrationGuidelines.patientCharacteristics.value",                               // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = -1,                                                                                                       // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Primitive.Primitive_String                                                        // MakerGen.cs:303
                                {                                                                                                           // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:307
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                }                                                                                                                           // MakerGen.cs:405
            }                                                                                                                               // MakerGen.cs:407
            // 29. MedicationKnowledge.administrationGuidelines.dosage
            public ElementDefinitionInfo Element_Dosage;                                                                                    // MakerGen.cs:219
            // 32. MedicationKnowledge.administrationGuidelines.indication[x]
            public ElementDefinitionInfo Element_Indication;                                                                                // MakerGen.cs:219
            // 33. MedicationKnowledge.administrationGuidelines.patientCharacteristics
            public ElementDefinitionInfo Element_PatientCharacteristics;                                                                    // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "MedicationKnowledge.administrationGuidelines",                                                                  // MakerGen.cs:395
                    ElementId = "MedicationKnowledge.administrationGuidelines"                                                              // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Dosage.Write(sDef);                                                                                                 // MakerGen.cs:223
                Element_Indication.Write(sDef);                                                                                             // MakerGen.cs:223
                Element_PatientCharacteristics.Write(sDef);                                                                                 // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_AdministrationGuidelines()                                                                                          // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 29. MedicationKnowledge.administrationGuidelines.dosage
                    this.Element_Dosage = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Dosage",                                                                                            // MakerGen.cs:238
                        Path= "MedicationKnowledge.administrationGuidelines.dosage",                                                        // MakerGen.cs:239
                        Id = "MedicationKnowledge.administrationGuidelines.dosage",                                                         // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new Type_Dosage                                                                                                 // MakerGen.cs:262
                            {                                                                                                               // MakerGen.cs:263
                            }                                                                                                               // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 32. MedicationKnowledge.administrationGuidelines.indication[x]
                    this.Element_Indication = new ElementDefinitionInfo                                                                     // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Indication",                                                                                        // MakerGen.cs:238
                        Path= "MedicationKnowledge.administrationGuidelines.indication[x]",                                                 // MakerGen.cs:239
                        Id = "MedicationKnowledge.administrationGuidelines.indication[x]",                                                  // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            },                                                                                                              // MakerGen.cs:322
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ObservationDefinition"                                         // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 33. MedicationKnowledge.administrationGuidelines.patientCharacteristics
                    this.Element_PatientCharacteristics = new ElementDefinitionInfo                                                         // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_PatientCharacteristics",                                                                            // MakerGen.cs:238
                        Path= "MedicationKnowledge.administrationGuidelines.patientCharacteristics",                                        // MakerGen.cs:239
                        Id = "MedicationKnowledge.administrationGuidelines.patientCharacteristics",                                         // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new Type_PatientCharacteristics                                                                                 // MakerGen.cs:262
                            {                                                                                                               // MakerGen.cs:263
                            }                                                                                                               // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 36. MedicationKnowledge.medicineClassification
        public class Type_MedicineClassification : FhirKhit.Maker.Common.Complex.ComplexBase                                                // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 37. MedicationKnowledge.medicineClassification.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:219
            // 38. MedicationKnowledge.medicineClassification.classification
            public ElementDefinitionInfo Element_Classification;                                                                            // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "MedicationKnowledge.medicineClassification",                                                                    // MakerGen.cs:395
                    ElementId = "MedicationKnowledge.medicineClassification"                                                                // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:223
                Element_Classification.Write(sDef);                                                                                         // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_MedicineClassification()                                                                                            // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 37. MedicationKnowledge.medicineClassification.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Type",                                                                                              // MakerGen.cs:238
                        Path= "MedicationKnowledge.medicineClassification.type",                                                            // MakerGen.cs:239
                        Id = "MedicationKnowledge.medicineClassification.type",                                                             // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 38. MedicationKnowledge.medicineClassification.classification
                    this.Element_Classification = new ElementDefinitionInfo                                                                 // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Classification",                                                                                    // MakerGen.cs:238
                        Path= "MedicationKnowledge.medicineClassification.classification",                                                  // MakerGen.cs:239
                        Id = "MedicationKnowledge.medicineClassification.classification",                                                   // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 39. MedicationKnowledge.packaging
        public class Type_Packaging : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 40. MedicationKnowledge.packaging.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:219
            // 41. MedicationKnowledge.packaging.quantity
            public ElementDefinitionInfo Element_Quantity;                                                                                  // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "MedicationKnowledge.packaging",                                                                                 // MakerGen.cs:395
                    ElementId = "MedicationKnowledge.packaging"                                                                             // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:223
                Element_Quantity.Write(sDef);                                                                                               // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Packaging()                                                                                                         // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 40. MedicationKnowledge.packaging.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Type",                                                                                              // MakerGen.cs:238
                        Path= "MedicationKnowledge.packaging.type",                                                                         // MakerGen.cs:239
                        Id = "MedicationKnowledge.packaging.type",                                                                          // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 41. MedicationKnowledge.packaging.quantity
                    this.Element_Quantity = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Quantity",                                                                                          // MakerGen.cs:238
                        Path= "MedicationKnowledge.packaging.quantity",                                                                     // MakerGen.cs:239
                        Id = "MedicationKnowledge.packaging.quantity",                                                                      // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 42. MedicationKnowledge.drugCharacteristic
        public class Type_DrugCharacteristic : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 43. MedicationKnowledge.drugCharacteristic.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:219
            // 44. MedicationKnowledge.drugCharacteristic.value[x]
            public ElementDefinitionInfo Element_Value;                                                                                     // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "MedicationKnowledge.drugCharacteristic",                                                                        // MakerGen.cs:395
                    ElementId = "MedicationKnowledge.drugCharacteristic"                                                                    // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:223
                Element_Value.Write(sDef);                                                                                                  // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_DrugCharacteristic()                                                                                                // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 43. MedicationKnowledge.drugCharacteristic.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Type",                                                                                              // MakerGen.cs:238
                        Path= "MedicationKnowledge.drugCharacteristic.type",                                                                // MakerGen.cs:239
                        Id = "MedicationKnowledge.drugCharacteristic.type",                                                                 // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 44. MedicationKnowledge.drugCharacteristic.value[x]
                    this.Element_Value = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Value",                                                                                             // MakerGen.cs:238
                        Path= "MedicationKnowledge.drugCharacteristic.value[x]",                                                            // MakerGen.cs:239
                        Id = "MedicationKnowledge.drugCharacteristic.value[x]",                                                             // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            },                                                                                                              // MakerGen.cs:322
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            },                                                                                                              // MakerGen.cs:307
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            },                                                                                                              // MakerGen.cs:360
                            new FhirKhit.Maker.Common.Primitive.Primitive_Base64Binary                                                      // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 46. MedicationKnowledge.regulatory
        public class Type_Regulatory : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 48. MedicationKnowledge.regulatory.substitution
            public class Type_Substitution : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                // 49. MedicationKnowledge.regulatory.substitution.type
                public ElementDefinitionInfo Element_Type;                                                                                  // MakerGen.cs:219
                // 50. MedicationKnowledge.regulatory.substitution.allowed
                public ElementDefinitionInfo Element_Allowed;                                                                               // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:390
                {                                                                                                                           // MakerGen.cs:391
                    base.Write(sDef);                                                                                                       // MakerGen.cs:392
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        Path = "MedicationKnowledge.regulatory.substitution",                                                               // MakerGen.cs:395
                        ElementId = "MedicationKnowledge.regulatory.substitution"                                                           // MakerGen.cs:396
                    });                                                                                                                     // MakerGen.cs:397
                    Element_Type.Write(sDef);                                                                                               // MakerGen.cs:223
                    Element_Allowed.Write(sDef);                                                                                            // MakerGen.cs:223
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
                public Type_Substitution()                                                                                                  // MakerGen.cs:402
                {                                                                                                                           // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:234
                        // 49. MedicationKnowledge.regulatory.substitution.type
                        this.Element_Type = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Type",                                                                                          // MakerGen.cs:238
                            Path= "MedicationKnowledge.regulatory.substitution.type",                                                       // MakerGen.cs:239
                            Id = "MedicationKnowledge.regulatory.substitution.type",                                                        // MakerGen.cs:240
                            Min = 1,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:318
                                {                                                                                                           // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:322
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 50. MedicationKnowledge.regulatory.substitution.allowed
                        this.Element_Allowed = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Allowed",                                                                                       // MakerGen.cs:238
                            Path= "MedicationKnowledge.regulatory.substitution.allowed",                                                    // MakerGen.cs:239
                            Id = "MedicationKnowledge.regulatory.substitution.allowed",                                                     // MakerGen.cs:240
                            Min = 1,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                       // MakerGen.cs:303
                                {                                                                                                           // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:307
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                }                                                                                                                           // MakerGen.cs:405
            }                                                                                                                               // MakerGen.cs:407
            // 51. MedicationKnowledge.regulatory.schedule
            public class Type_Schedule : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                // 52. MedicationKnowledge.regulatory.schedule.schedule
                public ElementDefinitionInfo Element_Schedule;                                                                              // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:390
                {                                                                                                                           // MakerGen.cs:391
                    base.Write(sDef);                                                                                                       // MakerGen.cs:392
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        Path = "MedicationKnowledge.regulatory.schedule",                                                                   // MakerGen.cs:395
                        ElementId = "MedicationKnowledge.regulatory.schedule"                                                               // MakerGen.cs:396
                    });                                                                                                                     // MakerGen.cs:397
                    Element_Schedule.Write(sDef);                                                                                           // MakerGen.cs:223
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
                public Type_Schedule()                                                                                                      // MakerGen.cs:402
                {                                                                                                                           // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:234
                        // 52. MedicationKnowledge.regulatory.schedule.schedule
                        this.Element_Schedule = new ElementDefinitionInfo                                                                   // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Schedule",                                                                                      // MakerGen.cs:238
                            Path= "MedicationKnowledge.regulatory.schedule.schedule",                                                       // MakerGen.cs:239
                            Id = "MedicationKnowledge.regulatory.schedule.schedule",                                                        // MakerGen.cs:240
                            Min = 1,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:318
                                {                                                                                                           // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:322
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                }                                                                                                                           // MakerGen.cs:405
            }                                                                                                                               // MakerGen.cs:407
            // 53. MedicationKnowledge.regulatory.maxDispense
            public class Type_MaxDispense : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                // 54. MedicationKnowledge.regulatory.maxDispense.quantity
                public ElementDefinitionInfo Element_Quantity;                                                                              // MakerGen.cs:219
                // 55. MedicationKnowledge.regulatory.maxDispense.period
                public ElementDefinitionInfo Element_Period;                                                                                // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:390
                {                                                                                                                           // MakerGen.cs:391
                    base.Write(sDef);                                                                                                       // MakerGen.cs:392
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        Path = "MedicationKnowledge.regulatory.maxDispense",                                                                // MakerGen.cs:395
                        ElementId = "MedicationKnowledge.regulatory.maxDispense"                                                            // MakerGen.cs:396
                    });                                                                                                                     // MakerGen.cs:397
                    Element_Quantity.Write(sDef);                                                                                           // MakerGen.cs:223
                    Element_Period.Write(sDef);                                                                                             // MakerGen.cs:223
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
                public Type_MaxDispense()                                                                                                   // MakerGen.cs:402
                {                                                                                                                           // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:234
                        // 54. MedicationKnowledge.regulatory.maxDispense.quantity
                        this.Element_Quantity = new ElementDefinitionInfo                                                                   // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Quantity",                                                                                      // MakerGen.cs:238
                            Path= "MedicationKnowledge.regulatory.maxDispense.quantity",                                                    // MakerGen.cs:239
                            Id = "MedicationKnowledge.regulatory.maxDispense.quantity",                                                     // MakerGen.cs:240
                            Min = 1,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_Quantity                                                             // MakerGen.cs:358
                                {                                                                                                           // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:360
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 55. MedicationKnowledge.regulatory.maxDispense.period
                        this.Element_Period = new ElementDefinitionInfo                                                                     // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Period",                                                                                        // MakerGen.cs:238
                            Path= "MedicationKnowledge.regulatory.maxDispense.period",                                                      // MakerGen.cs:239
                            Id = "MedicationKnowledge.regulatory.maxDispense.period",                                                       // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_Duration                                                             // MakerGen.cs:358
                                {                                                                                                           // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:360
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                }                                                                                                                           // MakerGen.cs:405
            }                                                                                                                               // MakerGen.cs:407
            // 47. MedicationKnowledge.regulatory.regulatoryAuthority
            public ElementDefinitionInfo Element_RegulatoryAuthority;                                                                       // MakerGen.cs:219
            // 48. MedicationKnowledge.regulatory.substitution
            public ElementDefinitionInfo Element_Substitution;                                                                              // MakerGen.cs:219
            // 51. MedicationKnowledge.regulatory.schedule
            public ElementDefinitionInfo Element_Schedule;                                                                                  // MakerGen.cs:219
            // 53. MedicationKnowledge.regulatory.maxDispense
            public ElementDefinitionInfo Element_MaxDispense;                                                                               // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "MedicationKnowledge.regulatory",                                                                                // MakerGen.cs:395
                    ElementId = "MedicationKnowledge.regulatory"                                                                            // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_RegulatoryAuthority.Write(sDef);                                                                                    // MakerGen.cs:223
                Element_Substitution.Write(sDef);                                                                                           // MakerGen.cs:223
                Element_Schedule.Write(sDef);                                                                                               // MakerGen.cs:223
                Element_MaxDispense.Write(sDef);                                                                                            // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Regulatory()                                                                                                        // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 47. MedicationKnowledge.regulatory.regulatoryAuthority
                    this.Element_RegulatoryAuthority = new ElementDefinitionInfo                                                            // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_RegulatoryAuthority",                                                                               // MakerGen.cs:238
                        Path= "MedicationKnowledge.regulatory.regulatoryAuthority",                                                         // MakerGen.cs:239
                        Id = "MedicationKnowledge.regulatory.regulatoryAuthority",                                                          // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 48. MedicationKnowledge.regulatory.substitution
                    this.Element_Substitution = new ElementDefinitionInfo                                                                   // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Substitution",                                                                                      // MakerGen.cs:238
                        Path= "MedicationKnowledge.regulatory.substitution",                                                                // MakerGen.cs:239
                        Id = "MedicationKnowledge.regulatory.substitution",                                                                 // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new Type_Substitution                                                                                           // MakerGen.cs:262
                            {                                                                                                               // MakerGen.cs:263
                            }                                                                                                               // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 51. MedicationKnowledge.regulatory.schedule
                    this.Element_Schedule = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Schedule",                                                                                          // MakerGen.cs:238
                        Path= "MedicationKnowledge.regulatory.schedule",                                                                    // MakerGen.cs:239
                        Id = "MedicationKnowledge.regulatory.schedule",                                                                     // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new Type_Schedule                                                                                               // MakerGen.cs:262
                            {                                                                                                               // MakerGen.cs:263
                            }                                                                                                               // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 53. MedicationKnowledge.regulatory.maxDispense
                    this.Element_MaxDispense = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_MaxDispense",                                                                                       // MakerGen.cs:238
                        Path= "MedicationKnowledge.regulatory.maxDispense",                                                                 // MakerGen.cs:239
                        Id = "MedicationKnowledge.regulatory.maxDispense",                                                                  // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new Type_MaxDispense                                                                                            // MakerGen.cs:262
                            {                                                                                                               // MakerGen.cs:263
                            }                                                                                                               // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 56. MedicationKnowledge.kinetics
        public class Type_Kinetics : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 57. MedicationKnowledge.kinetics.areaUnderCurve
            public ElementDefinitionInfo Element_AreaUnderCurve;                                                                            // MakerGen.cs:219
            // 58. MedicationKnowledge.kinetics.lethalDose50
            public ElementDefinitionInfo Element_LethalDose50;                                                                              // MakerGen.cs:219
            // 59. MedicationKnowledge.kinetics.halfLifePeriod
            public ElementDefinitionInfo Element_HalfLifePeriod;                                                                            // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "MedicationKnowledge.kinetics",                                                                                  // MakerGen.cs:395
                    ElementId = "MedicationKnowledge.kinetics"                                                                              // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_AreaUnderCurve.Write(sDef);                                                                                         // MakerGen.cs:223
                Element_LethalDose50.Write(sDef);                                                                                           // MakerGen.cs:223
                Element_HalfLifePeriod.Write(sDef);                                                                                         // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Kinetics()                                                                                                          // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 57. MedicationKnowledge.kinetics.areaUnderCurve
                    this.Element_AreaUnderCurve = new ElementDefinitionInfo                                                                 // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_AreaUnderCurve",                                                                                    // MakerGen.cs:238
                        Path= "MedicationKnowledge.kinetics.areaUnderCurve",                                                                // MakerGen.cs:239
                        Id = "MedicationKnowledge.kinetics.areaUnderCurve",                                                                 // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 58. MedicationKnowledge.kinetics.lethalDose50
                    this.Element_LethalDose50 = new ElementDefinitionInfo                                                                   // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_LethalDose50",                                                                                      // MakerGen.cs:238
                        Path= "MedicationKnowledge.kinetics.lethalDose50",                                                                  // MakerGen.cs:239
                        Id = "MedicationKnowledge.kinetics.lethalDose50",                                                                   // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 59. MedicationKnowledge.kinetics.halfLifePeriod
                    this.Element_HalfLifePeriod = new ElementDefinitionInfo                                                                 // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_HalfLifePeriod",                                                                                    // MakerGen.cs:238
                        Path= "MedicationKnowledge.kinetics.halfLifePeriod",                                                                // MakerGen.cs:239
                        Id = "MedicationKnowledge.kinetics.halfLifePeriod",                                                                 // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Duration                                                                 // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 1. MedicationKnowledge.code
        public ElementDefinitionInfo Element_Code;                                                                                          // MakerGen.cs:219
        // 2. MedicationKnowledge.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:219
        // 3. MedicationKnowledge.manufacturer
        public ElementDefinitionInfo Element_Manufacturer;                                                                                  // MakerGen.cs:219
        // 4. MedicationKnowledge.doseForm
        public ElementDefinitionInfo Element_DoseForm;                                                                                      // MakerGen.cs:219
        // 5. MedicationKnowledge.amount
        public ElementDefinitionInfo Element_Amount;                                                                                        // MakerGen.cs:219
        // 6. MedicationKnowledge.synonym
        public ElementDefinitionInfo Element_Synonym;                                                                                       // MakerGen.cs:219
        // 7. MedicationKnowledge.relatedMedicationKnowledge
        public ElementDefinitionInfo Element_RelatedMedicationKnowledge;                                                                    // MakerGen.cs:219
        // 10. MedicationKnowledge.associatedMedication
        public ElementDefinitionInfo Element_AssociatedMedication;                                                                          // MakerGen.cs:219
        // 11. MedicationKnowledge.productType
        public ElementDefinitionInfo Element_ProductType;                                                                                   // MakerGen.cs:219
        // 12. MedicationKnowledge.monograph
        public ElementDefinitionInfo Element_Monograph;                                                                                     // MakerGen.cs:219
        // 15. MedicationKnowledge.ingredient
        public ElementDefinitionInfo Element_Ingredient;                                                                                    // MakerGen.cs:219
        // 19. MedicationKnowledge.preparationInstruction
        public ElementDefinitionInfo Element_PreparationInstruction;                                                                        // MakerGen.cs:219
        // 20. MedicationKnowledge.intendedRoute
        public ElementDefinitionInfo Element_IntendedRoute;                                                                                 // MakerGen.cs:219
        // 21. MedicationKnowledge.cost
        public ElementDefinitionInfo Element_Cost;                                                                                          // MakerGen.cs:219
        // 25. MedicationKnowledge.monitoringProgram
        public ElementDefinitionInfo Element_MonitoringProgram;                                                                             // MakerGen.cs:219
        // 28. MedicationKnowledge.administrationGuidelines
        public ElementDefinitionInfo Element_AdministrationGuidelines;                                                                      // MakerGen.cs:219
        // 36. MedicationKnowledge.medicineClassification
        public ElementDefinitionInfo Element_MedicineClassification;                                                                        // MakerGen.cs:219
        // 39. MedicationKnowledge.packaging
        public ElementDefinitionInfo Element_Packaging;                                                                                     // MakerGen.cs:219
        // 42. MedicationKnowledge.drugCharacteristic
        public ElementDefinitionInfo Element_DrugCharacteristic;                                                                            // MakerGen.cs:219
        // 45. MedicationKnowledge.contraindication
        public ElementDefinitionInfo Element_Contraindication;                                                                              // MakerGen.cs:219
        // 46. MedicationKnowledge.regulatory
        public ElementDefinitionInfo Element_Regulatory;                                                                                    // MakerGen.cs:219
        // 56. MedicationKnowledge.kinetics
        public ElementDefinitionInfo Element_Kinetics;                                                                                      // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:390
        {                                                                                                                                   // MakerGen.cs:391
            base.Write(sDef);                                                                                                               // MakerGen.cs:392
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                Path = "MedicationKnowledge",                                                                                               // MakerGen.cs:395
                ElementId = "MedicationKnowledge"                                                                                           // MakerGen.cs:396
            });                                                                                                                             // MakerGen.cs:397
            Element_Code.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_Manufacturer.Write(sDef);                                                                                               // MakerGen.cs:223
            Element_DoseForm.Write(sDef);                                                                                                   // MakerGen.cs:223
            Element_Amount.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_Synonym.Write(sDef);                                                                                                    // MakerGen.cs:223
            Element_RelatedMedicationKnowledge.Write(sDef);                                                                                 // MakerGen.cs:223
            Element_AssociatedMedication.Write(sDef);                                                                                       // MakerGen.cs:223
            Element_ProductType.Write(sDef);                                                                                                // MakerGen.cs:223
            Element_Monograph.Write(sDef);                                                                                                  // MakerGen.cs:223
            Element_Ingredient.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_PreparationInstruction.Write(sDef);                                                                                     // MakerGen.cs:223
            Element_IntendedRoute.Write(sDef);                                                                                              // MakerGen.cs:223
            Element_Cost.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_MonitoringProgram.Write(sDef);                                                                                          // MakerGen.cs:223
            Element_AdministrationGuidelines.Write(sDef);                                                                                   // MakerGen.cs:223
            Element_MedicineClassification.Write(sDef);                                                                                     // MakerGen.cs:223
            Element_Packaging.Write(sDef);                                                                                                  // MakerGen.cs:223
            Element_DrugCharacteristic.Write(sDef);                                                                                         // MakerGen.cs:223
            Element_Contraindication.Write(sDef);                                                                                           // MakerGen.cs:223
            Element_Regulatory.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Kinetics.Write(sDef);                                                                                                   // MakerGen.cs:223
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
        public Resource_MedicationKnowledge()                                                                                               // MakerGen.cs:402
        {                                                                                                                                   // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:234
                // 1. MedicationKnowledge.code
                this.Element_Code = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Code",                                                                                                  // MakerGen.cs:238
                    Path= "MedicationKnowledge.code",                                                                                       // MakerGen.cs:239
                    Id = "MedicationKnowledge.code",                                                                                        // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 2. MedicationKnowledge.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Status",                                                                                                // MakerGen.cs:238
                    Path= "MedicationKnowledge.status",                                                                                     // MakerGen.cs:239
                    Id = "MedicationKnowledge.status",                                                                                      // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 3. MedicationKnowledge.manufacturer
                this.Element_Manufacturer = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Manufacturer",                                                                                          // MakerGen.cs:238
                    Path= "MedicationKnowledge.manufacturer",                                                                               // MakerGen.cs:239
                    Id = "MedicationKnowledge.manufacturer",                                                                                // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 4. MedicationKnowledge.doseForm
                this.Element_DoseForm = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_DoseForm",                                                                                              // MakerGen.cs:238
                    Path= "MedicationKnowledge.doseForm",                                                                                   // MakerGen.cs:239
                    Id = "MedicationKnowledge.doseForm",                                                                                    // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 5. MedicationKnowledge.amount
                this.Element_Amount = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Amount",                                                                                                // MakerGen.cs:238
                    Path= "MedicationKnowledge.amount",                                                                                     // MakerGen.cs:239
                    Id = "MedicationKnowledge.amount",                                                                                      // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                     // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 6. MedicationKnowledge.synonym
                this.Element_Synonym = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Synonym",                                                                                               // MakerGen.cs:238
                    Path= "MedicationKnowledge.synonym",                                                                                    // MakerGen.cs:239
                    Id = "MedicationKnowledge.synonym",                                                                                     // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 7. MedicationKnowledge.relatedMedicationKnowledge
                this.Element_RelatedMedicationKnowledge = new ElementDefinitionInfo                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_RelatedMedicationKnowledge",                                                                            // MakerGen.cs:238
                    Path= "MedicationKnowledge.relatedMedicationKnowledge",                                                                 // MakerGen.cs:239
                    Id = "MedicationKnowledge.relatedMedicationKnowledge",                                                                  // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_RelatedMedicationKnowledge                                                                                 // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 10. MedicationKnowledge.associatedMedication
                this.Element_AssociatedMedication = new ElementDefinitionInfo                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_AssociatedMedication",                                                                                  // MakerGen.cs:238
                    Path= "MedicationKnowledge.associatedMedication",                                                                       // MakerGen.cs:239
                    Id = "MedicationKnowledge.associatedMedication",                                                                        // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Medication"                                                        // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 11. MedicationKnowledge.productType
                this.Element_ProductType = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_ProductType",                                                                                           // MakerGen.cs:238
                    Path= "MedicationKnowledge.productType",                                                                                // MakerGen.cs:239
                    Id = "MedicationKnowledge.productType",                                                                                 // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 12. MedicationKnowledge.monograph
                this.Element_Monograph = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Monograph",                                                                                             // MakerGen.cs:238
                    Path= "MedicationKnowledge.monograph",                                                                                  // MakerGen.cs:239
                    Id = "MedicationKnowledge.monograph",                                                                                   // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Monograph                                                                                                  // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 15. MedicationKnowledge.ingredient
                this.Element_Ingredient = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Ingredient",                                                                                            // MakerGen.cs:238
                    Path= "MedicationKnowledge.ingredient",                                                                                 // MakerGen.cs:239
                    Id = "MedicationKnowledge.ingredient",                                                                                  // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Ingredient                                                                                                 // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 19. MedicationKnowledge.preparationInstruction
                this.Element_PreparationInstruction = new ElementDefinitionInfo                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_PreparationInstruction",                                                                                // MakerGen.cs:238
                    Path= "MedicationKnowledge.preparationInstruction",                                                                     // MakerGen.cs:239
                    Id = "MedicationKnowledge.preparationInstruction",                                                                      // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                              // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 20. MedicationKnowledge.intendedRoute
                this.Element_IntendedRoute = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_IntendedRoute",                                                                                         // MakerGen.cs:238
                    Path= "MedicationKnowledge.intendedRoute",                                                                              // MakerGen.cs:239
                    Id = "MedicationKnowledge.intendedRoute",                                                                               // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 21. MedicationKnowledge.cost
                this.Element_Cost = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Cost",                                                                                                  // MakerGen.cs:238
                    Path= "MedicationKnowledge.cost",                                                                                       // MakerGen.cs:239
                    Id = "MedicationKnowledge.cost",                                                                                        // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Cost                                                                                                       // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 25. MedicationKnowledge.monitoringProgram
                this.Element_MonitoringProgram = new ElementDefinitionInfo                                                                  // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_MonitoringProgram",                                                                                     // MakerGen.cs:238
                    Path= "MedicationKnowledge.monitoringProgram",                                                                          // MakerGen.cs:239
                    Id = "MedicationKnowledge.monitoringProgram",                                                                           // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_MonitoringProgram                                                                                          // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 28. MedicationKnowledge.administrationGuidelines
                this.Element_AdministrationGuidelines = new ElementDefinitionInfo                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_AdministrationGuidelines",                                                                              // MakerGen.cs:238
                    Path= "MedicationKnowledge.administrationGuidelines",                                                                   // MakerGen.cs:239
                    Id = "MedicationKnowledge.administrationGuidelines",                                                                    // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_AdministrationGuidelines                                                                                   // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 36. MedicationKnowledge.medicineClassification
                this.Element_MedicineClassification = new ElementDefinitionInfo                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_MedicineClassification",                                                                                // MakerGen.cs:238
                    Path= "MedicationKnowledge.medicineClassification",                                                                     // MakerGen.cs:239
                    Id = "MedicationKnowledge.medicineClassification",                                                                      // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_MedicineClassification                                                                                     // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 39. MedicationKnowledge.packaging
                this.Element_Packaging = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Packaging",                                                                                             // MakerGen.cs:238
                    Path= "MedicationKnowledge.packaging",                                                                                  // MakerGen.cs:239
                    Id = "MedicationKnowledge.packaging",                                                                                   // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Packaging                                                                                                  // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 42. MedicationKnowledge.drugCharacteristic
                this.Element_DrugCharacteristic = new ElementDefinitionInfo                                                                 // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_DrugCharacteristic",                                                                                    // MakerGen.cs:238
                    Path= "MedicationKnowledge.drugCharacteristic",                                                                         // MakerGen.cs:239
                    Id = "MedicationKnowledge.drugCharacteristic",                                                                          // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_DrugCharacteristic                                                                                         // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 45. MedicationKnowledge.contraindication
                this.Element_Contraindication = new ElementDefinitionInfo                                                                   // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Contraindication",                                                                                      // MakerGen.cs:238
                    Path= "MedicationKnowledge.contraindication",                                                                           // MakerGen.cs:239
                    Id = "MedicationKnowledge.contraindication",                                                                            // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/DetectedIssue"                                                     // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 46. MedicationKnowledge.regulatory
                this.Element_Regulatory = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Regulatory",                                                                                            // MakerGen.cs:238
                    Path= "MedicationKnowledge.regulatory",                                                                                 // MakerGen.cs:239
                    Id = "MedicationKnowledge.regulatory",                                                                                  // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Regulatory                                                                                                 // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 56. MedicationKnowledge.kinetics
                this.Element_Kinetics = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Kinetics",                                                                                              // MakerGen.cs:238
                    Path= "MedicationKnowledge.kinetics",                                                                                   // MakerGen.cs:239
                    Id = "MedicationKnowledge.kinetics",                                                                                    // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Kinetics                                                                                                   // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            this.Name = "MedicationKnowledge";                                                                                              // MakerGen.cs:471
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MedicationKnowledge";                                                       // MakerGen.cs:472
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:407
}                                                                                                                                           // MakerGen.cs:452
