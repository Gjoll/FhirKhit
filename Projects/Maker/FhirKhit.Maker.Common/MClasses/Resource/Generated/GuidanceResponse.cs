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
    #endregion                                                                                                                              // MakerGen.cs:463
    /// <summary>
    /// Fhir resource 'GuidanceResponse'
    /// </summary>
    // 0. GuidanceResponse
    public class GuidanceResponse : FhirKhit.Maker.Common.Resource.ResourceBase                                                             // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class GuidanceResponse_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 1. GuidanceResponse.requestIdentifier
            public ElementDefinitionInfo RequestIdentifier;                                                                                 // MakerGen.cs:236
            // 2. GuidanceResponse.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:236
            // 3. GuidanceResponse.module[x]
            public ElementDefinitionInfo Module;                                                                                            // MakerGen.cs:236
            // 4. GuidanceResponse.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:236
            // 5. GuidanceResponse.subject
            public ElementDefinitionInfo Subject;                                                                                           // MakerGen.cs:236
            // 6. GuidanceResponse.encounter
            public ElementDefinitionInfo Encounter;                                                                                         // MakerGen.cs:236
            // 7. GuidanceResponse.occurrenceDateTime
            public ElementDefinitionInfo OccurrenceDateTime;                                                                                // MakerGen.cs:236
            // 8. GuidanceResponse.performer
            public ElementDefinitionInfo Performer;                                                                                         // MakerGen.cs:236
            // 9. GuidanceResponse.reasonCode
            public ElementDefinitionInfo ReasonCode;                                                                                        // MakerGen.cs:236
            // 10. GuidanceResponse.reasonReference
            public ElementDefinitionInfo ReasonReference;                                                                                   // MakerGen.cs:236
            // 11. GuidanceResponse.note
            public ElementDefinitionInfo Note;                                                                                              // MakerGen.cs:236
            // 12. GuidanceResponse.evaluationMessage
            public ElementDefinitionInfo EvaluationMessage;                                                                                 // MakerGen.cs:236
            // 13. GuidanceResponse.outputParameters
            public ElementDefinitionInfo OutputParameters;                                                                                  // MakerGen.cs:236
            // 14. GuidanceResponse.result
            public ElementDefinitionInfo Result;                                                                                            // MakerGen.cs:236
            // 15. GuidanceResponse.dataRequirement
            public ElementDefinitionInfo DataRequirement;                                                                                   // MakerGen.cs:236
            public GuidanceResponse_Elements()                                                                                              // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. GuidanceResponse.requestIdentifier
                    this.RequestIdentifier = new ElementDefinitionInfo                                                                      // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "RequestIdentifier",                                                                                         // MakerGen.cs:255
                        Path= "GuidanceResponse.requestIdentifier",                                                                         // MakerGen.cs:256
                        Id = "GuidanceResponse.requestIdentifier",                                                                          // MakerGen.cs:257
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
                    // 2. GuidanceResponse.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Identifier",                                                                                                // MakerGen.cs:255
                        Path= "GuidanceResponse.identifier",                                                                                // MakerGen.cs:256
                        Id = "GuidanceResponse.identifier",                                                                                 // MakerGen.cs:257
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
                    // 3. GuidanceResponse.module[x]
                    this.Module = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Module",                                                                                                    // MakerGen.cs:255
                        Path= "GuidanceResponse.module[x]",                                                                                 // MakerGen.cs:256
                        Id = "GuidanceResponse.module[x]",                                                                                  // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Uri                                                                         // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            },                                                                                                              // MakerGen.cs:303
                            new FhirKhit.Maker.Common.Primitive.Canonical                                                                   // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            },                                                                                                              // MakerGen.cs:303
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 4. GuidanceResponse.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Status",                                                                                                    // MakerGen.cs:255
                        Path= "GuidanceResponse.status",                                                                                    // MakerGen.cs:256
                        Id = "GuidanceResponse.status",                                                                                     // MakerGen.cs:257
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
                    // 5. GuidanceResponse.subject
                    this.Subject = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Subject",                                                                                                   // MakerGen.cs:255
                        Path= "GuidanceResponse.subject",                                                                                   // MakerGen.cs:256
                        Id = "GuidanceResponse.subject",                                                                                    // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Group"                                                         // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 6. GuidanceResponse.encounter
                    this.Encounter = new ElementDefinitionInfo                                                                              // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Encounter",                                                                                                 // MakerGen.cs:255
                        Path= "GuidanceResponse.encounter",                                                                                 // MakerGen.cs:256
                        Id = "GuidanceResponse.encounter",                                                                                  // MakerGen.cs:257
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
                    // 7. GuidanceResponse.occurrenceDateTime
                    this.OccurrenceDateTime = new ElementDefinitionInfo                                                                     // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "OccurrenceDateTime",                                                                                        // MakerGen.cs:255
                        Path= "GuidanceResponse.occurrenceDateTime",                                                                        // MakerGen.cs:256
                        Id = "GuidanceResponse.occurrenceDateTime",                                                                         // MakerGen.cs:257
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
                    // 8. GuidanceResponse.performer
                    this.Performer = new ElementDefinitionInfo                                                                              // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Performer",                                                                                                 // MakerGen.cs:255
                        Path= "GuidanceResponse.performer",                                                                                 // MakerGen.cs:256
                        Id = "GuidanceResponse.performer",                                                                                  // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Device"                                                        // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 9. GuidanceResponse.reasonCode
                    this.ReasonCode = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "ReasonCode",                                                                                                // MakerGen.cs:255
                        Path= "GuidanceResponse.reasonCode",                                                                                // MakerGen.cs:256
                        Id = "GuidanceResponse.reasonCode",                                                                                 // MakerGen.cs:257
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
                    // 10. GuidanceResponse.reasonReference
                    this.ReasonReference = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "ReasonReference",                                                                                           // MakerGen.cs:255
                        Path= "GuidanceResponse.reasonReference",                                                                           // MakerGen.cs:256
                        Id = "GuidanceResponse.reasonReference",                                                                            // MakerGen.cs:257
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
                    // 11. GuidanceResponse.note
                    this.Note = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Note",                                                                                                      // MakerGen.cs:255
                        Path= "GuidanceResponse.note",                                                                                      // MakerGen.cs:256
                        Id = "GuidanceResponse.note",                                                                                       // MakerGen.cs:257
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
                    // 12. GuidanceResponse.evaluationMessage
                    this.EvaluationMessage = new ElementDefinitionInfo                                                                      // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "EvaluationMessage",                                                                                         // MakerGen.cs:255
                        Path= "GuidanceResponse.evaluationMessage",                                                                         // MakerGen.cs:256
                        Id = "GuidanceResponse.evaluationMessage",                                                                          // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/OperationOutcome"                                              // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 13. GuidanceResponse.outputParameters
                    this.OutputParameters = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "OutputParameters",                                                                                          // MakerGen.cs:255
                        Path= "GuidanceResponse.outputParameters",                                                                          // MakerGen.cs:256
                        Id = "GuidanceResponse.outputParameters",                                                                           // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Parameters"                                                    // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 14. GuidanceResponse.result
                    this.Result = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Result",                                                                                                    // MakerGen.cs:255
                        Path= "GuidanceResponse.result",                                                                                    // MakerGen.cs:256
                        Id = "GuidanceResponse.result",                                                                                     // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/CarePlan",                                                     // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/RequestGroup"                                                  // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 15. GuidanceResponse.dataRequirement
                    this.DataRequirement = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "DataRequirement",                                                                                           // MakerGen.cs:255
                        Path= "GuidanceResponse.dataRequirement",                                                                           // MakerGen.cs:256
                        Id = "GuidanceResponse.dataRequirement",                                                                            // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.DataRequirement                                                               // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:429
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                RequestIdentifier.Write(sDef);                                                                                              // MakerGen.cs:240
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:240
                Module.Write(sDef);                                                                                                         // MakerGen.cs:240
                Status.Write(sDef);                                                                                                         // MakerGen.cs:240
                Subject.Write(sDef);                                                                                                        // MakerGen.cs:240
                Encounter.Write(sDef);                                                                                                      // MakerGen.cs:240
                OccurrenceDateTime.Write(sDef);                                                                                             // MakerGen.cs:240
                Performer.Write(sDef);                                                                                                      // MakerGen.cs:240
                ReasonCode.Write(sDef);                                                                                                     // MakerGen.cs:240
                ReasonReference.Write(sDef);                                                                                                // MakerGen.cs:240
                Note.Write(sDef);                                                                                                           // MakerGen.cs:240
                EvaluationMessage.Write(sDef);                                                                                              // MakerGen.cs:240
                OutputParameters.Write(sDef);                                                                                               // MakerGen.cs:240
                Result.Write(sDef);                                                                                                         // MakerGen.cs:240
                DataRequirement.Write(sDef);                                                                                                // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public GuidanceResponse_Elements Elements { get; }                                                                                  // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public GuidanceResponse()                                                                                                           // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new GuidanceResponse_Elements();                                                                                // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:468
