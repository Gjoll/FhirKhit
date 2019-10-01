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
      "id": "ServiceRequest",
      "url": "http://hl7.org/fhir/StructureDefinition/ServiceRequest",
      "version": "4.0.0",
      "name": "ServiceRequest",
      "status": "draft",
      "publisher": "Health Level Seven International (Orders and Observations)",
      "description": "A record of a request for service such as diagnostic investigations, treatments, or operations to be performed.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "ServiceRequest",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "ServiceRequest",
            "path": "ServiceRequest",
            "short": "A request for a service to be performed",
            "definition": "A record of a request for service such as diagnostic investigations, treatments, or operations to be performed.",
            "alias": [
              "diagnostic request",
              "referral",
              "referral request",
              "transfer of care request"
            ],
            "min": 0,
            "max": "*"
          },
          {
            "id": "ServiceRequest.identifier",
            "path": "ServiceRequest.identifier",
            "short": "Identifiers assigned to this order",
            "definition": "Identifiers assigned to this order instance by the orderer and/or the receiver and/or order fulfiller.",
            "comment": "The identifier.type element is used to distinguish between the identifiers assigned by the orderer (known as the 'Placer' in HL7 v2) and the producer of the observations in response to the order (known as the 'Filler' in HL7 v2).  For further discussion and examples see the resource notes section below.",
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
            "id": "ServiceRequest.instantiatesCanonical",
            "path": "ServiceRequest.instantiatesCanonical",
            "short": "Instantiates FHIR protocol or definition",
            "definition": "The URL pointing to a FHIR-defined protocol, guideline, orderset or other definition that is adhered to in whole or in part by this ServiceRequest.",
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
            "id": "ServiceRequest.instantiatesUri",
            "path": "ServiceRequest.instantiatesUri",
            "short": "Instantiates external protocol or definition",
            "definition": "The URL pointing to an externally maintained protocol, guideline, orderset or other definition that is adhered to in whole or in part by this ServiceRequest.",
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
            "id": "ServiceRequest.basedOn",
            "path": "ServiceRequest.basedOn",
            "short": "What request fulfills",
            "definition": "Plan/proposal/order fulfilled by this request.",
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
                  "http://hl7.org/fhir/StructureDefinition/ServiceRequest",
                  "http://hl7.org/fhir/StructureDefinition/MedicationRequest"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ServiceRequest.replaces",
            "path": "ServiceRequest.replaces",
            "short": "What request replaces",
            "definition": "The request takes the place of the referenced completed or terminated request(s).",
            "alias": [
              "supersedes",
              "prior",
              "renewed order"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ServiceRequest"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ServiceRequest.requisition",
            "path": "ServiceRequest.requisition",
            "short": "Composite Request ID",
            "definition": "A shared identifier common to all service requests that were authorized more or less simultaneously by a single author, representing the composite or group identifier.",
            "comment": "Requests are linked either by a \"basedOn\" relationship (i.e. one request is fulfilling another) or by having a common requisition. Requests that are part of the same requisition are generally treated independently from the perspective of changing their state or maintaining them after initial creation.",
            "requirements": "Some business processes need to know if multiple items were ordered as part of the same \"requisition\" for billing or other purposes.",
            "alias": [
              "grouperId",
              "groupIdentifier"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Identifier"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ServiceRequest.status",
            "path": "ServiceRequest.status",
            "short": "draft | active | suspended | completed | entered-in-error | cancelled",
            "definition": "The status of the order.",
            "comment": "The status is generally fully in the control of the requester - they determine whether the order is draft or active and, after it has been activated, competed, cancelled or suspended. States relating to the activities of the performer are reflected on either the corresponding event (see [Event Pattern](event.html) for general discussion) or using the [Task](task.html) resource.",
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
                  "valueString": "ServiceRequestStatus"
                }
              ],
              "strength": "required",
              "description": "The status of a service order.",
              "valueSet": "http://hl7.org/fhir/ValueSet/request-status|4.0.0"
            }
          },
          {
            "id": "ServiceRequest.intent",
            "path": "ServiceRequest.intent",
            "short": "proposal | plan | order +",
            "definition": "Whether the request is a proposal, plan, an original order or a reflex order.",
            "comment": "This element is labeled as a modifier because the intent alters when and how the resource is actually applicable.",
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
                  "valueString": "ServiceRequestIntent"
                }
              ],
              "strength": "required",
              "description": "The kind of service request.",
              "valueSet": "http://hl7.org/fhir/ValueSet/request-intent|4.0.0"
            }
          },
          {
            "id": "ServiceRequest.category",
            "path": "ServiceRequest.category",
            "short": "Classification of service",
            "definition": "A code that classifies the service for searching, sorting and display purposes (e.g. \"Surgical Procedure\").",
            "comment": "There may be multiple axis of categorization depending on the context or use case for retrieving or displaying the resource.  The level of granularity is defined by the category concepts in the value set.",
            "requirements": "Used for filtering what service request are retrieved and displayed.",
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
                  "valueString": "ServiceRequestCategory"
                }
              ],
              "strength": "example",
              "description": "Classification of the requested service.",
              "valueSet": "http://hl7.org/fhir/ValueSet/servicerequest-category"
            }
          },
          {
            "id": "ServiceRequest.priority",
            "path": "ServiceRequest.priority",
            "short": "routine | urgent | asap | stat",
            "definition": "Indicates how quickly the ServiceRequest should be addressed with respect to other requests.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "meaningWhenMissing": "If missing, this task should be performed with normal priority",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ServiceRequestPriority"
                }
              ],
              "strength": "required",
              "description": "Identifies the level of importance to be assigned to actioning the request.",
              "valueSet": "http://hl7.org/fhir/ValueSet/request-priority|4.0.0"
            }
          },
          {
            "id": "ServiceRequest.doNotPerform",
            "path": "ServiceRequest.doNotPerform",
            "short": "True if service/procedure should not be performed",
            "definition": "Set this to true if the record is saying that the service/procedure should NOT be performed.",
            "comment": "In general, only the code and timeframe will be present, though occasional additional qualifiers such as body site or even performer could be included to narrow the scope of the prohibition.  If the ServiceRequest.code and ServiceRequest.doNotPerform both contain negation, that will reinforce prohibition and should not have a double negative interpretation.",
            "requirements": "Used for do not ambulate, do not elevate head of bed, do not flush NG tube, do not take blood pressure on a certain arm, etc.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "meaningWhenMissing": "If missing, the request is a positive request e.g. \"do perform\"",
            "isModifier": true,
            "isModifierReason": "If true this element negates the specified action. For Example,  instead of a request for a procedure, it is a request for the procedure to not occur.",
            "isSummary": true
          },
          {
            "id": "ServiceRequest.code",
            "path": "ServiceRequest.code",
            "short": "What is being requested/ordered",
            "definition": "A code that identifies a particular service (i.e., procedure, diagnostic investigation, or panel of investigations) that have been requested.",
            "comment": "Many laboratory and radiology procedure codes embed the specimen/organ system in the test order name, for example,  serum or serum/plasma glucose, or a chest x-ray. The specimen might not be recorded separately from the test code.",
            "alias": [
              "service requested"
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
                  "valueString": "ServiceRequestCode"
                }
              ],
              "strength": "example",
              "description": "Codes for tests or services that can be carried out by a designated individual, organization or healthcare service.  For laboratory, LOINC is  (preferred)[http://build.fhir.org/terminologies.html#preferred] and a valueset using LOINC Order codes is available [here](valueset-diagnostic-requests.html).",
              "valueSet": "http://hl7.org/fhir/ValueSet/procedure-code"
            }
          },
          {
            "id": "ServiceRequest.orderDetail",
            "path": "ServiceRequest.orderDetail",
            "short": "Additional order information",
            "definition": "Additional details and instructions about the how the services are to be delivered.   For example, and order for a urinary catheter may have an order detail for an external or indwelling catheter, or an order for a bandage may require additional instructions specifying how the bandage should be applied.",
            "comment": "For information from the medical record intended to support the delivery of the requested services, use the `supportingInformation` element.",
            "alias": [
              "detailed instructions"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "condition": [
              "prr-1"
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "OrderDetail"
                }
              ],
              "strength": "example",
              "description": "Codified order entry details which are based on order context.",
              "valueSet": "http://hl7.org/fhir/ValueSet/servicerequest-orderdetail"
            }
          },
          {
            "id": "ServiceRequest.quantity[x]",
            "path": "ServiceRequest.quantity[x]",
            "short": "Service amount",
            "definition": "An amount of service being requested which can be a quantity ( for example $1,500 home modification), a ratio ( for example, 20 half day visits per month), or a range (2.0 to 1.8 Gy per fraction).",
            "requirements": "When ordering a service the number of service items may need to be specified separately from the the service item.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity"
              },
              {
                "code": "Ratio"
              },
              {
                "code": "Range"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ServiceRequest.subject",
            "path": "ServiceRequest.subject",
            "short": "Individual or Entity the service is ordered for",
            "definition": "On whom or what the service is to be performed. This is usually a human patient, but can also be requested on animals, groups of humans or animals, devices such as dialysis machines, or even locations (typically for environmental scans).",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Group",
                  "http://hl7.org/fhir/StructureDefinition/Location",
                  "http://hl7.org/fhir/StructureDefinition/Device"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ServiceRequest.encounter",
            "path": "ServiceRequest.encounter",
            "short": "Encounter in which the request was created",
            "definition": "An encounter that provides additional information about the healthcare context in which this request is made.",
            "alias": [
              "context"
            ],
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
            "id": "ServiceRequest.occurrence[x]",
            "path": "ServiceRequest.occurrence[x]",
            "short": "When service should occur",
            "definition": "The date/time at which the requested service should occur.",
            "alias": [
              "schedule"
            ],
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
                "code": "Timing"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ServiceRequest.asNeeded[x]",
            "path": "ServiceRequest.asNeeded[x]",
            "short": "Preconditions for service",
            "definition": "If a CodeableConcept is present, it indicates the pre-condition for performing the service.  For example \"pain\", \"on flare-up\", etc.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              },
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ProcedureAsNeededReason"
                }
              ],
              "strength": "example",
              "description": "A coded concept identifying the pre-condition that should hold prior to performing a procedure.  For example \"pain\", \"on flare-up\", etc.",
              "valueSet": "http://hl7.org/fhir/ValueSet/medication-as-needed-reason"
            }
          },
          {
            "id": "ServiceRequest.authoredOn",
            "path": "ServiceRequest.authoredOn",
            "short": "Date request signed",
            "definition": "When the request transitioned to being actionable.",
            "alias": [
              "orderedOn"
            ],
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
            "id": "ServiceRequest.requester",
            "path": "ServiceRequest.requester",
            "short": "Who/what is requesting service",
            "definition": "The individual who initiated the request and has responsibility for its activation.",
            "comment": "This not the dispatcher, but rather who is the authorizer.  This element is not intended to handle delegation which would generally be managed through the Provenance resource.",
            "alias": [
              "author",
              "orderer"
            ],
            "min": 0,
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
            "id": "ServiceRequest.performerType",
            "path": "ServiceRequest.performerType",
            "short": "Performer role",
            "definition": "Desired type of performer for doing the requested service.",
            "comment": "This is a  role, not  a participation type.  In other words, does not describe the task but describes the capacity.  For example, “compounding pharmacy”, “psychiatrist” or “internal referral”.",
            "alias": [
              "specialty"
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
                  "valueString": "ServiceRequestParticipantRole"
                }
              ],
              "strength": "example",
              "description": "Indicates specific responsibility of an individual within the care team, such as \"Primary physician\", \"Team coordinator\", \"Caregiver\", etc.",
              "valueSet": "http://hl7.org/fhir/ValueSet/participant-role"
            }
          },
          {
            "id": "ServiceRequest.performer",
            "path": "ServiceRequest.performer",
            "short": "Requested performer",
            "definition": "The desired performer for doing the requested service.  For example, the surgeon, dermatopathologist, endoscopist, etc.",
            "comment": "If multiple performers are present, it is interpreted as a list of *alternative* performers without any preference regardless of order.  If order of preference is needed use the [request-performerOrder extension](extension-request-performerorder.html).  Use CareTeam to represent a group of performers (for example, Practitioner A *and* Practitioner B).",
            "alias": [
              "request recipient"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/CareTeam",
                  "http://hl7.org/fhir/StructureDefinition/HealthcareService",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ServiceRequest.locationCode",
            "path": "ServiceRequest.locationCode",
            "short": "Requested location",
            "definition": "The preferred location(s) where the procedure should actually happen in coded or free text form. E.g. at home or nursing day care center.",
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
                  "valueString": "ServiceRequestLocation"
                }
              ],
              "strength": "example",
              "description": "A location type where services are delivered.",
              "valueSet": "http://terminology.hl7.org/ValueSet/v3-ServiceDeliveryLocationRoleType"
            }
          },
          {
            "id": "ServiceRequest.locationReference",
            "path": "ServiceRequest.locationReference",
            "short": "Requested location",
            "definition": "A reference to the the preferred location(s) where the procedure should actually happen. E.g. at home or nursing day care center.",
            "min": 0,
            "max": "*",
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
            "id": "ServiceRequest.reasonCode",
            "path": "ServiceRequest.reasonCode",
            "short": "Explanation/Justification for procedure or service",
            "definition": "An explanation or justification for why this service is being requested in coded or textual form.   This is often for billing purposes.  May relate to the resources referred to in `supportingInfo`.",
            "comment": "This element represents why the referral is being made and may be used to decide how the service will be performed, or even if it will be performed at all.   Use `CodeableConcept.text` element if the data is free (uncoded) text as shown in the [CT Scan example](servicerequest-example-di.html).",
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
                  "valueString": "ServiceRequestReason"
                }
              ],
              "strength": "example",
              "description": "Diagnosis or problem codes justifying the reason for requesting the service investigation.",
              "valueSet": "http://hl7.org/fhir/ValueSet/procedure-reason"
            }
          },
          {
            "id": "ServiceRequest.reasonReference",
            "path": "ServiceRequest.reasonReference",
            "short": "Explanation/Justification for service or service",
            "definition": "Indicates another resource that provides a justification for why this service is being requested.   May relate to the resources referred to in `supportingInfo`.",
            "comment": "This element represents why the referral is being made and may be used to decide how the service will be performed, or even if it will be performed at all.    To be as specific as possible,  a reference to  *Observation* or *Condition* should be used if available.  Otherwise when referencing  *DiagnosticReport*  it should contain a finding  in `DiagnosticReport.conclusion` and/or `DiagnosticReport.conclusionCode`.   When using a reference to *DocumentReference*, the target document should contain clear findings language providing the relevant reason for this service request.  Use  the CodeableConcept text element in `ServiceRequest.reasonCode` if the data is free (uncoded) text as shown in the [CT Scan example](servicerequest-example-di.html).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Condition",
                  "http://hl7.org/fhir/StructureDefinition/Observation",
                  "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",
                  "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ServiceRequest.insurance",
            "path": "ServiceRequest.insurance",
            "short": "Associated insurance coverage",
            "definition": "Insurance plans, coverage extensions, pre-authorizations and/or pre-determinations that may be needed for delivering the requested service.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Coverage",
                  "http://hl7.org/fhir/StructureDefinition/ClaimResponse"
                ]
              }
            ]
          },
          {
            "id": "ServiceRequest.supportingInfo",
            "path": "ServiceRequest.supportingInfo",
            "short": "Additional clinical information",
            "definition": "Additional clinical information about the patient or specimen that may influence the services or their interpretations.     This information includes diagnosis, clinical findings and other observations.  In laboratory ordering these are typically referred to as \"ask at order entry questions (AOEs)\".  This includes observations explicitly requested by the producer (filler) to provide context or supporting information needed to complete the order. For example,  reporting the amount of inspired oxygen for blood gas measurements.",
            "comment": "To represent information about how the services are to be delivered use the `instructions` element.",
            "alias": [
              "Ask at order entry question",
              "AOE"
            ],
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
            "id": "ServiceRequest.specimen",
            "path": "ServiceRequest.specimen",
            "short": "Procedure Samples",
            "definition": "One or more specimens that the laboratory procedure will use.",
            "comment": "Many diagnostic procedures need a specimen, but the request itself is not actually about the specimen. This element is for when the diagnostic is requested on already existing specimens and the request points to the specimen it applies to.    Conversely, if the request is entered first with an unknown specimen, then the [Specimen](specimen.html) resource points to the ServiceRequest.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Specimen"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ServiceRequest.bodySite",
            "path": "ServiceRequest.bodySite",
            "short": "Location on Body",
            "definition": "Anatomic location where the procedure should be performed. This is the target site.",
            "comment": "Only used if not implicit in the code found in ServiceRequest.code.  If the use case requires BodySite to be handled as a separate resource instead of an inline coded element (e.g. to identify and track separately)  then use the standard extension [procedure-targetBodyStructure](extension-procedure-targetbodystructure.html).",
            "requirements": "Knowing where the procedure is performed is important for tracking if multiple sites are possible.",
            "alias": [
              "location"
            ],
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
            "id": "ServiceRequest.note",
            "path": "ServiceRequest.note",
            "short": "Comments",
            "definition": "Any other notes and comments made about the service request. For example, internal billing notes.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Annotation"
              }
            ]
          },
          {
            "id": "ServiceRequest.patientInstruction",
            "path": "ServiceRequest.patientInstruction",
            "short": "Patient or consumer-oriented instructions",
            "definition": "Instructions in terms that are understood by the patient or consumer.",
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
            "id": "ServiceRequest.relevantHistory",
            "path": "ServiceRequest.relevantHistory",
            "short": "Request provenance",
            "definition": "Key events in the history of the request.",
            "comment": "This might not include provenances for all versions of the request – only those deemed “relevant” or important.\rThis SHALL NOT include the Provenance associated with this current version of the resource.  (If that provenance is deemed to be a “relevant” change, it will need to be added as part of a later update.  Until then, it can be queried directly as the Provenance that points to this version using _revinclude\rAll Provenances should have some historical version of this Request as their subject.",
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
    #endregion                                                                                                                              // MakerGen.cs:463
    /// <summary>
    /// Fhir resource 'ServiceRequest'
    /// </summary>
    // 0. ServiceRequest
    public class ServiceRequest : FhirKhit.Maker.Common.Resource.ResourceBase                                                               // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class ServiceRequest_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                  // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 1. ServiceRequest.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:236
            // 2. ServiceRequest.instantiatesCanonical
            public ElementDefinitionInfo InstantiatesCanonical;                                                                             // MakerGen.cs:236
            // 3. ServiceRequest.instantiatesUri
            public ElementDefinitionInfo InstantiatesUri;                                                                                   // MakerGen.cs:236
            // 4. ServiceRequest.basedOn
            public ElementDefinitionInfo BasedOn;                                                                                           // MakerGen.cs:236
            // 5. ServiceRequest.replaces
            public ElementDefinitionInfo Replaces;                                                                                          // MakerGen.cs:236
            // 6. ServiceRequest.requisition
            public ElementDefinitionInfo Requisition;                                                                                       // MakerGen.cs:236
            // 7. ServiceRequest.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:236
            // 8. ServiceRequest.intent
            public ElementDefinitionInfo Intent;                                                                                            // MakerGen.cs:236
            // 9. ServiceRequest.category
            public ElementDefinitionInfo Category;                                                                                          // MakerGen.cs:236
            // 10. ServiceRequest.priority
            public ElementDefinitionInfo Priority;                                                                                          // MakerGen.cs:236
            // 11. ServiceRequest.doNotPerform
            public ElementDefinitionInfo DoNotPerform;                                                                                      // MakerGen.cs:236
            // 12. ServiceRequest.code
            public ElementDefinitionInfo Code;                                                                                              // MakerGen.cs:236
            // 13. ServiceRequest.orderDetail
            public ElementDefinitionInfo OrderDetail;                                                                                       // MakerGen.cs:236
            // 14. ServiceRequest.quantity[x]
            public ElementDefinitionInfo Quantity;                                                                                          // MakerGen.cs:236
            // 15. ServiceRequest.subject
            public ElementDefinitionInfo Subject;                                                                                           // MakerGen.cs:236
            // 16. ServiceRequest.encounter
            public ElementDefinitionInfo Encounter;                                                                                         // MakerGen.cs:236
            // 17. ServiceRequest.occurrence[x]
            public ElementDefinitionInfo Occurrence;                                                                                        // MakerGen.cs:236
            // 18. ServiceRequest.asNeeded[x]
            public ElementDefinitionInfo AsNeeded;                                                                                          // MakerGen.cs:236
            // 19. ServiceRequest.authoredOn
            public ElementDefinitionInfo AuthoredOn;                                                                                        // MakerGen.cs:236
            // 20. ServiceRequest.requester
            public ElementDefinitionInfo Requester;                                                                                         // MakerGen.cs:236
            // 21. ServiceRequest.performerType
            public ElementDefinitionInfo PerformerType;                                                                                     // MakerGen.cs:236
            // 22. ServiceRequest.performer
            public ElementDefinitionInfo Performer;                                                                                         // MakerGen.cs:236
            // 23. ServiceRequest.locationCode
            public ElementDefinitionInfo LocationCode;                                                                                      // MakerGen.cs:236
            // 24. ServiceRequest.locationReference
            public ElementDefinitionInfo LocationReference;                                                                                 // MakerGen.cs:236
            // 25. ServiceRequest.reasonCode
            public ElementDefinitionInfo ReasonCode;                                                                                        // MakerGen.cs:236
            // 26. ServiceRequest.reasonReference
            public ElementDefinitionInfo ReasonReference;                                                                                   // MakerGen.cs:236
            // 27. ServiceRequest.insurance
            public ElementDefinitionInfo Insurance;                                                                                         // MakerGen.cs:236
            // 28. ServiceRequest.supportingInfo
            public ElementDefinitionInfo SupportingInfo;                                                                                    // MakerGen.cs:236
            // 29. ServiceRequest.specimen
            public ElementDefinitionInfo Specimen;                                                                                          // MakerGen.cs:236
            // 30. ServiceRequest.bodySite
            public ElementDefinitionInfo BodySite;                                                                                          // MakerGen.cs:236
            // 31. ServiceRequest.note
            public ElementDefinitionInfo Note;                                                                                              // MakerGen.cs:236
            // 32. ServiceRequest.patientInstruction
            public ElementDefinitionInfo PatientInstruction;                                                                                // MakerGen.cs:236
            // 33. ServiceRequest.relevantHistory
            public ElementDefinitionInfo RelevantHistory;                                                                                   // MakerGen.cs:236
            public ServiceRequest_Elements()                                                                                                // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. ServiceRequest.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Identifier",                                                                                                // MakerGen.cs:255
                        Path= "ServiceRequest.identifier",                                                                                  // MakerGen.cs:256
                        Id = "ServiceRequest.identifier",                                                                                   // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 2. ServiceRequest.instantiatesCanonical
                    this.InstantiatesCanonical = new ElementDefinitionInfo                                                                  // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "InstantiatesCanonical",                                                                                     // MakerGen.cs:255
                        Path= "ServiceRequest.instantiatesCanonical",                                                                       // MakerGen.cs:256
                        Id = "ServiceRequest.instantiatesCanonical",                                                                        // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Canonical                                                                   // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                                TargetProfile = new String[]                                                                                // MakerGen.cs:302
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ActivityDefinition",                                           // MakerGen.cs:302
                                    "http://hl7.org/fhir/StructureDefinition/PlanDefinition"                                                // MakerGen.cs:302
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 3. ServiceRequest.instantiatesUri
                    this.InstantiatesUri = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "InstantiatesUri",                                                                                           // MakerGen.cs:255
                        Path= "ServiceRequest.instantiatesUri",                                                                             // MakerGen.cs:256
                        Id = "ServiceRequest.instantiatesUri",                                                                              // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Uri                                                                         // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 4. ServiceRequest.basedOn
                    this.BasedOn = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "BasedOn",                                                                                                   // MakerGen.cs:255
                        Path= "ServiceRequest.basedOn",                                                                                     // MakerGen.cs:256
                        Id = "ServiceRequest.basedOn",                                                                                      // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/CarePlan",                                                     // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/ServiceRequest",                                               // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/MedicationRequest"                                             // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 5. ServiceRequest.replaces
                    this.Replaces = new ElementDefinitionInfo                                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Replaces",                                                                                                  // MakerGen.cs:255
                        Path= "ServiceRequest.replaces",                                                                                    // MakerGen.cs:256
                        Id = "ServiceRequest.replaces",                                                                                     // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ServiceRequest"                                                // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 6. ServiceRequest.requisition
                    this.Requisition = new ElementDefinitionInfo                                                                            // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Requisition",                                                                                               // MakerGen.cs:255
                        Path= "ServiceRequest.requisition",                                                                                 // MakerGen.cs:256
                        Id = "ServiceRequest.requisition",                                                                                  // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 7. ServiceRequest.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Status",                                                                                                    // MakerGen.cs:255
                        Path= "ServiceRequest.status",                                                                                      // MakerGen.cs:256
                        Id = "ServiceRequest.status",                                                                                       // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
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
                    // 8. ServiceRequest.intent
                    this.Intent = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Intent",                                                                                                    // MakerGen.cs:255
                        Path= "ServiceRequest.intent",                                                                                      // MakerGen.cs:256
                        Id = "ServiceRequest.intent",                                                                                       // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
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
                    // 9. ServiceRequest.category
                    this.Category = new ElementDefinitionInfo                                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Category",                                                                                                  // MakerGen.cs:255
                        Path= "ServiceRequest.category",                                                                                    // MakerGen.cs:256
                        Id = "ServiceRequest.category",                                                                                     // MakerGen.cs:257
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
                    // 10. ServiceRequest.priority
                    this.Priority = new ElementDefinitionInfo                                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Priority",                                                                                                  // MakerGen.cs:255
                        Path= "ServiceRequest.priority",                                                                                    // MakerGen.cs:256
                        Id = "ServiceRequest.priority",                                                                                     // MakerGen.cs:257
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
                    // 11. ServiceRequest.doNotPerform
                    this.DoNotPerform = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "DoNotPerform",                                                                                              // MakerGen.cs:255
                        Path= "ServiceRequest.doNotPerform",                                                                                // MakerGen.cs:256
                        Id = "ServiceRequest.doNotPerform",                                                                                 // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 12. ServiceRequest.code
                    this.Code = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Code",                                                                                                      // MakerGen.cs:255
                        Path= "ServiceRequest.code",                                                                                        // MakerGen.cs:256
                        Id = "ServiceRequest.code",                                                                                         // MakerGen.cs:257
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
                    // 13. ServiceRequest.orderDetail
                    this.OrderDetail = new ElementDefinitionInfo                                                                            // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "OrderDetail",                                                                                               // MakerGen.cs:255
                        Path= "ServiceRequest.orderDetail",                                                                                 // MakerGen.cs:256
                        Id = "ServiceRequest.orderDetail",                                                                                  // MakerGen.cs:257
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
                    // 14. ServiceRequest.quantity[x]
                    this.Quantity = new ElementDefinitionInfo                                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Quantity",                                                                                                  // MakerGen.cs:255
                        Path= "ServiceRequest.quantity[x]",                                                                                 // MakerGen.cs:256
                        Id = "ServiceRequest.quantity[x]",                                                                                  // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Quantity                                                                      // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            },                                                                                                              // MakerGen.cs:359
                            new FhirKhit.Maker.Common.Complex.Ratio                                                                         // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            },                                                                                                              // MakerGen.cs:359
                            new FhirKhit.Maker.Common.Complex.Range                                                                         // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 15. ServiceRequest.subject
                    this.Subject = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Subject",                                                                                                   // MakerGen.cs:255
                        Path= "ServiceRequest.subject",                                                                                     // MakerGen.cs:256
                        Id = "ServiceRequest.subject",                                                                                      // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Group",                                                        // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Location",                                                     // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Device"                                                        // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 16. ServiceRequest.encounter
                    this.Encounter = new ElementDefinitionInfo                                                                              // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Encounter",                                                                                                 // MakerGen.cs:255
                        Path= "ServiceRequest.encounter",                                                                                   // MakerGen.cs:256
                        Id = "ServiceRequest.encounter",                                                                                    // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Encounter"                                                     // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 17. ServiceRequest.occurrence[x]
                    this.Occurrence = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Occurrence",                                                                                                // MakerGen.cs:255
                        Path= "ServiceRequest.occurrence[x]",                                                                               // MakerGen.cs:256
                        Id = "ServiceRequest.occurrence[x]",                                                                                // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            },                                                                                                              // MakerGen.cs:303
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            },                                                                                                              // MakerGen.cs:359
                            new FhirKhit.Maker.Common.Complex.Timing                                                                        // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 18. ServiceRequest.asNeeded[x]
                    this.AsNeeded = new ElementDefinitionInfo                                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "AsNeeded",                                                                                                  // MakerGen.cs:255
                        Path= "ServiceRequest.asNeeded[x]",                                                                                 // MakerGen.cs:256
                        Id = "ServiceRequest.asNeeded[x]",                                                                                  // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            },                                                                                                              // MakerGen.cs:303
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 19. ServiceRequest.authoredOn
                    this.AuthoredOn = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "AuthoredOn",                                                                                                // MakerGen.cs:255
                        Path= "ServiceRequest.authoredOn",                                                                                  // MakerGen.cs:256
                        Id = "ServiceRequest.authoredOn",                                                                                   // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 20. ServiceRequest.requester
                    this.Requester = new ElementDefinitionInfo                                                                              // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Requester",                                                                                                 // MakerGen.cs:255
                        Path= "ServiceRequest.requester",                                                                                   // MakerGen.cs:256
                        Id = "ServiceRequest.requester",                                                                                    // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Organization",                                                 // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                                // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Device"                                                        // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 21. ServiceRequest.performerType
                    this.PerformerType = new ElementDefinitionInfo                                                                          // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "PerformerType",                                                                                             // MakerGen.cs:255
                        Path= "ServiceRequest.performerType",                                                                               // MakerGen.cs:256
                        Id = "ServiceRequest.performerType",                                                                                // MakerGen.cs:257
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
                    // 22. ServiceRequest.performer
                    this.Performer = new ElementDefinitionInfo                                                                              // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Performer",                                                                                                 // MakerGen.cs:255
                        Path= "ServiceRequest.performer",                                                                                   // MakerGen.cs:256
                        Id = "ServiceRequest.performer",                                                                                    // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Organization",                                                 // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/CareTeam",                                                     // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/HealthcareService",                                            // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Device",                                                       // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                                 // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 23. ServiceRequest.locationCode
                    this.LocationCode = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "LocationCode",                                                                                              // MakerGen.cs:255
                        Path= "ServiceRequest.locationCode",                                                                                // MakerGen.cs:256
                        Id = "ServiceRequest.locationCode",                                                                                 // MakerGen.cs:257
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
                    // 24. ServiceRequest.locationReference
                    this.LocationReference = new ElementDefinitionInfo                                                                      // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "LocationReference",                                                                                         // MakerGen.cs:255
                        Path= "ServiceRequest.locationReference",                                                                           // MakerGen.cs:256
                        Id = "ServiceRequest.locationReference",                                                                            // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Location"                                                      // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 25. ServiceRequest.reasonCode
                    this.ReasonCode = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "ReasonCode",                                                                                                // MakerGen.cs:255
                        Path= "ServiceRequest.reasonCode",                                                                                  // MakerGen.cs:256
                        Id = "ServiceRequest.reasonCode",                                                                                   // MakerGen.cs:257
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
                    // 26. ServiceRequest.reasonReference
                    this.ReasonReference = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "ReasonReference",                                                                                           // MakerGen.cs:255
                        Path= "ServiceRequest.reasonReference",                                                                             // MakerGen.cs:256
                        Id = "ServiceRequest.reasonReference",                                                                              // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Condition",                                                    // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Observation",                                                  // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",                                             // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                             // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 27. ServiceRequest.insurance
                    this.Insurance = new ElementDefinitionInfo                                                                              // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Insurance",                                                                                                 // MakerGen.cs:255
                        Path= "ServiceRequest.insurance",                                                                                   // MakerGen.cs:256
                        Id = "ServiceRequest.insurance",                                                                                    // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Coverage",                                                     // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/ClaimResponse"                                                 // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 28. ServiceRequest.supportingInfo
                    this.SupportingInfo = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "SupportingInfo",                                                                                            // MakerGen.cs:255
                        Path= "ServiceRequest.supportingInfo",                                                                              // MakerGen.cs:256
                        Id = "ServiceRequest.supportingInfo",                                                                               // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Resource"                                                      // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 29. ServiceRequest.specimen
                    this.Specimen = new ElementDefinitionInfo                                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Specimen",                                                                                                  // MakerGen.cs:255
                        Path= "ServiceRequest.specimen",                                                                                    // MakerGen.cs:256
                        Id = "ServiceRequest.specimen",                                                                                     // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Specimen"                                                      // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 30. ServiceRequest.bodySite
                    this.BodySite = new ElementDefinitionInfo                                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "BodySite",                                                                                                  // MakerGen.cs:255
                        Path= "ServiceRequest.bodySite",                                                                                    // MakerGen.cs:256
                        Id = "ServiceRequest.bodySite",                                                                                     // MakerGen.cs:257
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
                    // 31. ServiceRequest.note
                    this.Note = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Note",                                                                                                      // MakerGen.cs:255
                        Path= "ServiceRequest.note",                                                                                        // MakerGen.cs:256
                        Id = "ServiceRequest.note",                                                                                         // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Annotation                                                                    // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 32. ServiceRequest.patientInstruction
                    this.PatientInstruction = new ElementDefinitionInfo                                                                     // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "PatientInstruction",                                                                                        // MakerGen.cs:255
                        Path= "ServiceRequest.patientInstruction",                                                                          // MakerGen.cs:256
                        Id = "ServiceRequest.patientInstruction",                                                                           // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 33. ServiceRequest.relevantHistory
                    this.RelevantHistory = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "RelevantHistory",                                                                                           // MakerGen.cs:255
                        Path= "ServiceRequest.relevantHistory",                                                                             // MakerGen.cs:256
                        Id = "ServiceRequest.relevantHistory",                                                                              // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Provenance"                                                    // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:429
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:240
                InstantiatesCanonical.Write(sDef);                                                                                          // MakerGen.cs:240
                InstantiatesUri.Write(sDef);                                                                                                // MakerGen.cs:240
                BasedOn.Write(sDef);                                                                                                        // MakerGen.cs:240
                Replaces.Write(sDef);                                                                                                       // MakerGen.cs:240
                Requisition.Write(sDef);                                                                                                    // MakerGen.cs:240
                Status.Write(sDef);                                                                                                         // MakerGen.cs:240
                Intent.Write(sDef);                                                                                                         // MakerGen.cs:240
                Category.Write(sDef);                                                                                                       // MakerGen.cs:240
                Priority.Write(sDef);                                                                                                       // MakerGen.cs:240
                DoNotPerform.Write(sDef);                                                                                                   // MakerGen.cs:240
                Code.Write(sDef);                                                                                                           // MakerGen.cs:240
                OrderDetail.Write(sDef);                                                                                                    // MakerGen.cs:240
                Quantity.Write(sDef);                                                                                                       // MakerGen.cs:240
                Subject.Write(sDef);                                                                                                        // MakerGen.cs:240
                Encounter.Write(sDef);                                                                                                      // MakerGen.cs:240
                Occurrence.Write(sDef);                                                                                                     // MakerGen.cs:240
                AsNeeded.Write(sDef);                                                                                                       // MakerGen.cs:240
                AuthoredOn.Write(sDef);                                                                                                     // MakerGen.cs:240
                Requester.Write(sDef);                                                                                                      // MakerGen.cs:240
                PerformerType.Write(sDef);                                                                                                  // MakerGen.cs:240
                Performer.Write(sDef);                                                                                                      // MakerGen.cs:240
                LocationCode.Write(sDef);                                                                                                   // MakerGen.cs:240
                LocationReference.Write(sDef);                                                                                              // MakerGen.cs:240
                ReasonCode.Write(sDef);                                                                                                     // MakerGen.cs:240
                ReasonReference.Write(sDef);                                                                                                // MakerGen.cs:240
                Insurance.Write(sDef);                                                                                                      // MakerGen.cs:240
                SupportingInfo.Write(sDef);                                                                                                 // MakerGen.cs:240
                Specimen.Write(sDef);                                                                                                       // MakerGen.cs:240
                BodySite.Write(sDef);                                                                                                       // MakerGen.cs:240
                Note.Write(sDef);                                                                                                           // MakerGen.cs:240
                PatientInstruction.Write(sDef);                                                                                             // MakerGen.cs:240
                RelevantHistory.Write(sDef);                                                                                                // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public ServiceRequest_Elements Elements { get; }                                                                                    // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public ServiceRequest()                                                                                                             // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new ServiceRequest_Elements();                                                                                  // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:468
