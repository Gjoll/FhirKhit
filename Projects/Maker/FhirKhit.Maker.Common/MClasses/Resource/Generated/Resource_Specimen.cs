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
      "id": "Specimen",
      "url": "http://hl7.org/fhir/StructureDefinition/Specimen",
      "version": "4.0.0",
      "name": "Specimen",
      "status": "draft",
      "publisher": "Health Level Seven International (Orders and Observations)",
      "description": "A sample to be used for analysis.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Specimen",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Specimen",
            "path": "Specimen",
            "short": "Sample for analysis",
            "definition": "A sample to be used for analysis.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Specimen.identifier",
            "path": "Specimen.identifier",
            "short": "External Identifier",
            "definition": "Id for specimen.",
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
            "id": "Specimen.accessionIdentifier",
            "path": "Specimen.accessionIdentifier",
            "short": "Identifier assigned by the lab",
            "definition": "The identifier assigned by the lab when accessioning specimen(s). This is not necessarily the same as the specimen identifier, depending on local lab procedures.",
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
            "id": "Specimen.status",
            "path": "Specimen.status",
            "short": "available | unavailable | unsatisfactory | entered-in-error",
            "definition": "The availability of the specimen.",
            "comment": "This element is labeled as a modifier because the status contains codes that mark the resource as not currently valid.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element is labelled as a modifier because it is a status element that contains status entered-in-error which means that the resource should not be treated as valid",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "SpecimenStatus"
                }
              ],
              "strength": "required",
              "description": "Codes providing the status/availability of a specimen.",
              "valueSet": "http://hl7.org/fhir/ValueSet/specimen-status|4.0.0"
            }
          },
          {
            "id": "Specimen.type",
            "path": "Specimen.type",
            "short": "Kind of material that forms the specimen",
            "definition": "The kind of material that forms the specimen.",
            "comment": "The type can change the way that a specimen is handled and drives what kind of analyses can properly be performed on the specimen. It is frequently used in diagnostic work flow decision making systems.",
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
                  "valueString": "SpecimenType"
                }
              ],
              "strength": "example",
              "description": "The type of the specimen.",
              "valueSet": "http://terminology.hl7.org/ValueSet/v2-0487"
            }
          },
          {
            "id": "Specimen.subject",
            "path": "Specimen.subject",
            "short": "Where the specimen came from. This may be from patient(s), from a location (e.g., the source of an environmental sample), or a sampling of a substance or a device",
            "definition": "Where the specimen came from. This may be from patient(s), from a location (e.g., the source of an environmental sample), or a sampling of a substance or a device.",
            "requirements": "Must know the subject context.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Group",
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/Substance",
                  "http://hl7.org/fhir/StructureDefinition/Location"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Specimen.receivedTime",
            "path": "Specimen.receivedTime",
            "short": "The time when specimen was received for processing",
            "definition": "Time when specimen was received for processing or testing.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Specimen.parent",
            "path": "Specimen.parent",
            "short": "Specimen from which this specimen originated",
            "definition": "Reference to the parent (source) specimen which is used when the specimen was either derived from or a component of another specimen.",
            "comment": "The parent specimen could be the source from which the current specimen is derived by some processing step (e.g. an aliquot or isolate or extracted nucleic acids from clinical samples) or one of many specimens that were combined to create a pooled sample.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Specimen"
                ]
              }
            ]
          },
          {
            "id": "Specimen.request",
            "path": "Specimen.request",
            "short": "Why the specimen was collected",
            "definition": "Details concerning a service request that required a specimen to be collected.",
            "comment": "The request may be explicit or implied such with a ServiceRequest that requires a blood draw.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ServiceRequest"
                ]
              }
            ]
          },
          {
            "id": "Specimen.collection",
            "path": "Specimen.collection",
            "short": "Collection details",
            "definition": "Details concerning the specimen collection.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Specimen.collection.collector",
            "path": "Specimen.collection.collector",
            "short": "Who collected the specimen",
            "definition": "Person who collected the specimen.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Specimen.collection.collected[x]",
            "path": "Specimen.collection.collected[x]",
            "short": "Collection time",
            "definition": "Time when specimen was collected from subject - the physiologically relevant time.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              },
              {
                "code": "Period"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Specimen.collection.duration",
            "path": "Specimen.collection.duration",
            "short": "How long it took to collect specimen",
            "definition": "The span of time over which the collection of a specimen occurred.",
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
            "id": "Specimen.collection.quantity",
            "path": "Specimen.collection.quantity",
            "short": "The quantity of specimen collected",
            "definition": "The quantity of specimen collected; for instance the volume of a blood sample, or the physical measurement of an anatomic pathology sample.",
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
            "id": "Specimen.collection.method",
            "path": "Specimen.collection.method",
            "short": "Technique used to perform collection",
            "definition": "A coded value specifying the technique that is used to perform the procedure.",
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
                  "valueString": "SpecimenCollectionMethod"
                }
              ],
              "strength": "example",
              "description": "The  technique that is used to perform the procedure.",
              "valueSet": "http://hl7.org/fhir/ValueSet/specimen-collection-method"
            }
          },
          {
            "id": "Specimen.collection.bodySite",
            "path": "Specimen.collection.bodySite",
            "short": "Anatomical collection site",
            "definition": "Anatomical location from which the specimen was collected (if subject is a patient). This is the target site.  This element is not used for environmental specimens.",
            "comment": "If the use case requires  BodySite to be handled as a separate resource instead of an inline coded element (e.g. to identify and track separately)  then use the standard extension [bodySite](extension-bodysite.html).",
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
                  "valueString": "BodySite"
                }
              ],
              "strength": "example",
              "description": "Codes describing anatomical locations. May include laterality.",
              "valueSet": "http://hl7.org/fhir/ValueSet/body-site"
            }
          },
          {
            "id": "Specimen.collection.fastingStatus[x]",
            "path": "Specimen.collection.fastingStatus[x]",
            "short": "Whether or how long patient abstained from food and/or drink",
            "definition": "Abstinence or reduction from some or all food, drink, or both, for a period of time prior to sample collection.",
            "comment": "Representing fasting status using this element is preferred to representing it with an observation using a 'pre-coordinated code'  such as  LOINC 2005-7 (Calcium [Moles/​time] in 2 hour Urine --12 hours fasting), or  using  a component observation ` such as `Observation.component code`  = LOINC 49541-6 (Fasting status - Reported).",
            "requirements": "Many diagnostic tests require fasting  to facilitate accurate interpretation.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              },
              {
                "code": "Duration"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "FastingStatus"
                }
              ],
              "strength": "extensible",
              "description": "Codes describing the fasting status of the patient.",
              "valueSet": "http://terminology.hl7.org/ValueSet/v2-0916"
            }
          },
          {
            "id": "Specimen.processing",
            "path": "Specimen.processing",
            "short": "Processing and processing step details",
            "definition": "Details concerning processing and processing steps for the specimen.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Specimen.processing.description",
            "path": "Specimen.processing.description",
            "short": "Textual description of procedure",
            "definition": "Textual description of procedure.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Specimen.processing.procedure",
            "path": "Specimen.processing.procedure",
            "short": "Indicates the treatment step  applied to the specimen",
            "definition": "A coded value specifying the procedure used to process the specimen.",
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
                  "valueString": "SpecimenProcessingProcedure"
                }
              ],
              "strength": "example",
              "description": "Type indicating the technique used to process the specimen.",
              "valueSet": "http://hl7.org/fhir/ValueSet/specimen-processing-procedure"
            }
          },
          {
            "id": "Specimen.processing.additive",
            "path": "Specimen.processing.additive",
            "short": "Material used in the processing step",
            "definition": "Material used in the processing step.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Substance"
                ]
              }
            ]
          },
          {
            "id": "Specimen.processing.time[x]",
            "path": "Specimen.processing.time[x]",
            "short": "Date and time of specimen processing",
            "definition": "A record of the time or period when the specimen processing occurred.  For example the time of sample fixation or the period of time the sample was in formalin.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              },
              {
                "code": "Period"
              }
            ]
          },
          {
            "id": "Specimen.container",
            "path": "Specimen.container",
            "short": "Direct container of specimen (tube/slide, etc.)",
            "definition": "The container holding the specimen.  The recursive nature of containers; i.e. blood in tube in tray in rack is not addressed here.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Specimen.container.identifier",
            "path": "Specimen.container.identifier",
            "short": "Id for the container",
            "definition": "Id for container. There may be multiple; a manufacturer's bar code, lab assigned identifier, etc. The container ID may differ from the specimen id in some circumstances.",
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
            "id": "Specimen.container.description",
            "path": "Specimen.container.description",
            "short": "Textual description of the container",
            "definition": "Textual description of the container.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Specimen.container.type",
            "path": "Specimen.container.type",
            "short": "Kind of container directly associated with specimen",
            "definition": "The type of container associated with the specimen (e.g. slide, aliquot, etc.).",
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
                  "valueString": "SpecimenContainerType"
                }
              ],
              "strength": "example",
              "description": "Type of specimen container.",
              "valueSet": "http://hl7.org/fhir/ValueSet/specimen-container-type"
            }
          },
          {
            "id": "Specimen.container.capacity",
            "path": "Specimen.container.capacity",
            "short": "Container volume or size",
            "definition": "The capacity (volume or other measure) the container may contain.",
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
            "id": "Specimen.container.specimenQuantity",
            "path": "Specimen.container.specimenQuantity",
            "short": "Quantity of specimen within container",
            "definition": "The quantity of specimen in the container; may be volume, dimensions, or other appropriate measurements, depending on the specimen type.",
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
            "id": "Specimen.container.additive[x]",
            "path": "Specimen.container.additive[x]",
            "short": "Additive associated with container",
            "definition": "Introduced substance to preserve, maintain or enhance the specimen. Examples: Formalin, Citrate, EDTA.",
            "min": 0,
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
                  "valueString": "SpecimenContainerAdditive"
                }
              ],
              "strength": "example",
              "description": "Substance added to specimen container.",
              "valueSet": "http://terminology.hl7.org/ValueSet/v2-0371"
            }
          },
          {
            "id": "Specimen.condition",
            "path": "Specimen.condition",
            "short": "State of the specimen",
            "definition": "A mode or state of being that describes the nature of the specimen.",
            "comment": "Specimen condition is an observation made about the specimen.  It's a point-in-time assessment.  It can be used to assess its quality or appropriateness for a specific test.",
            "requirements": "The specimen condition can be used to assess its quality or appropriateness for a specific test.",
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
                  "valueString": "SpecimenCondition"
                }
              ],
              "strength": "extensible",
              "description": "Codes describing the state of the specimen.",
              "valueSet": "http://terminology.hl7.org/ValueSet/v2-0493"
            }
          },
          {
            "id": "Specimen.note",
            "path": "Specimen.note",
            "short": "Comments",
            "definition": "To communicate any details or issues about the specimen or during the specimen collection. (for example: broken vial, sent with patient, frozen).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Annotation"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir resource 'Specimen'
    /// </summary>
    // 0. Specimen
    public class Resource_Specimen : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 9. Specimen.collection
        public class Type_Collection : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 10. Specimen.collection.collector
            public ElementDefinitionInfo Element_Collector;
            // 11. Specimen.collection.collected[x]
            public ElementDefinitionInfo Element_Collected;
            // 12. Specimen.collection.duration
            public ElementDefinitionInfo Element_Duration;
            // 13. Specimen.collection.quantity
            public ElementDefinitionInfo Element_Quantity;
            // 14. Specimen.collection.method
            public ElementDefinitionInfo Element_Method;
            // 15. Specimen.collection.bodySite
            public ElementDefinitionInfo Element_BodySite;
            // 16. Specimen.collection.fastingStatus[x]
            public ElementDefinitionInfo Element_FastingStatus;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Specimen.collection",
                    ElementId = "Specimen.collection"
                });
                Element_Collector.Write(sDef);
                Element_Collected.Write(sDef);
                Element_Duration.Write(sDef);
                Element_Quantity.Write(sDef);
                Element_Method.Write(sDef);
                Element_BodySite.Write(sDef);
                Element_FastingStatus.Write(sDef);
            }
            
            public Type_Collection()
            {
                {
                    // 10. Specimen.collection.collector
                    this.Element_Collector = new ElementDefinitionInfo
                    {
                        Name = "Element_Collector",
                        Path= "Specimen.collection.collector",
                        Id = "Specimen.collection.collector",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                                }
                            }
                        }
                    };
                }
                {
                    // 11. Specimen.collection.collected[x]
                    this.Element_Collected = new ElementDefinitionInfo
                    {
                        Name = "Element_Collected",
                        Path= "Specimen.collection.collected[x]",
                        Id = "Specimen.collection.collected[x]",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Period
                            {
                            }
                        }
                    };
                }
                {
                    // 12. Specimen.collection.duration
                    this.Element_Duration = new ElementDefinitionInfo
                    {
                        Name = "Element_Duration",
                        Path= "Specimen.collection.duration",
                        Id = "Specimen.collection.duration",
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
                    // 13. Specimen.collection.quantity
                    this.Element_Quantity = new ElementDefinitionInfo
                    {
                        Name = "Element_Quantity",
                        Path= "Specimen.collection.quantity",
                        Id = "Specimen.collection.quantity",
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
                    // 14. Specimen.collection.method
                    this.Element_Method = new ElementDefinitionInfo
                    {
                        Name = "Element_Method",
                        Path= "Specimen.collection.method",
                        Id = "Specimen.collection.method",
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
                    // 15. Specimen.collection.bodySite
                    this.Element_BodySite = new ElementDefinitionInfo
                    {
                        Name = "Element_BodySite",
                        Path= "Specimen.collection.bodySite",
                        Id = "Specimen.collection.bodySite",
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
                    // 16. Specimen.collection.fastingStatus[x]
                    this.Element_FastingStatus = new ElementDefinitionInfo
                    {
                        Name = "Element_FastingStatus",
                        Path= "Specimen.collection.fastingStatus[x]",
                        Id = "Specimen.collection.fastingStatus[x]",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Duration
                            {
                            }
                        }
                    };
                }
            }
        }
        // 17. Specimen.processing
        public class Type_Processing : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 18. Specimen.processing.description
            public ElementDefinitionInfo Element_Description;
            // 19. Specimen.processing.procedure
            public ElementDefinitionInfo Element_Procedure;
            // 20. Specimen.processing.additive
            public ElementDefinitionInfo Element_Additive;
            // 21. Specimen.processing.time[x]
            public ElementDefinitionInfo Element_Time;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Specimen.processing",
                    ElementId = "Specimen.processing"
                });
                Element_Description.Write(sDef);
                Element_Procedure.Write(sDef);
                Element_Additive.Write(sDef);
                Element_Time.Write(sDef);
            }
            
            public Type_Processing()
            {
                {
                    // 18. Specimen.processing.description
                    this.Element_Description = new ElementDefinitionInfo
                    {
                        Name = "Element_Description",
                        Path= "Specimen.processing.description",
                        Id = "Specimen.processing.description",
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
                    // 19. Specimen.processing.procedure
                    this.Element_Procedure = new ElementDefinitionInfo
                    {
                        Name = "Element_Procedure",
                        Path= "Specimen.processing.procedure",
                        Id = "Specimen.processing.procedure",
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
                    // 20. Specimen.processing.additive
                    this.Element_Additive = new ElementDefinitionInfo
                    {
                        Name = "Element_Additive",
                        Path= "Specimen.processing.additive",
                        Id = "Specimen.processing.additive",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
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
                {
                    // 21. Specimen.processing.time[x]
                    this.Element_Time = new ElementDefinitionInfo
                    {
                        Name = "Element_Time",
                        Path= "Specimen.processing.time[x]",
                        Id = "Specimen.processing.time[x]",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Period
                            {
                            }
                        }
                    };
                }
            }
        }
        // 22. Specimen.container
        public class Type_Container : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 23. Specimen.container.identifier
            public ElementDefinitionInfo Element_Identifier;
            // 24. Specimen.container.description
            public ElementDefinitionInfo Element_Description;
            // 25. Specimen.container.type
            public ElementDefinitionInfo Element_Type;
            // 26. Specimen.container.capacity
            public ElementDefinitionInfo Element_Capacity;
            // 27. Specimen.container.specimenQuantity
            public ElementDefinitionInfo Element_SpecimenQuantity;
            // 28. Specimen.container.additive[x]
            public ElementDefinitionInfo Element_Additive;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Specimen.container",
                    ElementId = "Specimen.container"
                });
                Element_Identifier.Write(sDef);
                Element_Description.Write(sDef);
                Element_Type.Write(sDef);
                Element_Capacity.Write(sDef);
                Element_SpecimenQuantity.Write(sDef);
                Element_Additive.Write(sDef);
            }
            
            public Type_Container()
            {
                {
                    // 23. Specimen.container.identifier
                    this.Element_Identifier = new ElementDefinitionInfo
                    {
                        Name = "Element_Identifier",
                        Path= "Specimen.container.identifier",
                        Id = "Specimen.container.identifier",
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
                    // 24. Specimen.container.description
                    this.Element_Description = new ElementDefinitionInfo
                    {
                        Name = "Element_Description",
                        Path= "Specimen.container.description",
                        Id = "Specimen.container.description",
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
                    // 25. Specimen.container.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "Specimen.container.type",
                        Id = "Specimen.container.type",
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
                    // 26. Specimen.container.capacity
                    this.Element_Capacity = new ElementDefinitionInfo
                    {
                        Name = "Element_Capacity",
                        Path= "Specimen.container.capacity",
                        Id = "Specimen.container.capacity",
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
                    // 27. Specimen.container.specimenQuantity
                    this.Element_SpecimenQuantity = new ElementDefinitionInfo
                    {
                        Name = "Element_SpecimenQuantity",
                        Path= "Specimen.container.specimenQuantity",
                        Id = "Specimen.container.specimenQuantity",
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
                    // 28. Specimen.container.additive[x]
                    this.Element_Additive = new ElementDefinitionInfo
                    {
                        Name = "Element_Additive",
                        Path= "Specimen.container.additive[x]",
                        Id = "Specimen.container.additive[x]",
                        Min = 0,
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
        // 1. Specimen.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. Specimen.accessionIdentifier
        public ElementDefinitionInfo Element_AccessionIdentifier;
        // 3. Specimen.status
        public ElementDefinitionInfo Element_Status;
        // 4. Specimen.type
        public ElementDefinitionInfo Element_Type;
        // 5. Specimen.subject
        public ElementDefinitionInfo Element_Subject;
        // 6. Specimen.receivedTime
        public ElementDefinitionInfo Element_ReceivedTime;
        // 7. Specimen.parent
        public ElementDefinitionInfo Element_Parent;
        // 8. Specimen.request
        public ElementDefinitionInfo Element_Request;
        // 9. Specimen.collection
        public ElementDefinitionInfo Element_Collection;
        // 17. Specimen.processing
        public ElementDefinitionInfo Element_Processing;
        // 22. Specimen.container
        public ElementDefinitionInfo Element_Container;
        // 29. Specimen.condition
        public ElementDefinitionInfo Element_Condition;
        // 30. Specimen.note
        public ElementDefinitionInfo Element_Note;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "Specimen",
                ElementId = "Specimen"
            });
            Element_Identifier.Write(sDef);
            Element_AccessionIdentifier.Write(sDef);
            Element_Status.Write(sDef);
            Element_Type.Write(sDef);
            Element_Subject.Write(sDef);
            Element_ReceivedTime.Write(sDef);
            Element_Parent.Write(sDef);
            Element_Request.Write(sDef);
            Element_Collection.Write(sDef);
            Element_Processing.Write(sDef);
            Element_Container.Write(sDef);
            Element_Condition.Write(sDef);
            Element_Note.Write(sDef);
        }
        
        public Resource_Specimen()
        {
            {
                // 1. Specimen.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "Specimen.identifier",
                    Id = "Specimen.identifier",
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
                // 2. Specimen.accessionIdentifier
                this.Element_AccessionIdentifier = new ElementDefinitionInfo
                {
                    Name = "Element_AccessionIdentifier",
                    Path= "Specimen.accessionIdentifier",
                    Id = "Specimen.accessionIdentifier",
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
                // 3. Specimen.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "Specimen.status",
                    Id = "Specimen.status",
                    Min = 0,
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
                // 4. Specimen.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "Specimen.type",
                    Id = "Specimen.type",
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
                // 5. Specimen.subject
                this.Element_Subject = new ElementDefinitionInfo
                {
                    Name = "Element_Subject",
                    Path= "Specimen.subject",
                    Id = "Specimen.subject",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/Group",
                                "http://hl7.org/fhir/StructureDefinition/Device",
                                "http://hl7.org/fhir/StructureDefinition/Substance",
                                "http://hl7.org/fhir/StructureDefinition/Location"
                            }
                        }
                    }
                };
            }
            {
                // 6. Specimen.receivedTime
                this.Element_ReceivedTime = new ElementDefinitionInfo
                {
                    Name = "Element_ReceivedTime",
                    Path= "Specimen.receivedTime",
                    Id = "Specimen.receivedTime",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                        {
                        }
                    }
                };
            }
            {
                // 7. Specimen.parent
                this.Element_Parent = new ElementDefinitionInfo
                {
                    Name = "Element_Parent",
                    Path= "Specimen.parent",
                    Id = "Specimen.parent",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Specimen"
                            }
                        }
                    }
                };
            }
            {
                // 8. Specimen.request
                this.Element_Request = new ElementDefinitionInfo
                {
                    Name = "Element_Request",
                    Path= "Specimen.request",
                    Id = "Specimen.request",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/ServiceRequest"
                            }
                        }
                    }
                };
            }
            {
                // 9. Specimen.collection
                this.Element_Collection = new ElementDefinitionInfo
                {
                    Name = "Element_Collection",
                    Path= "Specimen.collection",
                    Id = "Specimen.collection",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_Collection
                        {
                        }
                    }
                };
            }
            {
                // 17. Specimen.processing
                this.Element_Processing = new ElementDefinitionInfo
                {
                    Name = "Element_Processing",
                    Path= "Specimen.processing",
                    Id = "Specimen.processing",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Processing
                        {
                        }
                    }
                };
            }
            {
                // 22. Specimen.container
                this.Element_Container = new ElementDefinitionInfo
                {
                    Name = "Element_Container",
                    Path= "Specimen.container",
                    Id = "Specimen.container",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Container
                        {
                        }
                    }
                };
            }
            {
                // 29. Specimen.condition
                this.Element_Condition = new ElementDefinitionInfo
                {
                    Name = "Element_Condition",
                    Path= "Specimen.condition",
                    Id = "Specimen.condition",
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
                // 30. Specimen.note
                this.Element_Note = new ElementDefinitionInfo
                {
                    Name = "Element_Note",
                    Path= "Specimen.note",
                    Id = "Specimen.note",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Annotation
                        {
                        }
                    }
                };
            }
            this.Name = "Specimen";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Specimen";
        }
    }
}
