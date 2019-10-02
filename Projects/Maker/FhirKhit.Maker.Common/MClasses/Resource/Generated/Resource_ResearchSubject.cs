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
      "id": "ResearchSubject",
      "url": "http://hl7.org/fhir/StructureDefinition/ResearchSubject",
      "version": "4.0.0",
      "name": "ResearchSubject",
      "status": "draft",
      "publisher": "Health Level Seven International (Biomedical Research and Regulation)",
      "description": "A physical entity which is the primary unit of operational and/or administrative interest in a study.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "ResearchSubject",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "ResearchSubject",
            "path": "ResearchSubject",
            "short": "Physical entity which is the primary unit of interest in the study",
            "definition": "A physical entity which is the primary unit of operational and/or administrative interest in a study.",
            "comment": "Need to make sure we encompass public health studies.",
            "alias": [
              "Study Subject"
            ],
            "min": 0,
            "max": "*"
          },
          {
            "id": "ResearchSubject.identifier",
            "path": "ResearchSubject.identifier",
            "short": "Business Identifier for research subject in a study",
            "definition": "Identifiers assigned to this research subject for a study.",
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
            "id": "ResearchSubject.status",
            "path": "ResearchSubject.status",
            "short": "candidate | eligible | follow-up | ineligible | not-registered | off-study | on-study | on-study-intervention | on-study-observation | pending-on-study | potential-candidate | screening | withdrawn",
            "definition": "The current state of the subject.",
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
                  "valueString": "ResearchSubjectStatus"
                }
              ],
              "strength": "required",
              "description": "Indicates the progression of a study subject through a study.",
              "valueSet": "http://hl7.org/fhir/ValueSet/research-subject-status|4.0.0"
            }
          },
          {
            "id": "ResearchSubject.period",
            "path": "ResearchSubject.period",
            "short": "Start and end of participation",
            "definition": "The dates the subject began and ended their participation in the study.",
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
            "id": "ResearchSubject.study",
            "path": "ResearchSubject.study",
            "short": "Study subject is part of",
            "definition": "Reference to the study the subject is participating in.",
            "min": 1,
            "max": "1",
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
            "id": "ResearchSubject.individual",
            "path": "ResearchSubject.individual",
            "short": "Who is part of study",
            "definition": "The record of the person or animal who is involved in the study.",
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
            "id": "ResearchSubject.assignedArm",
            "path": "ResearchSubject.assignedArm",
            "short": "What path should be followed",
            "definition": "The name of the arm in the study the subject is expected to follow as part of this study.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ResearchSubject.actualArm",
            "path": "ResearchSubject.actualArm",
            "short": "What path was followed",
            "definition": "The name of the arm in the study the subject actually followed as part of this study.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ResearchSubject.consent",
            "path": "ResearchSubject.consent",
            "short": "Agreement to participate in study",
            "definition": "A record of the patient's informed agreement to participate in the study.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Consent"
                ]
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir resource 'ResearchSubject'
    /// </summary>
    // 0. ResearchSubject
    public class Resource_ResearchSubject : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 1. ResearchSubject.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. ResearchSubject.status
        public ElementDefinitionInfo Element_Status;
        // 3. ResearchSubject.period
        public ElementDefinitionInfo Element_Period;
        // 4. ResearchSubject.study
        public ElementDefinitionInfo Element_Study;
        // 5. ResearchSubject.individual
        public ElementDefinitionInfo Element_Individual;
        // 6. ResearchSubject.assignedArm
        public ElementDefinitionInfo Element_AssignedArm;
        // 7. ResearchSubject.actualArm
        public ElementDefinitionInfo Element_ActualArm;
        // 8. ResearchSubject.consent
        public ElementDefinitionInfo Element_Consent;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "ResearchSubject",
                ElementId = "ResearchSubject"
            });
            Element_Identifier.Write(sDef);
            Element_Status.Write(sDef);
            Element_Period.Write(sDef);
            Element_Study.Write(sDef);
            Element_Individual.Write(sDef);
            Element_AssignedArm.Write(sDef);
            Element_ActualArm.Write(sDef);
            Element_Consent.Write(sDef);
        }
        
        public Resource_ResearchSubject()
        {
            {
                // 1. ResearchSubject.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "ResearchSubject.identifier",
                    Id = "ResearchSubject.identifier",
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
                // 2. ResearchSubject.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "ResearchSubject.status",
                    Id = "ResearchSubject.status",
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
                // 3. ResearchSubject.period
                this.Element_Period = new ElementDefinitionInfo
                {
                    Name = "Element_Period",
                    Path= "ResearchSubject.period",
                    Id = "ResearchSubject.period",
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
                // 4. ResearchSubject.study
                this.Element_Study = new ElementDefinitionInfo
                {
                    Name = "Element_Study",
                    Path= "ResearchSubject.study",
                    Id = "ResearchSubject.study",
                    Min = 1,
                    Max = 1,
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
                // 5. ResearchSubject.individual
                this.Element_Individual = new ElementDefinitionInfo
                {
                    Name = "Element_Individual",
                    Path= "ResearchSubject.individual",
                    Id = "ResearchSubject.individual",
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
                // 6. ResearchSubject.assignedArm
                this.Element_AssignedArm = new ElementDefinitionInfo
                {
                    Name = "Element_AssignedArm",
                    Path= "ResearchSubject.assignedArm",
                    Id = "ResearchSubject.assignedArm",
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
                // 7. ResearchSubject.actualArm
                this.Element_ActualArm = new ElementDefinitionInfo
                {
                    Name = "Element_ActualArm",
                    Path= "ResearchSubject.actualArm",
                    Id = "ResearchSubject.actualArm",
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
                // 8. ResearchSubject.consent
                this.Element_Consent = new ElementDefinitionInfo
                {
                    Name = "Element_Consent",
                    Path= "ResearchSubject.consent",
                    Id = "ResearchSubject.consent",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Consent"
                            }
                        }
                    }
                };
            }
            this.Name = "ResearchSubject";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/ResearchSubject";
        }
    }
}
