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
      "id": "GuidanceResponse",
      "url": "http://hl7.org/fhir/StructureDefinition/GuidanceResponse",
      "version": "4.0.0",
      "name": "GuidanceResponse",
      "status": "draft",
      "publisher": "Health Level Seven International (Clinical Decision Support)",
      "description": "A guidance response is the formal response to a guidance request, including any output parameters returned by the evaluation, as well as the description of any proposed actions to be taken.",
      "purpose": "The GuidanceResponse resource supports recording the results of decision support interactions, reportability determination for public health, as well as the communication of additional data requirements for subsequent interactions.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "GuidanceResponse",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "GuidanceResponse",
            "path": "GuidanceResponse",
            "short": "The formal response to a guidance request",
            "definition": "A guidance response is the formal response to a guidance request, including any output parameters returned by the evaluation, as well as the description of any proposed actions to be taken.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "GuidanceResponse.requestIdentifier",
            "path": "GuidanceResponse.requestIdentifier",
            "short": "The identifier of the request associated with this response, if any",
            "definition": "The identifier of the request associated with this response. If an identifier was given as part of the request, it will be reproduced here to enable the requester to more easily identify the response in a multi-request scenario.",
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
            "id": "GuidanceResponse.identifier",
            "path": "GuidanceResponse.identifier",
            "short": "Business identifier",
            "definition": "Allows a service to provide  unique, business identifiers for the response.",
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
            "id": "GuidanceResponse.module[x]",
            "path": "GuidanceResponse.module[x]",
            "short": "What guidance was requested",
            "definition": "An identifier, CodeableConcept or canonical reference to the guidance that was requested.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "uri"
              },
              {
                "code": "canonical"
              },
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "GuidanceResponse.status",
            "path": "GuidanceResponse.status",
            "short": "success | data-requested | data-required | in-progress | failure | entered-in-error",
            "definition": "The status of the response. If the evaluation is completed successfully, the status will indicate success. However, in order to complete the evaluation, the engine may require more information. In this case, the status will be data-required, and the response will contain a description of the additional required information. If the evaluation completed successfully, but the engine determines that a potentially more accurate response could be provided if more data was available, the status will be data-requested, and the response will contain a description of the additional requested information.",
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
                  "valueString": "GuidanceResponseStatus"
                }
              ],
              "strength": "required",
              "description": "The status of a guidance response.",
              "valueSet": "http://hl7.org/fhir/ValueSet/guidance-response-status|4.0.0"
            }
          },
          {
            "id": "GuidanceResponse.subject",
            "path": "GuidanceResponse.subject",
            "short": "Patient the request was performed for",
            "definition": "The patient for which the request was processed.",
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
            ]
          },
          {
            "id": "GuidanceResponse.encounter",
            "path": "GuidanceResponse.encounter",
            "short": "Encounter during which the response was returned",
            "definition": "The encounter during which this response was created or to which the creation of this record is tightly associated.",
            "comment": "This will typically be the encounter the event occurred within, but some activities may be initiated prior to or after the official copmletion of an encounter but still be tied to the context of the encounter.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Encounter"
                ]
              }
            ]
          },
          {
            "id": "GuidanceResponse.occurrenceDateTime",
            "path": "GuidanceResponse.occurrenceDateTime",
            "short": "When the guidance response was processed",
            "definition": "Indicates when the guidance response was processed.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ]
          },
          {
            "id": "GuidanceResponse.performer",
            "path": "GuidanceResponse.performer",
            "short": "Device returning the guidance",
            "definition": "Provides a reference to the device that performed the guidance.",
            "min": 0,
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
            "id": "GuidanceResponse.reasonCode",
            "path": "GuidanceResponse.reasonCode",
            "short": "Why guidance is needed",
            "definition": "Describes the reason for the guidance response in coded or textual form.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "GuidanceResponse.reasonReference",
            "path": "GuidanceResponse.reasonReference",
            "short": "Why guidance is needed",
            "definition": "Indicates the reason the request was initiated. This is typically provided as a parameter to the evaluation and echoed by the service, although for some use cases, such as subscription- or event-based scenarios, it may provide an indication of the cause for the response.",
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
            ]
          },
          {
            "id": "GuidanceResponse.note",
            "path": "GuidanceResponse.note",
            "short": "Additional notes about the response",
            "definition": "Provides a mechanism to communicate additional information about the response.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Annotation"
              }
            ]
          },
          {
            "id": "GuidanceResponse.evaluationMessage",
            "path": "GuidanceResponse.evaluationMessage",
            "short": "Messages resulting from the evaluation of the artifact or artifacts",
            "definition": "Messages resulting from the evaluation of the artifact or artifacts. As part of evaluating the request, the engine may produce informational or warning messages. These messages will be provided by this element.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/OperationOutcome"
                ]
              }
            ]
          },
          {
            "id": "GuidanceResponse.outputParameters",
            "path": "GuidanceResponse.outputParameters",
            "short": "The output parameters of the evaluation, if any",
            "definition": "The output parameters of the evaluation, if any. Many modules will result in the return of specific resources such as procedure or communication requests that are returned as part of the operation result. However, modules may define specific outputs that would be returned as the result of the evaluation, and these would be returned in this element.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Parameters"
                ]
              }
            ]
          },
          {
            "id": "GuidanceResponse.result",
            "path": "GuidanceResponse.result",
            "short": "Proposed actions, if any",
            "definition": "The actions, if any, produced by the evaluation of the artifact.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/CarePlan",
                  "http://hl7.org/fhir/StructureDefinition/RequestGroup"
                ]
              }
            ]
          },
          {
            "id": "GuidanceResponse.dataRequirement",
            "path": "GuidanceResponse.dataRequirement",
            "short": "Additional required data",
            "definition": "If the evaluation could not be completed due to lack of information, or additional information would potentially result in a more accurate response, this element will a description of the data required in order to proceed with the evaluation. A subsequent request to the service should include this data.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "DataRequirement"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:461
    /// <summary>
    /// Fhir resource 'GuidanceResponse'
    /// </summary>
    // 0. GuidanceResponse
    public class GuidanceResponse : FhirKhit.Maker.Common.Resource.ResourceBase                                                             // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        public class GuidanceResponse_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                // MakerGen.cs:385
        {                                                                                                                                   // MakerGen.cs:386
            // 1. GuidanceResponse.requestIdentifier
            public ElementDefinitionInfo RequestIdentifier;                                                                                 // MakerGen.cs:216
            // 2. GuidanceResponse.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 3. GuidanceResponse.module[x]
            public ElementDefinitionInfo Module;                                                                                            // MakerGen.cs:216
            // 4. GuidanceResponse.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:216
            // 5. GuidanceResponse.subject
            public ElementDefinitionInfo Subject;                                                                                           // MakerGen.cs:216
            // 6. GuidanceResponse.encounter
            public ElementDefinitionInfo Encounter;                                                                                         // MakerGen.cs:216
            // 7. GuidanceResponse.occurrenceDateTime
            public ElementDefinitionInfo OccurrenceDateTime;                                                                                // MakerGen.cs:216
            // 8. GuidanceResponse.performer
            public ElementDefinitionInfo Performer;                                                                                         // MakerGen.cs:216
            // 9. GuidanceResponse.reasonCode
            public ElementDefinitionInfo ReasonCode;                                                                                        // MakerGen.cs:216
            // 10. GuidanceResponse.reasonReference
            public ElementDefinitionInfo ReasonReference;                                                                                   // MakerGen.cs:216
            // 11. GuidanceResponse.note
            public ElementDefinitionInfo Note;                                                                                              // MakerGen.cs:216
            // 12. GuidanceResponse.evaluationMessage
            public ElementDefinitionInfo EvaluationMessage;                                                                                 // MakerGen.cs:216
            // 13. GuidanceResponse.outputParameters
            public ElementDefinitionInfo OutputParameters;                                                                                  // MakerGen.cs:216
            // 14. GuidanceResponse.result
            public ElementDefinitionInfo Result;                                                                                            // MakerGen.cs:216
            // 15. GuidanceResponse.dataRequirement
            public ElementDefinitionInfo DataRequirement;                                                                                   // MakerGen.cs:216
            public GuidanceResponse_Elements()                                                                                              // MakerGen.cs:407
            {                                                                                                                               // MakerGen.cs:408
                {                                                                                                                           // MakerGen.cs:231
                    // 1. GuidanceResponse.requestIdentifier
                    this.RequestIdentifier = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "RequestIdentifier",                                                                                         // MakerGen.cs:235
                        Path= "GuidanceResponse.requestIdentifier",                                                                         // MakerGen.cs:236
                        Id = "GuidanceResponse.requestIdentifier",                                                                          // MakerGen.cs:237
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
                    // 2. GuidanceResponse.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "GuidanceResponse.identifier",                                                                                // MakerGen.cs:236
                        Id = "GuidanceResponse.identifier",                                                                                 // MakerGen.cs:237
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
                    // 3. GuidanceResponse.module[x]
                    this.Module = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Module",                                                                                                    // MakerGen.cs:235
                        Path= "GuidanceResponse.module[x]",                                                                                 // MakerGen.cs:236
                        Id = "GuidanceResponse.module[x]",                                                                                  // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Uri                                                                         // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            },                                                                                                              // MakerGen.cs:304
                            new FhirKhit.Maker.Common.Primitive.Canonical                                                                   // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            },                                                                                                              // MakerGen.cs:304
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 4. GuidanceResponse.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Status",                                                                                                    // MakerGen.cs:235
                        Path= "GuidanceResponse.status",                                                                                    // MakerGen.cs:236
                        Id = "GuidanceResponse.status",                                                                                     // MakerGen.cs:237
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
                    // 5. GuidanceResponse.subject
                    this.Subject = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Subject",                                                                                                   // MakerGen.cs:235
                        Path= "GuidanceResponse.subject",                                                                                   // MakerGen.cs:236
                        Id = "GuidanceResponse.subject",                                                                                    // MakerGen.cs:237
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
                    // 6. GuidanceResponse.encounter
                    this.Encounter = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Encounter",                                                                                                 // MakerGen.cs:235
                        Path= "GuidanceResponse.encounter",                                                                                 // MakerGen.cs:236
                        Id = "GuidanceResponse.encounter",                                                                                  // MakerGen.cs:237
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
                    // 7. GuidanceResponse.occurrenceDateTime
                    this.OccurrenceDateTime = new ElementDefinitionInfo                                                                     // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "OccurrenceDateTime",                                                                                        // MakerGen.cs:235
                        Path= "GuidanceResponse.occurrenceDateTime",                                                                        // MakerGen.cs:236
                        Id = "GuidanceResponse.occurrenceDateTime",                                                                         // MakerGen.cs:237
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
                    // 8. GuidanceResponse.performer
                    this.Performer = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Performer",                                                                                                 // MakerGen.cs:235
                        Path= "GuidanceResponse.performer",                                                                                 // MakerGen.cs:236
                        Id = "GuidanceResponse.performer",                                                                                  // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Device"                                                        // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 9. GuidanceResponse.reasonCode
                    this.ReasonCode = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ReasonCode",                                                                                                // MakerGen.cs:235
                        Path= "GuidanceResponse.reasonCode",                                                                                // MakerGen.cs:236
                        Id = "GuidanceResponse.reasonCode",                                                                                 // MakerGen.cs:237
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
                    // 10. GuidanceResponse.reasonReference
                    this.ReasonReference = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ReasonReference",                                                                                           // MakerGen.cs:235
                        Path= "GuidanceResponse.reasonReference",                                                                           // MakerGen.cs:236
                        Id = "GuidanceResponse.reasonReference",                                                                            // MakerGen.cs:237
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
                    // 11. GuidanceResponse.note
                    this.Note = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Note",                                                                                                      // MakerGen.cs:235
                        Path= "GuidanceResponse.note",                                                                                      // MakerGen.cs:236
                        Id = "GuidanceResponse.note",                                                                                       // MakerGen.cs:237
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
                    // 12. GuidanceResponse.evaluationMessage
                    this.EvaluationMessage = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "EvaluationMessage",                                                                                         // MakerGen.cs:235
                        Path= "GuidanceResponse.evaluationMessage",                                                                         // MakerGen.cs:236
                        Id = "GuidanceResponse.evaluationMessage",                                                                          // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/OperationOutcome"                                              // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 13. GuidanceResponse.outputParameters
                    this.OutputParameters = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "OutputParameters",                                                                                          // MakerGen.cs:235
                        Path= "GuidanceResponse.outputParameters",                                                                          // MakerGen.cs:236
                        Id = "GuidanceResponse.outputParameters",                                                                           // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Parameters"                                                    // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 14. GuidanceResponse.result
                    this.Result = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Result",                                                                                                    // MakerGen.cs:235
                        Path= "GuidanceResponse.result",                                                                                    // MakerGen.cs:236
                        Id = "GuidanceResponse.result",                                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/CarePlan",                                                     // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/RequestGroup"                                                  // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 15. GuidanceResponse.dataRequirement
                    this.DataRequirement = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "DataRequirement",                                                                                           // MakerGen.cs:235
                        Path= "GuidanceResponse.dataRequirement",                                                                           // MakerGen.cs:236
                        Id = "GuidanceResponse.dataRequirement",                                                                            // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.DataRequirement                                                               // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:427
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:412
            {                                                                                                                               // MakerGen.cs:413
                base.Write(sDef);                                                                                                           // MakerGen.cs:414
                RequestIdentifier.Write(sDef);                                                                                              // MakerGen.cs:220
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:220
                Module.Write(sDef);                                                                                                         // MakerGen.cs:220
                Status.Write(sDef);                                                                                                         // MakerGen.cs:220
                Subject.Write(sDef);                                                                                                        // MakerGen.cs:220
                Encounter.Write(sDef);                                                                                                      // MakerGen.cs:220
                OccurrenceDateTime.Write(sDef);                                                                                             // MakerGen.cs:220
                Performer.Write(sDef);                                                                                                      // MakerGen.cs:220
                ReasonCode.Write(sDef);                                                                                                     // MakerGen.cs:220
                ReasonReference.Write(sDef);                                                                                                // MakerGen.cs:220
                Note.Write(sDef);                                                                                                           // MakerGen.cs:220
                EvaluationMessage.Write(sDef);                                                                                              // MakerGen.cs:220
                OutputParameters.Write(sDef);                                                                                               // MakerGen.cs:220
                Result.Write(sDef);                                                                                                         // MakerGen.cs:220
                DataRequirement.Write(sDef);                                                                                                // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:431
        }                                                                                                                                   // MakerGen.cs:391
        public GuidanceResponse_Elements Elements { get; }                                                                                  // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
        public GuidanceResponse()                                                                                                           // MakerGen.cs:394
        {                                                                                                                                   // MakerGen.cs:395
            this.Elements = new GuidanceResponse_Elements();                                                                                // MakerGen.cs:396
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:399
        {                                                                                                                                   // MakerGen.cs:400
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:401
        }                                                                                                                                   // MakerGen.cs:402
    }                                                                                                                                       // MakerGen.cs:403
}                                                                                                                                           // MakerGen.cs:466
