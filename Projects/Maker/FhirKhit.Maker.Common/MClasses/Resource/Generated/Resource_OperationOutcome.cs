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
    #endregion                                                                                                                              // MakerGen.cs:447
    /// <summary>
    /// Fhir resource 'OperationOutcome'
    /// </summary>
    // 0. OperationOutcome
    public class Resource_OperationOutcome : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                         // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        // 1. OperationOutcome.issue
        public class Type_Issue : FhirKhit.Maker.Common.Complex.ComplexBase                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 2. OperationOutcome.issue.severity
            public ElementDefinitionInfo Element_Severity;                                                                                  // MakerGen.cs:219
            // 3. OperationOutcome.issue.code
            public ElementDefinitionInfo Element_Code;                                                                                      // MakerGen.cs:219
            // 4. OperationOutcome.issue.details
            public ElementDefinitionInfo Element_Details;                                                                                   // MakerGen.cs:219
            // 5. OperationOutcome.issue.diagnostics
            public ElementDefinitionInfo Element_Diagnostics;                                                                               // MakerGen.cs:219
            // 6. OperationOutcome.issue.location
            public ElementDefinitionInfo Element_Location;                                                                                  // MakerGen.cs:219
            // 7. OperationOutcome.issue.expression
            public ElementDefinitionInfo Element_Expression;                                                                                // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "OperationOutcome.issue",                                                                                        // MakerGen.cs:395
                    ElementId = "OperationOutcome.issue"                                                                                    // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Severity.Write(sDef);                                                                                               // MakerGen.cs:223
                Element_Code.Write(sDef);                                                                                                   // MakerGen.cs:223
                Element_Details.Write(sDef);                                                                                                // MakerGen.cs:223
                Element_Diagnostics.Write(sDef);                                                                                            // MakerGen.cs:223
                Element_Location.Write(sDef);                                                                                               // MakerGen.cs:223
                Element_Expression.Write(sDef);                                                                                             // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Issue()                                                                                                             // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 2. OperationOutcome.issue.severity
                    this.Element_Severity = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Severity",                                                                                          // MakerGen.cs:238
                        Path= "OperationOutcome.issue.severity",                                                                            // MakerGen.cs:239
                        Id = "OperationOutcome.issue.severity",                                                                             // MakerGen.cs:240
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
                    // 3. OperationOutcome.issue.code
                    this.Element_Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Code",                                                                                              // MakerGen.cs:238
                        Path= "OperationOutcome.issue.code",                                                                                // MakerGen.cs:239
                        Id = "OperationOutcome.issue.code",                                                                                 // MakerGen.cs:240
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
                    // 4. OperationOutcome.issue.details
                    this.Element_Details = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Details",                                                                                           // MakerGen.cs:238
                        Path= "OperationOutcome.issue.details",                                                                             // MakerGen.cs:239
                        Id = "OperationOutcome.issue.details",                                                                              // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 5. OperationOutcome.issue.diagnostics
                    this.Element_Diagnostics = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Diagnostics",                                                                                       // MakerGen.cs:238
                        Path= "OperationOutcome.issue.diagnostics",                                                                         // MakerGen.cs:239
                        Id = "OperationOutcome.issue.diagnostics",                                                                          // MakerGen.cs:240
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
                    // 6. OperationOutcome.issue.location
                    this.Element_Location = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Location",                                                                                          // MakerGen.cs:238
                        Path= "OperationOutcome.issue.location",                                                                            // MakerGen.cs:239
                        Id = "OperationOutcome.issue.location",                                                                             // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 7. OperationOutcome.issue.expression
                    this.Element_Expression = new ElementDefinitionInfo                                                                     // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Expression",                                                                                        // MakerGen.cs:238
                        Path= "OperationOutcome.issue.expression",                                                                          // MakerGen.cs:239
                        Id = "OperationOutcome.issue.expression",                                                                           // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
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
        // 1. OperationOutcome.issue
        public ElementDefinitionInfo Element_Issue;                                                                                         // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:390
        {                                                                                                                                   // MakerGen.cs:391
            base.Write(sDef);                                                                                                               // MakerGen.cs:392
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                Path = "OperationOutcome",                                                                                                  // MakerGen.cs:395
                ElementId = "OperationOutcome"                                                                                              // MakerGen.cs:396
            });                                                                                                                             // MakerGen.cs:397
            Element_Issue.Write(sDef);                                                                                                      // MakerGen.cs:223
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
        public Resource_OperationOutcome()                                                                                                  // MakerGen.cs:402
        {                                                                                                                                   // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:234
                // 1. OperationOutcome.issue
                this.Element_Issue = new ElementDefinitionInfo                                                                              // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Issue",                                                                                                 // MakerGen.cs:238
                    Path= "OperationOutcome.issue",                                                                                         // MakerGen.cs:239
                    Id = "OperationOutcome.issue",                                                                                          // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Issue                                                                                                      // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            this.Name = "OperationOutcome";                                                                                                 // MakerGen.cs:471
            this.Uri = "http://hl7.org/fhir/StructureDefinition/OperationOutcome";                                                          // MakerGen.cs:472
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:407
}                                                                                                                                           // MakerGen.cs:452
