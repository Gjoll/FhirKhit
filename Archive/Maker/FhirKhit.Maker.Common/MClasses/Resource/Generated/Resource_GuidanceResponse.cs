using System;                                                                                                                               // MakerGen.cs:432
using System.Diagnostics;                                                                                                                   // MakerGen.cs:433
using System.IO;                                                                                                                            // MakerGen.cs:434
using System.Linq;                                                                                                                          // MakerGen.cs:435
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:436
                                                                                                                                            // MakerGen.cs:437
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:438
{                                                                                                                                           // MakerGen.cs:439
    #region Json                                                                                                                            // MakerGen.cs:440
    #if NEVER                                                                                                                               // MakerGen.cs:441
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
    #endregion                                                                                                                              // MakerGen.cs:444
    /// <summary>
    /// Fhir resource 'GuidanceResponse'
    /// </summary>
    // 0. GuidanceResponse
    public partial class Resource_GuidanceResponse : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                 // MakerGen.cs:381
    {                                                                                                                                       // MakerGen.cs:382
        // 1. GuidanceResponse.requestIdentifier
        public ElementDefinitionInfo Element_RequestIdentifier;                                                                             // MakerGen.cs:217
        // 2. GuidanceResponse.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:217
        // 3. GuidanceResponse.module[x]
        public ElementDefinitionInfo Element_Module;                                                                                        // MakerGen.cs:217
        // 4. GuidanceResponse.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:217
        // 5. GuidanceResponse.subject
        public ElementDefinitionInfo Element_Subject;                                                                                       // MakerGen.cs:217
        // 6. GuidanceResponse.encounter
        public ElementDefinitionInfo Element_Encounter;                                                                                     // MakerGen.cs:217
        // 7. GuidanceResponse.occurrenceDateTime
        public ElementDefinitionInfo Element_OccurrenceDateTime;                                                                            // MakerGen.cs:217
        // 8. GuidanceResponse.performer
        public ElementDefinitionInfo Element_Performer;                                                                                     // MakerGen.cs:217
        // 9. GuidanceResponse.reasonCode
        public ElementDefinitionInfo Element_ReasonCode;                                                                                    // MakerGen.cs:217
        // 10. GuidanceResponse.reasonReference
        public ElementDefinitionInfo Element_ReasonReference;                                                                               // MakerGen.cs:217
        // 11. GuidanceResponse.note
        public ElementDefinitionInfo Element_Note;                                                                                          // MakerGen.cs:217
        // 12. GuidanceResponse.evaluationMessage
        public ElementDefinitionInfo Element_EvaluationMessage;                                                                             // MakerGen.cs:217
        // 13. GuidanceResponse.outputParameters
        public ElementDefinitionInfo Element_OutputParameters;                                                                              // MakerGen.cs:217
        // 14. GuidanceResponse.result
        public ElementDefinitionInfo Element_Result;                                                                                        // MakerGen.cs:217
        // 15. GuidanceResponse.dataRequirement
        public ElementDefinitionInfo Element_DataRequirement;                                                                               // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:388
        {                                                                                                                                   // MakerGen.cs:389
            base.Write(sDef);                                                                                                               // MakerGen.cs:390
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:391
            {                                                                                                                               // MakerGen.cs:392
                Path = "GuidanceResponse",                                                                                                  // MakerGen.cs:393
                ElementId = "GuidanceResponse"                                                                                              // MakerGen.cs:394
            });                                                                                                                             // MakerGen.cs:395
            Element_RequestIdentifier.Write(sDef);                                                                                          // MakerGen.cs:221
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:221
            Element_Module.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_Subject.Write(sDef);                                                                                                    // MakerGen.cs:221
            Element_Encounter.Write(sDef);                                                                                                  // MakerGen.cs:221
            Element_OccurrenceDateTime.Write(sDef);                                                                                         // MakerGen.cs:221
            Element_Performer.Write(sDef);                                                                                                  // MakerGen.cs:221
            Element_ReasonCode.Write(sDef);                                                                                                 // MakerGen.cs:221
            Element_ReasonReference.Write(sDef);                                                                                            // MakerGen.cs:221
            Element_Note.Write(sDef);                                                                                                       // MakerGen.cs:221
            Element_EvaluationMessage.Write(sDef);                                                                                          // MakerGen.cs:221
            Element_OutputParameters.Write(sDef);                                                                                           // MakerGen.cs:221
            Element_Result.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_DataRequirement.Write(sDef);                                                                                            // MakerGen.cs:221
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
        public Resource_GuidanceResponse()                                                                                                  // MakerGen.cs:400
        {                                                                                                                                   // MakerGen.cs:401
            {                                                                                                                               // MakerGen.cs:232
                // 1. GuidanceResponse.requestIdentifier
                this.Element_RequestIdentifier = new ElementDefinitionInfo                                                                  // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_RequestIdentifier",                                                                                     // MakerGen.cs:236
                    Path= "GuidanceResponse.requestIdentifier",                                                                             // MakerGen.cs:237
                    Id = "GuidanceResponse.requestIdentifier",                                                                              // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 2. GuidanceResponse.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:236
                    Path= "GuidanceResponse.identifier",                                                                                    // MakerGen.cs:237
                    Id = "GuidanceResponse.identifier",                                                                                     // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 3. GuidanceResponse.module[x]
                this.Element_Module = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Module",                                                                                                // MakerGen.cs:236
                    Path= "GuidanceResponse.module[x]",                                                                                     // MakerGen.cs:237
                    Id = "GuidanceResponse.module[x]",                                                                                      // MakerGen.cs:238
                    Min = 1,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uri                                                                   // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        },                                                                                                                  // MakerGen.cs:305
                        new FhirKhit.Maker.Common.Primitive.Primitive_Canonical                                                             // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        },                                                                                                                  // MakerGen.cs:305
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 4. GuidanceResponse.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Status",                                                                                                // MakerGen.cs:236
                    Path= "GuidanceResponse.status",                                                                                        // MakerGen.cs:237
                    Id = "GuidanceResponse.status",                                                                                         // MakerGen.cs:238
                    Min = 1,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 5. GuidanceResponse.subject
                this.Element_Subject = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Subject",                                                                                               // MakerGen.cs:236
                    Path= "GuidanceResponse.subject",                                                                                       // MakerGen.cs:237
                    Id = "GuidanceResponse.subject",                                                                                        // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Patient",                                                          // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/Group"                                                             // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 6. GuidanceResponse.encounter
                this.Element_Encounter = new ElementDefinitionInfo                                                                          // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Encounter",                                                                                             // MakerGen.cs:236
                    Path= "GuidanceResponse.encounter",                                                                                     // MakerGen.cs:237
                    Id = "GuidanceResponse.encounter",                                                                                      // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Encounter"                                                         // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 7. GuidanceResponse.occurrenceDateTime
                this.Element_OccurrenceDateTime = new ElementDefinitionInfo                                                                 // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_OccurrenceDateTime",                                                                                    // MakerGen.cs:236
                    Path= "GuidanceResponse.occurrenceDateTime",                                                                            // MakerGen.cs:237
                    Id = "GuidanceResponse.occurrenceDateTime",                                                                             // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 8. GuidanceResponse.performer
                this.Element_Performer = new ElementDefinitionInfo                                                                          // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Performer",                                                                                             // MakerGen.cs:236
                    Path= "GuidanceResponse.performer",                                                                                     // MakerGen.cs:237
                    Id = "GuidanceResponse.performer",                                                                                      // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Device"                                                            // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 9. GuidanceResponse.reasonCode
                this.Element_ReasonCode = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_ReasonCode",                                                                                            // MakerGen.cs:236
                    Path= "GuidanceResponse.reasonCode",                                                                                    // MakerGen.cs:237
                    Id = "GuidanceResponse.reasonCode",                                                                                     // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 10. GuidanceResponse.reasonReference
                this.Element_ReasonReference = new ElementDefinitionInfo                                                                    // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_ReasonReference",                                                                                       // MakerGen.cs:236
                    Path= "GuidanceResponse.reasonReference",                                                                               // MakerGen.cs:237
                    Id = "GuidanceResponse.reasonReference",                                                                                // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Condition",                                                        // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/Observation",                                                      // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",                                                 // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                                 // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 11. GuidanceResponse.note
                this.Element_Note = new ElementDefinitionInfo                                                                               // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Note",                                                                                                  // MakerGen.cs:236
                    Path= "GuidanceResponse.note",                                                                                          // MakerGen.cs:237
                    Id = "GuidanceResponse.note",                                                                                           // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Annotation                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 12. GuidanceResponse.evaluationMessage
                this.Element_EvaluationMessage = new ElementDefinitionInfo                                                                  // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_EvaluationMessage",                                                                                     // MakerGen.cs:236
                    Path= "GuidanceResponse.evaluationMessage",                                                                             // MakerGen.cs:237
                    Id = "GuidanceResponse.evaluationMessage",                                                                              // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/OperationOutcome"                                                  // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 13. GuidanceResponse.outputParameters
                this.Element_OutputParameters = new ElementDefinitionInfo                                                                   // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_OutputParameters",                                                                                      // MakerGen.cs:236
                    Path= "GuidanceResponse.outputParameters",                                                                              // MakerGen.cs:237
                    Id = "GuidanceResponse.outputParameters",                                                                               // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Parameters"                                                        // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 14. GuidanceResponse.result
                this.Element_Result = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Result",                                                                                                // MakerGen.cs:236
                    Path= "GuidanceResponse.result",                                                                                        // MakerGen.cs:237
                    Id = "GuidanceResponse.result",                                                                                         // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/CarePlan",                                                         // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/RequestGroup"                                                      // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 15. GuidanceResponse.dataRequirement
                this.Element_DataRequirement = new ElementDefinitionInfo                                                                    // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_DataRequirement",                                                                                       // MakerGen.cs:236
                    Path= "GuidanceResponse.dataRequirement",                                                                               // MakerGen.cs:237
                    Id = "GuidanceResponse.dataRequirement",                                                                                // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_DataRequirement                                                              // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            this.Name = "GuidanceResponse";                                                                                                 // MakerGen.cs:468
            this.Uri = "http://hl7.org/fhir/StructureDefinition/GuidanceResponse";                                                          // MakerGen.cs:469
        }                                                                                                                                   // MakerGen.cs:403
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:449
