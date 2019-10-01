using System;                                                                                                                               // MakerGen.cs:391
using System.Diagnostics;                                                                                                                   // MakerGen.cs:392
using System.IO;                                                                                                                            // MakerGen.cs:393
using System.Linq;                                                                                                                          // MakerGen.cs:394
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:396
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:397
{                                                                                                                                           // MakerGen.cs:398
    #region Json                                                                                                                            // MakerGen.cs:399
    #if NEVER                                                                                                                               // MakerGen.cs:400
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
    #endregion                                                                                                                              // MakerGen.cs:403
    /// <summary>
    /// Fhir resource 'SupplyDelivery'
    /// </summary>
    // 0. SupplyDelivery
    public class SupplyDelivery : FhirKhit.Maker.Common.Resource.ResourceBase                                                               // MakerGen.cs:352
    {                                                                                                                                       // MakerGen.cs:353
        // 7. SupplyDelivery.suppliedItem
        public class Type_SuppliedItem : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 8. SupplyDelivery.suppliedItem.quantity
            public MakerElementInstance Element_Quantity;                                                                                   // MakerGen.cs:232
            // 9. SupplyDelivery.suppliedItem.item[x]
            public MakerElementInstance Element_Item;                                                                                       // MakerGen.cs:232
            public Type_SuppliedItem()                                                                                                      // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 8. SupplyDelivery.suppliedItem.quantity
                    this.Element_Quantity = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Quantity",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 9. SupplyDelivery.suppliedItem.item[x]
                    this.Element_Item = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Item",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept(),                                                            // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 1. SupplyDelivery.identifier
        public MakerElementInstance Element_Identifier;                                                                                     // MakerGen.cs:232
        // 2. SupplyDelivery.basedOn
        public MakerElementInstance Element_BasedOn;                                                                                        // MakerGen.cs:232
        // 3. SupplyDelivery.partOf
        public MakerElementInstance Element_PartOf;                                                                                         // MakerGen.cs:232
        // 4. SupplyDelivery.status
        public MakerElementInstance Element_Status;                                                                                         // MakerGen.cs:232
        // 5. SupplyDelivery.patient
        public MakerElementInstance Element_Patient;                                                                                        // MakerGen.cs:232
        // 6. SupplyDelivery.type
        public MakerElementInstance Element_Type;                                                                                           // MakerGen.cs:232
        // 10. SupplyDelivery.occurrence[x]
        public MakerElementInstance Element_Occurrence;                                                                                     // MakerGen.cs:232
        // 11. SupplyDelivery.supplier
        public MakerElementInstance Element_Supplier;                                                                                       // MakerGen.cs:232
        // 12. SupplyDelivery.destination
        public MakerElementInstance Element_Destination;                                                                                    // MakerGen.cs:232
        // 13. SupplyDelivery.receiver
        public MakerElementInstance Element_Receiver;                                                                                       // MakerGen.cs:232
        public SupplyDelivery()                                                                                                             // MakerGen.cs:361
        {                                                                                                                                   // MakerGen.cs:362
            {                                                                                                                               // MakerGen.cs:243
                // 1. SupplyDelivery.identifier
                this.Element_Identifier = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 2. SupplyDelivery.basedOn
                this.Element_BasedOn = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_BasedOn",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 3. SupplyDelivery.partOf
                this.Element_PartOf = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_PartOf",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 4. SupplyDelivery.status
                this.Element_Status = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Status",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code()                                                                          // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 5. SupplyDelivery.patient
                this.Element_Patient = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Patient",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 6. SupplyDelivery.type
                this.Element_Type = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 10. SupplyDelivery.occurrence[x]
                this.Element_Occurrence = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Occurrence",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.DateTime(),                                                                     // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 11. SupplyDelivery.supplier
                this.Element_Supplier = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Supplier",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 12. SupplyDelivery.destination
                this.Element_Destination = new MakerElementInstance                                                                         // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Destination",                                                                                           // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 13. SupplyDelivery.receiver
                this.Element_Receiver = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Receiver",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
        }                                                                                                                                   // MakerGen.cs:373
    }                                                                                                                                       // MakerGen.cs:357
}                                                                                                                                           // MakerGen.cs:408
