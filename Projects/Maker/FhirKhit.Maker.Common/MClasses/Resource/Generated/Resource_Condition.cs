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
    #endregion
    /// <summary>
    /// Fhir resource 'Condition'
    /// </summary>
    // 0. Condition
    public partial class Resource_Condition : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 15. Condition.stage
        public partial class Type_Stage : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 16. Condition.stage.summary
            public ElementDefinitionInfo Element_Summary;
            // 17. Condition.stage.assessment
            public ElementDefinitionInfo Element_Assessment;
            // 18. Condition.stage.type
            public ElementDefinitionInfo Element_Type;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Condition.stage",
                    ElementId = "Condition.stage"
                });
                Element_Summary.Write(sDef);
                Element_Assessment.Write(sDef);
                Element_Type.Write(sDef);
            }
            
            public Type_Stage()
            {
                {
                    // 16. Condition.stage.summary
                    this.Element_Summary = new ElementDefinitionInfo
                    {
                        Name = "Element_Summary",
                        Path= "Condition.stage.summary",
                        Id = "Condition.stage.summary",
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
                    // 17. Condition.stage.assessment
                    this.Element_Assessment = new ElementDefinitionInfo
                    {
                        Name = "Element_Assessment",
                        Path= "Condition.stage.assessment",
                        Id = "Condition.stage.assessment",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/ClinicalImpression",
                                    "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",
                                    "http://hl7.org/fhir/StructureDefinition/Observation"
                                }
                            }
                        }
                    };
                }
                {
                    // 18. Condition.stage.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "Condition.stage.type",
                        Id = "Condition.stage.type",
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
            }
        }
        // 19. Condition.evidence
        public partial class Type_Evidence : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 20. Condition.evidence.code
            public ElementDefinitionInfo Element_Code;
            // 21. Condition.evidence.detail
            public ElementDefinitionInfo Element_Detail;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Condition.evidence",
                    ElementId = "Condition.evidence"
                });
                Element_Code.Write(sDef);
                Element_Detail.Write(sDef);
            }
            
            public Type_Evidence()
            {
                {
                    // 20. Condition.evidence.code
                    this.Element_Code = new ElementDefinitionInfo
                    {
                        Name = "Element_Code",
                        Path= "Condition.evidence.code",
                        Id = "Condition.evidence.code",
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
                    // 21. Condition.evidence.detail
                    this.Element_Detail = new ElementDefinitionInfo
                    {
                        Name = "Element_Detail",
                        Path= "Condition.evidence.detail",
                        Id = "Condition.evidence.detail",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Resource"
                                }
                            }
                        }
                    };
                }
            }
        }
        // 1. Condition.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. Condition.clinicalStatus
        public ElementDefinitionInfo Element_ClinicalStatus;
        // 3. Condition.verificationStatus
        public ElementDefinitionInfo Element_VerificationStatus;
        // 4. Condition.category
        public ElementDefinitionInfo Element_Category;
        // 5. Condition.severity
        public ElementDefinitionInfo Element_Severity;
        // 6. Condition.code
        public ElementDefinitionInfo Element_Code;
        // 7. Condition.bodySite
        public ElementDefinitionInfo Element_BodySite;
        // 8. Condition.subject
        public ElementDefinitionInfo Element_Subject;
        // 9. Condition.encounter
        public ElementDefinitionInfo Element_Encounter;
        // 10. Condition.onset[x]
        public ElementDefinitionInfo Element_Onset;
        // 11. Condition.abatement[x]
        public ElementDefinitionInfo Element_Abatement;
        // 12. Condition.recordedDate
        public ElementDefinitionInfo Element_RecordedDate;
        // 13. Condition.recorder
        public ElementDefinitionInfo Element_Recorder;
        // 14. Condition.asserter
        public ElementDefinitionInfo Element_Asserter;
        // 15. Condition.stage
        public ElementDefinitionInfo Element_Stage;
        // 19. Condition.evidence
        public ElementDefinitionInfo Element_Evidence;
        // 22. Condition.note
        public ElementDefinitionInfo Element_Note;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "Condition",
                ElementId = "Condition"
            });
            Element_Identifier.Write(sDef);
            Element_ClinicalStatus.Write(sDef);
            Element_VerificationStatus.Write(sDef);
            Element_Category.Write(sDef);
            Element_Severity.Write(sDef);
            Element_Code.Write(sDef);
            Element_BodySite.Write(sDef);
            Element_Subject.Write(sDef);
            Element_Encounter.Write(sDef);
            Element_Onset.Write(sDef);
            Element_Abatement.Write(sDef);
            Element_RecordedDate.Write(sDef);
            Element_Recorder.Write(sDef);
            Element_Asserter.Write(sDef);
            Element_Stage.Write(sDef);
            Element_Evidence.Write(sDef);
            Element_Note.Write(sDef);
        }
        
        public Resource_Condition()
        {
            {
                // 1. Condition.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "Condition.identifier",
                    Id = "Condition.identifier",
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
                // 2. Condition.clinicalStatus
                this.Element_ClinicalStatus = new ElementDefinitionInfo
                {
                    Name = "Element_ClinicalStatus",
                    Path= "Condition.clinicalStatus",
                    Id = "Condition.clinicalStatus",
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
                // 3. Condition.verificationStatus
                this.Element_VerificationStatus = new ElementDefinitionInfo
                {
                    Name = "Element_VerificationStatus",
                    Path= "Condition.verificationStatus",
                    Id = "Condition.verificationStatus",
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
                // 4. Condition.category
                this.Element_Category = new ElementDefinitionInfo
                {
                    Name = "Element_Category",
                    Path= "Condition.category",
                    Id = "Condition.category",
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
                // 5. Condition.severity
                this.Element_Severity = new ElementDefinitionInfo
                {
                    Name = "Element_Severity",
                    Path= "Condition.severity",
                    Id = "Condition.severity",
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
                // 6. Condition.code
                this.Element_Code = new ElementDefinitionInfo
                {
                    Name = "Element_Code",
                    Path= "Condition.code",
                    Id = "Condition.code",
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
                // 7. Condition.bodySite
                this.Element_BodySite = new ElementDefinitionInfo
                {
                    Name = "Element_BodySite",
                    Path= "Condition.bodySite",
                    Id = "Condition.bodySite",
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
                // 8. Condition.subject
                this.Element_Subject = new ElementDefinitionInfo
                {
                    Name = "Element_Subject",
                    Path= "Condition.subject",
                    Id = "Condition.subject",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/Group"
                            }
                        }
                    }
                };
            }
            {
                // 9. Condition.encounter
                this.Element_Encounter = new ElementDefinitionInfo
                {
                    Name = "Element_Encounter",
                    Path= "Condition.encounter",
                    Id = "Condition.encounter",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Encounter"
                            }
                        }
                    }
                };
            }
            {
                // 10. Condition.onset[x]
                this.Element_Onset = new ElementDefinitionInfo
                {
                    Name = "Element_Onset",
                    Path= "Condition.onset[x]",
                    Id = "Condition.onset[x]",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Age
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Period
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
                // 11. Condition.abatement[x]
                this.Element_Abatement = new ElementDefinitionInfo
                {
                    Name = "Element_Abatement",
                    Path= "Condition.abatement[x]",
                    Id = "Condition.abatement[x]",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Age
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Period
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
                // 12. Condition.recordedDate
                this.Element_RecordedDate = new ElementDefinitionInfo
                {
                    Name = "Element_RecordedDate",
                    Path= "Condition.recordedDate",
                    Id = "Condition.recordedDate",
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
                // 13. Condition.recorder
                this.Element_Recorder = new ElementDefinitionInfo
                {
                    Name = "Element_Recorder",
                    Path= "Condition.recorder",
                    Id = "Condition.recorder",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                            }
                        }
                    }
                };
            }
            {
                // 14. Condition.asserter
                this.Element_Asserter = new ElementDefinitionInfo
                {
                    Name = "Element_Asserter",
                    Path= "Condition.asserter",
                    Id = "Condition.asserter",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                            }
                        }
                    }
                };
            }
            {
                // 15. Condition.stage
                this.Element_Stage = new ElementDefinitionInfo
                {
                    Name = "Element_Stage",
                    Path= "Condition.stage",
                    Id = "Condition.stage",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Stage
                        {
                        }
                    }
                };
            }
            {
                // 19. Condition.evidence
                this.Element_Evidence = new ElementDefinitionInfo
                {
                    Name = "Element_Evidence",
                    Path= "Condition.evidence",
                    Id = "Condition.evidence",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Evidence
                        {
                        }
                    }
                };
            }
            {
                // 22. Condition.note
                this.Element_Note = new ElementDefinitionInfo
                {
                    Name = "Element_Note",
                    Path= "Condition.note",
                    Id = "Condition.note",
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
            this.Name = "Condition";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Condition";
        }
    }
}
