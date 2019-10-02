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
    #endregion
    /// <summary>
    /// Fhir resource 'MedicationKnowledge'
    /// </summary>
    // 0. MedicationKnowledge
    public class Resource_MedicationKnowledge : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 7. MedicationKnowledge.relatedMedicationKnowledge
        public class Type_RelatedMedicationKnowledge : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 8. MedicationKnowledge.relatedMedicationKnowledge.type
            public ElementDefinitionInfo Element_Type;
            // 9. MedicationKnowledge.relatedMedicationKnowledge.reference
            public ElementDefinitionInfo Element_Reference;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "MedicationKnowledge.relatedMedicationKnowledge",
                    ElementId = "MedicationKnowledge.relatedMedicationKnowledge"
                });
                Element_Type.Write(sDef);
                Element_Reference.Write(sDef);
            }
            
            public Type_RelatedMedicationKnowledge()
            {
                {
                    // 8. MedicationKnowledge.relatedMedicationKnowledge.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "MedicationKnowledge.relatedMedicationKnowledge.type",
                        Id = "MedicationKnowledge.relatedMedicationKnowledge.type",
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
                    // 9. MedicationKnowledge.relatedMedicationKnowledge.reference
                    this.Element_Reference = new ElementDefinitionInfo
                    {
                        Name = "Element_Reference",
                        Path= "MedicationKnowledge.relatedMedicationKnowledge.reference",
                        Id = "MedicationKnowledge.relatedMedicationKnowledge.reference",
                        Min = 1,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/MedicationKnowledge"
                                }
                            }
                        }
                    };
                }
            }
        }
        // 12. MedicationKnowledge.monograph
        public class Type_Monograph : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 13. MedicationKnowledge.monograph.type
            public ElementDefinitionInfo Element_Type;
            // 14. MedicationKnowledge.monograph.source
            public ElementDefinitionInfo Element_Source;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "MedicationKnowledge.monograph",
                    ElementId = "MedicationKnowledge.monograph"
                });
                Element_Type.Write(sDef);
                Element_Source.Write(sDef);
            }
            
            public Type_Monograph()
            {
                {
                    // 13. MedicationKnowledge.monograph.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "MedicationKnowledge.monograph.type",
                        Id = "MedicationKnowledge.monograph.type",
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
                    // 14. MedicationKnowledge.monograph.source
                    this.Element_Source = new ElementDefinitionInfo
                    {
                        Name = "Element_Source",
                        Path= "MedicationKnowledge.monograph.source",
                        Id = "MedicationKnowledge.monograph.source",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference",
                                    "http://hl7.org/fhir/StructureDefinition/Media"
                                }
                            }
                        }
                    };
                }
            }
        }
        // 15. MedicationKnowledge.ingredient
        public class Type_Ingredient : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 16. MedicationKnowledge.ingredient.item[x]
            public ElementDefinitionInfo Element_Item;
            // 17. MedicationKnowledge.ingredient.isActive
            public ElementDefinitionInfo Element_IsActive;
            // 18. MedicationKnowledge.ingredient.strength
            public ElementDefinitionInfo Element_Strength;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "MedicationKnowledge.ingredient",
                    ElementId = "MedicationKnowledge.ingredient"
                });
                Element_Item.Write(sDef);
                Element_IsActive.Write(sDef);
                Element_Strength.Write(sDef);
            }
            
            public Type_Ingredient()
            {
                {
                    // 16. MedicationKnowledge.ingredient.item[x]
                    this.Element_Item = new ElementDefinitionInfo
                    {
                        Name = "Element_Item",
                        Path= "MedicationKnowledge.ingredient.item[x]",
                        Id = "MedicationKnowledge.ingredient.item[x]",
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
                {
                    // 17. MedicationKnowledge.ingredient.isActive
                    this.Element_IsActive = new ElementDefinitionInfo
                    {
                        Name = "Element_IsActive",
                        Path= "MedicationKnowledge.ingredient.isActive",
                        Id = "MedicationKnowledge.ingredient.isActive",
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
                    // 18. MedicationKnowledge.ingredient.strength
                    this.Element_Strength = new ElementDefinitionInfo
                    {
                        Name = "Element_Strength",
                        Path= "MedicationKnowledge.ingredient.strength",
                        Id = "MedicationKnowledge.ingredient.strength",
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
        // 21. MedicationKnowledge.cost
        public class Type_Cost : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 22. MedicationKnowledge.cost.type
            public ElementDefinitionInfo Element_Type;
            // 23. MedicationKnowledge.cost.source
            public ElementDefinitionInfo Element_Source;
            // 24. MedicationKnowledge.cost.cost
            public ElementDefinitionInfo Element_Cost;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "MedicationKnowledge.cost",
                    ElementId = "MedicationKnowledge.cost"
                });
                Element_Type.Write(sDef);
                Element_Source.Write(sDef);
                Element_Cost.Write(sDef);
            }
            
            public Type_Cost()
            {
                {
                    // 22. MedicationKnowledge.cost.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "MedicationKnowledge.cost.type",
                        Id = "MedicationKnowledge.cost.type",
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
                    // 23. MedicationKnowledge.cost.source
                    this.Element_Source = new ElementDefinitionInfo
                    {
                        Name = "Element_Source",
                        Path= "MedicationKnowledge.cost.source",
                        Id = "MedicationKnowledge.cost.source",
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
                    // 24. MedicationKnowledge.cost.cost
                    this.Element_Cost = new ElementDefinitionInfo
                    {
                        Name = "Element_Cost",
                        Path= "MedicationKnowledge.cost.cost",
                        Id = "MedicationKnowledge.cost.cost",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Money
                            {
                            }
                        }
                    };
                }
            }
        }
        // 25. MedicationKnowledge.monitoringProgram
        public class Type_MonitoringProgram : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 26. MedicationKnowledge.monitoringProgram.type
            public ElementDefinitionInfo Element_Type;
            // 27. MedicationKnowledge.monitoringProgram.name
            public ElementDefinitionInfo Element_Name;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "MedicationKnowledge.monitoringProgram",
                    ElementId = "MedicationKnowledge.monitoringProgram"
                });
                Element_Type.Write(sDef);
                Element_Name.Write(sDef);
            }
            
            public Type_MonitoringProgram()
            {
                {
                    // 26. MedicationKnowledge.monitoringProgram.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "MedicationKnowledge.monitoringProgram.type",
                        Id = "MedicationKnowledge.monitoringProgram.type",
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
                    // 27. MedicationKnowledge.monitoringProgram.name
                    this.Element_Name = new ElementDefinitionInfo
                    {
                        Name = "Element_Name",
                        Path= "MedicationKnowledge.monitoringProgram.name",
                        Id = "MedicationKnowledge.monitoringProgram.name",
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
        // 28. MedicationKnowledge.administrationGuidelines
        public class Type_AdministrationGuidelines : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 29. MedicationKnowledge.administrationGuidelines.dosage
            public class Type_Dosage : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 30. MedicationKnowledge.administrationGuidelines.dosage.type
                public ElementDefinitionInfo Element_Type;
                // 31. MedicationKnowledge.administrationGuidelines.dosage.dosage
                public ElementDefinitionInfo Element_Dosage;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "MedicationKnowledge.administrationGuidelines.dosage",
                        ElementId = "MedicationKnowledge.administrationGuidelines.dosage"
                    });
                    Element_Type.Write(sDef);
                    Element_Dosage.Write(sDef);
                }
                
                public Type_Dosage()
                {
                    {
                        // 30. MedicationKnowledge.administrationGuidelines.dosage.type
                        this.Element_Type = new ElementDefinitionInfo
                        {
                            Name = "Element_Type",
                            Path= "MedicationKnowledge.administrationGuidelines.dosage.type",
                            Id = "MedicationKnowledge.administrationGuidelines.dosage.type",
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
                        // 31. MedicationKnowledge.administrationGuidelines.dosage.dosage
                        this.Element_Dosage = new ElementDefinitionInfo
                        {
                            Name = "Element_Dosage",
                            Path= "MedicationKnowledge.administrationGuidelines.dosage.dosage",
                            Id = "MedicationKnowledge.administrationGuidelines.dosage.dosage",
                            Min = 1,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_Dosage
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 33. MedicationKnowledge.administrationGuidelines.patientCharacteristics
            public class Type_PatientCharacteristics : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 34. MedicationKnowledge.administrationGuidelines.patientCharacteristics.characteristic[x]
                public ElementDefinitionInfo Element_Characteristic;
                // 35. MedicationKnowledge.administrationGuidelines.patientCharacteristics.value
                public ElementDefinitionInfo Element_Value;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "MedicationKnowledge.administrationGuidelines.patientCharacteristics",
                        ElementId = "MedicationKnowledge.administrationGuidelines.patientCharacteristics"
                    });
                    Element_Characteristic.Write(sDef);
                    Element_Value.Write(sDef);
                }
                
                public Type_PatientCharacteristics()
                {
                    {
                        // 34. MedicationKnowledge.administrationGuidelines.patientCharacteristics.characteristic[x]
                        this.Element_Characteristic = new ElementDefinitionInfo
                        {
                            Name = "Element_Characteristic",
                            Path= "MedicationKnowledge.administrationGuidelines.patientCharacteristics.characteristic[x]",
                            Id = "MedicationKnowledge.administrationGuidelines.patientCharacteristics.characteristic[x]",
                            Min = 1,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                                {
                                },
                                new FhirKhit.Maker.Common.Complex.Type_Quantity
                                {
                                }
                            }
                        };
                    }
                    {
                        // 35. MedicationKnowledge.administrationGuidelines.patientCharacteristics.value
                        this.Element_Value = new ElementDefinitionInfo
                        {
                            Name = "Element_Value",
                            Path= "MedicationKnowledge.administrationGuidelines.patientCharacteristics.value",
                            Id = "MedicationKnowledge.administrationGuidelines.patientCharacteristics.value",
                            Min = 0,
                            Max = -1,
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
            // 29. MedicationKnowledge.administrationGuidelines.dosage
            public ElementDefinitionInfo Element_Dosage;
            // 32. MedicationKnowledge.administrationGuidelines.indication[x]
            public ElementDefinitionInfo Element_Indication;
            // 33. MedicationKnowledge.administrationGuidelines.patientCharacteristics
            public ElementDefinitionInfo Element_PatientCharacteristics;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "MedicationKnowledge.administrationGuidelines",
                    ElementId = "MedicationKnowledge.administrationGuidelines"
                });
                Element_Dosage.Write(sDef);
                Element_Indication.Write(sDef);
                Element_PatientCharacteristics.Write(sDef);
            }
            
            public Type_AdministrationGuidelines()
            {
                {
                    // 29. MedicationKnowledge.administrationGuidelines.dosage
                    this.Element_Dosage = new ElementDefinitionInfo
                    {
                        Name = "Element_Dosage",
                        Path= "MedicationKnowledge.administrationGuidelines.dosage",
                        Id = "MedicationKnowledge.administrationGuidelines.dosage",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Dosage
                            {
                            }
                        }
                    };
                }
                {
                    // 32. MedicationKnowledge.administrationGuidelines.indication[x]
                    this.Element_Indication = new ElementDefinitionInfo
                    {
                        Name = "Element_Indication",
                        Path= "MedicationKnowledge.administrationGuidelines.indication[x]",
                        Id = "MedicationKnowledge.administrationGuidelines.indication[x]",
                        Min = 0,
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
                                    "http://hl7.org/fhir/StructureDefinition/ObservationDefinition"
                                }
                            }
                        }
                    };
                }
                {
                    // 33. MedicationKnowledge.administrationGuidelines.patientCharacteristics
                    this.Element_PatientCharacteristics = new ElementDefinitionInfo
                    {
                        Name = "Element_PatientCharacteristics",
                        Path= "MedicationKnowledge.administrationGuidelines.patientCharacteristics",
                        Id = "MedicationKnowledge.administrationGuidelines.patientCharacteristics",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_PatientCharacteristics
                            {
                            }
                        }
                    };
                }
            }
        }
        // 36. MedicationKnowledge.medicineClassification
        public class Type_MedicineClassification : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 37. MedicationKnowledge.medicineClassification.type
            public ElementDefinitionInfo Element_Type;
            // 38. MedicationKnowledge.medicineClassification.classification
            public ElementDefinitionInfo Element_Classification;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "MedicationKnowledge.medicineClassification",
                    ElementId = "MedicationKnowledge.medicineClassification"
                });
                Element_Type.Write(sDef);
                Element_Classification.Write(sDef);
            }
            
            public Type_MedicineClassification()
            {
                {
                    // 37. MedicationKnowledge.medicineClassification.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "MedicationKnowledge.medicineClassification.type",
                        Id = "MedicationKnowledge.medicineClassification.type",
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
                    // 38. MedicationKnowledge.medicineClassification.classification
                    this.Element_Classification = new ElementDefinitionInfo
                    {
                        Name = "Element_Classification",
                        Path= "MedicationKnowledge.medicineClassification.classification",
                        Id = "MedicationKnowledge.medicineClassification.classification",
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
        // 39. MedicationKnowledge.packaging
        public class Type_Packaging : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 40. MedicationKnowledge.packaging.type
            public ElementDefinitionInfo Element_Type;
            // 41. MedicationKnowledge.packaging.quantity
            public ElementDefinitionInfo Element_Quantity;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "MedicationKnowledge.packaging",
                    ElementId = "MedicationKnowledge.packaging"
                });
                Element_Type.Write(sDef);
                Element_Quantity.Write(sDef);
            }
            
            public Type_Packaging()
            {
                {
                    // 40. MedicationKnowledge.packaging.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "MedicationKnowledge.packaging.type",
                        Id = "MedicationKnowledge.packaging.type",
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
                    // 41. MedicationKnowledge.packaging.quantity
                    this.Element_Quantity = new ElementDefinitionInfo
                    {
                        Name = "Element_Quantity",
                        Path= "MedicationKnowledge.packaging.quantity",
                        Id = "MedicationKnowledge.packaging.quantity",
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
        // 42. MedicationKnowledge.drugCharacteristic
        public class Type_DrugCharacteristic : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 43. MedicationKnowledge.drugCharacteristic.type
            public ElementDefinitionInfo Element_Type;
            // 44. MedicationKnowledge.drugCharacteristic.value[x]
            public ElementDefinitionInfo Element_Value;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "MedicationKnowledge.drugCharacteristic",
                    ElementId = "MedicationKnowledge.drugCharacteristic"
                });
                Element_Type.Write(sDef);
                Element_Value.Write(sDef);
            }
            
            public Type_DrugCharacteristic()
            {
                {
                    // 43. MedicationKnowledge.drugCharacteristic.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "MedicationKnowledge.drugCharacteristic.type",
                        Id = "MedicationKnowledge.drugCharacteristic.type",
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
                    // 44. MedicationKnowledge.drugCharacteristic.value[x]
                    this.Element_Value = new ElementDefinitionInfo
                    {
                        Name = "Element_Value",
                        Path= "MedicationKnowledge.drugCharacteristic.value[x]",
                        Id = "MedicationKnowledge.drugCharacteristic.value[x]",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_String
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Quantity
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_Base64Binary
                            {
                            }
                        }
                    };
                }
            }
        }
        // 46. MedicationKnowledge.regulatory
        public class Type_Regulatory : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 48. MedicationKnowledge.regulatory.substitution
            public class Type_Substitution : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 49. MedicationKnowledge.regulatory.substitution.type
                public ElementDefinitionInfo Element_Type;
                // 50. MedicationKnowledge.regulatory.substitution.allowed
                public ElementDefinitionInfo Element_Allowed;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "MedicationKnowledge.regulatory.substitution",
                        ElementId = "MedicationKnowledge.regulatory.substitution"
                    });
                    Element_Type.Write(sDef);
                    Element_Allowed.Write(sDef);
                }
                
                public Type_Substitution()
                {
                    {
                        // 49. MedicationKnowledge.regulatory.substitution.type
                        this.Element_Type = new ElementDefinitionInfo
                        {
                            Name = "Element_Type",
                            Path= "MedicationKnowledge.regulatory.substitution.type",
                            Id = "MedicationKnowledge.regulatory.substitution.type",
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
                        // 50. MedicationKnowledge.regulatory.substitution.allowed
                        this.Element_Allowed = new ElementDefinitionInfo
                        {
                            Name = "Element_Allowed",
                            Path= "MedicationKnowledge.regulatory.substitution.allowed",
                            Id = "MedicationKnowledge.regulatory.substitution.allowed",
                            Min = 1,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_Boolean
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 51. MedicationKnowledge.regulatory.schedule
            public class Type_Schedule : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 52. MedicationKnowledge.regulatory.schedule.schedule
                public ElementDefinitionInfo Element_Schedule;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "MedicationKnowledge.regulatory.schedule",
                        ElementId = "MedicationKnowledge.regulatory.schedule"
                    });
                    Element_Schedule.Write(sDef);
                }
                
                public Type_Schedule()
                {
                    {
                        // 52. MedicationKnowledge.regulatory.schedule.schedule
                        this.Element_Schedule = new ElementDefinitionInfo
                        {
                            Name = "Element_Schedule",
                            Path= "MedicationKnowledge.regulatory.schedule.schedule",
                            Id = "MedicationKnowledge.regulatory.schedule.schedule",
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
                }
            }
            // 53. MedicationKnowledge.regulatory.maxDispense
            public class Type_MaxDispense : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 54. MedicationKnowledge.regulatory.maxDispense.quantity
                public ElementDefinitionInfo Element_Quantity;
                // 55. MedicationKnowledge.regulatory.maxDispense.period
                public ElementDefinitionInfo Element_Period;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "MedicationKnowledge.regulatory.maxDispense",
                        ElementId = "MedicationKnowledge.regulatory.maxDispense"
                    });
                    Element_Quantity.Write(sDef);
                    Element_Period.Write(sDef);
                }
                
                public Type_MaxDispense()
                {
                    {
                        // 54. MedicationKnowledge.regulatory.maxDispense.quantity
                        this.Element_Quantity = new ElementDefinitionInfo
                        {
                            Name = "Element_Quantity",
                            Path= "MedicationKnowledge.regulatory.maxDispense.quantity",
                            Id = "MedicationKnowledge.regulatory.maxDispense.quantity",
                            Min = 1,
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
                        // 55. MedicationKnowledge.regulatory.maxDispense.period
                        this.Element_Period = new ElementDefinitionInfo
                        {
                            Name = "Element_Period",
                            Path= "MedicationKnowledge.regulatory.maxDispense.period",
                            Id = "MedicationKnowledge.regulatory.maxDispense.period",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_Duration
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 47. MedicationKnowledge.regulatory.regulatoryAuthority
            public ElementDefinitionInfo Element_RegulatoryAuthority;
            // 48. MedicationKnowledge.regulatory.substitution
            public ElementDefinitionInfo Element_Substitution;
            // 51. MedicationKnowledge.regulatory.schedule
            public ElementDefinitionInfo Element_Schedule;
            // 53. MedicationKnowledge.regulatory.maxDispense
            public ElementDefinitionInfo Element_MaxDispense;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "MedicationKnowledge.regulatory",
                    ElementId = "MedicationKnowledge.regulatory"
                });
                Element_RegulatoryAuthority.Write(sDef);
                Element_Substitution.Write(sDef);
                Element_Schedule.Write(sDef);
                Element_MaxDispense.Write(sDef);
            }
            
            public Type_Regulatory()
            {
                {
                    // 47. MedicationKnowledge.regulatory.regulatoryAuthority
                    this.Element_RegulatoryAuthority = new ElementDefinitionInfo
                    {
                        Name = "Element_RegulatoryAuthority",
                        Path= "MedicationKnowledge.regulatory.regulatoryAuthority",
                        Id = "MedicationKnowledge.regulatory.regulatoryAuthority",
                        Min = 1,
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
                    // 48. MedicationKnowledge.regulatory.substitution
                    this.Element_Substitution = new ElementDefinitionInfo
                    {
                        Name = "Element_Substitution",
                        Path= "MedicationKnowledge.regulatory.substitution",
                        Id = "MedicationKnowledge.regulatory.substitution",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Substitution
                            {
                            }
                        }
                    };
                }
                {
                    // 51. MedicationKnowledge.regulatory.schedule
                    this.Element_Schedule = new ElementDefinitionInfo
                    {
                        Name = "Element_Schedule",
                        Path= "MedicationKnowledge.regulatory.schedule",
                        Id = "MedicationKnowledge.regulatory.schedule",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Schedule
                            {
                            }
                        }
                    };
                }
                {
                    // 53. MedicationKnowledge.regulatory.maxDispense
                    this.Element_MaxDispense = new ElementDefinitionInfo
                    {
                        Name = "Element_MaxDispense",
                        Path= "MedicationKnowledge.regulatory.maxDispense",
                        Id = "MedicationKnowledge.regulatory.maxDispense",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new Type_MaxDispense
                            {
                            }
                        }
                    };
                }
            }
        }
        // 56. MedicationKnowledge.kinetics
        public class Type_Kinetics : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 57. MedicationKnowledge.kinetics.areaUnderCurve
            public ElementDefinitionInfo Element_AreaUnderCurve;
            // 58. MedicationKnowledge.kinetics.lethalDose50
            public ElementDefinitionInfo Element_LethalDose50;
            // 59. MedicationKnowledge.kinetics.halfLifePeriod
            public ElementDefinitionInfo Element_HalfLifePeriod;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "MedicationKnowledge.kinetics",
                    ElementId = "MedicationKnowledge.kinetics"
                });
                Element_AreaUnderCurve.Write(sDef);
                Element_LethalDose50.Write(sDef);
                Element_HalfLifePeriod.Write(sDef);
            }
            
            public Type_Kinetics()
            {
                {
                    // 57. MedicationKnowledge.kinetics.areaUnderCurve
                    this.Element_AreaUnderCurve = new ElementDefinitionInfo
                    {
                        Name = "Element_AreaUnderCurve",
                        Path= "MedicationKnowledge.kinetics.areaUnderCurve",
                        Id = "MedicationKnowledge.kinetics.areaUnderCurve",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Quantity
                            {
                            }
                        }
                    };
                }
                {
                    // 58. MedicationKnowledge.kinetics.lethalDose50
                    this.Element_LethalDose50 = new ElementDefinitionInfo
                    {
                        Name = "Element_LethalDose50",
                        Path= "MedicationKnowledge.kinetics.lethalDose50",
                        Id = "MedicationKnowledge.kinetics.lethalDose50",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Quantity
                            {
                            }
                        }
                    };
                }
                {
                    // 59. MedicationKnowledge.kinetics.halfLifePeriod
                    this.Element_HalfLifePeriod = new ElementDefinitionInfo
                    {
                        Name = "Element_HalfLifePeriod",
                        Path= "MedicationKnowledge.kinetics.halfLifePeriod",
                        Id = "MedicationKnowledge.kinetics.halfLifePeriod",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Duration
                            {
                            }
                        }
                    };
                }
            }
        }
        // 1. MedicationKnowledge.code
        public ElementDefinitionInfo Element_Code;
        // 2. MedicationKnowledge.status
        public ElementDefinitionInfo Element_Status;
        // 3. MedicationKnowledge.manufacturer
        public ElementDefinitionInfo Element_Manufacturer;
        // 4. MedicationKnowledge.doseForm
        public ElementDefinitionInfo Element_DoseForm;
        // 5. MedicationKnowledge.amount
        public ElementDefinitionInfo Element_Amount;
        // 6. MedicationKnowledge.synonym
        public ElementDefinitionInfo Element_Synonym;
        // 7. MedicationKnowledge.relatedMedicationKnowledge
        public ElementDefinitionInfo Element_RelatedMedicationKnowledge;
        // 10. MedicationKnowledge.associatedMedication
        public ElementDefinitionInfo Element_AssociatedMedication;
        // 11. MedicationKnowledge.productType
        public ElementDefinitionInfo Element_ProductType;
        // 12. MedicationKnowledge.monograph
        public ElementDefinitionInfo Element_Monograph;
        // 15. MedicationKnowledge.ingredient
        public ElementDefinitionInfo Element_Ingredient;
        // 19. MedicationKnowledge.preparationInstruction
        public ElementDefinitionInfo Element_PreparationInstruction;
        // 20. MedicationKnowledge.intendedRoute
        public ElementDefinitionInfo Element_IntendedRoute;
        // 21. MedicationKnowledge.cost
        public ElementDefinitionInfo Element_Cost;
        // 25. MedicationKnowledge.monitoringProgram
        public ElementDefinitionInfo Element_MonitoringProgram;
        // 28. MedicationKnowledge.administrationGuidelines
        public ElementDefinitionInfo Element_AdministrationGuidelines;
        // 36. MedicationKnowledge.medicineClassification
        public ElementDefinitionInfo Element_MedicineClassification;
        // 39. MedicationKnowledge.packaging
        public ElementDefinitionInfo Element_Packaging;
        // 42. MedicationKnowledge.drugCharacteristic
        public ElementDefinitionInfo Element_DrugCharacteristic;
        // 45. MedicationKnowledge.contraindication
        public ElementDefinitionInfo Element_Contraindication;
        // 46. MedicationKnowledge.regulatory
        public ElementDefinitionInfo Element_Regulatory;
        // 56. MedicationKnowledge.kinetics
        public ElementDefinitionInfo Element_Kinetics;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "MedicationKnowledge",
                ElementId = "MedicationKnowledge"
            });
            Element_Code.Write(sDef);
            Element_Status.Write(sDef);
            Element_Manufacturer.Write(sDef);
            Element_DoseForm.Write(sDef);
            Element_Amount.Write(sDef);
            Element_Synonym.Write(sDef);
            Element_RelatedMedicationKnowledge.Write(sDef);
            Element_AssociatedMedication.Write(sDef);
            Element_ProductType.Write(sDef);
            Element_Monograph.Write(sDef);
            Element_Ingredient.Write(sDef);
            Element_PreparationInstruction.Write(sDef);
            Element_IntendedRoute.Write(sDef);
            Element_Cost.Write(sDef);
            Element_MonitoringProgram.Write(sDef);
            Element_AdministrationGuidelines.Write(sDef);
            Element_MedicineClassification.Write(sDef);
            Element_Packaging.Write(sDef);
            Element_DrugCharacteristic.Write(sDef);
            Element_Contraindication.Write(sDef);
            Element_Regulatory.Write(sDef);
            Element_Kinetics.Write(sDef);
        }
        
        public Resource_MedicationKnowledge()
        {
            {
                // 1. MedicationKnowledge.code
                this.Element_Code = new ElementDefinitionInfo
                {
                    Name = "Element_Code",
                    Path= "MedicationKnowledge.code",
                    Id = "MedicationKnowledge.code",
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
                // 2. MedicationKnowledge.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "MedicationKnowledge.status",
                    Id = "MedicationKnowledge.status",
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
                // 3. MedicationKnowledge.manufacturer
                this.Element_Manufacturer = new ElementDefinitionInfo
                {
                    Name = "Element_Manufacturer",
                    Path= "MedicationKnowledge.manufacturer",
                    Id = "MedicationKnowledge.manufacturer",
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
                // 4. MedicationKnowledge.doseForm
                this.Element_DoseForm = new ElementDefinitionInfo
                {
                    Name = "Element_DoseForm",
                    Path= "MedicationKnowledge.doseForm",
                    Id = "MedicationKnowledge.doseForm",
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
                // 5. MedicationKnowledge.amount
                this.Element_Amount = new ElementDefinitionInfo
                {
                    Name = "Element_Amount",
                    Path= "MedicationKnowledge.amount",
                    Id = "MedicationKnowledge.amount",
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
                // 6. MedicationKnowledge.synonym
                this.Element_Synonym = new ElementDefinitionInfo
                {
                    Name = "Element_Synonym",
                    Path= "MedicationKnowledge.synonym",
                    Id = "MedicationKnowledge.synonym",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_String
                        {
                        }
                    }
                };
            }
            {
                // 7. MedicationKnowledge.relatedMedicationKnowledge
                this.Element_RelatedMedicationKnowledge = new ElementDefinitionInfo
                {
                    Name = "Element_RelatedMedicationKnowledge",
                    Path= "MedicationKnowledge.relatedMedicationKnowledge",
                    Id = "MedicationKnowledge.relatedMedicationKnowledge",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_RelatedMedicationKnowledge
                        {
                        }
                    }
                };
            }
            {
                // 10. MedicationKnowledge.associatedMedication
                this.Element_AssociatedMedication = new ElementDefinitionInfo
                {
                    Name = "Element_AssociatedMedication",
                    Path= "MedicationKnowledge.associatedMedication",
                    Id = "MedicationKnowledge.associatedMedication",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Medication"
                            }
                        }
                    }
                };
            }
            {
                // 11. MedicationKnowledge.productType
                this.Element_ProductType = new ElementDefinitionInfo
                {
                    Name = "Element_ProductType",
                    Path= "MedicationKnowledge.productType",
                    Id = "MedicationKnowledge.productType",
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
                // 12. MedicationKnowledge.monograph
                this.Element_Monograph = new ElementDefinitionInfo
                {
                    Name = "Element_Monograph",
                    Path= "MedicationKnowledge.monograph",
                    Id = "MedicationKnowledge.monograph",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Monograph
                        {
                        }
                    }
                };
            }
            {
                // 15. MedicationKnowledge.ingredient
                this.Element_Ingredient = new ElementDefinitionInfo
                {
                    Name = "Element_Ingredient",
                    Path= "MedicationKnowledge.ingredient",
                    Id = "MedicationKnowledge.ingredient",
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
                // 19. MedicationKnowledge.preparationInstruction
                this.Element_PreparationInstruction = new ElementDefinitionInfo
                {
                    Name = "Element_PreparationInstruction",
                    Path= "MedicationKnowledge.preparationInstruction",
                    Id = "MedicationKnowledge.preparationInstruction",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Markdown
                        {
                        }
                    }
                };
            }
            {
                // 20. MedicationKnowledge.intendedRoute
                this.Element_IntendedRoute = new ElementDefinitionInfo
                {
                    Name = "Element_IntendedRoute",
                    Path= "MedicationKnowledge.intendedRoute",
                    Id = "MedicationKnowledge.intendedRoute",
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
                // 21. MedicationKnowledge.cost
                this.Element_Cost = new ElementDefinitionInfo
                {
                    Name = "Element_Cost",
                    Path= "MedicationKnowledge.cost",
                    Id = "MedicationKnowledge.cost",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Cost
                        {
                        }
                    }
                };
            }
            {
                // 25. MedicationKnowledge.monitoringProgram
                this.Element_MonitoringProgram = new ElementDefinitionInfo
                {
                    Name = "Element_MonitoringProgram",
                    Path= "MedicationKnowledge.monitoringProgram",
                    Id = "MedicationKnowledge.monitoringProgram",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_MonitoringProgram
                        {
                        }
                    }
                };
            }
            {
                // 28. MedicationKnowledge.administrationGuidelines
                this.Element_AdministrationGuidelines = new ElementDefinitionInfo
                {
                    Name = "Element_AdministrationGuidelines",
                    Path= "MedicationKnowledge.administrationGuidelines",
                    Id = "MedicationKnowledge.administrationGuidelines",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_AdministrationGuidelines
                        {
                        }
                    }
                };
            }
            {
                // 36. MedicationKnowledge.medicineClassification
                this.Element_MedicineClassification = new ElementDefinitionInfo
                {
                    Name = "Element_MedicineClassification",
                    Path= "MedicationKnowledge.medicineClassification",
                    Id = "MedicationKnowledge.medicineClassification",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_MedicineClassification
                        {
                        }
                    }
                };
            }
            {
                // 39. MedicationKnowledge.packaging
                this.Element_Packaging = new ElementDefinitionInfo
                {
                    Name = "Element_Packaging",
                    Path= "MedicationKnowledge.packaging",
                    Id = "MedicationKnowledge.packaging",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_Packaging
                        {
                        }
                    }
                };
            }
            {
                // 42. MedicationKnowledge.drugCharacteristic
                this.Element_DrugCharacteristic = new ElementDefinitionInfo
                {
                    Name = "Element_DrugCharacteristic",
                    Path= "MedicationKnowledge.drugCharacteristic",
                    Id = "MedicationKnowledge.drugCharacteristic",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_DrugCharacteristic
                        {
                        }
                    }
                };
            }
            {
                // 45. MedicationKnowledge.contraindication
                this.Element_Contraindication = new ElementDefinitionInfo
                {
                    Name = "Element_Contraindication",
                    Path= "MedicationKnowledge.contraindication",
                    Id = "MedicationKnowledge.contraindication",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/DetectedIssue"
                            }
                        }
                    }
                };
            }
            {
                // 46. MedicationKnowledge.regulatory
                this.Element_Regulatory = new ElementDefinitionInfo
                {
                    Name = "Element_Regulatory",
                    Path= "MedicationKnowledge.regulatory",
                    Id = "MedicationKnowledge.regulatory",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Regulatory
                        {
                        }
                    }
                };
            }
            {
                // 56. MedicationKnowledge.kinetics
                this.Element_Kinetics = new ElementDefinitionInfo
                {
                    Name = "Element_Kinetics",
                    Path= "MedicationKnowledge.kinetics",
                    Id = "MedicationKnowledge.kinetics",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Kinetics
                        {
                        }
                    }
                };
            }
            this.Name = "MedicationKnowledge";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MedicationKnowledge";
        }
    }
}
