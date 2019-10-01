using System;                                                                                                                               // MakerGen.cs:449
using System.Diagnostics;                                                                                                                   // MakerGen.cs:450
using System.IO;                                                                                                                            // MakerGen.cs:451
using System.Linq;                                                                                                                          // MakerGen.cs:452
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:453
                                                                                                                                            // MakerGen.cs:454
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:455
{                                                                                                                                           // MakerGen.cs:456
    #region Json                                                                                                                            // MakerGen.cs:457
    #if NEVER                                                                                                                               // MakerGen.cs:458
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
    #endregion                                                                                                                              // MakerGen.cs:461
    /// <summary>
    /// Fhir resource 'SpecimenDefinition'
    /// </summary>
    // 0. SpecimenDefinition
    public class SpecimenDefinition : FhirKhit.Maker.Common.Resource.ResourceBase                                                           // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        public class SpecimenDefinition_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                              // MakerGen.cs:385
        {                                                                                                                                   // MakerGen.cs:386
            // 6. SpecimenDefinition.typeTested
            public class Type_TypeTested : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_TypeTested_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                         // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 10. SpecimenDefinition.typeTested.container
                    public class Type_Container : FhirKhit.Maker.Common.Complex.ComplexBase                                                 // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        public class Type_Container_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                  // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:386
                            // 17. SpecimenDefinition.typeTested.container.additive
                            public class Type_Additive : FhirKhit.Maker.Common.Complex.ComplexBase                                          // MakerGen.cs:383
                            {                                                                                                               // MakerGen.cs:384
                                public class Type_Additive_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                           // MakerGen.cs:385
                                {                                                                                                           // MakerGen.cs:386
                                    // 18. SpecimenDefinition.typeTested.container.additive.additive[x]
                                    public ElementDefinitionInfo Additive;                                                                  // MakerGen.cs:216
                                    public Type_Additive_Elements()                                                                         // MakerGen.cs:407
                                    {                                                                                                       // MakerGen.cs:408
                                        {                                                                                                   // MakerGen.cs:231
                                            // 18. SpecimenDefinition.typeTested.container.additive.additive[x]
                                            this.Additive = new ElementDefinitionInfo                                                       // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Additive",                                                                          // MakerGen.cs:235
                                                Path= "SpecimenDefinition.typeTested.container.additive.additive[x]",                       // MakerGen.cs:236
                                                Id = "SpecimenDefinition.typeTested.container.additive.additive[x]",                        // MakerGen.cs:237
                                                Min = 1,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                       // MakerGen.cs:315
                                                    {                                                                                       // MakerGen.cs:316
                                                    },                                                                                      // MakerGen.cs:319
                                                    new FhirKhit.Maker.Common.Complex.Reference                                             // MakerGen.cs:346
                                                    {                                                                                       // MakerGen.cs:347
                                                        TargetProfile = new String[]                                                        // MakerGen.cs:349
                                                        {                                                                                   // CodeEditorExtensions.cs:28
                                                            "http://hl7.org/fhir/StructureDefinition/Substance"                             // MakerGen.cs:349
                                                        }                                                                                   // CodeEditorExtensions.cs:34
                                                    }                                                                                       // MakerGen.cs:350
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                    }                                                                                                       // MakerGen.cs:427
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:412
                                    {                                                                                                       // MakerGen.cs:413
                                        base.Write(sDef);                                                                                   // MakerGen.cs:414
                                        Additive.Write(sDef);                                                                               // MakerGen.cs:220
                                    }                                                                                                       // MakerGen.cs:431
                                }                                                                                                           // MakerGen.cs:391
                                public Type_Additive_Elements Elements { get; }                                                             // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                                public Type_Additive()                                                                                      // MakerGen.cs:394
                                {                                                                                                           // MakerGen.cs:395
                                    this.Elements = new Type_Additive_Elements();                                                           // MakerGen.cs:396
                                }                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:399
                                {                                                                                                           // MakerGen.cs:400
                                    this.Elements.Write(sDef);                                                                              // MakerGen.cs:401
                                }                                                                                                           // MakerGen.cs:402
                            }                                                                                                               // MakerGen.cs:403
                            // 11. SpecimenDefinition.typeTested.container.material
                            public ElementDefinitionInfo Material;                                                                          // MakerGen.cs:216
                            // 12. SpecimenDefinition.typeTested.container.type
                            public ElementDefinitionInfo Type;                                                                              // MakerGen.cs:216
                            // 13. SpecimenDefinition.typeTested.container.cap
                            public ElementDefinitionInfo Cap;                                                                               // MakerGen.cs:216
                            // 14. SpecimenDefinition.typeTested.container.description
                            public ElementDefinitionInfo Description;                                                                       // MakerGen.cs:216
                            // 15. SpecimenDefinition.typeTested.container.capacity
                            public ElementDefinitionInfo Capacity;                                                                          // MakerGen.cs:216
                            // 16. SpecimenDefinition.typeTested.container.minimumVolume[x]
                            public ElementDefinitionInfo MinimumVolume;                                                                     // MakerGen.cs:216
                            // 17. SpecimenDefinition.typeTested.container.additive
                            public ElementDefinitionInfo Additive;                                                                          // MakerGen.cs:216
                            // 19. SpecimenDefinition.typeTested.container.preparation
                            public ElementDefinitionInfo Preparation;                                                                       // MakerGen.cs:216
                            public Type_Container_Elements()                                                                                // MakerGen.cs:407
                            {                                                                                                               // MakerGen.cs:408
                                {                                                                                                           // MakerGen.cs:231
                                    // 11. SpecimenDefinition.typeTested.container.material
                                    this.Material = new ElementDefinitionInfo                                                               // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Material",                                                                                  // MakerGen.cs:235
                                        Path= "SpecimenDefinition.typeTested.container.material",                                           // MakerGen.cs:236
                                        Id = "SpecimenDefinition.typeTested.container.material",                                            // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 12. SpecimenDefinition.typeTested.container.type
                                    this.Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Type",                                                                                      // MakerGen.cs:235
                                        Path= "SpecimenDefinition.typeTested.container.type",                                               // MakerGen.cs:236
                                        Id = "SpecimenDefinition.typeTested.container.type",                                                // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 13. SpecimenDefinition.typeTested.container.cap
                                    this.Cap = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Cap",                                                                                       // MakerGen.cs:235
                                        Path= "SpecimenDefinition.typeTested.container.cap",                                                // MakerGen.cs:236
                                        Id = "SpecimenDefinition.typeTested.container.cap",                                                 // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 14. SpecimenDefinition.typeTested.container.description
                                    this.Description = new ElementDefinitionInfo                                                            // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Description",                                                                               // MakerGen.cs:235
                                        Path= "SpecimenDefinition.typeTested.container.description",                                        // MakerGen.cs:236
                                        Id = "SpecimenDefinition.typeTested.container.description",                                         // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 15. SpecimenDefinition.typeTested.container.capacity
                                    this.Capacity = new ElementDefinitionInfo                                                               // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Capacity",                                                                                  // MakerGen.cs:235
                                        Path= "SpecimenDefinition.typeTested.container.capacity",                                           // MakerGen.cs:236
                                        Id = "SpecimenDefinition.typeTested.container.capacity",                                            // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.Quantity                                                      // MakerGen.cs:358
                                            {                                                                                               // MakerGen.cs:359
                                            }                                                                                               // MakerGen.cs:360
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 16. SpecimenDefinition.typeTested.container.minimumVolume[x]
                                    this.MinimumVolume = new ElementDefinitionInfo                                                          // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "MinimumVolume",                                                                             // MakerGen.cs:235
                                        Path= "SpecimenDefinition.typeTested.container.minimumVolume[x]",                                   // MakerGen.cs:236
                                        Id = "SpecimenDefinition.typeTested.container.minimumVolume[x]",                                    // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.Quantity                                                      // MakerGen.cs:358
                                            {                                                                                               // MakerGen.cs:359
                                            },                                                                                              // MakerGen.cs:360
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 17. SpecimenDefinition.typeTested.container.additive
                                    this.Additive = new ElementDefinitionInfo                                                               // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Additive",                                                                                  // MakerGen.cs:235
                                        Path= "SpecimenDefinition.typeTested.container.additive",                                           // MakerGen.cs:236
                                        Id = "SpecimenDefinition.typeTested.container.additive",                                            // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new Type_Additive                                                                               // MakerGen.cs:259
                                            {                                                                                               // MakerGen.cs:260
                                            }                                                                                               // MakerGen.cs:261
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 19. SpecimenDefinition.typeTested.container.preparation
                                    this.Preparation = new ElementDefinitionInfo                                                            // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Preparation",                                                                               // MakerGen.cs:235
                                        Path= "SpecimenDefinition.typeTested.container.preparation",                                        // MakerGen.cs:236
                                        Id = "SpecimenDefinition.typeTested.container.preparation",                                         // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:427
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:412
                            {                                                                                                               // MakerGen.cs:413
                                base.Write(sDef);                                                                                           // MakerGen.cs:414
                                Material.Write(sDef);                                                                                       // MakerGen.cs:220
                                Type.Write(sDef);                                                                                           // MakerGen.cs:220
                                Cap.Write(sDef);                                                                                            // MakerGen.cs:220
                                Description.Write(sDef);                                                                                    // MakerGen.cs:220
                                Capacity.Write(sDef);                                                                                       // MakerGen.cs:220
                                MinimumVolume.Write(sDef);                                                                                  // MakerGen.cs:220
                                Additive.Write(sDef);                                                                                       // MakerGen.cs:220
                                Preparation.Write(sDef);                                                                                    // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:431
                        }                                                                                                                   // MakerGen.cs:391
                        public Type_Container_Elements Elements { get; }                                                                    // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                        public Type_Container()                                                                                             // MakerGen.cs:394
                        {                                                                                                                   // MakerGen.cs:395
                            this.Elements = new Type_Container_Elements();                                                                  // MakerGen.cs:396
                        }                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:399
                        {                                                                                                                   // MakerGen.cs:400
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:401
                        }                                                                                                                   // MakerGen.cs:402
                    }                                                                                                                       // MakerGen.cs:403
                    // 23. SpecimenDefinition.typeTested.handling
                    public class Type_Handling : FhirKhit.Maker.Common.Complex.ComplexBase                                                  // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        public class Type_Handling_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                   // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:386
                            // 24. SpecimenDefinition.typeTested.handling.temperatureQualifier
                            public ElementDefinitionInfo TemperatureQualifier;                                                              // MakerGen.cs:216
                            // 25. SpecimenDefinition.typeTested.handling.temperatureRange
                            public ElementDefinitionInfo TemperatureRange;                                                                  // MakerGen.cs:216
                            // 26. SpecimenDefinition.typeTested.handling.maxDuration
                            public ElementDefinitionInfo MaxDuration;                                                                       // MakerGen.cs:216
                            // 27. SpecimenDefinition.typeTested.handling.instruction
                            public ElementDefinitionInfo Instruction;                                                                       // MakerGen.cs:216
                            public Type_Handling_Elements()                                                                                 // MakerGen.cs:407
                            {                                                                                                               // MakerGen.cs:408
                                {                                                                                                           // MakerGen.cs:231
                                    // 24. SpecimenDefinition.typeTested.handling.temperatureQualifier
                                    this.TemperatureQualifier = new ElementDefinitionInfo                                                   // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "TemperatureQualifier",                                                                      // MakerGen.cs:235
                                        Path= "SpecimenDefinition.typeTested.handling.temperatureQualifier",                                // MakerGen.cs:236
                                        Id = "SpecimenDefinition.typeTested.handling.temperatureQualifier",                                 // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 25. SpecimenDefinition.typeTested.handling.temperatureRange
                                    this.TemperatureRange = new ElementDefinitionInfo                                                       // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "TemperatureRange",                                                                          // MakerGen.cs:235
                                        Path= "SpecimenDefinition.typeTested.handling.temperatureRange",                                    // MakerGen.cs:236
                                        Id = "SpecimenDefinition.typeTested.handling.temperatureRange",                                     // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.Range                                                         // MakerGen.cs:358
                                            {                                                                                               // MakerGen.cs:359
                                            }                                                                                               // MakerGen.cs:360
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 26. SpecimenDefinition.typeTested.handling.maxDuration
                                    this.MaxDuration = new ElementDefinitionInfo                                                            // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "MaxDuration",                                                                               // MakerGen.cs:235
                                        Path= "SpecimenDefinition.typeTested.handling.maxDuration",                                         // MakerGen.cs:236
                                        Id = "SpecimenDefinition.typeTested.handling.maxDuration",                                          // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.Duration                                                      // MakerGen.cs:358
                                            {                                                                                               // MakerGen.cs:359
                                            }                                                                                               // MakerGen.cs:360
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 27. SpecimenDefinition.typeTested.handling.instruction
                                    this.Instruction = new ElementDefinitionInfo                                                            // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Instruction",                                                                               // MakerGen.cs:235
                                        Path= "SpecimenDefinition.typeTested.handling.instruction",                                         // MakerGen.cs:236
                                        Id = "SpecimenDefinition.typeTested.handling.instruction",                                          // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:427
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:412
                            {                                                                                                               // MakerGen.cs:413
                                base.Write(sDef);                                                                                           // MakerGen.cs:414
                                TemperatureQualifier.Write(sDef);                                                                           // MakerGen.cs:220
                                TemperatureRange.Write(sDef);                                                                               // MakerGen.cs:220
                                MaxDuration.Write(sDef);                                                                                    // MakerGen.cs:220
                                Instruction.Write(sDef);                                                                                    // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:431
                        }                                                                                                                   // MakerGen.cs:391
                        public Type_Handling_Elements Elements { get; }                                                                     // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                        public Type_Handling()                                                                                              // MakerGen.cs:394
                        {                                                                                                                   // MakerGen.cs:395
                            this.Elements = new Type_Handling_Elements();                                                                   // MakerGen.cs:396
                        }                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:399
                        {                                                                                                                   // MakerGen.cs:400
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:401
                        }                                                                                                                   // MakerGen.cs:402
                    }                                                                                                                       // MakerGen.cs:403
                    // 7. SpecimenDefinition.typeTested.isDerived
                    public ElementDefinitionInfo IsDerived;                                                                                 // MakerGen.cs:216
                    // 8. SpecimenDefinition.typeTested.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:216
                    // 9. SpecimenDefinition.typeTested.preference
                    public ElementDefinitionInfo Preference;                                                                                // MakerGen.cs:216
                    // 10. SpecimenDefinition.typeTested.container
                    public ElementDefinitionInfo Container;                                                                                 // MakerGen.cs:216
                    // 20. SpecimenDefinition.typeTested.requirement
                    public ElementDefinitionInfo Requirement;                                                                               // MakerGen.cs:216
                    // 21. SpecimenDefinition.typeTested.retentionTime
                    public ElementDefinitionInfo RetentionTime;                                                                             // MakerGen.cs:216
                    // 22. SpecimenDefinition.typeTested.rejectionCriterion
                    public ElementDefinitionInfo RejectionCriterion;                                                                        // MakerGen.cs:216
                    // 23. SpecimenDefinition.typeTested.handling
                    public ElementDefinitionInfo Handling;                                                                                  // MakerGen.cs:216
                    public Type_TypeTested_Elements()                                                                                       // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 7. SpecimenDefinition.typeTested.isDerived
                            this.IsDerived = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "IsDerived",                                                                                         // MakerGen.cs:235
                                Path= "SpecimenDefinition.typeTested.isDerived",                                                            // MakerGen.cs:236
                                Id = "SpecimenDefinition.typeTested.isDerived",                                                             // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 8. SpecimenDefinition.typeTested.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Type",                                                                                              // MakerGen.cs:235
                                Path= "SpecimenDefinition.typeTested.type",                                                                 // MakerGen.cs:236
                                Id = "SpecimenDefinition.typeTested.type",                                                                  // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 9. SpecimenDefinition.typeTested.preference
                            this.Preference = new ElementDefinitionInfo                                                                     // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Preference",                                                                                        // MakerGen.cs:235
                                Path= "SpecimenDefinition.typeTested.preference",                                                           // MakerGen.cs:236
                                Id = "SpecimenDefinition.typeTested.preference",                                                            // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 10. SpecimenDefinition.typeTested.container
                            this.Container = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Container",                                                                                         // MakerGen.cs:235
                                Path= "SpecimenDefinition.typeTested.container",                                                            // MakerGen.cs:236
                                Id = "SpecimenDefinition.typeTested.container",                                                             // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_Container                                                                                      // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 20. SpecimenDefinition.typeTested.requirement
                            this.Requirement = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Requirement",                                                                                       // MakerGen.cs:235
                                Path= "SpecimenDefinition.typeTested.requirement",                                                          // MakerGen.cs:236
                                Id = "SpecimenDefinition.typeTested.requirement",                                                           // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 21. SpecimenDefinition.typeTested.retentionTime
                            this.RetentionTime = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "RetentionTime",                                                                                     // MakerGen.cs:235
                                Path= "SpecimenDefinition.typeTested.retentionTime",                                                        // MakerGen.cs:236
                                Id = "SpecimenDefinition.typeTested.retentionTime",                                                         // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Duration                                                              // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 22. SpecimenDefinition.typeTested.rejectionCriterion
                            this.RejectionCriterion = new ElementDefinitionInfo                                                             // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "RejectionCriterion",                                                                                // MakerGen.cs:235
                                Path= "SpecimenDefinition.typeTested.rejectionCriterion",                                                   // MakerGen.cs:236
                                Id = "SpecimenDefinition.typeTested.rejectionCriterion",                                                    // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 23. SpecimenDefinition.typeTested.handling
                            this.Handling = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Handling",                                                                                          // MakerGen.cs:235
                                Path= "SpecimenDefinition.typeTested.handling",                                                             // MakerGen.cs:236
                                Id = "SpecimenDefinition.typeTested.handling",                                                              // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_Handling                                                                                       // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        IsDerived.Write(sDef);                                                                                              // MakerGen.cs:220
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Preference.Write(sDef);                                                                                             // MakerGen.cs:220
                        Container.Write(sDef);                                                                                              // MakerGen.cs:220
                        Requirement.Write(sDef);                                                                                            // MakerGen.cs:220
                        RetentionTime.Write(sDef);                                                                                          // MakerGen.cs:220
                        RejectionCriterion.Write(sDef);                                                                                     // MakerGen.cs:220
                        Handling.Write(sDef);                                                                                               // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_TypeTested_Elements Elements { get; }                                                                           // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_TypeTested()                                                                                                    // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_TypeTested_Elements();                                                                         // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 1. SpecimenDefinition.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 2. SpecimenDefinition.typeCollected
            public ElementDefinitionInfo TypeCollected;                                                                                     // MakerGen.cs:216
            // 3. SpecimenDefinition.patientPreparation
            public ElementDefinitionInfo PatientPreparation;                                                                                // MakerGen.cs:216
            // 4. SpecimenDefinition.timeAspect
            public ElementDefinitionInfo TimeAspect;                                                                                        // MakerGen.cs:216
            // 5. SpecimenDefinition.collection
            public ElementDefinitionInfo Collection;                                                                                        // MakerGen.cs:216
            // 6. SpecimenDefinition.typeTested
            public ElementDefinitionInfo TypeTested;                                                                                        // MakerGen.cs:216
            public SpecimenDefinition_Elements()                                                                                            // MakerGen.cs:407
            {                                                                                                                               // MakerGen.cs:408
                {                                                                                                                           // MakerGen.cs:231
                    // 1. SpecimenDefinition.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "SpecimenDefinition.identifier",                                                                              // MakerGen.cs:236
                        Id = "SpecimenDefinition.identifier",                                                                               // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 2. SpecimenDefinition.typeCollected
                    this.TypeCollected = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "TypeCollected",                                                                                             // MakerGen.cs:235
                        Path= "SpecimenDefinition.typeCollected",                                                                           // MakerGen.cs:236
                        Id = "SpecimenDefinition.typeCollected",                                                                            // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 3. SpecimenDefinition.patientPreparation
                    this.PatientPreparation = new ElementDefinitionInfo                                                                     // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "PatientPreparation",                                                                                        // MakerGen.cs:235
                        Path= "SpecimenDefinition.patientPreparation",                                                                      // MakerGen.cs:236
                        Id = "SpecimenDefinition.patientPreparation",                                                                       // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 4. SpecimenDefinition.timeAspect
                    this.TimeAspect = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "TimeAspect",                                                                                                // MakerGen.cs:235
                        Path= "SpecimenDefinition.timeAspect",                                                                              // MakerGen.cs:236
                        Id = "SpecimenDefinition.timeAspect",                                                                               // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 5. SpecimenDefinition.collection
                    this.Collection = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Collection",                                                                                                // MakerGen.cs:235
                        Path= "SpecimenDefinition.collection",                                                                              // MakerGen.cs:236
                        Id = "SpecimenDefinition.collection",                                                                               // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 6. SpecimenDefinition.typeTested
                    this.TypeTested = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "TypeTested",                                                                                                // MakerGen.cs:235
                        Path= "SpecimenDefinition.typeTested",                                                                              // MakerGen.cs:236
                        Id = "SpecimenDefinition.typeTested",                                                                               // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_TypeTested                                                                                             // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:427
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:412
            {                                                                                                                               // MakerGen.cs:413
                base.Write(sDef);                                                                                                           // MakerGen.cs:414
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:220
                TypeCollected.Write(sDef);                                                                                                  // MakerGen.cs:220
                PatientPreparation.Write(sDef);                                                                                             // MakerGen.cs:220
                TimeAspect.Write(sDef);                                                                                                     // MakerGen.cs:220
                Collection.Write(sDef);                                                                                                     // MakerGen.cs:220
                TypeTested.Write(sDef);                                                                                                     // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:431
        }                                                                                                                                   // MakerGen.cs:391
        public SpecimenDefinition_Elements Elements { get; }                                                                                // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
        public SpecimenDefinition()                                                                                                         // MakerGen.cs:394
        {                                                                                                                                   // MakerGen.cs:395
            this.Elements = new SpecimenDefinition_Elements();                                                                              // MakerGen.cs:396
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:399
        {                                                                                                                                   // MakerGen.cs:400
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:401
        }                                                                                                                                   // MakerGen.cs:402
    }                                                                                                                                       // MakerGen.cs:403
}                                                                                                                                           // MakerGen.cs:466
