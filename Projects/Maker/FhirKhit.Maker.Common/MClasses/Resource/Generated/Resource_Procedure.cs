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
      "id": "Procedure",
      "url": "http://hl7.org/fhir/StructureDefinition/Procedure",
      "version": "4.0.0",
      "name": "Procedure",
      "status": "draft",
      "publisher": "Health Level Seven International (Patient Care)",
      "description": "An action that is or was performed on or for a patient. This can be a physical intervention like an operation, or less invasive like long term services, counseling, or hypnotherapy.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Procedure",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Procedure",
            "path": "Procedure",
            "short": "An action that is being or was performed on a patient",
            "definition": "An action that is or was performed on or for a patient. This can be a physical intervention like an operation, or less invasive like long term services, counseling, or hypnotherapy.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Procedure.identifier",
            "path": "Procedure.identifier",
            "short": "External Identifiers for this procedure",
            "definition": "Business identifiers assigned to this procedure by the performer or other systems which remain constant as the resource is updated and is propagated from server to server.",
            "comment": "This is a business identifier, not a resource identifier (see [discussion](resource.html#identifiers)).  It is best practice for the identifier to only appear on a single resource instance, however business practices may occasionally dictate that multiple resource instances with the same identifier can exist - possibly even with different resource types.  For example, multiple Patient and Person resource instances might share the same social insurance number.",
            "requirements": "Allows identification of the procedure as it is known by various participating systems and in a way that remains consistent across servers.",
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
            "id": "Procedure.instantiatesCanonical",
            "path": "Procedure.instantiatesCanonical",
            "short": "Instantiates FHIR protocol or definition",
            "definition": "The URL pointing to a FHIR-defined protocol, guideline, order set or other definition that is adhered to in whole or in part by this Procedure.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/PlanDefinition",
                  "http://hl7.org/fhir/StructureDefinition/ActivityDefinition",
                  "http://hl7.org/fhir/StructureDefinition/Measure",
                  "http://hl7.org/fhir/StructureDefinition/OperationDefinition",
                  "http://hl7.org/fhir/StructureDefinition/Questionnaire"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Procedure.instantiatesUri",
            "path": "Procedure.instantiatesUri",
            "short": "Instantiates external protocol or definition",
            "definition": "The URL pointing to an externally maintained protocol, guideline, order set or other definition that is adhered to in whole or in part by this Procedure.",
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
            "id": "Procedure.basedOn",
            "path": "Procedure.basedOn",
            "short": "A request for this procedure",
            "definition": "A reference to a resource that contains details of the request for this procedure.",
            "alias": [
              "fulfills"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/CarePlan",
                  "http://hl7.org/fhir/StructureDefinition/ServiceRequest"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Procedure.partOf",
            "path": "Procedure.partOf",
            "short": "Part of referenced event",
            "definition": "A larger event of which this particular procedure is a component or step.",
            "comment": "The MedicationAdministration resource has a partOf reference to Procedure, but this is not a circular reference.   For example, the anesthesia MedicationAdministration is part of the surgical Procedure (MedicationAdministration.partOf = Procedure).  For example, the procedure to insert the IV port for an IV medication administration is part of the medication administration (Procedure.partOf = MedicationAdministration).",
            "alias": [
              "container"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Procedure",
                  "http://hl7.org/fhir/StructureDefinition/Observation",
                  "http://hl7.org/fhir/StructureDefinition/MedicationAdministration"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Procedure.status",
            "path": "Procedure.status",
            "short": "preparation | in-progress | not-done | suspended | aborted | completed | entered-in-error | unknown",
            "definition": "A code specifying the state of the procedure. Generally, this will be the in-progress or completed state.",
            "comment": "The \"unknown\" code is not to be used to convey other statuses.  The \"unknown\" code should be used when one of the statuses applies, but the authoring system doesn't know the current state of the procedure.\n\nThis element is labeled as a modifier because the status contains codes that mark the resource as not currently valid.",
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
                  "valueString": "ProcedureStatus"
                }
              ],
              "strength": "required",
              "description": "A code specifying the state of the procedure.",
              "valueSet": "http://hl7.org/fhir/ValueSet/event-status|4.0.0"
            }
          },
          {
            "id": "Procedure.statusReason",
            "path": "Procedure.statusReason",
            "short": "Reason for current status",
            "definition": "Captures the reason for the current state of the procedure.",
            "comment": "This is generally only used for \"exception\" statuses such as \"not-done\", \"suspended\" or \"aborted\". The reason for performing the event at all is captured in reasonCode, not here.",
            "alias": [
              "Suspended Reason",
              "Cancelled Reason"
            ],
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
                  "valueString": "ProcedureNegationReason"
                }
              ],
              "strength": "example",
              "description": "A code that identifies the reason a procedure was not performed.",
              "valueSet": "http://hl7.org/fhir/ValueSet/procedure-not-performed-reason"
            }
          },
          {
            "id": "Procedure.category",
            "path": "Procedure.category",
            "short": "Classification of the procedure",
            "definition": "A code that classifies the procedure for searching, sorting and display purposes (e.g. \"Surgical Procedure\").",
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
                  "valueString": "ProcedureCategory"
                }
              ],
              "strength": "example",
              "description": "A code that classifies a procedure for searching, sorting and display purposes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/procedure-category"
            }
          },
          {
            "id": "Procedure.code",
            "path": "Procedure.code",
            "short": "Identification of the procedure",
            "definition": "The specific procedure that is performed. Use text if the exact nature of the procedure cannot be coded (e.g. \"Laparoscopic Appendectomy\").",
            "requirements": "0..1 to account for primarily narrative only resources.",
            "alias": [
              "type"
            ],
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
                  "valueString": "ProcedureCode"
                }
              ],
              "strength": "example",
              "description": "A code to identify a specific procedure .",
              "valueSet": "http://hl7.org/fhir/ValueSet/procedure-code"
            }
          },
          {
            "id": "Procedure.subject",
            "path": "Procedure.subject",
            "short": "Who the procedure was performed on",
            "definition": "The person, animal or group on which the procedure was performed.",
            "alias": [
              "patient"
            ],
            "min": 1,
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
            "id": "Procedure.encounter",
            "path": "Procedure.encounter",
            "short": "Encounter created as part of",
            "definition": "The Encounter during which this Procedure was created or performed or to which the creation of this record is tightly associated.",
            "comment": "This will typically be the encounter the event occurred within, but some activities may be initiated prior to or after the official completion of an encounter but still be tied to the context of the encounter.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Encounter"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Procedure.performed[x]",
            "path": "Procedure.performed[x]",
            "short": "When the procedure was performed",
            "definition": "Estimated or actual date, date-time, period, or age when the procedure was performed.  Allows a period to support complex procedures that span more than one date, and also allows for the length of the procedure to be captured.",
            "comment": "Age is generally used when the patient reports an age at which the procedure was performed. Range is generally used when the patient reports an age range when the procedure was performed, such as sometime between 20-25 years old.  dateTime supports a range of precision due to some procedures being reported as past procedures that might not have millisecond precision while other procedures performed and documented during the encounter might have more precise UTC timestamps with timezone.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              },
              {
                "code": "Period"
              },
              {
                "code": "string"
              },
              {
                "code": "Age"
              },
              {
                "code": "Range"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Procedure.recorder",
            "path": "Procedure.recorder",
            "short": "Who recorded the procedure",
            "definition": "Individual who recorded the record and takes responsibility for its content.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Procedure.asserter",
            "path": "Procedure.asserter",
            "short": "Person who asserts this procedure",
            "definition": "Individual who is making the procedure statement.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Procedure.performer",
            "path": "Procedure.performer",
            "short": "The people who performed the procedure",
            "definition": "Limited to \"real\" people rather than equipment.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Procedure.performer.function",
            "path": "Procedure.performer.function",
            "short": "Type of performance",
            "definition": "Distinguishes the type of involvement of the performer in the procedure. For example, surgeon, anaesthetist, endoscopist.",
            "requirements": "Allows disambiguation of the types of involvement of different performers.",
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
                  "valueString": "ProcedurePerformerRole"
                }
              ],
              "strength": "example",
              "description": "A code that identifies the role of a performer of the procedure.",
              "valueSet": "http://hl7.org/fhir/ValueSet/performer-role"
            }
          },
          {
            "id": "Procedure.performer.actor",
            "path": "Procedure.performer.actor",
            "short": "The reference to the practitioner",
            "definition": "The practitioner who was involved in the procedure.",
            "requirements": "A reference to Device supports use cases, such as pacemakers.",
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
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/Device"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Procedure.performer.onBehalfOf",
            "path": "Procedure.performer.onBehalfOf",
            "short": "Organization the device or practitioner was acting for",
            "definition": "The organization the device or practitioner was acting on behalf of.",
            "requirements": "Practitioners and Devices can be associated with multiple organizations.  This element indicates which organization they were acting on behalf of when performing the action.",
            "min": 0,
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
            "id": "Procedure.location",
            "path": "Procedure.location",
            "short": "Where the procedure happened",
            "definition": "The location where the procedure actually happened.  E.g. a newborn at home, a tracheostomy at a restaurant.",
            "requirements": "Ties a procedure to where the records are likely kept.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Location"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Procedure.reasonCode",
            "path": "Procedure.reasonCode",
            "short": "Coded reason procedure performed",
            "definition": "The coded reason why the procedure was performed. This may be a coded entity of some type, or may simply be present as text.",
            "comment": "Use Procedure.reasonCode when a code sufficiently describes the reason.  Use Procedure.reasonReference when referencing a resource, which allows more information to be conveyed, such as onset date. Procedure.reasonCode and Procedure.reasonReference are not meant to be duplicative.  For a single reason, either Procedure.reasonCode or Procedure.reasonReference can be used.  Procedure.reasonCode may be a summary code, or Procedure.reasonReference may be used to reference a very precise definition of the reason using Condition | Observation | Procedure | DiagnosticReport | DocumentReference.  Both Procedure.reasonCode and Procedure.reasonReference can be used if they are describing different reasons for the procedure.",
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
                  "valueString": "ProcedureReason"
                }
              ],
              "strength": "example",
              "description": "A code that identifies the reason a procedure is  required.",
              "valueSet": "http://hl7.org/fhir/ValueSet/procedure-reason"
            }
          },
          {
            "id": "Procedure.reasonReference",
            "path": "Procedure.reasonReference",
            "short": "The justification that the procedure was performed",
            "definition": "The justification of why the procedure was performed.",
            "comment": "It is possible for a procedure to be a reason (such as C-Section) for another procedure (such as an epidural). Other examples include endoscopy for dilatation and biopsy (a combination of diagnostic and therapeutic use). \nUse Procedure.reasonCode when a code sufficiently describes the reason.  Use Procedure.reasonReference when referencing a resource, which allows more information to be conveyed, such as onset date. Procedure.reasonCode and Procedure.reasonReference are not meant to be duplicative.  For a single reason, either Procedure.reasonCode or Procedure.reasonReference can be used.  Procedure.reasonCode may be a summary code, or Procedure.reasonReference may be used to reference a very precise definition of the reason using Condition | Observation | Procedure | DiagnosticReport | DocumentReference.  Both Procedure.reasonCode and Procedure.reasonReference can be used if they are describing different reasons for the procedure.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Condition",
                  "http://hl7.org/fhir/StructureDefinition/Observation",
                  "http://hl7.org/fhir/StructureDefinition/Procedure",
                  "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",
                  "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Procedure.bodySite",
            "path": "Procedure.bodySite",
            "short": "Target body sites",
            "definition": "Detailed and structured anatomical location information. Multiple locations are allowed - e.g. multiple punch biopsies of a lesion.",
            "comment": "If the use case requires attributes from the BodySite resource (e.g. to identify and track separately) then use the standard extension [procedure-targetbodystructure](extension-procedure-targetbodystructure.html).",
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
                  "valueString": "BodySite"
                }
              ],
              "strength": "example",
              "description": "Codes describing anatomical locations. May include laterality.",
              "valueSet": "http://hl7.org/fhir/ValueSet/body-site"
            }
          },
          {
            "id": "Procedure.outcome",
            "path": "Procedure.outcome",
            "short": "The result of procedure",
            "definition": "The outcome of the procedure - did it resolve the reasons for the procedure being performed?",
            "comment": "If outcome contains narrative text only, it can be captured using the CodeableConcept.text.",
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
                  "valueString": "ProcedureOutcome"
                }
              ],
              "strength": "example",
              "description": "An outcome of a procedure - whether it was resolved or otherwise.",
              "valueSet": "http://hl7.org/fhir/ValueSet/procedure-outcome"
            }
          },
          {
            "id": "Procedure.report",
            "path": "Procedure.report",
            "short": "Any report resulting from the procedure",
            "definition": "This could be a histology result, pathology report, surgical report, etc.",
            "comment": "There could potentially be multiple reports - e.g. if this was a procedure which took multiple biopsies resulting in a number of anatomical pathology reports.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",
                  "http://hl7.org/fhir/StructureDefinition/DocumentReference",
                  "http://hl7.org/fhir/StructureDefinition/Composition"
                ]
              }
            ]
          },
          {
            "id": "Procedure.complication",
            "path": "Procedure.complication",
            "short": "Complication following the procedure",
            "definition": "Any complications that occurred during the procedure, or in the immediate post-performance period. These are generally tracked separately from the notes, which will typically describe the procedure itself rather than any 'post procedure' issues.",
            "comment": "If complications are only expressed by the narrative text, they can be captured using the CodeableConcept.text.",
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
                  "valueString": "ProcedureComplication"
                }
              ],
              "strength": "example",
              "description": "Codes describing complications that resulted from a procedure.",
              "valueSet": "http://hl7.org/fhir/ValueSet/condition-code"
            }
          },
          {
            "id": "Procedure.complicationDetail",
            "path": "Procedure.complicationDetail",
            "short": "A condition that is a result of the procedure",
            "definition": "Any complications that occurred during the procedure, or in the immediate post-performance period.",
            "requirements": "This is used to document a condition that is a result of the procedure, not the condition that was the reason for the procedure.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Condition"
                ]
              }
            ]
          },
          {
            "id": "Procedure.followUp",
            "path": "Procedure.followUp",
            "short": "Instructions for follow up",
            "definition": "If the procedure required specific follow up - e.g. removal of sutures. The follow up may be represented as a simple note or could potentially be more complex, in which case the CarePlan resource can be used.",
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
                  "valueString": "ProcedureFollowUp"
                }
              ],
              "strength": "example",
              "description": "Specific follow up required for a procedure e.g. removal of sutures.",
              "valueSet": "http://hl7.org/fhir/ValueSet/procedure-followup"
            }
          },
          {
            "id": "Procedure.note",
            "path": "Procedure.note",
            "short": "Additional information about the procedure",
            "definition": "Any other notes and comments about the procedure.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Annotation"
              }
            ]
          },
          {
            "id": "Procedure.focalDevice",
            "path": "Procedure.focalDevice",
            "short": "Manipulated, implanted, or removed device",
            "definition": "A device that is implanted, removed or otherwise manipulated (calibration, battery replacement, fitting a prosthesis, attaching a wound-vac, etc.) as a focal portion of the Procedure.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Procedure.focalDevice.action",
            "path": "Procedure.focalDevice.action",
            "short": "Kind of change to device",
            "definition": "The kind of change that happened to the device during the procedure.",
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
                  "valueString": "DeviceActionKind"
                }
              ],
              "strength": "preferred",
              "description": "A kind of change that happened to the device during the procedure.",
              "valueSet": "http://hl7.org/fhir/ValueSet/device-action"
            }
          },
          {
            "id": "Procedure.focalDevice.manipulated",
            "path": "Procedure.focalDevice.manipulated",
            "short": "Device that was changed",
            "definition": "The device that was manipulated (changed) during the procedure.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Device"
                ]
              }
            ]
          },
          {
            "id": "Procedure.usedReference",
            "path": "Procedure.usedReference",
            "short": "Items used during procedure",
            "definition": "Identifies medications, devices and any other substance used as part of the procedure.",
            "comment": "For devices actually implanted or removed, use Procedure.device.",
            "requirements": "Used for tracking contamination, etc.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/Medication",
                  "http://hl7.org/fhir/StructureDefinition/Substance"
                ]
              }
            ]
          },
          {
            "id": "Procedure.usedCode",
            "path": "Procedure.usedCode",
            "short": "Coded items used during the procedure",
            "definition": "Identifies coded items that were used as part of the procedure.",
            "comment": "For devices actually implanted or removed, use Procedure.device.",
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
                  "valueString": "ProcedureUsed"
                }
              ],
              "strength": "example",
              "description": "Codes describing items used during a procedure.",
              "valueSet": "http://hl7.org/fhir/ValueSet/device-kind"
            }
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:440
    /// <summary>
    /// Fhir resource 'Procedure'
    /// </summary>
    // 0. Procedure
    public class Resource_Procedure : FhirKhit.Maker.Common.Resource.ResourceBase                                                           // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 15. Procedure.performer
        public class Type_Performer : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 16. Procedure.performer.function
            public ElementDefinitionInfo Element_Function;                                                                                  // MakerGen.cs:212
            // 17. Procedure.performer.actor
            public ElementDefinitionInfo Element_Actor;                                                                                     // MakerGen.cs:212
            // 18. Procedure.performer.onBehalfOf
            public ElementDefinitionInfo Element_OnBehalfOf;                                                                                // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "Procedure.performer",                                                                                           // MakerGen.cs:388
                    ElementId = "Procedure.performer"                                                                                       // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Function.Write(sDef);                                                                                               // MakerGen.cs:216
                Element_Actor.Write(sDef);                                                                                                  // MakerGen.cs:216
                Element_OnBehalfOf.Write(sDef);                                                                                             // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Performer()                                                                                                         // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 16. Procedure.performer.function
                    this.Element_Function = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Function",                                                                                          // MakerGen.cs:231
                        Path= "Procedure.performer.function",                                                                               // MakerGen.cs:232
                        Id = "Procedure.performer.function",                                                                                // MakerGen.cs:233
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
                    // 17. Procedure.performer.actor
                    this.Element_Actor = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Actor",                                                                                             // MakerGen.cs:231
                        Path= "Procedure.performer.actor",                                                                                  // MakerGen.cs:232
                        Id = "Procedure.performer.actor",                                                                                   // MakerGen.cs:233
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
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                                // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/Device"                                                        // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:343
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 18. Procedure.performer.onBehalfOf
                    this.Element_OnBehalfOf = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_OnBehalfOf",                                                                                        // MakerGen.cs:231
                        Path= "Procedure.performer.onBehalfOf",                                                                             // MakerGen.cs:232
                        Id = "Procedure.performer.onBehalfOf",                                                                              // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:339
                            {                                                                                                               // MakerGen.cs:340
                                TargetProfile = new String[]                                                                                // MakerGen.cs:342
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:343
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 29. Procedure.focalDevice
        public class Type_FocalDevice : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 30. Procedure.focalDevice.action
            public ElementDefinitionInfo Element_Action;                                                                                    // MakerGen.cs:212
            // 31. Procedure.focalDevice.manipulated
            public ElementDefinitionInfo Element_Manipulated;                                                                               // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "Procedure.focalDevice",                                                                                         // MakerGen.cs:388
                    ElementId = "Procedure.focalDevice"                                                                                     // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Action.Write(sDef);                                                                                                 // MakerGen.cs:216
                Element_Manipulated.Write(sDef);                                                                                            // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_FocalDevice()                                                                                                       // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 30. Procedure.focalDevice.action
                    this.Element_Action = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Action",                                                                                            // MakerGen.cs:231
                        Path= "Procedure.focalDevice.action",                                                                               // MakerGen.cs:232
                        Id = "Procedure.focalDevice.action",                                                                                // MakerGen.cs:233
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
                    // 31. Procedure.focalDevice.manipulated
                    this.Element_Manipulated = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Manipulated",                                                                                       // MakerGen.cs:231
                        Path= "Procedure.focalDevice.manipulated",                                                                          // MakerGen.cs:232
                        Id = "Procedure.focalDevice.manipulated",                                                                           // MakerGen.cs:233
                        Min = 1,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:339
                            {                                                                                                               // MakerGen.cs:340
                                TargetProfile = new String[]                                                                                // MakerGen.cs:342
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Device"                                                        // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:343
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 1. Procedure.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:212
        // 2. Procedure.instantiatesCanonical
        public ElementDefinitionInfo Element_InstantiatesCanonical;                                                                         // MakerGen.cs:212
        // 3. Procedure.instantiatesUri
        public ElementDefinitionInfo Element_InstantiatesUri;                                                                               // MakerGen.cs:212
        // 4. Procedure.basedOn
        public ElementDefinitionInfo Element_BasedOn;                                                                                       // MakerGen.cs:212
        // 5. Procedure.partOf
        public ElementDefinitionInfo Element_PartOf;                                                                                        // MakerGen.cs:212
        // 6. Procedure.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:212
        // 7. Procedure.statusReason
        public ElementDefinitionInfo Element_StatusReason;                                                                                  // MakerGen.cs:212
        // 8. Procedure.category
        public ElementDefinitionInfo Element_Category;                                                                                      // MakerGen.cs:212
        // 9. Procedure.code
        public ElementDefinitionInfo Element_Code;                                                                                          // MakerGen.cs:212
        // 10. Procedure.subject
        public ElementDefinitionInfo Element_Subject;                                                                                       // MakerGen.cs:212
        // 11. Procedure.encounter
        public ElementDefinitionInfo Element_Encounter;                                                                                     // MakerGen.cs:212
        // 12. Procedure.performed[x]
        public ElementDefinitionInfo Element_Performed;                                                                                     // MakerGen.cs:212
        // 13. Procedure.recorder
        public ElementDefinitionInfo Element_Recorder;                                                                                      // MakerGen.cs:212
        // 14. Procedure.asserter
        public ElementDefinitionInfo Element_Asserter;                                                                                      // MakerGen.cs:212
        // 15. Procedure.performer
        public ElementDefinitionInfo Element_Performer;                                                                                     // MakerGen.cs:212
        // 19. Procedure.location
        public ElementDefinitionInfo Element_Location;                                                                                      // MakerGen.cs:212
        // 20. Procedure.reasonCode
        public ElementDefinitionInfo Element_ReasonCode;                                                                                    // MakerGen.cs:212
        // 21. Procedure.reasonReference
        public ElementDefinitionInfo Element_ReasonReference;                                                                               // MakerGen.cs:212
        // 22. Procedure.bodySite
        public ElementDefinitionInfo Element_BodySite;                                                                                      // MakerGen.cs:212
        // 23. Procedure.outcome
        public ElementDefinitionInfo Element_Outcome;                                                                                       // MakerGen.cs:212
        // 24. Procedure.report
        public ElementDefinitionInfo Element_Report;                                                                                        // MakerGen.cs:212
        // 25. Procedure.complication
        public ElementDefinitionInfo Element_Complication;                                                                                  // MakerGen.cs:212
        // 26. Procedure.complicationDetail
        public ElementDefinitionInfo Element_ComplicationDetail;                                                                            // MakerGen.cs:212
        // 27. Procedure.followUp
        public ElementDefinitionInfo Element_FollowUp;                                                                                      // MakerGen.cs:212
        // 28. Procedure.note
        public ElementDefinitionInfo Element_Note;                                                                                          // MakerGen.cs:212
        // 29. Procedure.focalDevice
        public ElementDefinitionInfo Element_FocalDevice;                                                                                   // MakerGen.cs:212
        // 32. Procedure.usedReference
        public ElementDefinitionInfo Element_UsedReference;                                                                                 // MakerGen.cs:212
        // 33. Procedure.usedCode
        public ElementDefinitionInfo Element_UsedCode;                                                                                      // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "Procedure",                                                                                                         // MakerGen.cs:388
                ElementId = "Procedure"                                                                                                     // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_InstantiatesCanonical.Write(sDef);                                                                                      // MakerGen.cs:216
            Element_InstantiatesUri.Write(sDef);                                                                                            // MakerGen.cs:216
            Element_BasedOn.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_PartOf.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_StatusReason.Write(sDef);                                                                                               // MakerGen.cs:216
            Element_Category.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_Code.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Subject.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Encounter.Write(sDef);                                                                                                  // MakerGen.cs:216
            Element_Performed.Write(sDef);                                                                                                  // MakerGen.cs:216
            Element_Recorder.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_Asserter.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_Performer.Write(sDef);                                                                                                  // MakerGen.cs:216
            Element_Location.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_ReasonCode.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_ReasonReference.Write(sDef);                                                                                            // MakerGen.cs:216
            Element_BodySite.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_Outcome.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Report.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Complication.Write(sDef);                                                                                               // MakerGen.cs:216
            Element_ComplicationDetail.Write(sDef);                                                                                         // MakerGen.cs:216
            Element_FollowUp.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_Note.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_FocalDevice.Write(sDef);                                                                                                // MakerGen.cs:216
            Element_UsedReference.Write(sDef);                                                                                              // MakerGen.cs:216
            Element_UsedCode.Write(sDef);                                                                                                   // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Resource_Procedure()                                                                                                         // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. Procedure.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:231
                    Path= "Procedure.identifier",                                                                                           // MakerGen.cs:232
                    Id = "Procedure.identifier",                                                                                            // MakerGen.cs:233
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
                // 2. Procedure.instantiatesCanonical
                this.Element_InstantiatesCanonical = new ElementDefinitionInfo                                                              // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_InstantiatesCanonical",                                                                                 // MakerGen.cs:231
                    Path= "Procedure.instantiatesCanonical",                                                                                // MakerGen.cs:232
                    Id = "Procedure.instantiatesCanonical",                                                                                 // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Canonical                                                             // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:299
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/PlanDefinition",                                                   // MakerGen.cs:299
                                "http://hl7.org/fhir/StructureDefinition/ActivityDefinition",                                               // MakerGen.cs:299
                                "http://hl7.org/fhir/StructureDefinition/Measure",                                                          // MakerGen.cs:299
                                "http://hl7.org/fhir/StructureDefinition/OperationDefinition",                                              // MakerGen.cs:299
                                "http://hl7.org/fhir/StructureDefinition/Questionnaire"                                                     // MakerGen.cs:299
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 3. Procedure.instantiatesUri
                this.Element_InstantiatesUri = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_InstantiatesUri",                                                                                       // MakerGen.cs:231
                    Path= "Procedure.instantiatesUri",                                                                                      // MakerGen.cs:232
                    Id = "Procedure.instantiatesUri",                                                                                       // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uri                                                                   // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 4. Procedure.basedOn
                this.Element_BasedOn = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_BasedOn",                                                                                               // MakerGen.cs:231
                    Path= "Procedure.basedOn",                                                                                              // MakerGen.cs:232
                    Id = "Procedure.basedOn",                                                                                               // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/CarePlan",                                                         // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/ServiceRequest"                                                    // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 5. Procedure.partOf
                this.Element_PartOf = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_PartOf",                                                                                                // MakerGen.cs:231
                    Path= "Procedure.partOf",                                                                                               // MakerGen.cs:232
                    Id = "Procedure.partOf",                                                                                                // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Procedure",                                                        // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Observation",                                                      // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/MedicationAdministration"                                          // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 6. Procedure.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Status",                                                                                                // MakerGen.cs:231
                    Path= "Procedure.status",                                                                                               // MakerGen.cs:232
                    Id = "Procedure.status",                                                                                                // MakerGen.cs:233
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
                // 7. Procedure.statusReason
                this.Element_StatusReason = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_StatusReason",                                                                                          // MakerGen.cs:231
                    Path= "Procedure.statusReason",                                                                                         // MakerGen.cs:232
                    Id = "Procedure.statusReason",                                                                                          // MakerGen.cs:233
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
                // 8. Procedure.category
                this.Element_Category = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Category",                                                                                              // MakerGen.cs:231
                    Path= "Procedure.category",                                                                                             // MakerGen.cs:232
                    Id = "Procedure.category",                                                                                              // MakerGen.cs:233
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
                // 9. Procedure.code
                this.Element_Code = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Code",                                                                                                  // MakerGen.cs:231
                    Path= "Procedure.code",                                                                                                 // MakerGen.cs:232
                    Id = "Procedure.code",                                                                                                  // MakerGen.cs:233
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
                // 10. Procedure.subject
                this.Element_Subject = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Subject",                                                                                               // MakerGen.cs:231
                    Path= "Procedure.subject",                                                                                              // MakerGen.cs:232
                    Id = "Procedure.subject",                                                                                               // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
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
                // 11. Procedure.encounter
                this.Element_Encounter = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Encounter",                                                                                             // MakerGen.cs:231
                    Path= "Procedure.encounter",                                                                                            // MakerGen.cs:232
                    Id = "Procedure.encounter",                                                                                             // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Encounter"                                                         // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 12. Procedure.performed[x]
                this.Element_Performed = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Performed",                                                                                             // MakerGen.cs:231
                    Path= "Procedure.performed[x]",                                                                                         // MakerGen.cs:232
                    Id = "Procedure.performed[x]",                                                                                          // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        },                                                                                                                  // MakerGen.cs:300
                        new FhirKhit.Maker.Common.Complex.Type_Period                                                                       // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        },                                                                                                                  // MakerGen.cs:353
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        },                                                                                                                  // MakerGen.cs:300
                        new FhirKhit.Maker.Common.Complex.Type_Age                                                                          // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        },                                                                                                                  // MakerGen.cs:353
                        new FhirKhit.Maker.Common.Complex.Type_Range                                                                        // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 13. Procedure.recorder
                this.Element_Recorder = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Recorder",                                                                                              // MakerGen.cs:231
                    Path= "Procedure.recorder",                                                                                             // MakerGen.cs:232
                    Id = "Procedure.recorder",                                                                                              // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Patient",                                                          // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                                    // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                                  // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 14. Procedure.asserter
                this.Element_Asserter = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Asserter",                                                                                              // MakerGen.cs:231
                    Path= "Procedure.asserter",                                                                                             // MakerGen.cs:232
                    Id = "Procedure.asserter",                                                                                              // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Patient",                                                          // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                                    // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                                  // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 15. Procedure.performer
                this.Element_Performer = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Performer",                                                                                             // MakerGen.cs:231
                    Path= "Procedure.performer",                                                                                            // MakerGen.cs:232
                    Id = "Procedure.performer",                                                                                             // MakerGen.cs:233
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
                // 19. Procedure.location
                this.Element_Location = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Location",                                                                                              // MakerGen.cs:231
                    Path= "Procedure.location",                                                                                             // MakerGen.cs:232
                    Id = "Procedure.location",                                                                                              // MakerGen.cs:233
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
                // 20. Procedure.reasonCode
                this.Element_ReasonCode = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_ReasonCode",                                                                                            // MakerGen.cs:231
                    Path= "Procedure.reasonCode",                                                                                           // MakerGen.cs:232
                    Id = "Procedure.reasonCode",                                                                                            // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 21. Procedure.reasonReference
                this.Element_ReasonReference = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_ReasonReference",                                                                                       // MakerGen.cs:231
                    Path= "Procedure.reasonReference",                                                                                      // MakerGen.cs:232
                    Id = "Procedure.reasonReference",                                                                                       // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Condition",                                                        // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Observation",                                                      // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Procedure",                                                        // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",                                                 // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                                 // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 22. Procedure.bodySite
                this.Element_BodySite = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_BodySite",                                                                                              // MakerGen.cs:231
                    Path= "Procedure.bodySite",                                                                                             // MakerGen.cs:232
                    Id = "Procedure.bodySite",                                                                                              // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 23. Procedure.outcome
                this.Element_Outcome = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Outcome",                                                                                               // MakerGen.cs:231
                    Path= "Procedure.outcome",                                                                                              // MakerGen.cs:232
                    Id = "Procedure.outcome",                                                                                               // MakerGen.cs:233
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
                // 24. Procedure.report
                this.Element_Report = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Report",                                                                                                // MakerGen.cs:231
                    Path= "Procedure.report",                                                                                               // MakerGen.cs:232
                    Id = "Procedure.report",                                                                                                // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",                                                 // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/DocumentReference",                                                // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Composition"                                                       // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 25. Procedure.complication
                this.Element_Complication = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Complication",                                                                                          // MakerGen.cs:231
                    Path= "Procedure.complication",                                                                                         // MakerGen.cs:232
                    Id = "Procedure.complication",                                                                                          // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 26. Procedure.complicationDetail
                this.Element_ComplicationDetail = new ElementDefinitionInfo                                                                 // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_ComplicationDetail",                                                                                    // MakerGen.cs:231
                    Path= "Procedure.complicationDetail",                                                                                   // MakerGen.cs:232
                    Id = "Procedure.complicationDetail",                                                                                    // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Condition"                                                         // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 27. Procedure.followUp
                this.Element_FollowUp = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_FollowUp",                                                                                              // MakerGen.cs:231
                    Path= "Procedure.followUp",                                                                                             // MakerGen.cs:232
                    Id = "Procedure.followUp",                                                                                              // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 28. Procedure.note
                this.Element_Note = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Note",                                                                                                  // MakerGen.cs:231
                    Path= "Procedure.note",                                                                                                 // MakerGen.cs:232
                    Id = "Procedure.note",                                                                                                  // MakerGen.cs:233
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
                // 29. Procedure.focalDevice
                this.Element_FocalDevice = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_FocalDevice",                                                                                           // MakerGen.cs:231
                    Path= "Procedure.focalDevice",                                                                                          // MakerGen.cs:232
                    Id = "Procedure.focalDevice",                                                                                           // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_FocalDevice                                                                                                // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 32. Procedure.usedReference
                this.Element_UsedReference = new ElementDefinitionInfo                                                                      // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_UsedReference",                                                                                         // MakerGen.cs:231
                    Path= "Procedure.usedReference",                                                                                        // MakerGen.cs:232
                    Id = "Procedure.usedReference",                                                                                         // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Device",                                                           // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Medication",                                                       // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Substance"                                                         // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 33. Procedure.usedCode
                this.Element_UsedCode = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_UsedCode",                                                                                              // MakerGen.cs:231
                    Path= "Procedure.usedCode",                                                                                             // MakerGen.cs:232
                    Id = "Procedure.usedCode",                                                                                              // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            this.Name = "Procedure";                                                                                                        // MakerGen.cs:458
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Procedure";                                                                 // MakerGen.cs:459
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:445
