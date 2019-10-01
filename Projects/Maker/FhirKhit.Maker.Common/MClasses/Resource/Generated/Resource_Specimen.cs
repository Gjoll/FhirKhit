using System;                                                                                                                               // MakerGen.cs:428
using System.Diagnostics;                                                                                                                   // MakerGen.cs:429
using System.IO;                                                                                                                            // MakerGen.cs:430
using System.Linq;                                                                                                                          // MakerGen.cs:431
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:432
                                                                                                                                            // MakerGen.cs:433
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:434
{                                                                                                                                           // MakerGen.cs:435
    #region Json                                                                                                                            // MakerGen.cs:436
    #if NEVER                                                                                                                               // MakerGen.cs:437
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
    #endregion                                                                                                                              // MakerGen.cs:440
    /// <summary>
    /// Fhir resource 'Specimen'
    /// </summary>
    // 0. Specimen
    public class Resource_Specimen : FhirKhit.Maker.Common.Resource.ResourceBase                                                            // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 9. Specimen.collection
        public class Type_Collection : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 10. Specimen.collection.collector
            public ElementDefinitionInfo Element_Collector;                                                                                 // MakerGen.cs:212
            // 11. Specimen.collection.collected[x]
            public ElementDefinitionInfo Element_Collected;                                                                                 // MakerGen.cs:212
            // 12. Specimen.collection.duration
            public ElementDefinitionInfo Element_Duration;                                                                                  // MakerGen.cs:212
            // 13. Specimen.collection.quantity
            public ElementDefinitionInfo Element_Quantity;                                                                                  // MakerGen.cs:212
            // 14. Specimen.collection.method
            public ElementDefinitionInfo Element_Method;                                                                                    // MakerGen.cs:212
            // 15. Specimen.collection.bodySite
            public ElementDefinitionInfo Element_BodySite;                                                                                  // MakerGen.cs:212
            // 16. Specimen.collection.fastingStatus[x]
            public ElementDefinitionInfo Element_FastingStatus;                                                                             // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "Specimen.collection",                                                                                           // MakerGen.cs:388
                    ElementId = "Specimen.collection"                                                                                       // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Collector.Write(sDef);                                                                                              // MakerGen.cs:216
                Element_Collected.Write(sDef);                                                                                              // MakerGen.cs:216
                Element_Duration.Write(sDef);                                                                                               // MakerGen.cs:216
                Element_Quantity.Write(sDef);                                                                                               // MakerGen.cs:216
                Element_Method.Write(sDef);                                                                                                 // MakerGen.cs:216
                Element_BodySite.Write(sDef);                                                                                               // MakerGen.cs:216
                Element_FastingStatus.Write(sDef);                                                                                          // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Collection()                                                                                                        // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 10. Specimen.collection.collector
                    this.Element_Collector = new ElementDefinitionInfo                                                                      // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Collector",                                                                                         // MakerGen.cs:231
                        Path= "Specimen.collection.collector",                                                                              // MakerGen.cs:232
                        Id = "Specimen.collection.collector",                                                                               // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:339
                            {                                                                                                               // MakerGen.cs:340
                                TargetProfile = new String[]                                                                                // MakerGen.cs:342
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                              // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:343
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 11. Specimen.collection.collected[x]
                    this.Element_Collected = new ElementDefinitionInfo                                                                      // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Collected",                                                                                         // MakerGen.cs:231
                        Path= "Specimen.collection.collected[x]",                                                                           // MakerGen.cs:232
                        Id = "Specimen.collection.collected[x]",                                                                            // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                          // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            },                                                                                                              // MakerGen.cs:300
                            new FhirKhit.Maker.Common.Complex.Type_Period                                                                   // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            }                                                                                                               // MakerGen.cs:353
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 12. Specimen.collection.duration
                    this.Element_Duration = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Duration",                                                                                          // MakerGen.cs:231
                        Path= "Specimen.collection.duration",                                                                               // MakerGen.cs:232
                        Id = "Specimen.collection.duration",                                                                                // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Duration                                                                 // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            }                                                                                                               // MakerGen.cs:353
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 13. Specimen.collection.quantity
                    this.Element_Quantity = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Quantity",                                                                                          // MakerGen.cs:231
                        Path= "Specimen.collection.quantity",                                                                               // MakerGen.cs:232
                        Id = "Specimen.collection.quantity",                                                                                // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            }                                                                                                               // MakerGen.cs:353
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 14. Specimen.collection.method
                    this.Element_Method = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Method",                                                                                            // MakerGen.cs:231
                        Path= "Specimen.collection.method",                                                                                 // MakerGen.cs:232
                        Id = "Specimen.collection.method",                                                                                  // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 15. Specimen.collection.bodySite
                    this.Element_BodySite = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_BodySite",                                                                                          // MakerGen.cs:231
                        Path= "Specimen.collection.bodySite",                                                                               // MakerGen.cs:232
                        Id = "Specimen.collection.bodySite",                                                                                // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 16. Specimen.collection.fastingStatus[x]
                    this.Element_FastingStatus = new ElementDefinitionInfo                                                                  // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_FastingStatus",                                                                                     // MakerGen.cs:231
                        Path= "Specimen.collection.fastingStatus[x]",                                                                       // MakerGen.cs:232
                        Id = "Specimen.collection.fastingStatus[x]",                                                                        // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            },                                                                                                              // MakerGen.cs:315
                            new FhirKhit.Maker.Common.Complex.Type_Duration                                                                 // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            }                                                                                                               // MakerGen.cs:353
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 17. Specimen.processing
        public class Type_Processing : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 18. Specimen.processing.description
            public ElementDefinitionInfo Element_Description;                                                                               // MakerGen.cs:212
            // 19. Specimen.processing.procedure
            public ElementDefinitionInfo Element_Procedure;                                                                                 // MakerGen.cs:212
            // 20. Specimen.processing.additive
            public ElementDefinitionInfo Element_Additive;                                                                                  // MakerGen.cs:212
            // 21. Specimen.processing.time[x]
            public ElementDefinitionInfo Element_Time;                                                                                      // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "Specimen.processing",                                                                                           // MakerGen.cs:388
                    ElementId = "Specimen.processing"                                                                                       // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Description.Write(sDef);                                                                                            // MakerGen.cs:216
                Element_Procedure.Write(sDef);                                                                                              // MakerGen.cs:216
                Element_Additive.Write(sDef);                                                                                               // MakerGen.cs:216
                Element_Time.Write(sDef);                                                                                                   // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Processing()                                                                                                        // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 18. Specimen.processing.description
                    this.Element_Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Description",                                                                                       // MakerGen.cs:231
                        Path= "Specimen.processing.description",                                                                            // MakerGen.cs:232
                        Id = "Specimen.processing.description",                                                                             // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 19. Specimen.processing.procedure
                    this.Element_Procedure = new ElementDefinitionInfo                                                                      // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Procedure",                                                                                         // MakerGen.cs:231
                        Path= "Specimen.processing.procedure",                                                                              // MakerGen.cs:232
                        Id = "Specimen.processing.procedure",                                                                               // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 20. Specimen.processing.additive
                    this.Element_Additive = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Additive",                                                                                          // MakerGen.cs:231
                        Path= "Specimen.processing.additive",                                                                               // MakerGen.cs:232
                        Id = "Specimen.processing.additive",                                                                                // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:339
                            {                                                                                                               // MakerGen.cs:340
                                TargetProfile = new String[]                                                                                // MakerGen.cs:342
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Substance"                                                     // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:343
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 21. Specimen.processing.time[x]
                    this.Element_Time = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Time",                                                                                              // MakerGen.cs:231
                        Path= "Specimen.processing.time[x]",                                                                                // MakerGen.cs:232
                        Id = "Specimen.processing.time[x]",                                                                                 // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                          // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            },                                                                                                              // MakerGen.cs:300
                            new FhirKhit.Maker.Common.Complex.Type_Period                                                                   // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            }                                                                                                               // MakerGen.cs:353
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 22. Specimen.container
        public class Type_Container : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 23. Specimen.container.identifier
            public ElementDefinitionInfo Element_Identifier;                                                                                // MakerGen.cs:212
            // 24. Specimen.container.description
            public ElementDefinitionInfo Element_Description;                                                                               // MakerGen.cs:212
            // 25. Specimen.container.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:212
            // 26. Specimen.container.capacity
            public ElementDefinitionInfo Element_Capacity;                                                                                  // MakerGen.cs:212
            // 27. Specimen.container.specimenQuantity
            public ElementDefinitionInfo Element_SpecimenQuantity;                                                                          // MakerGen.cs:212
            // 28. Specimen.container.additive[x]
            public ElementDefinitionInfo Element_Additive;                                                                                  // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "Specimen.container",                                                                                            // MakerGen.cs:388
                    ElementId = "Specimen.container"                                                                                        // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Identifier.Write(sDef);                                                                                             // MakerGen.cs:216
                Element_Description.Write(sDef);                                                                                            // MakerGen.cs:216
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_Capacity.Write(sDef);                                                                                               // MakerGen.cs:216
                Element_SpecimenQuantity.Write(sDef);                                                                                       // MakerGen.cs:216
                Element_Additive.Write(sDef);                                                                                               // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Container()                                                                                                         // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 23. Specimen.container.identifier
                    this.Element_Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Identifier",                                                                                        // MakerGen.cs:231
                        Path= "Specimen.container.identifier",                                                                              // MakerGen.cs:232
                        Id = "Specimen.container.identifier",                                                                               // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Identifier                                                               // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            }                                                                                                               // MakerGen.cs:353
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 24. Specimen.container.description
                    this.Element_Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Description",                                                                                       // MakerGen.cs:231
                        Path= "Specimen.container.description",                                                                             // MakerGen.cs:232
                        Id = "Specimen.container.description",                                                                              // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 25. Specimen.container.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Type",                                                                                              // MakerGen.cs:231
                        Path= "Specimen.container.type",                                                                                    // MakerGen.cs:232
                        Id = "Specimen.container.type",                                                                                     // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 26. Specimen.container.capacity
                    this.Element_Capacity = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Capacity",                                                                                          // MakerGen.cs:231
                        Path= "Specimen.container.capacity",                                                                                // MakerGen.cs:232
                        Id = "Specimen.container.capacity",                                                                                 // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            }                                                                                                               // MakerGen.cs:353
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 27. Specimen.container.specimenQuantity
                    this.Element_SpecimenQuantity = new ElementDefinitionInfo                                                               // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_SpecimenQuantity",                                                                                  // MakerGen.cs:231
                        Path= "Specimen.container.specimenQuantity",                                                                        // MakerGen.cs:232
                        Id = "Specimen.container.specimenQuantity",                                                                         // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            }                                                                                                               // MakerGen.cs:353
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 28. Specimen.container.additive[x]
                    this.Element_Additive = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Additive",                                                                                          // MakerGen.cs:231
                        Path= "Specimen.container.additive[x]",                                                                             // MakerGen.cs:232
                        Id = "Specimen.container.additive[x]",                                                                              // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            },                                                                                                              // MakerGen.cs:315
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:339
                            {                                                                                                               // MakerGen.cs:340
                                TargetProfile = new String[]                                                                                // MakerGen.cs:342
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Substance"                                                     // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:343
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 1. Specimen.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:212
        // 2. Specimen.accessionIdentifier
        public ElementDefinitionInfo Element_AccessionIdentifier;                                                                           // MakerGen.cs:212
        // 3. Specimen.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:212
        // 4. Specimen.type
        public ElementDefinitionInfo Element_Type;                                                                                          // MakerGen.cs:212
        // 5. Specimen.subject
        public ElementDefinitionInfo Element_Subject;                                                                                       // MakerGen.cs:212
        // 6. Specimen.receivedTime
        public ElementDefinitionInfo Element_ReceivedTime;                                                                                  // MakerGen.cs:212
        // 7. Specimen.parent
        public ElementDefinitionInfo Element_Parent;                                                                                        // MakerGen.cs:212
        // 8. Specimen.request
        public ElementDefinitionInfo Element_Request;                                                                                       // MakerGen.cs:212
        // 9. Specimen.collection
        public ElementDefinitionInfo Element_Collection;                                                                                    // MakerGen.cs:212
        // 17. Specimen.processing
        public ElementDefinitionInfo Element_Processing;                                                                                    // MakerGen.cs:212
        // 22. Specimen.container
        public ElementDefinitionInfo Element_Container;                                                                                     // MakerGen.cs:212
        // 29. Specimen.condition
        public ElementDefinitionInfo Element_Condition;                                                                                     // MakerGen.cs:212
        // 30. Specimen.note
        public ElementDefinitionInfo Element_Note;                                                                                          // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "Specimen",                                                                                                          // MakerGen.cs:388
                ElementId = "Specimen"                                                                                                      // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_AccessionIdentifier.Write(sDef);                                                                                        // MakerGen.cs:216
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Type.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Subject.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_ReceivedTime.Write(sDef);                                                                                               // MakerGen.cs:216
            Element_Parent.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Request.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Collection.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_Processing.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_Container.Write(sDef);                                                                                                  // MakerGen.cs:216
            Element_Condition.Write(sDef);                                                                                                  // MakerGen.cs:216
            Element_Note.Write(sDef);                                                                                                       // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Resource_Specimen()                                                                                                          // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. Specimen.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:231
                    Path= "Specimen.identifier",                                                                                            // MakerGen.cs:232
                    Id = "Specimen.identifier",                                                                                             // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 2. Specimen.accessionIdentifier
                this.Element_AccessionIdentifier = new ElementDefinitionInfo                                                                // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_AccessionIdentifier",                                                                                   // MakerGen.cs:231
                    Path= "Specimen.accessionIdentifier",                                                                                   // MakerGen.cs:232
                    Id = "Specimen.accessionIdentifier",                                                                                    // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 3. Specimen.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Status",                                                                                                // MakerGen.cs:231
                    Path= "Specimen.status",                                                                                                // MakerGen.cs:232
                    Id = "Specimen.status",                                                                                                 // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 4. Specimen.type
                this.Element_Type = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:231
                    Path= "Specimen.type",                                                                                                  // MakerGen.cs:232
                    Id = "Specimen.type",                                                                                                   // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 5. Specimen.subject
                this.Element_Subject = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Subject",                                                                                               // MakerGen.cs:231
                    Path= "Specimen.subject",                                                                                               // MakerGen.cs:232
                    Id = "Specimen.subject",                                                                                                // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Patient",                                                          // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Group",                                                            // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Device",                                                           // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Substance",                                                        // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Location"                                                          // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 6. Specimen.receivedTime
                this.Element_ReceivedTime = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_ReceivedTime",                                                                                          // MakerGen.cs:231
                    Path= "Specimen.receivedTime",                                                                                          // MakerGen.cs:232
                    Id = "Specimen.receivedTime",                                                                                           // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 7. Specimen.parent
                this.Element_Parent = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Parent",                                                                                                // MakerGen.cs:231
                    Path= "Specimen.parent",                                                                                                // MakerGen.cs:232
                    Id = "Specimen.parent",                                                                                                 // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Specimen"                                                          // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 8. Specimen.request
                this.Element_Request = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Request",                                                                                               // MakerGen.cs:231
                    Path= "Specimen.request",                                                                                               // MakerGen.cs:232
                    Id = "Specimen.request",                                                                                                // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/ServiceRequest"                                                    // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 9. Specimen.collection
                this.Element_Collection = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Collection",                                                                                            // MakerGen.cs:231
                    Path= "Specimen.collection",                                                                                            // MakerGen.cs:232
                    Id = "Specimen.collection",                                                                                             // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Collection                                                                                                 // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 17. Specimen.processing
                this.Element_Processing = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Processing",                                                                                            // MakerGen.cs:231
                    Path= "Specimen.processing",                                                                                            // MakerGen.cs:232
                    Id = "Specimen.processing",                                                                                             // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Processing                                                                                                 // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 22. Specimen.container
                this.Element_Container = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Container",                                                                                             // MakerGen.cs:231
                    Path= "Specimen.container",                                                                                             // MakerGen.cs:232
                    Id = "Specimen.container",                                                                                              // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Container                                                                                                  // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 29. Specimen.condition
                this.Element_Condition = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Condition",                                                                                             // MakerGen.cs:231
                    Path= "Specimen.condition",                                                                                             // MakerGen.cs:232
                    Id = "Specimen.condition",                                                                                              // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 30. Specimen.note
                this.Element_Note = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Note",                                                                                                  // MakerGen.cs:231
                    Path= "Specimen.note",                                                                                                  // MakerGen.cs:232
                    Id = "Specimen.note",                                                                                                   // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Annotation                                                                   // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            this.Name = "Specimen";                                                                                                         // MakerGen.cs:458
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Specimen";                                                                  // MakerGen.cs:459
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:445
