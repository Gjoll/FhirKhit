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
      "id": "FamilyMemberHistory",
      "url": "http://hl7.org/fhir/StructureDefinition/FamilyMemberHistory",
      "version": "4.0.0",
      "name": "FamilyMemberHistory",
      "status": "draft",
      "publisher": "Health Level Seven International (Patient Care)",
      "description": "Significant health conditions for a person related to the patient relevant in the context of care for the patient.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "FamilyMemberHistory",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "FamilyMemberHistory",
            "path": "FamilyMemberHistory",
            "short": "Information about patient's relatives, relevant for patient",
            "definition": "Significant health conditions for a person related to the patient relevant in the context of care for the patient.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "FamilyMemberHistory.identifier",
            "path": "FamilyMemberHistory.identifier",
            "short": "External Id(s) for this record",
            "definition": "Business identifiers assigned to this family member history by the performer or other systems which remain constant as the resource is updated and propagates from server to server.",
            "comment": "This is a business identifier, not a resource identifier (see [discussion](resource.html#identifiers)).  It is best practice for the identifier to only appear on a single resource instance, however business practices may occasionally dictate that multiple resource instances with the same identifier can exist - possibly even with different resource types.  For example, multiple Patient and a Person resource instance might share the same social insurance number.",
            "requirements": "Allows identification of the family member history as it is known by various participating systems and in a way that remains consistent across servers.",
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
            "id": "FamilyMemberHistory.instantiatesCanonical",
            "path": "FamilyMemberHistory.instantiatesCanonical",
            "short": "Instantiates FHIR protocol or definition",
            "definition": "The URL pointing to a FHIR-defined protocol, guideline, orderset or other definition that is adhered to in whole or in part by this FamilyMemberHistory.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/PlanDefinition",
                  "http://hl7.org/fhir/StructureDefinition/Questionnaire",
                  "http://hl7.org/fhir/StructureDefinition/ActivityDefinition",
                  "http://hl7.org/fhir/StructureDefinition/Measure",
                  "http://hl7.org/fhir/StructureDefinition/OperationDefinition"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "FamilyMemberHistory.instantiatesUri",
            "path": "FamilyMemberHistory.instantiatesUri",
            "short": "Instantiates external protocol or definition",
            "definition": "The URL pointing to an externally maintained protocol, guideline, orderset or other definition that is adhered to in whole or in part by this FamilyMemberHistory.",
            "comment": "This might be an HTML page, PDF, etc. or could just be a non-resolvable URI identifier.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "uri"
              }
            ],
            "isSummary": true
          },
          {
            "id": "FamilyMemberHistory.status",
            "path": "FamilyMemberHistory.status",
            "short": "partial | completed | entered-in-error | health-unknown",
            "definition": "A code specifying the status of the record of the family history of a specific family member.",
            "comment": "This element is labeled as a modifier because the status contains codes that mark the resource as not currently valid.",
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
                  "valueString": "FamilyHistoryStatus"
                }
              ],
              "strength": "required",
              "description": "A code that identifies the status of the family history record.",
              "valueSet": "http://hl7.org/fhir/ValueSet/history-status|4.0.0"
            }
          },
          {
            "id": "FamilyMemberHistory.dataAbsentReason",
            "path": "FamilyMemberHistory.dataAbsentReason",
            "short": "subject-unknown | withheld | unable-to-obtain | deferred",
            "definition": "Describes why the family member's history is not available.",
            "requirements": "This is a separate element to allow it to have a distinct binding from reasonCode.",
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
                  "valueString": "FamilyHistoryAbsentReason"
                }
              ],
              "strength": "example",
              "description": "Codes describing the reason why a family member's history is not available.",
              "valueSet": "http://hl7.org/fhir/ValueSet/history-absent-reason"
            }
          },
          {
            "id": "FamilyMemberHistory.patient",
            "path": "FamilyMemberHistory.patient",
            "short": "Patient history is about",
            "definition": "The person who this history concerns.",
            "alias": [
              "Proband"
            ],
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
            "id": "FamilyMemberHistory.date",
            "path": "FamilyMemberHistory.date",
            "short": "When history was recorded or last updated",
            "definition": "The date (and possibly time) when the family member history was recorded or last updated.",
            "comment": "This should be captured even if the same as the date on the List aggregating the full family history.",
            "requirements": "Allows determination of how current the summary is.",
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
            "id": "FamilyMemberHistory.name",
            "path": "FamilyMemberHistory.name",
            "short": "The family member described",
            "definition": "This will either be a name or a description; e.g. \"Aunt Susan\", \"my cousin with the red hair\".",
            "requirements": "Allows greater ease in ensuring the same person is being talked about.",
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
            "id": "FamilyMemberHistory.relationship",
            "path": "FamilyMemberHistory.relationship",
            "short": "Relationship to the subject",
            "definition": "The type of relationship this person has to the patient (father, mother, brother etc.).",
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
                  "valueString": "FamilialRelationship"
                }
              ],
              "strength": "example",
              "description": "The nature of the relationship between the patient and the related person being described in the family member history.",
              "valueSet": "http://terminology.hl7.org/ValueSet/v3-FamilyMember"
            }
          },
          {
            "id": "FamilyMemberHistory.sex",
            "path": "FamilyMemberHistory.sex",
            "short": "male | female | other | unknown",
            "definition": "The birth sex of the family member.",
            "comment": "This element should ideally reflect whether the individual is genetically male or female.  However, as reported information based on the knowledge of the patient or reporting friend/relative, there may be situations where the reported sex might not be totally accurate.  E.g. 'Aunt Sue' might be XY rather than XX.  Questions soliciting this information should be phrased to encourage capture of genetic sex where known.  However, systems performing analysis should also allow for the possibility of imprecision with this element.",
            "requirements": "Not all relationship codes imply sex and the relative's sex can be relevant for risk assessments.",
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
                  "valueString": "Sex"
                }
              ],
              "strength": "extensible",
              "description": "Codes describing the sex assigned at birth as documented on the birth registration.",
              "valueSet": "http://build.fhir.org/valueset-administrative-gender.html"
            }
          },
          {
            "id": "FamilyMemberHistory.born[x]",
            "path": "FamilyMemberHistory.born[x]",
            "short": "(approximate) date of birth",
            "definition": "The actual or approximate date of birth of the relative.",
            "requirements": "Allows calculation of the relative's age.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              },
              {
                "code": "date"
              },
              {
                "code": "string"
              }
            ],
            "condition": [
              "fhs-1"
            ]
          },
          {
            "id": "FamilyMemberHistory.age[x]",
            "path": "FamilyMemberHistory.age[x]",
            "short": "(approximate) age",
            "definition": "The age of the relative at the time the family member history is recorded.",
            "comment": "use estimatedAge to indicate whether the age is actual or not.",
            "requirements": "While age can be calculated from date of birth, sometimes recording age directly is more natural for clinicians.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Age"
              },
              {
                "code": "Range"
              },
              {
                "code": "string"
              }
            ],
            "condition": [
              "fhs-1"
            ],
            "isSummary": true
          },
          {
            "id": "FamilyMemberHistory.estimatedAge",
            "path": "FamilyMemberHistory.estimatedAge",
            "short": "Age is estimated?",
            "definition": "If true, indicates that the age value specified is an estimated value.",
            "comment": "This element is labeled as a modifier because the fact that age is estimated can/should change the results of any algorithm that calculates based on the specified age.",
            "requirements": "Clinicians often prefer to specify an estimaged age rather than an age range.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "meaningWhenMissing": "It is unknown whether the age is an estimate or not",
            "condition": [
              "fhs-2"
            ],
            "isSummary": true
          },
          {
            "id": "FamilyMemberHistory.deceased[x]",
            "path": "FamilyMemberHistory.deceased[x]",
            "short": "Dead? How old/when?",
            "definition": "Deceased flag or the actual or approximate age of the relative at the time of death for the family member history record.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              },
              {
                "code": "Age"
              },
              {
                "code": "Range"
              },
              {
                "code": "date"
              },
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "FamilyMemberHistory.reasonCode",
            "path": "FamilyMemberHistory.reasonCode",
            "short": "Why was family member history performed?",
            "definition": "Describes why the family member history occurred in coded or textual form.",
            "comment": "Textual reasons can be captured using reasonCode.text.",
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
                  "valueString": "FamilyHistoryReason"
                }
              ],
              "strength": "example",
              "description": "Codes indicating why the family member history was done.",
              "valueSet": "http://hl7.org/fhir/ValueSet/clinical-findings"
            }
          },
          {
            "id": "FamilyMemberHistory.reasonReference",
            "path": "FamilyMemberHistory.reasonReference",
            "short": "Why was family member history performed?",
            "definition": "Indicates a Condition, Observation, AllergyIntolerance, or QuestionnaireResponse that justifies this family member history event.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Condition",
                  "http://hl7.org/fhir/StructureDefinition/Observation",
                  "http://hl7.org/fhir/StructureDefinition/AllergyIntolerance",
                  "http://hl7.org/fhir/StructureDefinition/QuestionnaireResponse",
                  "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",
                  "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "FamilyMemberHistory.note",
            "path": "FamilyMemberHistory.note",
            "short": "General note about related person",
            "definition": "This property allows a non condition-specific note to the made about the related person. Ideally, the note would be in the condition property, but this is not always possible.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Annotation"
              }
            ]
          },
          {
            "id": "FamilyMemberHistory.condition",
            "path": "FamilyMemberHistory.condition",
            "short": "Condition that the related person had",
            "definition": "The significant Conditions (or condition) that the family member had. This is a repeating section to allow a system to represent more than one condition per resource, though there is nothing stopping multiple resources - one per condition.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "FamilyMemberHistory.condition.code",
            "path": "FamilyMemberHistory.condition.code",
            "short": "Condition suffered by relation",
            "definition": "The actual condition specified. Could be a coded condition (like MI or Diabetes) or a less specific string like 'cancer' depending on how much is known about the condition and the capabilities of the creating system.",
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
                  "valueString": "ConditionCode"
                }
              ],
              "strength": "example",
              "description": "Identification of the Condition or diagnosis.",
              "valueSet": "http://hl7.org/fhir/ValueSet/condition-code"
            }
          },
          {
            "id": "FamilyMemberHistory.condition.outcome",
            "path": "FamilyMemberHistory.condition.outcome",
            "short": "deceased | permanent disability | etc.",
            "definition": "Indicates what happened following the condition.  If the condition resulted in death, deceased date is captured on the relation.",
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
                  "valueString": "ConditionOutcome"
                }
              ],
              "strength": "example",
              "description": "The result of the condition for the patient; e.g. death, permanent disability, temporary disability, etc.",
              "valueSet": "http://hl7.org/fhir/ValueSet/condition-outcome"
            }
          },
          {
            "id": "FamilyMemberHistory.condition.contributedToDeath",
            "path": "FamilyMemberHistory.condition.contributedToDeath",
            "short": "Whether the condition contributed to the cause of death",
            "definition": "This condition contributed to the cause of death of the related person. If contributedToDeath is not populated, then it is unknown.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "FamilyMemberHistory.condition.onset[x]",
            "path": "FamilyMemberHistory.condition.onset[x]",
            "short": "When condition first manifested",
            "definition": "Either the age of onset, range of approximate age or descriptive string can be recorded.  For conditions with multiple occurrences, this describes the first known occurrence.",
            "requirements": "Age of onset of a condition in relatives is predictive of risk for the patient.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Age"
              },
              {
                "code": "Range"
              },
              {
                "code": "Period"
              },
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "FamilyMemberHistory.condition.note",
            "path": "FamilyMemberHistory.condition.note",
            "short": "Extra information about condition",
            "definition": "An area where general notes can be placed about this specific condition.",
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
    #endregion                                                                                                                              // MakerGen.cs:463
    /// <summary>
    /// Fhir resource 'FamilyMemberHistory'
    /// </summary>
    // 0. FamilyMemberHistory
    public class FamilyMemberHistory : FhirKhit.Maker.Common.Resource.ResourceBase                                                          // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class FamilyMemberHistory_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                             // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 18. FamilyMemberHistory.condition
            public class Type_Condition : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Condition_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                          // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 19. FamilyMemberHistory.condition.code
                    public ElementDefinitionInfo Code;                                                                                      // MakerGen.cs:236
                    // 20. FamilyMemberHistory.condition.outcome
                    public ElementDefinitionInfo Outcome;                                                                                   // MakerGen.cs:236
                    // 21. FamilyMemberHistory.condition.contributedToDeath
                    public ElementDefinitionInfo ContributedToDeath;                                                                        // MakerGen.cs:236
                    // 22. FamilyMemberHistory.condition.onset[x]
                    public ElementDefinitionInfo Onset;                                                                                     // MakerGen.cs:236
                    // 23. FamilyMemberHistory.condition.note
                    public ElementDefinitionInfo Note;                                                                                      // MakerGen.cs:236
                    public Type_Condition_Elements()                                                                                        // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 19. FamilyMemberHistory.condition.code
                            this.Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Code",                                                                                              // MakerGen.cs:255
                                Path= "FamilyMemberHistory.condition.code",                                                                 // MakerGen.cs:256
                                Id = "FamilyMemberHistory.condition.code",                                                                  // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
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
                            // 20. FamilyMemberHistory.condition.outcome
                            this.Outcome = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Outcome",                                                                                           // MakerGen.cs:255
                                Path= "FamilyMemberHistory.condition.outcome",                                                              // MakerGen.cs:256
                                Id = "FamilyMemberHistory.condition.outcome",                                                               // MakerGen.cs:257
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
                            // 21. FamilyMemberHistory.condition.contributedToDeath
                            this.ContributedToDeath = new ElementDefinitionInfo                                                             // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "ContributedToDeath",                                                                                // MakerGen.cs:255
                                Path= "FamilyMemberHistory.condition.contributedToDeath",                                                   // MakerGen.cs:256
                                Id = "FamilyMemberHistory.condition.contributedToDeath",                                                    // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 22. FamilyMemberHistory.condition.onset[x]
                            this.Onset = new ElementDefinitionInfo                                                                          // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Onset",                                                                                             // MakerGen.cs:255
                                Path= "FamilyMemberHistory.condition.onset[x]",                                                             // MakerGen.cs:256
                                Id = "FamilyMemberHistory.condition.onset[x]",                                                              // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Age                                                                   // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Range                                                                 // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Period                                                                // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 23. FamilyMemberHistory.condition.note
                            this.Note = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Note",                                                                                              // MakerGen.cs:255
                                Path= "FamilyMemberHistory.condition.note",                                                                 // MakerGen.cs:256
                                Id = "FamilyMemberHistory.condition.note",                                                                  // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Annotation                                                            // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public void override Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Code.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Outcome.Write(sDef);                                                                                                // MakerGen.cs:240
                        ContributedToDeath.Write(sDef);                                                                                     // MakerGen.cs:240
                        Onset.Write(sDef);                                                                                                  // MakerGen.cs:240
                        Note.Write(sDef);                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Condition_Elements Elements { get; }                                                                            // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Condition()                                                                                                     // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Condition_Elements();                                                                          // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 1. FamilyMemberHistory.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:236
            // 2. FamilyMemberHistory.instantiatesCanonical
            public ElementDefinitionInfo InstantiatesCanonical;                                                                             // MakerGen.cs:236
            // 3. FamilyMemberHistory.instantiatesUri
            public ElementDefinitionInfo InstantiatesUri;                                                                                   // MakerGen.cs:236
            // 4. FamilyMemberHistory.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:236
            // 5. FamilyMemberHistory.dataAbsentReason
            public ElementDefinitionInfo DataAbsentReason;                                                                                  // MakerGen.cs:236
            // 6. FamilyMemberHistory.patient
            public ElementDefinitionInfo Patient;                                                                                           // MakerGen.cs:236
            // 7. FamilyMemberHistory.date
            public ElementDefinitionInfo Date;                                                                                              // MakerGen.cs:236
            // 8. FamilyMemberHistory.name
            public ElementDefinitionInfo Name;                                                                                              // MakerGen.cs:236
            // 9. FamilyMemberHistory.relationship
            public ElementDefinitionInfo Relationship;                                                                                      // MakerGen.cs:236
            // 10. FamilyMemberHistory.sex
            public ElementDefinitionInfo Sex;                                                                                               // MakerGen.cs:236
            // 11. FamilyMemberHistory.born[x]
            public ElementDefinitionInfo Born;                                                                                              // MakerGen.cs:236
            // 12. FamilyMemberHistory.age[x]
            public ElementDefinitionInfo Age;                                                                                               // MakerGen.cs:236
            // 13. FamilyMemberHistory.estimatedAge
            public ElementDefinitionInfo EstimatedAge;                                                                                      // MakerGen.cs:236
            // 14. FamilyMemberHistory.deceased[x]
            public ElementDefinitionInfo Deceased;                                                                                          // MakerGen.cs:236
            // 15. FamilyMemberHistory.reasonCode
            public ElementDefinitionInfo ReasonCode;                                                                                        // MakerGen.cs:236
            // 16. FamilyMemberHistory.reasonReference
            public ElementDefinitionInfo ReasonReference;                                                                                   // MakerGen.cs:236
            // 17. FamilyMemberHistory.note
            public ElementDefinitionInfo Note;                                                                                              // MakerGen.cs:236
            public FamilyMemberHistory_Elements()                                                                                           // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. FamilyMemberHistory.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Identifier",                                                                                                // MakerGen.cs:255
                        Path= "FamilyMemberHistory.identifier",                                                                             // MakerGen.cs:256
                        Id = "FamilyMemberHistory.identifier",                                                                              // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 2. FamilyMemberHistory.instantiatesCanonical
                    this.InstantiatesCanonical = new ElementDefinitionInfo                                                                  // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "InstantiatesCanonical",                                                                                     // MakerGen.cs:255
                        Path= "FamilyMemberHistory.instantiatesCanonical",                                                                  // MakerGen.cs:256
                        Id = "FamilyMemberHistory.instantiatesCanonical",                                                                   // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Canonical                                                                   // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                                TargetProfile = new String[]                                                                                // MakerGen.cs:302
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/PlanDefinition",                                               // MakerGen.cs:302
                                    "http://hl7.org/fhir/StructureDefinition/Questionnaire",                                                // MakerGen.cs:302
                                    "http://hl7.org/fhir/StructureDefinition/ActivityDefinition",                                           // MakerGen.cs:302
                                    "http://hl7.org/fhir/StructureDefinition/Measure",                                                      // MakerGen.cs:302
                                    "http://hl7.org/fhir/StructureDefinition/OperationDefinition"                                           // MakerGen.cs:302
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 3. FamilyMemberHistory.instantiatesUri
                    this.InstantiatesUri = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "InstantiatesUri",                                                                                           // MakerGen.cs:255
                        Path= "FamilyMemberHistory.instantiatesUri",                                                                        // MakerGen.cs:256
                        Id = "FamilyMemberHistory.instantiatesUri",                                                                         // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Uri                                                                         // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 4. FamilyMemberHistory.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Status",                                                                                                    // MakerGen.cs:255
                        Path= "FamilyMemberHistory.status",                                                                                 // MakerGen.cs:256
                        Id = "FamilyMemberHistory.status",                                                                                  // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 5. FamilyMemberHistory.dataAbsentReason
                    this.DataAbsentReason = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "DataAbsentReason",                                                                                          // MakerGen.cs:255
                        Path= "FamilyMemberHistory.dataAbsentReason",                                                                       // MakerGen.cs:256
                        Id = "FamilyMemberHistory.dataAbsentReason",                                                                        // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 6. FamilyMemberHistory.patient
                    this.Patient = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Patient",                                                                                                   // MakerGen.cs:255
                        Path= "FamilyMemberHistory.patient",                                                                                // MakerGen.cs:256
                        Id = "FamilyMemberHistory.patient",                                                                                 // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient"                                                       // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 7. FamilyMemberHistory.date
                    this.Date = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Date",                                                                                                      // MakerGen.cs:255
                        Path= "FamilyMemberHistory.date",                                                                                   // MakerGen.cs:256
                        Id = "FamilyMemberHistory.date",                                                                                    // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 8. FamilyMemberHistory.name
                    this.Name = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Name",                                                                                                      // MakerGen.cs:255
                        Path= "FamilyMemberHistory.name",                                                                                   // MakerGen.cs:256
                        Id = "FamilyMemberHistory.name",                                                                                    // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 9. FamilyMemberHistory.relationship
                    this.Relationship = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Relationship",                                                                                              // MakerGen.cs:255
                        Path= "FamilyMemberHistory.relationship",                                                                           // MakerGen.cs:256
                        Id = "FamilyMemberHistory.relationship",                                                                            // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 10. FamilyMemberHistory.sex
                    this.Sex = new ElementDefinitionInfo                                                                                    // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Sex",                                                                                                       // MakerGen.cs:255
                        Path= "FamilyMemberHistory.sex",                                                                                    // MakerGen.cs:256
                        Id = "FamilyMemberHistory.sex",                                                                                     // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 11. FamilyMemberHistory.born[x]
                    this.Born = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Born",                                                                                                      // MakerGen.cs:255
                        Path= "FamilyMemberHistory.born[x]",                                                                                // MakerGen.cs:256
                        Id = "FamilyMemberHistory.born[x]",                                                                                 // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            },                                                                                                              // MakerGen.cs:359
                            new FhirKhit.Maker.Common.Primitive.Date                                                                        // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            },                                                                                                              // MakerGen.cs:303
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 12. FamilyMemberHistory.age[x]
                    this.Age = new ElementDefinitionInfo                                                                                    // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Age",                                                                                                       // MakerGen.cs:255
                        Path= "FamilyMemberHistory.age[x]",                                                                                 // MakerGen.cs:256
                        Id = "FamilyMemberHistory.age[x]",                                                                                  // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Age                                                                           // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            },                                                                                                              // MakerGen.cs:359
                            new FhirKhit.Maker.Common.Complex.Range                                                                         // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            },                                                                                                              // MakerGen.cs:359
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 13. FamilyMemberHistory.estimatedAge
                    this.EstimatedAge = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "EstimatedAge",                                                                                              // MakerGen.cs:255
                        Path= "FamilyMemberHistory.estimatedAge",                                                                           // MakerGen.cs:256
                        Id = "FamilyMemberHistory.estimatedAge",                                                                            // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 14. FamilyMemberHistory.deceased[x]
                    this.Deceased = new ElementDefinitionInfo                                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Deceased",                                                                                                  // MakerGen.cs:255
                        Path= "FamilyMemberHistory.deceased[x]",                                                                            // MakerGen.cs:256
                        Id = "FamilyMemberHistory.deceased[x]",                                                                             // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            },                                                                                                              // MakerGen.cs:303
                            new FhirKhit.Maker.Common.Complex.Age                                                                           // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            },                                                                                                              // MakerGen.cs:359
                            new FhirKhit.Maker.Common.Complex.Range                                                                         // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            },                                                                                                              // MakerGen.cs:359
                            new FhirKhit.Maker.Common.Primitive.Date                                                                        // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            },                                                                                                              // MakerGen.cs:303
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 15. FamilyMemberHistory.reasonCode
                    this.ReasonCode = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "ReasonCode",                                                                                                // MakerGen.cs:255
                        Path= "FamilyMemberHistory.reasonCode",                                                                             // MakerGen.cs:256
                        Id = "FamilyMemberHistory.reasonCode",                                                                              // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 16. FamilyMemberHistory.reasonReference
                    this.ReasonReference = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "ReasonReference",                                                                                           // MakerGen.cs:255
                        Path= "FamilyMemberHistory.reasonReference",                                                                        // MakerGen.cs:256
                        Id = "FamilyMemberHistory.reasonReference",                                                                         // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Condition",                                                    // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Observation",                                                  // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/AllergyIntolerance",                                           // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/QuestionnaireResponse",                                        // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",                                             // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                             // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 17. FamilyMemberHistory.note
                    this.Note = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Note",                                                                                                      // MakerGen.cs:255
                        Path= "FamilyMemberHistory.note",                                                                                   // MakerGen.cs:256
                        Id = "FamilyMemberHistory.note",                                                                                    // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Annotation                                                                    // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:429
            public void override Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:240
                InstantiatesCanonical.Write(sDef);                                                                                          // MakerGen.cs:240
                InstantiatesUri.Write(sDef);                                                                                                // MakerGen.cs:240
                Status.Write(sDef);                                                                                                         // MakerGen.cs:240
                DataAbsentReason.Write(sDef);                                                                                               // MakerGen.cs:240
                Patient.Write(sDef);                                                                                                        // MakerGen.cs:240
                Date.Write(sDef);                                                                                                           // MakerGen.cs:240
                Name.Write(sDef);                                                                                                           // MakerGen.cs:240
                Relationship.Write(sDef);                                                                                                   // MakerGen.cs:240
                Sex.Write(sDef);                                                                                                            // MakerGen.cs:240
                Born.Write(sDef);                                                                                                           // MakerGen.cs:240
                Age.Write(sDef);                                                                                                            // MakerGen.cs:240
                EstimatedAge.Write(sDef);                                                                                                   // MakerGen.cs:240
                Deceased.Write(sDef);                                                                                                       // MakerGen.cs:240
                ReasonCode.Write(sDef);                                                                                                     // MakerGen.cs:240
                ReasonReference.Write(sDef);                                                                                                // MakerGen.cs:240
                Note.Write(sDef);                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public FamilyMemberHistory_Elements Elements { get; }                                                                               // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public FamilyMemberHistory()                                                                                                        // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new FamilyMemberHistory_Elements();                                                                             // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:468
