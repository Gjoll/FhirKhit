using System;                                                                                                                               // MakerGen.cs:462
using System.Diagnostics;                                                                                                                   // MakerGen.cs:463
using System.IO;                                                                                                                            // MakerGen.cs:464
using System.Linq;                                                                                                                          // MakerGen.cs:465
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:466
                                                                                                                                            // MakerGen.cs:467
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:468
{                                                                                                                                           // MakerGen.cs:469
    #region Json                                                                                                                            // MakerGen.cs:470
    #if NEVER                                                                                                                               // MakerGen.cs:471
    {
      "resourceType": "StructureDefinition",
      "id": "DetectedIssue",
      "url": "http://hl7.org/fhir/StructureDefinition/DetectedIssue",
      "version": "4.0.0",
      "name": "DetectedIssue",
      "status": "draft",
      "publisher": "Health Level Seven International (Clinical Decision Support)",
      "description": "Indicates an actual or potential clinical issue with or between one or more active or proposed clinical actions for a patient; e.g. Drug-drug interaction, Ineffective treatment frequency, Procedure-condition conflict, etc.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "DetectedIssue",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "DetectedIssue",
            "path": "DetectedIssue",
            "short": "Clinical issue with action",
            "definition": "Indicates an actual or potential clinical issue with or between one or more active or proposed clinical actions for a patient; e.g. Drug-drug interaction, Ineffective treatment frequency, Procedure-condition conflict, etc.",
            "alias": [
              "DDI",
              "drug-drug interaction",
              "Contraindication",
              "Alert"
            ],
            "min": 0,
            "max": "*"
          },
          {
            "id": "DetectedIssue.identifier",
            "path": "DetectedIssue.identifier",
            "short": "Unique id for the detected issue",
            "definition": "Business identifier associated with the detected issue record.",
            "requirements": "Allows linking instances of the same detected issue found on different servers.",
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
            "id": "DetectedIssue.status",
            "path": "DetectedIssue.status",
            "short": "registered | preliminary | final | amended +",
            "definition": "Indicates the status of the detected issue.",
            "comment": "This element is labeled as a modifier because the status contains the codes cancelled and entered-in-error that mark the issue as not currently valid.",
            "alias": [
              "status"
            ],
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element is labeled as a modifier because it is a status element that contains status entered-in-error which means that the resource should not be treated as valid",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "DetectedIssueStatus"
                }
              ],
              "strength": "required",
              "description": "Indicates the status of the identified issue.",
              "valueSet": "http://hl7.org/fhir/ValueSet/observation-status|4.0.0"
            }
          },
          {
            "id": "DetectedIssue.code",
            "path": "DetectedIssue.code",
            "short": "Issue Category, e.g. drug-drug, duplicate therapy, etc.",
            "definition": "Identifies the general type of issue identified.",
            "alias": [
              "type"
            ],
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
                  "valueString": "DetectedIssueCategory"
                }
              ],
              "strength": "preferred",
              "description": "Codes identifying the general type of detected issue; e.g. Drug-drug interaction, Timing issue, Duplicate therapy, etc.",
              "valueSet": "http://hl7.org/fhir/ValueSet/detectedissue-category"
            }
          },
          {
            "id": "DetectedIssue.severity",
            "path": "DetectedIssue.severity",
            "short": "high | moderate | low",
            "definition": "Indicates the degree of importance associated with the identified issue based on the potential impact on the patient.",
            "alias": [
              "severity"
            ],
            "min": 0,
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
                  "valueString": "DetectedIssueSeverity"
                }
              ],
              "strength": "required",
              "description": "Indicates the potential degree of impact of the identified issue on the patient.",
              "valueSet": "http://hl7.org/fhir/ValueSet/detectedissue-severity|4.0.0"
            }
          },
          {
            "id": "DetectedIssue.patient",
            "path": "DetectedIssue.patient",
            "short": "Associated patient",
            "definition": "Indicates the patient whose record the detected issue is associated with.",
            "requirements": "While the subject could be inferred by tracing the subject of the implicated resources, it's useful to have a direct link for query purposes.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "DetectedIssue.identified[x]",
            "path": "DetectedIssue.identified[x]",
            "short": "When identified",
            "definition": "The date or period when the detected issue was initially identified.",
            "requirements": "No-one can be responsible for mitigation prior to the issue being identified.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              },
              {
                "code": "Period"
              }
            ],
            "isSummary": true
          },
          {
            "id": "DetectedIssue.author",
            "path": "DetectedIssue.author",
            "short": "The provider or device that identified the issue",
            "definition": "Individual or device responsible for the issue being raised.  For example, a decision support application or a pharmacist conducting a medication review.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Device"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "DetectedIssue.implicated",
            "path": "DetectedIssue.implicated",
            "short": "Problem resource",
            "definition": "Indicates the resource representing the current activity or proposed activity that is potentially problematic.",
            "comment": "There's an implicit constraint on the number of implicated resources based on DetectedIssue.type; e.g. For drug-drug, there would be more than one.  For timing, there would typically only be one.",
            "alias": [
              "cause"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "DetectedIssue.evidence",
            "path": "DetectedIssue.evidence",
            "short": "Supporting evidence",
            "definition": "Supporting evidence or manifestations that provide the basis for identifying the detected issue such as a GuidanceResponse or MeasureReport.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "DetectedIssue.evidence.code",
            "path": "DetectedIssue.evidence.code",
            "short": "Manifestation",
            "definition": "A manifestation that led to the recording of this detected issue.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "DetectedIssueEvidenceCode"
                }
              ],
              "strength": "example",
              "description": "Codes that describes the types of evidence for a detected issue.",
              "valueSet": "http://hl7.org/fhir/ValueSet/manifestation-or-symptom"
            }
          },
          {
            "id": "DetectedIssue.evidence.detail",
            "path": "DetectedIssue.evidence.detail",
            "short": "Supporting information",
            "definition": "Links to resources that constitute evidence for the detected issue such as a GuidanceResponse or MeasureReport.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ]
          },
          {
            "id": "DetectedIssue.detail",
            "path": "DetectedIssue.detail",
            "short": "Description and context",
            "definition": "A textual explanation of the detected issue.",
            "comment": "Should focus on information not covered elsewhere as discrete data - no need to duplicate the narrative.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "DetectedIssue.reference",
            "path": "DetectedIssue.reference",
            "short": "Authority for issue",
            "definition": "The literature, knowledge-base or similar reference that describes the propensity for the detected issue identified.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ]
          },
          {
            "id": "DetectedIssue.mitigation",
            "path": "DetectedIssue.mitigation",
            "short": "Step taken to address",
            "definition": "Indicates an action that has been taken or is committed to reduce or eliminate the likelihood of the risk identified by the detected issue from manifesting.  Can also reflect an observation of known mitigating factors that may reduce/eliminate the need for any action.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "DetectedIssue.mitigation.action",
            "path": "DetectedIssue.mitigation.action",
            "short": "What mitigation?",
            "definition": "Describes the action that was taken or the observation that was made that reduces/eliminates the risk associated with the identified issue.",
            "comment": "The \"text\" component can be used for detail or when no appropriate code exists.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "DetectedIssueMitigationAction"
                }
              ],
              "strength": "preferred",
              "description": "Codes describing steps taken to resolve the issue or other circumstances that mitigate the risk associated with the issue; e.g. 'added concurrent therapy', 'prior therapy documented', etc.",
              "valueSet": "http://hl7.org/fhir/ValueSet/detectedissue-mitigation-action"
            }
          },
          {
            "id": "DetectedIssue.mitigation.date",
            "path": "DetectedIssue.mitigation.date",
            "short": "Date committed",
            "definition": "Indicates when the mitigating action was documented.",
            "comment": "This might not be the same as when the mitigating step was actually taken.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ]
          },
          {
            "id": "DetectedIssue.mitigation.author",
            "path": "DetectedIssue.mitigation.author",
            "short": "Who is committing?",
            "definition": "Identifies the practitioner who determined the mitigation and takes responsibility for the mitigation step occurring.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                ]
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:474
    /// <summary>
    /// Fhir resource 'DetectedIssue'
    /// </summary>
    // 0. DetectedIssue
    public class DetectedIssue : FhirKhit.Maker.Common.Resource.ResourceBase                                                                // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        public class DetectedIssue_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                   // MakerGen.cs:386
        {                                                                                                                                   // MakerGen.cs:387
            // 9. DetectedIssue.evidence
            public class Type_Evidence : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_Evidence_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                           // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 10. DetectedIssue.evidence.code
                    public ElementDefinitionInfo Code;                                                                                      // MakerGen.cs:216
                    // 11. DetectedIssue.evidence.detail
                    public ElementDefinitionInfo Detail;                                                                                    // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_Evidence_Elements()                                                                                         // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 10. DetectedIssue.evidence.code
                            this.Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Code",                                                                                              // MakerGen.cs:235
                                Path= "DetectedIssue.evidence.code",                                                                        // MakerGen.cs:236
                                Id = "DetectedIssue.evidence.code",                                                                         // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 11. DetectedIssue.evidence.detail
                            this.Detail = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Detail",                                                                                            // MakerGen.cs:235
                                Path= "DetectedIssue.evidence.detail",                                                                      // MakerGen.cs:236
                                Id = "DetectedIssue.evidence.detail",                                                                       // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Resource"                                              // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        Code.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Detail.Write(sDef);                                                                                                 // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_Evidence_Elements Elements                                                                                      // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_Evidence_Elements();                                                                   // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_Evidence_Elements elements;                                                                                            // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_Evidence()                                                                                                      // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "DetectedIssue.evidence",                                                                                    // MakerGen.cs:428
                        ElementId = "DetectedIssue.evidence"                                                                                // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 14. DetectedIssue.mitigation
            public class Type_Mitigation : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_Mitigation_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                         // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 15. DetectedIssue.mitigation.action
                    public ElementDefinitionInfo Action;                                                                                    // MakerGen.cs:216
                    // 16. DetectedIssue.mitigation.date
                    public ElementDefinitionInfo Date;                                                                                      // MakerGen.cs:216
                    // 17. DetectedIssue.mitigation.author
                    public ElementDefinitionInfo Author;                                                                                    // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_Mitigation_Elements()                                                                                       // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 15. DetectedIssue.mitigation.action
                            this.Action = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Action",                                                                                            // MakerGen.cs:235
                                Path= "DetectedIssue.mitigation.action",                                                                    // MakerGen.cs:236
                                Id = "DetectedIssue.mitigation.action",                                                                     // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 16. DetectedIssue.mitigation.date
                            this.Date = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Date",                                                                                              // MakerGen.cs:235
                                Path= "DetectedIssue.mitigation.date",                                                                      // MakerGen.cs:236
                                Id = "DetectedIssue.mitigation.date",                                                                       // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.DateTime                                                            // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 17. DetectedIssue.mitigation.author
                            this.Author = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Author",                                                                                            // MakerGen.cs:235
                                Path= "DetectedIssue.mitigation.author",                                                                    // MakerGen.cs:236
                                Id = "DetectedIssue.mitigation.author",                                                                     // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",                                         // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                      // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        Action.Write(sDef);                                                                                                 // MakerGen.cs:220
                        Date.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Author.Write(sDef);                                                                                                 // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_Mitigation_Elements Elements                                                                                    // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_Mitigation_Elements();                                                                 // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_Mitigation_Elements elements;                                                                                          // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_Mitigation()                                                                                                    // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "DetectedIssue.mitigation",                                                                                  // MakerGen.cs:428
                        ElementId = "DetectedIssue.mitigation"                                                                              // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 1. DetectedIssue.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 2. DetectedIssue.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:216
            // 3. DetectedIssue.code
            public ElementDefinitionInfo Code;                                                                                              // MakerGen.cs:216
            // 4. DetectedIssue.severity
            public ElementDefinitionInfo Severity;                                                                                          // MakerGen.cs:216
            // 5. DetectedIssue.patient
            public ElementDefinitionInfo Patient;                                                                                           // MakerGen.cs:216
            // 6. DetectedIssue.identified[x]
            public ElementDefinitionInfo Identified;                                                                                        // MakerGen.cs:216
            // 7. DetectedIssue.author
            public ElementDefinitionInfo Author;                                                                                            // MakerGen.cs:216
            // 8. DetectedIssue.implicated
            public ElementDefinitionInfo Implicated;                                                                                        // MakerGen.cs:216
            // 9. DetectedIssue.evidence
            public ElementDefinitionInfo Evidence;                                                                                          // MakerGen.cs:216
            // 12. DetectedIssue.detail
            public ElementDefinitionInfo Detail;                                                                                            // MakerGen.cs:216
            // 13. DetectedIssue.reference
            public ElementDefinitionInfo Reference;                                                                                         // MakerGen.cs:216
            // 14. DetectedIssue.mitigation
            public ElementDefinitionInfo Mitigation;                                                                                        // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
            public DetectedIssue_Elements()                                                                                                 // MakerGen.cs:392
            {                                                                                                                               // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:231
                    // 1. DetectedIssue.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "DetectedIssue.identifier",                                                                                   // MakerGen.cs:236
                        Id = "DetectedIssue.identifier",                                                                                    // MakerGen.cs:237
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
                    // 2. DetectedIssue.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Status",                                                                                                    // MakerGen.cs:235
                        Path= "DetectedIssue.status",                                                                                       // MakerGen.cs:236
                        Id = "DetectedIssue.status",                                                                                        // MakerGen.cs:237
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
                    // 3. DetectedIssue.code
                    this.Code = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Code",                                                                                                      // MakerGen.cs:235
                        Path= "DetectedIssue.code",                                                                                         // MakerGen.cs:236
                        Id = "DetectedIssue.code",                                                                                          // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 4. DetectedIssue.severity
                    this.Severity = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Severity",                                                                                                  // MakerGen.cs:235
                        Path= "DetectedIssue.severity",                                                                                     // MakerGen.cs:236
                        Id = "DetectedIssue.severity",                                                                                      // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
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
                    // 5. DetectedIssue.patient
                    this.Patient = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Patient",                                                                                                   // MakerGen.cs:235
                        Path= "DetectedIssue.patient",                                                                                      // MakerGen.cs:236
                        Id = "DetectedIssue.patient",                                                                                       // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient"                                                       // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 6. DetectedIssue.identified[x]
                    this.Identified = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identified",                                                                                                // MakerGen.cs:235
                        Path= "DetectedIssue.identified[x]",                                                                                // MakerGen.cs:236
                        Id = "DetectedIssue.identified[x]",                                                                                 // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            },                                                                                                              // MakerGen.cs:304
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 7. DetectedIssue.author
                    this.Author = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Author",                                                                                                    // MakerGen.cs:235
                        Path= "DetectedIssue.author",                                                                                       // MakerGen.cs:236
                        Id = "DetectedIssue.author",                                                                                        // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Device"                                                        // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 8. DetectedIssue.implicated
                    this.Implicated = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Implicated",                                                                                                // MakerGen.cs:235
                        Path= "DetectedIssue.implicated",                                                                                   // MakerGen.cs:236
                        Id = "DetectedIssue.implicated",                                                                                    // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Resource"                                                      // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 9. DetectedIssue.evidence
                    this.Evidence = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Evidence",                                                                                                  // MakerGen.cs:235
                        Path= "DetectedIssue.evidence",                                                                                     // MakerGen.cs:236
                        Id = "DetectedIssue.evidence",                                                                                      // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Evidence                                                                                               // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 12. DetectedIssue.detail
                    this.Detail = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Detail",                                                                                                    // MakerGen.cs:235
                        Path= "DetectedIssue.detail",                                                                                       // MakerGen.cs:236
                        Id = "DetectedIssue.detail",                                                                                        // MakerGen.cs:237
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
                    // 13. DetectedIssue.reference
                    this.Reference = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Reference",                                                                                                 // MakerGen.cs:235
                        Path= "DetectedIssue.reference",                                                                                    // MakerGen.cs:236
                        Id = "DetectedIssue.reference",                                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Uri                                                                         // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 14. DetectedIssue.mitigation
                    this.Mitigation = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Mitigation",                                                                                                // MakerGen.cs:235
                        Path= "DetectedIssue.mitigation",                                                                                   // MakerGen.cs:236
                        Id = "DetectedIssue.mitigation",                                                                                    // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Mitigation                                                                                             // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:398
            {                                                                                                                               // MakerGen.cs:399
                base.Write(sDef);                                                                                                           // MakerGen.cs:400
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:220
                Status.Write(sDef);                                                                                                         // MakerGen.cs:220
                Code.Write(sDef);                                                                                                           // MakerGen.cs:220
                Severity.Write(sDef);                                                                                                       // MakerGen.cs:220
                Patient.Write(sDef);                                                                                                        // MakerGen.cs:220
                Identified.Write(sDef);                                                                                                     // MakerGen.cs:220
                Author.Write(sDef);                                                                                                         // MakerGen.cs:220
                Implicated.Write(sDef);                                                                                                     // MakerGen.cs:220
                Evidence.Write(sDef);                                                                                                       // MakerGen.cs:220
                Detail.Write(sDef);                                                                                                         // MakerGen.cs:220
                Reference.Write(sDef);                                                                                                      // MakerGen.cs:220
                Mitigation.Write(sDef);                                                                                                     // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:402
        }                                                                                                                                   // MakerGen.cs:404
        public DetectedIssue_Elements Elements                                                                                              // MakerGen.cs:406
        {                                                                                                                                   // MakerGen.cs:407
            get                                                                                                                             // MakerGen.cs:408
            {                                                                                                                               // MakerGen.cs:409
                if (this.elements == null)                                                                                                  // MakerGen.cs:410
                    this.elements = new DetectedIssue_Elements();                                                                           // MakerGen.cs:411
                return this.elements;                                                                                                       // MakerGen.cs:412
            }                                                                                                                               // MakerGen.cs:413
        }                                                                                                                                   // MakerGen.cs:414
        DetectedIssue_Elements elements;                                                                                                    // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
        public DetectedIssue()                                                                                                              // MakerGen.cs:418
        {                                                                                                                                   // MakerGen.cs:419
            this.Name = "DetectedIssue";                                                                                                    // MakerGen.cs:492
            this.Uri = "http://hl7.org/fhir/StructureDefinition/DetectedIssue";                                                             // MakerGen.cs:493
        }                                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:424
        {                                                                                                                                   // MakerGen.cs:425
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:426
            {                                                                                                                               // MakerGen.cs:427
                Path = "DetectedIssue",                                                                                                     // MakerGen.cs:428
                ElementId = "DetectedIssue"                                                                                                 // MakerGen.cs:429
            });                                                                                                                             // MakerGen.cs:430
            if (this.elements != null)                                                                                                      // MakerGen.cs:431
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:432
        }                                                                                                                                   // MakerGen.cs:433
    }                                                                                                                                       // MakerGen.cs:434
}                                                                                                                                           // MakerGen.cs:479
