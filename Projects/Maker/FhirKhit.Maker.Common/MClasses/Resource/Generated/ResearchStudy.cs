using System;                                                                                                                               // MakerGen.cs:457
using System.Diagnostics;                                                                                                                   // MakerGen.cs:458
using System.IO;                                                                                                                            // MakerGen.cs:459
using System.Linq;                                                                                                                          // MakerGen.cs:460
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:461
                                                                                                                                            // MakerGen.cs:462
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:463
{                                                                                                                                           // MakerGen.cs:464
    #region Json                                                                                                                            // MakerGen.cs:465
    #if NEVER                                                                                                                               // MakerGen.cs:466
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
    #endregion                                                                                                                              // MakerGen.cs:469
    /// <summary>
    /// Fhir resource 'ResearchStudy'
    /// </summary>
    // 0. ResearchStudy
    public class ResearchStudy : FhirKhit.Maker.Common.Resource.ResourceBase                                                                // MakerGen.cs:379
    {                                                                                                                                       // MakerGen.cs:380
        public class ResearchStudy_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                   // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 23. ResearchStudy.arm
            public class Type_Arm : FhirKhit.Maker.Common.Complex.ComplexBase                                                               // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_Arm_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 24. ResearchStudy.arm.name
                    public ElementDefinitionInfo Name;                                                                                      // MakerGen.cs:211
                    // 25. ResearchStudy.arm.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:211
                    // 26. ResearchStudy.arm.description
                    public ElementDefinitionInfo Description;                                                                               // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_Arm_Elements()                                                                                              // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 24. ResearchStudy.arm.name
                            this.Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Name",                                                                                              // MakerGen.cs:230
                                Path= "ResearchStudy.arm.name",                                                                             // MakerGen.cs:231
                                Id = "ResearchStudy.arm.name",                                                                              // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 25. ResearchStudy.arm.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Type",                                                                                              // MakerGen.cs:230
                                Path= "ResearchStudy.arm.type",                                                                             // MakerGen.cs:231
                                Id = "ResearchStudy.arm.type",                                                                              // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 26. ResearchStudy.arm.description
                            this.Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Description",                                                                                       // MakerGen.cs:230
                                Path= "ResearchStudy.arm.description",                                                                      // MakerGen.cs:231
                                Id = "ResearchStudy.arm.description",                                                                       // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        Name.Write(sDef);                                                                                                   // MakerGen.cs:215
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:215
                        Description.Write(sDef);                                                                                            // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_Arm_Elements Elements                                                                                           // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_Arm_Elements();                                                                        // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_Arm_Elements elements;                                                                                                 // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_Arm()                                                                                                           // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "ResearchStudy.arm",                                                                                         // MakerGen.cs:423
                        ElementId = "ResearchStudy.arm"                                                                                     // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 27. ResearchStudy.objective
            public class Type_Objective : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_Objective_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                          // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 28. ResearchStudy.objective.name
                    public ElementDefinitionInfo Name;                                                                                      // MakerGen.cs:211
                    // 29. ResearchStudy.objective.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_Objective_Elements()                                                                                        // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 28. ResearchStudy.objective.name
                            this.Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Name",                                                                                              // MakerGen.cs:230
                                Path= "ResearchStudy.objective.name",                                                                       // MakerGen.cs:231
                                Id = "ResearchStudy.objective.name",                                                                        // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 29. ResearchStudy.objective.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Type",                                                                                              // MakerGen.cs:230
                                Path= "ResearchStudy.objective.type",                                                                       // MakerGen.cs:231
                                Id = "ResearchStudy.objective.type",                                                                        // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        Name.Write(sDef);                                                                                                   // MakerGen.cs:215
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_Objective_Elements Elements                                                                                     // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_Objective_Elements();                                                                  // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_Objective_Elements elements;                                                                                           // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_Objective()                                                                                                     // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "ResearchStudy.objective",                                                                                   // MakerGen.cs:423
                        ElementId = "ResearchStudy.objective"                                                                               // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 1. ResearchStudy.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:211
            // 2. ResearchStudy.title
            public ElementDefinitionInfo Title;                                                                                             // MakerGen.cs:211
            // 3. ResearchStudy.protocol
            public ElementDefinitionInfo Protocol;                                                                                          // MakerGen.cs:211
            // 4. ResearchStudy.partOf
            public ElementDefinitionInfo PartOf;                                                                                            // MakerGen.cs:211
            // 5. ResearchStudy.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:211
            // 6. ResearchStudy.primaryPurposeType
            public ElementDefinitionInfo PrimaryPurposeType;                                                                                // MakerGen.cs:211
            // 7. ResearchStudy.phase
            public ElementDefinitionInfo Phase;                                                                                             // MakerGen.cs:211
            // 8. ResearchStudy.category
            public ElementDefinitionInfo Category;                                                                                          // MakerGen.cs:211
            // 9. ResearchStudy.focus
            public ElementDefinitionInfo Focus;                                                                                             // MakerGen.cs:211
            // 10. ResearchStudy.condition
            public ElementDefinitionInfo Condition;                                                                                         // MakerGen.cs:211
            // 11. ResearchStudy.contact
            public ElementDefinitionInfo Contact;                                                                                           // MakerGen.cs:211
            // 12. ResearchStudy.relatedArtifact
            public ElementDefinitionInfo RelatedArtifact;                                                                                   // MakerGen.cs:211
            // 13. ResearchStudy.keyword
            public ElementDefinitionInfo Keyword;                                                                                           // MakerGen.cs:211
            // 14. ResearchStudy.location
            public ElementDefinitionInfo Location;                                                                                          // MakerGen.cs:211
            // 15. ResearchStudy.description
            public ElementDefinitionInfo Description;                                                                                       // MakerGen.cs:211
            // 16. ResearchStudy.enrollment
            public ElementDefinitionInfo Enrollment;                                                                                        // MakerGen.cs:211
            // 17. ResearchStudy.period
            public ElementDefinitionInfo Period;                                                                                            // MakerGen.cs:211
            // 18. ResearchStudy.sponsor
            public ElementDefinitionInfo Sponsor;                                                                                           // MakerGen.cs:211
            // 19. ResearchStudy.principalInvestigator
            public ElementDefinitionInfo PrincipalInvestigator;                                                                             // MakerGen.cs:211
            // 20. ResearchStudy.site
            public ElementDefinitionInfo Site;                                                                                              // MakerGen.cs:211
            // 21. ResearchStudy.reasonStopped
            public ElementDefinitionInfo ReasonStopped;                                                                                     // MakerGen.cs:211
            // 22. ResearchStudy.note
            public ElementDefinitionInfo Note;                                                                                              // MakerGen.cs:211
            // 23. ResearchStudy.arm
            public ElementDefinitionInfo Arm;                                                                                               // MakerGen.cs:211
            // 27. ResearchStudy.objective
            public ElementDefinitionInfo Objective;                                                                                         // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
            public ResearchStudy_Elements()                                                                                                 // MakerGen.cs:387
            {                                                                                                                               // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:226
                    // 1. ResearchStudy.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Identifier",                                                                                                // MakerGen.cs:230
                        Path= "ResearchStudy.identifier",                                                                                   // MakerGen.cs:231
                        Id = "ResearchStudy.identifier",                                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. ResearchStudy.title
                    this.Title = new ElementDefinitionInfo                                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Title",                                                                                                     // MakerGen.cs:230
                        Path= "ResearchStudy.title",                                                                                        // MakerGen.cs:231
                        Id = "ResearchStudy.title",                                                                                         // MakerGen.cs:232
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
                    // 3. ResearchStudy.protocol
                    this.Protocol = new ElementDefinitionInfo                                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Protocol",                                                                                                  // MakerGen.cs:230
                        Path= "ResearchStudy.protocol",                                                                                     // MakerGen.cs:231
                        Id = "ResearchStudy.protocol",                                                                                      // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/PlanDefinition"                                                // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 4. ResearchStudy.partOf
                    this.PartOf = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "PartOf",                                                                                                    // MakerGen.cs:230
                        Path= "ResearchStudy.partOf",                                                                                       // MakerGen.cs:231
                        Id = "ResearchStudy.partOf",                                                                                        // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ResearchStudy"                                                 // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. ResearchStudy.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Status",                                                                                                    // MakerGen.cs:230
                        Path= "ResearchStudy.status",                                                                                       // MakerGen.cs:231
                        Id = "ResearchStudy.status",                                                                                        // MakerGen.cs:232
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
                    // 6. ResearchStudy.primaryPurposeType
                    this.PrimaryPurposeType = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "PrimaryPurposeType",                                                                                        // MakerGen.cs:230
                        Path= "ResearchStudy.primaryPurposeType",                                                                           // MakerGen.cs:231
                        Id = "ResearchStudy.primaryPurposeType",                                                                            // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 7. ResearchStudy.phase
                    this.Phase = new ElementDefinitionInfo                                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Phase",                                                                                                     // MakerGen.cs:230
                        Path= "ResearchStudy.phase",                                                                                        // MakerGen.cs:231
                        Id = "ResearchStudy.phase",                                                                                         // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 8. ResearchStudy.category
                    this.Category = new ElementDefinitionInfo                                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Category",                                                                                                  // MakerGen.cs:230
                        Path= "ResearchStudy.category",                                                                                     // MakerGen.cs:231
                        Id = "ResearchStudy.category",                                                                                      // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 9. ResearchStudy.focus
                    this.Focus = new ElementDefinitionInfo                                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Focus",                                                                                                     // MakerGen.cs:230
                        Path= "ResearchStudy.focus",                                                                                        // MakerGen.cs:231
                        Id = "ResearchStudy.focus",                                                                                         // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 10. ResearchStudy.condition
                    this.Condition = new ElementDefinitionInfo                                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Condition",                                                                                                 // MakerGen.cs:230
                        Path= "ResearchStudy.condition",                                                                                    // MakerGen.cs:231
                        Id = "ResearchStudy.condition",                                                                                     // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 11. ResearchStudy.contact
                    this.Contact = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Contact",                                                                                                   // MakerGen.cs:230
                        Path= "ResearchStudy.contact",                                                                                      // MakerGen.cs:231
                        Id = "ResearchStudy.contact",                                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.ContactDetail                                                                 // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 12. ResearchStudy.relatedArtifact
                    this.RelatedArtifact = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "RelatedArtifact",                                                                                           // MakerGen.cs:230
                        Path= "ResearchStudy.relatedArtifact",                                                                              // MakerGen.cs:231
                        Id = "ResearchStudy.relatedArtifact",                                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.RelatedArtifact                                                               // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 13. ResearchStudy.keyword
                    this.Keyword = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Keyword",                                                                                                   // MakerGen.cs:230
                        Path= "ResearchStudy.keyword",                                                                                      // MakerGen.cs:231
                        Id = "ResearchStudy.keyword",                                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 14. ResearchStudy.location
                    this.Location = new ElementDefinitionInfo                                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Location",                                                                                                  // MakerGen.cs:230
                        Path= "ResearchStudy.location",                                                                                     // MakerGen.cs:231
                        Id = "ResearchStudy.location",                                                                                      // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 15. ResearchStudy.description
                    this.Description = new ElementDefinitionInfo                                                                            // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Description",                                                                                               // MakerGen.cs:230
                        Path= "ResearchStudy.description",                                                                                  // MakerGen.cs:231
                        Id = "ResearchStudy.description",                                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Markdown                                                                    // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 16. ResearchStudy.enrollment
                    this.Enrollment = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Enrollment",                                                                                                // MakerGen.cs:230
                        Path= "ResearchStudy.enrollment",                                                                                   // MakerGen.cs:231
                        Id = "ResearchStudy.enrollment",                                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Group"                                                         // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 17. ResearchStudy.period
                    this.Period = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Period",                                                                                                    // MakerGen.cs:230
                        Path= "ResearchStudy.period",                                                                                       // MakerGen.cs:231
                        Id = "ResearchStudy.period",                                                                                        // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 18. ResearchStudy.sponsor
                    this.Sponsor = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Sponsor",                                                                                                   // MakerGen.cs:230
                        Path= "ResearchStudy.sponsor",                                                                                      // MakerGen.cs:231
                        Id = "ResearchStudy.sponsor",                                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 19. ResearchStudy.principalInvestigator
                    this.PrincipalInvestigator = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "PrincipalInvestigator",                                                                                     // MakerGen.cs:230
                        Path= "ResearchStudy.principalInvestigator",                                                                        // MakerGen.cs:231
                        Id = "ResearchStudy.principalInvestigator",                                                                         // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:344
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                              // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 20. ResearchStudy.site
                    this.Site = new ElementDefinitionInfo                                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Site",                                                                                                      // MakerGen.cs:230
                        Path= "ResearchStudy.site",                                                                                         // MakerGen.cs:231
                        Id = "ResearchStudy.site",                                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Location"                                                      // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 21. ResearchStudy.reasonStopped
                    this.ReasonStopped = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "ReasonStopped",                                                                                             // MakerGen.cs:230
                        Path= "ResearchStudy.reasonStopped",                                                                                // MakerGen.cs:231
                        Id = "ResearchStudy.reasonStopped",                                                                                 // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 22. ResearchStudy.note
                    this.Note = new ElementDefinitionInfo                                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Note",                                                                                                      // MakerGen.cs:230
                        Path= "ResearchStudy.note",                                                                                         // MakerGen.cs:231
                        Id = "ResearchStudy.note",                                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Annotation                                                                    // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 23. ResearchStudy.arm
                    this.Arm = new ElementDefinitionInfo                                                                                    // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Arm",                                                                                                       // MakerGen.cs:230
                        Path= "ResearchStudy.arm",                                                                                          // MakerGen.cs:231
                        Id = "ResearchStudy.arm",                                                                                           // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Arm                                                                                                    // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 27. ResearchStudy.objective
                    this.Objective = new ElementDefinitionInfo                                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Objective",                                                                                                 // MakerGen.cs:230
                        Path= "ResearchStudy.objective",                                                                                    // MakerGen.cs:231
                        Id = "ResearchStudy.objective",                                                                                     // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Objective                                                                                              // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                base.Write(sDef);                                                                                                           // MakerGen.cs:395
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:215
                Title.Write(sDef);                                                                                                          // MakerGen.cs:215
                Protocol.Write(sDef);                                                                                                       // MakerGen.cs:215
                PartOf.Write(sDef);                                                                                                         // MakerGen.cs:215
                Status.Write(sDef);                                                                                                         // MakerGen.cs:215
                PrimaryPurposeType.Write(sDef);                                                                                             // MakerGen.cs:215
                Phase.Write(sDef);                                                                                                          // MakerGen.cs:215
                Category.Write(sDef);                                                                                                       // MakerGen.cs:215
                Focus.Write(sDef);                                                                                                          // MakerGen.cs:215
                Condition.Write(sDef);                                                                                                      // MakerGen.cs:215
                Contact.Write(sDef);                                                                                                        // MakerGen.cs:215
                RelatedArtifact.Write(sDef);                                                                                                // MakerGen.cs:215
                Keyword.Write(sDef);                                                                                                        // MakerGen.cs:215
                Location.Write(sDef);                                                                                                       // MakerGen.cs:215
                Description.Write(sDef);                                                                                                    // MakerGen.cs:215
                Enrollment.Write(sDef);                                                                                                     // MakerGen.cs:215
                Period.Write(sDef);                                                                                                         // MakerGen.cs:215
                Sponsor.Write(sDef);                                                                                                        // MakerGen.cs:215
                PrincipalInvestigator.Write(sDef);                                                                                          // MakerGen.cs:215
                Site.Write(sDef);                                                                                                           // MakerGen.cs:215
                ReasonStopped.Write(sDef);                                                                                                  // MakerGen.cs:215
                Note.Write(sDef);                                                                                                           // MakerGen.cs:215
                Arm.Write(sDef);                                                                                                            // MakerGen.cs:215
                Objective.Write(sDef);                                                                                                      // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:397
        }                                                                                                                                   // MakerGen.cs:399
        public ResearchStudy_Elements Elements                                                                                              // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            get                                                                                                                             // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:404
                if (this.elements == null)                                                                                                  // MakerGen.cs:405
                    this.elements = new ResearchStudy_Elements();                                                                           // MakerGen.cs:406
                return this.elements;                                                                                                       // MakerGen.cs:407
            }                                                                                                                               // MakerGen.cs:408
        }                                                                                                                                   // MakerGen.cs:409
        ResearchStudy_Elements elements;                                                                                                    // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
        public ResearchStudy()                                                                                                              // MakerGen.cs:413
        {                                                                                                                                   // MakerGen.cs:414
            this.Name = "ResearchStudy";                                                                                                    // MakerGen.cs:487
            this.Uri = "http://hl7.org/fhir/StructureDefinition/ResearchStudy";                                                             // MakerGen.cs:488
        }                                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:419
        {                                                                                                                                   // MakerGen.cs:420
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:421
            {                                                                                                                               // MakerGen.cs:422
                Path = "ResearchStudy",                                                                                                     // MakerGen.cs:423
                ElementId = "ResearchStudy"                                                                                                 // MakerGen.cs:424
            });                                                                                                                             // MakerGen.cs:425
            if (this.elements != null)                                                                                                      // MakerGen.cs:426
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:427
        }                                                                                                                                   // MakerGen.cs:428
    }                                                                                                                                       // MakerGen.cs:429
}                                                                                                                                           // MakerGen.cs:474
