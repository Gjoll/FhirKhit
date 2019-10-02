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
    #endregion
    /// <summary>
    /// Fhir resource 'MedicationDispense'
    /// </summary>
    // 0. MedicationDispense
    public class Resource_MedicationDispense : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 10. MedicationDispense.performer
        public class Type_Performer : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 11. MedicationDispense.performer.function
            public ElementDefinitionInfo Element_Function;
            // 12. MedicationDispense.performer.actor
            public ElementDefinitionInfo Element_Actor;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "MedicationDispense.performer",
                    ElementId = "MedicationDispense.performer"
                });
                Element_Function.Write(sDef);
                Element_Actor.Write(sDef);
            }
            
            public Type_Performer()
            {
                {
                    // 11. MedicationDispense.performer.function
                    this.Element_Function = new ElementDefinitionInfo
                    {
                        Name = "Element_Function",
                        Path= "MedicationDispense.performer.function",
                        Id = "MedicationDispense.performer.function",
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
                    // 12. MedicationDispense.performer.actor
                    this.Element_Actor = new ElementDefinitionInfo
                    {
                        Name = "Element_Actor",
                        Path= "MedicationDispense.performer.actor",
                        Id = "MedicationDispense.performer.actor",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                    "http://hl7.org/fhir/StructureDefinition/Organization",
                                    "http://hl7.org/fhir/StructureDefinition/Patient",
                                    "http://hl7.org/fhir/StructureDefinition/Device",
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                                }
                            }
                        }
                    };
                }
            }
        }
        // 24. MedicationDispense.substitution
        public class Type_Substitution : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 25. MedicationDispense.substitution.wasSubstituted
            public ElementDefinitionInfo Element_WasSubstituted;
            // 26. MedicationDispense.substitution.type
            public ElementDefinitionInfo Element_Type;
            // 27. MedicationDispense.substitution.reason
            public ElementDefinitionInfo Element_Reason;
            // 28. MedicationDispense.substitution.responsibleParty
            public ElementDefinitionInfo Element_ResponsibleParty;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "MedicationDispense.substitution",
                    ElementId = "MedicationDispense.substitution"
                });
                Element_WasSubstituted.Write(sDef);
                Element_Type.Write(sDef);
                Element_Reason.Write(sDef);
                Element_ResponsibleParty.Write(sDef);
            }
            
            public Type_Substitution()
            {
                {
                    // 25. MedicationDispense.substitution.wasSubstituted
                    this.Element_WasSubstituted = new ElementDefinitionInfo
                    {
                        Name = "Element_WasSubstituted",
                        Path= "MedicationDispense.substitution.wasSubstituted",
                        Id = "MedicationDispense.substitution.wasSubstituted",
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
                {
                    // 26. MedicationDispense.substitution.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "MedicationDispense.substitution.type",
                        Id = "MedicationDispense.substitution.type",
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
                    // 27. MedicationDispense.substitution.reason
                    this.Element_Reason = new ElementDefinitionInfo
                    {
                        Name = "Element_Reason",
                        Path= "MedicationDispense.substitution.reason",
                        Id = "MedicationDispense.substitution.reason",
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
                    // 28. MedicationDispense.substitution.responsibleParty
                    this.Element_ResponsibleParty = new ElementDefinitionInfo
                    {
                        Name = "Element_ResponsibleParty",
                        Path= "MedicationDispense.substitution.responsibleParty",
                        Id = "MedicationDispense.substitution.responsibleParty",
                        Min = 0,
                        Max = -1,
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
            }
        }
        // 1. MedicationDispense.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. MedicationDispense.partOf
        public ElementDefinitionInfo Element_PartOf;
        // 3. MedicationDispense.status
        public ElementDefinitionInfo Element_Status;
        // 4. MedicationDispense.statusReason[x]
        public ElementDefinitionInfo Element_StatusReason;
        // 5. MedicationDispense.category
        public ElementDefinitionInfo Element_Category;
        // 6. MedicationDispense.medication[x]
        public ElementDefinitionInfo Element_Medication;
        // 7. MedicationDispense.subject
        public ElementDefinitionInfo Element_Subject;
        // 8. MedicationDispense.context
        public ElementDefinitionInfo Element_Context;
        // 9. MedicationDispense.supportingInformation
        public ElementDefinitionInfo Element_SupportingInformation;
        // 10. MedicationDispense.performer
        public ElementDefinitionInfo Element_Performer;
        // 13. MedicationDispense.location
        public ElementDefinitionInfo Element_Location;
        // 14. MedicationDispense.authorizingPrescription
        public ElementDefinitionInfo Element_AuthorizingPrescription;
        // 15. MedicationDispense.type
        public ElementDefinitionInfo Element_Type;
        // 16. MedicationDispense.quantity
        public ElementDefinitionInfo Element_Quantity;
        // 17. MedicationDispense.daysSupply
        public ElementDefinitionInfo Element_DaysSupply;
        // 18. MedicationDispense.whenPrepared
        public ElementDefinitionInfo Element_WhenPrepared;
        // 19. MedicationDispense.whenHandedOver
        public ElementDefinitionInfo Element_WhenHandedOver;
        // 20. MedicationDispense.destination
        public ElementDefinitionInfo Element_Destination;
        // 21. MedicationDispense.receiver
        public ElementDefinitionInfo Element_Receiver;
        // 22. MedicationDispense.note
        public ElementDefinitionInfo Element_Note;
        // 23. MedicationDispense.dosageInstruction
        public ElementDefinitionInfo Element_DosageInstruction;
        // 24. MedicationDispense.substitution
        public ElementDefinitionInfo Element_Substitution;
        // 29. MedicationDispense.detectedIssue
        public ElementDefinitionInfo Element_DetectedIssue;
        // 30. MedicationDispense.eventHistory
        public ElementDefinitionInfo Element_EventHistory;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "MedicationDispense",
                ElementId = "MedicationDispense"
            });
            Element_Identifier.Write(sDef);
            Element_PartOf.Write(sDef);
            Element_Status.Write(sDef);
            Element_StatusReason.Write(sDef);
            Element_Category.Write(sDef);
            Element_Medication.Write(sDef);
            Element_Subject.Write(sDef);
            Element_Context.Write(sDef);
            Element_SupportingInformation.Write(sDef);
            Element_Performer.Write(sDef);
            Element_Location.Write(sDef);
            Element_AuthorizingPrescription.Write(sDef);
            Element_Type.Write(sDef);
            Element_Quantity.Write(sDef);
            Element_DaysSupply.Write(sDef);
            Element_WhenPrepared.Write(sDef);
            Element_WhenHandedOver.Write(sDef);
            Element_Destination.Write(sDef);
            Element_Receiver.Write(sDef);
            Element_Note.Write(sDef);
            Element_DosageInstruction.Write(sDef);
            Element_Substitution.Write(sDef);
            Element_DetectedIssue.Write(sDef);
            Element_EventHistory.Write(sDef);
        }
        
        public Resource_MedicationDispense()
        {
            {
                // 1. MedicationDispense.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "MedicationDispense.identifier",
                    Id = "MedicationDispense.identifier",
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
                // 2. MedicationDispense.partOf
                this.Element_PartOf = new ElementDefinitionInfo
                {
                    Name = "Element_PartOf",
                    Path= "MedicationDispense.partOf",
                    Id = "MedicationDispense.partOf",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Procedure"
                            }
                        }
                    }
                };
            }
            {
                // 3. MedicationDispense.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "MedicationDispense.status",
                    Id = "MedicationDispense.status",
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
                // 4. MedicationDispense.statusReason[x]
                this.Element_StatusReason = new ElementDefinitionInfo
                {
                    Name = "Element_StatusReason",
                    Path= "MedicationDispense.statusReason[x]",
                    Id = "MedicationDispense.statusReason[x]",
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
                                "http://hl7.org/fhir/StructureDefinition/DetectedIssue"
                            }
                        }
                    }
                };
            }
            {
                // 5. MedicationDispense.category
                this.Element_Category = new ElementDefinitionInfo
                {
                    Name = "Element_Category",
                    Path= "MedicationDispense.category",
                    Id = "MedicationDispense.category",
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
                // 6. MedicationDispense.medication[x]
                this.Element_Medication = new ElementDefinitionInfo
                {
                    Name = "Element_Medication",
                    Path= "MedicationDispense.medication[x]",
                    Id = "MedicationDispense.medication[x]",
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
                                "http://hl7.org/fhir/StructureDefinition/Medication"
                            }
                        }
                    }
                };
            }
            {
                // 7. MedicationDispense.subject
                this.Element_Subject = new ElementDefinitionInfo
                {
                    Name = "Element_Subject",
                    Path= "MedicationDispense.subject",
                    Id = "MedicationDispense.subject",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/Group"
                            }
                        }
                    }
                };
            }
            {
                // 8. MedicationDispense.context
                this.Element_Context = new ElementDefinitionInfo
                {
                    Name = "Element_Context",
                    Path= "MedicationDispense.context",
                    Id = "MedicationDispense.context",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Encounter",
                                "http://hl7.org/fhir/StructureDefinition/EpisodeOfCare"
                            }
                        }
                    }
                };
            }
            {
                // 9. MedicationDispense.supportingInformation
                this.Element_SupportingInformation = new ElementDefinitionInfo
                {
                    Name = "Element_SupportingInformation",
                    Path= "MedicationDispense.supportingInformation",
                    Id = "MedicationDispense.supportingInformation",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Resource"
                            }
                        }
                    }
                };
            }
            {
                // 10. MedicationDispense.performer
                this.Element_Performer = new ElementDefinitionInfo
                {
                    Name = "Element_Performer",
                    Path= "MedicationDispense.performer",
                    Id = "MedicationDispense.performer",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Performer
                        {
                        }
                    }
                };
            }
            {
                // 13. MedicationDispense.location
                this.Element_Location = new ElementDefinitionInfo
                {
                    Name = "Element_Location",
                    Path= "MedicationDispense.location",
                    Id = "MedicationDispense.location",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Location"
                            }
                        }
                    }
                };
            }
            {
                // 14. MedicationDispense.authorizingPrescription
                this.Element_AuthorizingPrescription = new ElementDefinitionInfo
                {
                    Name = "Element_AuthorizingPrescription",
                    Path= "MedicationDispense.authorizingPrescription",
                    Id = "MedicationDispense.authorizingPrescription",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/MedicationRequest"
                            }
                        }
                    }
                };
            }
            {
                // 15. MedicationDispense.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "MedicationDispense.type",
                    Id = "MedicationDispense.type",
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
                // 16. MedicationDispense.quantity
                this.Element_Quantity = new ElementDefinitionInfo
                {
                    Name = "Element_Quantity",
                    Path= "MedicationDispense.quantity",
                    Id = "MedicationDispense.quantity",
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
                // 17. MedicationDispense.daysSupply
                this.Element_DaysSupply = new ElementDefinitionInfo
                {
                    Name = "Element_DaysSupply",
                    Path= "MedicationDispense.daysSupply",
                    Id = "MedicationDispense.daysSupply",
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
                // 18. MedicationDispense.whenPrepared
                this.Element_WhenPrepared = new ElementDefinitionInfo
                {
                    Name = "Element_WhenPrepared",
                    Path= "MedicationDispense.whenPrepared",
                    Id = "MedicationDispense.whenPrepared",
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
                // 19. MedicationDispense.whenHandedOver
                this.Element_WhenHandedOver = new ElementDefinitionInfo
                {
                    Name = "Element_WhenHandedOver",
                    Path= "MedicationDispense.whenHandedOver",
                    Id = "MedicationDispense.whenHandedOver",
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
                // 20. MedicationDispense.destination
                this.Element_Destination = new ElementDefinitionInfo
                {
                    Name = "Element_Destination",
                    Path= "MedicationDispense.destination",
                    Id = "MedicationDispense.destination",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Location"
                            }
                        }
                    }
                };
            }
            {
                // 21. MedicationDispense.receiver
                this.Element_Receiver = new ElementDefinitionInfo
                {
                    Name = "Element_Receiver",
                    Path= "MedicationDispense.receiver",
                    Id = "MedicationDispense.receiver",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/Practitioner"
                            }
                        }
                    }
                };
            }
            {
                // 22. MedicationDispense.note
                this.Element_Note = new ElementDefinitionInfo
                {
                    Name = "Element_Note",
                    Path= "MedicationDispense.note",
                    Id = "MedicationDispense.note",
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
            {
                // 23. MedicationDispense.dosageInstruction
                this.Element_DosageInstruction = new ElementDefinitionInfo
                {
                    Name = "Element_DosageInstruction",
                    Path= "MedicationDispense.dosageInstruction",
                    Id = "MedicationDispense.dosageInstruction",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Dosage
                        {
                        }
                    }
                };
            }
            {
                // 24. MedicationDispense.substitution
                this.Element_Substitution = new ElementDefinitionInfo
                {
                    Name = "Element_Substitution",
                    Path= "MedicationDispense.substitution",
                    Id = "MedicationDispense.substitution",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_Substitution
                        {
                        }
                    }
                };
            }
            {
                // 29. MedicationDispense.detectedIssue
                this.Element_DetectedIssue = new ElementDefinitionInfo
                {
                    Name = "Element_DetectedIssue",
                    Path= "MedicationDispense.detectedIssue",
                    Id = "MedicationDispense.detectedIssue",
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
                // 30. MedicationDispense.eventHistory
                this.Element_EventHistory = new ElementDefinitionInfo
                {
                    Name = "Element_EventHistory",
                    Path= "MedicationDispense.eventHistory",
                    Id = "MedicationDispense.eventHistory",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Provenance"
                            }
                        }
                    }
                };
            }
            this.Name = "MedicationDispense";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MedicationDispense";
        }
    }
}
