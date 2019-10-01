using System;                                                                                                                               // MakerGen.cs:449
using System.Diagnostics;                                                                                                                   // MakerGen.cs:450
using System.IO;                                                                                                                            // MakerGen.cs:451
using System.Linq;                                                                                                                          // MakerGen.cs:452
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:453
                                                                                                                                            // MakerGen.cs:454
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:455
{                                                                                                                                           // MakerGen.cs:456
    #region Json                                                                                                                            // MakerGen.cs:457
    #if NEVER                                                                                                                               // MakerGen.cs:458
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
    #endregion                                                                                                                              // MakerGen.cs:461
    /// <summary>
    /// Fhir resource 'DeviceRequest'
    /// </summary>
    // 0. DeviceRequest
    public class DeviceRequest : FhirKhit.Maker.Common.Resource.ResourceBase                                                                // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        public class DeviceRequest_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                   // MakerGen.cs:385
        {                                                                                                                                   // MakerGen.cs:386
            // 11. DeviceRequest.parameter
            public class Type_Parameter : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_Parameter_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                          // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 12. DeviceRequest.parameter.code
                    public ElementDefinitionInfo Code;                                                                                      // MakerGen.cs:216
                    // 13. DeviceRequest.parameter.value[x]
                    public ElementDefinitionInfo Value;                                                                                     // MakerGen.cs:216
                    public Type_Parameter_Elements()                                                                                        // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 12. DeviceRequest.parameter.code
                            this.Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Code",                                                                                              // MakerGen.cs:235
                                Path= "DeviceRequest.parameter.code",                                                                       // MakerGen.cs:236
                                Id = "DeviceRequest.parameter.code",                                                                        // MakerGen.cs:237
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
                            // 13. DeviceRequest.parameter.value[x]
                            this.Value = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Value",                                                                                             // MakerGen.cs:235
                                Path= "DeviceRequest.parameter.value[x]",                                                                   // MakerGen.cs:236
                                Id = "DeviceRequest.parameter.value[x]",                                                                    // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    },                                                                                                      // MakerGen.cs:319
                                    new FhirKhit.Maker.Common.Complex.Quantity                                                              // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    },                                                                                                      // MakerGen.cs:360
                                    new FhirKhit.Maker.Common.Complex.Range                                                                 // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    },                                                                                                      // MakerGen.cs:360
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Code.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Value.Write(sDef);                                                                                                  // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_Parameter_Elements Elements { get; }                                                                            // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_Parameter()                                                                                                     // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_Parameter_Elements();                                                                          // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 1. DeviceRequest.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 2. DeviceRequest.instantiatesCanonical
            public ElementDefinitionInfo InstantiatesCanonical;                                                                             // MakerGen.cs:216
            // 3. DeviceRequest.instantiatesUri
            public ElementDefinitionInfo InstantiatesUri;                                                                                   // MakerGen.cs:216
            // 4. DeviceRequest.basedOn
            public ElementDefinitionInfo BasedOn;                                                                                           // MakerGen.cs:216
            // 5. DeviceRequest.priorRequest
            public ElementDefinitionInfo PriorRequest;                                                                                      // MakerGen.cs:216
            // 6. DeviceRequest.groupIdentifier
            public ElementDefinitionInfo GroupIdentifier;                                                                                   // MakerGen.cs:216
            // 7. DeviceRequest.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:216
            // 8. DeviceRequest.intent
            public ElementDefinitionInfo Intent;                                                                                            // MakerGen.cs:216
            // 9. DeviceRequest.priority
            public ElementDefinitionInfo Priority;                                                                                          // MakerGen.cs:216
            // 10. DeviceRequest.code[x]
            public ElementDefinitionInfo Code;                                                                                              // MakerGen.cs:216
            // 11. DeviceRequest.parameter
            public ElementDefinitionInfo Parameter;                                                                                         // MakerGen.cs:216
            // 14. DeviceRequest.subject
            public ElementDefinitionInfo Subject;                                                                                           // MakerGen.cs:216
            // 15. DeviceRequest.encounter
            public ElementDefinitionInfo Encounter;                                                                                         // MakerGen.cs:216
            // 16. DeviceRequest.occurrence[x]
            public ElementDefinitionInfo Occurrence;                                                                                        // MakerGen.cs:216
            // 17. DeviceRequest.authoredOn
            public ElementDefinitionInfo AuthoredOn;                                                                                        // MakerGen.cs:216
            // 18. DeviceRequest.requester
            public ElementDefinitionInfo Requester;                                                                                         // MakerGen.cs:216
            // 19. DeviceRequest.performerType
            public ElementDefinitionInfo PerformerType;                                                                                     // MakerGen.cs:216
            // 20. DeviceRequest.performer
            public ElementDefinitionInfo Performer;                                                                                         // MakerGen.cs:216
            // 21. DeviceRequest.reasonCode
            public ElementDefinitionInfo ReasonCode;                                                                                        // MakerGen.cs:216
            // 22. DeviceRequest.reasonReference
            public ElementDefinitionInfo ReasonReference;                                                                                   // MakerGen.cs:216
            // 23. DeviceRequest.insurance
            public ElementDefinitionInfo Insurance;                                                                                         // MakerGen.cs:216
            // 24. DeviceRequest.supportingInfo
            public ElementDefinitionInfo SupportingInfo;                                                                                    // MakerGen.cs:216
            // 25. DeviceRequest.note
            public ElementDefinitionInfo Note;                                                                                              // MakerGen.cs:216
            // 26. DeviceRequest.relevantHistory
            public ElementDefinitionInfo RelevantHistory;                                                                                   // MakerGen.cs:216
            public DeviceRequest_Elements()                                                                                                 // MakerGen.cs:407
            {                                                                                                                               // MakerGen.cs:408
                {                                                                                                                           // MakerGen.cs:231
                    // 1. DeviceRequest.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "DeviceRequest.identifier",                                                                                   // MakerGen.cs:236
                        Id = "DeviceRequest.identifier",                                                                                    // MakerGen.cs:237
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
                    // 2. DeviceRequest.instantiatesCanonical
                    this.InstantiatesCanonical = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "InstantiatesCanonical",                                                                                     // MakerGen.cs:235
                        Path= "DeviceRequest.instantiatesCanonical",                                                                        // MakerGen.cs:236
                        Id = "DeviceRequest.instantiatesCanonical",                                                                         // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Canonical                                                                   // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                                TargetProfile = new String[]                                                                                // MakerGen.cs:303
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ActivityDefinition",                                           // MakerGen.cs:303
                                    "http://hl7.org/fhir/StructureDefinition/PlanDefinition"                                                // MakerGen.cs:303
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 3. DeviceRequest.instantiatesUri
                    this.InstantiatesUri = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "InstantiatesUri",                                                                                           // MakerGen.cs:235
                        Path= "DeviceRequest.instantiatesUri",                                                                              // MakerGen.cs:236
                        Id = "DeviceRequest.instantiatesUri",                                                                               // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Uri                                                                         // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 4. DeviceRequest.basedOn
                    this.BasedOn = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "BasedOn",                                                                                                   // MakerGen.cs:235
                        Path= "DeviceRequest.basedOn",                                                                                      // MakerGen.cs:236
                        Id = "DeviceRequest.basedOn",                                                                                       // MakerGen.cs:237
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
                    // 5. DeviceRequest.priorRequest
                    this.PriorRequest = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "PriorRequest",                                                                                              // MakerGen.cs:235
                        Path= "DeviceRequest.priorRequest",                                                                                 // MakerGen.cs:236
                        Id = "DeviceRequest.priorRequest",                                                                                  // MakerGen.cs:237
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
                    // 6. DeviceRequest.groupIdentifier
                    this.GroupIdentifier = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "GroupIdentifier",                                                                                           // MakerGen.cs:235
                        Path= "DeviceRequest.groupIdentifier",                                                                              // MakerGen.cs:236
                        Id = "DeviceRequest.groupIdentifier",                                                                               // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 7. DeviceRequest.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Status",                                                                                                    // MakerGen.cs:235
                        Path= "DeviceRequest.status",                                                                                       // MakerGen.cs:236
                        Id = "DeviceRequest.status",                                                                                        // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
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
                    // 8. DeviceRequest.intent
                    this.Intent = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Intent",                                                                                                    // MakerGen.cs:235
                        Path= "DeviceRequest.intent",                                                                                       // MakerGen.cs:236
                        Id = "DeviceRequest.intent",                                                                                        // MakerGen.cs:237
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
                    // 9. DeviceRequest.priority
                    this.Priority = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Priority",                                                                                                  // MakerGen.cs:235
                        Path= "DeviceRequest.priority",                                                                                     // MakerGen.cs:236
                        Id = "DeviceRequest.priority",                                                                                      // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
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
                    // 10. DeviceRequest.code[x]
                    this.Code = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Code",                                                                                                      // MakerGen.cs:235
                        Path= "DeviceRequest.code[x]",                                                                                      // MakerGen.cs:236
                        Id = "DeviceRequest.code[x]",                                                                                       // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Device"                                                        // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            },                                                                                                              // MakerGen.cs:350
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 11. DeviceRequest.parameter
                    this.Parameter = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Parameter",                                                                                                 // MakerGen.cs:235
                        Path= "DeviceRequest.parameter",                                                                                    // MakerGen.cs:236
                        Id = "DeviceRequest.parameter",                                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Parameter                                                                                              // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 14. DeviceRequest.subject
                    this.Subject = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Subject",                                                                                                   // MakerGen.cs:235
                        Path= "DeviceRequest.subject",                                                                                      // MakerGen.cs:236
                        Id = "DeviceRequest.subject",                                                                                       // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Group",                                                        // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Location",                                                     // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Device"                                                        // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 15. DeviceRequest.encounter
                    this.Encounter = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Encounter",                                                                                                 // MakerGen.cs:235
                        Path= "DeviceRequest.encounter",                                                                                    // MakerGen.cs:236
                        Id = "DeviceRequest.encounter",                                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Encounter"                                                     // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 16. DeviceRequest.occurrence[x]
                    this.Occurrence = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Occurrence",                                                                                                // MakerGen.cs:235
                        Path= "DeviceRequest.occurrence[x]",                                                                                // MakerGen.cs:236
                        Id = "DeviceRequest.occurrence[x]",                                                                                 // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            },                                                                                                              // MakerGen.cs:304
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            },                                                                                                              // MakerGen.cs:360
                            new FhirKhit.Maker.Common.Complex.Timing                                                                        // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 17. DeviceRequest.authoredOn
                    this.AuthoredOn = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "AuthoredOn",                                                                                                // MakerGen.cs:235
                        Path= "DeviceRequest.authoredOn",                                                                                   // MakerGen.cs:236
                        Id = "DeviceRequest.authoredOn",                                                                                    // MakerGen.cs:237
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
                    // 18. DeviceRequest.requester
                    this.Requester = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Requester",                                                                                                 // MakerGen.cs:235
                        Path= "DeviceRequest.requester",                                                                                    // MakerGen.cs:236
                        Id = "DeviceRequest.requester",                                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Device",                                                       // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 19. DeviceRequest.performerType
                    this.PerformerType = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "PerformerType",                                                                                             // MakerGen.cs:235
                        Path= "DeviceRequest.performerType",                                                                                // MakerGen.cs:236
                        Id = "DeviceRequest.performerType",                                                                                 // MakerGen.cs:237
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
                    // 20. DeviceRequest.performer
                    this.Performer = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Performer",                                                                                                 // MakerGen.cs:235
                        Path= "DeviceRequest.performer",                                                                                    // MakerGen.cs:236
                        Id = "DeviceRequest.performer",                                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Organization",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/CareTeam",                                                     // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/HealthcareService",                                            // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Device",                                                       // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                                 // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 21. DeviceRequest.reasonCode
                    this.ReasonCode = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ReasonCode",                                                                                                // MakerGen.cs:235
                        Path= "DeviceRequest.reasonCode",                                                                                   // MakerGen.cs:236
                        Id = "DeviceRequest.reasonCode",                                                                                    // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 22. DeviceRequest.reasonReference
                    this.ReasonReference = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ReasonReference",                                                                                           // MakerGen.cs:235
                        Path= "DeviceRequest.reasonReference",                                                                              // MakerGen.cs:236
                        Id = "DeviceRequest.reasonReference",                                                                               // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Condition",                                                    // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Observation",                                                  // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",                                             // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                             // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 23. DeviceRequest.insurance
                    this.Insurance = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Insurance",                                                                                                 // MakerGen.cs:235
                        Path= "DeviceRequest.insurance",                                                                                    // MakerGen.cs:236
                        Id = "DeviceRequest.insurance",                                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Coverage",                                                     // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/ClaimResponse"                                                 // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 24. DeviceRequest.supportingInfo
                    this.SupportingInfo = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "SupportingInfo",                                                                                            // MakerGen.cs:235
                        Path= "DeviceRequest.supportingInfo",                                                                               // MakerGen.cs:236
                        Id = "DeviceRequest.supportingInfo",                                                                                // MakerGen.cs:237
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
                    // 25. DeviceRequest.note
                    this.Note = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Note",                                                                                                      // MakerGen.cs:235
                        Path= "DeviceRequest.note",                                                                                         // MakerGen.cs:236
                        Id = "DeviceRequest.note",                                                                                          // MakerGen.cs:237
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
                    // 26. DeviceRequest.relevantHistory
                    this.RelevantHistory = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "RelevantHistory",                                                                                           // MakerGen.cs:235
                        Path= "DeviceRequest.relevantHistory",                                                                              // MakerGen.cs:236
                        Id = "DeviceRequest.relevantHistory",                                                                               // MakerGen.cs:237
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
            }                                                                                                                               // MakerGen.cs:427
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:412
            {                                                                                                                               // MakerGen.cs:413
                base.Write(sDef);                                                                                                           // MakerGen.cs:414
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:220
                InstantiatesCanonical.Write(sDef);                                                                                          // MakerGen.cs:220
                InstantiatesUri.Write(sDef);                                                                                                // MakerGen.cs:220
                BasedOn.Write(sDef);                                                                                                        // MakerGen.cs:220
                PriorRequest.Write(sDef);                                                                                                   // MakerGen.cs:220
                GroupIdentifier.Write(sDef);                                                                                                // MakerGen.cs:220
                Status.Write(sDef);                                                                                                         // MakerGen.cs:220
                Intent.Write(sDef);                                                                                                         // MakerGen.cs:220
                Priority.Write(sDef);                                                                                                       // MakerGen.cs:220
                Code.Write(sDef);                                                                                                           // MakerGen.cs:220
                Parameter.Write(sDef);                                                                                                      // MakerGen.cs:220
                Subject.Write(sDef);                                                                                                        // MakerGen.cs:220
                Encounter.Write(sDef);                                                                                                      // MakerGen.cs:220
                Occurrence.Write(sDef);                                                                                                     // MakerGen.cs:220
                AuthoredOn.Write(sDef);                                                                                                     // MakerGen.cs:220
                Requester.Write(sDef);                                                                                                      // MakerGen.cs:220
                PerformerType.Write(sDef);                                                                                                  // MakerGen.cs:220
                Performer.Write(sDef);                                                                                                      // MakerGen.cs:220
                ReasonCode.Write(sDef);                                                                                                     // MakerGen.cs:220
                ReasonReference.Write(sDef);                                                                                                // MakerGen.cs:220
                Insurance.Write(sDef);                                                                                                      // MakerGen.cs:220
                SupportingInfo.Write(sDef);                                                                                                 // MakerGen.cs:220
                Note.Write(sDef);                                                                                                           // MakerGen.cs:220
                RelevantHistory.Write(sDef);                                                                                                // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:431
        }                                                                                                                                   // MakerGen.cs:391
        public DeviceRequest_Elements Elements { get; }                                                                                     // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
        public DeviceRequest()                                                                                                              // MakerGen.cs:394
        {                                                                                                                                   // MakerGen.cs:395
            this.Elements = new DeviceRequest_Elements();                                                                                   // MakerGen.cs:396
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:399
        {                                                                                                                                   // MakerGen.cs:400
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:401
        }                                                                                                                                   // MakerGen.cs:402
    }                                                                                                                                       // MakerGen.cs:403
}                                                                                                                                           // MakerGen.cs:466
