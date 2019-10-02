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
    #endregion
    /// <summary>
    /// Fhir resource 'FamilyMemberHistory'
    /// </summary>
    // 0. FamilyMemberHistory
    public class Resource_FamilyMemberHistory : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 18. FamilyMemberHistory.condition
        public class Type_Condition : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 19. FamilyMemberHistory.condition.code
            public ElementDefinitionInfo Element_Code;
            // 20. FamilyMemberHistory.condition.outcome
            public ElementDefinitionInfo Element_Outcome;
            // 21. FamilyMemberHistory.condition.contributedToDeath
            public ElementDefinitionInfo Element_ContributedToDeath;
            // 22. FamilyMemberHistory.condition.onset[x]
            public ElementDefinitionInfo Element_Onset;
            // 23. FamilyMemberHistory.condition.note
            public ElementDefinitionInfo Element_Note;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "FamilyMemberHistory.condition",
                    ElementId = "FamilyMemberHistory.condition"
                });
                Element_Code.Write(sDef);
                Element_Outcome.Write(sDef);
                Element_ContributedToDeath.Write(sDef);
                Element_Onset.Write(sDef);
                Element_Note.Write(sDef);
            }
            
            public Type_Condition()
            {
                {
                    // 19. FamilyMemberHistory.condition.code
                    this.Element_Code = new ElementDefinitionInfo
                    {
                        Name = "Element_Code",
                        Path= "FamilyMemberHistory.condition.code",
                        Id = "FamilyMemberHistory.condition.code",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                            {
                            }
                        }
                    };
                }
                {
                    // 20. FamilyMemberHistory.condition.outcome
                    this.Element_Outcome = new ElementDefinitionInfo
                    {
                        Name = "Element_Outcome",
                        Path= "FamilyMemberHistory.condition.outcome",
                        Id = "FamilyMemberHistory.condition.outcome",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                            {
                            }
                        }
                    };
                }
                {
                    // 21. FamilyMemberHistory.condition.contributedToDeath
                    this.Element_ContributedToDeath = new ElementDefinitionInfo
                    {
                        Name = "Element_ContributedToDeath",
                        Path= "FamilyMemberHistory.condition.contributedToDeath",
                        Id = "FamilyMemberHistory.condition.contributedToDeath",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Boolean
                            {
                            }
                        }
                    };
                }
                {
                    // 22. FamilyMemberHistory.condition.onset[x]
                    this.Element_Onset = new ElementDefinitionInfo
                    {
                        Name = "Element_Onset",
                        Path= "FamilyMemberHistory.condition.onset[x]",
                        Id = "FamilyMemberHistory.condition.onset[x]",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Age
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Range
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Period
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_String
                            {
                            }
                        }
                    };
                }
                {
                    // 23. FamilyMemberHistory.condition.note
                    this.Element_Note = new ElementDefinitionInfo
                    {
                        Name = "Element_Note",
                        Path= "FamilyMemberHistory.condition.note",
                        Id = "FamilyMemberHistory.condition.note",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Annotation
                            {
                            }
                        }
                    };
                }
            }
        }
        // 1. FamilyMemberHistory.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. FamilyMemberHistory.instantiatesCanonical
        public ElementDefinitionInfo Element_InstantiatesCanonical;
        // 3. FamilyMemberHistory.instantiatesUri
        public ElementDefinitionInfo Element_InstantiatesUri;
        // 4. FamilyMemberHistory.status
        public ElementDefinitionInfo Element_Status;
        // 5. FamilyMemberHistory.dataAbsentReason
        public ElementDefinitionInfo Element_DataAbsentReason;
        // 6. FamilyMemberHistory.patient
        public ElementDefinitionInfo Element_Patient;
        // 7. FamilyMemberHistory.date
        public ElementDefinitionInfo Element_Date;
        // 8. FamilyMemberHistory.name
        public ElementDefinitionInfo Element_Name;
        // 9. FamilyMemberHistory.relationship
        public ElementDefinitionInfo Element_Relationship;
        // 10. FamilyMemberHistory.sex
        public ElementDefinitionInfo Element_Sex;
        // 11. FamilyMemberHistory.born[x]
        public ElementDefinitionInfo Element_Born;
        // 12. FamilyMemberHistory.age[x]
        public ElementDefinitionInfo Element_Age;
        // 13. FamilyMemberHistory.estimatedAge
        public ElementDefinitionInfo Element_EstimatedAge;
        // 14. FamilyMemberHistory.deceased[x]
        public ElementDefinitionInfo Element_Deceased;
        // 15. FamilyMemberHistory.reasonCode
        public ElementDefinitionInfo Element_ReasonCode;
        // 16. FamilyMemberHistory.reasonReference
        public ElementDefinitionInfo Element_ReasonReference;
        // 17. FamilyMemberHistory.note
        public ElementDefinitionInfo Element_Note;
        // 18. FamilyMemberHistory.condition
        public ElementDefinitionInfo Element_Condition;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "FamilyMemberHistory",
                ElementId = "FamilyMemberHistory"
            });
            Element_Identifier.Write(sDef);
            Element_InstantiatesCanonical.Write(sDef);
            Element_InstantiatesUri.Write(sDef);
            Element_Status.Write(sDef);
            Element_DataAbsentReason.Write(sDef);
            Element_Patient.Write(sDef);
            Element_Date.Write(sDef);
            Element_Name.Write(sDef);
            Element_Relationship.Write(sDef);
            Element_Sex.Write(sDef);
            Element_Born.Write(sDef);
            Element_Age.Write(sDef);
            Element_EstimatedAge.Write(sDef);
            Element_Deceased.Write(sDef);
            Element_ReasonCode.Write(sDef);
            Element_ReasonReference.Write(sDef);
            Element_Note.Write(sDef);
            Element_Condition.Write(sDef);
        }
        
        public Resource_FamilyMemberHistory()
        {
            {
                // 1. FamilyMemberHistory.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "FamilyMemberHistory.identifier",
                    Id = "FamilyMemberHistory.identifier",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Identifier
                        {
                        }
                    }
                };
            }
            {
                // 2. FamilyMemberHistory.instantiatesCanonical
                this.Element_InstantiatesCanonical = new ElementDefinitionInfo
                {
                    Name = "Element_InstantiatesCanonical",
                    Path= "FamilyMemberHistory.instantiatesCanonical",
                    Id = "FamilyMemberHistory.instantiatesCanonical",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Canonical
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/PlanDefinition",
                                "http://hl7.org/fhir/StructureDefinition/Questionnaire",
                                "http://hl7.org/fhir/StructureDefinition/ActivityDefinition",
                                "http://hl7.org/fhir/StructureDefinition/Measure",
                                "http://hl7.org/fhir/StructureDefinition/OperationDefinition"
                            }
                        }
                    }
                };
            }
            {
                // 3. FamilyMemberHistory.instantiatesUri
                this.Element_InstantiatesUri = new ElementDefinitionInfo
                {
                    Name = "Element_InstantiatesUri",
                    Path= "FamilyMemberHistory.instantiatesUri",
                    Id = "FamilyMemberHistory.instantiatesUri",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uri
                        {
                        }
                    }
                };
            }
            {
                // 4. FamilyMemberHistory.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "FamilyMemberHistory.status",
                    Id = "FamilyMemberHistory.status",
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
                // 5. FamilyMemberHistory.dataAbsentReason
                this.Element_DataAbsentReason = new ElementDefinitionInfo
                {
                    Name = "Element_DataAbsentReason",
                    Path= "FamilyMemberHistory.dataAbsentReason",
                    Id = "FamilyMemberHistory.dataAbsentReason",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                        {
                        }
                    }
                };
            }
            {
                // 6. FamilyMemberHistory.patient
                this.Element_Patient = new ElementDefinitionInfo
                {
                    Name = "Element_Patient",
                    Path= "FamilyMemberHistory.patient",
                    Id = "FamilyMemberHistory.patient",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Patient"
                            }
                        }
                    }
                };
            }
            {
                // 7. FamilyMemberHistory.date
                this.Element_Date = new ElementDefinitionInfo
                {
                    Name = "Element_Date",
                    Path= "FamilyMemberHistory.date",
                    Id = "FamilyMemberHistory.date",
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
                // 8. FamilyMemberHistory.name
                this.Element_Name = new ElementDefinitionInfo
                {
                    Name = "Element_Name",
                    Path= "FamilyMemberHistory.name",
                    Id = "FamilyMemberHistory.name",
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
                // 9. FamilyMemberHistory.relationship
                this.Element_Relationship = new ElementDefinitionInfo
                {
                    Name = "Element_Relationship",
                    Path= "FamilyMemberHistory.relationship",
                    Id = "FamilyMemberHistory.relationship",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                        {
                        }
                    }
                };
            }
            {
                // 10. FamilyMemberHistory.sex
                this.Element_Sex = new ElementDefinitionInfo
                {
                    Name = "Element_Sex",
                    Path= "FamilyMemberHistory.sex",
                    Id = "FamilyMemberHistory.sex",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                        {
                        }
                    }
                };
            }
            {
                // 11. FamilyMemberHistory.born[x]
                this.Element_Born = new ElementDefinitionInfo
                {
                    Name = "Element_Born",
                    Path= "FamilyMemberHistory.born[x]",
                    Id = "FamilyMemberHistory.born[x]",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Period
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_Date
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_String
                        {
                        }
                    }
                };
            }
            {
                // 12. FamilyMemberHistory.age[x]
                this.Element_Age = new ElementDefinitionInfo
                {
                    Name = "Element_Age",
                    Path= "FamilyMemberHistory.age[x]",
                    Id = "FamilyMemberHistory.age[x]",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Age
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Range
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_String
                        {
                        }
                    }
                };
            }
            {
                // 13. FamilyMemberHistory.estimatedAge
                this.Element_EstimatedAge = new ElementDefinitionInfo
                {
                    Name = "Element_EstimatedAge",
                    Path= "FamilyMemberHistory.estimatedAge",
                    Id = "FamilyMemberHistory.estimatedAge",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Boolean
                        {
                        }
                    }
                };
            }
            {
                // 14. FamilyMemberHistory.deceased[x]
                this.Element_Deceased = new ElementDefinitionInfo
                {
                    Name = "Element_Deceased",
                    Path= "FamilyMemberHistory.deceased[x]",
                    Id = "FamilyMemberHistory.deceased[x]",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Boolean
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Age
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Range
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_Date
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_String
                        {
                        }
                    }
                };
            }
            {
                // 15. FamilyMemberHistory.reasonCode
                this.Element_ReasonCode = new ElementDefinitionInfo
                {
                    Name = "Element_ReasonCode",
                    Path= "FamilyMemberHistory.reasonCode",
                    Id = "FamilyMemberHistory.reasonCode",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                        {
                        }
                    }
                };
            }
            {
                // 16. FamilyMemberHistory.reasonReference
                this.Element_ReasonReference = new ElementDefinitionInfo
                {
                    Name = "Element_ReasonReference",
                    Path= "FamilyMemberHistory.reasonReference",
                    Id = "FamilyMemberHistory.reasonReference",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Condition",
                                "http://hl7.org/fhir/StructureDefinition/Observation",
                                "http://hl7.org/fhir/StructureDefinition/AllergyIntolerance",
                                "http://hl7.org/fhir/StructureDefinition/QuestionnaireResponse",
                                "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",
                                "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                            }
                        }
                    }
                };
            }
            {
                // 17. FamilyMemberHistory.note
                this.Element_Note = new ElementDefinitionInfo
                {
                    Name = "Element_Note",
                    Path= "FamilyMemberHistory.note",
                    Id = "FamilyMemberHistory.note",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Annotation
                        {
                        }
                    }
                };
            }
            {
                // 18. FamilyMemberHistory.condition
                this.Element_Condition = new ElementDefinitionInfo
                {
                    Name = "Element_Condition",
                    Path= "FamilyMemberHistory.condition",
                    Id = "FamilyMemberHistory.condition",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Condition
                        {
                        }
                    }
                };
            }
            this.Name = "FamilyMemberHistory";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/FamilyMemberHistory";
        }
    }
}
