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
    #endregion                                                                                                                              // MakerGen.cs:466
    /// <summary>
    /// Fhir resource 'ImmunizationEvaluation'
    /// </summary>
    // 0. ImmunizationEvaluation
    public class Resource_ImmunizationEvaluation : FhirKhit.Maker.Common.Resource.ResourceBase                                              // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        public class Resource_ImmunizationEvaluation_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                 // MakerGen.cs:378
        {                                                                                                                                   // MakerGen.cs:379
            // 1. ImmunizationEvaluation.identifier
            public ElementDefinitionInfo Element_Identifier;                                                                                // MakerGen.cs:211
            // 2. ImmunizationEvaluation.status
            public ElementDefinitionInfo Element_Status;                                                                                    // MakerGen.cs:211
            // 3. ImmunizationEvaluation.patient
            public ElementDefinitionInfo Element_Patient;                                                                                   // MakerGen.cs:211
            // 4. ImmunizationEvaluation.date
            public ElementDefinitionInfo Element_Date;                                                                                      // MakerGen.cs:211
            // 5. ImmunizationEvaluation.authority
            public ElementDefinitionInfo Element_Authority;                                                                                 // MakerGen.cs:211
            // 6. ImmunizationEvaluation.targetDisease
            public ElementDefinitionInfo Element_TargetDisease;                                                                             // MakerGen.cs:211
            // 7. ImmunizationEvaluation.immunizationEvent
            public ElementDefinitionInfo Element_ImmunizationEvent;                                                                         // MakerGen.cs:211
            // 8. ImmunizationEvaluation.doseStatus
            public ElementDefinitionInfo Element_DoseStatus;                                                                                // MakerGen.cs:211
            // 9. ImmunizationEvaluation.doseStatusReason
            public ElementDefinitionInfo Element_DoseStatusReason;                                                                          // MakerGen.cs:211
            // 10. ImmunizationEvaluation.description
            public ElementDefinitionInfo Element_Description;                                                                               // MakerGen.cs:211
            // 11. ImmunizationEvaluation.series
            public ElementDefinitionInfo Element_Series;                                                                                    // MakerGen.cs:211
            // 12. ImmunizationEvaluation.doseNumber[x]
            public ElementDefinitionInfo Element_DoseNumber;                                                                                // MakerGen.cs:211
            // 13. ImmunizationEvaluation.seriesDoses[x]
            public ElementDefinitionInfo Element_SeriesDoses;                                                                               // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
            public Resource_ImmunizationEvaluation_Elements()                                                                               // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:226
                    // 1. ImmunizationEvaluation.identifier
                    this.Element_Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Identifier",                                                                                        // MakerGen.cs:230
                        Path= "ImmunizationEvaluation.identifier",                                                                          // MakerGen.cs:231
                        Id = "ImmunizationEvaluation.identifier",                                                                           // MakerGen.cs:232
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
                    // 2. ImmunizationEvaluation.status
                    this.Element_Status = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Status",                                                                                            // MakerGen.cs:230
                        Path= "ImmunizationEvaluation.status",                                                                              // MakerGen.cs:231
                        Id = "ImmunizationEvaluation.status",                                                                               // MakerGen.cs:232
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
                    // 3. ImmunizationEvaluation.patient
                    this.Element_Patient = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Patient",                                                                                           // MakerGen.cs:230
                        Path= "ImmunizationEvaluation.patient",                                                                             // MakerGen.cs:231
                        Id = "ImmunizationEvaluation.patient",                                                                              // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient"                                                       // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 4. ImmunizationEvaluation.date
                    this.Element_Date = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Date",                                                                                              // MakerGen.cs:230
                        Path= "ImmunizationEvaluation.date",                                                                                // MakerGen.cs:231
                        Id = "ImmunizationEvaluation.date",                                                                                 // MakerGen.cs:232
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
                    // 5. ImmunizationEvaluation.authority
                    this.Element_Authority = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Authority",                                                                                         // MakerGen.cs:230
                        Path= "ImmunizationEvaluation.authority",                                                                           // MakerGen.cs:231
                        Id = "ImmunizationEvaluation.authority",                                                                            // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 6. ImmunizationEvaluation.targetDisease
                    this.Element_TargetDisease = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_TargetDisease",                                                                                     // MakerGen.cs:230
                        Path= "ImmunizationEvaluation.targetDisease",                                                                       // MakerGen.cs:231
                        Id = "ImmunizationEvaluation.targetDisease",                                                                        // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 7. ImmunizationEvaluation.immunizationEvent
                    this.Element_ImmunizationEvent = new ElementDefinitionInfo                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_ImmunizationEvent",                                                                                 // MakerGen.cs:230
                        Path= "ImmunizationEvaluation.immunizationEvent",                                                                   // MakerGen.cs:231
                        Id = "ImmunizationEvaluation.immunizationEvent",                                                                    // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Immunization"                                                  // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 8. ImmunizationEvaluation.doseStatus
                    this.Element_DoseStatus = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_DoseStatus",                                                                                        // MakerGen.cs:230
                        Path= "ImmunizationEvaluation.doseStatus",                                                                          // MakerGen.cs:231
                        Id = "ImmunizationEvaluation.doseStatus",                                                                           // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 9. ImmunizationEvaluation.doseStatusReason
                    this.Element_DoseStatusReason = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_DoseStatusReason",                                                                                  // MakerGen.cs:230
                        Path= "ImmunizationEvaluation.doseStatusReason",                                                                    // MakerGen.cs:231
                        Id = "ImmunizationEvaluation.doseStatusReason",                                                                     // MakerGen.cs:232
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
                    // 10. ImmunizationEvaluation.description
                    this.Element_Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Description",                                                                                       // MakerGen.cs:230
                        Path= "ImmunizationEvaluation.description",                                                                         // MakerGen.cs:231
                        Id = "ImmunizationEvaluation.description",                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 11. ImmunizationEvaluation.series
                    this.Element_Series = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Series",                                                                                            // MakerGen.cs:230
                        Path= "ImmunizationEvaluation.series",                                                                              // MakerGen.cs:231
                        Id = "ImmunizationEvaluation.series",                                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 12. ImmunizationEvaluation.doseNumber[x]
                    this.Element_DoseNumber = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_DoseNumber",                                                                                        // MakerGen.cs:230
                        Path= "ImmunizationEvaluation.doseNumber[x]",                                                                       // MakerGen.cs:231
                        Id = "ImmunizationEvaluation.doseNumber[x]",                                                                        // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.PositiveInt                                                                 // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            },                                                                                                              // MakerGen.cs:299
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 13. ImmunizationEvaluation.seriesDoses[x]
                    this.Element_SeriesDoses = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_SeriesDoses",                                                                                       // MakerGen.cs:230
                        Path= "ImmunizationEvaluation.seriesDoses[x]",                                                                      // MakerGen.cs:231
                        Id = "ImmunizationEvaluation.seriesDoses[x]",                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.PositiveInt                                                                 // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            },                                                                                                              // MakerGen.cs:299
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                Element_Identifier.Write(sDef);                                                                                             // MakerGen.cs:215
                Element_Status.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_Patient.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_Date.Write(sDef);                                                                                                   // MakerGen.cs:215
                Element_Authority.Write(sDef);                                                                                              // MakerGen.cs:215
                Element_TargetDisease.Write(sDef);                                                                                          // MakerGen.cs:215
                Element_ImmunizationEvent.Write(sDef);                                                                                      // MakerGen.cs:215
                Element_DoseStatus.Write(sDef);                                                                                             // MakerGen.cs:215
                Element_DoseStatusReason.Write(sDef);                                                                                       // MakerGen.cs:215
                Element_Description.Write(sDef);                                                                                            // MakerGen.cs:215
                Element_Series.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_DoseNumber.Write(sDef);                                                                                             // MakerGen.cs:215
                Element_SeriesDoses.Write(sDef);                                                                                            // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:394
        }                                                                                                                                   // MakerGen.cs:396
        public Resource_ImmunizationEvaluation_Elements Elements                                                                            // MakerGen.cs:398
        {                                                                                                                                   // MakerGen.cs:399
            get                                                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                if (this.elements == null)                                                                                                  // MakerGen.cs:402
                    this.elements = new Resource_ImmunizationEvaluation_Elements();                                                         // MakerGen.cs:403
                return this.elements;                                                                                                       // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:406
        Resource_ImmunizationEvaluation_Elements elements;                                                                                  // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
        public Resource_ImmunizationEvaluation()                                                                                            // MakerGen.cs:410
        {                                                                                                                                   // MakerGen.cs:411
            this.Name = "ImmunizationEvaluation";                                                                                           // MakerGen.cs:484
            this.Uri = "http://hl7.org/fhir/StructureDefinition/ImmunizationEvaluation";                                                    // MakerGen.cs:485
        }                                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:416
        {                                                                                                                                   // MakerGen.cs:417
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:418
            {                                                                                                                               // MakerGen.cs:419
                Path = "ImmunizationEvaluation",                                                                                            // MakerGen.cs:420
                ElementId = "ImmunizationEvaluation"                                                                                        // MakerGen.cs:421
            });                                                                                                                             // MakerGen.cs:422
            if (this.elements != null)                                                                                                      // MakerGen.cs:423
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:424
        }                                                                                                                                   // MakerGen.cs:425
    }                                                                                                                                       // MakerGen.cs:426
}                                                                                                                                           // MakerGen.cs:471
