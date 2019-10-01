using System;                                                                                                                               // MakerGen.cs:391
using System.Diagnostics;                                                                                                                   // MakerGen.cs:392
using System.IO;                                                                                                                            // MakerGen.cs:393
using System.Linq;                                                                                                                          // MakerGen.cs:394
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:396
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:397
{                                                                                                                                           // MakerGen.cs:398
    #region Json                                                                                                                            // MakerGen.cs:399
    #if NEVER                                                                                                                               // MakerGen.cs:400
    {
      "resourceType": "StructureDefinition",
      "id": "MedicationDispense",
      "url": "http://hl7.org/fhir/StructureDefinition/MedicationDispense",
      "version": "4.0.0",
      "name": "MedicationDispense",
      "status": "draft",
      "publisher": "Health Level Seven International (Pharmacy)",
      "description": "Indicates that a medication product is to be or has been dispensed for a named person/patient.  This includes a description of the medication product (supply) provided and the instructions for administering the medication.  The medication dispense is the result of a pharmacy system responding to a medication order.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "MedicationDispense",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "MedicationDispense",
            "path": "MedicationDispense",
            "short": "Dispensing a medication to a named patient",
            "definition": "Indicates that a medication product is to be or has been dispensed for a named person/patient.  This includes a description of the medication product (supply) provided and the instructions for administering the medication.  The medication dispense is the result of a pharmacy system responding to a medication order.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "MedicationDispense.identifier",
            "path": "MedicationDispense.identifier",
            "short": "External identifier",
            "definition": "Identifiers associated with this Medication Dispense that are defined by business processes and/or used to refer to it when a direct URL reference to the resource itself is not appropriate. They are business identifiers assigned to this resource by the performer or other systems and remain constant as the resource is updated and propagates from server to server.",
            "comment": "This is a business identifier, not a resource identifier.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ]
          },
          {
            "id": "MedicationDispense.partOf",
            "path": "MedicationDispense.partOf",
            "short": "Event that dispense is part of",
            "definition": "The procedure that trigger the dispense.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Procedure"
                ]
              }
            ]
          },
          {
            "id": "MedicationDispense.status",
            "path": "MedicationDispense.status",
            "short": "preparation | in-progress | cancelled | on-hold | completed | entered-in-error | stopped | unknown",
            "definition": "A code specifying the state of the set of dispense events.",
            "comment": "This element is labeled as a modifier because the status contains codes that mark the resource as not currently valid.",
            "min": 1,
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
                  "valueString": "MedicationDispenseStatus"
                }
              ],
              "strength": "required",
              "description": "A coded concept specifying the state of the dispense event.",
              "valueSet": "http://hl7.org/fhir/ValueSet/medicationdispense-status|4.0.0"
            }
          },
          {
            "id": "MedicationDispense.statusReason[x]",
            "path": "MedicationDispense.statusReason[x]",
            "short": "Why a dispense was not performed",
            "definition": "Indicates the reason why a dispense was not performed.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/DetectedIssue"
                ]
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "MedicationDispenseStatusReason"
                }
              ],
              "strength": "example",
              "description": "A code describing why a dispense was not performed.",
              "valueSet": "http://hl7.org/fhir/ValueSet/medicationdispense-status-reason"
            }
          },
          {
            "id": "MedicationDispense.category",
            "path": "MedicationDispense.category",
            "short": "Type of medication dispense",
            "definition": "Indicates the type of medication dispense (for example, where the medication is expected to be consumed or administered (i.e. inpatient or outpatient)).",
            "comment": "The category can be used to include where the medication is expected to be consumed or other types of dispenses.  Invariants can be used to bind to different value sets when profiling to bind.",
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
                  "valueString": "MedicationDispenseCategory"
                }
              ],
              "strength": "preferred",
              "description": "A code describing where the dispensed medication is expected to be consumed or administered.",
              "valueSet": "http://hl7.org/fhir/ValueSet/medicationdispense-category"
            }
          },
          {
            "id": "MedicationDispense.medication[x]",
            "path": "MedicationDispense.medication[x]",
            "short": "What medication was supplied",
            "definition": "Identifies the medication being administered. This is either a link to a resource representing the details of the medication or a simple attribute carrying a code that identifies the medication from a known list of medications.",
            "comment": "If only a code is specified, then it needs to be a code for a specific product. If more information is required, then the use of the medication resource is recommended.  For example, if you require form or lot number, then you must reference the Medication resource.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Medication"
                ]
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "MedicationCode"
                }
              ],
              "strength": "example",
              "description": "A coded concept identifying which substance or product can be dispensed.",
              "valueSet": "http://hl7.org/fhir/ValueSet/medication-codes"
            }
          },
          {
            "id": "MedicationDispense.subject",
            "path": "MedicationDispense.subject",
            "short": "Who the dispense is for",
            "definition": "A link to a resource representing the person or the group to whom the medication will be given.",
            "comment": "SubstanceAdministration->subject->Patient.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Group"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicationDispense.context",
            "path": "MedicationDispense.context",
            "short": "Encounter / Episode associated with event",
            "definition": "The encounter or episode of care that establishes the context for this event.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Encounter",
                  "http://hl7.org/fhir/StructureDefinition/EpisodeOfCare"
                ]
              }
            ]
          },
          {
            "id": "MedicationDispense.supportingInformation",
            "path": "MedicationDispense.supportingInformation",
            "short": "Information that supports the dispensing of the medication",
            "definition": "Additional information that supports the medication being dispensed.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ]
          },
          {
            "id": "MedicationDispense.performer",
            "path": "MedicationDispense.performer",
            "short": "Who performed event",
            "definition": "Indicates who or what performed the event.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "MedicationDispense.performer.function",
            "path": "MedicationDispense.performer.function",
            "short": "Who performed the dispense and what they did",
            "definition": "Distinguishes the type of performer in the dispense.  For example, date enterer, packager, final checker.",
            "requirements": "Allows disambiguation of the types of involvement of different performers.",
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
                  "valueString": "MedicationDispensePerformerFunction"
                }
              ],
              "strength": "example",
              "description": "A code describing the role an individual played in dispensing a medication.",
              "valueSet": "http://hl7.org/fhir/ValueSet/medicationdispense-performer-function"
            }
          },
          {
            "id": "MedicationDispense.performer.actor",
            "path": "MedicationDispense.performer.actor",
            "short": "Individual who was performing",
            "definition": "The device, practitioner, etc. who performed the action.  It should be assumed that the actor is the dispenser of the medication.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                ]
              }
            ]
          },
          {
            "id": "MedicationDispense.location",
            "path": "MedicationDispense.location",
            "short": "Where the dispense occurred",
            "definition": "The principal physical location where the dispense was performed.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Location"
                ]
              }
            ]
          },
          {
            "id": "MedicationDispense.authorizingPrescription",
            "path": "MedicationDispense.authorizingPrescription",
            "short": "Medication order that authorizes the dispense",
            "definition": "Indicates the medication order that is being dispensed against.",
            "comment": "Maps to basedOn in Event logical model.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/MedicationRequest"
                ]
              }
            ]
          },
          {
            "id": "MedicationDispense.type",
            "path": "MedicationDispense.type",
            "short": "Trial fill, partial fill, emergency fill, etc.",
            "definition": "Indicates the type of dispensing event that is performed. For example, Trial Fill, Completion of Trial, Partial Fill, Emergency Fill, Samples, etc.",
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
                  "valueString": "MedicationDispenseType"
                }
              ],
              "strength": "example",
              "description": "Indicates the type of dispensing event that is performed. For example, Trial Fill, Completion of Trial, Partial Fill, Emergency Fill, Samples, etc.",
              "valueSet": "http://terminology.hl7.org/ValueSet/v3-ActPharmacySupplyType"
            }
          },
          {
            "id": "MedicationDispense.quantity",
            "path": "MedicationDispense.quantity",
            "short": "Amount dispensed",
            "definition": "The amount of medication that has been dispensed. Includes unit of measure.",
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
            "id": "MedicationDispense.daysSupply",
            "path": "MedicationDispense.daysSupply",
            "short": "Amount of medication expressed as a timing amount",
            "definition": "The amount of medication expressed as a timing amount.",
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
            "id": "MedicationDispense.whenPrepared",
            "path": "MedicationDispense.whenPrepared",
            "short": "When product was packaged and reviewed",
            "definition": "The time when the dispensed product was packaged and reviewed.",
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
            "id": "MedicationDispense.whenHandedOver",
            "path": "MedicationDispense.whenHandedOver",
            "short": "When product was given out",
            "definition": "The time the dispensed product was provided to the patient or their representative.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ]
          },
          {
            "id": "MedicationDispense.destination",
            "path": "MedicationDispense.destination",
            "short": "Where the medication was sent",
            "definition": "Identification of the facility/location where the medication was shipped to, as part of the dispense event.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Location"
                ]
              }
            ]
          },
          {
            "id": "MedicationDispense.receiver",
            "path": "MedicationDispense.receiver",
            "short": "Who collected the medication",
            "definition": "Identifies the person who picked up the medication.  This will usually be a patient or their caregiver, but some cases exist where it can be a healthcare professional.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner"
                ]
              }
            ]
          },
          {
            "id": "MedicationDispense.note",
            "path": "MedicationDispense.note",
            "short": "Information about the dispense",
            "definition": "Extra information about the dispense that could not be conveyed in the other attributes.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Annotation"
              }
            ]
          },
          {
            "id": "MedicationDispense.dosageInstruction",
            "path": "MedicationDispense.dosageInstruction",
            "short": "How the medication is to be used by the patient or administered by the caregiver",
            "definition": "Indicates how the medication is to be used by the patient.",
            "comment": "When the dose or rate is intended to change over the entire administration period (e.g. Tapering dose prescriptions), multiple instances of dosage instructions will need to be supplied to convey the different doses/rates.\rThe pharmacist reviews the medication order prior to dispense and updates the dosageInstruction based on the actual product being dispensed.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Dosage"
              }
            ]
          },
          {
            "id": "MedicationDispense.substitution",
            "path": "MedicationDispense.substitution",
            "short": "Whether a substitution was performed on the dispense",
            "definition": "Indicates whether or not substitution was made as part of the dispense.  In some cases, substitution will be expected but does not happen, in other cases substitution is not expected but does happen.  This block explains what substitution did or did not happen and why.  If nothing is specified, substitution was not done.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "MedicationDispense.substitution.wasSubstituted",
            "path": "MedicationDispense.substitution.wasSubstituted",
            "short": "Whether a substitution was or was not performed on the dispense",
            "definition": "True if the dispenser dispensed a different drug or product from what was prescribed.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "MedicationDispense.substitution.type",
            "path": "MedicationDispense.substitution.type",
            "short": "Code signifying whether a different drug was dispensed from what was prescribed",
            "definition": "A code signifying whether a different drug was dispensed from what was prescribed.",
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
                  "valueString": "MedicationIntendedSubstitutionType"
                }
              ],
              "strength": "example",
              "description": "A coded concept describing whether a different medicinal product may be dispensed other than the product as specified exactly in the prescription.",
              "valueSet": "http://terminology.hl7.org/ValueSet/v3-ActSubstanceAdminSubstitutionCode"
            }
          },
          {
            "id": "MedicationDispense.substitution.reason",
            "path": "MedicationDispense.substitution.reason",
            "short": "Why was substitution made",
            "definition": "Indicates the reason for the substitution (or lack of substitution) from what was prescribed.",
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
                  "valueString": "MedicationIntendedSubstitutionReason"
                }
              ],
              "strength": "example",
              "description": "A coded concept describing the reason that a different medication should (or should not) be substituted from what was prescribed.",
              "valueSet": "http://terminology.hl7.org/ValueSet/v3-SubstanceAdminSubstitutionReason"
            }
          },
          {
            "id": "MedicationDispense.substitution.responsibleParty",
            "path": "MedicationDispense.substitution.responsibleParty",
            "short": "Who is responsible for the substitution",
            "definition": "The person or organization that has primary responsibility for the substitution.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                ]
              }
            ]
          },
          {
            "id": "MedicationDispense.detectedIssue",
            "path": "MedicationDispense.detectedIssue",
            "short": "Clinical issue with action",
            "definition": "Indicates an actual or potential clinical issue with or between one or more active or proposed clinical actions for a patient; e.g. drug-drug interaction, duplicate therapy, dosage alert etc.",
            "comment": "This element can include a detected issue that has been identified either by a decision support system or by a clinician and may include information on the steps that were taken to address the issue.",
            "alias": [
              "Contraindication",
              "Drug Utilization Review (DUR)",
              "Alert"
            ],
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
            "id": "MedicationDispense.eventHistory",
            "path": "MedicationDispense.eventHistory",
            "short": "A list of relevant lifecycle events",
            "definition": "A summary of the events of interest that have occurred, such as when the dispense was verified.",
            "comment": "This might not include provenances for all versions of the request – only those deemed “relevant” or important. This SHALL NOT include the Provenance associated with this current version of the resource. (If that provenance is deemed to be a “relevant” change, it will need to be added as part of a later update. Until then, it can be queried directly as the Provenance that points to this version using _revinclude All Provenances should have some historical version of this Request as their subject.).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Provenance"
                ]
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:403
    /// <summary>
    /// Fhir resource 'MedicationDispense'
    /// </summary>
    // 0. MedicationDispense
    public class MedicationDispense : FhirKhit.Maker.Common.Resource.ResourceBase                                                           // MakerGen.cs:352
    {                                                                                                                                       // MakerGen.cs:353
        // 10. MedicationDispense.performer
        public class Type_Performer : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 11. MedicationDispense.performer.function
            public MakerElementInstance Element_Function;                                                                                   // MakerGen.cs:232
            // 12. MedicationDispense.performer.actor
            public MakerElementInstance Element_Actor;                                                                                      // MakerGen.cs:232
            public Type_Performer()                                                                                                         // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 11. MedicationDispense.performer.function
                    this.Element_Function = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Function",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 12. MedicationDispense.performer.actor
                    this.Element_Actor = new MakerElementInstance                                                                           // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Actor",                                                                                             // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 24. MedicationDispense.substitution
        public class Type_Substitution : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 25. MedicationDispense.substitution.wasSubstituted
            public MakerElementInstance Element_WasSubstituted;                                                                             // MakerGen.cs:232
            // 26. MedicationDispense.substitution.type
            public MakerElementInstance Element_Type;                                                                                       // MakerGen.cs:232
            // 27. MedicationDispense.substitution.reason
            public MakerElementInstance Element_Reason;                                                                                     // MakerGen.cs:232
            // 28. MedicationDispense.substitution.responsibleParty
            public MakerElementInstance Element_ResponsibleParty;                                                                           // MakerGen.cs:232
            public Type_Substitution()                                                                                                      // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 25. MedicationDispense.substitution.wasSubstituted
                    this.Element_WasSubstituted = new MakerElementInstance                                                                  // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_WasSubstituted",                                                                                    // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Boolean()                                                                   // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 26. MedicationDispense.substitution.type
                    this.Element_Type = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Type",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 27. MedicationDispense.substitution.reason
                    this.Element_Reason = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Reason",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 28. MedicationDispense.substitution.responsibleParty
                    this.Element_ResponsibleParty = new MakerElementInstance                                                                // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_ResponsibleParty",                                                                                  // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 1. MedicationDispense.identifier
        public MakerElementInstance Element_Identifier;                                                                                     // MakerGen.cs:232
        // 2. MedicationDispense.partOf
        public MakerElementInstance Element_PartOf;                                                                                         // MakerGen.cs:232
        // 3. MedicationDispense.status
        public MakerElementInstance Element_Status;                                                                                         // MakerGen.cs:232
        // 4. MedicationDispense.statusReason[x]
        public MakerElementInstance Element_StatusReason;                                                                                   // MakerGen.cs:232
        // 5. MedicationDispense.category
        public MakerElementInstance Element_Category;                                                                                       // MakerGen.cs:232
        // 6. MedicationDispense.medication[x]
        public MakerElementInstance Element_Medication;                                                                                     // MakerGen.cs:232
        // 7. MedicationDispense.subject
        public MakerElementInstance Element_Subject;                                                                                        // MakerGen.cs:232
        // 8. MedicationDispense.context
        public MakerElementInstance Element_Context;                                                                                        // MakerGen.cs:232
        // 9. MedicationDispense.supportingInformation
        public MakerElementInstance Element_SupportingInformation;                                                                          // MakerGen.cs:232
        // 13. MedicationDispense.location
        public MakerElementInstance Element_Location;                                                                                       // MakerGen.cs:232
        // 14. MedicationDispense.authorizingPrescription
        public MakerElementInstance Element_AuthorizingPrescription;                                                                        // MakerGen.cs:232
        // 15. MedicationDispense.type
        public MakerElementInstance Element_Type;                                                                                           // MakerGen.cs:232
        // 16. MedicationDispense.quantity
        public MakerElementInstance Element_Quantity;                                                                                       // MakerGen.cs:232
        // 17. MedicationDispense.daysSupply
        public MakerElementInstance Element_DaysSupply;                                                                                     // MakerGen.cs:232
        // 18. MedicationDispense.whenPrepared
        public MakerElementInstance Element_WhenPrepared;                                                                                   // MakerGen.cs:232
        // 19. MedicationDispense.whenHandedOver
        public MakerElementInstance Element_WhenHandedOver;                                                                                 // MakerGen.cs:232
        // 20. MedicationDispense.destination
        public MakerElementInstance Element_Destination;                                                                                    // MakerGen.cs:232
        // 21. MedicationDispense.receiver
        public MakerElementInstance Element_Receiver;                                                                                       // MakerGen.cs:232
        // 22. MedicationDispense.note
        public MakerElementInstance Element_Note;                                                                                           // MakerGen.cs:232
        // 23. MedicationDispense.dosageInstruction
        public MakerElementInstance Element_DosageInstruction;                                                                              // MakerGen.cs:232
        // 29. MedicationDispense.detectedIssue
        public MakerElementInstance Element_DetectedIssue;                                                                                  // MakerGen.cs:232
        // 30. MedicationDispense.eventHistory
        public MakerElementInstance Element_EventHistory;                                                                                   // MakerGen.cs:232
        public MedicationDispense()                                                                                                         // MakerGen.cs:361
        {                                                                                                                                   // MakerGen.cs:362
            {                                                                                                                               // MakerGen.cs:243
                // 1. MedicationDispense.identifier
                this.Element_Identifier = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 2. MedicationDispense.partOf
                this.Element_PartOf = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_PartOf",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 3. MedicationDispense.status
                this.Element_Status = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Status",                                                                                                // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code()                                                                          // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 4. MedicationDispense.statusReason[x]
                this.Element_StatusReason = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_StatusReason",                                                                                          // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept(),                                                                // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 5. MedicationDispense.category
                this.Element_Category = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Category",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 6. MedicationDispense.medication[x]
                this.Element_Medication = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Medication",                                                                                            // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept(),                                                                // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 7. MedicationDispense.subject
                this.Element_Subject = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Subject",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 8. MedicationDispense.context
                this.Element_Context = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Context",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 9. MedicationDispense.supportingInformation
                this.Element_SupportingInformation = new MakerElementInstance                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_SupportingInformation",                                                                                 // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 13. MedicationDispense.location
                this.Element_Location = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Location",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 14. MedicationDispense.authorizingPrescription
                this.Element_AuthorizingPrescription = new MakerElementInstance                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_AuthorizingPrescription",                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 15. MedicationDispense.type
                this.Element_Type = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 16. MedicationDispense.quantity
                this.Element_Quantity = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Quantity",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 17. MedicationDispense.daysSupply
                this.Element_DaysSupply = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_DaysSupply",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 18. MedicationDispense.whenPrepared
                this.Element_WhenPrepared = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_WhenPrepared",                                                                                          // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.DateTime()                                                                      // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 19. MedicationDispense.whenHandedOver
                this.Element_WhenHandedOver = new MakerElementInstance                                                                      // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_WhenHandedOver",                                                                                        // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.DateTime()                                                                      // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 20. MedicationDispense.destination
                this.Element_Destination = new MakerElementInstance                                                                         // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Destination",                                                                                           // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 21. MedicationDispense.receiver
                this.Element_Receiver = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Receiver",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 22. MedicationDispense.note
                this.Element_Note = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Note",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 23. MedicationDispense.dosageInstruction
                this.Element_DosageInstruction = new MakerElementInstance                                                                   // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_DosageInstruction",                                                                                     // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 29. MedicationDispense.detectedIssue
                this.Element_DetectedIssue = new MakerElementInstance                                                                       // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_DetectedIssue",                                                                                         // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 30. MedicationDispense.eventHistory
                this.Element_EventHistory = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_EventHistory",                                                                                          // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
        }                                                                                                                                   // MakerGen.cs:373
    }                                                                                                                                       // MakerGen.cs:357
}                                                                                                                                           // MakerGen.cs:408
