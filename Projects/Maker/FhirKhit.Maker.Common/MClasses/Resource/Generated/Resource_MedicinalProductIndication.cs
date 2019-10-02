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
      "id": "MedicinalProductIndication",
      "url": "http://hl7.org/fhir/StructureDefinition/MedicinalProductIndication",
      "version": "4.0.0",
      "name": "MedicinalProductIndication",
      "status": "draft",
      "publisher": "Health Level Seven International (Biomedical Research and Regulation)",
      "description": "Indication for the Medicinal Product.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "MedicinalProductIndication",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "MedicinalProductIndication",
            "path": "MedicinalProductIndication",
            "short": "MedicinalProductIndication",
            "definition": "Indication for the Medicinal Product.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "MedicinalProductIndication.subject",
            "path": "MedicinalProductIndication.subject",
            "short": "The medication for which this is an indication",
            "definition": "The medication for which this is an indication.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/MedicinalProduct",
                  "http://hl7.org/fhir/StructureDefinition/Medication"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductIndication.diseaseSymptomProcedure",
            "path": "MedicinalProductIndication.diseaseSymptomProcedure",
            "short": "The disease, symptom or procedure that is the indication for treatment",
            "definition": "The disease, symptom or procedure that is the indication for treatment.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductIndication.diseaseStatus",
            "path": "MedicinalProductIndication.diseaseStatus",
            "short": "The status of the disease or symptom for which the indication applies",
            "definition": "The status of the disease or symptom for which the indication applies.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductIndication.comorbidity",
            "path": "MedicinalProductIndication.comorbidity",
            "short": "Comorbidity (concurrent condition) or co-infection as part of the indication",
            "definition": "Comorbidity (concurrent condition) or co-infection as part of the indication.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductIndication.intendedEffect",
            "path": "MedicinalProductIndication.intendedEffect",
            "short": "The intended effect, aim or strategy to be achieved by the indication",
            "definition": "The intended effect, aim or strategy to be achieved by the indication.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductIndication.duration",
            "path": "MedicinalProductIndication.duration",
            "short": "Timing or duration information as part of the indication",
            "definition": "Timing or duration information as part of the indication.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductIndication.otherTherapy",
            "path": "MedicinalProductIndication.otherTherapy",
            "short": "Information about the use of the medicinal product in relation to other therapies described as part of the indication",
            "definition": "Information about the use of the medicinal product in relation to other therapies described as part of the indication.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductIndication.otherTherapy.therapyRelationshipType",
            "path": "MedicinalProductIndication.otherTherapy.therapyRelationshipType",
            "short": "The type of relationship between the medicinal product indication or contraindication and another therapy",
            "definition": "The type of relationship between the medicinal product indication or contraindication and another therapy.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductIndication.otherTherapy.medication[x]",
            "path": "MedicinalProductIndication.otherTherapy.medication[x]",
            "short": "Reference to a specific medication (active substance, medicinal product or class of products) as part of an indication or contraindication",
            "definition": "Reference to a specific medication (active substance, medicinal product or class of products) as part of an indication or contraindication.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/MedicinalProduct",
                  "http://hl7.org/fhir/StructureDefinition/Medication",
                  "http://hl7.org/fhir/StructureDefinition/Substance",
                  "http://hl7.org/fhir/StructureDefinition/SubstanceSpecification"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductIndication.undesirableEffect",
            "path": "MedicinalProductIndication.undesirableEffect",
            "short": "Describe the undesirable effects of the medicinal product",
            "definition": "Describe the undesirable effects of the medicinal product.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/MedicinalProductUndesirableEffect"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductIndication.population",
            "path": "MedicinalProductIndication.population",
            "short": "The population group to which this applies",
            "definition": "The population group to which this applies.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Population"
              }
            ],
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir resource 'MedicinalProductIndication'
    /// </summary>
    // 0. MedicinalProductIndication
    public partial class Resource_MedicinalProductIndication : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 7. MedicinalProductIndication.otherTherapy
        public partial class Type_OtherTherapy : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 8. MedicinalProductIndication.otherTherapy.therapyRelationshipType
            public ElementDefinitionInfo Element_TherapyRelationshipType;
            // 9. MedicinalProductIndication.otherTherapy.medication[x]
            public ElementDefinitionInfo Element_Medication;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "MedicinalProductIndication.otherTherapy",
                    ElementId = "MedicinalProductIndication.otherTherapy"
                });
                Element_TherapyRelationshipType.Write(sDef);
                Element_Medication.Write(sDef);
            }
            
            public Type_OtherTherapy()
            {
                {
                    // 8. MedicinalProductIndication.otherTherapy.therapyRelationshipType
                    this.Element_TherapyRelationshipType = new ElementDefinitionInfo
                    {
                        Name = "Element_TherapyRelationshipType",
                        Path= "MedicinalProductIndication.otherTherapy.therapyRelationshipType",
                        Id = "MedicinalProductIndication.otherTherapy.therapyRelationshipType",
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
                    // 9. MedicinalProductIndication.otherTherapy.medication[x]
                    this.Element_Medication = new ElementDefinitionInfo
                    {
                        Name = "Element_Medication",
                        Path= "MedicinalProductIndication.otherTherapy.medication[x]",
                        Id = "MedicinalProductIndication.otherTherapy.medication[x]",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/MedicinalProduct",
                                    "http://hl7.org/fhir/StructureDefinition/Medication",
                                    "http://hl7.org/fhir/StructureDefinition/Substance",
                                    "http://hl7.org/fhir/StructureDefinition/SubstanceSpecification"
                                }
                            }
                        }
                    };
                }
            }
        }
        // 1. MedicinalProductIndication.subject
        public ElementDefinitionInfo Element_Subject;
        // 2. MedicinalProductIndication.diseaseSymptomProcedure
        public ElementDefinitionInfo Element_DiseaseSymptomProcedure;
        // 3. MedicinalProductIndication.diseaseStatus
        public ElementDefinitionInfo Element_DiseaseStatus;
        // 4. MedicinalProductIndication.comorbidity
        public ElementDefinitionInfo Element_Comorbidity;
        // 5. MedicinalProductIndication.intendedEffect
        public ElementDefinitionInfo Element_IntendedEffect;
        // 6. MedicinalProductIndication.duration
        public ElementDefinitionInfo Element_Duration;
        // 7. MedicinalProductIndication.otherTherapy
        public ElementDefinitionInfo Element_OtherTherapy;
        // 10. MedicinalProductIndication.undesirableEffect
        public ElementDefinitionInfo Element_UndesirableEffect;
        // 11. MedicinalProductIndication.population
        public ElementDefinitionInfo Element_Population;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "MedicinalProductIndication",
                ElementId = "MedicinalProductIndication"
            });
            Element_Subject.Write(sDef);
            Element_DiseaseSymptomProcedure.Write(sDef);
            Element_DiseaseStatus.Write(sDef);
            Element_Comorbidity.Write(sDef);
            Element_IntendedEffect.Write(sDef);
            Element_Duration.Write(sDef);
            Element_OtherTherapy.Write(sDef);
            Element_UndesirableEffect.Write(sDef);
            Element_Population.Write(sDef);
        }
        
        public Resource_MedicinalProductIndication()
        {
            {
                // 1. MedicinalProductIndication.subject
                this.Element_Subject = new ElementDefinitionInfo
                {
                    Name = "Element_Subject",
                    Path= "MedicinalProductIndication.subject",
                    Id = "MedicinalProductIndication.subject",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/MedicinalProduct",
                                "http://hl7.org/fhir/StructureDefinition/Medication"
                            }
                        }
                    }
                };
            }
            {
                // 2. MedicinalProductIndication.diseaseSymptomProcedure
                this.Element_DiseaseSymptomProcedure = new ElementDefinitionInfo
                {
                    Name = "Element_DiseaseSymptomProcedure",
                    Path= "MedicinalProductIndication.diseaseSymptomProcedure",
                    Id = "MedicinalProductIndication.diseaseSymptomProcedure",
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
                // 3. MedicinalProductIndication.diseaseStatus
                this.Element_DiseaseStatus = new ElementDefinitionInfo
                {
                    Name = "Element_DiseaseStatus",
                    Path= "MedicinalProductIndication.diseaseStatus",
                    Id = "MedicinalProductIndication.diseaseStatus",
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
                // 4. MedicinalProductIndication.comorbidity
                this.Element_Comorbidity = new ElementDefinitionInfo
                {
                    Name = "Element_Comorbidity",
                    Path= "MedicinalProductIndication.comorbidity",
                    Id = "MedicinalProductIndication.comorbidity",
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
                // 5. MedicinalProductIndication.intendedEffect
                this.Element_IntendedEffect = new ElementDefinitionInfo
                {
                    Name = "Element_IntendedEffect",
                    Path= "MedicinalProductIndication.intendedEffect",
                    Id = "MedicinalProductIndication.intendedEffect",
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
                // 6. MedicinalProductIndication.duration
                this.Element_Duration = new ElementDefinitionInfo
                {
                    Name = "Element_Duration",
                    Path= "MedicinalProductIndication.duration",
                    Id = "MedicinalProductIndication.duration",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Quantity
                        {
                        }
                    }
                };
            }
            {
                // 7. MedicinalProductIndication.otherTherapy
                this.Element_OtherTherapy = new ElementDefinitionInfo
                {
                    Name = "Element_OtherTherapy",
                    Path= "MedicinalProductIndication.otherTherapy",
                    Id = "MedicinalProductIndication.otherTherapy",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_OtherTherapy
                        {
                        }
                    }
                };
            }
            {
                // 10. MedicinalProductIndication.undesirableEffect
                this.Element_UndesirableEffect = new ElementDefinitionInfo
                {
                    Name = "Element_UndesirableEffect",
                    Path= "MedicinalProductIndication.undesirableEffect",
                    Id = "MedicinalProductIndication.undesirableEffect",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/MedicinalProductUndesirableEffect"
                            }
                        }
                    }
                };
            }
            {
                // 11. MedicinalProductIndication.population
                this.Element_Population = new ElementDefinitionInfo
                {
                    Name = "Element_Population",
                    Path= "MedicinalProductIndication.population",
                    Id = "MedicinalProductIndication.population",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Population
                        {
                        }
                    }
                };
            }
            this.Name = "MedicinalProductIndication";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MedicinalProductIndication";
        }
    }
}
