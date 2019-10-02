using System;                                                                                                                               // MakerGen.cs:435
using System.Diagnostics;                                                                                                                   // MakerGen.cs:436
using System.IO;                                                                                                                            // MakerGen.cs:437
using System.Linq;                                                                                                                          // MakerGen.cs:438
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:439
                                                                                                                                            // MakerGen.cs:440
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:441
{                                                                                                                                           // MakerGen.cs:442
    #region Json                                                                                                                            // MakerGen.cs:443
    #if NEVER                                                                                                                               // MakerGen.cs:444
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
    #endregion                                                                                                                              // MakerGen.cs:447
    /// <summary>
    /// Fhir resource 'TestReport'
    /// </summary>
    // 0. TestReport
    public class Resource_TestReport : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                               // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        // 9. TestReport.participant
        public class Type_Participant : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 10. TestReport.participant.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:219
            // 11. TestReport.participant.uri
            public ElementDefinitionInfo Element_Uri;                                                                                       // MakerGen.cs:219
            // 12. TestReport.participant.display
            public ElementDefinitionInfo Element_Display;                                                                                   // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "TestReport.participant",                                                                                        // MakerGen.cs:395
                    ElementId = "TestReport.participant"                                                                                    // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:223
                Element_Uri.Write(sDef);                                                                                                    // MakerGen.cs:223
                Element_Display.Write(sDef);                                                                                                // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Participant()                                                                                                       // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 10. TestReport.participant.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Type",                                                                                              // MakerGen.cs:238
                        Path= "TestReport.participant.type",                                                                                // MakerGen.cs:239
                        Id = "TestReport.participant.type",                                                                                 // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                              // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 11. TestReport.participant.uri
                    this.Element_Uri = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Uri",                                                                                               // MakerGen.cs:238
                        Path= "TestReport.participant.uri",                                                                                 // MakerGen.cs:239
                        Id = "TestReport.participant.uri",                                                                                  // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Uri                                                               // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 12. TestReport.participant.display
                    this.Element_Display = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Display",                                                                                           // MakerGen.cs:238
                        Path= "TestReport.participant.display",                                                                             // MakerGen.cs:239
                        Id = "TestReport.participant.display",                                                                              // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 13. TestReport.setup
        public class Type_Setup : FhirKhit.Maker.Common.Complex.ComplexBase                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 14. TestReport.setup.action
            public class Type_Action : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                // 15. TestReport.setup.action.operation
                public class Type_Operation : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:383
                {                                                                                                                           // MakerGen.cs:384
                    // 16. TestReport.setup.action.operation.result
                    public ElementDefinitionInfo Element_Result;                                                                            // MakerGen.cs:219
                    // 17. TestReport.setup.action.operation.message
                    public ElementDefinitionInfo Element_Message;                                                                           // MakerGen.cs:219
                    // 18. TestReport.setup.action.operation.detail
                    public ElementDefinitionInfo Element_Detail;                                                                            // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                  // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:394
                            Path = "TestReport.setup.action.operation",                                                                     // MakerGen.cs:395
                            ElementId = "TestReport.setup.action.operation"                                                                 // MakerGen.cs:396
                        });                                                                                                                 // MakerGen.cs:397
                        Element_Result.Write(sDef);                                                                                         // MakerGen.cs:223
                        Element_Message.Write(sDef);                                                                                        // MakerGen.cs:223
                        Element_Detail.Write(sDef);                                                                                         // MakerGen.cs:223
                    }                                                                                                                       // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
                    public Type_Operation()                                                                                                 // MakerGen.cs:402
                    {                                                                                                                       // MakerGen.cs:403
                        {                                                                                                                   // MakerGen.cs:234
                            // 16. TestReport.setup.action.operation.result
                            this.Element_Result = new ElementDefinitionInfo                                                                 // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                Name = "Element_Result",                                                                                    // MakerGen.cs:238
                                Path= "TestReport.setup.action.operation.result",                                                           // MakerGen.cs:239
                                Id = "TestReport.setup.action.operation.result",                                                            // MakerGen.cs:240
                                Min = 1,                                                                                                    // MakerGen.cs:241
                                Max = 1,                                                                                                    // MakerGen.cs:242
                                Types = new BaseType[]                                                                                      // MakerGen.cs:243
                                {                                                                                                           // MakerGen.cs:244
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                      // MakerGen.cs:303
                                    {                                                                                                       // MakerGen.cs:304
                                    }                                                                                                       // MakerGen.cs:307
                                }                                                                                                           // MakerGen.cs:246
                            };                                                                                                              // MakerGen.cs:247
                        }                                                                                                                   // MakerGen.cs:248
                        {                                                                                                                   // MakerGen.cs:234
                            // 17. TestReport.setup.action.operation.message
                            this.Element_Message = new ElementDefinitionInfo                                                                // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                Name = "Element_Message",                                                                                   // MakerGen.cs:238
                                Path= "TestReport.setup.action.operation.message",                                                          // MakerGen.cs:239
                                Id = "TestReport.setup.action.operation.message",                                                           // MakerGen.cs:240
                                Min = 0,                                                                                                    // MakerGen.cs:241
                                Max = 1,                                                                                                    // MakerGen.cs:242
                                Types = new BaseType[]                                                                                      // MakerGen.cs:243
                                {                                                                                                           // MakerGen.cs:244
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                  // MakerGen.cs:303
                                    {                                                                                                       // MakerGen.cs:304
                                    }                                                                                                       // MakerGen.cs:307
                                }                                                                                                           // MakerGen.cs:246
                            };                                                                                                              // MakerGen.cs:247
                        }                                                                                                                   // MakerGen.cs:248
                        {                                                                                                                   // MakerGen.cs:234
                            // 18. TestReport.setup.action.operation.detail
                            this.Element_Detail = new ElementDefinitionInfo                                                                 // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                Name = "Element_Detail",                                                                                    // MakerGen.cs:238
                                Path= "TestReport.setup.action.operation.detail",                                                           // MakerGen.cs:239
                                Id = "TestReport.setup.action.operation.detail",                                                            // MakerGen.cs:240
                                Min = 0,                                                                                                    // MakerGen.cs:241
                                Max = 1,                                                                                                    // MakerGen.cs:242
                                Types = new BaseType[]                                                                                      // MakerGen.cs:243
                                {                                                                                                           // MakerGen.cs:244
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Uri                                                       // MakerGen.cs:303
                                    {                                                                                                       // MakerGen.cs:304
                                    }                                                                                                       // MakerGen.cs:307
                                }                                                                                                           // MakerGen.cs:246
                            };                                                                                                              // MakerGen.cs:247
                        }                                                                                                                   // MakerGen.cs:248
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:407
                // 19. TestReport.setup.action.assert
                public class Type_Assert : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:383
                {                                                                                                                           // MakerGen.cs:384
                    // 20. TestReport.setup.action.assert.result
                    public ElementDefinitionInfo Element_Result;                                                                            // MakerGen.cs:219
                    // 21. TestReport.setup.action.assert.message
                    public ElementDefinitionInfo Element_Message;                                                                           // MakerGen.cs:219
                    // 22. TestReport.setup.action.assert.detail
                    public ElementDefinitionInfo Element_Detail;                                                                            // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                  // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:394
                            Path = "TestReport.setup.action.assert",                                                                        // MakerGen.cs:395
                            ElementId = "TestReport.setup.action.assert"                                                                    // MakerGen.cs:396
                        });                                                                                                                 // MakerGen.cs:397
                        Element_Result.Write(sDef);                                                                                         // MakerGen.cs:223
                        Element_Message.Write(sDef);                                                                                        // MakerGen.cs:223
                        Element_Detail.Write(sDef);                                                                                         // MakerGen.cs:223
                    }                                                                                                                       // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
                    public Type_Assert()                                                                                                    // MakerGen.cs:402
                    {                                                                                                                       // MakerGen.cs:403
                        {                                                                                                                   // MakerGen.cs:234
                            // 20. TestReport.setup.action.assert.result
                            this.Element_Result = new ElementDefinitionInfo                                                                 // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                Name = "Element_Result",                                                                                    // MakerGen.cs:238
                                Path= "TestReport.setup.action.assert.result",                                                              // MakerGen.cs:239
                                Id = "TestReport.setup.action.assert.result",                                                               // MakerGen.cs:240
                                Min = 1,                                                                                                    // MakerGen.cs:241
                                Max = 1,                                                                                                    // MakerGen.cs:242
                                Types = new BaseType[]                                                                                      // MakerGen.cs:243
                                {                                                                                                           // MakerGen.cs:244
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                      // MakerGen.cs:303
                                    {                                                                                                       // MakerGen.cs:304
                                    }                                                                                                       // MakerGen.cs:307
                                }                                                                                                           // MakerGen.cs:246
                            };                                                                                                              // MakerGen.cs:247
                        }                                                                                                                   // MakerGen.cs:248
                        {                                                                                                                   // MakerGen.cs:234
                            // 21. TestReport.setup.action.assert.message
                            this.Element_Message = new ElementDefinitionInfo                                                                // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                Name = "Element_Message",                                                                                   // MakerGen.cs:238
                                Path= "TestReport.setup.action.assert.message",                                                             // MakerGen.cs:239
                                Id = "TestReport.setup.action.assert.message",                                                              // MakerGen.cs:240
                                Min = 0,                                                                                                    // MakerGen.cs:241
                                Max = 1,                                                                                                    // MakerGen.cs:242
                                Types = new BaseType[]                                                                                      // MakerGen.cs:243
                                {                                                                                                           // MakerGen.cs:244
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                  // MakerGen.cs:303
                                    {                                                                                                       // MakerGen.cs:304
                                    }                                                                                                       // MakerGen.cs:307
                                }                                                                                                           // MakerGen.cs:246
                            };                                                                                                              // MakerGen.cs:247
                        }                                                                                                                   // MakerGen.cs:248
                        {                                                                                                                   // MakerGen.cs:234
                            // 22. TestReport.setup.action.assert.detail
                            this.Element_Detail = new ElementDefinitionInfo                                                                 // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                Name = "Element_Detail",                                                                                    // MakerGen.cs:238
                                Path= "TestReport.setup.action.assert.detail",                                                              // MakerGen.cs:239
                                Id = "TestReport.setup.action.assert.detail",                                                               // MakerGen.cs:240
                                Min = 0,                                                                                                    // MakerGen.cs:241
                                Max = 1,                                                                                                    // MakerGen.cs:242
                                Types = new BaseType[]                                                                                      // MakerGen.cs:243
                                {                                                                                                           // MakerGen.cs:244
                                    new FhirKhit.Maker.Common.Primitive.Primitive_String                                                    // MakerGen.cs:303
                                    {                                                                                                       // MakerGen.cs:304
                                    }                                                                                                       // MakerGen.cs:307
                                }                                                                                                           // MakerGen.cs:246
                            };                                                                                                              // MakerGen.cs:247
                        }                                                                                                                   // MakerGen.cs:248
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:407
                // 15. TestReport.setup.action.operation
                public ElementDefinitionInfo Element_Operation;                                                                             // MakerGen.cs:219
                // 19. TestReport.setup.action.assert
                public ElementDefinitionInfo Element_Assert;                                                                                // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:390
                {                                                                                                                           // MakerGen.cs:391
                    base.Write(sDef);                                                                                                       // MakerGen.cs:392
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        Path = "TestReport.setup.action",                                                                                   // MakerGen.cs:395
                        ElementId = "TestReport.setup.action"                                                                               // MakerGen.cs:396
                    });                                                                                                                     // MakerGen.cs:397
                    Element_Operation.Write(sDef);                                                                                          // MakerGen.cs:223
                    Element_Assert.Write(sDef);                                                                                             // MakerGen.cs:223
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
                public Type_Action()                                                                                                        // MakerGen.cs:402
                {                                                                                                                           // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:234
                        // 15. TestReport.setup.action.operation
                        this.Element_Operation = new ElementDefinitionInfo                                                                  // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Operation",                                                                                     // MakerGen.cs:238
                            Path= "TestReport.setup.action.operation",                                                                      // MakerGen.cs:239
                            Id = "TestReport.setup.action.operation",                                                                       // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new Type_Operation                                                                                          // MakerGen.cs:262
                                {                                                                                                           // MakerGen.cs:263
                                }                                                                                                           // MakerGen.cs:264
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 19. TestReport.setup.action.assert
                        this.Element_Assert = new ElementDefinitionInfo                                                                     // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Assert",                                                                                        // MakerGen.cs:238
                            Path= "TestReport.setup.action.assert",                                                                         // MakerGen.cs:239
                            Id = "TestReport.setup.action.assert",                                                                          // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new Type_Assert                                                                                             // MakerGen.cs:262
                                {                                                                                                           // MakerGen.cs:263
                                }                                                                                                           // MakerGen.cs:264
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                }                                                                                                                           // MakerGen.cs:405
            }                                                                                                                               // MakerGen.cs:407
            // 14. TestReport.setup.action
            public ElementDefinitionInfo Element_Action;                                                                                    // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "TestReport.setup",                                                                                              // MakerGen.cs:395
                    ElementId = "TestReport.setup"                                                                                          // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Action.Write(sDef);                                                                                                 // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Setup()                                                                                                             // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 14. TestReport.setup.action
                    this.Element_Action = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Action",                                                                                            // MakerGen.cs:238
                        Path= "TestReport.setup.action",                                                                                    // MakerGen.cs:239
                        Id = "TestReport.setup.action",                                                                                     // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new Type_Action                                                                                                 // MakerGen.cs:262
                            {                                                                                                               // MakerGen.cs:263
                            }                                                                                                               // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 23. TestReport.test
        public class Type_Test : FhirKhit.Maker.Common.Complex.ComplexBase                                                                  // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 26. TestReport.test.action
            public class Type_Action : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                // 27. TestReport.test.action.operation
                public ElementDefinitionInfo Element_Operation;                                                                             // MakerGen.cs:219
                // 28. TestReport.test.action.assert
                public ElementDefinitionInfo Element_Assert;                                                                                // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:390
                {                                                                                                                           // MakerGen.cs:391
                    base.Write(sDef);                                                                                                       // MakerGen.cs:392
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        Path = "TestReport.test.action",                                                                                    // MakerGen.cs:395
                        ElementId = "TestReport.test.action"                                                                                // MakerGen.cs:396
                    });                                                                                                                     // MakerGen.cs:397
                    Element_Operation.Write(sDef);                                                                                          // MakerGen.cs:223
                    Element_Assert.Write(sDef);                                                                                             // MakerGen.cs:223
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
                public Type_Action()                                                                                                        // MakerGen.cs:402
                {                                                                                                                           // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:234
                        // 27. TestReport.test.action.operation
                        this.Element_Operation = new ElementDefinitionInfo                                                                  // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Operation",                                                                                     // MakerGen.cs:238
                            Path= "TestReport.test.action.operation",                                                                       // MakerGen.cs:239
                            Id = "TestReport.test.action.operation",                                                                        // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 28. TestReport.test.action.assert
                        this.Element_Assert = new ElementDefinitionInfo                                                                     // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Assert",                                                                                        // MakerGen.cs:238
                            Path= "TestReport.test.action.assert",                                                                          // MakerGen.cs:239
                            Id = "TestReport.test.action.assert",                                                                           // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                }                                                                                                                           // MakerGen.cs:405
            }                                                                                                                               // MakerGen.cs:407
            // 24. TestReport.test.name
            public ElementDefinitionInfo Element_Name;                                                                                      // MakerGen.cs:219
            // 25. TestReport.test.description
            public ElementDefinitionInfo Element_Description;                                                                               // MakerGen.cs:219
            // 26. TestReport.test.action
            public ElementDefinitionInfo Element_Action;                                                                                    // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "TestReport.test",                                                                                               // MakerGen.cs:395
                    ElementId = "TestReport.test"                                                                                           // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Name.Write(sDef);                                                                                                   // MakerGen.cs:223
                Element_Description.Write(sDef);                                                                                            // MakerGen.cs:223
                Element_Action.Write(sDef);                                                                                                 // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Test()                                                                                                              // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 24. TestReport.test.name
                    this.Element_Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Name",                                                                                              // MakerGen.cs:238
                        Path= "TestReport.test.name",                                                                                       // MakerGen.cs:239
                        Id = "TestReport.test.name",                                                                                        // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 25. TestReport.test.description
                    this.Element_Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Description",                                                                                       // MakerGen.cs:238
                        Path= "TestReport.test.description",                                                                                // MakerGen.cs:239
                        Id = "TestReport.test.description",                                                                                 // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 26. TestReport.test.action
                    this.Element_Action = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Action",                                                                                            // MakerGen.cs:238
                        Path= "TestReport.test.action",                                                                                     // MakerGen.cs:239
                        Id = "TestReport.test.action",                                                                                      // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new Type_Action                                                                                                 // MakerGen.cs:262
                            {                                                                                                               // MakerGen.cs:263
                            }                                                                                                               // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 29. TestReport.teardown
        public class Type_Teardown : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 30. TestReport.teardown.action
            public class Type_Action : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                // 31. TestReport.teardown.action.operation
                public ElementDefinitionInfo Element_Operation;                                                                             // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:390
                {                                                                                                                           // MakerGen.cs:391
                    base.Write(sDef);                                                                                                       // MakerGen.cs:392
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        Path = "TestReport.teardown.action",                                                                                // MakerGen.cs:395
                        ElementId = "TestReport.teardown.action"                                                                            // MakerGen.cs:396
                    });                                                                                                                     // MakerGen.cs:397
                    Element_Operation.Write(sDef);                                                                                          // MakerGen.cs:223
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
                public Type_Action()                                                                                                        // MakerGen.cs:402
                {                                                                                                                           // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:234
                        // 31. TestReport.teardown.action.operation
                        this.Element_Operation = new ElementDefinitionInfo                                                                  // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Operation",                                                                                     // MakerGen.cs:238
                            Path= "TestReport.teardown.action.operation",                                                                   // MakerGen.cs:239
                            Id = "TestReport.teardown.action.operation",                                                                    // MakerGen.cs:240
                            Min = 1,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                }                                                                                                                           // MakerGen.cs:405
            }                                                                                                                               // MakerGen.cs:407
            // 30. TestReport.teardown.action
            public ElementDefinitionInfo Element_Action;                                                                                    // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "TestReport.teardown",                                                                                           // MakerGen.cs:395
                    ElementId = "TestReport.teardown"                                                                                       // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Action.Write(sDef);                                                                                                 // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Teardown()                                                                                                          // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 30. TestReport.teardown.action
                    this.Element_Action = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Action",                                                                                            // MakerGen.cs:238
                        Path= "TestReport.teardown.action",                                                                                 // MakerGen.cs:239
                        Id = "TestReport.teardown.action",                                                                                  // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new Type_Action                                                                                                 // MakerGen.cs:262
                            {                                                                                                               // MakerGen.cs:263
                            }                                                                                                               // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 1. TestReport.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:219
        // 2. TestReport.name
        public ElementDefinitionInfo Element_Name;                                                                                          // MakerGen.cs:219
        // 3. TestReport.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:219
        // 4. TestReport.testScript
        public ElementDefinitionInfo Element_TestScript;                                                                                    // MakerGen.cs:219
        // 5. TestReport.result
        public ElementDefinitionInfo Element_Result;                                                                                        // MakerGen.cs:219
        // 6. TestReport.score
        public ElementDefinitionInfo Element_Score;                                                                                         // MakerGen.cs:219
        // 7. TestReport.tester
        public ElementDefinitionInfo Element_Tester;                                                                                        // MakerGen.cs:219
        // 8. TestReport.issued
        public ElementDefinitionInfo Element_Issued;                                                                                        // MakerGen.cs:219
        // 9. TestReport.participant
        public ElementDefinitionInfo Element_Participant;                                                                                   // MakerGen.cs:219
        // 13. TestReport.setup
        public ElementDefinitionInfo Element_Setup;                                                                                         // MakerGen.cs:219
        // 23. TestReport.test
        public ElementDefinitionInfo Element_Test;                                                                                          // MakerGen.cs:219
        // 29. TestReport.teardown
        public ElementDefinitionInfo Element_Teardown;                                                                                      // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:390
        {                                                                                                                                   // MakerGen.cs:391
            base.Write(sDef);                                                                                                               // MakerGen.cs:392
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                Path = "TestReport",                                                                                                        // MakerGen.cs:395
                ElementId = "TestReport"                                                                                                    // MakerGen.cs:396
            });                                                                                                                             // MakerGen.cs:397
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Name.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_TestScript.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Result.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_Score.Write(sDef);                                                                                                      // MakerGen.cs:223
            Element_Tester.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_Issued.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_Participant.Write(sDef);                                                                                                // MakerGen.cs:223
            Element_Setup.Write(sDef);                                                                                                      // MakerGen.cs:223
            Element_Test.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_Teardown.Write(sDef);                                                                                                   // MakerGen.cs:223
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
        public Resource_TestReport()                                                                                                        // MakerGen.cs:402
        {                                                                                                                                   // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:234
                // 1. TestReport.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:238
                    Path= "TestReport.identifier",                                                                                          // MakerGen.cs:239
                    Id = "TestReport.identifier",                                                                                           // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 2. TestReport.name
                this.Element_Name = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Name",                                                                                                  // MakerGen.cs:238
                    Path= "TestReport.name",                                                                                                // MakerGen.cs:239
                    Id = "TestReport.name",                                                                                                 // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 3. TestReport.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Status",                                                                                                // MakerGen.cs:238
                    Path= "TestReport.status",                                                                                              // MakerGen.cs:239
                    Id = "TestReport.status",                                                                                               // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 4. TestReport.testScript
                this.Element_TestScript = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_TestScript",                                                                                            // MakerGen.cs:238
                    Path= "TestReport.testScript",                                                                                          // MakerGen.cs:239
                    Id = "TestReport.testScript",                                                                                           // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/TestScript"                                                        // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 5. TestReport.result
                this.Element_Result = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Result",                                                                                                // MakerGen.cs:238
                    Path= "TestReport.result",                                                                                              // MakerGen.cs:239
                    Id = "TestReport.result",                                                                                               // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 6. TestReport.score
                this.Element_Score = new ElementDefinitionInfo                                                                              // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Score",                                                                                                 // MakerGen.cs:238
                    Path= "TestReport.score",                                                                                               // MakerGen.cs:239
                    Id = "TestReport.score",                                                                                                // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                               // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 7. TestReport.tester
                this.Element_Tester = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Tester",                                                                                                // MakerGen.cs:238
                    Path= "TestReport.tester",                                                                                              // MakerGen.cs:239
                    Id = "TestReport.tester",                                                                                               // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 8. TestReport.issued
                this.Element_Issued = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Issued",                                                                                                // MakerGen.cs:238
                    Path= "TestReport.issued",                                                                                              // MakerGen.cs:239
                    Id = "TestReport.issued",                                                                                               // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 9. TestReport.participant
                this.Element_Participant = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Participant",                                                                                           // MakerGen.cs:238
                    Path= "TestReport.participant",                                                                                         // MakerGen.cs:239
                    Id = "TestReport.participant",                                                                                          // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Participant                                                                                                // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 13. TestReport.setup
                this.Element_Setup = new ElementDefinitionInfo                                                                              // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Setup",                                                                                                 // MakerGen.cs:238
                    Path= "TestReport.setup",                                                                                               // MakerGen.cs:239
                    Id = "TestReport.setup",                                                                                                // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Setup                                                                                                      // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 23. TestReport.test
                this.Element_Test = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Test",                                                                                                  // MakerGen.cs:238
                    Path= "TestReport.test",                                                                                                // MakerGen.cs:239
                    Id = "TestReport.test",                                                                                                 // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Test                                                                                                       // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 29. TestReport.teardown
                this.Element_Teardown = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Teardown",                                                                                              // MakerGen.cs:238
                    Path= "TestReport.teardown",                                                                                            // MakerGen.cs:239
                    Id = "TestReport.teardown",                                                                                             // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Teardown                                                                                                   // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            this.Name = "TestReport";                                                                                                       // MakerGen.cs:471
            this.Uri = "http://hl7.org/fhir/StructureDefinition/TestReport";                                                                // MakerGen.cs:472
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:407
}                                                                                                                                           // MakerGen.cs:452
