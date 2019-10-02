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
    #endregion
    /// <summary>
    /// Fhir resource 'ImmunizationEvaluation'
    /// </summary>
    // 0. ImmunizationEvaluation
    public class Resource_ImmunizationEvaluation : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 1. ImmunizationEvaluation.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. ImmunizationEvaluation.status
        public ElementDefinitionInfo Element_Status;
        // 3. ImmunizationEvaluation.patient
        public ElementDefinitionInfo Element_Patient;
        // 4. ImmunizationEvaluation.date
        public ElementDefinitionInfo Element_Date;
        // 5. ImmunizationEvaluation.authority
        public ElementDefinitionInfo Element_Authority;
        // 6. ImmunizationEvaluation.targetDisease
        public ElementDefinitionInfo Element_TargetDisease;
        // 7. ImmunizationEvaluation.immunizationEvent
        public ElementDefinitionInfo Element_ImmunizationEvent;
        // 8. ImmunizationEvaluation.doseStatus
        public ElementDefinitionInfo Element_DoseStatus;
        // 9. ImmunizationEvaluation.doseStatusReason
        public ElementDefinitionInfo Element_DoseStatusReason;
        // 10. ImmunizationEvaluation.description
        public ElementDefinitionInfo Element_Description;
        // 11. ImmunizationEvaluation.series
        public ElementDefinitionInfo Element_Series;
        // 12. ImmunizationEvaluation.doseNumber[x]
        public ElementDefinitionInfo Element_DoseNumber;
        // 13. ImmunizationEvaluation.seriesDoses[x]
        public ElementDefinitionInfo Element_SeriesDoses;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "ImmunizationEvaluation",
                ElementId = "ImmunizationEvaluation"
            });
            Element_Identifier.Write(sDef);
            Element_Status.Write(sDef);
            Element_Patient.Write(sDef);
            Element_Date.Write(sDef);
            Element_Authority.Write(sDef);
            Element_TargetDisease.Write(sDef);
            Element_ImmunizationEvent.Write(sDef);
            Element_DoseStatus.Write(sDef);
            Element_DoseStatusReason.Write(sDef);
            Element_Description.Write(sDef);
            Element_Series.Write(sDef);
            Element_DoseNumber.Write(sDef);
            Element_SeriesDoses.Write(sDef);
        }
        
        public Resource_ImmunizationEvaluation()
        {
            {
                // 1. ImmunizationEvaluation.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "ImmunizationEvaluation.identifier",
                    Id = "ImmunizationEvaluation.identifier",
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
                // 2. ImmunizationEvaluation.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "ImmunizationEvaluation.status",
                    Id = "ImmunizationEvaluation.status",
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
                // 3. ImmunizationEvaluation.patient
                this.Element_Patient = new ElementDefinitionInfo
                {
                    Name = "Element_Patient",
                    Path= "ImmunizationEvaluation.patient",
                    Id = "ImmunizationEvaluation.patient",
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
                // 4. ImmunizationEvaluation.date
                this.Element_Date = new ElementDefinitionInfo
                {
                    Name = "Element_Date",
                    Path= "ImmunizationEvaluation.date",
                    Id = "ImmunizationEvaluation.date",
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
                // 5. ImmunizationEvaluation.authority
                this.Element_Authority = new ElementDefinitionInfo
                {
                    Name = "Element_Authority",
                    Path= "ImmunizationEvaluation.authority",
                    Id = "ImmunizationEvaluation.authority",
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
                // 6. ImmunizationEvaluation.targetDisease
                this.Element_TargetDisease = new ElementDefinitionInfo
                {
                    Name = "Element_TargetDisease",
                    Path= "ImmunizationEvaluation.targetDisease",
                    Id = "ImmunizationEvaluation.targetDisease",
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
                // 7. ImmunizationEvaluation.immunizationEvent
                this.Element_ImmunizationEvent = new ElementDefinitionInfo
                {
                    Name = "Element_ImmunizationEvent",
                    Path= "ImmunizationEvaluation.immunizationEvent",
                    Id = "ImmunizationEvaluation.immunizationEvent",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Immunization"
                            }
                        }
                    }
                };
            }
            {
                // 8. ImmunizationEvaluation.doseStatus
                this.Element_DoseStatus = new ElementDefinitionInfo
                {
                    Name = "Element_DoseStatus",
                    Path= "ImmunizationEvaluation.doseStatus",
                    Id = "ImmunizationEvaluation.doseStatus",
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
                // 9. ImmunizationEvaluation.doseStatusReason
                this.Element_DoseStatusReason = new ElementDefinitionInfo
                {
                    Name = "Element_DoseStatusReason",
                    Path= "ImmunizationEvaluation.doseStatusReason",
                    Id = "ImmunizationEvaluation.doseStatusReason",
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
                // 10. ImmunizationEvaluation.description
                this.Element_Description = new ElementDefinitionInfo
                {
                    Name = "Element_Description",
                    Path= "ImmunizationEvaluation.description",
                    Id = "ImmunizationEvaluation.description",
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
                // 11. ImmunizationEvaluation.series
                this.Element_Series = new ElementDefinitionInfo
                {
                    Name = "Element_Series",
                    Path= "ImmunizationEvaluation.series",
                    Id = "ImmunizationEvaluation.series",
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
                // 12. ImmunizationEvaluation.doseNumber[x]
                this.Element_DoseNumber = new ElementDefinitionInfo
                {
                    Name = "Element_DoseNumber",
                    Path= "ImmunizationEvaluation.doseNumber[x]",
                    Id = "ImmunizationEvaluation.doseNumber[x]",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_String
                        {
                        }
                    }
                };
            }
            {
                // 13. ImmunizationEvaluation.seriesDoses[x]
                this.Element_SeriesDoses = new ElementDefinitionInfo
                {
                    Name = "Element_SeriesDoses",
                    Path= "ImmunizationEvaluation.seriesDoses[x]",
                    Id = "ImmunizationEvaluation.seriesDoses[x]",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_String
                        {
                        }
                    }
                };
            }
            this.Name = "ImmunizationEvaluation";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/ImmunizationEvaluation";
        }
    }
}
