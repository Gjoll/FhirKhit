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
      "id": "Condition",
      "url": "http://hl7.org/fhir/StructureDefinition/Condition",
      "version": "4.0.0",
      "name": "Condition",
      "status": "draft",
      "publisher": "Health Level Seven International (Patient Care)",
      "description": "A clinical condition, problem, diagnosis, or other event, situation, issue, or clinical concept that has risen to a level of concern.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Condition",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Condition",
            "path": "Condition",
            "short": "Detailed information about conditions, problems or diagnoses",
            "definition": "A clinical condition, problem, diagnosis, or other event, situation, issue, or clinical concept that has risen to a level of concern.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Condition.identifier",
            "path": "Condition.identifier",
            "short": "External Ids for this condition",
            "definition": "Business identifiers assigned to this condition by the performer or other systems which remain constant as the resource is updated and propagates from server to server.",
            "comment": "This is a business identifier, not a resource identifier (see [discussion](resource.html#identifiers)).  It is best practice for the identifier to only appear on a single resource instance, however business practices may occasionally dictate that multiple resource instances with the same identifier can exist - possibly even with different resource types.  For example, multiple Patient and a Person resource instance might share the same social insurance number.",
            "requirements": "Allows identification of the condition as it is known by various participating systems and in a way that remains consistent across servers.",
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
            "id": "Condition.clinicalStatus",
            "path": "Condition.clinicalStatus",
            "short": "active | recurrence | relapse | inactive | remission | resolved",
            "definition": "The clinical status of the condition.",
            "comment": "The data type is CodeableConcept because clinicalStatus has some clinical judgment involved, such that there might need to be more specificity than the required FHIR value set allows. For example, a SNOMED coding might allow for additional specificity.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "condition": [
              "con-3",
              "con-4",
              "con-5"
            ],
            "isModifier": true,
            "isModifierReason": "This element is labeled as a modifier because the status contains codes that mark the condition as no longer active.",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ConditionClinicalStatus"
                }
              ],
              "strength": "required",
              "description": "The clinical status of the condition or diagnosis.",
              "valueSet": "http://hl7.org/fhir/ValueSet/condition-clinical|4.0.0"
            }
          },
          {
            "id": "Condition.verificationStatus",
            "path": "Condition.verificationStatus",
            "short": "unconfirmed | provisional | differential | confirmed | refuted | entered-in-error",
            "definition": "The verification status to support the clinical status of the condition.",
            "comment": "verificationStatus is not required.  For example, when a patient has abdominal pain in the ED, there is not likely going to be a verification status.\nThe data type is CodeableConcept because verificationStatus has some clinical judgment involved, such that there might need to be more specificity than the required FHIR value set allows. For example, a SNOMED coding might allow for additional specificity.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "condition": [
              "con-3",
              "con-5"
            ],
            "isModifier": true,
            "isModifierReason": "This element is labeled as a modifier because the status contains the code refuted and entered-in-error that mark the Condition as not currently valid.",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ConditionVerificationStatus"
                }
              ],
              "strength": "required",
              "description": "The verification status to support or decline the clinical status of the condition or diagnosis.",
              "valueSet": "http://hl7.org/fhir/ValueSet/condition-ver-status|4.0.0"
            }
          },
          {
            "id": "Condition.category",
            "path": "Condition.category",
            "short": "problem-list-item | encounter-diagnosis",
            "definition": "A category assigned to the condition.",
            "comment": "The categorization is often highly contextual and may appear poorly differentiated or not very useful in other contexts.",
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
                  "valueString": "ConditionCategory"
                }
              ],
              "strength": "extensible",
              "description": "A category assigned to the condition.",
              "valueSet": "http://hl7.org/fhir/ValueSet/condition-category"
            }
          },
          {
            "id": "Condition.severity",
            "path": "Condition.severity",
            "short": "Subjective severity of condition",
            "definition": "A subjective assessment of the severity of the condition as evaluated by the clinician.",
            "comment": "Coding of the severity with a terminology is preferred, where possible.",
            "min": 0,
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
                  "valueString": "ConditionSeverity"
                }
              ],
              "strength": "preferred",
              "description": "A subjective assessment of the severity of the condition as evaluated by the clinician.",
              "valueSet": "http://hl7.org/fhir/ValueSet/condition-severity"
            }
          },
          {
            "id": "Condition.code",
            "path": "Condition.code",
            "short": "Identification of the condition, problem or diagnosis",
            "definition": "Identification of the condition, problem or diagnosis.",
            "requirements": "0..1 to account for primarily narrative only resources.",
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
                  "valueString": "ConditionKind"
                }
              ],
              "strength": "example",
              "description": "Identification of the condition or diagnosis.",
              "valueSet": "http://hl7.org/fhir/ValueSet/condition-code"
            }
          },
          {
            "id": "Condition.bodySite",
            "path": "Condition.bodySite",
            "short": "Anatomical location, if relevant",
            "definition": "The anatomical location where this condition manifests itself.",
            "comment": "Only used if not implicit in code found in Condition.code. If the use case requires attributes from the BodySite resource (e.g. to identify and track separately) then use the standard extension [bodySite](extension-bodysite.html).  May be a summary code, or a reference to a very precise definition of the location, or both.",
            "min": 0,
            "max": "*",
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
                  "valueString": "BodySite"
                }
              ],
              "strength": "example",
              "description": "Codes describing anatomical locations. May include laterality.",
              "valueSet": "http://hl7.org/fhir/ValueSet/body-site"
            }
          },
          {
            "id": "Condition.subject",
            "path": "Condition.subject",
            "short": "Who has the condition?",
            "definition": "Indicates the patient or group who the condition record is associated with.",
            "requirements": "Group is typically used for veterinary or public health use cases.",
            "alias": [
              "patient"
            ],
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Group"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Condition.encounter",
            "path": "Condition.encounter",
            "short": "Encounter created as part of",
            "definition": "The Encounter during which this Condition was created or to which the creation of this record is tightly associated.",
            "comment": "This will typically be the encounter the event occurred within, but some activities may be initiated prior to or after the official completion of an encounter but still be tied to the context of the encounter. This record indicates the encounter this particular record is associated with.  In the case of a \"new\" diagnosis reflecting ongoing/revised information about the condition, this might be distinct from the first encounter in which the underlying condition was first \"known\".",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Encounter"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Condition.onset[x]",
            "path": "Condition.onset[x]",
            "short": "Estimated or actual date,  date-time, or age",
            "definition": "Estimated or actual date or date-time  the condition began, in the opinion of the clinician.",
            "comment": "Age is generally used when the patient reports an age at which the Condition began to occur.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              },
              {
                "code": "Age"
              },
              {
                "code": "Period"
              },
              {
                "code": "Range"
              },
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Condition.abatement[x]",
            "path": "Condition.abatement[x]",
            "short": "When in resolution/remission",
            "definition": "The date or estimated date that the condition resolved or went into remission. This is called \"abatement\" because of the many overloaded connotations associated with \"remission\" or \"resolution\" - Conditions are never really resolved, but they can abate.",
            "comment": "There is no explicit distinction between resolution and remission because in many cases the distinction is not clear. Age is generally used when the patient reports an age at which the Condition abated.  If there is no abatement element, it is unknown whether the condition has resolved or entered remission; applications and users should generally assume that the condition is still valid.  When abatementString exists, it implies the condition is abated.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              },
              {
                "code": "Age"
              },
              {
                "code": "Period"
              },
              {
                "code": "Range"
              },
              {
                "code": "string"
              }
            ],
            "condition": [
              "con-4"
            ]
          },
          {
            "id": "Condition.recordedDate",
            "path": "Condition.recordedDate",
            "short": "Date record was first recorded",
            "definition": "The recordedDate represents when this particular Condition record was created in the system, which is often a system-generated date.",
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
            "id": "Condition.recorder",
            "path": "Condition.recorder",
            "short": "Who recorded the condition",
            "definition": "Individual who recorded the record and takes responsibility for its content.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Condition.asserter",
            "path": "Condition.asserter",
            "short": "Person who asserts this condition",
            "definition": "Individual who is making the condition statement.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Condition.stage",
            "path": "Condition.stage",
            "short": "Stage/grade, usually assessed formally",
            "definition": "Clinical stage or grade of a condition. May include formal severity assessments.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Condition.stage.summary",
            "path": "Condition.stage.summary",
            "short": "Simple summary (disease specific)",
            "definition": "A simple summary of the stage such as \"Stage 3\". The determination of the stage is disease-specific.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "condition": [
              "con-1"
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ConditionStage"
                }
              ],
              "strength": "example",
              "description": "Codes describing condition stages (e.g. Cancer stages).",
              "valueSet": "http://hl7.org/fhir/ValueSet/condition-stage"
            }
          },
          {
            "id": "Condition.stage.assessment",
            "path": "Condition.stage.assessment",
            "short": "Formal record of assessment",
            "definition": "Reference to a formal record of the evidence on which the staging assessment is based.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ClinicalImpression",
                  "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",
                  "http://hl7.org/fhir/StructureDefinition/Observation"
                ]
              }
            ],
            "condition": [
              "con-1"
            ]
          },
          {
            "id": "Condition.stage.type",
            "path": "Condition.stage.type",
            "short": "Kind of staging",
            "definition": "The kind of staging, such as pathological or clinical staging.",
            "min": 0,
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
                  "valueString": "ConditionStageType"
                }
              ],
              "strength": "example",
              "description": "Codes describing the kind of condition staging (e.g. clinical or pathological).",
              "valueSet": "http://hl7.org/fhir/ValueSet/condition-stage-type"
            }
          },
          {
            "id": "Condition.evidence",
            "path": "Condition.evidence",
            "short": "Supporting evidence",
            "definition": "Supporting evidence / manifestations that are the basis of the Condition's verification status, such as evidence that confirmed or refuted the condition.",
            "comment": "The evidence may be a simple list of coded symptoms/manifestations, or references to observations or formal assessments, or both.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Condition.evidence.code",
            "path": "Condition.evidence.code",
            "short": "Manifestation/symptom",
            "definition": "A manifestation or symptom that led to the recording of this condition.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "condition": [
              "con-2"
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ManifestationOrSymptom"
                }
              ],
              "strength": "example",
              "description": "Codes that describe the manifestation or symptoms of a condition.",
              "valueSet": "http://hl7.org/fhir/ValueSet/manifestation-or-symptom"
            }
          },
          {
            "id": "Condition.evidence.detail",
            "path": "Condition.evidence.detail",
            "short": "Supporting information found elsewhere",
            "definition": "Links to other relevant information, including pathology reports.",
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
            "condition": [
              "con-2"
            ],
            "isSummary": true
          },
          {
            "id": "Condition.note",
            "path": "Condition.note",
            "short": "Additional information about the Condition",
            "definition": "Additional information about the Condition. This is a general notes/comments entry  for description of the Condition, its diagnosis and prognosis.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Annotation"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:466
    /// <summary>
    /// Fhir resource 'Condition'
    /// </summary>
    // 0. Condition
    public class Resource_Condition : FhirKhit.Maker.Common.Resource.ResourceBase                                                           // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        public class Resource_Condition_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                              // MakerGen.cs:378
        {                                                                                                                                   // MakerGen.cs:379
            // 15. Condition.stage
            public class Type_Stage : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_Stage_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                              // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 16. Condition.stage.summary
                    public ElementDefinitionInfo Element_Summary;                                                                           // MakerGen.cs:211
                    // 17. Condition.stage.assessment
                    public ElementDefinitionInfo Element_Assessment;                                                                        // MakerGen.cs:211
                    // 18. Condition.stage.type
                    public ElementDefinitionInfo Element_Type;                                                                              // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_Stage_Elements()                                                                                            // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 16. Condition.stage.summary
                            this.Element_Summary = new ElementDefinitionInfo                                                                // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Summary",                                                                                   // MakerGen.cs:230
                                Path= "Condition.stage.summary",                                                                            // MakerGen.cs:231
                                Id = "Condition.stage.summary",                                                                             // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 17. Condition.stage.assessment
                            this.Element_Assessment = new ElementDefinitionInfo                                                             // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Assessment",                                                                                // MakerGen.cs:230
                                Path= "Condition.stage.assessment",                                                                         // MakerGen.cs:231
                                Id = "Condition.stage.assessment",                                                                          // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Reference                                                        // MakerGen.cs:338
                                    {                                                                                                       // MakerGen.cs:339
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:341
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/ClinicalImpression",                                   // MakerGen.cs:341
                                            "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",                                     // MakerGen.cs:341
                                            "http://hl7.org/fhir/StructureDefinition/Observation"                                           // MakerGen.cs:341
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:342
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 18. Condition.stage.type
                            this.Element_Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Type",                                                                                      // MakerGen.cs:230
                                Path= "Condition.stage.type",                                                                               // MakerGen.cs:231
                                Id = "Condition.stage.type",                                                                                // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        Element_Summary.Write(sDef);                                                                                        // MakerGen.cs:215
                        Element_Assessment.Write(sDef);                                                                                     // MakerGen.cs:215
                        Element_Type.Write(sDef);                                                                                           // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_Stage_Elements Elements                                                                                         // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_Stage_Elements();                                                                      // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_Stage_Elements elements;                                                                                               // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_Stage()                                                                                                         // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "Condition.stage",                                                                                           // MakerGen.cs:420
                        ElementId = "Condition.stage"                                                                                       // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 19. Condition.evidence
            public class Type_Evidence : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_Evidence_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                           // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 20. Condition.evidence.code
                    public ElementDefinitionInfo Element_Code;                                                                              // MakerGen.cs:211
                    // 21. Condition.evidence.detail
                    public ElementDefinitionInfo Element_Detail;                                                                            // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_Evidence_Elements()                                                                                         // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 20. Condition.evidence.code
                            this.Element_Code = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Code",                                                                                      // MakerGen.cs:230
                                Path= "Condition.evidence.code",                                                                            // MakerGen.cs:231
                                Id = "Condition.evidence.code",                                                                             // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 21. Condition.evidence.detail
                            this.Element_Detail = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Detail",                                                                                    // MakerGen.cs:230
                                Path= "Condition.evidence.detail",                                                                          // MakerGen.cs:231
                                Id = "Condition.evidence.detail",                                                                           // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Reference                                                        // MakerGen.cs:338
                                    {                                                                                                       // MakerGen.cs:339
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:341
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Resource"                                              // MakerGen.cs:341
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:342
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        Element_Code.Write(sDef);                                                                                           // MakerGen.cs:215
                        Element_Detail.Write(sDef);                                                                                         // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_Evidence_Elements Elements                                                                                      // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_Evidence_Elements();                                                                   // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_Evidence_Elements elements;                                                                                            // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_Evidence()                                                                                                      // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "Condition.evidence",                                                                                        // MakerGen.cs:420
                        ElementId = "Condition.evidence"                                                                                    // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 1. Condition.identifier
            public ElementDefinitionInfo Element_Identifier;                                                                                // MakerGen.cs:211
            // 2. Condition.clinicalStatus
            public ElementDefinitionInfo Element_ClinicalStatus;                                                                            // MakerGen.cs:211
            // 3. Condition.verificationStatus
            public ElementDefinitionInfo Element_VerificationStatus;                                                                        // MakerGen.cs:211
            // 4. Condition.category
            public ElementDefinitionInfo Element_Category;                                                                                  // MakerGen.cs:211
            // 5. Condition.severity
            public ElementDefinitionInfo Element_Severity;                                                                                  // MakerGen.cs:211
            // 6. Condition.code
            public ElementDefinitionInfo Element_Code;                                                                                      // MakerGen.cs:211
            // 7. Condition.bodySite
            public ElementDefinitionInfo Element_BodySite;                                                                                  // MakerGen.cs:211
            // 8. Condition.subject
            public ElementDefinitionInfo Element_Subject;                                                                                   // MakerGen.cs:211
            // 9. Condition.encounter
            public ElementDefinitionInfo Element_Encounter;                                                                                 // MakerGen.cs:211
            // 10. Condition.onset[x]
            public ElementDefinitionInfo Element_Onset;                                                                                     // MakerGen.cs:211
            // 11. Condition.abatement[x]
            public ElementDefinitionInfo Element_Abatement;                                                                                 // MakerGen.cs:211
            // 12. Condition.recordedDate
            public ElementDefinitionInfo Element_RecordedDate;                                                                              // MakerGen.cs:211
            // 13. Condition.recorder
            public ElementDefinitionInfo Element_Recorder;                                                                                  // MakerGen.cs:211
            // 14. Condition.asserter
            public ElementDefinitionInfo Element_Asserter;                                                                                  // MakerGen.cs:211
            // 15. Condition.stage
            public ElementDefinitionInfo Element_Stage;                                                                                     // MakerGen.cs:211
            // 19. Condition.evidence
            public ElementDefinitionInfo Element_Evidence;                                                                                  // MakerGen.cs:211
            // 22. Condition.note
            public ElementDefinitionInfo Element_Note;                                                                                      // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
            public Resource_Condition_Elements()                                                                                            // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:226
                    // 1. Condition.identifier
                    this.Element_Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Identifier",                                                                                        // MakerGen.cs:230
                        Path= "Condition.identifier",                                                                                       // MakerGen.cs:231
                        Id = "Condition.identifier",                                                                                        // MakerGen.cs:232
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
                    // 2. Condition.clinicalStatus
                    this.Element_ClinicalStatus = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_ClinicalStatus",                                                                                    // MakerGen.cs:230
                        Path= "Condition.clinicalStatus",                                                                                   // MakerGen.cs:231
                        Id = "Condition.clinicalStatus",                                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
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
                    // 3. Condition.verificationStatus
                    this.Element_VerificationStatus = new ElementDefinitionInfo                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_VerificationStatus",                                                                                // MakerGen.cs:230
                        Path= "Condition.verificationStatus",                                                                               // MakerGen.cs:231
                        Id = "Condition.verificationStatus",                                                                                // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
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
                    // 4. Condition.category
                    this.Element_Category = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Category",                                                                                          // MakerGen.cs:230
                        Path= "Condition.category",                                                                                         // MakerGen.cs:231
                        Id = "Condition.category",                                                                                          // MakerGen.cs:232
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
                    // 5. Condition.severity
                    this.Element_Severity = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Severity",                                                                                          // MakerGen.cs:230
                        Path= "Condition.severity",                                                                                         // MakerGen.cs:231
                        Id = "Condition.severity",                                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
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
                    // 6. Condition.code
                    this.Element_Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Code",                                                                                              // MakerGen.cs:230
                        Path= "Condition.code",                                                                                             // MakerGen.cs:231
                        Id = "Condition.code",                                                                                              // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
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
                    // 7. Condition.bodySite
                    this.Element_BodySite = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_BodySite",                                                                                          // MakerGen.cs:230
                        Path= "Condition.bodySite",                                                                                         // MakerGen.cs:231
                        Id = "Condition.bodySite",                                                                                          // MakerGen.cs:232
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
                    // 8. Condition.subject
                    this.Element_Subject = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Subject",                                                                                           // MakerGen.cs:230
                        Path= "Condition.subject",                                                                                          // MakerGen.cs:231
                        Id = "Condition.subject",                                                                                           // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/Group"                                                         // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 9. Condition.encounter
                    this.Element_Encounter = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Encounter",                                                                                         // MakerGen.cs:230
                        Path= "Condition.encounter",                                                                                        // MakerGen.cs:231
                        Id = "Condition.encounter",                                                                                         // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Encounter"                                                     // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 10. Condition.onset[x]
                    this.Element_Onset = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Onset",                                                                                             // MakerGen.cs:230
                        Path= "Condition.onset[x]",                                                                                         // MakerGen.cs:231
                        Id = "Condition.onset[x]",                                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            },                                                                                                              // MakerGen.cs:299
                            new FhirKhit.Maker.Common.Complex.Type_Age                                                                      // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            },                                                                                                              // MakerGen.cs:352
                            new FhirKhit.Maker.Common.Complex.Type_Period                                                                   // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            },                                                                                                              // MakerGen.cs:352
                            new FhirKhit.Maker.Common.Complex.Type_Range                                                                    // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            },                                                                                                              // MakerGen.cs:352
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 11. Condition.abatement[x]
                    this.Element_Abatement = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Abatement",                                                                                         // MakerGen.cs:230
                        Path= "Condition.abatement[x]",                                                                                     // MakerGen.cs:231
                        Id = "Condition.abatement[x]",                                                                                      // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            },                                                                                                              // MakerGen.cs:299
                            new FhirKhit.Maker.Common.Complex.Type_Age                                                                      // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            },                                                                                                              // MakerGen.cs:352
                            new FhirKhit.Maker.Common.Complex.Type_Period                                                                   // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            },                                                                                                              // MakerGen.cs:352
                            new FhirKhit.Maker.Common.Complex.Type_Range                                                                    // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            },                                                                                                              // MakerGen.cs:352
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 12. Condition.recordedDate
                    this.Element_RecordedDate = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_RecordedDate",                                                                                      // MakerGen.cs:230
                        Path= "Condition.recordedDate",                                                                                     // MakerGen.cs:231
                        Id = "Condition.recordedDate",                                                                                      // MakerGen.cs:232
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
                    // 13. Condition.recorder
                    this.Element_Recorder = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Recorder",                                                                                          // MakerGen.cs:230
                        Path= "Condition.recorder",                                                                                         // MakerGen.cs:231
                        Id = "Condition.recorder",                                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                                 // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 14. Condition.asserter
                    this.Element_Asserter = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Asserter",                                                                                          // MakerGen.cs:230
                        Path= "Condition.asserter",                                                                                         // MakerGen.cs:231
                        Id = "Condition.asserter",                                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                                 // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 15. Condition.stage
                    this.Element_Stage = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Stage",                                                                                             // MakerGen.cs:230
                        Path= "Condition.stage",                                                                                            // MakerGen.cs:231
                        Id = "Condition.stage",                                                                                             // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Stage                                                                                                  // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 19. Condition.evidence
                    this.Element_Evidence = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Evidence",                                                                                          // MakerGen.cs:230
                        Path= "Condition.evidence",                                                                                         // MakerGen.cs:231
                        Id = "Condition.evidence",                                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Evidence                                                                                               // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 22. Condition.note
                    this.Element_Note = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Note",                                                                                              // MakerGen.cs:230
                        Path= "Condition.note",                                                                                             // MakerGen.cs:231
                        Id = "Condition.note",                                                                                              // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Annotation                                                               // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                Element_Identifier.Write(sDef);                                                                                             // MakerGen.cs:215
                Element_ClinicalStatus.Write(sDef);                                                                                         // MakerGen.cs:215
                Element_VerificationStatus.Write(sDef);                                                                                     // MakerGen.cs:215
                Element_Category.Write(sDef);                                                                                               // MakerGen.cs:215
                Element_Severity.Write(sDef);                                                                                               // MakerGen.cs:215
                Element_Code.Write(sDef);                                                                                                   // MakerGen.cs:215
                Element_BodySite.Write(sDef);                                                                                               // MakerGen.cs:215
                Element_Subject.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_Encounter.Write(sDef);                                                                                              // MakerGen.cs:215
                Element_Onset.Write(sDef);                                                                                                  // MakerGen.cs:215
                Element_Abatement.Write(sDef);                                                                                              // MakerGen.cs:215
                Element_RecordedDate.Write(sDef);                                                                                           // MakerGen.cs:215
                Element_Recorder.Write(sDef);                                                                                               // MakerGen.cs:215
                Element_Asserter.Write(sDef);                                                                                               // MakerGen.cs:215
                Element_Stage.Write(sDef);                                                                                                  // MakerGen.cs:215
                Element_Evidence.Write(sDef);                                                                                               // MakerGen.cs:215
                Element_Note.Write(sDef);                                                                                                   // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:394
        }                                                                                                                                   // MakerGen.cs:396
        public Resource_Condition_Elements Elements                                                                                         // MakerGen.cs:398
        {                                                                                                                                   // MakerGen.cs:399
            get                                                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                if (this.elements == null)                                                                                                  // MakerGen.cs:402
                    this.elements = new Resource_Condition_Elements();                                                                      // MakerGen.cs:403
                return this.elements;                                                                                                       // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:406
        Resource_Condition_Elements elements;                                                                                               // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
        public Resource_Condition()                                                                                                         // MakerGen.cs:410
        {                                                                                                                                   // MakerGen.cs:411
            this.Name = "Condition";                                                                                                        // MakerGen.cs:484
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Condition";                                                                 // MakerGen.cs:485
        }                                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:416
        {                                                                                                                                   // MakerGen.cs:417
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:418
            {                                                                                                                               // MakerGen.cs:419
                Path = "Condition",                                                                                                         // MakerGen.cs:420
                ElementId = "Condition"                                                                                                     // MakerGen.cs:421
            });                                                                                                                             // MakerGen.cs:422
            if (this.elements != null)                                                                                                      // MakerGen.cs:423
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:424
        }                                                                                                                                   // MakerGen.cs:425
    }                                                                                                                                       // MakerGen.cs:426
}                                                                                                                                           // MakerGen.cs:471
