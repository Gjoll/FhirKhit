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
      "id": "OperationOutcome",
      "url": "http://hl7.org/fhir/StructureDefinition/OperationOutcome",
      "version": "4.0.0",
      "name": "OperationOutcome",
      "status": "active",
      "publisher": "Health Level Seven International (FHIR Infrastructure)",
      "description": "A collection of error, warning, or information messages that result from a system action.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "OperationOutcome",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "OperationOutcome",
            "path": "OperationOutcome",
            "short": "Information about the success/failure of an action",
            "definition": "A collection of error, warning, or information messages that result from a system action.",
            "comment": "Can result from the failure of a REST call or be part of the response message returned from a request message.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "OperationOutcome.issue",
            "path": "OperationOutcome.issue",
            "short": "A single issue associated with the action",
            "definition": "An error, warning, or information message that results from a system action.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "OperationOutcome.issue.severity",
            "path": "OperationOutcome.issue.severity",
            "short": "fatal | error | warning | information",
            "definition": "Indicates whether the issue indicates a variation from successful processing.",
            "comment": "This is labeled as \"Is Modifier\" because applications should not confuse hints and warnings with errors.",
            "requirements": "Indicates how relevant the issue is to the overall success of the action.",
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
                  "valueString": "IssueSeverity"
                }
              ],
              "strength": "required",
              "description": "How the issue affects the success of the action.",
              "valueSet": "http://hl7.org/fhir/ValueSet/issue-severity|4.0.0"
            }
          },
          {
            "id": "OperationOutcome.issue.code",
            "path": "OperationOutcome.issue.code",
            "short": "Error or warning code",
            "definition": "Describes the type of the issue. The system that creates an OperationOutcome SHALL choose the most applicable code from the IssueType value set, and may additional provide its own code for the error in the details element.",
            "requirements": "Expresses the issue in a human and computer-friendly way, allowing the requesting system to behave differently based on the type of issue.\n\nThe required element provides a base level of computable interoperability across all systems for processing an outcome, allowing systems to respond appropriately regardless of the internal system error codes returned.",
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
                  "valueString": "IssueType"
                }
              ],
              "strength": "required",
              "description": "A code that describes the type of issue.",
              "valueSet": "http://hl7.org/fhir/ValueSet/issue-type|4.0.0"
            }
          },
          {
            "id": "OperationOutcome.issue.details",
            "path": "OperationOutcome.issue.details",
            "short": "Additional details about the error",
            "definition": "Additional details about the error. This may be a text description of the error or a system code that identifies the error.",
            "comment": "A human readable description of the error issue SHOULD be placed in details.text.",
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
                  "valueString": "IssueDetails"
                }
              ],
              "strength": "example",
              "description": "A code that provides details as the exact issue.",
              "valueSet": "http://hl7.org/fhir/ValueSet/operation-outcome"
            }
          },
          {
            "id": "OperationOutcome.issue.diagnostics",
            "path": "OperationOutcome.issue.diagnostics",
            "short": "Additional diagnostic information about the issue",
            "definition": "Additional diagnostic information about the issue.",
            "comment": "This may be a description of how a value is erroneous, a stack dump to help trace the issue or other troubleshooting information.",
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
            "id": "OperationOutcome.issue.location",
            "path": "OperationOutcome.issue.location",
            "short": "Deprecated: Path of element(s) related to issue",
            "definition": "This element is deprecated because it is XML specific. It is replaced by issue.expression, which is format independent, and simpler to parse. \n\nFor resource issues, this will be a simple XPath limited to element names, repetition indicators and the default child accessor that identifies one of the elements in the resource that caused this issue to be raised.  For HTTP errors, will be \"http.\" + the parameter name.",
            "comment": "The root of the XPath is the resource or bundle that generated OperationOutcome.  Each XPath SHALL resolve to a single node.  This element is deprecated, and is being replaced by expression.",
            "requirements": "Allows systems to highlight or otherwise guide users to elements implicated in issues to allow them to be fixed more easily.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "OperationOutcome.issue.expression",
            "path": "OperationOutcome.issue.expression",
            "short": "FHIRPath of element(s) related to issue",
            "definition": "A [simple subset of FHIRPath](fhirpath.html#simple) limited to element names, repetition indicators and the default child accessor that identifies one of the elements in the resource that caused this issue to be raised.",
            "comment": "The root of the FHIRPath is the resource or bundle that generated OperationOutcome.  Each FHIRPath SHALL resolve to a single node.",
            "requirements": "Allows systems to highlight or otherwise guide users to elements implicated in issues to allow them to be fixed more easily.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:463
    /// <summary>
    /// Fhir resource 'OperationOutcome'
    /// </summary>
    // 0. OperationOutcome
    public class OperationOutcome : FhirKhit.Maker.Common.Resource.ResourceBase                                                             // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class OperationOutcome_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 1. OperationOutcome.issue
            public class Type_Issue : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Issue_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                              // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 2. OperationOutcome.issue.severity
                    public ElementDefinitionInfo Severity;                                                                                  // MakerGen.cs:236
                    // 3. OperationOutcome.issue.code
                    public ElementDefinitionInfo Code;                                                                                      // MakerGen.cs:236
                    // 4. OperationOutcome.issue.details
                    public ElementDefinitionInfo Details;                                                                                   // MakerGen.cs:236
                    // 5. OperationOutcome.issue.diagnostics
                    public ElementDefinitionInfo Diagnostics;                                                                               // MakerGen.cs:236
                    // 6. OperationOutcome.issue.location
                    public ElementDefinitionInfo Location;                                                                                  // MakerGen.cs:236
                    // 7. OperationOutcome.issue.expression
                    public ElementDefinitionInfo Expression;                                                                                // MakerGen.cs:236
                    public Type_Issue_Elements()                                                                                            // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 2. OperationOutcome.issue.severity
                            this.Severity = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Severity",                                                                                          // MakerGen.cs:255
                                Path= "OperationOutcome.issue.severity",                                                                    // MakerGen.cs:256
                                Id = "OperationOutcome.issue.severity",                                                                     // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 3. OperationOutcome.issue.code
                            this.Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Code",                                                                                              // MakerGen.cs:255
                                Path= "OperationOutcome.issue.code",                                                                        // MakerGen.cs:256
                                Id = "OperationOutcome.issue.code",                                                                         // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 4. OperationOutcome.issue.details
                            this.Details = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Details",                                                                                           // MakerGen.cs:255
                                Path= "OperationOutcome.issue.details",                                                                     // MakerGen.cs:256
                                Id = "OperationOutcome.issue.details",                                                                      // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 5. OperationOutcome.issue.diagnostics
                            this.Diagnostics = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Diagnostics",                                                                                       // MakerGen.cs:255
                                Path= "OperationOutcome.issue.diagnostics",                                                                 // MakerGen.cs:256
                                Id = "OperationOutcome.issue.diagnostics",                                                                  // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 6. OperationOutcome.issue.location
                            this.Location = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Location",                                                                                          // MakerGen.cs:255
                                Path= "OperationOutcome.issue.location",                                                                    // MakerGen.cs:256
                                Id = "OperationOutcome.issue.location",                                                                     // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 7. OperationOutcome.issue.expression
                            this.Expression = new ElementDefinitionInfo                                                                     // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Expression",                                                                                        // MakerGen.cs:255
                                Path= "OperationOutcome.issue.expression",                                                                  // MakerGen.cs:256
                                Id = "OperationOutcome.issue.expression",                                                                   // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Severity.Write(sDef);                                                                                               // MakerGen.cs:240
                        Code.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Details.Write(sDef);                                                                                                // MakerGen.cs:240
                        Diagnostics.Write(sDef);                                                                                            // MakerGen.cs:240
                        Location.Write(sDef);                                                                                               // MakerGen.cs:240
                        Expression.Write(sDef);                                                                                             // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Issue_Elements Elements { get; }                                                                                // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Issue()                                                                                                         // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Issue_Elements();                                                                              // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            public OperationOutcome_Elements()                                                                                              // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
            }                                                                                                                               // MakerGen.cs:429
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public OperationOutcome_Elements Elements { get; }                                                                                  // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public OperationOutcome()                                                                                                           // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new OperationOutcome_Elements();                                                                                // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:468
