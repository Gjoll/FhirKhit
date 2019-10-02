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
      "id": "SubstancePolymer",
      "url": "http://hl7.org/fhir/StructureDefinition/SubstancePolymer",
      "version": "4.0.0",
      "name": "SubstancePolymer",
      "status": "draft",
      "publisher": "Health Level Seven International (Biomedical Research and Regulation)",
      "description": "Todo.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "SubstancePolymer",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "SubstancePolymer",
            "path": "SubstancePolymer",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "SubstancePolymer.class",
            "path": "SubstancePolymer.class",
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
            "id": "SubstancePolymer.geometry",
            "path": "SubstancePolymer.geometry",
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
            "id": "SubstancePolymer.copolymerConnectivity",
            "path": "SubstancePolymer.copolymerConnectivity",
            "short": "Todo",
            "definition": "Todo.",
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
            "id": "SubstancePolymer.modification",
            "path": "SubstancePolymer.modification",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstancePolymer.monomerSet",
            "path": "SubstancePolymer.monomerSet",
            "short": "Todo",
            "definition": "Todo.",
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
            "id": "SubstancePolymer.monomerSet.ratioType",
            "path": "SubstancePolymer.monomerSet.ratioType",
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
            "id": "SubstancePolymer.monomerSet.startingMaterial",
            "path": "SubstancePolymer.monomerSet.startingMaterial",
            "short": "Todo",
            "definition": "Todo.",
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
            "id": "SubstancePolymer.monomerSet.startingMaterial.material",
            "path": "SubstancePolymer.monomerSet.startingMaterial.material",
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
            "id": "SubstancePolymer.monomerSet.startingMaterial.type",
            "path": "SubstancePolymer.monomerSet.startingMaterial.type",
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
            "id": "SubstancePolymer.monomerSet.startingMaterial.isDefining",
            "path": "SubstancePolymer.monomerSet.startingMaterial.isDefining",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstancePolymer.monomerSet.startingMaterial.amount",
            "path": "SubstancePolymer.monomerSet.startingMaterial.amount",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "SubstanceAmount"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstancePolymer.repeat",
            "path": "SubstancePolymer.repeat",
            "short": "Todo",
            "definition": "Todo.",
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
            "id": "SubstancePolymer.repeat.numberOfUnits",
            "path": "SubstancePolymer.repeat.numberOfUnits",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "integer"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstancePolymer.repeat.averageMolecularFormula",
            "path": "SubstancePolymer.repeat.averageMolecularFormula",
            "short": "Todo",
            "definition": "Todo.",
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
            "id": "SubstancePolymer.repeat.repeatUnitAmountType",
            "path": "SubstancePolymer.repeat.repeatUnitAmountType",
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
            "id": "SubstancePolymer.repeat.repeatUnit",
            "path": "SubstancePolymer.repeat.repeatUnit",
            "short": "Todo",
            "definition": "Todo.",
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
            "id": "SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation",
            "path": "SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation",
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
            "id": "SubstancePolymer.repeat.repeatUnit.repeatUnit",
            "path": "SubstancePolymer.repeat.repeatUnit.repeatUnit",
            "short": "Todo",
            "definition": "Todo.",
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
            "id": "SubstancePolymer.repeat.repeatUnit.amount",
            "path": "SubstancePolymer.repeat.repeatUnit.amount",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "SubstanceAmount"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation",
            "path": "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation",
            "short": "Todo",
            "definition": "Todo.",
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
            "id": "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree",
            "path": "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree",
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
            "id": "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount",
            "path": "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "SubstanceAmount"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstancePolymer.repeat.repeatUnit.structuralRepresentation",
            "path": "SubstancePolymer.repeat.repeatUnit.structuralRepresentation",
            "short": "Todo",
            "definition": "Todo.",
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
            "id": "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type",
            "path": "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type",
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
            "id": "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.representation",
            "path": "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.representation",
            "short": "Todo",
            "definition": "Todo.",
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
            "id": "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment",
            "path": "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Attachment"
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
    /// Fhir resource 'SubstancePolymer'
    /// </summary>
    // 0. SubstancePolymer
    public class Resource_SubstancePolymer : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 5. SubstancePolymer.monomerSet
        public class Type_MonomerSet : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 7. SubstancePolymer.monomerSet.startingMaterial
            public class Type_StartingMaterial : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 8. SubstancePolymer.monomerSet.startingMaterial.material
                public ElementDefinitionInfo Element_Material;
                // 9. SubstancePolymer.monomerSet.startingMaterial.type
                public ElementDefinitionInfo Element_Type;
                // 10. SubstancePolymer.monomerSet.startingMaterial.isDefining
                public ElementDefinitionInfo Element_IsDefining;
                // 11. SubstancePolymer.monomerSet.startingMaterial.amount
                public ElementDefinitionInfo Element_Amount;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "SubstancePolymer.monomerSet.startingMaterial",
                        ElementId = "SubstancePolymer.monomerSet.startingMaterial"
                    });
                    Element_Material.Write(sDef);
                    Element_Type.Write(sDef);
                    Element_IsDefining.Write(sDef);
                    Element_Amount.Write(sDef);
                }
                
                public Type_StartingMaterial()
                {
                    {
                        // 8. SubstancePolymer.monomerSet.startingMaterial.material
                        this.Element_Material = new ElementDefinitionInfo
                        {
                            Name = "Element_Material",
                            Path= "SubstancePolymer.monomerSet.startingMaterial.material",
                            Id = "SubstancePolymer.monomerSet.startingMaterial.material",
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
                        // 9. SubstancePolymer.monomerSet.startingMaterial.type
                        this.Element_Type = new ElementDefinitionInfo
                        {
                            Name = "Element_Type",
                            Path= "SubstancePolymer.monomerSet.startingMaterial.type",
                            Id = "SubstancePolymer.monomerSet.startingMaterial.type",
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
                        // 10. SubstancePolymer.monomerSet.startingMaterial.isDefining
                        this.Element_IsDefining = new ElementDefinitionInfo
                        {
                            Name = "Element_IsDefining",
                            Path= "SubstancePolymer.monomerSet.startingMaterial.isDefining",
                            Id = "SubstancePolymer.monomerSet.startingMaterial.isDefining",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_Boolean
                                {
                                }
                            }
                        };
                    }
                    {
                        // 11. SubstancePolymer.monomerSet.startingMaterial.amount
                        this.Element_Amount = new ElementDefinitionInfo
                        {
                            Name = "Element_Amount",
                            Path= "SubstancePolymer.monomerSet.startingMaterial.amount",
                            Id = "SubstancePolymer.monomerSet.startingMaterial.amount",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_SubstanceAmount
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 6. SubstancePolymer.monomerSet.ratioType
            public ElementDefinitionInfo Element_RatioType;
            // 7. SubstancePolymer.monomerSet.startingMaterial
            public ElementDefinitionInfo Element_StartingMaterial;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "SubstancePolymer.monomerSet",
                    ElementId = "SubstancePolymer.monomerSet"
                });
                Element_RatioType.Write(sDef);
                Element_StartingMaterial.Write(sDef);
            }
            
            public Type_MonomerSet()
            {
                {
                    // 6. SubstancePolymer.monomerSet.ratioType
                    this.Element_RatioType = new ElementDefinitionInfo
                    {
                        Name = "Element_RatioType",
                        Path= "SubstancePolymer.monomerSet.ratioType",
                        Id = "SubstancePolymer.monomerSet.ratioType",
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
                    // 7. SubstancePolymer.monomerSet.startingMaterial
                    this.Element_StartingMaterial = new ElementDefinitionInfo
                    {
                        Name = "Element_StartingMaterial",
                        Path= "SubstancePolymer.monomerSet.startingMaterial",
                        Id = "SubstancePolymer.monomerSet.startingMaterial",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_StartingMaterial
                            {
                            }
                        }
                    };
                }
            }
        }
        // 12. SubstancePolymer.repeat
        public class Type_Repeat : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 16. SubstancePolymer.repeat.repeatUnit
            public class Type_RepeatUnit : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 20. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation
                public class Type_DegreeOfPolymerisation : FhirKhit.Maker.Common.Complex.ComplexBase
                {
                    // 21. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree
                    public ElementDefinitionInfo Element_Degree;
                    // 22. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount
                    public ElementDefinitionInfo Element_Amount;
                    
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                    {
                        base.Write(sDef);
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                        {
                            Path = "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation",
                            ElementId = "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation"
                        });
                        Element_Degree.Write(sDef);
                        Element_Amount.Write(sDef);
                    }
                    
                    public Type_DegreeOfPolymerisation()
                    {
                        {
                            // 21. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree
                            this.Element_Degree = new ElementDefinitionInfo
                            {
                                Name = "Element_Degree",
                                Path= "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree",
                                Id = "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree",
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
                            // 22. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount
                            this.Element_Amount = new ElementDefinitionInfo
                            {
                                Name = "Element_Amount",
                                Path= "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount",
                                Id = "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount",
                                Min = 0,
                                Max = 1,
                                Types = new BaseType[]
                                {
                                    new FhirKhit.Maker.Common.Complex.Type_SubstanceAmount
                                    {
                                    }
                                }
                            };
                        }
                    }
                }
                // 23. SubstancePolymer.repeat.repeatUnit.structuralRepresentation
                public class Type_StructuralRepresentation : FhirKhit.Maker.Common.Complex.ComplexBase
                {
                    // 24. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type
                    public ElementDefinitionInfo Element_Type;
                    // 25. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.representation
                    public ElementDefinitionInfo Element_Representation;
                    // 26. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment
                    public ElementDefinitionInfo Element_Attachment;
                    
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                    {
                        base.Write(sDef);
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                        {
                            Path = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation",
                            ElementId = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation"
                        });
                        Element_Type.Write(sDef);
                        Element_Representation.Write(sDef);
                        Element_Attachment.Write(sDef);
                    }
                    
                    public Type_StructuralRepresentation()
                    {
                        {
                            // 24. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type
                            this.Element_Type = new ElementDefinitionInfo
                            {
                                Name = "Element_Type",
                                Path= "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type",
                                Id = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type",
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
                            // 25. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.representation
                            this.Element_Representation = new ElementDefinitionInfo
                            {
                                Name = "Element_Representation",
                                Path= "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.representation",
                                Id = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.representation",
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
                            // 26. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment
                            this.Element_Attachment = new ElementDefinitionInfo
                            {
                                Name = "Element_Attachment",
                                Path= "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment",
                                Id = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment",
                                Min = 0,
                                Max = 1,
                                Types = new BaseType[]
                                {
                                    new FhirKhit.Maker.Common.Complex.Type_Attachment
                                    {
                                    }
                                }
                            };
                        }
                    }
                }
                // 17. SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation
                public ElementDefinitionInfo Element_OrientationOfPolymerisation;
                // 18. SubstancePolymer.repeat.repeatUnit.repeatUnit
                public ElementDefinitionInfo Element_RepeatUnit;
                // 19. SubstancePolymer.repeat.repeatUnit.amount
                public ElementDefinitionInfo Element_Amount;
                // 20. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation
                public ElementDefinitionInfo Element_DegreeOfPolymerisation;
                // 23. SubstancePolymer.repeat.repeatUnit.structuralRepresentation
                public ElementDefinitionInfo Element_StructuralRepresentation;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "SubstancePolymer.repeat.repeatUnit",
                        ElementId = "SubstancePolymer.repeat.repeatUnit"
                    });
                    Element_OrientationOfPolymerisation.Write(sDef);
                    Element_RepeatUnit.Write(sDef);
                    Element_Amount.Write(sDef);
                    Element_DegreeOfPolymerisation.Write(sDef);
                    Element_StructuralRepresentation.Write(sDef);
                }
                
                public Type_RepeatUnit()
                {
                    {
                        // 17. SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation
                        this.Element_OrientationOfPolymerisation = new ElementDefinitionInfo
                        {
                            Name = "Element_OrientationOfPolymerisation",
                            Path= "SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation",
                            Id = "SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation",
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
                        // 18. SubstancePolymer.repeat.repeatUnit.repeatUnit
                        this.Element_RepeatUnit = new ElementDefinitionInfo
                        {
                            Name = "Element_RepeatUnit",
                            Path= "SubstancePolymer.repeat.repeatUnit.repeatUnit",
                            Id = "SubstancePolymer.repeat.repeatUnit.repeatUnit",
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
                        // 19. SubstancePolymer.repeat.repeatUnit.amount
                        this.Element_Amount = new ElementDefinitionInfo
                        {
                            Name = "Element_Amount",
                            Path= "SubstancePolymer.repeat.repeatUnit.amount",
                            Id = "SubstancePolymer.repeat.repeatUnit.amount",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_SubstanceAmount
                                {
                                }
                            }
                        };
                    }
                    {
                        // 20. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation
                        this.Element_DegreeOfPolymerisation = new ElementDefinitionInfo
                        {
                            Name = "Element_DegreeOfPolymerisation",
                            Path= "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation",
                            Id = "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new Type_DegreeOfPolymerisation
                                {
                                }
                            }
                        };
                    }
                    {
                        // 23. SubstancePolymer.repeat.repeatUnit.structuralRepresentation
                        this.Element_StructuralRepresentation = new ElementDefinitionInfo
                        {
                            Name = "Element_StructuralRepresentation",
                            Path= "SubstancePolymer.repeat.repeatUnit.structuralRepresentation",
                            Id = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new Type_StructuralRepresentation
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 13. SubstancePolymer.repeat.numberOfUnits
            public ElementDefinitionInfo Element_NumberOfUnits;
            // 14. SubstancePolymer.repeat.averageMolecularFormula
            public ElementDefinitionInfo Element_AverageMolecularFormula;
            // 15. SubstancePolymer.repeat.repeatUnitAmountType
            public ElementDefinitionInfo Element_RepeatUnitAmountType;
            // 16. SubstancePolymer.repeat.repeatUnit
            public ElementDefinitionInfo Element_RepeatUnit;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "SubstancePolymer.repeat",
                    ElementId = "SubstancePolymer.repeat"
                });
                Element_NumberOfUnits.Write(sDef);
                Element_AverageMolecularFormula.Write(sDef);
                Element_RepeatUnitAmountType.Write(sDef);
                Element_RepeatUnit.Write(sDef);
            }
            
            public Type_Repeat()
            {
                {
                    // 13. SubstancePolymer.repeat.numberOfUnits
                    this.Element_NumberOfUnits = new ElementDefinitionInfo
                    {
                        Name = "Element_NumberOfUnits",
                        Path= "SubstancePolymer.repeat.numberOfUnits",
                        Id = "SubstancePolymer.repeat.numberOfUnits",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Integer
                            {
                            }
                        }
                    };
                }
                {
                    // 14. SubstancePolymer.repeat.averageMolecularFormula
                    this.Element_AverageMolecularFormula = new ElementDefinitionInfo
                    {
                        Name = "Element_AverageMolecularFormula",
                        Path= "SubstancePolymer.repeat.averageMolecularFormula",
                        Id = "SubstancePolymer.repeat.averageMolecularFormula",
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
                    // 15. SubstancePolymer.repeat.repeatUnitAmountType
                    this.Element_RepeatUnitAmountType = new ElementDefinitionInfo
                    {
                        Name = "Element_RepeatUnitAmountType",
                        Path= "SubstancePolymer.repeat.repeatUnitAmountType",
                        Id = "SubstancePolymer.repeat.repeatUnitAmountType",
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
                    // 16. SubstancePolymer.repeat.repeatUnit
                    this.Element_RepeatUnit = new ElementDefinitionInfo
                    {
                        Name = "Element_RepeatUnit",
                        Path= "SubstancePolymer.repeat.repeatUnit",
                        Id = "SubstancePolymer.repeat.repeatUnit",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_RepeatUnit
                            {
                            }
                        }
                    };
                }
            }
        }
        // 1. SubstancePolymer.class
        public ElementDefinitionInfo Element_Class;
        // 2. SubstancePolymer.geometry
        public ElementDefinitionInfo Element_Geometry;
        // 3. SubstancePolymer.copolymerConnectivity
        public ElementDefinitionInfo Element_CopolymerConnectivity;
        // 4. SubstancePolymer.modification
        public ElementDefinitionInfo Element_Modification;
        // 5. SubstancePolymer.monomerSet
        public ElementDefinitionInfo Element_MonomerSet;
        // 12. SubstancePolymer.repeat
        public ElementDefinitionInfo Element_Repeat;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "SubstancePolymer",
                ElementId = "SubstancePolymer"
            });
            Element_Class.Write(sDef);
            Element_Geometry.Write(sDef);
            Element_CopolymerConnectivity.Write(sDef);
            Element_Modification.Write(sDef);
            Element_MonomerSet.Write(sDef);
            Element_Repeat.Write(sDef);
        }
        
        public Resource_SubstancePolymer()
        {
            {
                // 1. SubstancePolymer.class
                this.Element_Class = new ElementDefinitionInfo
                {
                    Name = "Element_Class",
                    Path= "SubstancePolymer.class",
                    Id = "SubstancePolymer.class",
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
                // 2. SubstancePolymer.geometry
                this.Element_Geometry = new ElementDefinitionInfo
                {
                    Name = "Element_Geometry",
                    Path= "SubstancePolymer.geometry",
                    Id = "SubstancePolymer.geometry",
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
                // 3. SubstancePolymer.copolymerConnectivity
                this.Element_CopolymerConnectivity = new ElementDefinitionInfo
                {
                    Name = "Element_CopolymerConnectivity",
                    Path= "SubstancePolymer.copolymerConnectivity",
                    Id = "SubstancePolymer.copolymerConnectivity",
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
                // 4. SubstancePolymer.modification
                this.Element_Modification = new ElementDefinitionInfo
                {
                    Name = "Element_Modification",
                    Path= "SubstancePolymer.modification",
                    Id = "SubstancePolymer.modification",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_String
                        {
                        }
                    }
                };
            }
            {
                // 5. SubstancePolymer.monomerSet
                this.Element_MonomerSet = new ElementDefinitionInfo
                {
                    Name = "Element_MonomerSet",
                    Path= "SubstancePolymer.monomerSet",
                    Id = "SubstancePolymer.monomerSet",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_MonomerSet
                        {
                        }
                    }
                };
            }
            {
                // 12. SubstancePolymer.repeat
                this.Element_Repeat = new ElementDefinitionInfo
                {
                    Name = "Element_Repeat",
                    Path= "SubstancePolymer.repeat",
                    Id = "SubstancePolymer.repeat",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Repeat
                        {
                        }
                    }
                };
            }
            this.Name = "SubstancePolymer";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/SubstancePolymer";
        }
    }
}
