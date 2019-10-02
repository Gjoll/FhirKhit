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
      "id": "ResearchStudy",
      "url": "http://hl7.org/fhir/StructureDefinition/ResearchStudy",
      "version": "4.0.0",
      "name": "ResearchStudy",
      "status": "draft",
      "publisher": "Health Level Seven International (Biomedical Research and Regulation)",
      "description": "A process where a researcher or organization plans and then executes a series of steps intended to increase the field of healthcare-related knowledge.  This includes studies of safety, efficacy, comparative effectiveness and other information about medications, devices, therapies and other interventional and investigative techniques.  A ResearchStudy involves the gathering of information about human or animal subjects.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "ResearchStudy",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "ResearchStudy",
            "path": "ResearchStudy",
            "short": "Investigation to increase healthcare-related patient-independent knowledge",
            "definition": "A process where a researcher or organization plans and then executes a series of steps intended to increase the field of healthcare-related knowledge.  This includes studies of safety, efficacy, comparative effectiveness and other information about medications, devices, therapies and other interventional and investigative techniques.  A ResearchStudy involves the gathering of information about human or animal subjects.",
            "comment": "Need to make sure we encompass public health studies.",
            "alias": [
              "Clinical Trial",
              "Study"
            ],
            "min": 0,
            "max": "*"
          },
          {
            "id": "ResearchStudy.identifier",
            "path": "ResearchStudy.identifier",
            "short": "Business Identifier for study",
            "definition": "Identifiers assigned to this research study by the sponsor or other systems.",
            "requirements": "Allows identification of the research study as it is known by various participating systems and in a way that remains consistent across servers.",
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
            "id": "ResearchStudy.title",
            "path": "ResearchStudy.title",
            "short": "Name for this study",
            "definition": "A short, descriptive user-friendly label for the study.",
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
            "id": "ResearchStudy.protocol",
            "path": "ResearchStudy.protocol",
            "short": "Steps followed in executing study",
            "definition": "The set of steps expected to be performed as part of the execution of the study.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/PlanDefinition"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ResearchStudy.partOf",
            "path": "ResearchStudy.partOf",
            "short": "Part of larger study",
            "definition": "A larger research study of which this particular study is a component or step.",
            "requirements": "Allows breaking a study into components (e.g. by study site) each with their own PI, status, enrollment, etc.",
            "alias": [
              "container"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ResearchStudy"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ResearchStudy.status",
            "path": "ResearchStudy.status",
            "short": "active | administratively-completed | approved | closed-to-accrual | closed-to-accrual-and-intervention | completed | disapproved | in-review | temporarily-closed-to-accrual | temporarily-closed-to-accrual-and-intervention | withdrawn",
            "definition": "The current state of the study.",
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
                  "valueString": "ResearchStudyStatus"
                }
              ],
              "strength": "required",
              "description": "Codes that convey the current status of the research study.",
              "valueSet": "http://hl7.org/fhir/ValueSet/research-study-status|4.0.0"
            }
          },
          {
            "id": "ResearchStudy.primaryPurposeType",
            "path": "ResearchStudy.primaryPurposeType",
            "short": "treatment | prevention | diagnostic | supportive-care | screening | health-services-research | basic-science | device-feasibility",
            "definition": "The type of study based upon the intent of the study's activities. A classification of the intent of the study.",
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
                  "valueString": "ResearchStudyPrimaryPurposeType"
                }
              ],
              "strength": "extensible",
              "description": "Codes for the main intent of the study.",
              "valueSet": "http://hl7.org/fhir/ValueSet/research-study-prim-purp-type"
            }
          },
          {
            "id": "ResearchStudy.phase",
            "path": "ResearchStudy.phase",
            "short": "n-a | early-phase-1 | phase-1 | phase-1-phase-2 | phase-2 | phase-2-phase-3 | phase-3 | phase-4",
            "definition": "The stage in the progression of a therapy from initial experimental use in humans in clinical trials to post-market evaluation.",
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
                  "valueString": "ResearchStudyPhase"
                }
              ],
              "strength": "example",
              "description": "Codes for the stage in the progression of a therapy from initial experimental use in humans in clinical trials to post-market evaluation.",
              "valueSet": "http://hl7.org/fhir/ValueSet/research-study-phase"
            }
          },
          {
            "id": "ResearchStudy.category",
            "path": "ResearchStudy.category",
            "short": "Classifications for the study",
            "definition": "Codes categorizing the type of study such as investigational vs. observational, type of blinding, type of randomization, safety vs. efficacy, etc.",
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
                  "valueString": "ResearchStudyCategory"
                }
              ],
              "strength": "example",
              "description": "Codes that describe the type of research study.  E.g. Study phase, Interventional/Observational, blinding type, etc."
            }
          },
          {
            "id": "ResearchStudy.focus",
            "path": "ResearchStudy.focus",
            "short": "Drugs, devices, etc. under study",
            "definition": "The medication(s), food(s), therapy(ies), device(s) or other concerns or interventions that the study is seeking to gain more information about.",
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
                  "valueString": "ResearchStudyFocus"
                }
              ],
              "strength": "example",
              "description": "Codes for medications, devices and other interventions."
            }
          },
          {
            "id": "ResearchStudy.condition",
            "path": "ResearchStudy.condition",
            "short": "Condition being studied",
            "definition": "The condition that is the focus of the study.  For example, In a study to examine risk factors for Lupus, might have as an inclusion criterion \"healthy volunteer\", but the target condition code would be a Lupus SNOMED code.",
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
                  "valueString": "ConditionCode"
                }
              ],
              "strength": "example",
              "description": "Identification of the condition or diagnosis.",
              "valueSet": "http://hl7.org/fhir/ValueSet/condition-code"
            }
          },
          {
            "id": "ResearchStudy.contact",
            "path": "ResearchStudy.contact",
            "short": "Contact details for the study",
            "definition": "Contact details to assist a user in learning more about or engaging with the study.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "ContactDetail"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ResearchStudy.relatedArtifact",
            "path": "ResearchStudy.relatedArtifact",
            "short": "References and dependencies",
            "definition": "Citations, references and other related documents.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "RelatedArtifact"
              }
            ]
          },
          {
            "id": "ResearchStudy.keyword",
            "path": "ResearchStudy.keyword",
            "short": "Used to search for the study",
            "definition": "Key terms to aid in searching for or filtering the study.",
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
                  "valueString": "ResearchStudyKeyword"
                }
              ],
              "strength": "example",
              "description": "Words associated with the study that may be useful in discovery."
            }
          },
          {
            "id": "ResearchStudy.location",
            "path": "ResearchStudy.location",
            "short": "Geographic region(s) for study",
            "definition": "Indicates a country, state or other region where the study is taking place.",
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
                  "valueString": "Jurisdiction"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "extensible",
              "description": "Countries and regions within which this artifact is targeted for use.",
              "valueSet": "http://hl7.org/fhir/ValueSet/jurisdiction"
            }
          },
          {
            "id": "ResearchStudy.description",
            "path": "ResearchStudy.description",
            "short": "What this is study doing",
            "definition": "A full description of how the study is being conducted.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "ResearchStudy.enrollment",
            "path": "ResearchStudy.enrollment",
            "short": "Inclusion & exclusion criteria",
            "definition": "Reference to a Group that defines the criteria for and quantity of subjects participating in the study.  E.g. \" 200 female Europeans between the ages of 20 and 45 with early onset diabetes\".",
            "comment": "The Group referenced should not generally enumerate specific subjects.  Subjects will be linked to the study using the ResearchSubject resource.",
            "alias": [
              "patient"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Group"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ResearchStudy.period",
            "path": "ResearchStudy.period",
            "short": "When the study began and ended",
            "definition": "Identifies the start date and the expected (or actual, depending on status) end date for the study.",
            "alias": [
              "timing"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ResearchStudy.sponsor",
            "path": "ResearchStudy.sponsor",
            "short": "Organization that initiates and is legally responsible for the study",
            "definition": "An organization that initiates the investigation and is legally responsible for the study.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ResearchStudy.principalInvestigator",
            "path": "ResearchStudy.principalInvestigator",
            "short": "Researcher who oversees multiple aspects of the study",
            "definition": "A researcher in a study who oversees multiple aspects of the study, such as concept development, protocol writing, protocol submission for IRB approval, participant recruitment, informed consent, data collection, analysis, interpretation and presentation.",
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
            ],
            "isSummary": true
          },
          {
            "id": "ResearchStudy.site",
            "path": "ResearchStudy.site",
            "short": "Facility where study activities are conducted",
            "definition": "A facility in which study activities are conducted.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Location"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ResearchStudy.reasonStopped",
            "path": "ResearchStudy.reasonStopped",
            "short": "accrual-goal-met | closed-due-to-toxicity | closed-due-to-lack-of-study-progress | temporarily-closed-per-study-design",
            "definition": "A description and/or code explaining the premature termination of the study.",
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
                  "valueString": "ResearchStudyReasonStopped"
                }
              ],
              "strength": "example",
              "description": "Codes for why the study ended prematurely.",
              "valueSet": "http://hl7.org/fhir/ValueSet/research-study-reason-stopped"
            }
          },
          {
            "id": "ResearchStudy.note",
            "path": "ResearchStudy.note",
            "short": "Comments made about the study",
            "definition": "Comments made about the study by the performer, subject or other participants.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Annotation"
              }
            ]
          },
          {
            "id": "ResearchStudy.arm",
            "path": "ResearchStudy.arm",
            "short": "Defined path through the study for a subject",
            "definition": "Describes an expected sequence of events for one of the participants of a study.  E.g. Exposure to drug A, wash-out, exposure to drug B, wash-out, follow-up.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ResearchStudy.arm.name",
            "path": "ResearchStudy.arm.name",
            "short": "Label for study arm",
            "definition": "Unique, human-readable label for this arm of the study.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ResearchStudy.arm.type",
            "path": "ResearchStudy.arm.type",
            "short": "Categorization of study arm",
            "definition": "Categorization of study arm, e.g. experimental, active comparator, placebo comparater.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "ResearchStudy.arm.description",
            "path": "ResearchStudy.arm.description",
            "short": "Short explanation of study path",
            "definition": "A succinct description of the path through the study that would be followed by a subject adhering to this arm.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ResearchStudy.objective",
            "path": "ResearchStudy.objective",
            "short": "A goal for the study",
            "definition": "A goal that the study is aiming to achieve in terms of a scientific question to be answered by the analysis of data collected during the study.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ResearchStudy.objective.name",
            "path": "ResearchStudy.objective.name",
            "short": "Label for the objective",
            "definition": "Unique, human-readable label for this objective of the study.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ResearchStudy.objective.type",
            "path": "ResearchStudy.objective.type",
            "short": "primary | secondary | exploratory",
            "definition": "The kind of study objective.",
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
                  "valueString": "ResearchStudyObjectiveType"
                }
              ],
              "strength": "preferred",
              "description": "Codes for the kind of study objective.",
              "valueSet": "http://hl7.org/fhir/ValueSet/research-study-objective-type"
            }
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir resource 'ResearchStudy'
    /// </summary>
    // 0. ResearchStudy
    public class Resource_ResearchStudy : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 23. ResearchStudy.arm
        public class Type_Arm : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 24. ResearchStudy.arm.name
            public ElementDefinitionInfo Element_Name;
            // 25. ResearchStudy.arm.type
            public ElementDefinitionInfo Element_Type;
            // 26. ResearchStudy.arm.description
            public ElementDefinitionInfo Element_Description;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ResearchStudy.arm",
                    ElementId = "ResearchStudy.arm"
                });
                Element_Name.Write(sDef);
                Element_Type.Write(sDef);
                Element_Description.Write(sDef);
            }
            
            public Type_Arm()
            {
                {
                    // 24. ResearchStudy.arm.name
                    this.Element_Name = new ElementDefinitionInfo
                    {
                        Name = "Element_Name",
                        Path= "ResearchStudy.arm.name",
                        Id = "ResearchStudy.arm.name",
                        Min = 1,
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
                    // 25. ResearchStudy.arm.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "ResearchStudy.arm.type",
                        Id = "ResearchStudy.arm.type",
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
                    // 26. ResearchStudy.arm.description
                    this.Element_Description = new ElementDefinitionInfo
                    {
                        Name = "Element_Description",
                        Path= "ResearchStudy.arm.description",
                        Id = "ResearchStudy.arm.description",
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
            }
        }
        // 27. ResearchStudy.objective
        public class Type_Objective : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 28. ResearchStudy.objective.name
            public ElementDefinitionInfo Element_Name;
            // 29. ResearchStudy.objective.type
            public ElementDefinitionInfo Element_Type;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ResearchStudy.objective",
                    ElementId = "ResearchStudy.objective"
                });
                Element_Name.Write(sDef);
                Element_Type.Write(sDef);
            }
            
            public Type_Objective()
            {
                {
                    // 28. ResearchStudy.objective.name
                    this.Element_Name = new ElementDefinitionInfo
                    {
                        Name = "Element_Name",
                        Path= "ResearchStudy.objective.name",
                        Id = "ResearchStudy.objective.name",
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
                    // 29. ResearchStudy.objective.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "ResearchStudy.objective.type",
                        Id = "ResearchStudy.objective.type",
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
        // 1. ResearchStudy.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. ResearchStudy.title
        public ElementDefinitionInfo Element_Title;
        // 3. ResearchStudy.protocol
        public ElementDefinitionInfo Element_Protocol;
        // 4. ResearchStudy.partOf
        public ElementDefinitionInfo Element_PartOf;
        // 5. ResearchStudy.status
        public ElementDefinitionInfo Element_Status;
        // 6. ResearchStudy.primaryPurposeType
        public ElementDefinitionInfo Element_PrimaryPurposeType;
        // 7. ResearchStudy.phase
        public ElementDefinitionInfo Element_Phase;
        // 8. ResearchStudy.category
        public ElementDefinitionInfo Element_Category;
        // 9. ResearchStudy.focus
        public ElementDefinitionInfo Element_Focus;
        // 10. ResearchStudy.condition
        public ElementDefinitionInfo Element_Condition;
        // 11. ResearchStudy.contact
        public ElementDefinitionInfo Element_Contact;
        // 12. ResearchStudy.relatedArtifact
        public ElementDefinitionInfo Element_RelatedArtifact;
        // 13. ResearchStudy.keyword
        public ElementDefinitionInfo Element_Keyword;
        // 14. ResearchStudy.location
        public ElementDefinitionInfo Element_Location;
        // 15. ResearchStudy.description
        public ElementDefinitionInfo Element_Description;
        // 16. ResearchStudy.enrollment
        public ElementDefinitionInfo Element_Enrollment;
        // 17. ResearchStudy.period
        public ElementDefinitionInfo Element_Period;
        // 18. ResearchStudy.sponsor
        public ElementDefinitionInfo Element_Sponsor;
        // 19. ResearchStudy.principalInvestigator
        public ElementDefinitionInfo Element_PrincipalInvestigator;
        // 20. ResearchStudy.site
        public ElementDefinitionInfo Element_Site;
        // 21. ResearchStudy.reasonStopped
        public ElementDefinitionInfo Element_ReasonStopped;
        // 22. ResearchStudy.note
        public ElementDefinitionInfo Element_Note;
        // 23. ResearchStudy.arm
        public ElementDefinitionInfo Element_Arm;
        // 27. ResearchStudy.objective
        public ElementDefinitionInfo Element_Objective;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "ResearchStudy",
                ElementId = "ResearchStudy"
            });
            Element_Identifier.Write(sDef);
            Element_Title.Write(sDef);
            Element_Protocol.Write(sDef);
            Element_PartOf.Write(sDef);
            Element_Status.Write(sDef);
            Element_PrimaryPurposeType.Write(sDef);
            Element_Phase.Write(sDef);
            Element_Category.Write(sDef);
            Element_Focus.Write(sDef);
            Element_Condition.Write(sDef);
            Element_Contact.Write(sDef);
            Element_RelatedArtifact.Write(sDef);
            Element_Keyword.Write(sDef);
            Element_Location.Write(sDef);
            Element_Description.Write(sDef);
            Element_Enrollment.Write(sDef);
            Element_Period.Write(sDef);
            Element_Sponsor.Write(sDef);
            Element_PrincipalInvestigator.Write(sDef);
            Element_Site.Write(sDef);
            Element_ReasonStopped.Write(sDef);
            Element_Note.Write(sDef);
            Element_Arm.Write(sDef);
            Element_Objective.Write(sDef);
        }
        
        public Resource_ResearchStudy()
        {
            {
                // 1. ResearchStudy.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "ResearchStudy.identifier",
                    Id = "ResearchStudy.identifier",
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
                // 2. ResearchStudy.title
                this.Element_Title = new ElementDefinitionInfo
                {
                    Name = "Element_Title",
                    Path= "ResearchStudy.title",
                    Id = "ResearchStudy.title",
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
                // 3. ResearchStudy.protocol
                this.Element_Protocol = new ElementDefinitionInfo
                {
                    Name = "Element_Protocol",
                    Path= "ResearchStudy.protocol",
                    Id = "ResearchStudy.protocol",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/PlanDefinition"
                            }
                        }
                    }
                };
            }
            {
                // 4. ResearchStudy.partOf
                this.Element_PartOf = new ElementDefinitionInfo
                {
                    Name = "Element_PartOf",
                    Path= "ResearchStudy.partOf",
                    Id = "ResearchStudy.partOf",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/ResearchStudy"
                            }
                        }
                    }
                };
            }
            {
                // 5. ResearchStudy.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "ResearchStudy.status",
                    Id = "ResearchStudy.status",
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
                // 6. ResearchStudy.primaryPurposeType
                this.Element_PrimaryPurposeType = new ElementDefinitionInfo
                {
                    Name = "Element_PrimaryPurposeType",
                    Path= "ResearchStudy.primaryPurposeType",
                    Id = "ResearchStudy.primaryPurposeType",
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
                // 7. ResearchStudy.phase
                this.Element_Phase = new ElementDefinitionInfo
                {
                    Name = "Element_Phase",
                    Path= "ResearchStudy.phase",
                    Id = "ResearchStudy.phase",
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
                // 8. ResearchStudy.category
                this.Element_Category = new ElementDefinitionInfo
                {
                    Name = "Element_Category",
                    Path= "ResearchStudy.category",
                    Id = "ResearchStudy.category",
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
                // 9. ResearchStudy.focus
                this.Element_Focus = new ElementDefinitionInfo
                {
                    Name = "Element_Focus",
                    Path= "ResearchStudy.focus",
                    Id = "ResearchStudy.focus",
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
                // 10. ResearchStudy.condition
                this.Element_Condition = new ElementDefinitionInfo
                {
                    Name = "Element_Condition",
                    Path= "ResearchStudy.condition",
                    Id = "ResearchStudy.condition",
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
                // 11. ResearchStudy.contact
                this.Element_Contact = new ElementDefinitionInfo
                {
                    Name = "Element_Contact",
                    Path= "ResearchStudy.contact",
                    Id = "ResearchStudy.contact",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_ContactDetail
                        {
                        }
                    }
                };
            }
            {
                // 12. ResearchStudy.relatedArtifact
                this.Element_RelatedArtifact = new ElementDefinitionInfo
                {
                    Name = "Element_RelatedArtifact",
                    Path= "ResearchStudy.relatedArtifact",
                    Id = "ResearchStudy.relatedArtifact",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_RelatedArtifact
                        {
                        }
                    }
                };
            }
            {
                // 13. ResearchStudy.keyword
                this.Element_Keyword = new ElementDefinitionInfo
                {
                    Name = "Element_Keyword",
                    Path= "ResearchStudy.keyword",
                    Id = "ResearchStudy.keyword",
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
                // 14. ResearchStudy.location
                this.Element_Location = new ElementDefinitionInfo
                {
                    Name = "Element_Location",
                    Path= "ResearchStudy.location",
                    Id = "ResearchStudy.location",
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
                // 15. ResearchStudy.description
                this.Element_Description = new ElementDefinitionInfo
                {
                    Name = "Element_Description",
                    Path= "ResearchStudy.description",
                    Id = "ResearchStudy.description",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Markdown
                        {
                        }
                    }
                };
            }
            {
                // 16. ResearchStudy.enrollment
                this.Element_Enrollment = new ElementDefinitionInfo
                {
                    Name = "Element_Enrollment",
                    Path= "ResearchStudy.enrollment",
                    Id = "ResearchStudy.enrollment",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Group"
                            }
                        }
                    }
                };
            }
            {
                // 17. ResearchStudy.period
                this.Element_Period = new ElementDefinitionInfo
                {
                    Name = "Element_Period",
                    Path= "ResearchStudy.period",
                    Id = "ResearchStudy.period",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Period
                        {
                        }
                    }
                };
            }
            {
                // 18. ResearchStudy.sponsor
                this.Element_Sponsor = new ElementDefinitionInfo
                {
                    Name = "Element_Sponsor",
                    Path= "ResearchStudy.sponsor",
                    Id = "ResearchStudy.sponsor",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Organization"
                            }
                        }
                    }
                };
            }
            {
                // 19. ResearchStudy.principalInvestigator
                this.Element_PrincipalInvestigator = new ElementDefinitionInfo
                {
                    Name = "Element_PrincipalInvestigator",
                    Path= "ResearchStudy.principalInvestigator",
                    Id = "ResearchStudy.principalInvestigator",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                            }
                        }
                    }
                };
            }
            {
                // 20. ResearchStudy.site
                this.Element_Site = new ElementDefinitionInfo
                {
                    Name = "Element_Site",
                    Path= "ResearchStudy.site",
                    Id = "ResearchStudy.site",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Location"
                            }
                        }
                    }
                };
            }
            {
                // 21. ResearchStudy.reasonStopped
                this.Element_ReasonStopped = new ElementDefinitionInfo
                {
                    Name = "Element_ReasonStopped",
                    Path= "ResearchStudy.reasonStopped",
                    Id = "ResearchStudy.reasonStopped",
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
                // 22. ResearchStudy.note
                this.Element_Note = new ElementDefinitionInfo
                {
                    Name = "Element_Note",
                    Path= "ResearchStudy.note",
                    Id = "ResearchStudy.note",
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
                // 23. ResearchStudy.arm
                this.Element_Arm = new ElementDefinitionInfo
                {
                    Name = "Element_Arm",
                    Path= "ResearchStudy.arm",
                    Id = "ResearchStudy.arm",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Arm
                        {
                        }
                    }
                };
            }
            {
                // 27. ResearchStudy.objective
                this.Element_Objective = new ElementDefinitionInfo
                {
                    Name = "Element_Objective",
                    Path= "ResearchStudy.objective",
                    Id = "ResearchStudy.objective",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Objective
                        {
                        }
                    }
                };
            }
            this.Name = "ResearchStudy";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/ResearchStudy";
        }
    }
}
