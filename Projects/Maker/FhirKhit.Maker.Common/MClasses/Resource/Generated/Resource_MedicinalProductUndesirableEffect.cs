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
      "id": "MedicinalProductUndesirableEffect",
      "url": "http://hl7.org/fhir/StructureDefinition/MedicinalProductUndesirableEffect",
      "version": "4.0.0",
      "name": "MedicinalProductUndesirableEffect",
      "status": "draft",
      "publisher": "Health Level Seven International (Biomedical Research and Regulation)",
      "description": "Describe the undesirable effects of the medicinal product.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "MedicinalProductUndesirableEffect",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "MedicinalProductUndesirableEffect",
            "path": "MedicinalProductUndesirableEffect",
            "short": "MedicinalProductUndesirableEffect",
            "definition": "Describe the undesirable effects of the medicinal product.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "MedicinalProductUndesirableEffect.subject",
            "path": "MedicinalProductUndesirableEffect.subject",
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
            "id": "MedicinalProductUndesirableEffect.symptomConditionEffect",
            "path": "MedicinalProductUndesirableEffect.symptomConditionEffect",
            "short": "The symptom, condition or undesirable effect",
            "definition": "The symptom, condition or undesirable effect.",
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
            "id": "MedicinalProductUndesirableEffect.classification",
            "path": "MedicinalProductUndesirableEffect.classification",
            "short": "Classification of the effect",
            "definition": "Classification of the effect.",
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
            "id": "MedicinalProductUndesirableEffect.frequencyOfOccurrence",
            "path": "MedicinalProductUndesirableEffect.frequencyOfOccurrence",
            "short": "The frequency of occurrence of the effect",
            "definition": "The frequency of occurrence of the effect.",
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
            "id": "MedicinalProductUndesirableEffect.population",
            "path": "MedicinalProductUndesirableEffect.population",
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
    /// Fhir resource 'MedicinalProductUndesirableEffect'
    /// </summary>
    // 0. MedicinalProductUndesirableEffect
    public partial class Resource_MedicinalProductUndesirableEffect : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 1. MedicinalProductUndesirableEffect.subject
        public ElementDefinitionInfo Element_Subject;
        // 2. MedicinalProductUndesirableEffect.symptomConditionEffect
        public ElementDefinitionInfo Element_SymptomConditionEffect;
        // 3. MedicinalProductUndesirableEffect.classification
        public ElementDefinitionInfo Element_Classification;
        // 4. MedicinalProductUndesirableEffect.frequencyOfOccurrence
        public ElementDefinitionInfo Element_FrequencyOfOccurrence;
        // 5. MedicinalProductUndesirableEffect.population
        public ElementDefinitionInfo Element_Population;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "MedicinalProductUndesirableEffect",
                ElementId = "MedicinalProductUndesirableEffect"
            });
            Element_Subject.Write(sDef);
            Element_SymptomConditionEffect.Write(sDef);
            Element_Classification.Write(sDef);
            Element_FrequencyOfOccurrence.Write(sDef);
            Element_Population.Write(sDef);
        }
        
        public Resource_MedicinalProductUndesirableEffect()
        {
            {
                // 1. MedicinalProductUndesirableEffect.subject
                this.Element_Subject = new ElementDefinitionInfo
                {
                    Name = "Element_Subject",
                    Path= "MedicinalProductUndesirableEffect.subject",
                    Id = "MedicinalProductUndesirableEffect.subject",
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
                // 2. MedicinalProductUndesirableEffect.symptomConditionEffect
                this.Element_SymptomConditionEffect = new ElementDefinitionInfo
                {
                    Name = "Element_SymptomConditionEffect",
                    Path= "MedicinalProductUndesirableEffect.symptomConditionEffect",
                    Id = "MedicinalProductUndesirableEffect.symptomConditionEffect",
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
                // 3. MedicinalProductUndesirableEffect.classification
                this.Element_Classification = new ElementDefinitionInfo
                {
                    Name = "Element_Classification",
                    Path= "MedicinalProductUndesirableEffect.classification",
                    Id = "MedicinalProductUndesirableEffect.classification",
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
                // 4. MedicinalProductUndesirableEffect.frequencyOfOccurrence
                this.Element_FrequencyOfOccurrence = new ElementDefinitionInfo
                {
                    Name = "Element_FrequencyOfOccurrence",
                    Path= "MedicinalProductUndesirableEffect.frequencyOfOccurrence",
                    Id = "MedicinalProductUndesirableEffect.frequencyOfOccurrence",
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
                // 5. MedicinalProductUndesirableEffect.population
                this.Element_Population = new ElementDefinitionInfo
                {
                    Name = "Element_Population",
                    Path= "MedicinalProductUndesirableEffect.population",
                    Id = "MedicinalProductUndesirableEffect.population",
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
            this.Name = "MedicinalProductUndesirableEffect";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MedicinalProductUndesirableEffect";
        }
    }
}
