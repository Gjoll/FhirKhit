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
      "id": "ClinicalImpression",
      "url": "http://hl7.org/fhir/StructureDefinition/ClinicalImpression",
      "version": "4.0.0",
      "name": "ClinicalImpression",
      "status": "draft",
      "publisher": "Health Level Seven International (Patient Care)",
      "description": "A record of a clinical assessment performed to determine what problem(s) may affect the patient and before planning the treatments or management strategies that are best to manage a patient's condition. Assessments are often 1:1 with a clinical consultation / encounter,  but this varies greatly depending on the clinical workflow. This resource is called \"ClinicalImpression\" rather than \"ClinicalAssessment\" to avoid confusion with the recording of assessment tools such as Apgar score.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "ClinicalImpression",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "ClinicalImpression",
            "path": "ClinicalImpression",
            "short": "A clinical assessment performed when planning treatments and management strategies for a patient",
            "definition": "A record of a clinical assessment performed to determine what problem(s) may affect the patient and before planning the treatments or management strategies that are best to manage a patient's condition. Assessments are often 1:1 with a clinical consultation / encounter,  but this varies greatly depending on the clinical workflow. This resource is called \"ClinicalImpression\" rather than \"ClinicalAssessment\" to avoid confusion with the recording of assessment tools such as Apgar score.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "ClinicalImpression.identifier",
            "path": "ClinicalImpression.identifier",
            "short": "Business identifier",
            "definition": "Business identifiers assigned to this clinical impression by the performer or other systems which remain constant as the resource is updated and propagates from server to server.",
            "comment": "This is a business identifier, not a resource identifier (see [discussion](resource.html#identifiers)).  It is best practice for the identifier to only appear on a single resource instance, however business practices may occasionally dictate that multiple resource instances with the same identifier can exist - possibly even with different resource types.  For example, multiple Patient and a Person resource instance might share the same social insurance number.",
            "requirements": "Allows identification of the clinical impression as it is known by various participating systems and in a way that remains consistent across servers.",
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
            "id": "ClinicalImpression.status",
            "path": "ClinicalImpression.status",
            "short": "draft | completed | entered-in-error",
            "definition": "Identifies the workflow status of the assessment.",
            "comment": "This element is labeled as a modifier because the status contains the code entered-in-error that marks the clinical impression as not currently valid.",
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
                  "valueString": "ClinicalImpressionStatus"
                }
              ],
              "strength": "required",
              "description": "The workflow state of a clinical impression.",
              "valueSet": "http://hl7.org/fhir/ValueSet/clinicalimpression-status|4.0.0"
            }
          },
          {
            "id": "ClinicalImpression.statusReason",
            "path": "ClinicalImpression.statusReason",
            "short": "Reason for current status",
            "definition": "Captures the reason for the current state of the ClinicalImpression.",
            "comment": "This is generally only used for \"exception\" statuses such as \"not-done\", \"suspended\" or \"cancelled\".\n\n[distinct reason codes for different statuses can be enforced using invariants if they are universal bindings].",
            "alias": [
              "Suspended Reason",
              "Cancelled Reason"
            ],
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
                  "valueString": "ClinicalImpressionStatusReason"
                }
              ],
              "strength": "example",
              "description": "Codes identifying the reason for the current state of a clinical impression."
            }
          },
          {
            "id": "ClinicalImpression.code",
            "path": "ClinicalImpression.code",
            "short": "Kind of assessment performed",
            "definition": "Categorizes the type of clinical assessment performed.",
            "comment": "This is present as a place-holder only and may be removed based on feedback/work group opinion.",
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
                  "valueString": "ClinicalImpressionCode"
                }
              ],
              "strength": "example",
              "description": "Identifies categories of clinical impressions.  This is a place-holder only.  It may be removed."
            }
          },
          {
            "id": "ClinicalImpression.description",
            "path": "ClinicalImpression.description",
            "short": "Why/how the assessment was performed",
            "definition": "A summary of the context and/or cause of the assessment - why / where it was performed, and what patient events/status prompted it.",
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
            "id": "ClinicalImpression.subject",
            "path": "ClinicalImpression.subject",
            "short": "Patient or group assessed",
            "definition": "The patient or group of individuals assessed as part of this record.",
            "requirements": "Group is typically for veterinary and/or public health purposes.",
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
            "id": "ClinicalImpression.encounter",
            "path": "ClinicalImpression.encounter",
            "short": "Encounter created as part of",
            "definition": "The Encounter during which this ClinicalImpression was created or to which the creation of this record is tightly associated.",
            "comment": "This will typically be the encounter the event occurred within, but some activities may be initiated prior to or after the official completion of an encounter but still be tied to the context of the encounter.",
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
            "id": "ClinicalImpression.effective[x]",
            "path": "ClinicalImpression.effective[x]",
            "short": "Time of assessment",
            "definition": "The point in time or period over which the subject was assessed.",
            "comment": "This SHOULD be accurate to at least the minute, though some assessments only have a known date.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              },
              {
                "code": "Period"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ClinicalImpression.date",
            "path": "ClinicalImpression.date",
            "short": "When the assessment was documented",
            "definition": "Indicates when the documentation of the assessment was complete.",
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
            "id": "ClinicalImpression.assessor",
            "path": "ClinicalImpression.assessor",
            "short": "The clinician performing the assessment",
            "definition": "The clinician performing the assessment.",
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
            "id": "ClinicalImpression.previous",
            "path": "ClinicalImpression.previous",
            "short": "Reference to last assessment",
            "definition": "A reference to the last assessment that was conducted on this patient. Assessments are often/usually ongoing in nature; a care provider (practitioner or team) will make new assessments on an ongoing basis as new data arises or the patient's conditions changes.",
            "comment": "It is always likely that multiple previous assessments exist for a patient. The point of quoting a previous assessment is that this assessment is relative to it (see resolved).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ClinicalImpression"
                ]
              }
            ]
          },
          {
            "id": "ClinicalImpression.problem",
            "path": "ClinicalImpression.problem",
            "short": "Relevant impressions of patient state",
            "definition": "A list of the relevant problems/conditions for a patient.",
            "comment": "e.g. The patient is a pregnant, has congestive heart failure, has an ‎Adenocarcinoma, and is allergic to penicillin.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Condition",
                  "http://hl7.org/fhir/StructureDefinition/AllergyIntolerance"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ClinicalImpression.investigation",
            "path": "ClinicalImpression.investigation",
            "short": "One or more sets of investigations (signs, symptoms, etc.)",
            "definition": "One or more sets of investigations (signs, symptoms, etc.). The actual grouping of investigations varies greatly depending on the type and context of the assessment. These investigations may include data generated during the assessment process, or data previously generated and recorded that is pertinent to the outcomes.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ClinicalImpression.investigation.code",
            "path": "ClinicalImpression.investigation.code",
            "short": "A name/code for the set",
            "definition": "A name/code for the group (\"set\") of investigations. Typically, this will be something like \"signs\", \"symptoms\", \"clinical\", \"diagnostic\", but the list is not constrained, and others such groups such as (exposure|family|travel|nutritional) history may be used.",
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
                  "valueString": "InvestigationGroupType"
                }
              ],
              "strength": "example",
              "description": "A name/code for a set of investigations.",
              "valueSet": "http://hl7.org/fhir/ValueSet/investigation-sets"
            }
          },
          {
            "id": "ClinicalImpression.investigation.item",
            "path": "ClinicalImpression.investigation.item",
            "short": "Record of a specific investigation",
            "definition": "A record of a specific investigation that was undertaken.",
            "comment": "Most investigations are observations of one kind or another but some other specific types of data collection resources can also be used.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Observation",
                  "http://hl7.org/fhir/StructureDefinition/QuestionnaireResponse",
                  "http://hl7.org/fhir/StructureDefinition/FamilyMemberHistory",
                  "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",
                  "http://hl7.org/fhir/StructureDefinition/RiskAssessment",
                  "http://hl7.org/fhir/StructureDefinition/ImagingStudy",
                  "http://hl7.org/fhir/StructureDefinition/Media"
                ]
              }
            ]
          },
          {
            "id": "ClinicalImpression.protocol",
            "path": "ClinicalImpression.protocol",
            "short": "Clinical Protocol followed",
            "definition": "Reference to a specific published clinical protocol that was followed during this assessment, and/or that provides evidence in support of the diagnosis.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "uri"
              }
            ]
          },
          {
            "id": "ClinicalImpression.summary",
            "path": "ClinicalImpression.summary",
            "short": "Summary of the assessment",
            "definition": "A text summary of the investigations and the diagnosis.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ClinicalImpression.finding",
            "path": "ClinicalImpression.finding",
            "short": "Possible or likely findings and diagnoses",
            "definition": "Specific findings or diagnoses that were considered likely or relevant to ongoing treatment.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ClinicalImpression.finding.itemCodeableConcept",
            "path": "ClinicalImpression.finding.itemCodeableConcept",
            "short": "What was found",
            "definition": "Specific text or code for finding or diagnosis, which may include ruled-out or resolved conditions.",
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
                  "valueString": "ConditionKind"
                }
              ],
              "strength": "example",
              "description": "Identification of the Condition or diagnosis.",
              "valueSet": "http://hl7.org/fhir/ValueSet/condition-code"
            }
          },
          {
            "id": "ClinicalImpression.finding.itemReference",
            "path": "ClinicalImpression.finding.itemReference",
            "short": "What was found",
            "definition": "Specific reference for finding or diagnosis, which may include ruled-out or resolved conditions.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Condition",
                  "http://hl7.org/fhir/StructureDefinition/Observation",
                  "http://hl7.org/fhir/StructureDefinition/Media"
                ]
              }
            ]
          },
          {
            "id": "ClinicalImpression.finding.basis",
            "path": "ClinicalImpression.finding.basis",
            "short": "Which investigations support finding",
            "definition": "Which investigations support finding or diagnosis.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ClinicalImpression.prognosisCodeableConcept",
            "path": "ClinicalImpression.prognosisCodeableConcept",
            "short": "Estimate of likely outcome",
            "definition": "Estimate of likely outcome.",
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
                  "valueString": "ClinicalImpressionPrognosis"
                }
              ],
              "strength": "example",
              "description": "Prognosis or outlook findings.",
              "valueSet": "http://hl7.org/fhir/ValueSet/clinicalimpression-prognosis"
            }
          },
          {
            "id": "ClinicalImpression.prognosisReference",
            "path": "ClinicalImpression.prognosisReference",
            "short": "RiskAssessment expressing likely outcome",
            "definition": "RiskAssessment expressing likely outcome.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/RiskAssessment"
                ]
              }
            ]
          },
          {
            "id": "ClinicalImpression.supportingInfo",
            "path": "ClinicalImpression.supportingInfo",
            "short": "Information supporting the clinical impression",
            "definition": "Information supporting the clinical impression.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ]
          },
          {
            "id": "ClinicalImpression.note",
            "path": "ClinicalImpression.note",
            "short": "Comments made about the ClinicalImpression",
            "definition": "Commentary about the impression, typically recorded after the impression itself was made, though supplemental notes by the original author could also appear.",
            "comment": "Don't use this element for content that should more properly appear as one of the specific elements of the impression.",
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
    /// Fhir resource 'ClinicalImpression'
    /// </summary>
    // 0. ClinicalImpression
    public partial class Resource_ClinicalImpression : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 13. ClinicalImpression.investigation
        public partial class Type_Investigation : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 14. ClinicalImpression.investigation.code
            public ElementDefinitionInfo Element_Code;
            // 15. ClinicalImpression.investigation.item
            public ElementDefinitionInfo Element_Item;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ClinicalImpression.investigation",
                    ElementId = "ClinicalImpression.investigation"
                });
                Element_Code.Write(sDef);
                Element_Item.Write(sDef);
            }
            
            public Type_Investigation()
            {
                {
                    // 14. ClinicalImpression.investigation.code
                    this.Element_Code = new ElementDefinitionInfo
                    {
                        Name = "Element_Code",
                        Path= "ClinicalImpression.investigation.code",
                        Id = "ClinicalImpression.investigation.code",
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
                    // 15. ClinicalImpression.investigation.item
                    this.Element_Item = new ElementDefinitionInfo
                    {
                        Name = "Element_Item",
                        Path= "ClinicalImpression.investigation.item",
                        Id = "ClinicalImpression.investigation.item",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Observation",
                                    "http://hl7.org/fhir/StructureDefinition/QuestionnaireResponse",
                                    "http://hl7.org/fhir/StructureDefinition/FamilyMemberHistory",
                                    "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",
                                    "http://hl7.org/fhir/StructureDefinition/RiskAssessment",
                                    "http://hl7.org/fhir/StructureDefinition/ImagingStudy",
                                    "http://hl7.org/fhir/StructureDefinition/Media"
                                }
                            }
                        }
                    };
                }
            }
        }
        // 18. ClinicalImpression.finding
        public partial class Type_Finding : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 19. ClinicalImpression.finding.itemCodeableConcept
            public ElementDefinitionInfo Element_ItemCodeableConcept;
            // 20. ClinicalImpression.finding.itemReference
            public ElementDefinitionInfo Element_ItemReference;
            // 21. ClinicalImpression.finding.basis
            public ElementDefinitionInfo Element_Basis;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ClinicalImpression.finding",
                    ElementId = "ClinicalImpression.finding"
                });
                Element_ItemCodeableConcept.Write(sDef);
                Element_ItemReference.Write(sDef);
                Element_Basis.Write(sDef);
            }
            
            public Type_Finding()
            {
                {
                    // 19. ClinicalImpression.finding.itemCodeableConcept
                    this.Element_ItemCodeableConcept = new ElementDefinitionInfo
                    {
                        Name = "Element_ItemCodeableConcept",
                        Path= "ClinicalImpression.finding.itemCodeableConcept",
                        Id = "ClinicalImpression.finding.itemCodeableConcept",
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
                    // 20. ClinicalImpression.finding.itemReference
                    this.Element_ItemReference = new ElementDefinitionInfo
                    {
                        Name = "Element_ItemReference",
                        Path= "ClinicalImpression.finding.itemReference",
                        Id = "ClinicalImpression.finding.itemReference",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Condition",
                                    "http://hl7.org/fhir/StructureDefinition/Observation",
                                    "http://hl7.org/fhir/StructureDefinition/Media"
                                }
                            }
                        }
                    };
                }
                {
                    // 21. ClinicalImpression.finding.basis
                    this.Element_Basis = new ElementDefinitionInfo
                    {
                        Name = "Element_Basis",
                        Path= "ClinicalImpression.finding.basis",
                        Id = "ClinicalImpression.finding.basis",
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
        // 1. ClinicalImpression.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. ClinicalImpression.status
        public ElementDefinitionInfo Element_Status;
        // 3. ClinicalImpression.statusReason
        public ElementDefinitionInfo Element_StatusReason;
        // 4. ClinicalImpression.code
        public ElementDefinitionInfo Element_Code;
        // 5. ClinicalImpression.description
        public ElementDefinitionInfo Element_Description;
        // 6. ClinicalImpression.subject
        public ElementDefinitionInfo Element_Subject;
        // 7. ClinicalImpression.encounter
        public ElementDefinitionInfo Element_Encounter;
        // 8. ClinicalImpression.effective[x]
        public ElementDefinitionInfo Element_Effective;
        // 9. ClinicalImpression.date
        public ElementDefinitionInfo Element_Date;
        // 10. ClinicalImpression.assessor
        public ElementDefinitionInfo Element_Assessor;
        // 11. ClinicalImpression.previous
        public ElementDefinitionInfo Element_Previous;
        // 12. ClinicalImpression.problem
        public ElementDefinitionInfo Element_Problem;
        // 13. ClinicalImpression.investigation
        public ElementDefinitionInfo Element_Investigation;
        // 16. ClinicalImpression.protocol
        public ElementDefinitionInfo Element_Protocol;
        // 17. ClinicalImpression.summary
        public ElementDefinitionInfo Element_Summary;
        // 18. ClinicalImpression.finding
        public ElementDefinitionInfo Element_Finding;
        // 22. ClinicalImpression.prognosisCodeableConcept
        public ElementDefinitionInfo Element_PrognosisCodeableConcept;
        // 23. ClinicalImpression.prognosisReference
        public ElementDefinitionInfo Element_PrognosisReference;
        // 24. ClinicalImpression.supportingInfo
        public ElementDefinitionInfo Element_SupportingInfo;
        // 25. ClinicalImpression.note
        public ElementDefinitionInfo Element_Note;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "ClinicalImpression",
                ElementId = "ClinicalImpression"
            });
            Element_Identifier.Write(sDef);
            Element_Status.Write(sDef);
            Element_StatusReason.Write(sDef);
            Element_Code.Write(sDef);
            Element_Description.Write(sDef);
            Element_Subject.Write(sDef);
            Element_Encounter.Write(sDef);
            Element_Effective.Write(sDef);
            Element_Date.Write(sDef);
            Element_Assessor.Write(sDef);
            Element_Previous.Write(sDef);
            Element_Problem.Write(sDef);
            Element_Investigation.Write(sDef);
            Element_Protocol.Write(sDef);
            Element_Summary.Write(sDef);
            Element_Finding.Write(sDef);
            Element_PrognosisCodeableConcept.Write(sDef);
            Element_PrognosisReference.Write(sDef);
            Element_SupportingInfo.Write(sDef);
            Element_Note.Write(sDef);
        }
        
        public Resource_ClinicalImpression()
        {
            {
                // 1. ClinicalImpression.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "ClinicalImpression.identifier",
                    Id = "ClinicalImpression.identifier",
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
                // 2. ClinicalImpression.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "ClinicalImpression.status",
                    Id = "ClinicalImpression.status",
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
                // 3. ClinicalImpression.statusReason
                this.Element_StatusReason = new ElementDefinitionInfo
                {
                    Name = "Element_StatusReason",
                    Path= "ClinicalImpression.statusReason",
                    Id = "ClinicalImpression.statusReason",
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
                // 4. ClinicalImpression.code
                this.Element_Code = new ElementDefinitionInfo
                {
                    Name = "Element_Code",
                    Path= "ClinicalImpression.code",
                    Id = "ClinicalImpression.code",
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
                // 5. ClinicalImpression.description
                this.Element_Description = new ElementDefinitionInfo
                {
                    Name = "Element_Description",
                    Path= "ClinicalImpression.description",
                    Id = "ClinicalImpression.description",
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
                // 6. ClinicalImpression.subject
                this.Element_Subject = new ElementDefinitionInfo
                {
                    Name = "Element_Subject",
                    Path= "ClinicalImpression.subject",
                    Id = "ClinicalImpression.subject",
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
                // 7. ClinicalImpression.encounter
                this.Element_Encounter = new ElementDefinitionInfo
                {
                    Name = "Element_Encounter",
                    Path= "ClinicalImpression.encounter",
                    Id = "ClinicalImpression.encounter",
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
                // 8. ClinicalImpression.effective[x]
                this.Element_Effective = new ElementDefinitionInfo
                {
                    Name = "Element_Effective",
                    Path= "ClinicalImpression.effective[x]",
                    Id = "ClinicalImpression.effective[x]",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Period
                        {
                        }
                    }
                };
            }
            {
                // 9. ClinicalImpression.date
                this.Element_Date = new ElementDefinitionInfo
                {
                    Name = "Element_Date",
                    Path= "ClinicalImpression.date",
                    Id = "ClinicalImpression.date",
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
                // 10. ClinicalImpression.assessor
                this.Element_Assessor = new ElementDefinitionInfo
                {
                    Name = "Element_Assessor",
                    Path= "ClinicalImpression.assessor",
                    Id = "ClinicalImpression.assessor",
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
                // 11. ClinicalImpression.previous
                this.Element_Previous = new ElementDefinitionInfo
                {
                    Name = "Element_Previous",
                    Path= "ClinicalImpression.previous",
                    Id = "ClinicalImpression.previous",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/ClinicalImpression"
                            }
                        }
                    }
                };
            }
            {
                // 12. ClinicalImpression.problem
                this.Element_Problem = new ElementDefinitionInfo
                {
                    Name = "Element_Problem",
                    Path= "ClinicalImpression.problem",
                    Id = "ClinicalImpression.problem",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Condition",
                                "http://hl7.org/fhir/StructureDefinition/AllergyIntolerance"
                            }
                        }
                    }
                };
            }
            {
                // 13. ClinicalImpression.investigation
                this.Element_Investigation = new ElementDefinitionInfo
                {
                    Name = "Element_Investigation",
                    Path= "ClinicalImpression.investigation",
                    Id = "ClinicalImpression.investigation",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Investigation
                        {
                        }
                    }
                };
            }
            {
                // 16. ClinicalImpression.protocol
                this.Element_Protocol = new ElementDefinitionInfo
                {
                    Name = "Element_Protocol",
                    Path= "ClinicalImpression.protocol",
                    Id = "ClinicalImpression.protocol",
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
                // 17. ClinicalImpression.summary
                this.Element_Summary = new ElementDefinitionInfo
                {
                    Name = "Element_Summary",
                    Path= "ClinicalImpression.summary",
                    Id = "ClinicalImpression.summary",
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
                // 18. ClinicalImpression.finding
                this.Element_Finding = new ElementDefinitionInfo
                {
                    Name = "Element_Finding",
                    Path= "ClinicalImpression.finding",
                    Id = "ClinicalImpression.finding",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Finding
                        {
                        }
                    }
                };
            }
            {
                // 22. ClinicalImpression.prognosisCodeableConcept
                this.Element_PrognosisCodeableConcept = new ElementDefinitionInfo
                {
                    Name = "Element_PrognosisCodeableConcept",
                    Path= "ClinicalImpression.prognosisCodeableConcept",
                    Id = "ClinicalImpression.prognosisCodeableConcept",
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
                // 23. ClinicalImpression.prognosisReference
                this.Element_PrognosisReference = new ElementDefinitionInfo
                {
                    Name = "Element_PrognosisReference",
                    Path= "ClinicalImpression.prognosisReference",
                    Id = "ClinicalImpression.prognosisReference",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/RiskAssessment"
                            }
                        }
                    }
                };
            }
            {
                // 24. ClinicalImpression.supportingInfo
                this.Element_SupportingInfo = new ElementDefinitionInfo
                {
                    Name = "Element_SupportingInfo",
                    Path= "ClinicalImpression.supportingInfo",
                    Id = "ClinicalImpression.supportingInfo",
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
            {
                // 25. ClinicalImpression.note
                this.Element_Note = new ElementDefinitionInfo
                {
                    Name = "Element_Note",
                    Path= "ClinicalImpression.note",
                    Id = "ClinicalImpression.note",
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
            this.Name = "ClinicalImpression";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/ClinicalImpression";
        }
    }
}
