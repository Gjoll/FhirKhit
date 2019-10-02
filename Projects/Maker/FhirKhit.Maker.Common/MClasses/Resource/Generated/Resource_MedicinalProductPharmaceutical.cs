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
      "id": "MedicinalProductPharmaceutical",
      "url": "http://hl7.org/fhir/StructureDefinition/MedicinalProductPharmaceutical",
      "version": "4.0.0",
      "name": "MedicinalProductPharmaceutical",
      "status": "draft",
      "publisher": "Health Level Seven International (Biomedical Research and Regulation)",
      "description": "A pharmaceutical product described in terms of its composition and dose form.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "MedicinalProductPharmaceutical",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "MedicinalProductPharmaceutical",
            "path": "MedicinalProductPharmaceutical",
            "short": "A pharmaceutical product described in terms of its composition and dose form",
            "definition": "A pharmaceutical product described in terms of its composition and dose form.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "MedicinalProductPharmaceutical.identifier",
            "path": "MedicinalProductPharmaceutical.identifier",
            "short": "An identifier for the pharmaceutical medicinal product",
            "definition": "An identifier for the pharmaceutical medicinal product.",
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
            "id": "MedicinalProductPharmaceutical.administrableDoseForm",
            "path": "MedicinalProductPharmaceutical.administrableDoseForm",
            "short": "The administrable dose form, after necessary reconstitution",
            "definition": "The administrable dose form, after necessary reconstitution.",
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
            "id": "MedicinalProductPharmaceutical.unitOfPresentation",
            "path": "MedicinalProductPharmaceutical.unitOfPresentation",
            "short": "Todo",
            "definition": "Todo.",
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
            "id": "MedicinalProductPharmaceutical.ingredient",
            "path": "MedicinalProductPharmaceutical.ingredient",
            "short": "Ingredient",
            "definition": "Ingredient.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/MedicinalProductIngredient"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductPharmaceutical.device",
            "path": "MedicinalProductPharmaceutical.device",
            "short": "Accompanying device",
            "definition": "Accompanying device.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/DeviceDefinition"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductPharmaceutical.characteristics",
            "path": "MedicinalProductPharmaceutical.characteristics",
            "short": "Characteristics e.g. a products onset of action",
            "definition": "Characteristics e.g. a products onset of action.",
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
            "id": "MedicinalProductPharmaceutical.characteristics.code",
            "path": "MedicinalProductPharmaceutical.characteristics.code",
            "short": "A coded characteristic",
            "definition": "A coded characteristic.",
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
            "id": "MedicinalProductPharmaceutical.characteristics.status",
            "path": "MedicinalProductPharmaceutical.characteristics.status",
            "short": "The status of characteristic e.g. assigned or pending",
            "definition": "The status of characteristic e.g. assigned or pending.",
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
            "id": "MedicinalProductPharmaceutical.routeOfAdministration",
            "path": "MedicinalProductPharmaceutical.routeOfAdministration",
            "short": "The path by which the pharmaceutical product is taken into or makes contact with the body",
            "definition": "The path by which the pharmaceutical product is taken into or makes contact with the body.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductPharmaceutical.routeOfAdministration.code",
            "path": "MedicinalProductPharmaceutical.routeOfAdministration.code",
            "short": "Coded expression for the route",
            "definition": "Coded expression for the route.",
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
            "id": "MedicinalProductPharmaceutical.routeOfAdministration.firstDose",
            "path": "MedicinalProductPharmaceutical.routeOfAdministration.firstDose",
            "short": "The first dose (dose quantity) administered in humans can be specified, for a product under investigation, using a numerical value and its unit of measurement",
            "definition": "The first dose (dose quantity) administered in humans can be specified, for a product under investigation, using a numerical value and its unit of measurement.",
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
            "id": "MedicinalProductPharmaceutical.routeOfAdministration.maxSingleDose",
            "path": "MedicinalProductPharmaceutical.routeOfAdministration.maxSingleDose",
            "short": "The maximum single dose that can be administered as per the protocol of a clinical trial can be specified using a numerical value and its unit of measurement",
            "definition": "The maximum single dose that can be administered as per the protocol of a clinical trial can be specified using a numerical value and its unit of measurement.",
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
            "id": "MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerDay",
            "path": "MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerDay",
            "short": "The maximum dose per day (maximum dose quantity to be administered in any one 24-h period) that can be administered as per the protocol referenced in the clinical trial authorisation",
            "definition": "The maximum dose per day (maximum dose quantity to be administered in any one 24-h period) that can be administered as per the protocol referenced in the clinical trial authorisation.",
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
            "id": "MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerTreatmentPeriod",
            "path": "MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerTreatmentPeriod",
            "short": "The maximum dose per treatment period that can be administered as per the protocol referenced in the clinical trial authorisation",
            "definition": "The maximum dose per treatment period that can be administered as per the protocol referenced in the clinical trial authorisation.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Ratio"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductPharmaceutical.routeOfAdministration.maxTreatmentPeriod",
            "path": "MedicinalProductPharmaceutical.routeOfAdministration.maxTreatmentPeriod",
            "short": "The maximum treatment period during which an Investigational Medicinal Product can be administered as per the protocol referenced in the clinical trial authorisation",
            "definition": "The maximum treatment period during which an Investigational Medicinal Product can be administered as per the protocol referenced in the clinical trial authorisation.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Duration"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies",
            "path": "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies",
            "short": "A species for which this route applies",
            "definition": "A species for which this route applies.",
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
            "id": "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.code",
            "path": "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.code",
            "short": "Coded expression for the species",
            "definition": "Coded expression for the species.",
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
            "id": "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod",
            "path": "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod",
            "short": "A species specific time during which consumption of animal product is not appropriate",
            "definition": "A species specific time during which consumption of animal product is not appropriate.",
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
            "id": "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.tissue",
            "path": "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.tissue",
            "short": "Coded expression for the type of tissue for which the withdrawal period applues, e.g. meat, milk",
            "definition": "Coded expression for the type of tissue for which the withdrawal period applues, e.g. meat, milk.",
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
            "id": "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.value",
            "path": "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.value",
            "short": "A value for the time",
            "definition": "A value for the time.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Quantity"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.supportingInformation",
            "path": "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.supportingInformation",
            "short": "Extra information about the withdrawal period",
            "definition": "Extra information about the withdrawal period.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
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
    /// Fhir resource 'MedicinalProductPharmaceutical'
    /// </summary>
    // 0. MedicinalProductPharmaceutical
    public partial class Resource_MedicinalProductPharmaceutical : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 6. MedicinalProductPharmaceutical.characteristics
        public partial class Type_Characteristics : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 7. MedicinalProductPharmaceutical.characteristics.code
            public ElementDefinitionInfo Element_Code;
            // 8. MedicinalProductPharmaceutical.characteristics.status
            public ElementDefinitionInfo Element_Status;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "MedicinalProductPharmaceutical.characteristics",
                    ElementId = "MedicinalProductPharmaceutical.characteristics"
                });
                Element_Code.Write(sDef);
                Element_Status.Write(sDef);
            }
            
            public Type_Characteristics()
            {
                {
                    // 7. MedicinalProductPharmaceutical.characteristics.code
                    this.Element_Code = new ElementDefinitionInfo
                    {
                        Name = "Element_Code",
                        Path= "MedicinalProductPharmaceutical.characteristics.code",
                        Id = "MedicinalProductPharmaceutical.characteristics.code",
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
                    // 8. MedicinalProductPharmaceutical.characteristics.status
                    this.Element_Status = new ElementDefinitionInfo
                    {
                        Name = "Element_Status",
                        Path= "MedicinalProductPharmaceutical.characteristics.status",
                        Id = "MedicinalProductPharmaceutical.characteristics.status",
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
        // 9. MedicinalProductPharmaceutical.routeOfAdministration
        public partial class Type_RouteOfAdministration : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 16. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies
            public partial class Type_TargetSpecies : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 18. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod
                public partial class Type_WithdrawalPeriod : FhirKhit.Maker.Common.Complex.ComplexBase
                {
                    // 19. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.tissue
                    public ElementDefinitionInfo Element_Tissue;
                    // 20. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.value
                    public ElementDefinitionInfo Element_Value;
                    // 21. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.supportingInformation
                    public ElementDefinitionInfo Element_SupportingInformation;
                    
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                    {
                        base.Write(sDef);
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                        {
                            Path = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod",
                            ElementId = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod"
                        });
                        Element_Tissue.Write(sDef);
                        Element_Value.Write(sDef);
                        Element_SupportingInformation.Write(sDef);
                    }
                    
                    public Type_WithdrawalPeriod()
                    {
                        {
                            // 19. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.tissue
                            this.Element_Tissue = new ElementDefinitionInfo
                            {
                                Name = "Element_Tissue",
                                Path= "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.tissue",
                                Id = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.tissue",
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
                            // 20. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.value
                            this.Element_Value = new ElementDefinitionInfo
                            {
                                Name = "Element_Value",
                                Path= "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.value",
                                Id = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.value",
                                Min = 1,
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
                            // 21. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.supportingInformation
                            this.Element_SupportingInformation = new ElementDefinitionInfo
                            {
                                Name = "Element_SupportingInformation",
                                Path= "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.supportingInformation",
                                Id = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.supportingInformation",
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
                // 17. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.code
                public ElementDefinitionInfo Element_Code;
                // 18. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod
                public ElementDefinitionInfo Element_WithdrawalPeriod;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies",
                        ElementId = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies"
                    });
                    Element_Code.Write(sDef);
                    Element_WithdrawalPeriod.Write(sDef);
                }
                
                public Type_TargetSpecies()
                {
                    {
                        // 17. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.code
                        this.Element_Code = new ElementDefinitionInfo
                        {
                            Name = "Element_Code",
                            Path= "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.code",
                            Id = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.code",
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
                        // 18. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod
                        this.Element_WithdrawalPeriod = new ElementDefinitionInfo
                        {
                            Name = "Element_WithdrawalPeriod",
                            Path= "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod",
                            Id = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new Type_WithdrawalPeriod
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 10. MedicinalProductPharmaceutical.routeOfAdministration.code
            public ElementDefinitionInfo Element_Code;
            // 11. MedicinalProductPharmaceutical.routeOfAdministration.firstDose
            public ElementDefinitionInfo Element_FirstDose;
            // 12. MedicinalProductPharmaceutical.routeOfAdministration.maxSingleDose
            public ElementDefinitionInfo Element_MaxSingleDose;
            // 13. MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerDay
            public ElementDefinitionInfo Element_MaxDosePerDay;
            // 14. MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerTreatmentPeriod
            public ElementDefinitionInfo Element_MaxDosePerTreatmentPeriod;
            // 15. MedicinalProductPharmaceutical.routeOfAdministration.maxTreatmentPeriod
            public ElementDefinitionInfo Element_MaxTreatmentPeriod;
            // 16. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies
            public ElementDefinitionInfo Element_TargetSpecies;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "MedicinalProductPharmaceutical.routeOfAdministration",
                    ElementId = "MedicinalProductPharmaceutical.routeOfAdministration"
                });
                Element_Code.Write(sDef);
                Element_FirstDose.Write(sDef);
                Element_MaxSingleDose.Write(sDef);
                Element_MaxDosePerDay.Write(sDef);
                Element_MaxDosePerTreatmentPeriod.Write(sDef);
                Element_MaxTreatmentPeriod.Write(sDef);
                Element_TargetSpecies.Write(sDef);
            }
            
            public Type_RouteOfAdministration()
            {
                {
                    // 10. MedicinalProductPharmaceutical.routeOfAdministration.code
                    this.Element_Code = new ElementDefinitionInfo
                    {
                        Name = "Element_Code",
                        Path= "MedicinalProductPharmaceutical.routeOfAdministration.code",
                        Id = "MedicinalProductPharmaceutical.routeOfAdministration.code",
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
                    // 11. MedicinalProductPharmaceutical.routeOfAdministration.firstDose
                    this.Element_FirstDose = new ElementDefinitionInfo
                    {
                        Name = "Element_FirstDose",
                        Path= "MedicinalProductPharmaceutical.routeOfAdministration.firstDose",
                        Id = "MedicinalProductPharmaceutical.routeOfAdministration.firstDose",
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
                    // 12. MedicinalProductPharmaceutical.routeOfAdministration.maxSingleDose
                    this.Element_MaxSingleDose = new ElementDefinitionInfo
                    {
                        Name = "Element_MaxSingleDose",
                        Path= "MedicinalProductPharmaceutical.routeOfAdministration.maxSingleDose",
                        Id = "MedicinalProductPharmaceutical.routeOfAdministration.maxSingleDose",
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
                    // 13. MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerDay
                    this.Element_MaxDosePerDay = new ElementDefinitionInfo
                    {
                        Name = "Element_MaxDosePerDay",
                        Path= "MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerDay",
                        Id = "MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerDay",
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
                    // 14. MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerTreatmentPeriod
                    this.Element_MaxDosePerTreatmentPeriod = new ElementDefinitionInfo
                    {
                        Name = "Element_MaxDosePerTreatmentPeriod",
                        Path= "MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerTreatmentPeriod",
                        Id = "MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerTreatmentPeriod",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Ratio
                            {
                            }
                        }
                    };
                }
                {
                    // 15. MedicinalProductPharmaceutical.routeOfAdministration.maxTreatmentPeriod
                    this.Element_MaxTreatmentPeriod = new ElementDefinitionInfo
                    {
                        Name = "Element_MaxTreatmentPeriod",
                        Path= "MedicinalProductPharmaceutical.routeOfAdministration.maxTreatmentPeriod",
                        Id = "MedicinalProductPharmaceutical.routeOfAdministration.maxTreatmentPeriod",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Duration
                            {
                            }
                        }
                    };
                }
                {
                    // 16. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies
                    this.Element_TargetSpecies = new ElementDefinitionInfo
                    {
                        Name = "Element_TargetSpecies",
                        Path= "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies",
                        Id = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_TargetSpecies
                            {
                            }
                        }
                    };
                }
            }
        }
        // 1. MedicinalProductPharmaceutical.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. MedicinalProductPharmaceutical.administrableDoseForm
        public ElementDefinitionInfo Element_AdministrableDoseForm;
        // 3. MedicinalProductPharmaceutical.unitOfPresentation
        public ElementDefinitionInfo Element_UnitOfPresentation;
        // 4. MedicinalProductPharmaceutical.ingredient
        public ElementDefinitionInfo Element_Ingredient;
        // 5. MedicinalProductPharmaceutical.device
        public ElementDefinitionInfo Element_Device;
        // 6. MedicinalProductPharmaceutical.characteristics
        public ElementDefinitionInfo Element_Characteristics;
        // 9. MedicinalProductPharmaceutical.routeOfAdministration
        public ElementDefinitionInfo Element_RouteOfAdministration;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "MedicinalProductPharmaceutical",
                ElementId = "MedicinalProductPharmaceutical"
            });
            Element_Identifier.Write(sDef);
            Element_AdministrableDoseForm.Write(sDef);
            Element_UnitOfPresentation.Write(sDef);
            Element_Ingredient.Write(sDef);
            Element_Device.Write(sDef);
            Element_Characteristics.Write(sDef);
            Element_RouteOfAdministration.Write(sDef);
        }
        
        public Resource_MedicinalProductPharmaceutical()
        {
            {
                // 1. MedicinalProductPharmaceutical.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "MedicinalProductPharmaceutical.identifier",
                    Id = "MedicinalProductPharmaceutical.identifier",
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
                // 2. MedicinalProductPharmaceutical.administrableDoseForm
                this.Element_AdministrableDoseForm = new ElementDefinitionInfo
                {
                    Name = "Element_AdministrableDoseForm",
                    Path= "MedicinalProductPharmaceutical.administrableDoseForm",
                    Id = "MedicinalProductPharmaceutical.administrableDoseForm",
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
                // 3. MedicinalProductPharmaceutical.unitOfPresentation
                this.Element_UnitOfPresentation = new ElementDefinitionInfo
                {
                    Name = "Element_UnitOfPresentation",
                    Path= "MedicinalProductPharmaceutical.unitOfPresentation",
                    Id = "MedicinalProductPharmaceutical.unitOfPresentation",
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
                // 4. MedicinalProductPharmaceutical.ingredient
                this.Element_Ingredient = new ElementDefinitionInfo
                {
                    Name = "Element_Ingredient",
                    Path= "MedicinalProductPharmaceutical.ingredient",
                    Id = "MedicinalProductPharmaceutical.ingredient",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/MedicinalProductIngredient"
                            }
                        }
                    }
                };
            }
            {
                // 5. MedicinalProductPharmaceutical.device
                this.Element_Device = new ElementDefinitionInfo
                {
                    Name = "Element_Device",
                    Path= "MedicinalProductPharmaceutical.device",
                    Id = "MedicinalProductPharmaceutical.device",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/DeviceDefinition"
                            }
                        }
                    }
                };
            }
            {
                // 6. MedicinalProductPharmaceutical.characteristics
                this.Element_Characteristics = new ElementDefinitionInfo
                {
                    Name = "Element_Characteristics",
                    Path= "MedicinalProductPharmaceutical.characteristics",
                    Id = "MedicinalProductPharmaceutical.characteristics",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Characteristics
                        {
                        }
                    }
                };
            }
            {
                // 9. MedicinalProductPharmaceutical.routeOfAdministration
                this.Element_RouteOfAdministration = new ElementDefinitionInfo
                {
                    Name = "Element_RouteOfAdministration",
                    Path= "MedicinalProductPharmaceutical.routeOfAdministration",
                    Id = "MedicinalProductPharmaceutical.routeOfAdministration",
                    Min = 1,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_RouteOfAdministration
                        {
                        }
                    }
                };
            }
            this.Name = "MedicinalProductPharmaceutical";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MedicinalProductPharmaceutical";
        }
    }
}
