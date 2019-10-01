using System;                                                                                                                               // MakerGen.cs:428
using System.Diagnostics;                                                                                                                   // MakerGen.cs:429
using System.IO;                                                                                                                            // MakerGen.cs:430
using System.Linq;                                                                                                                          // MakerGen.cs:431
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:432
                                                                                                                                            // MakerGen.cs:433
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:434
{                                                                                                                                           // MakerGen.cs:435
    #region Json                                                                                                                            // MakerGen.cs:436
    #if NEVER                                                                                                                               // MakerGen.cs:437
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
    #endregion                                                                                                                              // MakerGen.cs:440
    /// <summary>
    /// Fhir resource 'MedicationDispense'
    /// </summary>
    // 0. MedicationDispense
    public class Resource_MedicationDispense : FhirKhit.Maker.Common.Resource.ResourceBase                                                  // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 10. MedicationDispense.performer
        public class Type_Performer : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 11. MedicationDispense.performer.function
            public ElementDefinitionInfo Element_Function;                                                                                  // MakerGen.cs:212
            // 12. MedicationDispense.performer.actor
            public ElementDefinitionInfo Element_Actor;                                                                                     // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "MedicationDispense.performer",                                                                                  // MakerGen.cs:388
                    ElementId = "MedicationDispense.performer"                                                                              // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Function.Write(sDef);                                                                                               // MakerGen.cs:216
                Element_Actor.Write(sDef);                                                                                                  // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Performer()                                                                                                         // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 11. MedicationDispense.performer.function
                    this.Element_Function = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Function",                                                                                          // MakerGen.cs:231
                        Path= "MedicationDispense.performer.function",                                                                      // MakerGen.cs:232
                        Id = "MedicationDispense.performer.function",                                                                       // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 12. MedicationDispense.performer.actor
                    this.Element_Actor = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Actor",                                                                                             // MakerGen.cs:231
                        Path= "MedicationDispense.performer.actor",                                                                         // MakerGen.cs:232
                        Id = "MedicationDispense.performer.actor",                                                                          // MakerGen.cs:233
                        Min = 1,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:339
                            {                                                                                                               // MakerGen.cs:340
                                TargetProfile = new String[]                                                                                // MakerGen.cs:342
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/Organization",                                                 // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/Device",                                                       // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                                 // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:343
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 24. MedicationDispense.substitution
        public class Type_Substitution : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 25. MedicationDispense.substitution.wasSubstituted
            public ElementDefinitionInfo Element_WasSubstituted;                                                                            // MakerGen.cs:212
            // 26. MedicationDispense.substitution.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:212
            // 27. MedicationDispense.substitution.reason
            public ElementDefinitionInfo Element_Reason;                                                                                    // MakerGen.cs:212
            // 28. MedicationDispense.substitution.responsibleParty
            public ElementDefinitionInfo Element_ResponsibleParty;                                                                          // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "MedicationDispense.substitution",                                                                               // MakerGen.cs:388
                    ElementId = "MedicationDispense.substitution"                                                                           // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_WasSubstituted.Write(sDef);                                                                                         // MakerGen.cs:216
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_Reason.Write(sDef);                                                                                                 // MakerGen.cs:216
                Element_ResponsibleParty.Write(sDef);                                                                                       // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Substitution()                                                                                                      // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 25. MedicationDispense.substitution.wasSubstituted
                    this.Element_WasSubstituted = new ElementDefinitionInfo                                                                 // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_WasSubstituted",                                                                                    // MakerGen.cs:231
                        Path= "MedicationDispense.substitution.wasSubstituted",                                                             // MakerGen.cs:232
                        Id = "MedicationDispense.substitution.wasSubstituted",                                                              // MakerGen.cs:233
                        Min = 1,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                           // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 26. MedicationDispense.substitution.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Type",                                                                                              // MakerGen.cs:231
                        Path= "MedicationDispense.substitution.type",                                                                       // MakerGen.cs:232
                        Id = "MedicationDispense.substitution.type",                                                                        // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 27. MedicationDispense.substitution.reason
                    this.Element_Reason = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Reason",                                                                                            // MakerGen.cs:231
                        Path= "MedicationDispense.substitution.reason",                                                                     // MakerGen.cs:232
                        Id = "MedicationDispense.substitution.reason",                                                                      // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 28. MedicationDispense.substitution.responsibleParty
                    this.Element_ResponsibleParty = new ElementDefinitionInfo                                                               // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_ResponsibleParty",                                                                                  // MakerGen.cs:231
                        Path= "MedicationDispense.substitution.responsibleParty",                                                           // MakerGen.cs:232
                        Id = "MedicationDispense.substitution.responsibleParty",                                                            // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:339
                            {                                                                                                               // MakerGen.cs:340
                                TargetProfile = new String[]                                                                                // MakerGen.cs:342
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                              // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:343
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 1. MedicationDispense.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:212
        // 2. MedicationDispense.partOf
        public ElementDefinitionInfo Element_PartOf;                                                                                        // MakerGen.cs:212
        // 3. MedicationDispense.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:212
        // 4. MedicationDispense.statusReason[x]
        public ElementDefinitionInfo Element_StatusReason;                                                                                  // MakerGen.cs:212
        // 5. MedicationDispense.category
        public ElementDefinitionInfo Element_Category;                                                                                      // MakerGen.cs:212
        // 6. MedicationDispense.medication[x]
        public ElementDefinitionInfo Element_Medication;                                                                                    // MakerGen.cs:212
        // 7. MedicationDispense.subject
        public ElementDefinitionInfo Element_Subject;                                                                                       // MakerGen.cs:212
        // 8. MedicationDispense.context
        public ElementDefinitionInfo Element_Context;                                                                                       // MakerGen.cs:212
        // 9. MedicationDispense.supportingInformation
        public ElementDefinitionInfo Element_SupportingInformation;                                                                         // MakerGen.cs:212
        // 10. MedicationDispense.performer
        public ElementDefinitionInfo Element_Performer;                                                                                     // MakerGen.cs:212
        // 13. MedicationDispense.location
        public ElementDefinitionInfo Element_Location;                                                                                      // MakerGen.cs:212
        // 14. MedicationDispense.authorizingPrescription
        public ElementDefinitionInfo Element_AuthorizingPrescription;                                                                       // MakerGen.cs:212
        // 15. MedicationDispense.type
        public ElementDefinitionInfo Element_Type;                                                                                          // MakerGen.cs:212
        // 16. MedicationDispense.quantity
        public ElementDefinitionInfo Element_Quantity;                                                                                      // MakerGen.cs:212
        // 17. MedicationDispense.daysSupply
        public ElementDefinitionInfo Element_DaysSupply;                                                                                    // MakerGen.cs:212
        // 18. MedicationDispense.whenPrepared
        public ElementDefinitionInfo Element_WhenPrepared;                                                                                  // MakerGen.cs:212
        // 19. MedicationDispense.whenHandedOver
        public ElementDefinitionInfo Element_WhenHandedOver;                                                                                // MakerGen.cs:212
        // 20. MedicationDispense.destination
        public ElementDefinitionInfo Element_Destination;                                                                                   // MakerGen.cs:212
        // 21. MedicationDispense.receiver
        public ElementDefinitionInfo Element_Receiver;                                                                                      // MakerGen.cs:212
        // 22. MedicationDispense.note
        public ElementDefinitionInfo Element_Note;                                                                                          // MakerGen.cs:212
        // 23. MedicationDispense.dosageInstruction
        public ElementDefinitionInfo Element_DosageInstruction;                                                                             // MakerGen.cs:212
        // 24. MedicationDispense.substitution
        public ElementDefinitionInfo Element_Substitution;                                                                                  // MakerGen.cs:212
        // 29. MedicationDispense.detectedIssue
        public ElementDefinitionInfo Element_DetectedIssue;                                                                                 // MakerGen.cs:212
        // 30. MedicationDispense.eventHistory
        public ElementDefinitionInfo Element_EventHistory;                                                                                  // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "MedicationDispense",                                                                                                // MakerGen.cs:388
                ElementId = "MedicationDispense"                                                                                            // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_PartOf.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_StatusReason.Write(sDef);                                                                                               // MakerGen.cs:216
            Element_Category.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_Medication.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_Subject.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Context.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_SupportingInformation.Write(sDef);                                                                                      // MakerGen.cs:216
            Element_Performer.Write(sDef);                                                                                                  // MakerGen.cs:216
            Element_Location.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_AuthorizingPrescription.Write(sDef);                                                                                    // MakerGen.cs:216
            Element_Type.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Quantity.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_DaysSupply.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_WhenPrepared.Write(sDef);                                                                                               // MakerGen.cs:216
            Element_WhenHandedOver.Write(sDef);                                                                                             // MakerGen.cs:216
            Element_Destination.Write(sDef);                                                                                                // MakerGen.cs:216
            Element_Receiver.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_Note.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_DosageInstruction.Write(sDef);                                                                                          // MakerGen.cs:216
            Element_Substitution.Write(sDef);                                                                                               // MakerGen.cs:216
            Element_DetectedIssue.Write(sDef);                                                                                              // MakerGen.cs:216
            Element_EventHistory.Write(sDef);                                                                                               // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Resource_MedicationDispense()                                                                                                // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. MedicationDispense.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:231
                    Path= "MedicationDispense.identifier",                                                                                  // MakerGen.cs:232
                    Id = "MedicationDispense.identifier",                                                                                   // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 2. MedicationDispense.partOf
                this.Element_PartOf = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_PartOf",                                                                                                // MakerGen.cs:231
                    Path= "MedicationDispense.partOf",                                                                                      // MakerGen.cs:232
                    Id = "MedicationDispense.partOf",                                                                                       // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Procedure"                                                         // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 3. MedicationDispense.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Status",                                                                                                // MakerGen.cs:231
                    Path= "MedicationDispense.status",                                                                                      // MakerGen.cs:232
                    Id = "MedicationDispense.status",                                                                                       // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 4. MedicationDispense.statusReason[x]
                this.Element_StatusReason = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_StatusReason",                                                                                          // MakerGen.cs:231
                    Path= "MedicationDispense.statusReason[x]",                                                                             // MakerGen.cs:232
                    Id = "MedicationDispense.statusReason[x]",                                                                              // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        },                                                                                                                  // MakerGen.cs:315
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/DetectedIssue"                                                     // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 5. MedicationDispense.category
                this.Element_Category = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Category",                                                                                              // MakerGen.cs:231
                    Path= "MedicationDispense.category",                                                                                    // MakerGen.cs:232
                    Id = "MedicationDispense.category",                                                                                     // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 6. MedicationDispense.medication[x]
                this.Element_Medication = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Medication",                                                                                            // MakerGen.cs:231
                    Path= "MedicationDispense.medication[x]",                                                                               // MakerGen.cs:232
                    Id = "MedicationDispense.medication[x]",                                                                                // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        },                                                                                                                  // MakerGen.cs:315
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Medication"                                                        // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 7. MedicationDispense.subject
                this.Element_Subject = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Subject",                                                                                               // MakerGen.cs:231
                    Path= "MedicationDispense.subject",                                                                                     // MakerGen.cs:232
                    Id = "MedicationDispense.subject",                                                                                      // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Patient",                                                          // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Group"                                                             // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 8. MedicationDispense.context
                this.Element_Context = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Context",                                                                                               // MakerGen.cs:231
                    Path= "MedicationDispense.context",                                                                                     // MakerGen.cs:232
                    Id = "MedicationDispense.context",                                                                                      // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Encounter",                                                        // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/EpisodeOfCare"                                                     // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 9. MedicationDispense.supportingInformation
                this.Element_SupportingInformation = new ElementDefinitionInfo                                                              // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_SupportingInformation",                                                                                 // MakerGen.cs:231
                    Path= "MedicationDispense.supportingInformation",                                                                       // MakerGen.cs:232
                    Id = "MedicationDispense.supportingInformation",                                                                        // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Resource"                                                          // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 10. MedicationDispense.performer
                this.Element_Performer = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Performer",                                                                                             // MakerGen.cs:231
                    Path= "MedicationDispense.performer",                                                                                   // MakerGen.cs:232
                    Id = "MedicationDispense.performer",                                                                                    // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Performer                                                                                                  // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 13. MedicationDispense.location
                this.Element_Location = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Location",                                                                                              // MakerGen.cs:231
                    Path= "MedicationDispense.location",                                                                                    // MakerGen.cs:232
                    Id = "MedicationDispense.location",                                                                                     // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Location"                                                          // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 14. MedicationDispense.authorizingPrescription
                this.Element_AuthorizingPrescription = new ElementDefinitionInfo                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_AuthorizingPrescription",                                                                               // MakerGen.cs:231
                    Path= "MedicationDispense.authorizingPrescription",                                                                     // MakerGen.cs:232
                    Id = "MedicationDispense.authorizingPrescription",                                                                      // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/MedicationRequest"                                                 // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 15. MedicationDispense.type
                this.Element_Type = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:231
                    Path= "MedicationDispense.type",                                                                                        // MakerGen.cs:232
                    Id = "MedicationDispense.type",                                                                                         // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 16. MedicationDispense.quantity
                this.Element_Quantity = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Quantity",                                                                                              // MakerGen.cs:231
                    Path= "MedicationDispense.quantity",                                                                                    // MakerGen.cs:232
                    Id = "MedicationDispense.quantity",                                                                                     // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                     // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 17. MedicationDispense.daysSupply
                this.Element_DaysSupply = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_DaysSupply",                                                                                            // MakerGen.cs:231
                    Path= "MedicationDispense.daysSupply",                                                                                  // MakerGen.cs:232
                    Id = "MedicationDispense.daysSupply",                                                                                   // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                     // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 18. MedicationDispense.whenPrepared
                this.Element_WhenPrepared = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_WhenPrepared",                                                                                          // MakerGen.cs:231
                    Path= "MedicationDispense.whenPrepared",                                                                                // MakerGen.cs:232
                    Id = "MedicationDispense.whenPrepared",                                                                                 // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 19. MedicationDispense.whenHandedOver
                this.Element_WhenHandedOver = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_WhenHandedOver",                                                                                        // MakerGen.cs:231
                    Path= "MedicationDispense.whenHandedOver",                                                                              // MakerGen.cs:232
                    Id = "MedicationDispense.whenHandedOver",                                                                               // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 20. MedicationDispense.destination
                this.Element_Destination = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Destination",                                                                                           // MakerGen.cs:231
                    Path= "MedicationDispense.destination",                                                                                 // MakerGen.cs:232
                    Id = "MedicationDispense.destination",                                                                                  // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Location"                                                          // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 21. MedicationDispense.receiver
                this.Element_Receiver = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Receiver",                                                                                              // MakerGen.cs:231
                    Path= "MedicationDispense.receiver",                                                                                    // MakerGen.cs:232
                    Id = "MedicationDispense.receiver",                                                                                     // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Patient",                                                          // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Practitioner"                                                      // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 22. MedicationDispense.note
                this.Element_Note = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Note",                                                                                                  // MakerGen.cs:231
                    Path= "MedicationDispense.note",                                                                                        // MakerGen.cs:232
                    Id = "MedicationDispense.note",                                                                                         // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Annotation                                                                   // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 23. MedicationDispense.dosageInstruction
                this.Element_DosageInstruction = new ElementDefinitionInfo                                                                  // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_DosageInstruction",                                                                                     // MakerGen.cs:231
                    Path= "MedicationDispense.dosageInstruction",                                                                           // MakerGen.cs:232
                    Id = "MedicationDispense.dosageInstruction",                                                                            // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Dosage                                                                       // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 24. MedicationDispense.substitution
                this.Element_Substitution = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Substitution",                                                                                          // MakerGen.cs:231
                    Path= "MedicationDispense.substitution",                                                                                // MakerGen.cs:232
                    Id = "MedicationDispense.substitution",                                                                                 // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Substitution                                                                                               // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 29. MedicationDispense.detectedIssue
                this.Element_DetectedIssue = new ElementDefinitionInfo                                                                      // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_DetectedIssue",                                                                                         // MakerGen.cs:231
                    Path= "MedicationDispense.detectedIssue",                                                                               // MakerGen.cs:232
                    Id = "MedicationDispense.detectedIssue",                                                                                // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/DetectedIssue"                                                     // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 30. MedicationDispense.eventHistory
                this.Element_EventHistory = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_EventHistory",                                                                                          // MakerGen.cs:231
                    Path= "MedicationDispense.eventHistory",                                                                                // MakerGen.cs:232
                    Id = "MedicationDispense.eventHistory",                                                                                 // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Provenance"                                                        // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            this.Name = "MedicationDispense";                                                                                               // MakerGen.cs:458
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MedicationDispense";                                                        // MakerGen.cs:459
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:445
