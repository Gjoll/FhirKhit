using System;                                                                                                                               // MakerGen.cs:454
using System.Diagnostics;                                                                                                                   // MakerGen.cs:455
using System.IO;                                                                                                                            // MakerGen.cs:456
using System.Linq;                                                                                                                          // MakerGen.cs:457
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:458
                                                                                                                                            // MakerGen.cs:459
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:460
{                                                                                                                                           // MakerGen.cs:461
    #region Json                                                                                                                            // MakerGen.cs:462
    #if NEVER                                                                                                                               // MakerGen.cs:463
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
    #endregion                                                                                                                              // MakerGen.cs:466
    /// <summary>
    /// Fhir resource 'SpecimenDefinition'
    /// </summary>
    // 0. SpecimenDefinition
    public class Resource_SpecimenDefinition : FhirKhit.Maker.Common.Resource.ResourceBase                                                  // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        public class Resource_SpecimenDefinition_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                     // MakerGen.cs:378
        {                                                                                                                                   // MakerGen.cs:379
            // 6. SpecimenDefinition.typeTested
            public class Type_TypeTested : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_TypeTested_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                         // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 10. SpecimenDefinition.typeTested.container
                    public class Type_Container : FhirKhit.Maker.Common.Complex.ComplexBase                                                 // MakerGen.cs:376
                    {                                                                                                                       // MakerGen.cs:377
                        public class Type_Container_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                  // MakerGen.cs:378
                        {                                                                                                                   // MakerGen.cs:379
                            // 17. SpecimenDefinition.typeTested.container.additive
                            public class Type_Additive : FhirKhit.Maker.Common.Complex.ComplexBase                                          // MakerGen.cs:376
                            {                                                                                                               // MakerGen.cs:377
                                public class Type_Additive_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                           // MakerGen.cs:378
                                {                                                                                                           // MakerGen.cs:379
                                    // 18. SpecimenDefinition.typeTested.container.additive.additive[x]
                                    public ElementDefinitionInfo Element_Additive;                                                          // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                                    public Type_Additive_Elements()                                                                         // MakerGen.cs:384
                                    {                                                                                                       // MakerGen.cs:385
                                        {                                                                                                   // MakerGen.cs:226
                                            // 18. SpecimenDefinition.typeTested.container.additive.additive[x]
                                            this.Element_Additive = new ElementDefinitionInfo                                               // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Element_Additive",                                                                  // MakerGen.cs:230
                                                Path= "SpecimenDefinition.typeTested.container.additive.additive[x]",                       // MakerGen.cs:231
                                                Id = "SpecimenDefinition.typeTested.container.additive.additive[x]",                        // MakerGen.cs:232
                                                Min = 1,                                                                                    // MakerGen.cs:233
                                                Max = 1,                                                                                    // MakerGen.cs:234
                                                Types = new BaseType[]                                                                      // MakerGen.cs:235
                                                {                                                                                           // MakerGen.cs:236
                                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                  // MakerGen.cs:310
                                                    {                                                                                       // MakerGen.cs:311
                                                    },                                                                                      // MakerGen.cs:314
                                                    new FhirKhit.Maker.Common.Complex.Type_Reference                                        // MakerGen.cs:338
                                                    {                                                                                       // MakerGen.cs:339
                                                        TargetProfile = new String[]                                                        // MakerGen.cs:341
                                                        {                                                                                   // CodeEditorExtensions.cs:28
                                                            "http://hl7.org/fhir/StructureDefinition/Substance"                             // MakerGen.cs:341
                                                        }                                                                                   // CodeEditorExtensions.cs:34
                                                    }                                                                                       // MakerGen.cs:342
                                                }                                                                                           // MakerGen.cs:238
                                            };                                                                                              // MakerGen.cs:239
                                        }                                                                                                   // MakerGen.cs:240
                                    }                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:390
                                    {                                                                                                       // MakerGen.cs:391
                                        base.Write(sDef);                                                                                   // MakerGen.cs:392
                                        Element_Additive.Write(sDef);                                                                       // MakerGen.cs:215
                                    }                                                                                                       // MakerGen.cs:394
                                }                                                                                                           // MakerGen.cs:396
                                public Type_Additive_Elements Elements                                                                      // MakerGen.cs:398
                                {                                                                                                           // MakerGen.cs:399
                                    get                                                                                                     // MakerGen.cs:400
                                    {                                                                                                       // MakerGen.cs:401
                                        if (this.elements == null)                                                                          // MakerGen.cs:402
                                            this.elements = new Type_Additive_Elements();                                                   // MakerGen.cs:403
                                        return this.elements;                                                                               // MakerGen.cs:404
                                    }                                                                                                       // MakerGen.cs:405
                                }                                                                                                           // MakerGen.cs:406
                                Type_Additive_Elements elements;                                                                            // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                                public Type_Additive()                                                                                      // MakerGen.cs:410
                                {                                                                                                           // MakerGen.cs:411
                                }                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:416
                                {                                                                                                           // MakerGen.cs:417
                                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                      // MakerGen.cs:418
                                    {                                                                                                       // MakerGen.cs:419
                                        Path = "SpecimenDefinition.typeTested.container.additive",                                          // MakerGen.cs:420
                                        ElementId = "SpecimenDefinition.typeTested.container.additive"                                      // MakerGen.cs:421
                                    });                                                                                                     // MakerGen.cs:422
                                    if (this.elements != null)                                                                              // MakerGen.cs:423
                                        this.elements.Write(sDef);                                                                          // MakerGen.cs:424
                                }                                                                                                           // MakerGen.cs:425
                            }                                                                                                               // MakerGen.cs:426
                            // 11. SpecimenDefinition.typeTested.container.material
                            public ElementDefinitionInfo Element_Material;                                                                  // MakerGen.cs:211
                            // 12. SpecimenDefinition.typeTested.container.type
                            public ElementDefinitionInfo Element_Type;                                                                      // MakerGen.cs:211
                            // 13. SpecimenDefinition.typeTested.container.cap
                            public ElementDefinitionInfo Element_Cap;                                                                       // MakerGen.cs:211
                            // 14. SpecimenDefinition.typeTested.container.description
                            public ElementDefinitionInfo Element_Description;                                                               // MakerGen.cs:211
                            // 15. SpecimenDefinition.typeTested.container.capacity
                            public ElementDefinitionInfo Element_Capacity;                                                                  // MakerGen.cs:211
                            // 16. SpecimenDefinition.typeTested.container.minimumVolume[x]
                            public ElementDefinitionInfo Element_MinimumVolume;                                                             // MakerGen.cs:211
                            // 17. SpecimenDefinition.typeTested.container.additive
                            public ElementDefinitionInfo Element_Additive;                                                                  // MakerGen.cs:211
                            // 19. SpecimenDefinition.typeTested.container.preparation
                            public ElementDefinitionInfo Element_Preparation;                                                               // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                            public Type_Container_Elements()                                                                                // MakerGen.cs:384
                            {                                                                                                               // MakerGen.cs:385
                                {                                                                                                           // MakerGen.cs:226
                                    // 11. SpecimenDefinition.typeTested.container.material
                                    this.Element_Material = new ElementDefinitionInfo                                                       // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_Material",                                                                          // MakerGen.cs:230
                                        Path= "SpecimenDefinition.typeTested.container.material",                                           // MakerGen.cs:231
                                        Id = "SpecimenDefinition.typeTested.container.material",                                            // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                          // MakerGen.cs:310
                                            {                                                                                               // MakerGen.cs:311
                                            }                                                                                               // MakerGen.cs:314
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 12. SpecimenDefinition.typeTested.container.type
                                    this.Element_Type = new ElementDefinitionInfo                                                           // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_Type",                                                                              // MakerGen.cs:230
                                        Path= "SpecimenDefinition.typeTested.container.type",                                               // MakerGen.cs:231
                                        Id = "SpecimenDefinition.typeTested.container.type",                                                // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                          // MakerGen.cs:310
                                            {                                                                                               // MakerGen.cs:311
                                            }                                                                                               // MakerGen.cs:314
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 13. SpecimenDefinition.typeTested.container.cap
                                    this.Element_Cap = new ElementDefinitionInfo                                                            // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_Cap",                                                                               // MakerGen.cs:230
                                        Path= "SpecimenDefinition.typeTested.container.cap",                                                // MakerGen.cs:231
                                        Id = "SpecimenDefinition.typeTested.container.cap",                                                 // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                          // MakerGen.cs:310
                                            {                                                                                               // MakerGen.cs:311
                                            }                                                                                               // MakerGen.cs:314
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 14. SpecimenDefinition.typeTested.container.description
                                    this.Element_Description = new ElementDefinitionInfo                                                    // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_Description",                                                                       // MakerGen.cs:230
                                        Path= "SpecimenDefinition.typeTested.container.description",                                        // MakerGen.cs:231
                                        Id = "SpecimenDefinition.typeTested.container.description",                                         // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 15. SpecimenDefinition.typeTested.container.capacity
                                    this.Element_Capacity = new ElementDefinitionInfo                                                       // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_Capacity",                                                                          // MakerGen.cs:230
                                        Path= "SpecimenDefinition.typeTested.container.capacity",                                           // MakerGen.cs:231
                                        Id = "SpecimenDefinition.typeTested.container.capacity",                                            // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                 // MakerGen.cs:350
                                            {                                                                                               // MakerGen.cs:351
                                            }                                                                                               // MakerGen.cs:352
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 16. SpecimenDefinition.typeTested.container.minimumVolume[x]
                                    this.Element_MinimumVolume = new ElementDefinitionInfo                                                  // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_MinimumVolume",                                                                     // MakerGen.cs:230
                                        Path= "SpecimenDefinition.typeTested.container.minimumVolume[x]",                                   // MakerGen.cs:231
                                        Id = "SpecimenDefinition.typeTested.container.minimumVolume[x]",                                    // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                 // MakerGen.cs:350
                                            {                                                                                               // MakerGen.cs:351
                                            },                                                                                              // MakerGen.cs:352
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 17. SpecimenDefinition.typeTested.container.additive
                                    this.Element_Additive = new ElementDefinitionInfo                                                       // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_Additive",                                                                          // MakerGen.cs:230
                                        Path= "SpecimenDefinition.typeTested.container.additive",                                           // MakerGen.cs:231
                                        Id = "SpecimenDefinition.typeTested.container.additive",                                            // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = -1,                                                                                           // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new Type_Additive                                                                               // MakerGen.cs:254
                                            {                                                                                               // MakerGen.cs:255
                                            }                                                                                               // MakerGen.cs:256
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 19. SpecimenDefinition.typeTested.container.preparation
                                    this.Element_Preparation = new ElementDefinitionInfo                                                    // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_Preparation",                                                                       // MakerGen.cs:230
                                        Path= "SpecimenDefinition.typeTested.container.preparation",                                        // MakerGen.cs:231
                                        Id = "SpecimenDefinition.typeTested.container.preparation",                                         // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:390
                            {                                                                                                               // MakerGen.cs:391
                                base.Write(sDef);                                                                                           // MakerGen.cs:392
                                Element_Material.Write(sDef);                                                                               // MakerGen.cs:215
                                Element_Type.Write(sDef);                                                                                   // MakerGen.cs:215
                                Element_Cap.Write(sDef);                                                                                    // MakerGen.cs:215
                                Element_Description.Write(sDef);                                                                            // MakerGen.cs:215
                                Element_Capacity.Write(sDef);                                                                               // MakerGen.cs:215
                                Element_MinimumVolume.Write(sDef);                                                                          // MakerGen.cs:215
                                Element_Additive.Write(sDef);                                                                               // MakerGen.cs:215
                                Element_Preparation.Write(sDef);                                                                            // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:394
                        }                                                                                                                   // MakerGen.cs:396
                        public Type_Container_Elements Elements                                                                             // MakerGen.cs:398
                        {                                                                                                                   // MakerGen.cs:399
                            get                                                                                                             // MakerGen.cs:400
                            {                                                                                                               // MakerGen.cs:401
                                if (this.elements == null)                                                                                  // MakerGen.cs:402
                                    this.elements = new Type_Container_Elements();                                                          // MakerGen.cs:403
                                return this.elements;                                                                                       // MakerGen.cs:404
                            }                                                                                                               // MakerGen.cs:405
                        }                                                                                                                   // MakerGen.cs:406
                        Type_Container_Elements elements;                                                                                   // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                        public Type_Container()                                                                                             // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:411
                        }                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:416
                        {                                                                                                                   // MakerGen.cs:417
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:418
                            {                                                                                                               // MakerGen.cs:419
                                Path = "SpecimenDefinition.typeTested.container",                                                           // MakerGen.cs:420
                                ElementId = "SpecimenDefinition.typeTested.container"                                                       // MakerGen.cs:421
                            });                                                                                                             // MakerGen.cs:422
                            if (this.elements != null)                                                                                      // MakerGen.cs:423
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:424
                        }                                                                                                                   // MakerGen.cs:425
                    }                                                                                                                       // MakerGen.cs:426
                    // 23. SpecimenDefinition.typeTested.handling
                    public class Type_Handling : FhirKhit.Maker.Common.Complex.ComplexBase                                                  // MakerGen.cs:376
                    {                                                                                                                       // MakerGen.cs:377
                        public class Type_Handling_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                   // MakerGen.cs:378
                        {                                                                                                                   // MakerGen.cs:379
                            // 24. SpecimenDefinition.typeTested.handling.temperatureQualifier
                            public ElementDefinitionInfo Element_TemperatureQualifier;                                                      // MakerGen.cs:211
                            // 25. SpecimenDefinition.typeTested.handling.temperatureRange
                            public ElementDefinitionInfo Element_TemperatureRange;                                                          // MakerGen.cs:211
                            // 26. SpecimenDefinition.typeTested.handling.maxDuration
                            public ElementDefinitionInfo Element_MaxDuration;                                                               // MakerGen.cs:211
                            // 27. SpecimenDefinition.typeTested.handling.instruction
                            public ElementDefinitionInfo Element_Instruction;                                                               // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                            public Type_Handling_Elements()                                                                                 // MakerGen.cs:384
                            {                                                                                                               // MakerGen.cs:385
                                {                                                                                                           // MakerGen.cs:226
                                    // 24. SpecimenDefinition.typeTested.handling.temperatureQualifier
                                    this.Element_TemperatureQualifier = new ElementDefinitionInfo                                           // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_TemperatureQualifier",                                                              // MakerGen.cs:230
                                        Path= "SpecimenDefinition.typeTested.handling.temperatureQualifier",                                // MakerGen.cs:231
                                        Id = "SpecimenDefinition.typeTested.handling.temperatureQualifier",                                 // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                          // MakerGen.cs:310
                                            {                                                                                               // MakerGen.cs:311
                                            }                                                                                               // MakerGen.cs:314
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 25. SpecimenDefinition.typeTested.handling.temperatureRange
                                    this.Element_TemperatureRange = new ElementDefinitionInfo                                               // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_TemperatureRange",                                                                  // MakerGen.cs:230
                                        Path= "SpecimenDefinition.typeTested.handling.temperatureRange",                                    // MakerGen.cs:231
                                        Id = "SpecimenDefinition.typeTested.handling.temperatureRange",                                     // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Type_Range                                                    // MakerGen.cs:350
                                            {                                                                                               // MakerGen.cs:351
                                            }                                                                                               // MakerGen.cs:352
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 26. SpecimenDefinition.typeTested.handling.maxDuration
                                    this.Element_MaxDuration = new ElementDefinitionInfo                                                    // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_MaxDuration",                                                                       // MakerGen.cs:230
                                        Path= "SpecimenDefinition.typeTested.handling.maxDuration",                                         // MakerGen.cs:231
                                        Id = "SpecimenDefinition.typeTested.handling.maxDuration",                                          // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Type_Duration                                                 // MakerGen.cs:350
                                            {                                                                                               // MakerGen.cs:351
                                            }                                                                                               // MakerGen.cs:352
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 27. SpecimenDefinition.typeTested.handling.instruction
                                    this.Element_Instruction = new ElementDefinitionInfo                                                    // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_Instruction",                                                                       // MakerGen.cs:230
                                        Path= "SpecimenDefinition.typeTested.handling.instruction",                                         // MakerGen.cs:231
                                        Id = "SpecimenDefinition.typeTested.handling.instruction",                                          // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:390
                            {                                                                                                               // MakerGen.cs:391
                                base.Write(sDef);                                                                                           // MakerGen.cs:392
                                Element_TemperatureQualifier.Write(sDef);                                                                   // MakerGen.cs:215
                                Element_TemperatureRange.Write(sDef);                                                                       // MakerGen.cs:215
                                Element_MaxDuration.Write(sDef);                                                                            // MakerGen.cs:215
                                Element_Instruction.Write(sDef);                                                                            // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:394
                        }                                                                                                                   // MakerGen.cs:396
                        public Type_Handling_Elements Elements                                                                              // MakerGen.cs:398
                        {                                                                                                                   // MakerGen.cs:399
                            get                                                                                                             // MakerGen.cs:400
                            {                                                                                                               // MakerGen.cs:401
                                if (this.elements == null)                                                                                  // MakerGen.cs:402
                                    this.elements = new Type_Handling_Elements();                                                           // MakerGen.cs:403
                                return this.elements;                                                                                       // MakerGen.cs:404
                            }                                                                                                               // MakerGen.cs:405
                        }                                                                                                                   // MakerGen.cs:406
                        Type_Handling_Elements elements;                                                                                    // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                        public Type_Handling()                                                                                              // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:411
                        }                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:416
                        {                                                                                                                   // MakerGen.cs:417
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:418
                            {                                                                                                               // MakerGen.cs:419
                                Path = "SpecimenDefinition.typeTested.handling",                                                            // MakerGen.cs:420
                                ElementId = "SpecimenDefinition.typeTested.handling"                                                        // MakerGen.cs:421
                            });                                                                                                             // MakerGen.cs:422
                            if (this.elements != null)                                                                                      // MakerGen.cs:423
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:424
                        }                                                                                                                   // MakerGen.cs:425
                    }                                                                                                                       // MakerGen.cs:426
                    // 7. SpecimenDefinition.typeTested.isDerived
                    public ElementDefinitionInfo Element_IsDerived;                                                                         // MakerGen.cs:211
                    // 8. SpecimenDefinition.typeTested.type
                    public ElementDefinitionInfo Element_Type;                                                                              // MakerGen.cs:211
                    // 9. SpecimenDefinition.typeTested.preference
                    public ElementDefinitionInfo Element_Preference;                                                                        // MakerGen.cs:211
                    // 10. SpecimenDefinition.typeTested.container
                    public ElementDefinitionInfo Element_Container;                                                                         // MakerGen.cs:211
                    // 20. SpecimenDefinition.typeTested.requirement
                    public ElementDefinitionInfo Element_Requirement;                                                                       // MakerGen.cs:211
                    // 21. SpecimenDefinition.typeTested.retentionTime
                    public ElementDefinitionInfo Element_RetentionTime;                                                                     // MakerGen.cs:211
                    // 22. SpecimenDefinition.typeTested.rejectionCriterion
                    public ElementDefinitionInfo Element_RejectionCriterion;                                                                // MakerGen.cs:211
                    // 23. SpecimenDefinition.typeTested.handling
                    public ElementDefinitionInfo Element_Handling;                                                                          // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_TypeTested_Elements()                                                                                       // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 7. SpecimenDefinition.typeTested.isDerived
                            this.Element_IsDerived = new ElementDefinitionInfo                                                              // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_IsDerived",                                                                                 // MakerGen.cs:230
                                Path= "SpecimenDefinition.typeTested.isDerived",                                                            // MakerGen.cs:231
                                Id = "SpecimenDefinition.typeTested.isDerived",                                                             // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 8. SpecimenDefinition.typeTested.type
                            this.Element_Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Type",                                                                                      // MakerGen.cs:230
                                Path= "SpecimenDefinition.typeTested.type",                                                                 // MakerGen.cs:231
                                Id = "SpecimenDefinition.typeTested.type",                                                                  // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 9. SpecimenDefinition.typeTested.preference
                            this.Element_Preference = new ElementDefinitionInfo                                                             // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Preference",                                                                                // MakerGen.cs:230
                                Path= "SpecimenDefinition.typeTested.preference",                                                           // MakerGen.cs:231
                                Id = "SpecimenDefinition.typeTested.preference",                                                            // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 10. SpecimenDefinition.typeTested.container
                            this.Element_Container = new ElementDefinitionInfo                                                              // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Container",                                                                                 // MakerGen.cs:230
                                Path= "SpecimenDefinition.typeTested.container",                                                            // MakerGen.cs:231
                                Id = "SpecimenDefinition.typeTested.container",                                                             // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new Type_Container                                                                                      // MakerGen.cs:254
                                    {                                                                                                       // MakerGen.cs:255
                                    }                                                                                                       // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 20. SpecimenDefinition.typeTested.requirement
                            this.Element_Requirement = new ElementDefinitionInfo                                                            // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Requirement",                                                                               // MakerGen.cs:230
                                Path= "SpecimenDefinition.typeTested.requirement",                                                          // MakerGen.cs:231
                                Id = "SpecimenDefinition.typeTested.requirement",                                                           // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 21. SpecimenDefinition.typeTested.retentionTime
                            this.Element_RetentionTime = new ElementDefinitionInfo                                                          // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_RetentionTime",                                                                             // MakerGen.cs:230
                                Path= "SpecimenDefinition.typeTested.retentionTime",                                                        // MakerGen.cs:231
                                Id = "SpecimenDefinition.typeTested.retentionTime",                                                         // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Duration                                                         // MakerGen.cs:350
                                    {                                                                                                       // MakerGen.cs:351
                                    }                                                                                                       // MakerGen.cs:352
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 22. SpecimenDefinition.typeTested.rejectionCriterion
                            this.Element_RejectionCriterion = new ElementDefinitionInfo                                                     // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_RejectionCriterion",                                                                        // MakerGen.cs:230
                                Path= "SpecimenDefinition.typeTested.rejectionCriterion",                                                   // MakerGen.cs:231
                                Id = "SpecimenDefinition.typeTested.rejectionCriterion",                                                    // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 23. SpecimenDefinition.typeTested.handling
                            this.Element_Handling = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Handling",                                                                                  // MakerGen.cs:230
                                Path= "SpecimenDefinition.typeTested.handling",                                                             // MakerGen.cs:231
                                Id = "SpecimenDefinition.typeTested.handling",                                                              // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new Type_Handling                                                                                       // MakerGen.cs:254
                                    {                                                                                                       // MakerGen.cs:255
                                    }                                                                                                       // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        Element_IsDerived.Write(sDef);                                                                                      // MakerGen.cs:215
                        Element_Type.Write(sDef);                                                                                           // MakerGen.cs:215
                        Element_Preference.Write(sDef);                                                                                     // MakerGen.cs:215
                        Element_Container.Write(sDef);                                                                                      // MakerGen.cs:215
                        Element_Requirement.Write(sDef);                                                                                    // MakerGen.cs:215
                        Element_RetentionTime.Write(sDef);                                                                                  // MakerGen.cs:215
                        Element_RejectionCriterion.Write(sDef);                                                                             // MakerGen.cs:215
                        Element_Handling.Write(sDef);                                                                                       // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_TypeTested_Elements Elements                                                                                    // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_TypeTested_Elements();                                                                 // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_TypeTested_Elements elements;                                                                                          // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_TypeTested()                                                                                                    // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "SpecimenDefinition.typeTested",                                                                             // MakerGen.cs:420
                        ElementId = "SpecimenDefinition.typeTested"                                                                         // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 1. SpecimenDefinition.identifier
            public ElementDefinitionInfo Element_Identifier;                                                                                // MakerGen.cs:211
            // 2. SpecimenDefinition.typeCollected
            public ElementDefinitionInfo Element_TypeCollected;                                                                             // MakerGen.cs:211
            // 3. SpecimenDefinition.patientPreparation
            public ElementDefinitionInfo Element_PatientPreparation;                                                                        // MakerGen.cs:211
            // 4. SpecimenDefinition.timeAspect
            public ElementDefinitionInfo Element_TimeAspect;                                                                                // MakerGen.cs:211
            // 5. SpecimenDefinition.collection
            public ElementDefinitionInfo Element_Collection;                                                                                // MakerGen.cs:211
            // 6. SpecimenDefinition.typeTested
            public ElementDefinitionInfo Element_TypeTested;                                                                                // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
            public Resource_SpecimenDefinition_Elements()                                                                                   // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:226
                    // 1. SpecimenDefinition.identifier
                    this.Element_Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Identifier",                                                                                        // MakerGen.cs:230
                        Path= "SpecimenDefinition.identifier",                                                                              // MakerGen.cs:231
                        Id = "SpecimenDefinition.identifier",                                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Identifier                                                               // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. SpecimenDefinition.typeCollected
                    this.Element_TypeCollected = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_TypeCollected",                                                                                     // MakerGen.cs:230
                        Path= "SpecimenDefinition.typeCollected",                                                                           // MakerGen.cs:231
                        Id = "SpecimenDefinition.typeCollected",                                                                            // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 3. SpecimenDefinition.patientPreparation
                    this.Element_PatientPreparation = new ElementDefinitionInfo                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_PatientPreparation",                                                                                // MakerGen.cs:230
                        Path= "SpecimenDefinition.patientPreparation",                                                                      // MakerGen.cs:231
                        Id = "SpecimenDefinition.patientPreparation",                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 4. SpecimenDefinition.timeAspect
                    this.Element_TimeAspect = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_TimeAspect",                                                                                        // MakerGen.cs:230
                        Path= "SpecimenDefinition.timeAspect",                                                                              // MakerGen.cs:231
                        Id = "SpecimenDefinition.timeAspect",                                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. SpecimenDefinition.collection
                    this.Element_Collection = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Collection",                                                                                        // MakerGen.cs:230
                        Path= "SpecimenDefinition.collection",                                                                              // MakerGen.cs:231
                        Id = "SpecimenDefinition.collection",                                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 6. SpecimenDefinition.typeTested
                    this.Element_TypeTested = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_TypeTested",                                                                                        // MakerGen.cs:230
                        Path= "SpecimenDefinition.typeTested",                                                                              // MakerGen.cs:231
                        Id = "SpecimenDefinition.typeTested",                                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_TypeTested                                                                                             // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                Element_Identifier.Write(sDef);                                                                                             // MakerGen.cs:215
                Element_TypeCollected.Write(sDef);                                                                                          // MakerGen.cs:215
                Element_PatientPreparation.Write(sDef);                                                                                     // MakerGen.cs:215
                Element_TimeAspect.Write(sDef);                                                                                             // MakerGen.cs:215
                Element_Collection.Write(sDef);                                                                                             // MakerGen.cs:215
                Element_TypeTested.Write(sDef);                                                                                             // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:394
        }                                                                                                                                   // MakerGen.cs:396
        public Resource_SpecimenDefinition_Elements Elements                                                                                // MakerGen.cs:398
        {                                                                                                                                   // MakerGen.cs:399
            get                                                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                if (this.elements == null)                                                                                                  // MakerGen.cs:402
                    this.elements = new Resource_SpecimenDefinition_Elements();                                                             // MakerGen.cs:403
                return this.elements;                                                                                                       // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:406
        Resource_SpecimenDefinition_Elements elements;                                                                                      // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
        public Resource_SpecimenDefinition()                                                                                                // MakerGen.cs:410
        {                                                                                                                                   // MakerGen.cs:411
            this.Name = "SpecimenDefinition";                                                                                               // MakerGen.cs:484
            this.Uri = "http://hl7.org/fhir/StructureDefinition/SpecimenDefinition";                                                        // MakerGen.cs:485
        }                                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:416
        {                                                                                                                                   // MakerGen.cs:417
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:418
            {                                                                                                                               // MakerGen.cs:419
                Path = "SpecimenDefinition",                                                                                                // MakerGen.cs:420
                ElementId = "SpecimenDefinition"                                                                                            // MakerGen.cs:421
            });                                                                                                                             // MakerGen.cs:422
            if (this.elements != null)                                                                                                      // MakerGen.cs:423
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:424
        }                                                                                                                                   // MakerGen.cs:425
    }                                                                                                                                       // MakerGen.cs:426
}                                                                                                                                           // MakerGen.cs:471
