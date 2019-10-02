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
      "id": "MedicinalProductContraindication",
      "url": "http://hl7.org/fhir/StructureDefinition/MedicinalProductContraindication",
      "version": "4.0.0",
      "name": "MedicinalProductContraindication",
      "status": "draft",
      "publisher": "Health Level Seven International (Biomedical Research and Regulation)",
      "description": "The clinical particulars - indications, contraindications etc. of a medicinal product, including for regulatory purposes.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "MedicinalProductContraindication",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "MedicinalProductContraindication",
            "path": "MedicinalProductContraindication",
            "short": "MedicinalProductContraindication",
            "definition": "The clinical particulars - indications, contraindications etc. of a medicinal product, including for regulatory purposes.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "MedicinalProductContraindication.subject",
            "path": "MedicinalProductContraindication.subject",
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
            "id": "MedicinalProductContraindication.disease",
            "path": "MedicinalProductContraindication.disease",
            "short": "The disease, symptom or procedure for the contraindication",
            "definition": "The disease, symptom or procedure for the contraindication.",
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
            "id": "MedicinalProductContraindication.diseaseStatus",
            "path": "MedicinalProductContraindication.diseaseStatus",
            "short": "The status of the disease or symptom for the contraindication",
            "definition": "The status of the disease or symptom for the contraindication.",
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
            "id": "MedicinalProductContraindication.comorbidity",
            "path": "MedicinalProductContraindication.comorbidity",
            "short": "A comorbidity (concurrent condition) or coinfection",
            "definition": "A comorbidity (concurrent condition) or coinfection.",
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
            "id": "MedicinalProductContraindication.therapeuticIndication",
            "path": "MedicinalProductContraindication.therapeuticIndication",
            "short": "Information about the use of the medicinal product in relation to other therapies as part of the indication",
            "definition": "Information about the use of the medicinal product in relation to other therapies as part of the indication.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/MedicinalProductIndication"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductContraindication.otherTherapy",
            "path": "MedicinalProductContraindication.otherTherapy",
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
            "id": "MedicinalProductContraindication.otherTherapy.therapyRelationshipType",
            "path": "MedicinalProductContraindication.otherTherapy.therapyRelationshipType",
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
            "id": "MedicinalProductContraindication.otherTherapy.medication[x]",
            "path": "MedicinalProductContraindication.otherTherapy.medication[x]",
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
            "id": "MedicinalProductContraindication.population",
            "path": "MedicinalProductContraindication.population",
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
    /// Fhir resource 'MedicinalProductContraindication'
    /// </summary>
    // 0. MedicinalProductContraindication
    public partial class Resource_MedicinalProductContraindication : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 6. MedicinalProductContraindication.otherTherapy
        public partial class Type_OtherTherapy : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 7. MedicinalProductContraindication.otherTherapy.therapyRelationshipType
            public ElementDefinitionInfo Element_TherapyRelationshipType;
            // 8. MedicinalProductContraindication.otherTherapy.medication[x]
            public ElementDefinitionInfo Element_Medication;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "MedicinalProductContraindication.otherTherapy",
                    ElementId = "MedicinalProductContraindication.otherTherapy"
                });
                Element_TherapyRelationshipType.Write(sDef);
                Element_Medication.Write(sDef);
            }
            
            public Type_OtherTherapy()
            {
                {
                    // 7. MedicinalProductContraindication.otherTherapy.therapyRelationshipType
                    this.Element_TherapyRelationshipType = new ElementDefinitionInfo
                    {
                        Name = "Element_TherapyRelationshipType",
                        Path= "MedicinalProductContraindication.otherTherapy.therapyRelationshipType",
                        Id = "MedicinalProductContraindication.otherTherapy.therapyRelationshipType",
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
                    // 8. MedicinalProductContraindication.otherTherapy.medication[x]
                    this.Element_Medication = new ElementDefinitionInfo
                    {
                        Name = "Element_Medication",
                        Path= "MedicinalProductContraindication.otherTherapy.medication[x]",
                        Id = "MedicinalProductContraindication.otherTherapy.medication[x]",
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
        // 1. MedicinalProductContraindication.subject
        public ElementDefinitionInfo Element_Subject;
        // 2. MedicinalProductContraindication.disease
        public ElementDefinitionInfo Element_Disease;
        // 3. MedicinalProductContraindication.diseaseStatus
        public ElementDefinitionInfo Element_DiseaseStatus;
        // 4. MedicinalProductContraindication.comorbidity
        public ElementDefinitionInfo Element_Comorbidity;
        // 5. MedicinalProductContraindication.therapeuticIndication
        public ElementDefinitionInfo Element_TherapeuticIndication;
        // 6. MedicinalProductContraindication.otherTherapy
        public ElementDefinitionInfo Element_OtherTherapy;
        // 9. MedicinalProductContraindication.population
        public ElementDefinitionInfo Element_Population;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "MedicinalProductContraindication",
                ElementId = "MedicinalProductContraindication"
            });
            Element_Subject.Write(sDef);
            Element_Disease.Write(sDef);
            Element_DiseaseStatus.Write(sDef);
            Element_Comorbidity.Write(sDef);
            Element_TherapeuticIndication.Write(sDef);
            Element_OtherTherapy.Write(sDef);
            Element_Population.Write(sDef);
        }
        
        public Resource_MedicinalProductContraindication()
        {
            {
                // 1. MedicinalProductContraindication.subject
                this.Element_Subject = new ElementDefinitionInfo
                {
                    Name = "Element_Subject",
                    Path= "MedicinalProductContraindication.subject",
                    Id = "MedicinalProductContraindication.subject",
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
                // 2. MedicinalProductContraindication.disease
                this.Element_Disease = new ElementDefinitionInfo
                {
                    Name = "Element_Disease",
                    Path= "MedicinalProductContraindication.disease",
                    Id = "MedicinalProductContraindication.disease",
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
                // 3. MedicinalProductContraindication.diseaseStatus
                this.Element_DiseaseStatus = new ElementDefinitionInfo
                {
                    Name = "Element_DiseaseStatus",
                    Path= "MedicinalProductContraindication.diseaseStatus",
                    Id = "MedicinalProductContraindication.diseaseStatus",
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
                // 4. MedicinalProductContraindication.comorbidity
                this.Element_Comorbidity = new ElementDefinitionInfo
                {
                    Name = "Element_Comorbidity",
                    Path= "MedicinalProductContraindication.comorbidity",
                    Id = "MedicinalProductContraindication.comorbidity",
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
                // 5. MedicinalProductContraindication.therapeuticIndication
                this.Element_TherapeuticIndication = new ElementDefinitionInfo
                {
                    Name = "Element_TherapeuticIndication",
                    Path= "MedicinalProductContraindication.therapeuticIndication",
                    Id = "MedicinalProductContraindication.therapeuticIndication",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/MedicinalProductIndication"
                            }
                        }
                    }
                };
            }
            {
                // 6. MedicinalProductContraindication.otherTherapy
                this.Element_OtherTherapy = new ElementDefinitionInfo
                {
                    Name = "Element_OtherTherapy",
                    Path= "MedicinalProductContraindication.otherTherapy",
                    Id = "MedicinalProductContraindication.otherTherapy",
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
                // 9. MedicinalProductContraindication.population
                this.Element_Population = new ElementDefinitionInfo
                {
                    Name = "Element_Population",
                    Path= "MedicinalProductContraindication.population",
                    Id = "MedicinalProductContraindication.population",
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
            this.Name = "MedicinalProductContraindication";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MedicinalProductContraindication";
        }
    }
}
