using System;                                                                                                                               // MakerGen.cs:428
using System.Diagnostics;                                                                                                                   // MakerGen.cs:429
using System.IO;                                                                                                                            // MakerGen.cs:430
using System.Linq;                                                                                                                          // MakerGen.cs:431
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:432
                                                                                                                                            // MakerGen.cs:433
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:434
{                                                                                                                                           // MakerGen.cs:435
    #region Json                                                                                                                            // MakerGen.cs:436
    #if NEVER                                                                                                                               // MakerGen.cs:437
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
    #endregion                                                                                                                              // MakerGen.cs:440
    /// <summary>
    /// Fhir resource 'ImmunizationEvaluation'
    /// </summary>
    // 0. ImmunizationEvaluation
    public class Resource_ImmunizationEvaluation : FhirKhit.Maker.Common.Resource.ResourceBase                                              // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 1. ImmunizationEvaluation.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:212
        // 2. ImmunizationEvaluation.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:212
        // 3. ImmunizationEvaluation.patient
        public ElementDefinitionInfo Element_Patient;                                                                                       // MakerGen.cs:212
        // 4. ImmunizationEvaluation.date
        public ElementDefinitionInfo Element_Date;                                                                                          // MakerGen.cs:212
        // 5. ImmunizationEvaluation.authority
        public ElementDefinitionInfo Element_Authority;                                                                                     // MakerGen.cs:212
        // 6. ImmunizationEvaluation.targetDisease
        public ElementDefinitionInfo Element_TargetDisease;                                                                                 // MakerGen.cs:212
        // 7. ImmunizationEvaluation.immunizationEvent
        public ElementDefinitionInfo Element_ImmunizationEvent;                                                                             // MakerGen.cs:212
        // 8. ImmunizationEvaluation.doseStatus
        public ElementDefinitionInfo Element_DoseStatus;                                                                                    // MakerGen.cs:212
        // 9. ImmunizationEvaluation.doseStatusReason
        public ElementDefinitionInfo Element_DoseStatusReason;                                                                              // MakerGen.cs:212
        // 10. ImmunizationEvaluation.description
        public ElementDefinitionInfo Element_Description;                                                                                   // MakerGen.cs:212
        // 11. ImmunizationEvaluation.series
        public ElementDefinitionInfo Element_Series;                                                                                        // MakerGen.cs:212
        // 12. ImmunizationEvaluation.doseNumber[x]
        public ElementDefinitionInfo Element_DoseNumber;                                                                                    // MakerGen.cs:212
        // 13. ImmunizationEvaluation.seriesDoses[x]
        public ElementDefinitionInfo Element_SeriesDoses;                                                                                   // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "ImmunizationEvaluation",                                                                                            // MakerGen.cs:388
                ElementId = "ImmunizationEvaluation"                                                                                        // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Patient.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Date.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Authority.Write(sDef);                                                                                                  // MakerGen.cs:216
            Element_TargetDisease.Write(sDef);                                                                                              // MakerGen.cs:216
            Element_ImmunizationEvent.Write(sDef);                                                                                          // MakerGen.cs:216
            Element_DoseStatus.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_DoseStatusReason.Write(sDef);                                                                                           // MakerGen.cs:216
            Element_Description.Write(sDef);                                                                                                // MakerGen.cs:216
            Element_Series.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_DoseNumber.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_SeriesDoses.Write(sDef);                                                                                                // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Resource_ImmunizationEvaluation()                                                                                            // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. ImmunizationEvaluation.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:231
                    Path= "ImmunizationEvaluation.identifier",                                                                              // MakerGen.cs:232
                    Id = "ImmunizationEvaluation.identifier",                                                                               // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 2. ImmunizationEvaluation.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Status",                                                                                                // MakerGen.cs:231
                    Path= "ImmunizationEvaluation.status",                                                                                  // MakerGen.cs:232
                    Id = "ImmunizationEvaluation.status",                                                                                   // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 3. ImmunizationEvaluation.patient
                this.Element_Patient = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Patient",                                                                                               // MakerGen.cs:231
                    Path= "ImmunizationEvaluation.patient",                                                                                 // MakerGen.cs:232
                    Id = "ImmunizationEvaluation.patient",                                                                                  // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Patient"                                                           // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 4. ImmunizationEvaluation.date
                this.Element_Date = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Date",                                                                                                  // MakerGen.cs:231
                    Path= "ImmunizationEvaluation.date",                                                                                    // MakerGen.cs:232
                    Id = "ImmunizationEvaluation.date",                                                                                     // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 5. ImmunizationEvaluation.authority
                this.Element_Authority = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Authority",                                                                                             // MakerGen.cs:231
                    Path= "ImmunizationEvaluation.authority",                                                                               // MakerGen.cs:232
                    Id = "ImmunizationEvaluation.authority",                                                                                // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 6. ImmunizationEvaluation.targetDisease
                this.Element_TargetDisease = new ElementDefinitionInfo                                                                      // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_TargetDisease",                                                                                         // MakerGen.cs:231
                    Path= "ImmunizationEvaluation.targetDisease",                                                                           // MakerGen.cs:232
                    Id = "ImmunizationEvaluation.targetDisease",                                                                            // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 7. ImmunizationEvaluation.immunizationEvent
                this.Element_ImmunizationEvent = new ElementDefinitionInfo                                                                  // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_ImmunizationEvent",                                                                                     // MakerGen.cs:231
                    Path= "ImmunizationEvaluation.immunizationEvent",                                                                       // MakerGen.cs:232
                    Id = "ImmunizationEvaluation.immunizationEvent",                                                                        // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Immunization"                                                      // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 8. ImmunizationEvaluation.doseStatus
                this.Element_DoseStatus = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_DoseStatus",                                                                                            // MakerGen.cs:231
                    Path= "ImmunizationEvaluation.doseStatus",                                                                              // MakerGen.cs:232
                    Id = "ImmunizationEvaluation.doseStatus",                                                                               // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 9. ImmunizationEvaluation.doseStatusReason
                this.Element_DoseStatusReason = new ElementDefinitionInfo                                                                   // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_DoseStatusReason",                                                                                      // MakerGen.cs:231
                    Path= "ImmunizationEvaluation.doseStatusReason",                                                                        // MakerGen.cs:232
                    Id = "ImmunizationEvaluation.doseStatusReason",                                                                         // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 10. ImmunizationEvaluation.description
                this.Element_Description = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Description",                                                                                           // MakerGen.cs:231
                    Path= "ImmunizationEvaluation.description",                                                                             // MakerGen.cs:232
                    Id = "ImmunizationEvaluation.description",                                                                              // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 11. ImmunizationEvaluation.series
                this.Element_Series = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Series",                                                                                                // MakerGen.cs:231
                    Path= "ImmunizationEvaluation.series",                                                                                  // MakerGen.cs:232
                    Id = "ImmunizationEvaluation.series",                                                                                   // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 12. ImmunizationEvaluation.doseNumber[x]
                this.Element_DoseNumber = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_DoseNumber",                                                                                            // MakerGen.cs:231
                    Path= "ImmunizationEvaluation.doseNumber[x]",                                                                           // MakerGen.cs:232
                    Id = "ImmunizationEvaluation.doseNumber[x]",                                                                            // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt                                                           // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        },                                                                                                                  // MakerGen.cs:300
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 13. ImmunizationEvaluation.seriesDoses[x]
                this.Element_SeriesDoses = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_SeriesDoses",                                                                                           // MakerGen.cs:231
                    Path= "ImmunizationEvaluation.seriesDoses[x]",                                                                          // MakerGen.cs:232
                    Id = "ImmunizationEvaluation.seriesDoses[x]",                                                                           // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt                                                           // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        },                                                                                                                  // MakerGen.cs:300
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            this.Name = "ImmunizationEvaluation";                                                                                           // MakerGen.cs:458
            this.Uri = "http://hl7.org/fhir/StructureDefinition/ImmunizationEvaluation";                                                    // MakerGen.cs:459
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:445
