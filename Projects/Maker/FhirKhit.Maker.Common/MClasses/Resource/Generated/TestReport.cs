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
      "id": "TestReport",
      "url": "http://hl7.org/fhir/StructureDefinition/TestReport",
      "version": "4.0.0",
      "name": "TestReport",
      "status": "draft",
      "publisher": "Health Level Seven International (FHIR Infrastructure)",
      "description": "A summary of information based on the results of executing a TestScript.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "TestReport",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "TestReport",
            "path": "TestReport",
            "short": "Describes the results of a TestScript execution",
            "definition": "A summary of information based on the results of executing a TestScript.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "TestReport.identifier",
            "path": "TestReport.identifier",
            "short": "External identifier",
            "definition": "Identifier for the TestScript assigned for external purposes outside the context of FHIR.",
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
            "id": "TestReport.name",
            "path": "TestReport.name",
            "short": "Informal name of the executed TestScript",
            "definition": "A free text natural language name identifying the executed TestScript.",
            "comment": "Not expected to be globally unique.",
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
            "id": "TestReport.status",
            "path": "TestReport.status",
            "short": "completed | in-progress | waiting | stopped | entered-in-error",
            "definition": "The current state of this test report.",
            "comment": "The status represents where the execution is currently within the test script execution life cycle.\n\nThis element is labeled as a modifier because the status contains codes that mark the resource as not currently valid.",
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
                  "valueString": "TestReportStatus"
                }
              ],
              "strength": "required",
              "description": "The current status of the test report.",
              "valueSet": "http://hl7.org/fhir/ValueSet/report-status-codes|4.0.0"
            }
          },
          {
            "id": "TestReport.testScript",
            "path": "TestReport.testScript",
            "short": "Reference to the  version-specific TestScript that was executed to produce this TestReport",
            "definition": "Ideally this is an absolute URL that is used to identify the version-specific TestScript that was executed, matching the `TestScript.url`.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/TestScript"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "TestReport.result",
            "path": "TestReport.result",
            "short": "pass | fail | pending",
            "definition": "The overall result from the execution of the TestScript.",
            "comment": "The pass and fail result represents a completed test script execution. The pending result represents a test script execution that has not yet started or is currently in progress.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "TestReportResult"
                }
              ],
              "strength": "required",
              "description": "The reported execution result.",
              "valueSet": "http://hl7.org/fhir/ValueSet/report-result-codes|4.0.0"
            }
          },
          {
            "id": "TestReport.score",
            "path": "TestReport.score",
            "short": "The final score (percentage of tests passed) resulting from the execution of the TestScript",
            "definition": "The final score (percentage of tests passed) resulting from the execution of the TestScript.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ],
            "isSummary": true
          },
          {
            "id": "TestReport.tester",
            "path": "TestReport.tester",
            "short": "Name of the tester producing this report (Organization or individual)",
            "definition": "Name of the tester producing this report (Organization or individual).",
            "comment": "Usually an organization, but may be an individual. This item SHOULD be populated unless the information is available from context.",
            "requirements": "Helps establish the \"authority/credibility\" of the TestReport.  May also allow for contact.",
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
            "id": "TestReport.issued",
            "path": "TestReport.issued",
            "short": "When the TestScript was executed and this TestReport was generated",
            "definition": "When the TestScript was executed and this TestReport was generated.",
            "comment": "Additional specific dates may be added as extensions.",
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
            "id": "TestReport.participant",
            "path": "TestReport.participant",
            "short": "A participant in the test execution, either the execution engine, a client, or a server",
            "definition": "A participant in the test execution, either the execution engine, a client, or a server.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "TestReport.participant.type",
            "path": "TestReport.participant.type",
            "short": "test-engine | client | server",
            "definition": "The type of participant.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "TestReportParticipantType"
                }
              ],
              "strength": "required",
              "description": "The type of participant.",
              "valueSet": "http://hl7.org/fhir/ValueSet/report-participant-type|4.0.0"
            }
          },
          {
            "id": "TestReport.participant.uri",
            "path": "TestReport.participant.uri",
            "short": "The uri of the participant. An absolute URL is preferred",
            "definition": "The uri of the participant. An absolute URL is preferred.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ]
          },
          {
            "id": "TestReport.participant.display",
            "path": "TestReport.participant.display",
            "short": "The display name of the participant",
            "definition": "The display name of the participant.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "TestReport.setup",
            "path": "TestReport.setup",
            "short": "The results of the series of required setup operations before the tests were executed",
            "definition": "The results of the series of required setup operations before the tests were executed.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "TestReport.setup.action",
            "path": "TestReport.setup.action",
            "short": "A setup operation or assert that was executed",
            "definition": "Action would contain either an operation or an assertion.",
            "comment": "An action should contain either an operation or an assertion but not both.  It can contain any number of variables.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "TestReport.setup.action.operation",
            "path": "TestReport.setup.action.operation",
            "short": "The operation to perform",
            "definition": "The operation performed.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "TestReport.setup.action.operation.result",
            "path": "TestReport.setup.action.operation.result",
            "short": "pass | skip | fail | warning | error",
            "definition": "The result of this operation.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "TestReportActionResult"
                }
              ],
              "strength": "required",
              "description": "The results of executing an action.",
              "valueSet": "http://hl7.org/fhir/ValueSet/report-action-result-codes|4.0.0"
            }
          },
          {
            "id": "TestReport.setup.action.operation.message",
            "path": "TestReport.setup.action.operation.message",
            "short": "A message associated with the result",
            "definition": "An explanatory message associated with the result.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "TestReport.setup.action.operation.detail",
            "path": "TestReport.setup.action.operation.detail",
            "short": "A link to further details on the result",
            "definition": "A link to further details on the result.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ]
          },
          {
            "id": "TestReport.setup.action.assert",
            "path": "TestReport.setup.action.assert",
            "short": "The assertion to perform",
            "definition": "The results of the assertion performed on the previous operations.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "TestReport.setup.action.assert.result",
            "path": "TestReport.setup.action.assert.result",
            "short": "pass | skip | fail | warning | error",
            "definition": "The result of this assertion.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "TestReportActionResult"
                }
              ],
              "strength": "required",
              "description": "The results of executing an action.",
              "valueSet": "http://hl7.org/fhir/ValueSet/report-action-result-codes|4.0.0"
            }
          },
          {
            "id": "TestReport.setup.action.assert.message",
            "path": "TestReport.setup.action.assert.message",
            "short": "A message associated with the result",
            "definition": "An explanatory message associated with the result.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "TestReport.setup.action.assert.detail",
            "path": "TestReport.setup.action.assert.detail",
            "short": "A link to further details on the result",
            "definition": "A link to further details on the result.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "TestReport.test",
            "path": "TestReport.test",
            "short": "A test executed from the test script",
            "definition": "A test executed from the test script.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "TestReport.test.name",
            "path": "TestReport.test.name",
            "short": "Tracking/logging name of this test",
            "definition": "The name of this test used for tracking/logging purposes by test engines.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "TestReport.test.description",
            "path": "TestReport.test.description",
            "short": "Tracking/reporting short description of the test",
            "definition": "A short description of the test used by test engines for tracking and reporting purposes.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "TestReport.test.action",
            "path": "TestReport.test.action",
            "short": "A test operation or assert that was performed",
            "definition": "Action would contain either an operation or an assertion.",
            "comment": "An action should contain either an operation or an assertion but not both.  It can contain any number of variables.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "TestReport.test.action.operation",
            "path": "TestReport.test.action.operation",
            "short": "The operation performed",
            "definition": "An operation would involve a REST request to a server.",
            "min": 0,
            "max": "1",
            "contentReference": "#TestReport.setup.action.operation"
          },
          {
            "id": "TestReport.test.action.assert",
            "path": "TestReport.test.action.assert",
            "short": "The assertion performed",
            "definition": "The results of the assertion performed on the previous operations.",
            "min": 0,
            "max": "1",
            "contentReference": "#TestReport.setup.action.assert"
          },
          {
            "id": "TestReport.teardown",
            "path": "TestReport.teardown",
            "short": "The results of running the series of required clean up steps",
            "definition": "The results of the series of operations required to clean up after all the tests were executed (successfully or otherwise).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "TestReport.teardown.action",
            "path": "TestReport.teardown.action",
            "short": "One or more teardown operations performed",
            "definition": "The teardown action will only contain an operation.",
            "comment": "An action should contain either an operation or an assertion but not both.  It can contain any number of variables.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "TestReport.teardown.action.operation",
            "path": "TestReport.teardown.action.operation",
            "short": "The teardown operation performed",
            "definition": "An operation would involve a REST request to a server.",
            "min": 1,
            "max": "1",
            "contentReference": "#TestReport.setup.action.operation"
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:461
    /// <summary>
    /// Fhir resource 'TestReport'
    /// </summary>
    // 0. TestReport
    public class TestReport : FhirKhit.Maker.Common.Resource.ResourceBase                                                                   // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        public class TestReport_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                      // MakerGen.cs:385
        {                                                                                                                                   // MakerGen.cs:386
            // 9. TestReport.participant
            public class Type_Participant : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_Participant_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                        // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 10. TestReport.participant.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:216
                    // 11. TestReport.participant.uri
                    public ElementDefinitionInfo Uri;                                                                                       // MakerGen.cs:216
                    // 12. TestReport.participant.display
                    public ElementDefinitionInfo Display;                                                                                   // MakerGen.cs:216
                    public Type_Participant_Elements()                                                                                      // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 10. TestReport.participant.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Type",                                                                                              // MakerGen.cs:235
                                Path= "TestReport.participant.type",                                                                        // MakerGen.cs:236
                                Id = "TestReport.participant.type",                                                                         // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 11. TestReport.participant.uri
                            this.Uri = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Uri",                                                                                               // MakerGen.cs:235
                                Path= "TestReport.participant.uri",                                                                         // MakerGen.cs:236
                                Id = "TestReport.participant.uri",                                                                          // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Uri                                                                 // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 12. TestReport.participant.display
                            this.Display = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Display",                                                                                           // MakerGen.cs:235
                                Path= "TestReport.participant.display",                                                                     // MakerGen.cs:236
                                Id = "TestReport.participant.display",                                                                      // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Uri.Write(sDef);                                                                                                    // MakerGen.cs:220
                        Display.Write(sDef);                                                                                                // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_Participant_Elements Elements { get; }                                                                          // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_Participant()                                                                                                   // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_Participant_Elements();                                                                        // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 13. TestReport.setup
            public class Type_Setup : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_Setup_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                              // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 14. TestReport.setup.action
                    public class Type_Action : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        public class Type_Action_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                     // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:386
                            // 15. TestReport.setup.action.operation
                            public class Type_Operation : FhirKhit.Maker.Common.Complex.ComplexBase                                         // MakerGen.cs:383
                            {                                                                                                               // MakerGen.cs:384
                                public class Type_Operation_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                          // MakerGen.cs:385
                                {                                                                                                           // MakerGen.cs:386
                                    // 16. TestReport.setup.action.operation.result
                                    public ElementDefinitionInfo Result;                                                                    // MakerGen.cs:216
                                    // 17. TestReport.setup.action.operation.message
                                    public ElementDefinitionInfo Message;                                                                   // MakerGen.cs:216
                                    // 18. TestReport.setup.action.operation.detail
                                    public ElementDefinitionInfo Detail;                                                                    // MakerGen.cs:216
                                    public Type_Operation_Elements()                                                                        // MakerGen.cs:407
                                    {                                                                                                       // MakerGen.cs:408
                                        {                                                                                                   // MakerGen.cs:231
                                            // 16. TestReport.setup.action.operation.result
                                            this.Result = new ElementDefinitionInfo                                                         // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Result",                                                                            // MakerGen.cs:235
                                                Path= "TestReport.setup.action.operation.result",                                           // MakerGen.cs:236
                                                Id = "TestReport.setup.action.operation.result",                                            // MakerGen.cs:237
                                                Min = 1,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.Code                                                // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 17. TestReport.setup.action.operation.message
                                            this.Message = new ElementDefinitionInfo                                                        // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Message",                                                                           // MakerGen.cs:235
                                                Path= "TestReport.setup.action.operation.message",                                          // MakerGen.cs:236
                                                Id = "TestReport.setup.action.operation.message",                                           // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.Markdown                                            // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 18. TestReport.setup.action.operation.detail
                                            this.Detail = new ElementDefinitionInfo                                                         // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Detail",                                                                            // MakerGen.cs:235
                                                Path= "TestReport.setup.action.operation.detail",                                           // MakerGen.cs:236
                                                Id = "TestReport.setup.action.operation.detail",                                            // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.Uri                                                 // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                    }                                                                                                       // MakerGen.cs:427
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:412
                                    {                                                                                                       // MakerGen.cs:413
                                        base.Write(sDef);                                                                                   // MakerGen.cs:414
                                        Result.Write(sDef);                                                                                 // MakerGen.cs:220
                                        Message.Write(sDef);                                                                                // MakerGen.cs:220
                                        Detail.Write(sDef);                                                                                 // MakerGen.cs:220
                                    }                                                                                                       // MakerGen.cs:431
                                }                                                                                                           // MakerGen.cs:391
                                public Type_Operation_Elements Elements { get; }                                                            // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                                public Type_Operation()                                                                                     // MakerGen.cs:394
                                {                                                                                                           // MakerGen.cs:395
                                    this.Elements = new Type_Operation_Elements();                                                          // MakerGen.cs:396
                                }                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:399
                                {                                                                                                           // MakerGen.cs:400
                                    this.Elements.Write(sDef);                                                                              // MakerGen.cs:401
                                }                                                                                                           // MakerGen.cs:402
                            }                                                                                                               // MakerGen.cs:403
                            // 19. TestReport.setup.action.assert
                            public class Type_Assert : FhirKhit.Maker.Common.Complex.ComplexBase                                            // MakerGen.cs:383
                            {                                                                                                               // MakerGen.cs:384
                                public class Type_Assert_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                             // MakerGen.cs:385
                                {                                                                                                           // MakerGen.cs:386
                                    // 20. TestReport.setup.action.assert.result
                                    public ElementDefinitionInfo Result;                                                                    // MakerGen.cs:216
                                    // 21. TestReport.setup.action.assert.message
                                    public ElementDefinitionInfo Message;                                                                   // MakerGen.cs:216
                                    // 22. TestReport.setup.action.assert.detail
                                    public ElementDefinitionInfo Detail;                                                                    // MakerGen.cs:216
                                    public Type_Assert_Elements()                                                                           // MakerGen.cs:407
                                    {                                                                                                       // MakerGen.cs:408
                                        {                                                                                                   // MakerGen.cs:231
                                            // 20. TestReport.setup.action.assert.result
                                            this.Result = new ElementDefinitionInfo                                                         // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Result",                                                                            // MakerGen.cs:235
                                                Path= "TestReport.setup.action.assert.result",                                              // MakerGen.cs:236
                                                Id = "TestReport.setup.action.assert.result",                                               // MakerGen.cs:237
                                                Min = 1,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.Code                                                // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 21. TestReport.setup.action.assert.message
                                            this.Message = new ElementDefinitionInfo                                                        // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Message",                                                                           // MakerGen.cs:235
                                                Path= "TestReport.setup.action.assert.message",                                             // MakerGen.cs:236
                                                Id = "TestReport.setup.action.assert.message",                                              // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.Markdown                                            // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 22. TestReport.setup.action.assert.detail
                                            this.Detail = new ElementDefinitionInfo                                                         // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Detail",                                                                            // MakerGen.cs:235
                                                Path= "TestReport.setup.action.assert.detail",                                              // MakerGen.cs:236
                                                Id = "TestReport.setup.action.assert.detail",                                               // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.String                                              // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                    }                                                                                                       // MakerGen.cs:427
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:412
                                    {                                                                                                       // MakerGen.cs:413
                                        base.Write(sDef);                                                                                   // MakerGen.cs:414
                                        Result.Write(sDef);                                                                                 // MakerGen.cs:220
                                        Message.Write(sDef);                                                                                // MakerGen.cs:220
                                        Detail.Write(sDef);                                                                                 // MakerGen.cs:220
                                    }                                                                                                       // MakerGen.cs:431
                                }                                                                                                           // MakerGen.cs:391
                                public Type_Assert_Elements Elements { get; }                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                                public Type_Assert()                                                                                        // MakerGen.cs:394
                                {                                                                                                           // MakerGen.cs:395
                                    this.Elements = new Type_Assert_Elements();                                                             // MakerGen.cs:396
                                }                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:399
                                {                                                                                                           // MakerGen.cs:400
                                    this.Elements.Write(sDef);                                                                              // MakerGen.cs:401
                                }                                                                                                           // MakerGen.cs:402
                            }                                                                                                               // MakerGen.cs:403
                            // 15. TestReport.setup.action.operation
                            public ElementDefinitionInfo Operation;                                                                         // MakerGen.cs:216
                            // 19. TestReport.setup.action.assert
                            public ElementDefinitionInfo Assert;                                                                            // MakerGen.cs:216
                            public Type_Action_Elements()                                                                                   // MakerGen.cs:407
                            {                                                                                                               // MakerGen.cs:408
                                {                                                                                                           // MakerGen.cs:231
                                    // 15. TestReport.setup.action.operation
                                    this.Operation = new ElementDefinitionInfo                                                              // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Operation",                                                                                 // MakerGen.cs:235
                                        Path= "TestReport.setup.action.operation",                                                          // MakerGen.cs:236
                                        Id = "TestReport.setup.action.operation",                                                           // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new Type_Operation                                                                              // MakerGen.cs:259
                                            {                                                                                               // MakerGen.cs:260
                                            }                                                                                               // MakerGen.cs:261
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 19. TestReport.setup.action.assert
                                    this.Assert = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Assert",                                                                                    // MakerGen.cs:235
                                        Path= "TestReport.setup.action.assert",                                                             // MakerGen.cs:236
                                        Id = "TestReport.setup.action.assert",                                                              // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new Type_Assert                                                                                 // MakerGen.cs:259
                                            {                                                                                               // MakerGen.cs:260
                                            }                                                                                               // MakerGen.cs:261
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:427
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:412
                            {                                                                                                               // MakerGen.cs:413
                                base.Write(sDef);                                                                                           // MakerGen.cs:414
                                Operation.Write(sDef);                                                                                      // MakerGen.cs:220
                                Assert.Write(sDef);                                                                                         // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:431
                        }                                                                                                                   // MakerGen.cs:391
                        public Type_Action_Elements Elements { get; }                                                                       // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                        public Type_Action()                                                                                                // MakerGen.cs:394
                        {                                                                                                                   // MakerGen.cs:395
                            this.Elements = new Type_Action_Elements();                                                                     // MakerGen.cs:396
                        }                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:399
                        {                                                                                                                   // MakerGen.cs:400
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:401
                        }                                                                                                                   // MakerGen.cs:402
                    }                                                                                                                       // MakerGen.cs:403
                    // 14. TestReport.setup.action
                    public ElementDefinitionInfo Action;                                                                                    // MakerGen.cs:216
                    public Type_Setup_Elements()                                                                                            // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 14. TestReport.setup.action
                            this.Action = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Action",                                                                                            // MakerGen.cs:235
                                Path= "TestReport.setup.action",                                                                            // MakerGen.cs:236
                                Id = "TestReport.setup.action",                                                                             // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_Action                                                                                         // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Action.Write(sDef);                                                                                                 // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_Setup_Elements Elements { get; }                                                                                // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_Setup()                                                                                                         // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_Setup_Elements();                                                                              // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 23. TestReport.test
            public class Type_Test : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_Test_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                               // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 26. TestReport.test.action
                    public class Type_Action : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        public class Type_Action_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                     // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:386
                            // 27. TestReport.test.action.operation
                            public ElementDefinitionInfo Operation;                                                                         // MakerGen.cs:216
                            // 28. TestReport.test.action.assert
                            public ElementDefinitionInfo Assert;                                                                            // MakerGen.cs:216
                            public Type_Action_Elements()                                                                                   // MakerGen.cs:407
                            {                                                                                                               // MakerGen.cs:408
                                {                                                                                                           // MakerGen.cs:231
                                    // 27. TestReport.test.action.operation
                                    this.Operation = new ElementDefinitionInfo                                                              // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Operation",                                                                                 // MakerGen.cs:235
                                        Path= "TestReport.test.action.operation",                                                           // MakerGen.cs:236
                                        Id = "TestReport.test.action.operation",                                                            // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 28. TestReport.test.action.assert
                                    this.Assert = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Assert",                                                                                    // MakerGen.cs:235
                                        Path= "TestReport.test.action.assert",                                                              // MakerGen.cs:236
                                        Id = "TestReport.test.action.assert",                                                               // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:427
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:412
                            {                                                                                                               // MakerGen.cs:413
                                base.Write(sDef);                                                                                           // MakerGen.cs:414
                                Operation.Write(sDef);                                                                                      // MakerGen.cs:220
                                Assert.Write(sDef);                                                                                         // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:431
                        }                                                                                                                   // MakerGen.cs:391
                        public Type_Action_Elements Elements { get; }                                                                       // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                        public Type_Action()                                                                                                // MakerGen.cs:394
                        {                                                                                                                   // MakerGen.cs:395
                            this.Elements = new Type_Action_Elements();                                                                     // MakerGen.cs:396
                        }                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:399
                        {                                                                                                                   // MakerGen.cs:400
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:401
                        }                                                                                                                   // MakerGen.cs:402
                    }                                                                                                                       // MakerGen.cs:403
                    // 24. TestReport.test.name
                    public ElementDefinitionInfo Name;                                                                                      // MakerGen.cs:216
                    // 25. TestReport.test.description
                    public ElementDefinitionInfo Description;                                                                               // MakerGen.cs:216
                    // 26. TestReport.test.action
                    public ElementDefinitionInfo Action;                                                                                    // MakerGen.cs:216
                    public Type_Test_Elements()                                                                                             // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 24. TestReport.test.name
                            this.Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Name",                                                                                              // MakerGen.cs:235
                                Path= "TestReport.test.name",                                                                               // MakerGen.cs:236
                                Id = "TestReport.test.name",                                                                                // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 25. TestReport.test.description
                            this.Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Description",                                                                                       // MakerGen.cs:235
                                Path= "TestReport.test.description",                                                                        // MakerGen.cs:236
                                Id = "TestReport.test.description",                                                                         // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 26. TestReport.test.action
                            this.Action = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Action",                                                                                            // MakerGen.cs:235
                                Path= "TestReport.test.action",                                                                             // MakerGen.cs:236
                                Id = "TestReport.test.action",                                                                              // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_Action                                                                                         // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Name.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Description.Write(sDef);                                                                                            // MakerGen.cs:220
                        Action.Write(sDef);                                                                                                 // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_Test_Elements Elements { get; }                                                                                 // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_Test()                                                                                                          // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_Test_Elements();                                                                               // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 29. TestReport.teardown
            public class Type_Teardown : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_Teardown_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                           // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 30. TestReport.teardown.action
                    public class Type_Action : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        public class Type_Action_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                     // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:386
                            // 31. TestReport.teardown.action.operation
                            public ElementDefinitionInfo Operation;                                                                         // MakerGen.cs:216
                            public Type_Action_Elements()                                                                                   // MakerGen.cs:407
                            {                                                                                                               // MakerGen.cs:408
                                {                                                                                                           // MakerGen.cs:231
                                    // 31. TestReport.teardown.action.operation
                                    this.Operation = new ElementDefinitionInfo                                                              // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Operation",                                                                                 // MakerGen.cs:235
                                        Path= "TestReport.teardown.action.operation",                                                       // MakerGen.cs:236
                                        Id = "TestReport.teardown.action.operation",                                                        // MakerGen.cs:237
                                        Min = 1,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:427
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:412
                            {                                                                                                               // MakerGen.cs:413
                                base.Write(sDef);                                                                                           // MakerGen.cs:414
                                Operation.Write(sDef);                                                                                      // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:431
                        }                                                                                                                   // MakerGen.cs:391
                        public Type_Action_Elements Elements { get; }                                                                       // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                        public Type_Action()                                                                                                // MakerGen.cs:394
                        {                                                                                                                   // MakerGen.cs:395
                            this.Elements = new Type_Action_Elements();                                                                     // MakerGen.cs:396
                        }                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:399
                        {                                                                                                                   // MakerGen.cs:400
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:401
                        }                                                                                                                   // MakerGen.cs:402
                    }                                                                                                                       // MakerGen.cs:403
                    // 30. TestReport.teardown.action
                    public ElementDefinitionInfo Action;                                                                                    // MakerGen.cs:216
                    public Type_Teardown_Elements()                                                                                         // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 30. TestReport.teardown.action
                            this.Action = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Action",                                                                                            // MakerGen.cs:235
                                Path= "TestReport.teardown.action",                                                                         // MakerGen.cs:236
                                Id = "TestReport.teardown.action",                                                                          // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_Action                                                                                         // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Action.Write(sDef);                                                                                                 // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_Teardown_Elements Elements { get; }                                                                             // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_Teardown()                                                                                                      // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_Teardown_Elements();                                                                           // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 1. TestReport.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 2. TestReport.name
            public ElementDefinitionInfo Name;                                                                                              // MakerGen.cs:216
            // 3. TestReport.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:216
            // 4. TestReport.testScript
            public ElementDefinitionInfo TestScript;                                                                                        // MakerGen.cs:216
            // 5. TestReport.result
            public ElementDefinitionInfo Result;                                                                                            // MakerGen.cs:216
            // 6. TestReport.score
            public ElementDefinitionInfo Score;                                                                                             // MakerGen.cs:216
            // 7. TestReport.tester
            public ElementDefinitionInfo Tester;                                                                                            // MakerGen.cs:216
            // 8. TestReport.issued
            public ElementDefinitionInfo Issued;                                                                                            // MakerGen.cs:216
            // 9. TestReport.participant
            public ElementDefinitionInfo Participant;                                                                                       // MakerGen.cs:216
            // 13. TestReport.setup
            public ElementDefinitionInfo Setup;                                                                                             // MakerGen.cs:216
            // 23. TestReport.test
            public ElementDefinitionInfo Test;                                                                                              // MakerGen.cs:216
            // 29. TestReport.teardown
            public ElementDefinitionInfo Teardown;                                                                                          // MakerGen.cs:216
            public TestReport_Elements()                                                                                                    // MakerGen.cs:407
            {                                                                                                                               // MakerGen.cs:408
                {                                                                                                                           // MakerGen.cs:231
                    // 1. TestReport.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "TestReport.identifier",                                                                                      // MakerGen.cs:236
                        Id = "TestReport.identifier",                                                                                       // MakerGen.cs:237
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
                    // 2. TestReport.name
                    this.Name = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Name",                                                                                                      // MakerGen.cs:235
                        Path= "TestReport.name",                                                                                            // MakerGen.cs:236
                        Id = "TestReport.name",                                                                                             // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 3. TestReport.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Status",                                                                                                    // MakerGen.cs:235
                        Path= "TestReport.status",                                                                                          // MakerGen.cs:236
                        Id = "TestReport.status",                                                                                           // MakerGen.cs:237
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
                    // 4. TestReport.testScript
                    this.TestScript = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "TestScript",                                                                                                // MakerGen.cs:235
                        Path= "TestReport.testScript",                                                                                      // MakerGen.cs:236
                        Id = "TestReport.testScript",                                                                                       // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/TestScript"                                                    // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 5. TestReport.result
                    this.Result = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Result",                                                                                                    // MakerGen.cs:235
                        Path= "TestReport.result",                                                                                          // MakerGen.cs:236
                        Id = "TestReport.result",                                                                                           // MakerGen.cs:237
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
                    // 6. TestReport.score
                    this.Score = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Score",                                                                                                     // MakerGen.cs:235
                        Path= "TestReport.score",                                                                                           // MakerGen.cs:236
                        Id = "TestReport.score",                                                                                            // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Decimal                                                                     // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 7. TestReport.tester
                    this.Tester = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Tester",                                                                                                    // MakerGen.cs:235
                        Path= "TestReport.tester",                                                                                          // MakerGen.cs:236
                        Id = "TestReport.tester",                                                                                           // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 8. TestReport.issued
                    this.Issued = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Issued",                                                                                                    // MakerGen.cs:235
                        Path= "TestReport.issued",                                                                                          // MakerGen.cs:236
                        Id = "TestReport.issued",                                                                                           // MakerGen.cs:237
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
                    // 9. TestReport.participant
                    this.Participant = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Participant",                                                                                               // MakerGen.cs:235
                        Path= "TestReport.participant",                                                                                     // MakerGen.cs:236
                        Id = "TestReport.participant",                                                                                      // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Participant                                                                                            // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 13. TestReport.setup
                    this.Setup = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Setup",                                                                                                     // MakerGen.cs:235
                        Path= "TestReport.setup",                                                                                           // MakerGen.cs:236
                        Id = "TestReport.setup",                                                                                            // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Setup                                                                                                  // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 23. TestReport.test
                    this.Test = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Test",                                                                                                      // MakerGen.cs:235
                        Path= "TestReport.test",                                                                                            // MakerGen.cs:236
                        Id = "TestReport.test",                                                                                             // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Test                                                                                                   // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 29. TestReport.teardown
                    this.Teardown = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Teardown",                                                                                                  // MakerGen.cs:235
                        Path= "TestReport.teardown",                                                                                        // MakerGen.cs:236
                        Id = "TestReport.teardown",                                                                                         // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Teardown                                                                                               // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:427
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:412
            {                                                                                                                               // MakerGen.cs:413
                base.Write(sDef);                                                                                                           // MakerGen.cs:414
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:220
                Name.Write(sDef);                                                                                                           // MakerGen.cs:220
                Status.Write(sDef);                                                                                                         // MakerGen.cs:220
                TestScript.Write(sDef);                                                                                                     // MakerGen.cs:220
                Result.Write(sDef);                                                                                                         // MakerGen.cs:220
                Score.Write(sDef);                                                                                                          // MakerGen.cs:220
                Tester.Write(sDef);                                                                                                         // MakerGen.cs:220
                Issued.Write(sDef);                                                                                                         // MakerGen.cs:220
                Participant.Write(sDef);                                                                                                    // MakerGen.cs:220
                Setup.Write(sDef);                                                                                                          // MakerGen.cs:220
                Test.Write(sDef);                                                                                                           // MakerGen.cs:220
                Teardown.Write(sDef);                                                                                                       // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:431
        }                                                                                                                                   // MakerGen.cs:391
        public TestReport_Elements Elements { get; }                                                                                        // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
        public TestReport()                                                                                                                 // MakerGen.cs:394
        {                                                                                                                                   // MakerGen.cs:395
            this.Elements = new TestReport_Elements();                                                                                      // MakerGen.cs:396
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:399
        {                                                                                                                                   // MakerGen.cs:400
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:401
        }                                                                                                                                   // MakerGen.cs:402
    }                                                                                                                                       // MakerGen.cs:403
}                                                                                                                                           // MakerGen.cs:466
