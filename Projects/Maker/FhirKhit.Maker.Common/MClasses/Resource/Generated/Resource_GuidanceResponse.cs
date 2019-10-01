using System;                                                                                                                               // MakerGen.cs:454
using System.Diagnostics;                                                                                                                   // MakerGen.cs:455
using System.IO;                                                                                                                            // MakerGen.cs:456
using System.Linq;                                                                                                                          // MakerGen.cs:457
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:458
                                                                                                                                            // MakerGen.cs:459
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:460
{                                                                                                                                           // MakerGen.cs:461
    #region Json                                                                                                                            // MakerGen.cs:462
    #if NEVER                                                                                                                               // MakerGen.cs:463
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
    #endregion                                                                                                                              // MakerGen.cs:466
    /// <summary>
    /// Fhir resource 'GuidanceResponse'
    /// </summary>
    // 0. GuidanceResponse
    public class Resource_GuidanceResponse : FhirKhit.Maker.Common.Resource.ResourceBase                                                    // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        public class Resource_GuidanceResponse_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                       // MakerGen.cs:378
        {                                                                                                                                   // MakerGen.cs:379
            // 1. GuidanceResponse.requestIdentifier
            public ElementDefinitionInfo Element_RequestIdentifier;                                                                         // MakerGen.cs:211
            // 2. GuidanceResponse.identifier
            public ElementDefinitionInfo Element_Identifier;                                                                                // MakerGen.cs:211
            // 3. GuidanceResponse.module[x]
            public ElementDefinitionInfo Element_Module;                                                                                    // MakerGen.cs:211
            // 4. GuidanceResponse.status
            public ElementDefinitionInfo Element_Status;                                                                                    // MakerGen.cs:211
            // 5. GuidanceResponse.subject
            public ElementDefinitionInfo Element_Subject;                                                                                   // MakerGen.cs:211
            // 6. GuidanceResponse.encounter
            public ElementDefinitionInfo Element_Encounter;                                                                                 // MakerGen.cs:211
            // 7. GuidanceResponse.occurrenceDateTime
            public ElementDefinitionInfo Element_OccurrenceDateTime;                                                                        // MakerGen.cs:211
            // 8. GuidanceResponse.performer
            public ElementDefinitionInfo Element_Performer;                                                                                 // MakerGen.cs:211
            // 9. GuidanceResponse.reasonCode
            public ElementDefinitionInfo Element_ReasonCode;                                                                                // MakerGen.cs:211
            // 10. GuidanceResponse.reasonReference
            public ElementDefinitionInfo Element_ReasonReference;                                                                           // MakerGen.cs:211
            // 11. GuidanceResponse.note
            public ElementDefinitionInfo Element_Note;                                                                                      // MakerGen.cs:211
            // 12. GuidanceResponse.evaluationMessage
            public ElementDefinitionInfo Element_EvaluationMessage;                                                                         // MakerGen.cs:211
            // 13. GuidanceResponse.outputParameters
            public ElementDefinitionInfo Element_OutputParameters;                                                                          // MakerGen.cs:211
            // 14. GuidanceResponse.result
            public ElementDefinitionInfo Element_Result;                                                                                    // MakerGen.cs:211
            // 15. GuidanceResponse.dataRequirement
            public ElementDefinitionInfo Element_DataRequirement;                                                                           // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
            public Resource_GuidanceResponse_Elements()                                                                                     // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:226
                    // 1. GuidanceResponse.requestIdentifier
                    this.Element_RequestIdentifier = new ElementDefinitionInfo                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_RequestIdentifier",                                                                                 // MakerGen.cs:230
                        Path= "GuidanceResponse.requestIdentifier",                                                                         // MakerGen.cs:231
                        Id = "GuidanceResponse.requestIdentifier",                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Identifier                                                               // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. GuidanceResponse.identifier
                    this.Element_Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Identifier",                                                                                        // MakerGen.cs:230
                        Path= "GuidanceResponse.identifier",                                                                                // MakerGen.cs:231
                        Id = "GuidanceResponse.identifier",                                                                                 // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Identifier                                                               // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 3. GuidanceResponse.module[x]
                    this.Element_Module = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Module",                                                                                            // MakerGen.cs:230
                        Path= "GuidanceResponse.module[x]",                                                                                 // MakerGen.cs:231
                        Id = "GuidanceResponse.module[x]",                                                                                  // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Uri                                                                         // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            },                                                                                                              // MakerGen.cs:299
                            new FhirKhit.Maker.Common.Primitive.Canonical                                                                   // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            },                                                                                                              // MakerGen.cs:299
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 4. GuidanceResponse.status
                    this.Element_Status = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Status",                                                                                            // MakerGen.cs:230
                        Path= "GuidanceResponse.status",                                                                                    // MakerGen.cs:231
                        Id = "GuidanceResponse.status",                                                                                     // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. GuidanceResponse.subject
                    this.Element_Subject = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Subject",                                                                                           // MakerGen.cs:230
                        Path= "GuidanceResponse.subject",                                                                                   // MakerGen.cs:231
                        Id = "GuidanceResponse.subject",                                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/Group"                                                         // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 6. GuidanceResponse.encounter
                    this.Element_Encounter = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Encounter",                                                                                         // MakerGen.cs:230
                        Path= "GuidanceResponse.encounter",                                                                                 // MakerGen.cs:231
                        Id = "GuidanceResponse.encounter",                                                                                  // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Encounter"                                                     // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 7. GuidanceResponse.occurrenceDateTime
                    this.Element_OccurrenceDateTime = new ElementDefinitionInfo                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_OccurrenceDateTime",                                                                                // MakerGen.cs:230
                        Path= "GuidanceResponse.occurrenceDateTime",                                                                        // MakerGen.cs:231
                        Id = "GuidanceResponse.occurrenceDateTime",                                                                         // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 8. GuidanceResponse.performer
                    this.Element_Performer = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Performer",                                                                                         // MakerGen.cs:230
                        Path= "GuidanceResponse.performer",                                                                                 // MakerGen.cs:231
                        Id = "GuidanceResponse.performer",                                                                                  // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Device"                                                        // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 9. GuidanceResponse.reasonCode
                    this.Element_ReasonCode = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_ReasonCode",                                                                                        // MakerGen.cs:230
                        Path= "GuidanceResponse.reasonCode",                                                                                // MakerGen.cs:231
                        Id = "GuidanceResponse.reasonCode",                                                                                 // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 10. GuidanceResponse.reasonReference
                    this.Element_ReasonReference = new ElementDefinitionInfo                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_ReasonReference",                                                                                   // MakerGen.cs:230
                        Path= "GuidanceResponse.reasonReference",                                                                           // MakerGen.cs:231
                        Id = "GuidanceResponse.reasonReference",                                                                            // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Condition",                                                    // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/Observation",                                                  // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",                                             // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                             // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 11. GuidanceResponse.note
                    this.Element_Note = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Note",                                                                                              // MakerGen.cs:230
                        Path= "GuidanceResponse.note",                                                                                      // MakerGen.cs:231
                        Id = "GuidanceResponse.note",                                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Annotation                                                               // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 12. GuidanceResponse.evaluationMessage
                    this.Element_EvaluationMessage = new ElementDefinitionInfo                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_EvaluationMessage",                                                                                 // MakerGen.cs:230
                        Path= "GuidanceResponse.evaluationMessage",                                                                         // MakerGen.cs:231
                        Id = "GuidanceResponse.evaluationMessage",                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/OperationOutcome"                                              // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 13. GuidanceResponse.outputParameters
                    this.Element_OutputParameters = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_OutputParameters",                                                                                  // MakerGen.cs:230
                        Path= "GuidanceResponse.outputParameters",                                                                          // MakerGen.cs:231
                        Id = "GuidanceResponse.outputParameters",                                                                           // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Parameters"                                                    // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 14. GuidanceResponse.result
                    this.Element_Result = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Result",                                                                                            // MakerGen.cs:230
                        Path= "GuidanceResponse.result",                                                                                    // MakerGen.cs:231
                        Id = "GuidanceResponse.result",                                                                                     // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/CarePlan",                                                     // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/RequestGroup"                                                  // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 15. GuidanceResponse.dataRequirement
                    this.Element_DataRequirement = new ElementDefinitionInfo                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_DataRequirement",                                                                                   // MakerGen.cs:230
                        Path= "GuidanceResponse.dataRequirement",                                                                           // MakerGen.cs:231
                        Id = "GuidanceResponse.dataRequirement",                                                                            // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_DataRequirement                                                          // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                Element_RequestIdentifier.Write(sDef);                                                                                      // MakerGen.cs:215
                Element_Identifier.Write(sDef);                                                                                             // MakerGen.cs:215
                Element_Module.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_Status.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_Subject.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_Encounter.Write(sDef);                                                                                              // MakerGen.cs:215
                Element_OccurrenceDateTime.Write(sDef);                                                                                     // MakerGen.cs:215
                Element_Performer.Write(sDef);                                                                                              // MakerGen.cs:215
                Element_ReasonCode.Write(sDef);                                                                                             // MakerGen.cs:215
                Element_ReasonReference.Write(sDef);                                                                                        // MakerGen.cs:215
                Element_Note.Write(sDef);                                                                                                   // MakerGen.cs:215
                Element_EvaluationMessage.Write(sDef);                                                                                      // MakerGen.cs:215
                Element_OutputParameters.Write(sDef);                                                                                       // MakerGen.cs:215
                Element_Result.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_DataRequirement.Write(sDef);                                                                                        // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:394
        }                                                                                                                                   // MakerGen.cs:396
        public Resource_GuidanceResponse_Elements Elements                                                                                  // MakerGen.cs:398
        {                                                                                                                                   // MakerGen.cs:399
            get                                                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                if (this.elements == null)                                                                                                  // MakerGen.cs:402
                    this.elements = new Resource_GuidanceResponse_Elements();                                                               // MakerGen.cs:403
                return this.elements;                                                                                                       // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:406
        Resource_GuidanceResponse_Elements elements;                                                                                        // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
        public Resource_GuidanceResponse()                                                                                                  // MakerGen.cs:410
        {                                                                                                                                   // MakerGen.cs:411
            this.Name = "GuidanceResponse";                                                                                                 // MakerGen.cs:484
            this.Uri = "http://hl7.org/fhir/StructureDefinition/GuidanceResponse";                                                          // MakerGen.cs:485
        }                                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:416
        {                                                                                                                                   // MakerGen.cs:417
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:418
            {                                                                                                                               // MakerGen.cs:419
                Path = "GuidanceResponse",                                                                                                  // MakerGen.cs:420
                ElementId = "GuidanceResponse"                                                                                              // MakerGen.cs:421
            });                                                                                                                             // MakerGen.cs:422
            if (this.elements != null)                                                                                                      // MakerGen.cs:423
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:424
        }                                                                                                                                   // MakerGen.cs:425
    }                                                                                                                                       // MakerGen.cs:426
}                                                                                                                                           // MakerGen.cs:471
