using System;                                                                                                                               // MakerGen.cs:391
using System.Diagnostics;                                                                                                                   // MakerGen.cs:392
using System.IO;                                                                                                                            // MakerGen.cs:393
using System.Linq;                                                                                                                          // MakerGen.cs:394
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:396
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:397
{                                                                                                                                           // MakerGen.cs:398
    #region Json                                                                                                                            // MakerGen.cs:399
    #if NEVER                                                                                                                               // MakerGen.cs:400
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
    #endregion                                                                                                                              // MakerGen.cs:403
    /// <summary>
    /// Fhir resource 'TestReport'
    /// </summary>
    // 0. TestReport
    public class TestReport : FhirKhit.Maker.Common.Resource.ResourceBase                                                                   // MakerGen.cs:352
    {                                                                                                                                       // MakerGen.cs:353
        // 9. TestReport.participant
        public class Type_Participant : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 10. TestReport.participant.type
            public MakerElementInstance Element_Type;                                                                                       // MakerGen.cs:232
            // 11. TestReport.participant.uri
            public MakerElementInstance Element_Uri;                                                                                        // MakerGen.cs:232
            // 12. TestReport.participant.display
            public MakerElementInstance Element_Display;                                                                                    // MakerGen.cs:232
            public Type_Participant()                                                                                                       // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 10. TestReport.participant.type
                    this.Element_Type = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Type",                                                                                              // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Code()                                                                      // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 11. TestReport.participant.uri
                    this.Element_Uri = new MakerElementInstance                                                                             // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Uri",                                                                                               // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Uri()                                                                       // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 12. TestReport.participant.display
                    this.Element_Display = new MakerElementInstance                                                                         // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Display",                                                                                           // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 13. TestReport.setup
        public class Type_Setup : FhirKhit.Maker.Common.Complex.ComplexBase                                                                 // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 14. TestReport.setup.action
            public class Type_Action : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:352
            {                                                                                                                               // MakerGen.cs:353
                // 15. TestReport.setup.action.operation
                public class Type_Operation : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:352
                {                                                                                                                           // MakerGen.cs:353
                    // 16. TestReport.setup.action.operation.result
                    public MakerElementInstance Element_Result;                                                                             // MakerGen.cs:232
                    // 17. TestReport.setup.action.operation.message
                    public MakerElementInstance Element_Message;                                                                            // MakerGen.cs:232
                    // 18. TestReport.setup.action.operation.detail
                    public MakerElementInstance Element_Detail;                                                                             // MakerGen.cs:232
                    public Type_Operation()                                                                                                 // MakerGen.cs:361
                    {                                                                                                                       // MakerGen.cs:362
                        {                                                                                                                   // MakerGen.cs:243
                            // 16. TestReport.setup.action.operation.result
                            this.Element_Result = new MakerElementInstance                                                                  // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Result",                                                                                    // MakerGen.cs:247
                                Min = 1,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBaseType[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.Code()                                                              // MakerGen.cs:286
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 17. TestReport.setup.action.operation.message
                            this.Element_Message = new MakerElementInstance                                                                 // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Message",                                                                                   // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBaseType[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.Markdown()                                                          // MakerGen.cs:286
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 18. TestReport.setup.action.operation.detail
                            this.Element_Detail = new MakerElementInstance                                                                  // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Detail",                                                                                    // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBaseType[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.Uri()                                                               // MakerGen.cs:286
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                    }                                                                                                                       // MakerGen.cs:373
                }                                                                                                                           // MakerGen.cs:357
                // 19. TestReport.setup.action.assert
                public class Type_Assert : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:352
                {                                                                                                                           // MakerGen.cs:353
                    // 20. TestReport.setup.action.assert.result
                    public MakerElementInstance Element_Result;                                                                             // MakerGen.cs:232
                    // 21. TestReport.setup.action.assert.message
                    public MakerElementInstance Element_Message;                                                                            // MakerGen.cs:232
                    // 22. TestReport.setup.action.assert.detail
                    public MakerElementInstance Element_Detail;                                                                             // MakerGen.cs:232
                    public Type_Assert()                                                                                                    // MakerGen.cs:361
                    {                                                                                                                       // MakerGen.cs:362
                        {                                                                                                                   // MakerGen.cs:243
                            // 20. TestReport.setup.action.assert.result
                            this.Element_Result = new MakerElementInstance                                                                  // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Result",                                                                                    // MakerGen.cs:247
                                Min = 1,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBaseType[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.Code()                                                              // MakerGen.cs:286
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 21. TestReport.setup.action.assert.message
                            this.Element_Message = new MakerElementInstance                                                                 // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Message",                                                                                   // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBaseType[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.Markdown()                                                          // MakerGen.cs:286
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 22. TestReport.setup.action.assert.detail
                            this.Element_Detail = new MakerElementInstance                                                                  // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Detail",                                                                                    // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBaseType[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.String()                                                            // MakerGen.cs:286
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                    }                                                                                                                       // MakerGen.cs:373
                }                                                                                                                           // MakerGen.cs:357
                public Type_Action()                                                                                                        // MakerGen.cs:361
                {                                                                                                                           // MakerGen.cs:362
                }                                                                                                                           // MakerGen.cs:373
            }                                                                                                                               // MakerGen.cs:357
            public Type_Setup()                                                                                                             // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 23. TestReport.test
        public class Type_Test : FhirKhit.Maker.Common.Complex.ComplexBase                                                                  // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 26. TestReport.test.action
            public class Type_Action : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:352
            {                                                                                                                               // MakerGen.cs:353
                // 27. TestReport.test.action.operation
                public MakerElementInstance Element_Operation;                                                                              // MakerGen.cs:232
                // 28. TestReport.test.action.assert
                public MakerElementInstance Element_Assert;                                                                                 // MakerGen.cs:232
                public Type_Action()                                                                                                        // MakerGen.cs:361
                {                                                                                                                           // MakerGen.cs:362
                    {                                                                                                                       // MakerGen.cs:243
                        // 27. TestReport.test.action.operation
                        this.Element_Operation = new MakerElementInstance                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Operation",                                                                                     // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 28. TestReport.test.action.assert
                        this.Element_Assert = new MakerElementInstance                                                                      // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Assert",                                                                                        // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                }                                                                                                                           // MakerGen.cs:373
            }                                                                                                                               // MakerGen.cs:357
            // 24. TestReport.test.name
            public MakerElementInstance Element_Name;                                                                                       // MakerGen.cs:232
            // 25. TestReport.test.description
            public MakerElementInstance Element_Description;                                                                                // MakerGen.cs:232
            public Type_Test()                                                                                                              // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 24. TestReport.test.name
                    this.Element_Name = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Name",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 25. TestReport.test.description
                    this.Element_Description = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Description",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 29. TestReport.teardown
        public class Type_Teardown : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 30. TestReport.teardown.action
            public class Type_Action : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:352
            {                                                                                                                               // MakerGen.cs:353
                // 31. TestReport.teardown.action.operation
                public MakerElementInstance Element_Operation;                                                                              // MakerGen.cs:232
                public Type_Action()                                                                                                        // MakerGen.cs:361
                {                                                                                                                           // MakerGen.cs:362
                    {                                                                                                                       // MakerGen.cs:243
                        // 31. TestReport.teardown.action.operation
                        this.Element_Operation = new MakerElementInstance                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Operation",                                                                                     // MakerGen.cs:247
                            Min = 1,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                }                                                                                                                           // MakerGen.cs:373
            }                                                                                                                               // MakerGen.cs:357
            public Type_Teardown()                                                                                                          // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 1. TestReport.identifier
        public MakerElementInstance Element_Identifier;                                                                                     // MakerGen.cs:232
        // 2. TestReport.name
        public MakerElementInstance Element_Name;                                                                                           // MakerGen.cs:232
        // 3. TestReport.status
        public MakerElementInstance Element_Status;                                                                                         // MakerGen.cs:232
        // 4. TestReport.testScript
        public MakerElementInstance Element_TestScript;                                                                                     // MakerGen.cs:232
        // 5. TestReport.result
        public MakerElementInstance Element_Result;                                                                                         // MakerGen.cs:232
        // 6. TestReport.score
        public MakerElementInstance Element_Score;                                                                                          // MakerGen.cs:232
        // 7. TestReport.tester
        public MakerElementInstance Element_Tester;                                                                                         // MakerGen.cs:232
        // 8. TestReport.issued
        public MakerElementInstance Element_Issued;                                                                                         // MakerGen.cs:232
        public TestReport()                                                                                                                 // MakerGen.cs:361
        {                                                                                                                                   // MakerGen.cs:362
            {                                                                                                                               // MakerGen.cs:243
                // 1. TestReport.identifier
                this.Element_Identifier = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 2. TestReport.name
                this.Element_Name = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Name",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String()                                                                        // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 3. TestReport.status
                this.Element_Status = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Status",                                                                                                // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code()                                                                          // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 4. TestReport.testScript
                this.Element_TestScript = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_TestScript",                                                                                            // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 5. TestReport.result
                this.Element_Result = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Result",                                                                                                // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code()                                                                          // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 6. TestReport.score
                this.Element_Score = new MakerElementInstance                                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Score",                                                                                                 // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Decimal()                                                                       // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 7. TestReport.tester
                this.Element_Tester = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Tester",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String()                                                                        // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 8. TestReport.issued
                this.Element_Issued = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Issued",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.DateTime()                                                                      // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
        }                                                                                                                                   // MakerGen.cs:373
    }                                                                                                                                       // MakerGen.cs:357
}                                                                                                                                           // MakerGen.cs:408
