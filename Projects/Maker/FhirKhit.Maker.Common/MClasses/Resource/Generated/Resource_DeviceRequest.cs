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
      "id": "DeviceRequest",
      "url": "http://hl7.org/fhir/StructureDefinition/DeviceRequest",
      "version": "4.0.0",
      "name": "DeviceRequest",
      "status": "draft",
      "publisher": "Health Level Seven International (Orders and Observations)",
      "description": "Represents a request for a patient to employ a medical device. The device may be an implantable device, or an external assistive device, such as a walker.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "DeviceRequest",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "DeviceRequest",
            "path": "DeviceRequest",
            "short": "Medical device request",
            "definition": "Represents a request for a patient to employ a medical device. The device may be an implantable device, or an external assistive device, such as a walker.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "DeviceRequest.identifier",
            "path": "DeviceRequest.identifier",
            "short": "External Request identifier",
            "definition": "Identifiers assigned to this order by the orderer or by the receiver.",
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
            "id": "DeviceRequest.instantiatesCanonical",
            "path": "DeviceRequest.instantiatesCanonical",
            "short": "Instantiates FHIR protocol or definition",
            "definition": "The URL pointing to a FHIR-defined protocol, guideline, orderset or other definition that is adhered to in whole or in part by this DeviceRequest.",
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
            "id": "DeviceRequest.instantiatesUri",
            "path": "DeviceRequest.instantiatesUri",
            "short": "Instantiates external protocol or definition",
            "definition": "The URL pointing to an externally maintained protocol, guideline, orderset or other definition that is adhered to in whole or in part by this DeviceRequest.",
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
            "id": "DeviceRequest.basedOn",
            "path": "DeviceRequest.basedOn",
            "short": "What request fulfills",
            "definition": "Plan/proposal/order fulfilled by this request.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "DeviceRequest.priorRequest",
            "path": "DeviceRequest.priorRequest",
            "short": "What request replaces",
            "definition": "The request takes the place of the referenced completed or terminated request(s).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "DeviceRequest.groupIdentifier",
            "path": "DeviceRequest.groupIdentifier",
            "short": "Identifier of composite request",
            "definition": "Composite request this is part of.",
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
            "id": "DeviceRequest.status",
            "path": "DeviceRequest.status",
            "short": "draft | active | suspended | completed | entered-in-error | cancelled",
            "definition": "The status of the request.",
            "comment": "This element is labeled as a modifier because the status contains the codes cancelled and entered-in-error that mark the request as not currently valid.",
            "min": 0,
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
                  "valueString": "DeviceRequestStatus"
                }
              ],
              "strength": "required",
              "description": "Codes representing the status of the request.",
              "valueSet": "http://hl7.org/fhir/ValueSet/request-status|4.0.0"
            }
          },
          {
            "id": "DeviceRequest.intent",
            "path": "DeviceRequest.intent",
            "short": "proposal | plan | original-order | encoded | reflex-order",
            "definition": "Whether the request is a proposal, plan, an original order or a reflex order.",
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
                  "valueString": "RequestIntent"
                }
              ],
              "strength": "required",
              "description": "The kind of diagnostic request.",
              "valueSet": "http://hl7.org/fhir/ValueSet/request-intent|4.0.0"
            }
          },
          {
            "id": "DeviceRequest.priority",
            "path": "DeviceRequest.priority",
            "short": "Indicates how quickly the {{title}} should be addressed with respect to other requests",
            "definition": "Indicates how quickly the {{title}} should be addressed with respect to other requests.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "meaningWhenMissing": "If missing, normal priority",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "RequestPriority"
                }
              ],
              "strength": "required",
              "description": "Identifies the level of importance to be assigned to actioning the request.",
              "valueSet": "http://hl7.org/fhir/ValueSet/request-priority|4.0.0"
            }
          },
          {
            "id": "DeviceRequest.code[x]",
            "path": "DeviceRequest.code[x]",
            "short": "Device requested",
            "definition": "The details of the device to be used.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Device"
                ]
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
                  "valueString": "DeviceRequestCode"
                }
              ],
              "strength": "example",
              "description": "Codes for devices that can be requested.",
              "valueSet": "http://hl7.org/fhir/ValueSet/device-kind"
            }
          },
          {
            "id": "DeviceRequest.parameter",
            "path": "DeviceRequest.parameter",
            "short": "Device details",
            "definition": "Specific parameters for the ordered item.  For example, the prism value for lenses.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "DeviceRequest.parameter.code",
            "path": "DeviceRequest.parameter.code",
            "short": "Device detail",
            "definition": "A code or string that identifies the device detail being asserted.",
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
                  "valueString": "ParameterCode"
                }
              ],
              "strength": "example",
              "description": "A code that identifies the device detail."
            }
          },
          {
            "id": "DeviceRequest.parameter.value[x]",
            "path": "DeviceRequest.parameter.value[x]",
            "short": "Value of detail",
            "definition": "The value of the device detail.",
            "comment": "Range means device should have a value that falls somewhere within the specified range.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              },
              {
                "code": "Quantity"
              },
              {
                "code": "Range"
              },
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "DeviceRequest.subject",
            "path": "DeviceRequest.subject",
            "short": "Focus of request",
            "definition": "The patient who will use the device.",
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
            "id": "DeviceRequest.encounter",
            "path": "DeviceRequest.encounter",
            "short": "Encounter motivating request",
            "definition": "An encounter that provides additional context in which this request is made.",
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
            "id": "DeviceRequest.occurrence[x]",
            "path": "DeviceRequest.occurrence[x]",
            "short": "Desired time or schedule for use",
            "definition": "The timing schedule for the use of the device. The Schedule data type allows many different expressions, for example. \"Every 8 hours\"; \"Three times a day\"; \"1/2 an hour before breakfast for 10 days from 23-Dec 2011:\"; \"15 Oct 2013, 17 Oct 2013 and 1 Nov 2013\".",
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
            "id": "DeviceRequest.authoredOn",
            "path": "DeviceRequest.authoredOn",
            "short": "When recorded",
            "definition": "When the request transitioned to being actionable.",
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
            "id": "DeviceRequest.requester",
            "path": "DeviceRequest.requester",
            "short": "Who/what is requesting diagnostics",
            "definition": "The individual who initiated the request and has responsibility for its activation.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "DeviceRequest.performerType",
            "path": "DeviceRequest.performerType",
            "short": "Filler role",
            "definition": "Desired type of performer for doing the diagnostic testing.",
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
                  "valueString": "DeviceRequestParticipantRole"
                }
              ],
              "strength": "example",
              "description": "Indicates specific responsibility of an individual within the care team, such as \"Primary physician\", \"Team coordinator\", \"Caregiver\", etc.",
              "valueSet": "http://hl7.org/fhir/ValueSet/participant-role"
            }
          },
          {
            "id": "DeviceRequest.performer",
            "path": "DeviceRequest.performer",
            "short": "Requested Filler",
            "definition": "The desired performer for doing the diagnostic testing.",
            "min": 0,
            "max": "1",
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
            "id": "DeviceRequest.reasonCode",
            "path": "DeviceRequest.reasonCode",
            "short": "Coded Reason for request",
            "definition": "Reason or justification for the use of this device.",
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
                  "valueString": "DeviceRequestReason"
                }
              ],
              "strength": "example",
              "description": "Diagnosis or problem codes justifying the reason for requesting the device.",
              "valueSet": "http://hl7.org/fhir/ValueSet/condition-code"
            }
          },
          {
            "id": "DeviceRequest.reasonReference",
            "path": "DeviceRequest.reasonReference",
            "short": "Linked Reason for request",
            "definition": "Reason or justification for the use of this device.",
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
            "id": "DeviceRequest.insurance",
            "path": "DeviceRequest.insurance",
            "short": "Associated insurance coverage",
            "definition": "Insurance plans, coverage extensions, pre-authorizations and/or pre-determinations that may be required for delivering the requested service.",
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
            "id": "DeviceRequest.supportingInfo",
            "path": "DeviceRequest.supportingInfo",
            "short": "Additional clinical information",
            "definition": "Additional clinical information about the patient that may influence the request fulfilment.  For example, this may include where on the subject's body the device will be used (i.e. the target site).",
            "requirements": "Knowing where the device is targeted is important for tracking if multiple sites are possible.",
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
            "id": "DeviceRequest.note",
            "path": "DeviceRequest.note",
            "short": "Notes or comments",
            "definition": "Details about this request that were not represented at all or sufficiently in one of the attributes provided in a class. These may include for example a comment, an instruction, or a note associated with the statement.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Annotation"
              }
            ]
          },
          {
            "id": "DeviceRequest.relevantHistory",
            "path": "DeviceRequest.relevantHistory",
            "short": "Request provenance",
            "definition": "Key events in the history of the request.",
            "comment": "This might not include provenances for all versions of the request - only those deemed \"relevant\" or important.\rThis SHALL NOT include the Provenance associated with this current version of the resource.  (If that provenance is deemed to be a \"relevant\" change, it will need to be added as part of a later update.  Until then, it can be queried directly as the Provenance that points to this version using _revinclude\rAll Provenances should have some historical version of this Request as their subject.",
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
    /// Fhir resource 'DeviceRequest'
    /// </summary>
    // 0. DeviceRequest
    public partial class Resource_DeviceRequest : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 11. DeviceRequest.parameter
        public partial class Type_Parameter : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 12. DeviceRequest.parameter.code
            public ElementDefinitionInfo Element_Code;
            // 13. DeviceRequest.parameter.value[x]
            public ElementDefinitionInfo Element_Value;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "DeviceRequest.parameter",
                    ElementId = "DeviceRequest.parameter"
                });
                Element_Code.Write(sDef);
                Element_Value.Write(sDef);
            }
            
            public Type_Parameter()
            {
                {
                    // 12. DeviceRequest.parameter.code
                    this.Element_Code = new ElementDefinitionInfo
                    {
                        Name = "Element_Code",
                        Path= "DeviceRequest.parameter.code",
                        Id = "DeviceRequest.parameter.code",
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
                    // 13. DeviceRequest.parameter.value[x]
                    this.Element_Value = new ElementDefinitionInfo
                    {
                        Name = "Element_Value",
                        Path= "DeviceRequest.parameter.value[x]",
                        Id = "DeviceRequest.parameter.value[x]",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Quantity
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Range
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_Boolean
                            {
                            }
                        }
                    };
                }
            }
        }
        // 1. DeviceRequest.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. DeviceRequest.instantiatesCanonical
        public ElementDefinitionInfo Element_InstantiatesCanonical;
        // 3. DeviceRequest.instantiatesUri
        public ElementDefinitionInfo Element_InstantiatesUri;
        // 4. DeviceRequest.basedOn
        public ElementDefinitionInfo Element_BasedOn;
        // 5. DeviceRequest.priorRequest
        public ElementDefinitionInfo Element_PriorRequest;
        // 6. DeviceRequest.groupIdentifier
        public ElementDefinitionInfo Element_GroupIdentifier;
        // 7. DeviceRequest.status
        public ElementDefinitionInfo Element_Status;
        // 8. DeviceRequest.intent
        public ElementDefinitionInfo Element_Intent;
        // 9. DeviceRequest.priority
        public ElementDefinitionInfo Element_Priority;
        // 10. DeviceRequest.code[x]
        public ElementDefinitionInfo Element_Code;
        // 11. DeviceRequest.parameter
        public ElementDefinitionInfo Element_Parameter;
        // 14. DeviceRequest.subject
        public ElementDefinitionInfo Element_Subject;
        // 15. DeviceRequest.encounter
        public ElementDefinitionInfo Element_Encounter;
        // 16. DeviceRequest.occurrence[x]
        public ElementDefinitionInfo Element_Occurrence;
        // 17. DeviceRequest.authoredOn
        public ElementDefinitionInfo Element_AuthoredOn;
        // 18. DeviceRequest.requester
        public ElementDefinitionInfo Element_Requester;
        // 19. DeviceRequest.performerType
        public ElementDefinitionInfo Element_PerformerType;
        // 20. DeviceRequest.performer
        public ElementDefinitionInfo Element_Performer;
        // 21. DeviceRequest.reasonCode
        public ElementDefinitionInfo Element_ReasonCode;
        // 22. DeviceRequest.reasonReference
        public ElementDefinitionInfo Element_ReasonReference;
        // 23. DeviceRequest.insurance
        public ElementDefinitionInfo Element_Insurance;
        // 24. DeviceRequest.supportingInfo
        public ElementDefinitionInfo Element_SupportingInfo;
        // 25. DeviceRequest.note
        public ElementDefinitionInfo Element_Note;
        // 26. DeviceRequest.relevantHistory
        public ElementDefinitionInfo Element_RelevantHistory;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "DeviceRequest",
                ElementId = "DeviceRequest"
            });
            Element_Identifier.Write(sDef);
            Element_InstantiatesCanonical.Write(sDef);
            Element_InstantiatesUri.Write(sDef);
            Element_BasedOn.Write(sDef);
            Element_PriorRequest.Write(sDef);
            Element_GroupIdentifier.Write(sDef);
            Element_Status.Write(sDef);
            Element_Intent.Write(sDef);
            Element_Priority.Write(sDef);
            Element_Code.Write(sDef);
            Element_Parameter.Write(sDef);
            Element_Subject.Write(sDef);
            Element_Encounter.Write(sDef);
            Element_Occurrence.Write(sDef);
            Element_AuthoredOn.Write(sDef);
            Element_Requester.Write(sDef);
            Element_PerformerType.Write(sDef);
            Element_Performer.Write(sDef);
            Element_ReasonCode.Write(sDef);
            Element_ReasonReference.Write(sDef);
            Element_Insurance.Write(sDef);
            Element_SupportingInfo.Write(sDef);
            Element_Note.Write(sDef);
            Element_RelevantHistory.Write(sDef);
        }
        
        public Resource_DeviceRequest()
        {
            {
                // 1. DeviceRequest.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "DeviceRequest.identifier",
                    Id = "DeviceRequest.identifier",
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
                // 2. DeviceRequest.instantiatesCanonical
                this.Element_InstantiatesCanonical = new ElementDefinitionInfo
                {
                    Name = "Element_InstantiatesCanonical",
                    Path= "DeviceRequest.instantiatesCanonical",
                    Id = "DeviceRequest.instantiatesCanonical",
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
                // 3. DeviceRequest.instantiatesUri
                this.Element_InstantiatesUri = new ElementDefinitionInfo
                {
                    Name = "Element_InstantiatesUri",
                    Path= "DeviceRequest.instantiatesUri",
                    Id = "DeviceRequest.instantiatesUri",
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
                // 4. DeviceRequest.basedOn
                this.Element_BasedOn = new ElementDefinitionInfo
                {
                    Name = "Element_BasedOn",
                    Path= "DeviceRequest.basedOn",
                    Id = "DeviceRequest.basedOn",
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
                // 5. DeviceRequest.priorRequest
                this.Element_PriorRequest = new ElementDefinitionInfo
                {
                    Name = "Element_PriorRequest",
                    Path= "DeviceRequest.priorRequest",
                    Id = "DeviceRequest.priorRequest",
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
                // 6. DeviceRequest.groupIdentifier
                this.Element_GroupIdentifier = new ElementDefinitionInfo
                {
                    Name = "Element_GroupIdentifier",
                    Path= "DeviceRequest.groupIdentifier",
                    Id = "DeviceRequest.groupIdentifier",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Identifier
                        {
                        }
                    }
                };
            }
            {
                // 7. DeviceRequest.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "DeviceRequest.status",
                    Id = "DeviceRequest.status",
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
                // 8. DeviceRequest.intent
                this.Element_Intent = new ElementDefinitionInfo
                {
                    Name = "Element_Intent",
                    Path= "DeviceRequest.intent",
                    Id = "DeviceRequest.intent",
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
                // 9. DeviceRequest.priority
                this.Element_Priority = new ElementDefinitionInfo
                {
                    Name = "Element_Priority",
                    Path= "DeviceRequest.priority",
                    Id = "DeviceRequest.priority",
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
                // 10. DeviceRequest.code[x]
                this.Element_Code = new ElementDefinitionInfo
                {
                    Name = "Element_Code",
                    Path= "DeviceRequest.code[x]",
                    Id = "DeviceRequest.code[x]",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Device"
                            }
                        },
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                        {
                        }
                    }
                };
            }
            {
                // 11. DeviceRequest.parameter
                this.Element_Parameter = new ElementDefinitionInfo
                {
                    Name = "Element_Parameter",
                    Path= "DeviceRequest.parameter",
                    Id = "DeviceRequest.parameter",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Parameter
                        {
                        }
                    }
                };
            }
            {
                // 14. DeviceRequest.subject
                this.Element_Subject = new ElementDefinitionInfo
                {
                    Name = "Element_Subject",
                    Path= "DeviceRequest.subject",
                    Id = "DeviceRequest.subject",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/Group",
                                "http://hl7.org/fhir/StructureDefinition/Location",
                                "http://hl7.org/fhir/StructureDefinition/Device"
                            }
                        }
                    }
                };
            }
            {
                // 15. DeviceRequest.encounter
                this.Element_Encounter = new ElementDefinitionInfo
                {
                    Name = "Element_Encounter",
                    Path= "DeviceRequest.encounter",
                    Id = "DeviceRequest.encounter",
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
                // 16. DeviceRequest.occurrence[x]
                this.Element_Occurrence = new ElementDefinitionInfo
                {
                    Name = "Element_Occurrence",
                    Path= "DeviceRequest.occurrence[x]",
                    Id = "DeviceRequest.occurrence[x]",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Period
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Timing
                        {
                        }
                    }
                };
            }
            {
                // 17. DeviceRequest.authoredOn
                this.Element_AuthoredOn = new ElementDefinitionInfo
                {
                    Name = "Element_AuthoredOn",
                    Path= "DeviceRequest.authoredOn",
                    Id = "DeviceRequest.authoredOn",
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
                // 18. DeviceRequest.requester
                this.Element_Requester = new ElementDefinitionInfo
                {
                    Name = "Element_Requester",
                    Path= "DeviceRequest.requester",
                    Id = "DeviceRequest.requester",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Device",
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                "http://hl7.org/fhir/StructureDefinition/Organization"
                            }
                        }
                    }
                };
            }
            {
                // 19. DeviceRequest.performerType
                this.Element_PerformerType = new ElementDefinitionInfo
                {
                    Name = "Element_PerformerType",
                    Path= "DeviceRequest.performerType",
                    Id = "DeviceRequest.performerType",
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
                // 20. DeviceRequest.performer
                this.Element_Performer = new ElementDefinitionInfo
                {
                    Name = "Element_Performer",
                    Path= "DeviceRequest.performer",
                    Id = "DeviceRequest.performer",
                    Min = 0,
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
                                "http://hl7.org/fhir/StructureDefinition/CareTeam",
                                "http://hl7.org/fhir/StructureDefinition/HealthcareService",
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/Device",
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                            }
                        }
                    }
                };
            }
            {
                // 21. DeviceRequest.reasonCode
                this.Element_ReasonCode = new ElementDefinitionInfo
                {
                    Name = "Element_ReasonCode",
                    Path= "DeviceRequest.reasonCode",
                    Id = "DeviceRequest.reasonCode",
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
                // 22. DeviceRequest.reasonReference
                this.Element_ReasonReference = new ElementDefinitionInfo
                {
                    Name = "Element_ReasonReference",
                    Path= "DeviceRequest.reasonReference",
                    Id = "DeviceRequest.reasonReference",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Condition",
                                "http://hl7.org/fhir/StructureDefinition/Observation",
                                "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",
                                "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                            }
                        }
                    }
                };
            }
            {
                // 23. DeviceRequest.insurance
                this.Element_Insurance = new ElementDefinitionInfo
                {
                    Name = "Element_Insurance",
                    Path= "DeviceRequest.insurance",
                    Id = "DeviceRequest.insurance",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Coverage",
                                "http://hl7.org/fhir/StructureDefinition/ClaimResponse"
                            }
                        }
                    }
                };
            }
            {
                // 24. DeviceRequest.supportingInfo
                this.Element_SupportingInfo = new ElementDefinitionInfo
                {
                    Name = "Element_SupportingInfo",
                    Path= "DeviceRequest.supportingInfo",
                    Id = "DeviceRequest.supportingInfo",
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
                // 25. DeviceRequest.note
                this.Element_Note = new ElementDefinitionInfo
                {
                    Name = "Element_Note",
                    Path= "DeviceRequest.note",
                    Id = "DeviceRequest.note",
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
                // 26. DeviceRequest.relevantHistory
                this.Element_RelevantHistory = new ElementDefinitionInfo
                {
                    Name = "Element_RelevantHistory",
                    Path= "DeviceRequest.relevantHistory",
                    Id = "DeviceRequest.relevantHistory",
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
            this.Name = "DeviceRequest";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/DeviceRequest";
        }
    }
}
