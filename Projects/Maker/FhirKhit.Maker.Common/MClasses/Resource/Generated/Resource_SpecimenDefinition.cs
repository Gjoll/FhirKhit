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
      "id": "SpecimenDefinition",
      "url": "http://hl7.org/fhir/StructureDefinition/SpecimenDefinition",
      "version": "4.0.0",
      "name": "SpecimenDefinition",
      "status": "draft",
      "publisher": "Health Level Seven International (Orders and Observations)",
      "description": "A kind of specimen with associated set of requirements.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "SpecimenDefinition",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "SpecimenDefinition",
            "path": "SpecimenDefinition",
            "short": "Kind of specimen",
            "definition": "A kind of specimen with associated set of requirements.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "SpecimenDefinition.identifier",
            "path": "SpecimenDefinition.identifier",
            "short": "Business identifier of a kind of specimen",
            "definition": "A business identifier associated with the kind of specimen.",
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
            "id": "SpecimenDefinition.typeCollected",
            "path": "SpecimenDefinition.typeCollected",
            "short": "Kind of material to collect",
            "definition": "The kind of material to be collected.",
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
                  "valueString": "CollectedSpecimenType"
                }
              ],
              "strength": "example",
              "description": "The type of the specimen to be collected.",
              "valueSet": "http://terminology.hl7.org/ValueSet/v2-0487"
            }
          },
          {
            "id": "SpecimenDefinition.patientPreparation",
            "path": "SpecimenDefinition.patientPreparation",
            "short": "Patient preparation for collection",
            "definition": "Preparation of the patient for specimen collection.",
            "min": 0,
            "max": "*",
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
                  "valueString": "PreparePatient"
                }
              ],
              "strength": "example",
              "description": "Checks on the patient prior specimen collection.",
              "valueSet": "http://hl7.org/fhir/ValueSet/prepare-patient-prior-specimen-collection"
            }
          },
          {
            "id": "SpecimenDefinition.timeAspect",
            "path": "SpecimenDefinition.timeAspect",
            "short": "Time aspect for collection",
            "definition": "Time aspect of specimen collection (duration or offset).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "example": [
              {
                "label": "General",
                "valueString": "24 hour, 20' post charge"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SpecimenDefinition.collection",
            "path": "SpecimenDefinition.collection",
            "short": "Specimen collection procedure",
            "definition": "The action to be performed for collecting the specimen.",
            "min": 0,
            "max": "*",
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
                  "valueString": "SpecimenCollection"
                }
              ],
              "strength": "example",
              "description": "The action to collect a type of specimen.",
              "valueSet": "http://hl7.org/fhir/ValueSet/specimen-collection"
            }
          },
          {
            "id": "SpecimenDefinition.typeTested",
            "path": "SpecimenDefinition.typeTested",
            "short": "Specimen in container intended for testing by lab",
            "definition": "Specimen conditioned in a container as expected by the testing laboratory.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "SpecimenDefinition.typeTested.isDerived",
            "path": "SpecimenDefinition.typeTested.isDerived",
            "short": "Primary or secondary specimen",
            "definition": "Primary of secondary specimen.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "example": [
              {
                "label": "General",
                "valueBoolean": false
              }
            ]
          },
          {
            "id": "SpecimenDefinition.typeTested.type",
            "path": "SpecimenDefinition.typeTested.type",
            "short": "Type of intended specimen",
            "definition": "The kind of specimen conditioned for testing expected by lab.",
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
                  "valueString": "IntendedSpecimenType"
                }
              ],
              "strength": "example",
              "description": "The type of specimen conditioned in a container for lab testing.",
              "valueSet": "http://terminology.hl7.org/ValueSet/v2-0487"
            }
          },
          {
            "id": "SpecimenDefinition.typeTested.preference",
            "path": "SpecimenDefinition.typeTested.preference",
            "short": "preferred | alternate",
            "definition": "The preference for this type of conditioned specimen.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "example": [
              {
                "label": "General",
                "valueCode": "preferred, alternate"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "SpecimenContainedPreference"
                }
              ],
              "strength": "required",
              "description": "Degree of preference of a type of conditioned specimen.",
              "valueSet": "http://hl7.org/fhir/ValueSet/specimen-contained-preference|4.0.0"
            }
          },
          {
            "id": "SpecimenDefinition.typeTested.container",
            "path": "SpecimenDefinition.typeTested.container",
            "short": "The specimen's container",
            "definition": "The specimen's container.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "SpecimenDefinition.typeTested.container.material",
            "path": "SpecimenDefinition.typeTested.container.material",
            "short": "Container material",
            "definition": "The type of material of the container.",
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
                  "valueString": "ContainerMaterial"
                }
              ],
              "strength": "example",
              "description": "Types of material for specimen containers.",
              "valueSet": "http://hl7.org/fhir/ValueSet/container-material"
            }
          },
          {
            "id": "SpecimenDefinition.typeTested.container.type",
            "path": "SpecimenDefinition.typeTested.container.type",
            "short": "Kind of container associated with the kind of specimen",
            "definition": "The type of container used to contain this kind of specimen.",
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
                  "valueString": "ContainerType"
                }
              ],
              "strength": "example",
              "description": "Type of specimen container.",
              "valueSet": "http://hl7.org/fhir/ValueSet/specimen-container-type"
            }
          },
          {
            "id": "SpecimenDefinition.typeTested.container.cap",
            "path": "SpecimenDefinition.typeTested.container.cap",
            "short": "Color of container cap",
            "definition": "Color of container cap.",
            "requirements": "From ISO 6710-2017 Table F.1 Recommended colour codes.",
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
                  "valueString": "ContainerCap"
                }
              ],
              "strength": "example",
              "description": "Color of the container cap.",
              "valueSet": "http://hl7.org/fhir/ValueSet/container-cap"
            }
          },
          {
            "id": "SpecimenDefinition.typeTested.container.description",
            "path": "SpecimenDefinition.typeTested.container.description",
            "short": "Container description",
            "definition": "The textual description of the kind of container.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "example": [
              {
                "label": "General",
                "valueString": "Blue top tube with citrate"
              }
            ]
          },
          {
            "id": "SpecimenDefinition.typeTested.container.capacity",
            "path": "SpecimenDefinition.typeTested.container.capacity",
            "short": "Container capacity",
            "definition": "The capacity (volume or other measure) of this kind of container.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity",
                "profile": [
                  "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
                ]
              }
            ]
          },
          {
            "id": "SpecimenDefinition.typeTested.container.minimumVolume[x]",
            "path": "SpecimenDefinition.typeTested.container.minimumVolume[x]",
            "short": "Minimum volume",
            "definition": "The minimum volume to be conditioned in the container.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity",
                "profile": [
                  "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
                ]
              },
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "SpecimenDefinition.typeTested.container.additive",
            "path": "SpecimenDefinition.typeTested.container.additive",
            "short": "Additive associated with container",
            "definition": "Substance introduced in the kind of container to preserve, maintain or enhance the specimen. Examples: Formalin, Citrate, EDTA.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "SpecimenDefinition.typeTested.container.additive.additive[x]",
            "path": "SpecimenDefinition.typeTested.container.additive.additive[x]",
            "short": "Additive associated with container",
            "definition": "Substance introduced in the kind of container to preserve, maintain or enhance the specimen. Examples: Formalin, Citrate, EDTA.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Substance"
                ]
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ContainerAdditive"
                }
              ],
              "strength": "example",
              "description": "Substance added to specimen container.",
              "valueSet": "http://terminology.hl7.org/ValueSet/v2-0371"
            }
          },
          {
            "id": "SpecimenDefinition.typeTested.container.preparation",
            "path": "SpecimenDefinition.typeTested.container.preparation",
            "short": "Specimen container preparation",
            "definition": "Special processing that should be applied to the container for this kind of specimen.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "SpecimenDefinition.typeTested.requirement",
            "path": "SpecimenDefinition.typeTested.requirement",
            "short": "Specimen requirements",
            "definition": "Requirements for delivery and special handling of this kind of conditioned specimen.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "SpecimenDefinition.typeTested.retentionTime",
            "path": "SpecimenDefinition.typeTested.retentionTime",
            "short": "Specimen retention time",
            "definition": "The usual time that a specimen of this kind is retained after the ordered tests are completed, for the purpose of additional testing.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Duration"
              }
            ]
          },
          {
            "id": "SpecimenDefinition.typeTested.rejectionCriterion",
            "path": "SpecimenDefinition.typeTested.rejectionCriterion",
            "short": "Rejection criterion",
            "definition": "Criterion for rejection of the specimen in its container by the laboratory.",
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
                  "valueString": "RejectionCriterion"
                }
              ],
              "strength": "example",
              "description": "Criterion for rejection of the specimen by laboratory.",
              "valueSet": "http://hl7.org/fhir/ValueSet/rejection-criteria"
            }
          },
          {
            "id": "SpecimenDefinition.typeTested.handling",
            "path": "SpecimenDefinition.typeTested.handling",
            "short": "Specimen handling before testing",
            "definition": "Set of instructions for preservation/transport of the specimen at a defined temperature interval, prior the testing process.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "SpecimenDefinition.typeTested.handling.temperatureQualifier",
            "path": "SpecimenDefinition.typeTested.handling.temperatureQualifier",
            "short": "Temperature qualifier",
            "definition": "It qualifies the interval of temperature, which characterizes an occurrence of handling. Conditions that are not related to temperature may be handled in the instruction element.",
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
                  "valueString": "HandlingConditionSet"
                }
              ],
              "strength": "example",
              "description": "Set of handling instructions prior testing of the specimen.",
              "valueSet": "http://hl7.org/fhir/ValueSet/handling-condition"
            }
          },
          {
            "id": "SpecimenDefinition.typeTested.handling.temperatureRange",
            "path": "SpecimenDefinition.typeTested.handling.temperatureRange",
            "short": "Temperature range",
            "definition": "The temperature interval for this set of handling instructions.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Range"
              }
            ]
          },
          {
            "id": "SpecimenDefinition.typeTested.handling.maxDuration",
            "path": "SpecimenDefinition.typeTested.handling.maxDuration",
            "short": "Maximum preservation time",
            "definition": "The maximum time interval of preservation of the specimen with these conditions.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Duration"
              }
            ]
          },
          {
            "id": "SpecimenDefinition.typeTested.handling.instruction",
            "path": "SpecimenDefinition.typeTested.handling.instruction",
            "short": "Preservation instruction",
            "definition": "Additional textual instructions for the preservation or transport of the specimen. For instance, 'Protect from light exposure'.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "example": [
              {
                "label": "General",
                "valueString": "freeze within 4 hours"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir resource 'SpecimenDefinition'
    /// </summary>
    // 0. SpecimenDefinition
    public partial class Resource_SpecimenDefinition : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 6. SpecimenDefinition.typeTested
        public partial class Type_TypeTested : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 10. SpecimenDefinition.typeTested.container
            public partial class Type_Container : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 17. SpecimenDefinition.typeTested.container.additive
                public partial class Type_Additive : FhirKhit.Maker.Common.Complex.ComplexBase
                {
                    // 18. SpecimenDefinition.typeTested.container.additive.additive[x]
                    public ElementDefinitionInfo Element_Additive;
                    
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                    {
                        base.Write(sDef);
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                        {
                            Path = "SpecimenDefinition.typeTested.container.additive",
                            ElementId = "SpecimenDefinition.typeTested.container.additive"
                        });
                        Element_Additive.Write(sDef);
                    }
                    
                    public Type_Additive()
                    {
                        {
                            // 18. SpecimenDefinition.typeTested.container.additive.additive[x]
                            this.Element_Additive = new ElementDefinitionInfo
                            {
                                Name = "Element_Additive",
                                Path= "SpecimenDefinition.typeTested.container.additive.additive[x]",
                                Id = "SpecimenDefinition.typeTested.container.additive.additive[x]",
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
                                            "http://hl7.org/fhir/StructureDefinition/Substance"
                                        }
                                    }
                                }
                            };
                        }
                    }
                }
                // 11. SpecimenDefinition.typeTested.container.material
                public ElementDefinitionInfo Element_Material;
                // 12. SpecimenDefinition.typeTested.container.type
                public ElementDefinitionInfo Element_Type;
                // 13. SpecimenDefinition.typeTested.container.cap
                public ElementDefinitionInfo Element_Cap;
                // 14. SpecimenDefinition.typeTested.container.description
                public ElementDefinitionInfo Element_Description;
                // 15. SpecimenDefinition.typeTested.container.capacity
                public ElementDefinitionInfo Element_Capacity;
                // 16. SpecimenDefinition.typeTested.container.minimumVolume[x]
                public ElementDefinitionInfo Element_MinimumVolume;
                // 17. SpecimenDefinition.typeTested.container.additive
                public ElementDefinitionInfo Element_Additive;
                // 19. SpecimenDefinition.typeTested.container.preparation
                public ElementDefinitionInfo Element_Preparation;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "SpecimenDefinition.typeTested.container",
                        ElementId = "SpecimenDefinition.typeTested.container"
                    });
                    Element_Material.Write(sDef);
                    Element_Type.Write(sDef);
                    Element_Cap.Write(sDef);
                    Element_Description.Write(sDef);
                    Element_Capacity.Write(sDef);
                    Element_MinimumVolume.Write(sDef);
                    Element_Additive.Write(sDef);
                    Element_Preparation.Write(sDef);
                }
                
                public Type_Container()
                {
                    {
                        // 11. SpecimenDefinition.typeTested.container.material
                        this.Element_Material = new ElementDefinitionInfo
                        {
                            Name = "Element_Material",
                            Path= "SpecimenDefinition.typeTested.container.material",
                            Id = "SpecimenDefinition.typeTested.container.material",
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
                        // 12. SpecimenDefinition.typeTested.container.type
                        this.Element_Type = new ElementDefinitionInfo
                        {
                            Name = "Element_Type",
                            Path= "SpecimenDefinition.typeTested.container.type",
                            Id = "SpecimenDefinition.typeTested.container.type",
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
                        // 13. SpecimenDefinition.typeTested.container.cap
                        this.Element_Cap = new ElementDefinitionInfo
                        {
                            Name = "Element_Cap",
                            Path= "SpecimenDefinition.typeTested.container.cap",
                            Id = "SpecimenDefinition.typeTested.container.cap",
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
                        // 14. SpecimenDefinition.typeTested.container.description
                        this.Element_Description = new ElementDefinitionInfo
                        {
                            Name = "Element_Description",
                            Path= "SpecimenDefinition.typeTested.container.description",
                            Id = "SpecimenDefinition.typeTested.container.description",
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
                        // 15. SpecimenDefinition.typeTested.container.capacity
                        this.Element_Capacity = new ElementDefinitionInfo
                        {
                            Name = "Element_Capacity",
                            Path= "SpecimenDefinition.typeTested.container.capacity",
                            Id = "SpecimenDefinition.typeTested.container.capacity",
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
                        // 16. SpecimenDefinition.typeTested.container.minimumVolume[x]
                        this.Element_MinimumVolume = new ElementDefinitionInfo
                        {
                            Name = "Element_MinimumVolume",
                            Path= "SpecimenDefinition.typeTested.container.minimumVolume[x]",
                            Id = "SpecimenDefinition.typeTested.container.minimumVolume[x]",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_Quantity
                                {
                                },
                                new FhirKhit.Maker.Common.Primitive.Primitive_String
                                {
                                }
                            }
                        };
                    }
                    {
                        // 17. SpecimenDefinition.typeTested.container.additive
                        this.Element_Additive = new ElementDefinitionInfo
                        {
                            Name = "Element_Additive",
                            Path= "SpecimenDefinition.typeTested.container.additive",
                            Id = "SpecimenDefinition.typeTested.container.additive",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new Type_Additive
                                {
                                }
                            }
                        };
                    }
                    {
                        // 19. SpecimenDefinition.typeTested.container.preparation
                        this.Element_Preparation = new ElementDefinitionInfo
                        {
                            Name = "Element_Preparation",
                            Path= "SpecimenDefinition.typeTested.container.preparation",
                            Id = "SpecimenDefinition.typeTested.container.preparation",
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
            // 23. SpecimenDefinition.typeTested.handling
            public partial class Type_Handling : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 24. SpecimenDefinition.typeTested.handling.temperatureQualifier
                public ElementDefinitionInfo Element_TemperatureQualifier;
                // 25. SpecimenDefinition.typeTested.handling.temperatureRange
                public ElementDefinitionInfo Element_TemperatureRange;
                // 26. SpecimenDefinition.typeTested.handling.maxDuration
                public ElementDefinitionInfo Element_MaxDuration;
                // 27. SpecimenDefinition.typeTested.handling.instruction
                public ElementDefinitionInfo Element_Instruction;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "SpecimenDefinition.typeTested.handling",
                        ElementId = "SpecimenDefinition.typeTested.handling"
                    });
                    Element_TemperatureQualifier.Write(sDef);
                    Element_TemperatureRange.Write(sDef);
                    Element_MaxDuration.Write(sDef);
                    Element_Instruction.Write(sDef);
                }
                
                public Type_Handling()
                {
                    {
                        // 24. SpecimenDefinition.typeTested.handling.temperatureQualifier
                        this.Element_TemperatureQualifier = new ElementDefinitionInfo
                        {
                            Name = "Element_TemperatureQualifier",
                            Path= "SpecimenDefinition.typeTested.handling.temperatureQualifier",
                            Id = "SpecimenDefinition.typeTested.handling.temperatureQualifier",
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
                        // 25. SpecimenDefinition.typeTested.handling.temperatureRange
                        this.Element_TemperatureRange = new ElementDefinitionInfo
                        {
                            Name = "Element_TemperatureRange",
                            Path= "SpecimenDefinition.typeTested.handling.temperatureRange",
                            Id = "SpecimenDefinition.typeTested.handling.temperatureRange",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_Range
                                {
                                }
                            }
                        };
                    }
                    {
                        // 26. SpecimenDefinition.typeTested.handling.maxDuration
                        this.Element_MaxDuration = new ElementDefinitionInfo
                        {
                            Name = "Element_MaxDuration",
                            Path= "SpecimenDefinition.typeTested.handling.maxDuration",
                            Id = "SpecimenDefinition.typeTested.handling.maxDuration",
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
                        // 27. SpecimenDefinition.typeTested.handling.instruction
                        this.Element_Instruction = new ElementDefinitionInfo
                        {
                            Name = "Element_Instruction",
                            Path= "SpecimenDefinition.typeTested.handling.instruction",
                            Id = "SpecimenDefinition.typeTested.handling.instruction",
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
            // 7. SpecimenDefinition.typeTested.isDerived
            public ElementDefinitionInfo Element_IsDerived;
            // 8. SpecimenDefinition.typeTested.type
            public ElementDefinitionInfo Element_Type;
            // 9. SpecimenDefinition.typeTested.preference
            public ElementDefinitionInfo Element_Preference;
            // 10. SpecimenDefinition.typeTested.container
            public ElementDefinitionInfo Element_Container;
            // 20. SpecimenDefinition.typeTested.requirement
            public ElementDefinitionInfo Element_Requirement;
            // 21. SpecimenDefinition.typeTested.retentionTime
            public ElementDefinitionInfo Element_RetentionTime;
            // 22. SpecimenDefinition.typeTested.rejectionCriterion
            public ElementDefinitionInfo Element_RejectionCriterion;
            // 23. SpecimenDefinition.typeTested.handling
            public ElementDefinitionInfo Element_Handling;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "SpecimenDefinition.typeTested",
                    ElementId = "SpecimenDefinition.typeTested"
                });
                Element_IsDerived.Write(sDef);
                Element_Type.Write(sDef);
                Element_Preference.Write(sDef);
                Element_Container.Write(sDef);
                Element_Requirement.Write(sDef);
                Element_RetentionTime.Write(sDef);
                Element_RejectionCriterion.Write(sDef);
                Element_Handling.Write(sDef);
            }
            
            public Type_TypeTested()
            {
                {
                    // 7. SpecimenDefinition.typeTested.isDerived
                    this.Element_IsDerived = new ElementDefinitionInfo
                    {
                        Name = "Element_IsDerived",
                        Path= "SpecimenDefinition.typeTested.isDerived",
                        Id = "SpecimenDefinition.typeTested.isDerived",
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
                    // 8. SpecimenDefinition.typeTested.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "SpecimenDefinition.typeTested.type",
                        Id = "SpecimenDefinition.typeTested.type",
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
                    // 9. SpecimenDefinition.typeTested.preference
                    this.Element_Preference = new ElementDefinitionInfo
                    {
                        Name = "Element_Preference",
                        Path= "SpecimenDefinition.typeTested.preference",
                        Id = "SpecimenDefinition.typeTested.preference",
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
                    // 10. SpecimenDefinition.typeTested.container
                    this.Element_Container = new ElementDefinitionInfo
                    {
                        Name = "Element_Container",
                        Path= "SpecimenDefinition.typeTested.container",
                        Id = "SpecimenDefinition.typeTested.container",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new Type_Container
                            {
                            }
                        }
                    };
                }
                {
                    // 20. SpecimenDefinition.typeTested.requirement
                    this.Element_Requirement = new ElementDefinitionInfo
                    {
                        Name = "Element_Requirement",
                        Path= "SpecimenDefinition.typeTested.requirement",
                        Id = "SpecimenDefinition.typeTested.requirement",
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
                    // 21. SpecimenDefinition.typeTested.retentionTime
                    this.Element_RetentionTime = new ElementDefinitionInfo
                    {
                        Name = "Element_RetentionTime",
                        Path= "SpecimenDefinition.typeTested.retentionTime",
                        Id = "SpecimenDefinition.typeTested.retentionTime",
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
                    // 22. SpecimenDefinition.typeTested.rejectionCriterion
                    this.Element_RejectionCriterion = new ElementDefinitionInfo
                    {
                        Name = "Element_RejectionCriterion",
                        Path= "SpecimenDefinition.typeTested.rejectionCriterion",
                        Id = "SpecimenDefinition.typeTested.rejectionCriterion",
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
                    // 23. SpecimenDefinition.typeTested.handling
                    this.Element_Handling = new ElementDefinitionInfo
                    {
                        Name = "Element_Handling",
                        Path= "SpecimenDefinition.typeTested.handling",
                        Id = "SpecimenDefinition.typeTested.handling",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Handling
                            {
                            }
                        }
                    };
                }
            }
        }
        // 1. SpecimenDefinition.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. SpecimenDefinition.typeCollected
        public ElementDefinitionInfo Element_TypeCollected;
        // 3. SpecimenDefinition.patientPreparation
        public ElementDefinitionInfo Element_PatientPreparation;
        // 4. SpecimenDefinition.timeAspect
        public ElementDefinitionInfo Element_TimeAspect;
        // 5. SpecimenDefinition.collection
        public ElementDefinitionInfo Element_Collection;
        // 6. SpecimenDefinition.typeTested
        public ElementDefinitionInfo Element_TypeTested;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "SpecimenDefinition",
                ElementId = "SpecimenDefinition"
            });
            Element_Identifier.Write(sDef);
            Element_TypeCollected.Write(sDef);
            Element_PatientPreparation.Write(sDef);
            Element_TimeAspect.Write(sDef);
            Element_Collection.Write(sDef);
            Element_TypeTested.Write(sDef);
        }
        
        public Resource_SpecimenDefinition()
        {
            {
                // 1. SpecimenDefinition.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "SpecimenDefinition.identifier",
                    Id = "SpecimenDefinition.identifier",
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
                // 2. SpecimenDefinition.typeCollected
                this.Element_TypeCollected = new ElementDefinitionInfo
                {
                    Name = "Element_TypeCollected",
                    Path= "SpecimenDefinition.typeCollected",
                    Id = "SpecimenDefinition.typeCollected",
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
                // 3. SpecimenDefinition.patientPreparation
                this.Element_PatientPreparation = new ElementDefinitionInfo
                {
                    Name = "Element_PatientPreparation",
                    Path= "SpecimenDefinition.patientPreparation",
                    Id = "SpecimenDefinition.patientPreparation",
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
                // 4. SpecimenDefinition.timeAspect
                this.Element_TimeAspect = new ElementDefinitionInfo
                {
                    Name = "Element_TimeAspect",
                    Path= "SpecimenDefinition.timeAspect",
                    Id = "SpecimenDefinition.timeAspect",
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
                // 5. SpecimenDefinition.collection
                this.Element_Collection = new ElementDefinitionInfo
                {
                    Name = "Element_Collection",
                    Path= "SpecimenDefinition.collection",
                    Id = "SpecimenDefinition.collection",
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
                // 6. SpecimenDefinition.typeTested
                this.Element_TypeTested = new ElementDefinitionInfo
                {
                    Name = "Element_TypeTested",
                    Path= "SpecimenDefinition.typeTested",
                    Id = "SpecimenDefinition.typeTested",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_TypeTested
                        {
                        }
                    }
                };
            }
            this.Name = "SpecimenDefinition";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/SpecimenDefinition";
        }
    }
}
