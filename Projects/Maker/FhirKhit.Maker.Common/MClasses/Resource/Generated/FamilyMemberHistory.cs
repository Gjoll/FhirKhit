using System;                                                                                                                               // MakerGen.cs:423
using System.Diagnostics;                                                                                                                   // MakerGen.cs:424
using System.IO;                                                                                                                            // MakerGen.cs:425
using System.Linq;                                                                                                                          // MakerGen.cs:426
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:427
                                                                                                                                            // MakerGen.cs:428
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:429
{                                                                                                                                           // MakerGen.cs:430
    #region Json                                                                                                                            // MakerGen.cs:431
    #if NEVER                                                                                                                               // MakerGen.cs:432
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
    #endregion                                                                                                                              // MakerGen.cs:435
    /// <summary>
    /// Fhir resource 'FamilyMemberHistory'
    /// </summary>
    // 0. FamilyMemberHistory
    public class FamilyMemberHistory : FhirKhit.Maker.Common.Resource.ResourceBase                                                          // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        // 18. FamilyMemberHistory.condition
        public class Type_Condition : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:384
        {                                                                                                                                   // MakerGen.cs:385
            // 19. FamilyMemberHistory.condition.code
            public MakerElementInstance Element_Code;                                                                                       // MakerGen.cs:232
            // 20. FamilyMemberHistory.condition.outcome
            public MakerElementInstance Element_Outcome;                                                                                    // MakerGen.cs:232
            // 21. FamilyMemberHistory.condition.contributedToDeath
            public MakerElementInstance Element_ContributedToDeath;                                                                         // MakerGen.cs:232
            // 22. FamilyMemberHistory.condition.onset[x]
            public MakerElementInstance Element_Onset;                                                                                      // MakerGen.cs:232
            // 23. FamilyMemberHistory.condition.note
            public MakerElementInstance Element_Note;                                                                                       // MakerGen.cs:232
            public Type_Condition()                                                                                                         // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:243
                    // 19. FamilyMemberHistory.condition.code
                    this.Element_Code = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Code",                                                                                              // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:297
                            {                                                                                                               // MakerGen.cs:298
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:243
                    // 20. FamilyMemberHistory.condition.outcome
                    this.Element_Outcome = new MakerElementInstance                                                                         // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Outcome",                                                                                           // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:297
                            {                                                                                                               // MakerGen.cs:298
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:243
                    // 21. FamilyMemberHistory.condition.contributedToDeath
                    this.Element_ContributedToDeath = new MakerElementInstance                                                              // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_ContributedToDeath",                                                                                // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:243
                    // 22. FamilyMemberHistory.condition.onset[x]
                    this.Element_Onset = new MakerElementInstance                                                                           // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Onset",                                                                                             // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.Age                                                                           // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            },                                                                                                              // MakerGen.cs:345
                            new FhirKhit.Maker.Common.Complex.Range                                                                         // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            },                                                                                                              // MakerGen.cs:345
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            },                                                                                                              // MakerGen.cs:345
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:243
                    // 23. FamilyMemberHistory.condition.note
                    this.Element_Note = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Note",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.Annotation                                                                    // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:389
        // 1. FamilyMemberHistory.identifier
        public MakerElementInstance Element_Identifier;                                                                                     // MakerGen.cs:232
        // 2. FamilyMemberHistory.instantiatesCanonical
        public MakerElementInstance Element_InstantiatesCanonical;                                                                          // MakerGen.cs:232
        // 3. FamilyMemberHistory.instantiatesUri
        public MakerElementInstance Element_InstantiatesUri;                                                                                // MakerGen.cs:232
        // 4. FamilyMemberHistory.status
        public MakerElementInstance Element_Status;                                                                                         // MakerGen.cs:232
        // 5. FamilyMemberHistory.dataAbsentReason
        public MakerElementInstance Element_DataAbsentReason;                                                                               // MakerGen.cs:232
        // 6. FamilyMemberHistory.patient
        public MakerElementInstance Element_Patient;                                                                                        // MakerGen.cs:232
        // 7. FamilyMemberHistory.date
        public MakerElementInstance Element_Date;                                                                                           // MakerGen.cs:232
        // 8. FamilyMemberHistory.name
        public MakerElementInstance Element_Name;                                                                                           // MakerGen.cs:232
        // 9. FamilyMemberHistory.relationship
        public MakerElementInstance Element_Relationship;                                                                                   // MakerGen.cs:232
        // 10. FamilyMemberHistory.sex
        public MakerElementInstance Element_Sex;                                                                                            // MakerGen.cs:232
        // 11. FamilyMemberHistory.born[x]
        public MakerElementInstance Element_Born;                                                                                           // MakerGen.cs:232
        // 12. FamilyMemberHistory.age[x]
        public MakerElementInstance Element_Age;                                                                                            // MakerGen.cs:232
        // 13. FamilyMemberHistory.estimatedAge
        public MakerElementInstance Element_EstimatedAge;                                                                                   // MakerGen.cs:232
        // 14. FamilyMemberHistory.deceased[x]
        public MakerElementInstance Element_Deceased;                                                                                       // MakerGen.cs:232
        // 15. FamilyMemberHistory.reasonCode
        public MakerElementInstance Element_ReasonCode;                                                                                     // MakerGen.cs:232
        // 16. FamilyMemberHistory.reasonReference
        public MakerElementInstance Element_ReasonReference;                                                                                // MakerGen.cs:232
        // 17. FamilyMemberHistory.note
        public MakerElementInstance Element_Note;                                                                                           // MakerGen.cs:232
        public FamilyMemberHistory()                                                                                                        // MakerGen.cs:393
        {                                                                                                                                   // MakerGen.cs:394
            {                                                                                                                               // MakerGen.cs:243
                // 1. FamilyMemberHistory.identifier
                this.Element_Identifier = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Identifier                                                                        // MakerGen.cs:343
                        {                                                                                                                   // MakerGen.cs:344
                        }                                                                                                                   // MakerGen.cs:345
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 2. FamilyMemberHistory.instantiatesCanonical
                this.Element_InstantiatesCanonical = new MakerElementInstance                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_InstantiatesCanonical",                                                                                 // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Canonical                                                                       // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 3. FamilyMemberHistory.instantiatesUri
                this.Element_InstantiatesUri = new MakerElementInstance                                                                     // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_InstantiatesUri",                                                                                       // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Uri                                                                             // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 4. FamilyMemberHistory.status
                this.Element_Status = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Status",                                                                                                // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code                                                                            // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 5. FamilyMemberHistory.dataAbsentReason
                this.Element_DataAbsentReason = new MakerElementInstance                                                                    // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_DataAbsentReason",                                                                                      // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 6. FamilyMemberHistory.patient
                this.Element_Patient = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Patient",                                                                                               // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 7. FamilyMemberHistory.date
                this.Element_Date = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Date",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.DateTime                                                                        // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 8. FamilyMemberHistory.name
                this.Element_Name = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Name",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String                                                                          // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 9. FamilyMemberHistory.relationship
                this.Element_Relationship = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Relationship",                                                                                          // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 10. FamilyMemberHistory.sex
                this.Element_Sex = new MakerElementInstance                                                                                 // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Sex",                                                                                                   // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 11. FamilyMemberHistory.born[x]
                this.Element_Born = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Born",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Period                                                                            // MakerGen.cs:343
                        {                                                                                                                   // MakerGen.cs:344
                        },                                                                                                                  // MakerGen.cs:345
                        new FhirKhit.Maker.Common.Primitive.Date                                                                            // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        },                                                                                                                  // MakerGen.cs:289
                        new FhirKhit.Maker.Common.Primitive.String                                                                          // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 12. FamilyMemberHistory.age[x]
                this.Element_Age = new MakerElementInstance                                                                                 // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Age",                                                                                                   // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Age                                                                               // MakerGen.cs:343
                        {                                                                                                                   // MakerGen.cs:344
                        },                                                                                                                  // MakerGen.cs:345
                        new FhirKhit.Maker.Common.Complex.Range                                                                             // MakerGen.cs:343
                        {                                                                                                                   // MakerGen.cs:344
                        },                                                                                                                  // MakerGen.cs:345
                        new FhirKhit.Maker.Common.Primitive.String                                                                          // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 13. FamilyMemberHistory.estimatedAge
                this.Element_EstimatedAge = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_EstimatedAge",                                                                                          // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Boolean                                                                         // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 14. FamilyMemberHistory.deceased[x]
                this.Element_Deceased = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Deceased",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Boolean                                                                         // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        },                                                                                                                  // MakerGen.cs:289
                        new FhirKhit.Maker.Common.Complex.Age                                                                               // MakerGen.cs:343
                        {                                                                                                                   // MakerGen.cs:344
                        },                                                                                                                  // MakerGen.cs:345
                        new FhirKhit.Maker.Common.Complex.Range                                                                             // MakerGen.cs:343
                        {                                                                                                                   // MakerGen.cs:344
                        },                                                                                                                  // MakerGen.cs:345
                        new FhirKhit.Maker.Common.Primitive.Date                                                                            // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        },                                                                                                                  // MakerGen.cs:289
                        new FhirKhit.Maker.Common.Primitive.String                                                                          // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 15. FamilyMemberHistory.reasonCode
                this.Element_ReasonCode = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ReasonCode",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 16. FamilyMemberHistory.reasonReference
                this.Element_ReasonReference = new MakerElementInstance                                                                     // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ReasonReference",                                                                                       // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 17. FamilyMemberHistory.note
                this.Element_Note = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Note",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Annotation                                                                        // MakerGen.cs:343
                        {                                                                                                                   // MakerGen.cs:344
                        }                                                                                                                   // MakerGen.cs:345
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:389
}                                                                                                                                           // MakerGen.cs:440
