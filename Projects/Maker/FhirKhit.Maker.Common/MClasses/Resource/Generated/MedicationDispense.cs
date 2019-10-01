using System;                                                                                                                               // MakerGen.cs:462
using System.Diagnostics;                                                                                                                   // MakerGen.cs:463
using System.IO;                                                                                                                            // MakerGen.cs:464
using System.Linq;                                                                                                                          // MakerGen.cs:465
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:466
                                                                                                                                            // MakerGen.cs:467
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:468
{                                                                                                                                           // MakerGen.cs:469
    #region Json                                                                                                                            // MakerGen.cs:470
    #if NEVER                                                                                                                               // MakerGen.cs:471
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
    #endregion                                                                                                                              // MakerGen.cs:474
    /// <summary>
    /// Fhir resource 'MedicationDispense'
    /// </summary>
    // 0. MedicationDispense
    public class MedicationDispense : FhirKhit.Maker.Common.Resource.ResourceBase                                                           // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        public class MedicationDispense_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                              // MakerGen.cs:386
        {                                                                                                                                   // MakerGen.cs:387
            // 10. MedicationDispense.performer
            public class Type_Performer : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_Performer_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 11. MedicationDispense.performer.function
                    public ElementDefinitionInfo Function;                                                                                  // MakerGen.cs:216
                    // 12. MedicationDispense.performer.actor
                    public ElementDefinitionInfo Actor;                                                                                     // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_Performer_Elements()                                                                                        // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 11. MedicationDispense.performer.function
                            this.Function = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Function",                                                                                          // MakerGen.cs:235
                                Path= "MedicationDispense.performer.function",                                                              // MakerGen.cs:236
                                Id = "MedicationDispense.performer.function",                                                               // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 12. MedicationDispense.performer.actor
                            this.Actor = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Actor",                                                                                             // MakerGen.cs:235
                                Path= "MedicationDispense.performer.actor",                                                                 // MakerGen.cs:236
                                Id = "MedicationDispense.performer.actor",                                                                  // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",                                         // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                     // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/Organization",                                         // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/Patient",                                              // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/Device",                                               // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                         // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        Function.Write(sDef);                                                                                               // MakerGen.cs:220
                        Actor.Write(sDef);                                                                                                  // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_Performer_Elements Elements                                                                                     // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_Performer_Elements();                                                                  // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_Performer_Elements elements;                                                                                           // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_Performer()                                                                                                     // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "MedicationDispense.performer",                                                                              // MakerGen.cs:428
                        ElementId = "MedicationDispense.performer"                                                                          // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 24. MedicationDispense.substitution
            public class Type_Substitution : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_Substitution_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                       // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 25. MedicationDispense.substitution.wasSubstituted
                    public ElementDefinitionInfo WasSubstituted;                                                                            // MakerGen.cs:216
                    // 26. MedicationDispense.substitution.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:216
                    // 27. MedicationDispense.substitution.reason
                    public ElementDefinitionInfo Reason;                                                                                    // MakerGen.cs:216
                    // 28. MedicationDispense.substitution.responsibleParty
                    public ElementDefinitionInfo ResponsibleParty;                                                                          // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_Substitution_Elements()                                                                                     // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 25. MedicationDispense.substitution.wasSubstituted
                            this.WasSubstituted = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "WasSubstituted",                                                                                    // MakerGen.cs:235
                                Path= "MedicationDispense.substitution.wasSubstituted",                                                     // MakerGen.cs:236
                                Id = "MedicationDispense.substitution.wasSubstituted",                                                      // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 26. MedicationDispense.substitution.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Type",                                                                                              // MakerGen.cs:235
                                Path= "MedicationDispense.substitution.type",                                                               // MakerGen.cs:236
                                Id = "MedicationDispense.substitution.type",                                                                // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 27. MedicationDispense.substitution.reason
                            this.Reason = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Reason",                                                                                            // MakerGen.cs:235
                                Path= "MedicationDispense.substitution.reason",                                                             // MakerGen.cs:236
                                Id = "MedicationDispense.substitution.reason",                                                              // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 28. MedicationDispense.substitution.responsibleParty
                            this.ResponsibleParty = new ElementDefinitionInfo                                                               // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "ResponsibleParty",                                                                                  // MakerGen.cs:235
                                Path= "MedicationDispense.substitution.responsibleParty",                                                   // MakerGen.cs:236
                                Id = "MedicationDispense.substitution.responsibleParty",                                                    // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",                                         // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                      // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        WasSubstituted.Write(sDef);                                                                                         // MakerGen.cs:220
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Reason.Write(sDef);                                                                                                 // MakerGen.cs:220
                        ResponsibleParty.Write(sDef);                                                                                       // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_Substitution_Elements Elements                                                                                  // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_Substitution_Elements();                                                               // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_Substitution_Elements elements;                                                                                        // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_Substitution()                                                                                                  // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "MedicationDispense.substitution",                                                                           // MakerGen.cs:428
                        ElementId = "MedicationDispense.substitution"                                                                       // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 1. MedicationDispense.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 2. MedicationDispense.partOf
            public ElementDefinitionInfo PartOf;                                                                                            // MakerGen.cs:216
            // 3. MedicationDispense.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:216
            // 4. MedicationDispense.statusReason[x]
            public ElementDefinitionInfo StatusReason;                                                                                      // MakerGen.cs:216
            // 5. MedicationDispense.category
            public ElementDefinitionInfo Category;                                                                                          // MakerGen.cs:216
            // 6. MedicationDispense.medication[x]
            public ElementDefinitionInfo Medication;                                                                                        // MakerGen.cs:216
            // 7. MedicationDispense.subject
            public ElementDefinitionInfo Subject;                                                                                           // MakerGen.cs:216
            // 8. MedicationDispense.context
            public ElementDefinitionInfo Context;                                                                                           // MakerGen.cs:216
            // 9. MedicationDispense.supportingInformation
            public ElementDefinitionInfo SupportingInformation;                                                                             // MakerGen.cs:216
            // 10. MedicationDispense.performer
            public ElementDefinitionInfo Performer;                                                                                         // MakerGen.cs:216
            // 13. MedicationDispense.location
            public ElementDefinitionInfo Location;                                                                                          // MakerGen.cs:216
            // 14. MedicationDispense.authorizingPrescription
            public ElementDefinitionInfo AuthorizingPrescription;                                                                           // MakerGen.cs:216
            // 15. MedicationDispense.type
            public ElementDefinitionInfo Type;                                                                                              // MakerGen.cs:216
            // 16. MedicationDispense.quantity
            public ElementDefinitionInfo Quantity;                                                                                          // MakerGen.cs:216
            // 17. MedicationDispense.daysSupply
            public ElementDefinitionInfo DaysSupply;                                                                                        // MakerGen.cs:216
            // 18. MedicationDispense.whenPrepared
            public ElementDefinitionInfo WhenPrepared;                                                                                      // MakerGen.cs:216
            // 19. MedicationDispense.whenHandedOver
            public ElementDefinitionInfo WhenHandedOver;                                                                                    // MakerGen.cs:216
            // 20. MedicationDispense.destination
            public ElementDefinitionInfo Destination;                                                                                       // MakerGen.cs:216
            // 21. MedicationDispense.receiver
            public ElementDefinitionInfo Receiver;                                                                                          // MakerGen.cs:216
            // 22. MedicationDispense.note
            public ElementDefinitionInfo Note;                                                                                              // MakerGen.cs:216
            // 23. MedicationDispense.dosageInstruction
            public ElementDefinitionInfo DosageInstruction;                                                                                 // MakerGen.cs:216
            // 24. MedicationDispense.substitution
            public ElementDefinitionInfo Substitution;                                                                                      // MakerGen.cs:216
            // 29. MedicationDispense.detectedIssue
            public ElementDefinitionInfo DetectedIssue;                                                                                     // MakerGen.cs:216
            // 30. MedicationDispense.eventHistory
            public ElementDefinitionInfo EventHistory;                                                                                      // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
            public MedicationDispense_Elements()                                                                                            // MakerGen.cs:392
            {                                                                                                                               // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:231
                    // 1. MedicationDispense.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "MedicationDispense.identifier",                                                                              // MakerGen.cs:236
                        Id = "MedicationDispense.identifier",                                                                               // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 2. MedicationDispense.partOf
                    this.PartOf = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "PartOf",                                                                                                    // MakerGen.cs:235
                        Path= "MedicationDispense.partOf",                                                                                  // MakerGen.cs:236
                        Id = "MedicationDispense.partOf",                                                                                   // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Procedure"                                                     // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 3. MedicationDispense.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Status",                                                                                                    // MakerGen.cs:235
                        Path= "MedicationDispense.status",                                                                                  // MakerGen.cs:236
                        Id = "MedicationDispense.status",                                                                                   // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 4. MedicationDispense.statusReason[x]
                    this.StatusReason = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "StatusReason",                                                                                              // MakerGen.cs:235
                        Path= "MedicationDispense.statusReason[x]",                                                                         // MakerGen.cs:236
                        Id = "MedicationDispense.statusReason[x]",                                                                          // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            },                                                                                                              // MakerGen.cs:319
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/DetectedIssue"                                                 // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 5. MedicationDispense.category
                    this.Category = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Category",                                                                                                  // MakerGen.cs:235
                        Path= "MedicationDispense.category",                                                                                // MakerGen.cs:236
                        Id = "MedicationDispense.category",                                                                                 // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 6. MedicationDispense.medication[x]
                    this.Medication = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Medication",                                                                                                // MakerGen.cs:235
                        Path= "MedicationDispense.medication[x]",                                                                           // MakerGen.cs:236
                        Id = "MedicationDispense.medication[x]",                                                                            // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            },                                                                                                              // MakerGen.cs:319
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Medication"                                                    // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 7. MedicationDispense.subject
                    this.Subject = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Subject",                                                                                                   // MakerGen.cs:235
                        Path= "MedicationDispense.subject",                                                                                 // MakerGen.cs:236
                        Id = "MedicationDispense.subject",                                                                                  // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Group"                                                         // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 8. MedicationDispense.context
                    this.Context = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Context",                                                                                                   // MakerGen.cs:235
                        Path= "MedicationDispense.context",                                                                                 // MakerGen.cs:236
                        Id = "MedicationDispense.context",                                                                                  // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Encounter",                                                    // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/EpisodeOfCare"                                                 // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 9. MedicationDispense.supportingInformation
                    this.SupportingInformation = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "SupportingInformation",                                                                                     // MakerGen.cs:235
                        Path= "MedicationDispense.supportingInformation",                                                                   // MakerGen.cs:236
                        Id = "MedicationDispense.supportingInformation",                                                                    // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Resource"                                                      // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 10. MedicationDispense.performer
                    this.Performer = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Performer",                                                                                                 // MakerGen.cs:235
                        Path= "MedicationDispense.performer",                                                                               // MakerGen.cs:236
                        Id = "MedicationDispense.performer",                                                                                // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Performer                                                                                              // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 13. MedicationDispense.location
                    this.Location = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Location",                                                                                                  // MakerGen.cs:235
                        Path= "MedicationDispense.location",                                                                                // MakerGen.cs:236
                        Id = "MedicationDispense.location",                                                                                 // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Location"                                                      // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 14. MedicationDispense.authorizingPrescription
                    this.AuthorizingPrescription = new ElementDefinitionInfo                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "AuthorizingPrescription",                                                                                   // MakerGen.cs:235
                        Path= "MedicationDispense.authorizingPrescription",                                                                 // MakerGen.cs:236
                        Id = "MedicationDispense.authorizingPrescription",                                                                  // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/MedicationRequest"                                             // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 15. MedicationDispense.type
                    this.Type = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Type",                                                                                                      // MakerGen.cs:235
                        Path= "MedicationDispense.type",                                                                                    // MakerGen.cs:236
                        Id = "MedicationDispense.type",                                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 16. MedicationDispense.quantity
                    this.Quantity = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Quantity",                                                                                                  // MakerGen.cs:235
                        Path= "MedicationDispense.quantity",                                                                                // MakerGen.cs:236
                        Id = "MedicationDispense.quantity",                                                                                 // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Quantity                                                                      // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 17. MedicationDispense.daysSupply
                    this.DaysSupply = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "DaysSupply",                                                                                                // MakerGen.cs:235
                        Path= "MedicationDispense.daysSupply",                                                                              // MakerGen.cs:236
                        Id = "MedicationDispense.daysSupply",                                                                               // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Quantity                                                                      // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 18. MedicationDispense.whenPrepared
                    this.WhenPrepared = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "WhenPrepared",                                                                                              // MakerGen.cs:235
                        Path= "MedicationDispense.whenPrepared",                                                                            // MakerGen.cs:236
                        Id = "MedicationDispense.whenPrepared",                                                                             // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 19. MedicationDispense.whenHandedOver
                    this.WhenHandedOver = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "WhenHandedOver",                                                                                            // MakerGen.cs:235
                        Path= "MedicationDispense.whenHandedOver",                                                                          // MakerGen.cs:236
                        Id = "MedicationDispense.whenHandedOver",                                                                           // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 20. MedicationDispense.destination
                    this.Destination = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Destination",                                                                                               // MakerGen.cs:235
                        Path= "MedicationDispense.destination",                                                                             // MakerGen.cs:236
                        Id = "MedicationDispense.destination",                                                                              // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Location"                                                      // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 21. MedicationDispense.receiver
                    this.Receiver = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Receiver",                                                                                                  // MakerGen.cs:235
                        Path= "MedicationDispense.receiver",                                                                                // MakerGen.cs:236
                        Id = "MedicationDispense.receiver",                                                                                 // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner"                                                  // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 22. MedicationDispense.note
                    this.Note = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Note",                                                                                                      // MakerGen.cs:235
                        Path= "MedicationDispense.note",                                                                                    // MakerGen.cs:236
                        Id = "MedicationDispense.note",                                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Annotation                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 23. MedicationDispense.dosageInstruction
                    this.DosageInstruction = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "DosageInstruction",                                                                                         // MakerGen.cs:235
                        Path= "MedicationDispense.dosageInstruction",                                                                       // MakerGen.cs:236
                        Id = "MedicationDispense.dosageInstruction",                                                                        // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Dosage                                                                        // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 24. MedicationDispense.substitution
                    this.Substitution = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Substitution",                                                                                              // MakerGen.cs:235
                        Path= "MedicationDispense.substitution",                                                                            // MakerGen.cs:236
                        Id = "MedicationDispense.substitution",                                                                             // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Substitution                                                                                           // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 29. MedicationDispense.detectedIssue
                    this.DetectedIssue = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "DetectedIssue",                                                                                             // MakerGen.cs:235
                        Path= "MedicationDispense.detectedIssue",                                                                           // MakerGen.cs:236
                        Id = "MedicationDispense.detectedIssue",                                                                            // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/DetectedIssue"                                                 // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 30. MedicationDispense.eventHistory
                    this.EventHistory = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "EventHistory",                                                                                              // MakerGen.cs:235
                        Path= "MedicationDispense.eventHistory",                                                                            // MakerGen.cs:236
                        Id = "MedicationDispense.eventHistory",                                                                             // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Provenance"                                                    // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:398
            {                                                                                                                               // MakerGen.cs:399
                base.Write(sDef);                                                                                                           // MakerGen.cs:400
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:220
                PartOf.Write(sDef);                                                                                                         // MakerGen.cs:220
                Status.Write(sDef);                                                                                                         // MakerGen.cs:220
                StatusReason.Write(sDef);                                                                                                   // MakerGen.cs:220
                Category.Write(sDef);                                                                                                       // MakerGen.cs:220
                Medication.Write(sDef);                                                                                                     // MakerGen.cs:220
                Subject.Write(sDef);                                                                                                        // MakerGen.cs:220
                Context.Write(sDef);                                                                                                        // MakerGen.cs:220
                SupportingInformation.Write(sDef);                                                                                          // MakerGen.cs:220
                Performer.Write(sDef);                                                                                                      // MakerGen.cs:220
                Location.Write(sDef);                                                                                                       // MakerGen.cs:220
                AuthorizingPrescription.Write(sDef);                                                                                        // MakerGen.cs:220
                Type.Write(sDef);                                                                                                           // MakerGen.cs:220
                Quantity.Write(sDef);                                                                                                       // MakerGen.cs:220
                DaysSupply.Write(sDef);                                                                                                     // MakerGen.cs:220
                WhenPrepared.Write(sDef);                                                                                                   // MakerGen.cs:220
                WhenHandedOver.Write(sDef);                                                                                                 // MakerGen.cs:220
                Destination.Write(sDef);                                                                                                    // MakerGen.cs:220
                Receiver.Write(sDef);                                                                                                       // MakerGen.cs:220
                Note.Write(sDef);                                                                                                           // MakerGen.cs:220
                DosageInstruction.Write(sDef);                                                                                              // MakerGen.cs:220
                Substitution.Write(sDef);                                                                                                   // MakerGen.cs:220
                DetectedIssue.Write(sDef);                                                                                                  // MakerGen.cs:220
                EventHistory.Write(sDef);                                                                                                   // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:402
        }                                                                                                                                   // MakerGen.cs:404
        public MedicationDispense_Elements Elements                                                                                         // MakerGen.cs:406
        {                                                                                                                                   // MakerGen.cs:407
            get                                                                                                                             // MakerGen.cs:408
            {                                                                                                                               // MakerGen.cs:409
                if (this.elements == null)                                                                                                  // MakerGen.cs:410
                    this.elements = new MedicationDispense_Elements();                                                                      // MakerGen.cs:411
                return this.elements;                                                                                                       // MakerGen.cs:412
            }                                                                                                                               // MakerGen.cs:413
        }                                                                                                                                   // MakerGen.cs:414
        MedicationDispense_Elements elements;                                                                                               // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
        public MedicationDispense()                                                                                                         // MakerGen.cs:418
        {                                                                                                                                   // MakerGen.cs:419
            this.Name = "MedicationDispense";                                                                                               // MakerGen.cs:492
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MedicationDispense";                                                        // MakerGen.cs:493
        }                                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:424
        {                                                                                                                                   // MakerGen.cs:425
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:426
            {                                                                                                                               // MakerGen.cs:427
                Path = "MedicationDispense",                                                                                                // MakerGen.cs:428
                ElementId = "MedicationDispense"                                                                                            // MakerGen.cs:429
            });                                                                                                                             // MakerGen.cs:430
            if (this.elements != null)                                                                                                      // MakerGen.cs:431
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:432
        }                                                                                                                                   // MakerGen.cs:433
    }                                                                                                                                       // MakerGen.cs:434
}                                                                                                                                           // MakerGen.cs:479
