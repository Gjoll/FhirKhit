using System;                                                                                                                               // MakerGen.cs:399
using System.Diagnostics;                                                                                                                   // MakerGen.cs:400
using System.IO;                                                                                                                            // MakerGen.cs:401
using System.Linq;                                                                                                                          // MakerGen.cs:402
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:403
                                                                                                                                            // MakerGen.cs:404
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:405
{                                                                                                                                           // MakerGen.cs:406
    #region Json                                                                                                                            // MakerGen.cs:407
    #if NEVER                                                                                                                               // MakerGen.cs:408
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
    #endregion                                                                                                                              // MakerGen.cs:411
    /// <summary>
    /// Fhir resource 'SpecimenDefinition'
    /// </summary>
    // 0. SpecimenDefinition
    public class SpecimenDefinition : FhirKhit.Maker.Common.Resource.ResourceBase                                                           // MakerGen.cs:360
    {                                                                                                                                       // MakerGen.cs:361
        // 6. SpecimenDefinition.typeTested
        public class Type_TypeTested : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:360
        {                                                                                                                                   // MakerGen.cs:361
            // 10. SpecimenDefinition.typeTested.container
            public class Type_Container : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:360
            {                                                                                                                               // MakerGen.cs:361
                // 17. SpecimenDefinition.typeTested.container.additive
                public class Type_Additive : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:360
                {                                                                                                                           // MakerGen.cs:361
                    // 18. SpecimenDefinition.typeTested.container.additive.additive[x]
                    public MakerElementInstance Element_Additive;                                                                           // MakerGen.cs:232
                    public Type_Additive()                                                                                                  // MakerGen.cs:369
                    {                                                                                                                       // MakerGen.cs:370
                        {                                                                                                                   // MakerGen.cs:243
                            // 18. SpecimenDefinition.typeTested.container.additive.additive[x]
                            this.Element_Additive = new MakerElementInstance                                                                // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Additive",                                                                                  // MakerGen.cs:247
                                Min = 1,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBaseType[]                                                                                 // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:297
                                    {                                                                                                       // MakerGen.cs:298
                                    },                                                                                                      // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:342
                    }                                                                                                                       // MakerGen.cs:381
                }                                                                                                                           // MakerGen.cs:365
                // 11. SpecimenDefinition.typeTested.container.material
                public MakerElementInstance Element_Material;                                                                               // MakerGen.cs:232
                // 12. SpecimenDefinition.typeTested.container.type
                public MakerElementInstance Element_Type;                                                                                   // MakerGen.cs:232
                // 13. SpecimenDefinition.typeTested.container.cap
                public MakerElementInstance Element_Cap;                                                                                    // MakerGen.cs:232
                // 14. SpecimenDefinition.typeTested.container.description
                public MakerElementInstance Element_Description;                                                                            // MakerGen.cs:232
                // 15. SpecimenDefinition.typeTested.container.capacity
                public MakerElementInstance Element_Capacity;                                                                               // MakerGen.cs:232
                // 16. SpecimenDefinition.typeTested.container.minimumVolume[x]
                public MakerElementInstance Element_MinimumVolume;                                                                          // MakerGen.cs:232
                // 19. SpecimenDefinition.typeTested.container.preparation
                public MakerElementInstance Element_Preparation;                                                                            // MakerGen.cs:232
                public Type_Container()                                                                                                     // MakerGen.cs:369
                {                                                                                                                           // MakerGen.cs:370
                    {                                                                                                                       // MakerGen.cs:243
                        // 11. SpecimenDefinition.typeTested.container.material
                        this.Element_Material = new MakerElementInstance                                                                    // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Material",                                                                                      // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept                                                           // MakerGen.cs:297
                                {                                                                                                           // MakerGen.cs:298
                                }                                                                                                           // MakerGen.cs:299
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:342
                    {                                                                                                                       // MakerGen.cs:243
                        // 12. SpecimenDefinition.typeTested.container.type
                        this.Element_Type = new MakerElementInstance                                                                        // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Type",                                                                                          // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept                                                           // MakerGen.cs:297
                                {                                                                                                           // MakerGen.cs:298
                                }                                                                                                           // MakerGen.cs:299
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:342
                    {                                                                                                                       // MakerGen.cs:243
                        // 13. SpecimenDefinition.typeTested.container.cap
                        this.Element_Cap = new MakerElementInstance                                                                         // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Cap",                                                                                           // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept                                                           // MakerGen.cs:297
                                {                                                                                                           // MakerGen.cs:298
                                }                                                                                                           // MakerGen.cs:299
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:342
                    {                                                                                                                       // MakerGen.cs:243
                        // 14. SpecimenDefinition.typeTested.container.description
                        this.Element_Description = new MakerElementInstance                                                                 // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Description",                                                                                   // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.String                                                                  // MakerGen.cs:287
                                {                                                                                                           // MakerGen.cs:288
                                }                                                                                                           // MakerGen.cs:289
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:342
                    {                                                                                                                       // MakerGen.cs:243
                        // 15. SpecimenDefinition.typeTested.container.capacity
                        this.Element_Capacity = new MakerElementInstance                                                                    // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Capacity",                                                                                      // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:342
                    {                                                                                                                       // MakerGen.cs:243
                        // 16. SpecimenDefinition.typeTested.container.minimumVolume[x]
                        this.Element_MinimumVolume = new MakerElementInstance                                                               // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_MinimumVolume",                                                                                 // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.String                                                                  // MakerGen.cs:287
                                {                                                                                                           // MakerGen.cs:288
                                }                                                                                                           // MakerGen.cs:289
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:342
                    {                                                                                                                       // MakerGen.cs:243
                        // 19. SpecimenDefinition.typeTested.container.preparation
                        this.Element_Preparation = new MakerElementInstance                                                                 // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Preparation",                                                                                   // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.String                                                                  // MakerGen.cs:287
                                {                                                                                                           // MakerGen.cs:288
                                }                                                                                                           // MakerGen.cs:289
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:342
                }                                                                                                                           // MakerGen.cs:381
            }                                                                                                                               // MakerGen.cs:365
            // 23. SpecimenDefinition.typeTested.handling
            public class Type_Handling : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:360
            {                                                                                                                               // MakerGen.cs:361
                // 24. SpecimenDefinition.typeTested.handling.temperatureQualifier
                public MakerElementInstance Element_TemperatureQualifier;                                                                   // MakerGen.cs:232
                // 25. SpecimenDefinition.typeTested.handling.temperatureRange
                public MakerElementInstance Element_TemperatureRange;                                                                       // MakerGen.cs:232
                // 26. SpecimenDefinition.typeTested.handling.maxDuration
                public MakerElementInstance Element_MaxDuration;                                                                            // MakerGen.cs:232
                // 27. SpecimenDefinition.typeTested.handling.instruction
                public MakerElementInstance Element_Instruction;                                                                            // MakerGen.cs:232
                public Type_Handling()                                                                                                      // MakerGen.cs:369
                {                                                                                                                           // MakerGen.cs:370
                    {                                                                                                                       // MakerGen.cs:243
                        // 24. SpecimenDefinition.typeTested.handling.temperatureQualifier
                        this.Element_TemperatureQualifier = new MakerElementInstance                                                        // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_TemperatureQualifier",                                                                          // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept                                                           // MakerGen.cs:297
                                {                                                                                                           // MakerGen.cs:298
                                }                                                                                                           // MakerGen.cs:299
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:342
                    {                                                                                                                       // MakerGen.cs:243
                        // 25. SpecimenDefinition.typeTested.handling.temperatureRange
                        this.Element_TemperatureRange = new MakerElementInstance                                                            // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_TemperatureRange",                                                                              // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:342
                    {                                                                                                                       // MakerGen.cs:243
                        // 26. SpecimenDefinition.typeTested.handling.maxDuration
                        this.Element_MaxDuration = new MakerElementInstance                                                                 // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_MaxDuration",                                                                                   // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:342
                    {                                                                                                                       // MakerGen.cs:243
                        // 27. SpecimenDefinition.typeTested.handling.instruction
                        this.Element_Instruction = new MakerElementInstance                                                                 // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Instruction",                                                                                   // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.String                                                                  // MakerGen.cs:287
                                {                                                                                                           // MakerGen.cs:288
                                }                                                                                                           // MakerGen.cs:289
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:342
                }                                                                                                                           // MakerGen.cs:381
            }                                                                                                                               // MakerGen.cs:365
            // 7. SpecimenDefinition.typeTested.isDerived
            public MakerElementInstance Element_IsDerived;                                                                                  // MakerGen.cs:232
            // 8. SpecimenDefinition.typeTested.type
            public MakerElementInstance Element_Type;                                                                                       // MakerGen.cs:232
            // 9. SpecimenDefinition.typeTested.preference
            public MakerElementInstance Element_Preference;                                                                                 // MakerGen.cs:232
            // 20. SpecimenDefinition.typeTested.requirement
            public MakerElementInstance Element_Requirement;                                                                                // MakerGen.cs:232
            // 21. SpecimenDefinition.typeTested.retentionTime
            public MakerElementInstance Element_RetentionTime;                                                                              // MakerGen.cs:232
            // 22. SpecimenDefinition.typeTested.rejectionCriterion
            public MakerElementInstance Element_RejectionCriterion;                                                                         // MakerGen.cs:232
            public Type_TypeTested()                                                                                                        // MakerGen.cs:369
            {                                                                                                                               // MakerGen.cs:370
                {                                                                                                                           // MakerGen.cs:243
                    // 7. SpecimenDefinition.typeTested.isDerived
                    this.Element_IsDerived = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_IsDerived",                                                                                         // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 8. SpecimenDefinition.typeTested.type
                    this.Element_Type = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Type",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:297
                            {                                                                                                               // MakerGen.cs:298
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 9. SpecimenDefinition.typeTested.preference
                    this.Element_Preference = new MakerElementInstance                                                                      // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Preference",                                                                                        // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 20. SpecimenDefinition.typeTested.requirement
                    this.Element_Requirement = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Requirement",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 21. SpecimenDefinition.typeTested.retentionTime
                    this.Element_RetentionTime = new MakerElementInstance                                                                   // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_RetentionTime",                                                                                     // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 22. SpecimenDefinition.typeTested.rejectionCriterion
                    this.Element_RejectionCriterion = new MakerElementInstance                                                              // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_RejectionCriterion",                                                                                // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:297
                            {                                                                                                               // MakerGen.cs:298
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
            }                                                                                                                               // MakerGen.cs:381
        }                                                                                                                                   // MakerGen.cs:365
        // 1. SpecimenDefinition.identifier
        public MakerElementInstance Element_Identifier;                                                                                     // MakerGen.cs:232
        // 2. SpecimenDefinition.typeCollected
        public MakerElementInstance Element_TypeCollected;                                                                                  // MakerGen.cs:232
        // 3. SpecimenDefinition.patientPreparation
        public MakerElementInstance Element_PatientPreparation;                                                                             // MakerGen.cs:232
        // 4. SpecimenDefinition.timeAspect
        public MakerElementInstance Element_TimeAspect;                                                                                     // MakerGen.cs:232
        // 5. SpecimenDefinition.collection
        public MakerElementInstance Element_Collection;                                                                                     // MakerGen.cs:232
        public SpecimenDefinition()                                                                                                         // MakerGen.cs:369
        {                                                                                                                                   // MakerGen.cs:370
            {                                                                                                                               // MakerGen.cs:243
                // 1. SpecimenDefinition.identifier
                this.Element_Identifier = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 2. SpecimenDefinition.typeCollected
                this.Element_TypeCollected = new MakerElementInstance                                                                       // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_TypeCollected",                                                                                         // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 3. SpecimenDefinition.patientPreparation
                this.Element_PatientPreparation = new MakerElementInstance                                                                  // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_PatientPreparation",                                                                                    // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 4. SpecimenDefinition.timeAspect
                this.Element_TimeAspect = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_TimeAspect",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String                                                                          // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 5. SpecimenDefinition.collection
                this.Element_Collection = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Collection",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
        }                                                                                                                                   // MakerGen.cs:381
    }                                                                                                                                       // MakerGen.cs:365
}                                                                                                                                           // MakerGen.cs:416
