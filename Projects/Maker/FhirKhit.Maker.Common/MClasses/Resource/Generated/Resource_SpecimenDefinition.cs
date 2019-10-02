using System;                                                                                                                               // MakerGen.cs:435
using System.Diagnostics;                                                                                                                   // MakerGen.cs:436
using System.IO;                                                                                                                            // MakerGen.cs:437
using System.Linq;                                                                                                                          // MakerGen.cs:438
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:439
                                                                                                                                            // MakerGen.cs:440
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:441
{                                                                                                                                           // MakerGen.cs:442
    #region Json                                                                                                                            // MakerGen.cs:443
    #if NEVER                                                                                                                               // MakerGen.cs:444
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
    #endregion                                                                                                                              // MakerGen.cs:447
    /// <summary>
    /// Fhir resource 'SpecimenDefinition'
    /// </summary>
    // 0. SpecimenDefinition
    public class Resource_SpecimenDefinition : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                       // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        // 6. SpecimenDefinition.typeTested
        public class Type_TypeTested : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 10. SpecimenDefinition.typeTested.container
            public class Type_Container : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                // 17. SpecimenDefinition.typeTested.container.additive
                public class Type_Additive : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:383
                {                                                                                                                           // MakerGen.cs:384
                    // 18. SpecimenDefinition.typeTested.container.additive.additive[x]
                    public ElementDefinitionInfo Element_Additive;                                                                          // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                  // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:394
                            Path = "SpecimenDefinition.typeTested.container.additive",                                                      // MakerGen.cs:395
                            ElementId = "SpecimenDefinition.typeTested.container.additive"                                                  // MakerGen.cs:396
                        });                                                                                                                 // MakerGen.cs:397
                        Element_Additive.Write(sDef);                                                                                       // MakerGen.cs:223
                    }                                                                                                                       // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
                    public Type_Additive()                                                                                                  // MakerGen.cs:402
                    {                                                                                                                       // MakerGen.cs:403
                        {                                                                                                                   // MakerGen.cs:234
                            // 18. SpecimenDefinition.typeTested.container.additive.additive[x]
                            this.Element_Additive = new ElementDefinitionInfo                                                               // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                Name = "Element_Additive",                                                                                  // MakerGen.cs:238
                                Path= "SpecimenDefinition.typeTested.container.additive.additive[x]",                                       // MakerGen.cs:239
                                Id = "SpecimenDefinition.typeTested.container.additive.additive[x]",                                        // MakerGen.cs:240
                                Min = 1,                                                                                                    // MakerGen.cs:241
                                Max = 1,                                                                                                    // MakerGen.cs:242
                                Types = new BaseType[]                                                                                      // MakerGen.cs:243
                                {                                                                                                           // MakerGen.cs:244
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:318
                                    {                                                                                                       // MakerGen.cs:319
                                    },                                                                                                      // MakerGen.cs:322
                                    new FhirKhit.Maker.Common.Complex.Type_Reference                                                        // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Substance"                                             // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:246
                            };                                                                                                              // MakerGen.cs:247
                        }                                                                                                                   // MakerGen.cs:248
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:407
                // 11. SpecimenDefinition.typeTested.container.material
                public ElementDefinitionInfo Element_Material;                                                                              // MakerGen.cs:219
                // 12. SpecimenDefinition.typeTested.container.type
                public ElementDefinitionInfo Element_Type;                                                                                  // MakerGen.cs:219
                // 13. SpecimenDefinition.typeTested.container.cap
                public ElementDefinitionInfo Element_Cap;                                                                                   // MakerGen.cs:219
                // 14. SpecimenDefinition.typeTested.container.description
                public ElementDefinitionInfo Element_Description;                                                                           // MakerGen.cs:219
                // 15. SpecimenDefinition.typeTested.container.capacity
                public ElementDefinitionInfo Element_Capacity;                                                                              // MakerGen.cs:219
                // 16. SpecimenDefinition.typeTested.container.minimumVolume[x]
                public ElementDefinitionInfo Element_MinimumVolume;                                                                         // MakerGen.cs:219
                // 17. SpecimenDefinition.typeTested.container.additive
                public ElementDefinitionInfo Element_Additive;                                                                              // MakerGen.cs:219
                // 19. SpecimenDefinition.typeTested.container.preparation
                public ElementDefinitionInfo Element_Preparation;                                                                           // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:390
                {                                                                                                                           // MakerGen.cs:391
                    base.Write(sDef);                                                                                                       // MakerGen.cs:392
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        Path = "SpecimenDefinition.typeTested.container",                                                                   // MakerGen.cs:395
                        ElementId = "SpecimenDefinition.typeTested.container"                                                               // MakerGen.cs:396
                    });                                                                                                                     // MakerGen.cs:397
                    Element_Material.Write(sDef);                                                                                           // MakerGen.cs:223
                    Element_Type.Write(sDef);                                                                                               // MakerGen.cs:223
                    Element_Cap.Write(sDef);                                                                                                // MakerGen.cs:223
                    Element_Description.Write(sDef);                                                                                        // MakerGen.cs:223
                    Element_Capacity.Write(sDef);                                                                                           // MakerGen.cs:223
                    Element_MinimumVolume.Write(sDef);                                                                                      // MakerGen.cs:223
                    Element_Additive.Write(sDef);                                                                                           // MakerGen.cs:223
                    Element_Preparation.Write(sDef);                                                                                        // MakerGen.cs:223
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
                public Type_Container()                                                                                                     // MakerGen.cs:402
                {                                                                                                                           // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:234
                        // 11. SpecimenDefinition.typeTested.container.material
                        this.Element_Material = new ElementDefinitionInfo                                                                   // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Material",                                                                                      // MakerGen.cs:238
                            Path= "SpecimenDefinition.typeTested.container.material",                                                       // MakerGen.cs:239
                            Id = "SpecimenDefinition.typeTested.container.material",                                                        // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:318
                                {                                                                                                           // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:322
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 12. SpecimenDefinition.typeTested.container.type
                        this.Element_Type = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Type",                                                                                          // MakerGen.cs:238
                            Path= "SpecimenDefinition.typeTested.container.type",                                                           // MakerGen.cs:239
                            Id = "SpecimenDefinition.typeTested.container.type",                                                            // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:318
                                {                                                                                                           // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:322
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 13. SpecimenDefinition.typeTested.container.cap
                        this.Element_Cap = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Cap",                                                                                           // MakerGen.cs:238
                            Path= "SpecimenDefinition.typeTested.container.cap",                                                            // MakerGen.cs:239
                            Id = "SpecimenDefinition.typeTested.container.cap",                                                             // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:318
                                {                                                                                                           // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:322
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 14. SpecimenDefinition.typeTested.container.description
                        this.Element_Description = new ElementDefinitionInfo                                                                // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Description",                                                                                   // MakerGen.cs:238
                            Path= "SpecimenDefinition.typeTested.container.description",                                                    // MakerGen.cs:239
                            Id = "SpecimenDefinition.typeTested.container.description",                                                     // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Primitive.Primitive_String                                                        // MakerGen.cs:303
                                {                                                                                                           // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:307
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 15. SpecimenDefinition.typeTested.container.capacity
                        this.Element_Capacity = new ElementDefinitionInfo                                                                   // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Capacity",                                                                                      // MakerGen.cs:238
                            Path= "SpecimenDefinition.typeTested.container.capacity",                                                       // MakerGen.cs:239
                            Id = "SpecimenDefinition.typeTested.container.capacity",                                                        // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_Quantity                                                             // MakerGen.cs:358
                                {                                                                                                           // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:360
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 16. SpecimenDefinition.typeTested.container.minimumVolume[x]
                        this.Element_MinimumVolume = new ElementDefinitionInfo                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_MinimumVolume",                                                                                 // MakerGen.cs:238
                            Path= "SpecimenDefinition.typeTested.container.minimumVolume[x]",                                               // MakerGen.cs:239
                            Id = "SpecimenDefinition.typeTested.container.minimumVolume[x]",                                                // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_Quantity                                                             // MakerGen.cs:358
                                {                                                                                                           // MakerGen.cs:359
                                },                                                                                                          // MakerGen.cs:360
                                new FhirKhit.Maker.Common.Primitive.Primitive_String                                                        // MakerGen.cs:303
                                {                                                                                                           // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:307
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 17. SpecimenDefinition.typeTested.container.additive
                        this.Element_Additive = new ElementDefinitionInfo                                                                   // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Additive",                                                                                      // MakerGen.cs:238
                            Path= "SpecimenDefinition.typeTested.container.additive",                                                       // MakerGen.cs:239
                            Id = "SpecimenDefinition.typeTested.container.additive",                                                        // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = -1,                                                                                                       // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new Type_Additive                                                                                           // MakerGen.cs:262
                                {                                                                                                           // MakerGen.cs:263
                                }                                                                                                           // MakerGen.cs:264
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 19. SpecimenDefinition.typeTested.container.preparation
                        this.Element_Preparation = new ElementDefinitionInfo                                                                // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Preparation",                                                                                   // MakerGen.cs:238
                            Path= "SpecimenDefinition.typeTested.container.preparation",                                                    // MakerGen.cs:239
                            Id = "SpecimenDefinition.typeTested.container.preparation",                                                     // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Primitive.Primitive_String                                                        // MakerGen.cs:303
                                {                                                                                                           // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:307
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                }                                                                                                                           // MakerGen.cs:405
            }                                                                                                                               // MakerGen.cs:407
            // 23. SpecimenDefinition.typeTested.handling
            public class Type_Handling : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                // 24. SpecimenDefinition.typeTested.handling.temperatureQualifier
                public ElementDefinitionInfo Element_TemperatureQualifier;                                                                  // MakerGen.cs:219
                // 25. SpecimenDefinition.typeTested.handling.temperatureRange
                public ElementDefinitionInfo Element_TemperatureRange;                                                                      // MakerGen.cs:219
                // 26. SpecimenDefinition.typeTested.handling.maxDuration
                public ElementDefinitionInfo Element_MaxDuration;                                                                           // MakerGen.cs:219
                // 27. SpecimenDefinition.typeTested.handling.instruction
                public ElementDefinitionInfo Element_Instruction;                                                                           // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:390
                {                                                                                                                           // MakerGen.cs:391
                    base.Write(sDef);                                                                                                       // MakerGen.cs:392
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        Path = "SpecimenDefinition.typeTested.handling",                                                                    // MakerGen.cs:395
                        ElementId = "SpecimenDefinition.typeTested.handling"                                                                // MakerGen.cs:396
                    });                                                                                                                     // MakerGen.cs:397
                    Element_TemperatureQualifier.Write(sDef);                                                                               // MakerGen.cs:223
                    Element_TemperatureRange.Write(sDef);                                                                                   // MakerGen.cs:223
                    Element_MaxDuration.Write(sDef);                                                                                        // MakerGen.cs:223
                    Element_Instruction.Write(sDef);                                                                                        // MakerGen.cs:223
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
                public Type_Handling()                                                                                                      // MakerGen.cs:402
                {                                                                                                                           // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:234
                        // 24. SpecimenDefinition.typeTested.handling.temperatureQualifier
                        this.Element_TemperatureQualifier = new ElementDefinitionInfo                                                       // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_TemperatureQualifier",                                                                          // MakerGen.cs:238
                            Path= "SpecimenDefinition.typeTested.handling.temperatureQualifier",                                            // MakerGen.cs:239
                            Id = "SpecimenDefinition.typeTested.handling.temperatureQualifier",                                             // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:318
                                {                                                                                                           // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:322
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 25. SpecimenDefinition.typeTested.handling.temperatureRange
                        this.Element_TemperatureRange = new ElementDefinitionInfo                                                           // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_TemperatureRange",                                                                              // MakerGen.cs:238
                            Path= "SpecimenDefinition.typeTested.handling.temperatureRange",                                                // MakerGen.cs:239
                            Id = "SpecimenDefinition.typeTested.handling.temperatureRange",                                                 // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_Range                                                                // MakerGen.cs:358
                                {                                                                                                           // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:360
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 26. SpecimenDefinition.typeTested.handling.maxDuration
                        this.Element_MaxDuration = new ElementDefinitionInfo                                                                // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_MaxDuration",                                                                                   // MakerGen.cs:238
                            Path= "SpecimenDefinition.typeTested.handling.maxDuration",                                                     // MakerGen.cs:239
                            Id = "SpecimenDefinition.typeTested.handling.maxDuration",                                                      // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_Duration                                                             // MakerGen.cs:358
                                {                                                                                                           // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:360
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 27. SpecimenDefinition.typeTested.handling.instruction
                        this.Element_Instruction = new ElementDefinitionInfo                                                                // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Instruction",                                                                                   // MakerGen.cs:238
                            Path= "SpecimenDefinition.typeTested.handling.instruction",                                                     // MakerGen.cs:239
                            Id = "SpecimenDefinition.typeTested.handling.instruction",                                                      // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Primitive.Primitive_String                                                        // MakerGen.cs:303
                                {                                                                                                           // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:307
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                }                                                                                                                           // MakerGen.cs:405
            }                                                                                                                               // MakerGen.cs:407
            // 7. SpecimenDefinition.typeTested.isDerived
            public ElementDefinitionInfo Element_IsDerived;                                                                                 // MakerGen.cs:219
            // 8. SpecimenDefinition.typeTested.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:219
            // 9. SpecimenDefinition.typeTested.preference
            public ElementDefinitionInfo Element_Preference;                                                                                // MakerGen.cs:219
            // 10. SpecimenDefinition.typeTested.container
            public ElementDefinitionInfo Element_Container;                                                                                 // MakerGen.cs:219
            // 20. SpecimenDefinition.typeTested.requirement
            public ElementDefinitionInfo Element_Requirement;                                                                               // MakerGen.cs:219
            // 21. SpecimenDefinition.typeTested.retentionTime
            public ElementDefinitionInfo Element_RetentionTime;                                                                             // MakerGen.cs:219
            // 22. SpecimenDefinition.typeTested.rejectionCriterion
            public ElementDefinitionInfo Element_RejectionCriterion;                                                                        // MakerGen.cs:219
            // 23. SpecimenDefinition.typeTested.handling
            public ElementDefinitionInfo Element_Handling;                                                                                  // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "SpecimenDefinition.typeTested",                                                                                 // MakerGen.cs:395
                    ElementId = "SpecimenDefinition.typeTested"                                                                             // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_IsDerived.Write(sDef);                                                                                              // MakerGen.cs:223
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:223
                Element_Preference.Write(sDef);                                                                                             // MakerGen.cs:223
                Element_Container.Write(sDef);                                                                                              // MakerGen.cs:223
                Element_Requirement.Write(sDef);                                                                                            // MakerGen.cs:223
                Element_RetentionTime.Write(sDef);                                                                                          // MakerGen.cs:223
                Element_RejectionCriterion.Write(sDef);                                                                                     // MakerGen.cs:223
                Element_Handling.Write(sDef);                                                                                               // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_TypeTested()                                                                                                        // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 7. SpecimenDefinition.typeTested.isDerived
                    this.Element_IsDerived = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_IsDerived",                                                                                         // MakerGen.cs:238
                        Path= "SpecimenDefinition.typeTested.isDerived",                                                                    // MakerGen.cs:239
                        Id = "SpecimenDefinition.typeTested.isDerived",                                                                     // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                           // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 8. SpecimenDefinition.typeTested.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Type",                                                                                              // MakerGen.cs:238
                        Path= "SpecimenDefinition.typeTested.type",                                                                         // MakerGen.cs:239
                        Id = "SpecimenDefinition.typeTested.type",                                                                          // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 9. SpecimenDefinition.typeTested.preference
                    this.Element_Preference = new ElementDefinitionInfo                                                                     // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Preference",                                                                                        // MakerGen.cs:238
                        Path= "SpecimenDefinition.typeTested.preference",                                                                   // MakerGen.cs:239
                        Id = "SpecimenDefinition.typeTested.preference",                                                                    // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                              // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 10. SpecimenDefinition.typeTested.container
                    this.Element_Container = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Container",                                                                                         // MakerGen.cs:238
                        Path= "SpecimenDefinition.typeTested.container",                                                                    // MakerGen.cs:239
                        Id = "SpecimenDefinition.typeTested.container",                                                                     // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new Type_Container                                                                                              // MakerGen.cs:262
                            {                                                                                                               // MakerGen.cs:263
                            }                                                                                                               // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 20. SpecimenDefinition.typeTested.requirement
                    this.Element_Requirement = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Requirement",                                                                                       // MakerGen.cs:238
                        Path= "SpecimenDefinition.typeTested.requirement",                                                                  // MakerGen.cs:239
                        Id = "SpecimenDefinition.typeTested.requirement",                                                                   // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 21. SpecimenDefinition.typeTested.retentionTime
                    this.Element_RetentionTime = new ElementDefinitionInfo                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_RetentionTime",                                                                                     // MakerGen.cs:238
                        Path= "SpecimenDefinition.typeTested.retentionTime",                                                                // MakerGen.cs:239
                        Id = "SpecimenDefinition.typeTested.retentionTime",                                                                 // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Duration                                                                 // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 22. SpecimenDefinition.typeTested.rejectionCriterion
                    this.Element_RejectionCriterion = new ElementDefinitionInfo                                                             // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_RejectionCriterion",                                                                                // MakerGen.cs:238
                        Path= "SpecimenDefinition.typeTested.rejectionCriterion",                                                           // MakerGen.cs:239
                        Id = "SpecimenDefinition.typeTested.rejectionCriterion",                                                            // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 23. SpecimenDefinition.typeTested.handling
                    this.Element_Handling = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Handling",                                                                                          // MakerGen.cs:238
                        Path= "SpecimenDefinition.typeTested.handling",                                                                     // MakerGen.cs:239
                        Id = "SpecimenDefinition.typeTested.handling",                                                                      // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new Type_Handling                                                                                               // MakerGen.cs:262
                            {                                                                                                               // MakerGen.cs:263
                            }                                                                                                               // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 1. SpecimenDefinition.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:219
        // 2. SpecimenDefinition.typeCollected
        public ElementDefinitionInfo Element_TypeCollected;                                                                                 // MakerGen.cs:219
        // 3. SpecimenDefinition.patientPreparation
        public ElementDefinitionInfo Element_PatientPreparation;                                                                            // MakerGen.cs:219
        // 4. SpecimenDefinition.timeAspect
        public ElementDefinitionInfo Element_TimeAspect;                                                                                    // MakerGen.cs:219
        // 5. SpecimenDefinition.collection
        public ElementDefinitionInfo Element_Collection;                                                                                    // MakerGen.cs:219
        // 6. SpecimenDefinition.typeTested
        public ElementDefinitionInfo Element_TypeTested;                                                                                    // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:390
        {                                                                                                                                   // MakerGen.cs:391
            base.Write(sDef);                                                                                                               // MakerGen.cs:392
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                Path = "SpecimenDefinition",                                                                                                // MakerGen.cs:395
                ElementId = "SpecimenDefinition"                                                                                            // MakerGen.cs:396
            });                                                                                                                             // MakerGen.cs:397
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_TypeCollected.Write(sDef);                                                                                              // MakerGen.cs:223
            Element_PatientPreparation.Write(sDef);                                                                                         // MakerGen.cs:223
            Element_TimeAspect.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Collection.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_TypeTested.Write(sDef);                                                                                                 // MakerGen.cs:223
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
        public Resource_SpecimenDefinition()                                                                                                // MakerGen.cs:402
        {                                                                                                                                   // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:234
                // 1. SpecimenDefinition.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:238
                    Path= "SpecimenDefinition.identifier",                                                                                  // MakerGen.cs:239
                    Id = "SpecimenDefinition.identifier",                                                                                   // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 2. SpecimenDefinition.typeCollected
                this.Element_TypeCollected = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_TypeCollected",                                                                                         // MakerGen.cs:238
                    Path= "SpecimenDefinition.typeCollected",                                                                               // MakerGen.cs:239
                    Id = "SpecimenDefinition.typeCollected",                                                                                // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 3. SpecimenDefinition.patientPreparation
                this.Element_PatientPreparation = new ElementDefinitionInfo                                                                 // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_PatientPreparation",                                                                                    // MakerGen.cs:238
                    Path= "SpecimenDefinition.patientPreparation",                                                                          // MakerGen.cs:239
                    Id = "SpecimenDefinition.patientPreparation",                                                                           // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 4. SpecimenDefinition.timeAspect
                this.Element_TimeAspect = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_TimeAspect",                                                                                            // MakerGen.cs:238
                    Path= "SpecimenDefinition.timeAspect",                                                                                  // MakerGen.cs:239
                    Id = "SpecimenDefinition.timeAspect",                                                                                   // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 5. SpecimenDefinition.collection
                this.Element_Collection = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Collection",                                                                                            // MakerGen.cs:238
                    Path= "SpecimenDefinition.collection",                                                                                  // MakerGen.cs:239
                    Id = "SpecimenDefinition.collection",                                                                                   // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 6. SpecimenDefinition.typeTested
                this.Element_TypeTested = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_TypeTested",                                                                                            // MakerGen.cs:238
                    Path= "SpecimenDefinition.typeTested",                                                                                  // MakerGen.cs:239
                    Id = "SpecimenDefinition.typeTested",                                                                                   // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_TypeTested                                                                                                 // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            this.Name = "SpecimenDefinition";                                                                                               // MakerGen.cs:471
            this.Uri = "http://hl7.org/fhir/StructureDefinition/SpecimenDefinition";                                                        // MakerGen.cs:472
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:407
}                                                                                                                                           // MakerGen.cs:452
