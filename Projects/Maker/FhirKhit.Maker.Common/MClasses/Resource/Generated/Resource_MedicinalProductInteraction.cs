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
      "id": "MedicinalProductInteraction",
      "url": "http://hl7.org/fhir/StructureDefinition/MedicinalProductInteraction",
      "version": "4.0.0",
      "name": "MedicinalProductInteraction",
      "status": "draft",
      "publisher": "Health Level Seven International (Biomedical Research and Regulation)",
      "description": "The interactions of the medicinal product with other medicinal products, or other forms of interactions.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "MedicinalProductInteraction",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "MedicinalProductInteraction",
            "path": "MedicinalProductInteraction",
            "short": "MedicinalProductInteraction",
            "definition": "The interactions of the medicinal product with other medicinal products, or other forms of interactions.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "MedicinalProductInteraction.subject",
            "path": "MedicinalProductInteraction.subject",
            "short": "The medication for which this is a described interaction",
            "definition": "The medication for which this is a described interaction.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/MedicinalProduct",
                  "http://hl7.org/fhir/StructureDefinition/Medication",
                  "http://hl7.org/fhir/StructureDefinition/Substance"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductInteraction.description",
            "path": "MedicinalProductInteraction.description",
            "short": "The interaction described",
            "definition": "The interaction described.",
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
            "id": "MedicinalProductInteraction.interactant",
            "path": "MedicinalProductInteraction.interactant",
            "short": "The specific medication, food or laboratory test that interacts",
            "definition": "The specific medication, food or laboratory test that interacts.",
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
            "id": "MedicinalProductInteraction.interactant.item[x]",
            "path": "MedicinalProductInteraction.interactant.item[x]",
            "short": "The specific medication, food or laboratory test that interacts",
            "definition": "The specific medication, food or laboratory test that interacts.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/MedicinalProduct",
                  "http://hl7.org/fhir/StructureDefinition/Medication",
                  "http://hl7.org/fhir/StructureDefinition/Substance",
                  "http://hl7.org/fhir/StructureDefinition/ObservationDefinition"
                ]
              },
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductInteraction.type",
            "path": "MedicinalProductInteraction.type",
            "short": "The type of the interaction e.g. drug-drug interaction, drug-food interaction, drug-lab test interaction",
            "definition": "The type of the interaction e.g. drug-drug interaction, drug-food interaction, drug-lab test interaction.",
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
            "id": "MedicinalProductInteraction.effect",
            "path": "MedicinalProductInteraction.effect",
            "short": "The effect of the interaction, for example \"reduced gastric absorption of primary medication\"",
            "definition": "The effect of the interaction, for example \"reduced gastric absorption of primary medication\".",
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
            "id": "MedicinalProductInteraction.incidence",
            "path": "MedicinalProductInteraction.incidence",
            "short": "The incidence of the interaction, e.g. theoretical, observed",
            "definition": "The incidence of the interaction, e.g. theoretical, observed.",
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
            "id": "MedicinalProductInteraction.management",
            "path": "MedicinalProductInteraction.management",
            "short": "Actions for managing the interaction",
            "definition": "Actions for managing the interaction.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
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
    /// Fhir resource 'MedicinalProductInteraction'
    /// </summary>
    // 0. MedicinalProductInteraction
    public partial class Resource_MedicinalProductInteraction : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 3. MedicinalProductInteraction.interactant
        public partial class Type_Interactant : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 4. MedicinalProductInteraction.interactant.item[x]
            public ElementDefinitionInfo Element_Item;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "MedicinalProductInteraction.interactant",
                    ElementId = "MedicinalProductInteraction.interactant"
                });
                Element_Item.Write(sDef);
            }
            
            public Type_Interactant()
            {
                {
                    // 4. MedicinalProductInteraction.interactant.item[x]
                    this.Element_Item = new ElementDefinitionInfo
                    {
                        Name = "Element_Item",
                        Path= "MedicinalProductInteraction.interactant.item[x]",
                        Id = "MedicinalProductInteraction.interactant.item[x]",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/MedicinalProduct",
                                    "http://hl7.org/fhir/StructureDefinition/Medication",
                                    "http://hl7.org/fhir/StructureDefinition/Substance",
                                    "http://hl7.org/fhir/StructureDefinition/ObservationDefinition"
                                }
                            },
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                            {
                            }
                        }
                    };
                }
            }
        }
        // 1. MedicinalProductInteraction.subject
        public ElementDefinitionInfo Element_Subject;
        // 2. MedicinalProductInteraction.description
        public ElementDefinitionInfo Element_Description;
        // 3. MedicinalProductInteraction.interactant
        public ElementDefinitionInfo Element_Interactant;
        // 5. MedicinalProductInteraction.type
        public ElementDefinitionInfo Element_Type;
        // 6. MedicinalProductInteraction.effect
        public ElementDefinitionInfo Element_Effect;
        // 7. MedicinalProductInteraction.incidence
        public ElementDefinitionInfo Element_Incidence;
        // 8. MedicinalProductInteraction.management
        public ElementDefinitionInfo Element_Management;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "MedicinalProductInteraction",
                ElementId = "MedicinalProductInteraction"
            });
            Element_Subject.Write(sDef);
            Element_Description.Write(sDef);
            Element_Interactant.Write(sDef);
            Element_Type.Write(sDef);
            Element_Effect.Write(sDef);
            Element_Incidence.Write(sDef);
            Element_Management.Write(sDef);
        }
        
        public Resource_MedicinalProductInteraction()
        {
            {
                // 1. MedicinalProductInteraction.subject
                this.Element_Subject = new ElementDefinitionInfo
                {
                    Name = "Element_Subject",
                    Path= "MedicinalProductInteraction.subject",
                    Id = "MedicinalProductInteraction.subject",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/MedicinalProduct",
                                "http://hl7.org/fhir/StructureDefinition/Medication",
                                "http://hl7.org/fhir/StructureDefinition/Substance"
                            }
                        }
                    }
                };
            }
            {
                // 2. MedicinalProductInteraction.description
                this.Element_Description = new ElementDefinitionInfo
                {
                    Name = "Element_Description",
                    Path= "MedicinalProductInteraction.description",
                    Id = "MedicinalProductInteraction.description",
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
                // 3. MedicinalProductInteraction.interactant
                this.Element_Interactant = new ElementDefinitionInfo
                {
                    Name = "Element_Interactant",
                    Path= "MedicinalProductInteraction.interactant",
                    Id = "MedicinalProductInteraction.interactant",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Interactant
                        {
                        }
                    }
                };
            }
            {
                // 5. MedicinalProductInteraction.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "MedicinalProductInteraction.type",
                    Id = "MedicinalProductInteraction.type",
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
                // 6. MedicinalProductInteraction.effect
                this.Element_Effect = new ElementDefinitionInfo
                {
                    Name = "Element_Effect",
                    Path= "MedicinalProductInteraction.effect",
                    Id = "MedicinalProductInteraction.effect",
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
                // 7. MedicinalProductInteraction.incidence
                this.Element_Incidence = new ElementDefinitionInfo
                {
                    Name = "Element_Incidence",
                    Path= "MedicinalProductInteraction.incidence",
                    Id = "MedicinalProductInteraction.incidence",
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
                // 8. MedicinalProductInteraction.management
                this.Element_Management = new ElementDefinitionInfo
                {
                    Name = "Element_Management",
                    Path= "MedicinalProductInteraction.management",
                    Id = "MedicinalProductInteraction.management",
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
            this.Name = "MedicinalProductInteraction";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MedicinalProductInteraction";
        }
    }
}
