using System;                                                                                                                               // MakerGen.cs:457
using System.Diagnostics;                                                                                                                   // MakerGen.cs:458
using System.IO;                                                                                                                            // MakerGen.cs:459
using System.Linq;                                                                                                                          // MakerGen.cs:460
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:461
                                                                                                                                            // MakerGen.cs:462
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:463
{                                                                                                                                           // MakerGen.cs:464
    #region Json                                                                                                                            // MakerGen.cs:465
    #if NEVER                                                                                                                               // MakerGen.cs:466
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
    #endregion                                                                                                                              // MakerGen.cs:469
    /// <summary>
    /// Fhir resource 'Specimen'
    /// </summary>
    // 0. Specimen
    public class Specimen : FhirKhit.Maker.Common.Resource.ResourceBase                                                                     // MakerGen.cs:379
    {                                                                                                                                       // MakerGen.cs:380
        public class Specimen_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                        // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 9. Specimen.collection
            public class Type_Collection : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_Collection_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                         // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 10. Specimen.collection.collector
                    public ElementDefinitionInfo Collector;                                                                                 // MakerGen.cs:211
                    // 11. Specimen.collection.collected[x]
                    public ElementDefinitionInfo Collected;                                                                                 // MakerGen.cs:211
                    // 12. Specimen.collection.duration
                    public ElementDefinitionInfo Duration;                                                                                  // MakerGen.cs:211
                    // 13. Specimen.collection.quantity
                    public ElementDefinitionInfo Quantity;                                                                                  // MakerGen.cs:211
                    // 14. Specimen.collection.method
                    public ElementDefinitionInfo Method;                                                                                    // MakerGen.cs:211
                    // 15. Specimen.collection.bodySite
                    public ElementDefinitionInfo BodySite;                                                                                  // MakerGen.cs:211
                    // 16. Specimen.collection.fastingStatus[x]
                    public ElementDefinitionInfo FastingStatus;                                                                             // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_Collection_Elements()                                                                                       // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 10. Specimen.collection.collector
                            this.Collector = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Collector",                                                                                         // MakerGen.cs:230
                                Path= "Specimen.collection.collector",                                                                      // MakerGen.cs:231
                                Id = "Specimen.collection.collector",                                                                       // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:341
                                    {                                                                                                       // MakerGen.cs:342
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:344
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",                                         // MakerGen.cs:344
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                      // MakerGen.cs:344
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:345
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 11. Specimen.collection.collected[x]
                            this.Collected = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Collected",                                                                                         // MakerGen.cs:230
                                Path= "Specimen.collection.collected[x]",                                                                   // MakerGen.cs:231
                                Id = "Specimen.collection.collected[x]",                                                                    // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.DateTime                                                            // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    },                                                                                                      // MakerGen.cs:299
                                    new FhirKhit.Maker.Common.Complex.Period                                                                // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    }                                                                                                       // MakerGen.cs:355
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 12. Specimen.collection.duration
                            this.Duration = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Duration",                                                                                          // MakerGen.cs:230
                                Path= "Specimen.collection.duration",                                                                       // MakerGen.cs:231
                                Id = "Specimen.collection.duration",                                                                        // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Duration                                                              // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    }                                                                                                       // MakerGen.cs:355
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 13. Specimen.collection.quantity
                            this.Quantity = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Quantity",                                                                                          // MakerGen.cs:230
                                Path= "Specimen.collection.quantity",                                                                       // MakerGen.cs:231
                                Id = "Specimen.collection.quantity",                                                                        // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Quantity                                                              // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    }                                                                                                       // MakerGen.cs:355
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 14. Specimen.collection.method
                            this.Method = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Method",                                                                                            // MakerGen.cs:230
                                Path= "Specimen.collection.method",                                                                         // MakerGen.cs:231
                                Id = "Specimen.collection.method",                                                                          // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 15. Specimen.collection.bodySite
                            this.BodySite = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "BodySite",                                                                                          // MakerGen.cs:230
                                Path= "Specimen.collection.bodySite",                                                                       // MakerGen.cs:231
                                Id = "Specimen.collection.bodySite",                                                                        // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 16. Specimen.collection.fastingStatus[x]
                            this.FastingStatus = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "FastingStatus",                                                                                     // MakerGen.cs:230
                                Path= "Specimen.collection.fastingStatus[x]",                                                               // MakerGen.cs:231
                                Id = "Specimen.collection.fastingStatus[x]",                                                                // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    },                                                                                                      // MakerGen.cs:314
                                    new FhirKhit.Maker.Common.Complex.Duration                                                              // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    }                                                                                                       // MakerGen.cs:355
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        Collector.Write(sDef);                                                                                              // MakerGen.cs:215
                        Collected.Write(sDef);                                                                                              // MakerGen.cs:215
                        Duration.Write(sDef);                                                                                               // MakerGen.cs:215
                        Quantity.Write(sDef);                                                                                               // MakerGen.cs:215
                        Method.Write(sDef);                                                                                                 // MakerGen.cs:215
                        BodySite.Write(sDef);                                                                                               // MakerGen.cs:215
                        FastingStatus.Write(sDef);                                                                                          // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_Collection_Elements Elements                                                                                    // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_Collection_Elements();                                                                 // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_Collection_Elements elements;                                                                                          // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_Collection()                                                                                                    // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "Specimen.collection",                                                                                       // MakerGen.cs:423
                        ElementId = "Specimen.collection"                                                                                   // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 17. Specimen.processing
            public class Type_Processing : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_Processing_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                         // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 18. Specimen.processing.description
                    public ElementDefinitionInfo Description;                                                                               // MakerGen.cs:211
                    // 19. Specimen.processing.procedure
                    public ElementDefinitionInfo Procedure;                                                                                 // MakerGen.cs:211
                    // 20. Specimen.processing.additive
                    public ElementDefinitionInfo Additive;                                                                                  // MakerGen.cs:211
                    // 21. Specimen.processing.time[x]
                    public ElementDefinitionInfo Time;                                                                                      // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_Processing_Elements()                                                                                       // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 18. Specimen.processing.description
                            this.Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Description",                                                                                       // MakerGen.cs:230
                                Path= "Specimen.processing.description",                                                                    // MakerGen.cs:231
                                Id = "Specimen.processing.description",                                                                     // MakerGen.cs:232
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
                            // 19. Specimen.processing.procedure
                            this.Procedure = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Procedure",                                                                                         // MakerGen.cs:230
                                Path= "Specimen.processing.procedure",                                                                      // MakerGen.cs:231
                                Id = "Specimen.processing.procedure",                                                                       // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 20. Specimen.processing.additive
                            this.Additive = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Additive",                                                                                          // MakerGen.cs:230
                                Path= "Specimen.processing.additive",                                                                       // MakerGen.cs:231
                                Id = "Specimen.processing.additive",                                                                        // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:341
                                    {                                                                                                       // MakerGen.cs:342
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:344
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Substance"                                             // MakerGen.cs:344
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:345
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 21. Specimen.processing.time[x]
                            this.Time = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Time",                                                                                              // MakerGen.cs:230
                                Path= "Specimen.processing.time[x]",                                                                        // MakerGen.cs:231
                                Id = "Specimen.processing.time[x]",                                                                         // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.DateTime                                                            // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    },                                                                                                      // MakerGen.cs:299
                                    new FhirKhit.Maker.Common.Complex.Period                                                                // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    }                                                                                                       // MakerGen.cs:355
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        Description.Write(sDef);                                                                                            // MakerGen.cs:215
                        Procedure.Write(sDef);                                                                                              // MakerGen.cs:215
                        Additive.Write(sDef);                                                                                               // MakerGen.cs:215
                        Time.Write(sDef);                                                                                                   // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_Processing_Elements Elements                                                                                    // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_Processing_Elements();                                                                 // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_Processing_Elements elements;                                                                                          // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_Processing()                                                                                                    // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "Specimen.processing",                                                                                       // MakerGen.cs:423
                        ElementId = "Specimen.processing"                                                                                   // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 22. Specimen.container
            public class Type_Container : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_Container_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                          // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 23. Specimen.container.identifier
                    public ElementDefinitionInfo Identifier;                                                                                // MakerGen.cs:211
                    // 24. Specimen.container.description
                    public ElementDefinitionInfo Description;                                                                               // MakerGen.cs:211
                    // 25. Specimen.container.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:211
                    // 26. Specimen.container.capacity
                    public ElementDefinitionInfo Capacity;                                                                                  // MakerGen.cs:211
                    // 27. Specimen.container.specimenQuantity
                    public ElementDefinitionInfo SpecimenQuantity;                                                                          // MakerGen.cs:211
                    // 28. Specimen.container.additive[x]
                    public ElementDefinitionInfo Additive;                                                                                  // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_Container_Elements()                                                                                        // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 23. Specimen.container.identifier
                            this.Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Identifier",                                                                                        // MakerGen.cs:230
                                Path= "Specimen.container.identifier",                                                                      // MakerGen.cs:231
                                Id = "Specimen.container.identifier",                                                                       // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Identifier                                                            // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    }                                                                                                       // MakerGen.cs:355
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 24. Specimen.container.description
                            this.Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Description",                                                                                       // MakerGen.cs:230
                                Path= "Specimen.container.description",                                                                     // MakerGen.cs:231
                                Id = "Specimen.container.description",                                                                      // MakerGen.cs:232
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
                            // 25. Specimen.container.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Type",                                                                                              // MakerGen.cs:230
                                Path= "Specimen.container.type",                                                                            // MakerGen.cs:231
                                Id = "Specimen.container.type",                                                                             // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 26. Specimen.container.capacity
                            this.Capacity = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Capacity",                                                                                          // MakerGen.cs:230
                                Path= "Specimen.container.capacity",                                                                        // MakerGen.cs:231
                                Id = "Specimen.container.capacity",                                                                         // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Quantity                                                              // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    }                                                                                                       // MakerGen.cs:355
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 27. Specimen.container.specimenQuantity
                            this.SpecimenQuantity = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "SpecimenQuantity",                                                                                  // MakerGen.cs:230
                                Path= "Specimen.container.specimenQuantity",                                                                // MakerGen.cs:231
                                Id = "Specimen.container.specimenQuantity",                                                                 // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Quantity                                                              // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    }                                                                                                       // MakerGen.cs:355
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 28. Specimen.container.additive[x]
                            this.Additive = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Additive",                                                                                          // MakerGen.cs:230
                                Path= "Specimen.container.additive[x]",                                                                     // MakerGen.cs:231
                                Id = "Specimen.container.additive[x]",                                                                      // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    },                                                                                                      // MakerGen.cs:314
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:341
                                    {                                                                                                       // MakerGen.cs:342
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:344
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Substance"                                             // MakerGen.cs:344
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:345
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        Identifier.Write(sDef);                                                                                             // MakerGen.cs:215
                        Description.Write(sDef);                                                                                            // MakerGen.cs:215
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:215
                        Capacity.Write(sDef);                                                                                               // MakerGen.cs:215
                        SpecimenQuantity.Write(sDef);                                                                                       // MakerGen.cs:215
                        Additive.Write(sDef);                                                                                               // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_Container_Elements Elements                                                                                     // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_Container_Elements();                                                                  // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_Container_Elements elements;                                                                                           // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_Container()                                                                                                     // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "Specimen.container",                                                                                        // MakerGen.cs:423
                        ElementId = "Specimen.container"                                                                                    // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 1. Specimen.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:211
            // 2. Specimen.accessionIdentifier
            public ElementDefinitionInfo AccessionIdentifier;                                                                               // MakerGen.cs:211
            // 3. Specimen.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:211
            // 4. Specimen.type
            public ElementDefinitionInfo Type;                                                                                              // MakerGen.cs:211
            // 5. Specimen.subject
            public ElementDefinitionInfo Subject;                                                                                           // MakerGen.cs:211
            // 6. Specimen.receivedTime
            public ElementDefinitionInfo ReceivedTime;                                                                                      // MakerGen.cs:211
            // 7. Specimen.parent
            public ElementDefinitionInfo Parent;                                                                                            // MakerGen.cs:211
            // 8. Specimen.request
            public ElementDefinitionInfo Request;                                                                                           // MakerGen.cs:211
            // 9. Specimen.collection
            public ElementDefinitionInfo Collection;                                                                                        // MakerGen.cs:211
            // 17. Specimen.processing
            public ElementDefinitionInfo Processing;                                                                                        // MakerGen.cs:211
            // 22. Specimen.container
            public ElementDefinitionInfo Container;                                                                                         // MakerGen.cs:211
            // 29. Specimen.condition
            public ElementDefinitionInfo Condition;                                                                                         // MakerGen.cs:211
            // 30. Specimen.note
            public ElementDefinitionInfo Note;                                                                                              // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
            public Specimen_Elements()                                                                                                      // MakerGen.cs:387
            {                                                                                                                               // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:226
                    // 1. Specimen.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Identifier",                                                                                                // MakerGen.cs:230
                        Path= "Specimen.identifier",                                                                                        // MakerGen.cs:231
                        Id = "Specimen.identifier",                                                                                         // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. Specimen.accessionIdentifier
                    this.AccessionIdentifier = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "AccessionIdentifier",                                                                                       // MakerGen.cs:230
                        Path= "Specimen.accessionIdentifier",                                                                               // MakerGen.cs:231
                        Id = "Specimen.accessionIdentifier",                                                                                // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 3. Specimen.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Status",                                                                                                    // MakerGen.cs:230
                        Path= "Specimen.status",                                                                                            // MakerGen.cs:231
                        Id = "Specimen.status",                                                                                             // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 4. Specimen.type
                    this.Type = new ElementDefinitionInfo                                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Type",                                                                                                      // MakerGen.cs:230
                        Path= "Specimen.type",                                                                                              // MakerGen.cs:231
                        Id = "Specimen.type",                                                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. Specimen.subject
                    this.Subject = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Subject",                                                                                                   // MakerGen.cs:230
                        Path= "Specimen.subject",                                                                                           // MakerGen.cs:231
                        Id = "Specimen.subject",                                                                                            // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:344
                                    "http://hl7.org/fhir/StructureDefinition/Group",                                                        // MakerGen.cs:344
                                    "http://hl7.org/fhir/StructureDefinition/Device",                                                       // MakerGen.cs:344
                                    "http://hl7.org/fhir/StructureDefinition/Substance",                                                    // MakerGen.cs:344
                                    "http://hl7.org/fhir/StructureDefinition/Location"                                                      // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 6. Specimen.receivedTime
                    this.ReceivedTime = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "ReceivedTime",                                                                                              // MakerGen.cs:230
                        Path= "Specimen.receivedTime",                                                                                      // MakerGen.cs:231
                        Id = "Specimen.receivedTime",                                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 7. Specimen.parent
                    this.Parent = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Parent",                                                                                                    // MakerGen.cs:230
                        Path= "Specimen.parent",                                                                                            // MakerGen.cs:231
                        Id = "Specimen.parent",                                                                                             // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Specimen"                                                      // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 8. Specimen.request
                    this.Request = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Request",                                                                                                   // MakerGen.cs:230
                        Path= "Specimen.request",                                                                                           // MakerGen.cs:231
                        Id = "Specimen.request",                                                                                            // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ServiceRequest"                                                // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 9. Specimen.collection
                    this.Collection = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Collection",                                                                                                // MakerGen.cs:230
                        Path= "Specimen.collection",                                                                                        // MakerGen.cs:231
                        Id = "Specimen.collection",                                                                                         // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Collection                                                                                             // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 17. Specimen.processing
                    this.Processing = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Processing",                                                                                                // MakerGen.cs:230
                        Path= "Specimen.processing",                                                                                        // MakerGen.cs:231
                        Id = "Specimen.processing",                                                                                         // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Processing                                                                                             // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 22. Specimen.container
                    this.Container = new ElementDefinitionInfo                                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Container",                                                                                                 // MakerGen.cs:230
                        Path= "Specimen.container",                                                                                         // MakerGen.cs:231
                        Id = "Specimen.container",                                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Container                                                                                              // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 29. Specimen.condition
                    this.Condition = new ElementDefinitionInfo                                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Condition",                                                                                                 // MakerGen.cs:230
                        Path= "Specimen.condition",                                                                                         // MakerGen.cs:231
                        Id = "Specimen.condition",                                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 30. Specimen.note
                    this.Note = new ElementDefinitionInfo                                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Note",                                                                                                      // MakerGen.cs:230
                        Path= "Specimen.note",                                                                                              // MakerGen.cs:231
                        Id = "Specimen.note",                                                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Annotation                                                                    // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                base.Write(sDef);                                                                                                           // MakerGen.cs:395
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:215
                AccessionIdentifier.Write(sDef);                                                                                            // MakerGen.cs:215
                Status.Write(sDef);                                                                                                         // MakerGen.cs:215
                Type.Write(sDef);                                                                                                           // MakerGen.cs:215
                Subject.Write(sDef);                                                                                                        // MakerGen.cs:215
                ReceivedTime.Write(sDef);                                                                                                   // MakerGen.cs:215
                Parent.Write(sDef);                                                                                                         // MakerGen.cs:215
                Request.Write(sDef);                                                                                                        // MakerGen.cs:215
                Collection.Write(sDef);                                                                                                     // MakerGen.cs:215
                Processing.Write(sDef);                                                                                                     // MakerGen.cs:215
                Container.Write(sDef);                                                                                                      // MakerGen.cs:215
                Condition.Write(sDef);                                                                                                      // MakerGen.cs:215
                Note.Write(sDef);                                                                                                           // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:397
        }                                                                                                                                   // MakerGen.cs:399
        public Specimen_Elements Elements                                                                                                   // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            get                                                                                                                             // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:404
                if (this.elements == null)                                                                                                  // MakerGen.cs:405
                    this.elements = new Specimen_Elements();                                                                                // MakerGen.cs:406
                return this.elements;                                                                                                       // MakerGen.cs:407
            }                                                                                                                               // MakerGen.cs:408
        }                                                                                                                                   // MakerGen.cs:409
        Specimen_Elements elements;                                                                                                         // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
        public Specimen()                                                                                                                   // MakerGen.cs:413
        {                                                                                                                                   // MakerGen.cs:414
            this.Name = "Specimen";                                                                                                         // MakerGen.cs:487
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Specimen";                                                                  // MakerGen.cs:488
        }                                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:419
        {                                                                                                                                   // MakerGen.cs:420
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:421
            {                                                                                                                               // MakerGen.cs:422
                Path = "Specimen",                                                                                                          // MakerGen.cs:423
                ElementId = "Specimen"                                                                                                      // MakerGen.cs:424
            });                                                                                                                             // MakerGen.cs:425
            if (this.elements != null)                                                                                                      // MakerGen.cs:426
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:427
        }                                                                                                                                   // MakerGen.cs:428
    }                                                                                                                                       // MakerGen.cs:429
}                                                                                                                                           // MakerGen.cs:474
