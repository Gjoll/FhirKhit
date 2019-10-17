using System;                                                                                                                               // MakerGen.cs:432
using System.Diagnostics;                                                                                                                   // MakerGen.cs:433
using System.IO;                                                                                                                            // MakerGen.cs:434
using System.Linq;                                                                                                                          // MakerGen.cs:435
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:436
                                                                                                                                            // MakerGen.cs:437
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:438
{                                                                                                                                           // MakerGen.cs:439
    #region Json                                                                                                                            // MakerGen.cs:440
    #if NEVER                                                                                                                               // MakerGen.cs:441
    {
      "resourceType": "StructureDefinition",
      "id": "SupplyDelivery",
      "url": "http://hl7.org/fhir/StructureDefinition/SupplyDelivery",
      "version": "4.0.0",
      "name": "SupplyDelivery",
      "status": "draft",
      "publisher": "Health Level Seven International (Orders and Observations)",
      "description": "Record of delivery of what is supplied.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "SupplyDelivery",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "SupplyDelivery",
            "path": "SupplyDelivery",
            "short": "Delivery of bulk Supplies",
            "definition": "Record of delivery of what is supplied.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "SupplyDelivery.identifier",
            "path": "SupplyDelivery.identifier",
            "short": "External identifier",
            "definition": "Identifier for the supply delivery event that is used to identify it across multiple disparate systems.",
            "comment": "This identifier is typically assigned by the dispenser, and may be used to reference the delivery when exchanging information about it with other systems.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ]
          },
          {
            "id": "SupplyDelivery.basedOn",
            "path": "SupplyDelivery.basedOn",
            "short": "Fulfills plan, proposal or order",
            "definition": "A plan, proposal or order that is fulfilled in whole or in part by this event.",
            "requirements": "Allows tracing of authorization for the event and tracking whether proposals/recommendations were acted upon.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/SupplyRequest"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "SupplyDelivery.partOf",
            "path": "SupplyDelivery.partOf",
            "short": "Part of referenced event",
            "definition": "A larger event of which this particular event is a component or step.",
            "comment": "Not to be used to link an event to an Encounter - use Event.context for that.\r\r[The allowed reference resources may be adjusted as appropriate for the event resource].",
            "requirements": "E.g. Drug administration as part of a procedure, procedure as part of observation, etc.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/SupplyDelivery",
                  "http://hl7.org/fhir/StructureDefinition/Contract"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "SupplyDelivery.status",
            "path": "SupplyDelivery.status",
            "short": "in-progress | completed | abandoned | entered-in-error",
            "definition": "A code specifying the state of the dispense event.",
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
                  "valueString": "SupplyDeliveryStatus"
                }
              ],
              "strength": "required",
              "description": "Status of the supply delivery.",
              "valueSet": "http://hl7.org/fhir/ValueSet/supplydelivery-status|4.0.0"
            }
          },
          {
            "id": "SupplyDelivery.patient",
            "path": "SupplyDelivery.patient",
            "short": "Patient for whom the item is supplied",
            "definition": "A link to a resource representing the person whom the delivered item is for.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient"
                ]
              }
            ]
          },
          {
            "id": "SupplyDelivery.type",
            "path": "SupplyDelivery.type",
            "short": "Category of dispense event",
            "definition": "Indicates the type of dispensing event that is performed. Examples include: Trial Fill, Completion of Trial, Partial Fill, Emergency Fill, Samples, etc.",
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
                  "valueString": "SupplyDeliveryType"
                }
              ],
              "strength": "required",
              "description": "The type of supply dispense.",
              "valueSet": "http://hl7.org/fhir/ValueSet/supplydelivery-type|4.0.0"
            }
          },
          {
            "id": "SupplyDelivery.suppliedItem",
            "path": "SupplyDelivery.suppliedItem",
            "short": "The item that is delivered or supplied",
            "definition": "The item that is being delivered or has been supplied.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "SupplyDelivery.suppliedItem.quantity",
            "path": "SupplyDelivery.suppliedItem.quantity",
            "short": "Amount dispensed",
            "definition": "The amount of supply that has been dispensed. Includes unit of measure.",
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
            "id": "SupplyDelivery.suppliedItem.item[x]",
            "path": "SupplyDelivery.suppliedItem.item[x]",
            "short": "Medication, Substance, or Device supplied",
            "definition": "Identifies the medication, substance or device being dispensed. This is either a link to a resource representing the details of the item or a code that identifies the item from a known list.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Medication",
                  "http://hl7.org/fhir/StructureDefinition/Substance",
                  "http://hl7.org/fhir/StructureDefinition/Device"
                ]
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "SupplyDeliveryItem"
                }
              ],
              "strength": "example",
              "description": "The item that was delivered.",
              "valueSet": "http://hl7.org/fhir/ValueSet/supply-item"
            }
          },
          {
            "id": "SupplyDelivery.occurrence[x]",
            "path": "SupplyDelivery.occurrence[x]",
            "short": "When event occurred",
            "definition": "The date or time(s) the activity occurred.",
            "comment": "[The list of types may be constrained as appropriate for the type of event].",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              },
              {
                "code": "Period"
              },
              {
                "code": "Timing"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SupplyDelivery.supplier",
            "path": "SupplyDelivery.supplier",
            "short": "Dispenser",
            "definition": "The individual responsible for dispensing the medication, supplier or device.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ]
          },
          {
            "id": "SupplyDelivery.destination",
            "path": "SupplyDelivery.destination",
            "short": "Where the Supply was sent",
            "definition": "Identification of the facility/location where the Supply was shipped to, as part of the dispense event.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Location"
                ]
              }
            ]
          },
          {
            "id": "SupplyDelivery.receiver",
            "path": "SupplyDelivery.receiver",
            "short": "Who collected the Supply",
            "definition": "Identifies the person who picked up the Supply.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                ]
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:444
    /// <summary>
    /// Fhir resource 'SupplyDelivery'
    /// </summary>
    // 0. SupplyDelivery
    public partial class Resource_SupplyDelivery : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                   // MakerGen.cs:381
    {                                                                                                                                       // MakerGen.cs:382
        // 7. SupplyDelivery.suppliedItem
        public partial class Type_SuppliedItem : FhirKhit.Maker.Common.Complex.ComplexBase                                                  // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 8. SupplyDelivery.suppliedItem.quantity
            public ElementDefinitionInfo Element_Quantity;                                                                                  // MakerGen.cs:217
            // 9. SupplyDelivery.suppliedItem.item[x]
            public ElementDefinitionInfo Element_Item;                                                                                      // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "SupplyDelivery.suppliedItem",                                                                                   // MakerGen.cs:393
                    ElementId = "SupplyDelivery.suppliedItem"                                                                               // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_Quantity.Write(sDef);                                                                                               // MakerGen.cs:221
                Element_Item.Write(sDef);                                                                                                   // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_SuppliedItem()                                                                                                      // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 8. SupplyDelivery.suppliedItem.quantity
                    this.Element_Quantity = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Quantity",                                                                                          // MakerGen.cs:236
                        Path= "SupplyDelivery.suppliedItem.quantity",                                                                       // MakerGen.cs:237
                        Id = "SupplyDelivery.suppliedItem.quantity",                                                                        // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:356
                            {                                                                                                               // MakerGen.cs:357
                            }                                                                                                               // MakerGen.cs:358
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 9. SupplyDelivery.suppliedItem.item[x]
                    this.Element_Item = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Item",                                                                                              // MakerGen.cs:236
                        Path= "SupplyDelivery.suppliedItem.item[x]",                                                                        // MakerGen.cs:237
                        Id = "SupplyDelivery.suppliedItem.item[x]",                                                                         // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:316
                            {                                                                                                               // MakerGen.cs:317
                            },                                                                                                              // MakerGen.cs:320
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:344
                            {                                                                                                               // MakerGen.cs:345
                                TargetProfile = new String[]                                                                                // MakerGen.cs:347
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Medication",                                                   // MakerGen.cs:347
                                    "http://hl7.org/fhir/StructureDefinition/Substance",                                                    // MakerGen.cs:347
                                    "http://hl7.org/fhir/StructureDefinition/Device"                                                        // MakerGen.cs:347
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:348
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 1. SupplyDelivery.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:217
        // 2. SupplyDelivery.basedOn
        public ElementDefinitionInfo Element_BasedOn;                                                                                       // MakerGen.cs:217
        // 3. SupplyDelivery.partOf
        public ElementDefinitionInfo Element_PartOf;                                                                                        // MakerGen.cs:217
        // 4. SupplyDelivery.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:217
        // 5. SupplyDelivery.patient
        public ElementDefinitionInfo Element_Patient;                                                                                       // MakerGen.cs:217
        // 6. SupplyDelivery.type
        public ElementDefinitionInfo Element_Type;                                                                                          // MakerGen.cs:217
        // 7. SupplyDelivery.suppliedItem
        public ElementDefinitionInfo Element_SuppliedItem;                                                                                  // MakerGen.cs:217
        // 10. SupplyDelivery.occurrence[x]
        public ElementDefinitionInfo Element_Occurrence;                                                                                    // MakerGen.cs:217
        // 11. SupplyDelivery.supplier
        public ElementDefinitionInfo Element_Supplier;                                                                                      // MakerGen.cs:217
        // 12. SupplyDelivery.destination
        public ElementDefinitionInfo Element_Destination;                                                                                   // MakerGen.cs:217
        // 13. SupplyDelivery.receiver
        public ElementDefinitionInfo Element_Receiver;                                                                                      // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:388
        {                                                                                                                                   // MakerGen.cs:389
            base.Write(sDef);                                                                                                               // MakerGen.cs:390
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:391
            {                                                                                                                               // MakerGen.cs:392
                Path = "SupplyDelivery",                                                                                                    // MakerGen.cs:393
                ElementId = "SupplyDelivery"                                                                                                // MakerGen.cs:394
            });                                                                                                                             // MakerGen.cs:395
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:221
            Element_BasedOn.Write(sDef);                                                                                                    // MakerGen.cs:221
            Element_PartOf.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_Patient.Write(sDef);                                                                                                    // MakerGen.cs:221
            Element_Type.Write(sDef);                                                                                                       // MakerGen.cs:221
            Element_SuppliedItem.Write(sDef);                                                                                               // MakerGen.cs:221
            Element_Occurrence.Write(sDef);                                                                                                 // MakerGen.cs:221
            Element_Supplier.Write(sDef);                                                                                                   // MakerGen.cs:221
            Element_Destination.Write(sDef);                                                                                                // MakerGen.cs:221
            Element_Receiver.Write(sDef);                                                                                                   // MakerGen.cs:221
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
        public Resource_SupplyDelivery()                                                                                                    // MakerGen.cs:400
        {                                                                                                                                   // MakerGen.cs:401
            {                                                                                                                               // MakerGen.cs:232
                // 1. SupplyDelivery.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:236
                    Path= "SupplyDelivery.identifier",                                                                                      // MakerGen.cs:237
                    Id = "SupplyDelivery.identifier",                                                                                       // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 2. SupplyDelivery.basedOn
                this.Element_BasedOn = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_BasedOn",                                                                                               // MakerGen.cs:236
                    Path= "SupplyDelivery.basedOn",                                                                                         // MakerGen.cs:237
                    Id = "SupplyDelivery.basedOn",                                                                                          // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/SupplyRequest"                                                     // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 3. SupplyDelivery.partOf
                this.Element_PartOf = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_PartOf",                                                                                                // MakerGen.cs:236
                    Path= "SupplyDelivery.partOf",                                                                                          // MakerGen.cs:237
                    Id = "SupplyDelivery.partOf",                                                                                           // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/SupplyDelivery",                                                   // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/Contract"                                                          // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 4. SupplyDelivery.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Status",                                                                                                // MakerGen.cs:236
                    Path= "SupplyDelivery.status",                                                                                          // MakerGen.cs:237
                    Id = "SupplyDelivery.status",                                                                                           // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 5. SupplyDelivery.patient
                this.Element_Patient = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Patient",                                                                                               // MakerGen.cs:236
                    Path= "SupplyDelivery.patient",                                                                                         // MakerGen.cs:237
                    Id = "SupplyDelivery.patient",                                                                                          // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Patient"                                                           // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 6. SupplyDelivery.type
                this.Element_Type = new ElementDefinitionInfo                                                                               // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:236
                    Path= "SupplyDelivery.type",                                                                                            // MakerGen.cs:237
                    Id = "SupplyDelivery.type",                                                                                             // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 7. SupplyDelivery.suppliedItem
                this.Element_SuppliedItem = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_SuppliedItem",                                                                                          // MakerGen.cs:236
                    Path= "SupplyDelivery.suppliedItem",                                                                                    // MakerGen.cs:237
                    Id = "SupplyDelivery.suppliedItem",                                                                                     // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_SuppliedItem                                                                                               // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 10. SupplyDelivery.occurrence[x]
                this.Element_Occurrence = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Occurrence",                                                                                            // MakerGen.cs:236
                    Path= "SupplyDelivery.occurrence[x]",                                                                                   // MakerGen.cs:237
                    Id = "SupplyDelivery.occurrence[x]",                                                                                    // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        },                                                                                                                  // MakerGen.cs:305
                        new FhirKhit.Maker.Common.Complex.Type_Period                                                                       // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        },                                                                                                                  // MakerGen.cs:358
                        new FhirKhit.Maker.Common.Complex.Type_Timing                                                                       // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 11. SupplyDelivery.supplier
                this.Element_Supplier = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Supplier",                                                                                              // MakerGen.cs:236
                    Path= "SupplyDelivery.supplier",                                                                                        // MakerGen.cs:237
                    Id = "SupplyDelivery.supplier",                                                                                         // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                                 // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 12. SupplyDelivery.destination
                this.Element_Destination = new ElementDefinitionInfo                                                                        // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Destination",                                                                                           // MakerGen.cs:236
                    Path= "SupplyDelivery.destination",                                                                                     // MakerGen.cs:237
                    Id = "SupplyDelivery.destination",                                                                                      // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Location"                                                          // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 13. SupplyDelivery.receiver
                this.Element_Receiver = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Receiver",                                                                                              // MakerGen.cs:236
                    Path= "SupplyDelivery.receiver",                                                                                        // MakerGen.cs:237
                    Id = "SupplyDelivery.receiver",                                                                                         // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                                  // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            this.Name = "SupplyDelivery";                                                                                                   // MakerGen.cs:468
            this.Uri = "http://hl7.org/fhir/StructureDefinition/SupplyDelivery";                                                            // MakerGen.cs:469
        }                                                                                                                                   // MakerGen.cs:403
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:449
