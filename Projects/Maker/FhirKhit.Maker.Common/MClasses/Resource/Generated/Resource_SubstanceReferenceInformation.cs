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
      "id": "SubstanceReferenceInformation",
      "url": "http://hl7.org/fhir/StructureDefinition/SubstanceReferenceInformation",
      "version": "4.0.0",
      "name": "SubstanceReferenceInformation",
      "status": "draft",
      "publisher": "Health Level Seven International (Biomedical Research and Regulation)",
      "description": "Todo.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "SubstanceReferenceInformation",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "SubstanceReferenceInformation",
            "path": "SubstanceReferenceInformation",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "SubstanceReferenceInformation.comment",
            "path": "SubstanceReferenceInformation.comment",
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
            "id": "SubstanceReferenceInformation.gene",
            "path": "SubstanceReferenceInformation.gene",
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
            "id": "SubstanceReferenceInformation.gene.geneSequenceOrigin",
            "path": "SubstanceReferenceInformation.gene.geneSequenceOrigin",
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
            "id": "SubstanceReferenceInformation.gene.gene",
            "path": "SubstanceReferenceInformation.gene.gene",
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
            "id": "SubstanceReferenceInformation.gene.source",
            "path": "SubstanceReferenceInformation.gene.source",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceReferenceInformation.geneElement",
            "path": "SubstanceReferenceInformation.geneElement",
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
            "id": "SubstanceReferenceInformation.geneElement.type",
            "path": "SubstanceReferenceInformation.geneElement.type",
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
            "id": "SubstanceReferenceInformation.geneElement.element",
            "path": "SubstanceReferenceInformation.geneElement.element",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Identifier"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceReferenceInformation.geneElement.source",
            "path": "SubstanceReferenceInformation.geneElement.source",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceReferenceInformation.classification",
            "path": "SubstanceReferenceInformation.classification",
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
            "id": "SubstanceReferenceInformation.classification.domain",
            "path": "SubstanceReferenceInformation.classification.domain",
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
            "id": "SubstanceReferenceInformation.classification.classification",
            "path": "SubstanceReferenceInformation.classification.classification",
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
            "id": "SubstanceReferenceInformation.classification.subtype",
            "path": "SubstanceReferenceInformation.classification.subtype",
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
            "id": "SubstanceReferenceInformation.classification.source",
            "path": "SubstanceReferenceInformation.classification.source",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceReferenceInformation.target",
            "path": "SubstanceReferenceInformation.target",
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
            "id": "SubstanceReferenceInformation.target.target",
            "path": "SubstanceReferenceInformation.target.target",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Identifier"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceReferenceInformation.target.type",
            "path": "SubstanceReferenceInformation.target.type",
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
            "id": "SubstanceReferenceInformation.target.interaction",
            "path": "SubstanceReferenceInformation.target.interaction",
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
            "id": "SubstanceReferenceInformation.target.organism",
            "path": "SubstanceReferenceInformation.target.organism",
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
            "id": "SubstanceReferenceInformation.target.organismType",
            "path": "SubstanceReferenceInformation.target.organismType",
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
            "id": "SubstanceReferenceInformation.target.amount[x]",
            "path": "SubstanceReferenceInformation.target.amount[x]",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity"
              },
              {
                "code": "Range"
              },
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceReferenceInformation.target.amountType",
            "path": "SubstanceReferenceInformation.target.amountType",
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
            "id": "SubstanceReferenceInformation.target.source",
            "path": "SubstanceReferenceInformation.target.source",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                ]
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
    /// Fhir resource 'SubstanceReferenceInformation'
    /// </summary>
    // 0. SubstanceReferenceInformation
    public class Resource_SubstanceReferenceInformation : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 2. SubstanceReferenceInformation.gene
        public class Type_Gene : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 3. SubstanceReferenceInformation.gene.geneSequenceOrigin
            public ElementDefinitionInfo Element_GeneSequenceOrigin;
            // 4. SubstanceReferenceInformation.gene.gene
            public ElementDefinitionInfo Element_Gene;
            // 5. SubstanceReferenceInformation.gene.source
            public ElementDefinitionInfo Element_Source;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "SubstanceReferenceInformation.gene",
                    ElementId = "SubstanceReferenceInformation.gene"
                });
                Element_GeneSequenceOrigin.Write(sDef);
                Element_Gene.Write(sDef);
                Element_Source.Write(sDef);
            }
            
            public Type_Gene()
            {
                {
                    // 3. SubstanceReferenceInformation.gene.geneSequenceOrigin
                    this.Element_GeneSequenceOrigin = new ElementDefinitionInfo
                    {
                        Name = "Element_GeneSequenceOrigin",
                        Path= "SubstanceReferenceInformation.gene.geneSequenceOrigin",
                        Id = "SubstanceReferenceInformation.gene.geneSequenceOrigin",
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
                    // 4. SubstanceReferenceInformation.gene.gene
                    this.Element_Gene = new ElementDefinitionInfo
                    {
                        Name = "Element_Gene",
                        Path= "SubstanceReferenceInformation.gene.gene",
                        Id = "SubstanceReferenceInformation.gene.gene",
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
                    // 5. SubstanceReferenceInformation.gene.source
                    this.Element_Source = new ElementDefinitionInfo
                    {
                        Name = "Element_Source",
                        Path= "SubstanceReferenceInformation.gene.source",
                        Id = "SubstanceReferenceInformation.gene.source",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                                }
                            }
                        }
                    };
                }
            }
        }
        // 6. SubstanceReferenceInformation.geneElement
        public class Type_GeneElement : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 7. SubstanceReferenceInformation.geneElement.type
            public ElementDefinitionInfo Element_Type;
            // 8. SubstanceReferenceInformation.geneElement.element
            public ElementDefinitionInfo Element_Element;
            // 9. SubstanceReferenceInformation.geneElement.source
            public ElementDefinitionInfo Element_Source;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "SubstanceReferenceInformation.geneElement",
                    ElementId = "SubstanceReferenceInformation.geneElement"
                });
                Element_Type.Write(sDef);
                Element_Element.Write(sDef);
                Element_Source.Write(sDef);
            }
            
            public Type_GeneElement()
            {
                {
                    // 7. SubstanceReferenceInformation.geneElement.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "SubstanceReferenceInformation.geneElement.type",
                        Id = "SubstanceReferenceInformation.geneElement.type",
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
                    // 8. SubstanceReferenceInformation.geneElement.element
                    this.Element_Element = new ElementDefinitionInfo
                    {
                        Name = "Element_Element",
                        Path= "SubstanceReferenceInformation.geneElement.element",
                        Id = "SubstanceReferenceInformation.geneElement.element",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Identifier
                            {
                            }
                        }
                    };
                }
                {
                    // 9. SubstanceReferenceInformation.geneElement.source
                    this.Element_Source = new ElementDefinitionInfo
                    {
                        Name = "Element_Source",
                        Path= "SubstanceReferenceInformation.geneElement.source",
                        Id = "SubstanceReferenceInformation.geneElement.source",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                                }
                            }
                        }
                    };
                }
            }
        }
        // 10. SubstanceReferenceInformation.classification
        public class Type_Classification : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 11. SubstanceReferenceInformation.classification.domain
            public ElementDefinitionInfo Element_Domain;
            // 12. SubstanceReferenceInformation.classification.classification
            public ElementDefinitionInfo Element_Classification;
            // 13. SubstanceReferenceInformation.classification.subtype
            public ElementDefinitionInfo Element_Subtype;
            // 14. SubstanceReferenceInformation.classification.source
            public ElementDefinitionInfo Element_Source;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "SubstanceReferenceInformation.classification",
                    ElementId = "SubstanceReferenceInformation.classification"
                });
                Element_Domain.Write(sDef);
                Element_Classification.Write(sDef);
                Element_Subtype.Write(sDef);
                Element_Source.Write(sDef);
            }
            
            public Type_Classification()
            {
                {
                    // 11. SubstanceReferenceInformation.classification.domain
                    this.Element_Domain = new ElementDefinitionInfo
                    {
                        Name = "Element_Domain",
                        Path= "SubstanceReferenceInformation.classification.domain",
                        Id = "SubstanceReferenceInformation.classification.domain",
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
                    // 12. SubstanceReferenceInformation.classification.classification
                    this.Element_Classification = new ElementDefinitionInfo
                    {
                        Name = "Element_Classification",
                        Path= "SubstanceReferenceInformation.classification.classification",
                        Id = "SubstanceReferenceInformation.classification.classification",
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
                    // 13. SubstanceReferenceInformation.classification.subtype
                    this.Element_Subtype = new ElementDefinitionInfo
                    {
                        Name = "Element_Subtype",
                        Path= "SubstanceReferenceInformation.classification.subtype",
                        Id = "SubstanceReferenceInformation.classification.subtype",
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
                    // 14. SubstanceReferenceInformation.classification.source
                    this.Element_Source = new ElementDefinitionInfo
                    {
                        Name = "Element_Source",
                        Path= "SubstanceReferenceInformation.classification.source",
                        Id = "SubstanceReferenceInformation.classification.source",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                                }
                            }
                        }
                    };
                }
            }
        }
        // 15. SubstanceReferenceInformation.target
        public class Type_Target : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 16. SubstanceReferenceInformation.target.target
            public ElementDefinitionInfo Element_Target;
            // 17. SubstanceReferenceInformation.target.type
            public ElementDefinitionInfo Element_Type;
            // 18. SubstanceReferenceInformation.target.interaction
            public ElementDefinitionInfo Element_Interaction;
            // 19. SubstanceReferenceInformation.target.organism
            public ElementDefinitionInfo Element_Organism;
            // 20. SubstanceReferenceInformation.target.organismType
            public ElementDefinitionInfo Element_OrganismType;
            // 21. SubstanceReferenceInformation.target.amount[x]
            public ElementDefinitionInfo Element_Amount;
            // 22. SubstanceReferenceInformation.target.amountType
            public ElementDefinitionInfo Element_AmountType;
            // 23. SubstanceReferenceInformation.target.source
            public ElementDefinitionInfo Element_Source;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "SubstanceReferenceInformation.target",
                    ElementId = "SubstanceReferenceInformation.target"
                });
                Element_Target.Write(sDef);
                Element_Type.Write(sDef);
                Element_Interaction.Write(sDef);
                Element_Organism.Write(sDef);
                Element_OrganismType.Write(sDef);
                Element_Amount.Write(sDef);
                Element_AmountType.Write(sDef);
                Element_Source.Write(sDef);
            }
            
            public Type_Target()
            {
                {
                    // 16. SubstanceReferenceInformation.target.target
                    this.Element_Target = new ElementDefinitionInfo
                    {
                        Name = "Element_Target",
                        Path= "SubstanceReferenceInformation.target.target",
                        Id = "SubstanceReferenceInformation.target.target",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Identifier
                            {
                            }
                        }
                    };
                }
                {
                    // 17. SubstanceReferenceInformation.target.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "SubstanceReferenceInformation.target.type",
                        Id = "SubstanceReferenceInformation.target.type",
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
                    // 18. SubstanceReferenceInformation.target.interaction
                    this.Element_Interaction = new ElementDefinitionInfo
                    {
                        Name = "Element_Interaction",
                        Path= "SubstanceReferenceInformation.target.interaction",
                        Id = "SubstanceReferenceInformation.target.interaction",
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
                    // 19. SubstanceReferenceInformation.target.organism
                    this.Element_Organism = new ElementDefinitionInfo
                    {
                        Name = "Element_Organism",
                        Path= "SubstanceReferenceInformation.target.organism",
                        Id = "SubstanceReferenceInformation.target.organism",
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
                    // 20. SubstanceReferenceInformation.target.organismType
                    this.Element_OrganismType = new ElementDefinitionInfo
                    {
                        Name = "Element_OrganismType",
                        Path= "SubstanceReferenceInformation.target.organismType",
                        Id = "SubstanceReferenceInformation.target.organismType",
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
                    // 21. SubstanceReferenceInformation.target.amount[x]
                    this.Element_Amount = new ElementDefinitionInfo
                    {
                        Name = "Element_Amount",
                        Path= "SubstanceReferenceInformation.target.amount[x]",
                        Id = "SubstanceReferenceInformation.target.amount[x]",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Quantity
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Range
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_String
                            {
                            }
                        }
                    };
                }
                {
                    // 22. SubstanceReferenceInformation.target.amountType
                    this.Element_AmountType = new ElementDefinitionInfo
                    {
                        Name = "Element_AmountType",
                        Path= "SubstanceReferenceInformation.target.amountType",
                        Id = "SubstanceReferenceInformation.target.amountType",
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
                    // 23. SubstanceReferenceInformation.target.source
                    this.Element_Source = new ElementDefinitionInfo
                    {
                        Name = "Element_Source",
                        Path= "SubstanceReferenceInformation.target.source",
                        Id = "SubstanceReferenceInformation.target.source",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                                }
                            }
                        }
                    };
                }
            }
        }
        // 1. SubstanceReferenceInformation.comment
        public ElementDefinitionInfo Element_Comment;
        // 2. SubstanceReferenceInformation.gene
        public ElementDefinitionInfo Element_Gene;
        // 6. SubstanceReferenceInformation.geneElement
        public ElementDefinitionInfo Element_GeneElement;
        // 10. SubstanceReferenceInformation.classification
        public ElementDefinitionInfo Element_Classification;
        // 15. SubstanceReferenceInformation.target
        public ElementDefinitionInfo Element_Target;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "SubstanceReferenceInformation",
                ElementId = "SubstanceReferenceInformation"
            });
            Element_Comment.Write(sDef);
            Element_Gene.Write(sDef);
            Element_GeneElement.Write(sDef);
            Element_Classification.Write(sDef);
            Element_Target.Write(sDef);
        }
        
        public Resource_SubstanceReferenceInformation()
        {
            {
                // 1. SubstanceReferenceInformation.comment
                this.Element_Comment = new ElementDefinitionInfo
                {
                    Name = "Element_Comment",
                    Path= "SubstanceReferenceInformation.comment",
                    Id = "SubstanceReferenceInformation.comment",
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
                // 2. SubstanceReferenceInformation.gene
                this.Element_Gene = new ElementDefinitionInfo
                {
                    Name = "Element_Gene",
                    Path= "SubstanceReferenceInformation.gene",
                    Id = "SubstanceReferenceInformation.gene",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Gene
                        {
                        }
                    }
                };
            }
            {
                // 6. SubstanceReferenceInformation.geneElement
                this.Element_GeneElement = new ElementDefinitionInfo
                {
                    Name = "Element_GeneElement",
                    Path= "SubstanceReferenceInformation.geneElement",
                    Id = "SubstanceReferenceInformation.geneElement",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_GeneElement
                        {
                        }
                    }
                };
            }
            {
                // 10. SubstanceReferenceInformation.classification
                this.Element_Classification = new ElementDefinitionInfo
                {
                    Name = "Element_Classification",
                    Path= "SubstanceReferenceInformation.classification",
                    Id = "SubstanceReferenceInformation.classification",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Classification
                        {
                        }
                    }
                };
            }
            {
                // 15. SubstanceReferenceInformation.target
                this.Element_Target = new ElementDefinitionInfo
                {
                    Name = "Element_Target",
                    Path= "SubstanceReferenceInformation.target",
                    Id = "SubstanceReferenceInformation.target",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Target
                        {
                        }
                    }
                };
            }
            this.Name = "SubstanceReferenceInformation";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/SubstanceReferenceInformation";
        }
    }
}
