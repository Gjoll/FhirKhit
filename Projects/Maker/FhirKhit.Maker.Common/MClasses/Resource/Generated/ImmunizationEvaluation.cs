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
      "id": "ImmunizationEvaluation",
      "url": "http://hl7.org/fhir/StructureDefinition/ImmunizationEvaluation",
      "version": "4.0.0",
      "name": "ImmunizationEvaluation",
      "status": "draft",
      "publisher": "Health Level Seven International (Public Health and Emergency Response)",
      "description": "Describes a comparison of an immunization event against published recommendations to determine if the administration is \"valid\" in relation to those  recommendations.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "ImmunizationEvaluation",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "ImmunizationEvaluation",
            "path": "ImmunizationEvaluation",
            "short": "Immunization evaluation information",
            "definition": "Describes a comparison of an immunization event against published recommendations to determine if the administration is \"valid\" in relation to those  recommendations.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "ImmunizationEvaluation.identifier",
            "path": "ImmunizationEvaluation.identifier",
            "short": "Business identifier",
            "definition": "A unique identifier assigned to this immunization evaluation record.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ]
          },
          {
            "id": "ImmunizationEvaluation.status",
            "path": "ImmunizationEvaluation.status",
            "short": "completed | entered-in-error",
            "definition": "Indicates the current status of the evaluation of the vaccination administration event.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element is labelled as a modifier because it is a status element that contains status entered-in-error which means that the resource should not be treated as valid).",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ImmunizationEvaluationStatus"
                }
              ],
              "strength": "required",
              "description": "The status of the evaluation being done.",
              "valueSet": "http://hl7.org/fhir/ValueSet/immunization-evaluation-status|4.0.0"
            }
          },
          {
            "id": "ImmunizationEvaluation.patient",
            "path": "ImmunizationEvaluation.patient",
            "short": "Who this evaluation is for",
            "definition": "The individual for whom the evaluation is being done.",
            "min": 1,
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
            "id": "ImmunizationEvaluation.date",
            "path": "ImmunizationEvaluation.date",
            "short": "Date evaluation was performed",
            "definition": "The date the evaluation of the vaccine administration event was performed.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ]
          },
          {
            "id": "ImmunizationEvaluation.authority",
            "path": "ImmunizationEvaluation.authority",
            "short": "Who is responsible for publishing the recommendations",
            "definition": "Indicates the authority who published the protocol (e.g. ACIP).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ]
          },
          {
            "id": "ImmunizationEvaluation.targetDisease",
            "path": "ImmunizationEvaluation.targetDisease",
            "short": "Evaluation target disease",
            "definition": "The vaccine preventable disease the dose is being evaluated against.",
            "min": 1,
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
                  "valueString": "EvaluationTargetDisease"
                }
              ],
              "strength": "example",
              "description": "The vaccine preventable disease the dose is being evaluated against.",
              "valueSet": "http://hl7.org/fhir/ValueSet/immunization-evaluation-target-disease"
            }
          },
          {
            "id": "ImmunizationEvaluation.immunizationEvent",
            "path": "ImmunizationEvaluation.immunizationEvent",
            "short": "Immunization being evaluated",
            "definition": "The vaccine administration event being evaluated.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Immunization"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ImmunizationEvaluation.doseStatus",
            "path": "ImmunizationEvaluation.doseStatus",
            "short": "Status of the dose relative to published recommendations",
            "definition": "Indicates if the dose is valid or not valid with respect to the published recommendations.",
            "min": 1,
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
                  "valueString": "EvaluationDoseStatus"
                }
              ],
              "strength": "example",
              "description": "The status of the administered dose relative to the published recommendations for the target disease.",
              "valueSet": "http://hl7.org/fhir/ValueSet/immunization-evaluation-dose-status"
            }
          },
          {
            "id": "ImmunizationEvaluation.doseStatusReason",
            "path": "ImmunizationEvaluation.doseStatusReason",
            "short": "Reason for the dose status",
            "definition": "Provides an explanation as to why the vaccine administration event is valid or not relative to the published recommendations.",
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
                  "valueString": "EvaluationDoseStatusReason"
                }
              ],
              "strength": "example",
              "description": "The reason the dose status was assigned.",
              "valueSet": "http://hl7.org/fhir/ValueSet/immunization-evaluation-dose-status-reason"
            }
          },
          {
            "id": "ImmunizationEvaluation.description",
            "path": "ImmunizationEvaluation.description",
            "short": "Evaluation notes",
            "definition": "Additional information about the evaluation.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ImmunizationEvaluation.series",
            "path": "ImmunizationEvaluation.series",
            "short": "Name of vaccine series",
            "definition": "One possible path to achieve presumed immunity against a disease - within the context of an authority.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ImmunizationEvaluation.doseNumber[x]",
            "path": "ImmunizationEvaluation.doseNumber[x]",
            "short": "Dose number within series",
            "definition": "Nominal position in a series.",
            "comment": "The use of an integer is preferred if known. A string should only be used in cases where an integer is not available (such as when documenting a recurring booster dose).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              },
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ImmunizationEvaluation.seriesDoses[x]",
            "path": "ImmunizationEvaluation.seriesDoses[x]",
            "short": "Recommended number of doses for immunity",
            "definition": "The recommended number of doses to achieve immunity.",
            "comment": "The use of an integer is preferred if known. A string should only be used in cases where an integer is not available (such as when documenting a recurring booster dose).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              },
              {
                "code": "string"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:474
    /// <summary>
    /// Fhir resource 'ImmunizationEvaluation'
    /// </summary>
    // 0. ImmunizationEvaluation
    public class ImmunizationEvaluation : FhirKhit.Maker.Common.Resource.ResourceBase                                                       // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        public class ImmunizationEvaluation_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                          // MakerGen.cs:386
        {                                                                                                                                   // MakerGen.cs:387
            // 1. ImmunizationEvaluation.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 2. ImmunizationEvaluation.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:216
            // 3. ImmunizationEvaluation.patient
            public ElementDefinitionInfo Patient;                                                                                           // MakerGen.cs:216
            // 4. ImmunizationEvaluation.date
            public ElementDefinitionInfo Date;                                                                                              // MakerGen.cs:216
            // 5. ImmunizationEvaluation.authority
            public ElementDefinitionInfo Authority;                                                                                         // MakerGen.cs:216
            // 6. ImmunizationEvaluation.targetDisease
            public ElementDefinitionInfo TargetDisease;                                                                                     // MakerGen.cs:216
            // 7. ImmunizationEvaluation.immunizationEvent
            public ElementDefinitionInfo ImmunizationEvent;                                                                                 // MakerGen.cs:216
            // 8. ImmunizationEvaluation.doseStatus
            public ElementDefinitionInfo DoseStatus;                                                                                        // MakerGen.cs:216
            // 9. ImmunizationEvaluation.doseStatusReason
            public ElementDefinitionInfo DoseStatusReason;                                                                                  // MakerGen.cs:216
            // 10. ImmunizationEvaluation.description
            public ElementDefinitionInfo Description;                                                                                       // MakerGen.cs:216
            // 11. ImmunizationEvaluation.series
            public ElementDefinitionInfo Series;                                                                                            // MakerGen.cs:216
            // 12. ImmunizationEvaluation.doseNumber[x]
            public ElementDefinitionInfo DoseNumber;                                                                                        // MakerGen.cs:216
            // 13. ImmunizationEvaluation.seriesDoses[x]
            public ElementDefinitionInfo SeriesDoses;                                                                                       // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
            public ImmunizationEvaluation_Elements()                                                                                        // MakerGen.cs:392
            {                                                                                                                               // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:231
                    // 1. ImmunizationEvaluation.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "ImmunizationEvaluation.identifier",                                                                          // MakerGen.cs:236
                        Id = "ImmunizationEvaluation.identifier",                                                                           // MakerGen.cs:237
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
                    // 2. ImmunizationEvaluation.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Status",                                                                                                    // MakerGen.cs:235
                        Path= "ImmunizationEvaluation.status",                                                                              // MakerGen.cs:236
                        Id = "ImmunizationEvaluation.status",                                                                               // MakerGen.cs:237
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
                    // 3. ImmunizationEvaluation.patient
                    this.Patient = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Patient",                                                                                                   // MakerGen.cs:235
                        Path= "ImmunizationEvaluation.patient",                                                                             // MakerGen.cs:236
                        Id = "ImmunizationEvaluation.patient",                                                                              // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
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
                    // 4. ImmunizationEvaluation.date
                    this.Date = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Date",                                                                                                      // MakerGen.cs:235
                        Path= "ImmunizationEvaluation.date",                                                                                // MakerGen.cs:236
                        Id = "ImmunizationEvaluation.date",                                                                                 // MakerGen.cs:237
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
                    // 5. ImmunizationEvaluation.authority
                    this.Authority = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Authority",                                                                                                 // MakerGen.cs:235
                        Path= "ImmunizationEvaluation.authority",                                                                           // MakerGen.cs:236
                        Id = "ImmunizationEvaluation.authority",                                                                            // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 6. ImmunizationEvaluation.targetDisease
                    this.TargetDisease = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "TargetDisease",                                                                                             // MakerGen.cs:235
                        Path= "ImmunizationEvaluation.targetDisease",                                                                       // MakerGen.cs:236
                        Id = "ImmunizationEvaluation.targetDisease",                                                                        // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
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
                    // 7. ImmunizationEvaluation.immunizationEvent
                    this.ImmunizationEvent = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ImmunizationEvent",                                                                                         // MakerGen.cs:235
                        Path= "ImmunizationEvaluation.immunizationEvent",                                                                   // MakerGen.cs:236
                        Id = "ImmunizationEvaluation.immunizationEvent",                                                                    // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Immunization"                                                  // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 8. ImmunizationEvaluation.doseStatus
                    this.DoseStatus = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "DoseStatus",                                                                                                // MakerGen.cs:235
                        Path= "ImmunizationEvaluation.doseStatus",                                                                          // MakerGen.cs:236
                        Id = "ImmunizationEvaluation.doseStatus",                                                                           // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
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
                    // 9. ImmunizationEvaluation.doseStatusReason
                    this.DoseStatusReason = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "DoseStatusReason",                                                                                          // MakerGen.cs:235
                        Path= "ImmunizationEvaluation.doseStatusReason",                                                                    // MakerGen.cs:236
                        Id = "ImmunizationEvaluation.doseStatusReason",                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 10. ImmunizationEvaluation.description
                    this.Description = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Description",                                                                                               // MakerGen.cs:235
                        Path= "ImmunizationEvaluation.description",                                                                         // MakerGen.cs:236
                        Id = "ImmunizationEvaluation.description",                                                                          // MakerGen.cs:237
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
                    // 11. ImmunizationEvaluation.series
                    this.Series = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Series",                                                                                                    // MakerGen.cs:235
                        Path= "ImmunizationEvaluation.series",                                                                              // MakerGen.cs:236
                        Id = "ImmunizationEvaluation.series",                                                                               // MakerGen.cs:237
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
                    // 12. ImmunizationEvaluation.doseNumber[x]
                    this.DoseNumber = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "DoseNumber",                                                                                                // MakerGen.cs:235
                        Path= "ImmunizationEvaluation.doseNumber[x]",                                                                       // MakerGen.cs:236
                        Id = "ImmunizationEvaluation.doseNumber[x]",                                                                        // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.PositiveInt                                                                 // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            },                                                                                                              // MakerGen.cs:304
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 13. ImmunizationEvaluation.seriesDoses[x]
                    this.SeriesDoses = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "SeriesDoses",                                                                                               // MakerGen.cs:235
                        Path= "ImmunizationEvaluation.seriesDoses[x]",                                                                      // MakerGen.cs:236
                        Id = "ImmunizationEvaluation.seriesDoses[x]",                                                                       // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.PositiveInt                                                                 // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            },                                                                                                              // MakerGen.cs:304
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
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
                Patient.Write(sDef);                                                                                                        // MakerGen.cs:220
                Date.Write(sDef);                                                                                                           // MakerGen.cs:220
                Authority.Write(sDef);                                                                                                      // MakerGen.cs:220
                TargetDisease.Write(sDef);                                                                                                  // MakerGen.cs:220
                ImmunizationEvent.Write(sDef);                                                                                              // MakerGen.cs:220
                DoseStatus.Write(sDef);                                                                                                     // MakerGen.cs:220
                DoseStatusReason.Write(sDef);                                                                                               // MakerGen.cs:220
                Description.Write(sDef);                                                                                                    // MakerGen.cs:220
                Series.Write(sDef);                                                                                                         // MakerGen.cs:220
                DoseNumber.Write(sDef);                                                                                                     // MakerGen.cs:220
                SeriesDoses.Write(sDef);                                                                                                    // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:402
        }                                                                                                                                   // MakerGen.cs:404
        public ImmunizationEvaluation_Elements Elements                                                                                     // MakerGen.cs:406
        {                                                                                                                                   // MakerGen.cs:407
            get                                                                                                                             // MakerGen.cs:408
            {                                                                                                                               // MakerGen.cs:409
                if (this.elements == null)                                                                                                  // MakerGen.cs:410
                    this.elements = new ImmunizationEvaluation_Elements();                                                                  // MakerGen.cs:411
                return this.elements;                                                                                                       // MakerGen.cs:412
            }                                                                                                                               // MakerGen.cs:413
        }                                                                                                                                   // MakerGen.cs:414
        ImmunizationEvaluation_Elements elements;                                                                                           // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
        public ImmunizationEvaluation()                                                                                                     // MakerGen.cs:418
        {                                                                                                                                   // MakerGen.cs:419
            this.Name = "ImmunizationEvaluation";                                                                                           // MakerGen.cs:492
            this.Uri = "http://hl7.org/fhir/StructureDefinition/ImmunizationEvaluation";                                                    // MakerGen.cs:493
        }                                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:424
        {                                                                                                                                   // MakerGen.cs:425
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:426
            {                                                                                                                               // MakerGen.cs:427
                Path = "ImmunizationEvaluation",                                                                                            // MakerGen.cs:428
                ElementId = "ImmunizationEvaluation"                                                                                        // MakerGen.cs:429
            });                                                                                                                             // MakerGen.cs:430
            if (this.elements != null)                                                                                                      // MakerGen.cs:431
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:432
        }                                                                                                                                   // MakerGen.cs:433
    }                                                                                                                                       // MakerGen.cs:434
}                                                                                                                                           // MakerGen.cs:479
