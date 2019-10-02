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
    #endregion
    /// <summary>
    /// Fhir resource 'TestReport'
    /// </summary>
    // 0. TestReport
    public class Resource_TestReport : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 9. TestReport.participant
        public class Type_Participant : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 10. TestReport.participant.type
            public ElementDefinitionInfo Element_Type;
            // 11. TestReport.participant.uri
            public ElementDefinitionInfo Element_Uri;
            // 12. TestReport.participant.display
            public ElementDefinitionInfo Element_Display;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "TestReport.participant",
                    ElementId = "TestReport.participant"
                });
                Element_Type.Write(sDef);
                Element_Uri.Write(sDef);
                Element_Display.Write(sDef);
            }
            
            public Type_Participant()
            {
                {
                    // 10. TestReport.participant.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "TestReport.participant.type",
                        Id = "TestReport.participant.type",
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
                    // 11. TestReport.participant.uri
                    this.Element_Uri = new ElementDefinitionInfo
                    {
                        Name = "Element_Uri",
                        Path= "TestReport.participant.uri",
                        Id = "TestReport.participant.uri",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Uri
                            {
                            }
                        }
                    };
                }
                {
                    // 12. TestReport.participant.display
                    this.Element_Display = new ElementDefinitionInfo
                    {
                        Name = "Element_Display",
                        Path= "TestReport.participant.display",
                        Id = "TestReport.participant.display",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_String
                            {
                            }
                        }
                    };
                }
            }
        }
        // 13. TestReport.setup
        public class Type_Setup : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 14. TestReport.setup.action
            public class Type_Action : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 15. TestReport.setup.action.operation
                public class Type_Operation : FhirKhit.Maker.Common.Complex.ComplexBase
                {
                    // 16. TestReport.setup.action.operation.result
                    public ElementDefinitionInfo Element_Result;
                    // 17. TestReport.setup.action.operation.message
                    public ElementDefinitionInfo Element_Message;
                    // 18. TestReport.setup.action.operation.detail
                    public ElementDefinitionInfo Element_Detail;
                    
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                    {
                        base.Write(sDef);
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                        {
                            Path = "TestReport.setup.action.operation",
                            ElementId = "TestReport.setup.action.operation"
                        });
                        Element_Result.Write(sDef);
                        Element_Message.Write(sDef);
                        Element_Detail.Write(sDef);
                    }
                    
                    public Type_Operation()
                    {
                        {
                            // 16. TestReport.setup.action.operation.result
                            this.Element_Result = new ElementDefinitionInfo
                            {
                                Name = "Element_Result",
                                Path= "TestReport.setup.action.operation.result",
                                Id = "TestReport.setup.action.operation.result",
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
                            // 17. TestReport.setup.action.operation.message
                            this.Element_Message = new ElementDefinitionInfo
                            {
                                Name = "Element_Message",
                                Path= "TestReport.setup.action.operation.message",
                                Id = "TestReport.setup.action.operation.message",
                                Min = 0,
                                Max = 1,
                                Types = new BaseType[]
                                {
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Markdown
                                    {
                                    }
                                }
                            };
                        }
                        {
                            // 18. TestReport.setup.action.operation.detail
                            this.Element_Detail = new ElementDefinitionInfo
                            {
                                Name = "Element_Detail",
                                Path= "TestReport.setup.action.operation.detail",
                                Id = "TestReport.setup.action.operation.detail",
                                Min = 0,
                                Max = 1,
                                Types = new BaseType[]
                                {
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Uri
                                    {
                                    }
                                }
                            };
                        }
                    }
                }
                // 19. TestReport.setup.action.assert
                public class Type_Assert : FhirKhit.Maker.Common.Complex.ComplexBase
                {
                    // 20. TestReport.setup.action.assert.result
                    public ElementDefinitionInfo Element_Result;
                    // 21. TestReport.setup.action.assert.message
                    public ElementDefinitionInfo Element_Message;
                    // 22. TestReport.setup.action.assert.detail
                    public ElementDefinitionInfo Element_Detail;
                    
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                    {
                        base.Write(sDef);
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                        {
                            Path = "TestReport.setup.action.assert",
                            ElementId = "TestReport.setup.action.assert"
                        });
                        Element_Result.Write(sDef);
                        Element_Message.Write(sDef);
                        Element_Detail.Write(sDef);
                    }
                    
                    public Type_Assert()
                    {
                        {
                            // 20. TestReport.setup.action.assert.result
                            this.Element_Result = new ElementDefinitionInfo
                            {
                                Name = "Element_Result",
                                Path= "TestReport.setup.action.assert.result",
                                Id = "TestReport.setup.action.assert.result",
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
                            // 21. TestReport.setup.action.assert.message
                            this.Element_Message = new ElementDefinitionInfo
                            {
                                Name = "Element_Message",
                                Path= "TestReport.setup.action.assert.message",
                                Id = "TestReport.setup.action.assert.message",
                                Min = 0,
                                Max = 1,
                                Types = new BaseType[]
                                {
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Markdown
                                    {
                                    }
                                }
                            };
                        }
                        {
                            // 22. TestReport.setup.action.assert.detail
                            this.Element_Detail = new ElementDefinitionInfo
                            {
                                Name = "Element_Detail",
                                Path= "TestReport.setup.action.assert.detail",
                                Id = "TestReport.setup.action.assert.detail",
                                Min = 0,
                                Max = 1,
                                Types = new BaseType[]
                                {
                                    new FhirKhit.Maker.Common.Primitive.Primitive_String
                                    {
                                    }
                                }
                            };
                        }
                    }
                }
                // 15. TestReport.setup.action.operation
                public ElementDefinitionInfo Element_Operation;
                // 19. TestReport.setup.action.assert
                public ElementDefinitionInfo Element_Assert;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "TestReport.setup.action",
                        ElementId = "TestReport.setup.action"
                    });
                    Element_Operation.Write(sDef);
                    Element_Assert.Write(sDef);
                }
                
                public Type_Action()
                {
                    {
                        // 15. TestReport.setup.action.operation
                        this.Element_Operation = new ElementDefinitionInfo
                        {
                            Name = "Element_Operation",
                            Path= "TestReport.setup.action.operation",
                            Id = "TestReport.setup.action.operation",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new Type_Operation
                                {
                                }
                            }
                        };
                    }
                    {
                        // 19. TestReport.setup.action.assert
                        this.Element_Assert = new ElementDefinitionInfo
                        {
                            Name = "Element_Assert",
                            Path= "TestReport.setup.action.assert",
                            Id = "TestReport.setup.action.assert",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new Type_Assert
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 14. TestReport.setup.action
            public ElementDefinitionInfo Element_Action;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "TestReport.setup",
                    ElementId = "TestReport.setup"
                });
                Element_Action.Write(sDef);
            }
            
            public Type_Setup()
            {
                {
                    // 14. TestReport.setup.action
                    this.Element_Action = new ElementDefinitionInfo
                    {
                        Name = "Element_Action",
                        Path= "TestReport.setup.action",
                        Id = "TestReport.setup.action",
                        Min = 1,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Action
                            {
                            }
                        }
                    };
                }
            }
        }
        // 23. TestReport.test
        public class Type_Test : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 26. TestReport.test.action
            public class Type_Action : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 27. TestReport.test.action.operation
                public ElementDefinitionInfo Element_Operation;
                // 28. TestReport.test.action.assert
                public ElementDefinitionInfo Element_Assert;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "TestReport.test.action",
                        ElementId = "TestReport.test.action"
                    });
                    Element_Operation.Write(sDef);
                    Element_Assert.Write(sDef);
                }
                
                public Type_Action()
                {
                    {
                        // 27. TestReport.test.action.operation
                        this.Element_Operation = new ElementDefinitionInfo
                        {
                            Name = "Element_Operation",
                            Path= "TestReport.test.action.operation",
                            Id = "TestReport.test.action.operation",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                            }
                        };
                    }
                    {
                        // 28. TestReport.test.action.assert
                        this.Element_Assert = new ElementDefinitionInfo
                        {
                            Name = "Element_Assert",
                            Path= "TestReport.test.action.assert",
                            Id = "TestReport.test.action.assert",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                            }
                        };
                    }
                }
            }
            // 24. TestReport.test.name
            public ElementDefinitionInfo Element_Name;
            // 25. TestReport.test.description
            public ElementDefinitionInfo Element_Description;
            // 26. TestReport.test.action
            public ElementDefinitionInfo Element_Action;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "TestReport.test",
                    ElementId = "TestReport.test"
                });
                Element_Name.Write(sDef);
                Element_Description.Write(sDef);
                Element_Action.Write(sDef);
            }
            
            public Type_Test()
            {
                {
                    // 24. TestReport.test.name
                    this.Element_Name = new ElementDefinitionInfo
                    {
                        Name = "Element_Name",
                        Path= "TestReport.test.name",
                        Id = "TestReport.test.name",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_String
                            {
                            }
                        }
                    };
                }
                {
                    // 25. TestReport.test.description
                    this.Element_Description = new ElementDefinitionInfo
                    {
                        Name = "Element_Description",
                        Path= "TestReport.test.description",
                        Id = "TestReport.test.description",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_String
                            {
                            }
                        }
                    };
                }
                {
                    // 26. TestReport.test.action
                    this.Element_Action = new ElementDefinitionInfo
                    {
                        Name = "Element_Action",
                        Path= "TestReport.test.action",
                        Id = "TestReport.test.action",
                        Min = 1,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Action
                            {
                            }
                        }
                    };
                }
            }
        }
        // 29. TestReport.teardown
        public class Type_Teardown : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 30. TestReport.teardown.action
            public class Type_Action : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 31. TestReport.teardown.action.operation
                public ElementDefinitionInfo Element_Operation;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "TestReport.teardown.action",
                        ElementId = "TestReport.teardown.action"
                    });
                    Element_Operation.Write(sDef);
                }
                
                public Type_Action()
                {
                    {
                        // 31. TestReport.teardown.action.operation
                        this.Element_Operation = new ElementDefinitionInfo
                        {
                            Name = "Element_Operation",
                            Path= "TestReport.teardown.action.operation",
                            Id = "TestReport.teardown.action.operation",
                            Min = 1,
                            Max = 1,
                            Types = new BaseType[]
                            {
                            }
                        };
                    }
                }
            }
            // 30. TestReport.teardown.action
            public ElementDefinitionInfo Element_Action;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "TestReport.teardown",
                    ElementId = "TestReport.teardown"
                });
                Element_Action.Write(sDef);
            }
            
            public Type_Teardown()
            {
                {
                    // 30. TestReport.teardown.action
                    this.Element_Action = new ElementDefinitionInfo
                    {
                        Name = "Element_Action",
                        Path= "TestReport.teardown.action",
                        Id = "TestReport.teardown.action",
                        Min = 1,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Action
                            {
                            }
                        }
                    };
                }
            }
        }
        // 1. TestReport.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. TestReport.name
        public ElementDefinitionInfo Element_Name;
        // 3. TestReport.status
        public ElementDefinitionInfo Element_Status;
        // 4. TestReport.testScript
        public ElementDefinitionInfo Element_TestScript;
        // 5. TestReport.result
        public ElementDefinitionInfo Element_Result;
        // 6. TestReport.score
        public ElementDefinitionInfo Element_Score;
        // 7. TestReport.tester
        public ElementDefinitionInfo Element_Tester;
        // 8. TestReport.issued
        public ElementDefinitionInfo Element_Issued;
        // 9. TestReport.participant
        public ElementDefinitionInfo Element_Participant;
        // 13. TestReport.setup
        public ElementDefinitionInfo Element_Setup;
        // 23. TestReport.test
        public ElementDefinitionInfo Element_Test;
        // 29. TestReport.teardown
        public ElementDefinitionInfo Element_Teardown;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "TestReport",
                ElementId = "TestReport"
            });
            Element_Identifier.Write(sDef);
            Element_Name.Write(sDef);
            Element_Status.Write(sDef);
            Element_TestScript.Write(sDef);
            Element_Result.Write(sDef);
            Element_Score.Write(sDef);
            Element_Tester.Write(sDef);
            Element_Issued.Write(sDef);
            Element_Participant.Write(sDef);
            Element_Setup.Write(sDef);
            Element_Test.Write(sDef);
            Element_Teardown.Write(sDef);
        }
        
        public Resource_TestReport()
        {
            {
                // 1. TestReport.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "TestReport.identifier",
                    Id = "TestReport.identifier",
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
                // 2. TestReport.name
                this.Element_Name = new ElementDefinitionInfo
                {
                    Name = "Element_Name",
                    Path= "TestReport.name",
                    Id = "TestReport.name",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_String
                        {
                        }
                    }
                };
            }
            {
                // 3. TestReport.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "TestReport.status",
                    Id = "TestReport.status",
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
                // 4. TestReport.testScript
                this.Element_TestScript = new ElementDefinitionInfo
                {
                    Name = "Element_TestScript",
                    Path= "TestReport.testScript",
                    Id = "TestReport.testScript",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/TestScript"
                            }
                        }
                    }
                };
            }
            {
                // 5. TestReport.result
                this.Element_Result = new ElementDefinitionInfo
                {
                    Name = "Element_Result",
                    Path= "TestReport.result",
                    Id = "TestReport.result",
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
                // 6. TestReport.score
                this.Element_Score = new ElementDefinitionInfo
                {
                    Name = "Element_Score",
                    Path= "TestReport.score",
                    Id = "TestReport.score",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                        {
                        }
                    }
                };
            }
            {
                // 7. TestReport.tester
                this.Element_Tester = new ElementDefinitionInfo
                {
                    Name = "Element_Tester",
                    Path= "TestReport.tester",
                    Id = "TestReport.tester",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_String
                        {
                        }
                    }
                };
            }
            {
                // 8. TestReport.issued
                this.Element_Issued = new ElementDefinitionInfo
                {
                    Name = "Element_Issued",
                    Path= "TestReport.issued",
                    Id = "TestReport.issued",
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
                // 9. TestReport.participant
                this.Element_Participant = new ElementDefinitionInfo
                {
                    Name = "Element_Participant",
                    Path= "TestReport.participant",
                    Id = "TestReport.participant",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Participant
                        {
                        }
                    }
                };
            }
            {
                // 13. TestReport.setup
                this.Element_Setup = new ElementDefinitionInfo
                {
                    Name = "Element_Setup",
                    Path= "TestReport.setup",
                    Id = "TestReport.setup",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_Setup
                        {
                        }
                    }
                };
            }
            {
                // 23. TestReport.test
                this.Element_Test = new ElementDefinitionInfo
                {
                    Name = "Element_Test",
                    Path= "TestReport.test",
                    Id = "TestReport.test",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Test
                        {
                        }
                    }
                };
            }
            {
                // 29. TestReport.teardown
                this.Element_Teardown = new ElementDefinitionInfo
                {
                    Name = "Element_Teardown",
                    Path= "TestReport.teardown",
                    Id = "TestReport.teardown",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_Teardown
                        {
                        }
                    }
                };
            }
            this.Name = "TestReport";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/TestReport";
        }
    }
}
