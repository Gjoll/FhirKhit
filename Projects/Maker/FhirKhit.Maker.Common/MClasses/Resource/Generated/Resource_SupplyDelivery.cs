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
    #endregion
    /// <summary>
    /// Fhir resource 'SupplyDelivery'
    /// </summary>
    // 0. SupplyDelivery
    public partial class Resource_SupplyDelivery : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 7. SupplyDelivery.suppliedItem
        public partial class Type_SuppliedItem : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 8. SupplyDelivery.suppliedItem.quantity
            public ElementDefinitionInfo Element_Quantity;
            // 9. SupplyDelivery.suppliedItem.item[x]
            public ElementDefinitionInfo Element_Item;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "SupplyDelivery.suppliedItem",
                    ElementId = "SupplyDelivery.suppliedItem"
                });
                Element_Quantity.Write(sDef);
                Element_Item.Write(sDef);
            }
            
            public Type_SuppliedItem()
            {
                {
                    // 8. SupplyDelivery.suppliedItem.quantity
                    this.Element_Quantity = new ElementDefinitionInfo
                    {
                        Name = "Element_Quantity",
                        Path= "SupplyDelivery.suppliedItem.quantity",
                        Id = "SupplyDelivery.suppliedItem.quantity",
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
                    // 9. SupplyDelivery.suppliedItem.item[x]
                    this.Element_Item = new ElementDefinitionInfo
                    {
                        Name = "Element_Item",
                        Path= "SupplyDelivery.suppliedItem.item[x]",
                        Id = "SupplyDelivery.suppliedItem.item[x]",
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
                                    "http://hl7.org/fhir/StructureDefinition/Medication",
                                    "http://hl7.org/fhir/StructureDefinition/Substance",
                                    "http://hl7.org/fhir/StructureDefinition/Device"
                                }
                            }
                        }
                    };
                }
            }
        }
        // 1. SupplyDelivery.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. SupplyDelivery.basedOn
        public ElementDefinitionInfo Element_BasedOn;
        // 3. SupplyDelivery.partOf
        public ElementDefinitionInfo Element_PartOf;
        // 4. SupplyDelivery.status
        public ElementDefinitionInfo Element_Status;
        // 5. SupplyDelivery.patient
        public ElementDefinitionInfo Element_Patient;
        // 6. SupplyDelivery.type
        public ElementDefinitionInfo Element_Type;
        // 7. SupplyDelivery.suppliedItem
        public ElementDefinitionInfo Element_SuppliedItem;
        // 10. SupplyDelivery.occurrence[x]
        public ElementDefinitionInfo Element_Occurrence;
        // 11. SupplyDelivery.supplier
        public ElementDefinitionInfo Element_Supplier;
        // 12. SupplyDelivery.destination
        public ElementDefinitionInfo Element_Destination;
        // 13. SupplyDelivery.receiver
        public ElementDefinitionInfo Element_Receiver;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "SupplyDelivery",
                ElementId = "SupplyDelivery"
            });
            Element_Identifier.Write(sDef);
            Element_BasedOn.Write(sDef);
            Element_PartOf.Write(sDef);
            Element_Status.Write(sDef);
            Element_Patient.Write(sDef);
            Element_Type.Write(sDef);
            Element_SuppliedItem.Write(sDef);
            Element_Occurrence.Write(sDef);
            Element_Supplier.Write(sDef);
            Element_Destination.Write(sDef);
            Element_Receiver.Write(sDef);
        }
        
        public Resource_SupplyDelivery()
        {
            {
                // 1. SupplyDelivery.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "SupplyDelivery.identifier",
                    Id = "SupplyDelivery.identifier",
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
                // 2. SupplyDelivery.basedOn
                this.Element_BasedOn = new ElementDefinitionInfo
                {
                    Name = "Element_BasedOn",
                    Path= "SupplyDelivery.basedOn",
                    Id = "SupplyDelivery.basedOn",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/SupplyRequest"
                            }
                        }
                    }
                };
            }
            {
                // 3. SupplyDelivery.partOf
                this.Element_PartOf = new ElementDefinitionInfo
                {
                    Name = "Element_PartOf",
                    Path= "SupplyDelivery.partOf",
                    Id = "SupplyDelivery.partOf",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/SupplyDelivery",
                                "http://hl7.org/fhir/StructureDefinition/Contract"
                            }
                        }
                    }
                };
            }
            {
                // 4. SupplyDelivery.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "SupplyDelivery.status",
                    Id = "SupplyDelivery.status",
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
                // 5. SupplyDelivery.patient
                this.Element_Patient = new ElementDefinitionInfo
                {
                    Name = "Element_Patient",
                    Path= "SupplyDelivery.patient",
                    Id = "SupplyDelivery.patient",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Patient"
                            }
                        }
                    }
                };
            }
            {
                // 6. SupplyDelivery.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "SupplyDelivery.type",
                    Id = "SupplyDelivery.type",
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
                // 7. SupplyDelivery.suppliedItem
                this.Element_SuppliedItem = new ElementDefinitionInfo
                {
                    Name = "Element_SuppliedItem",
                    Path= "SupplyDelivery.suppliedItem",
                    Id = "SupplyDelivery.suppliedItem",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_SuppliedItem
                        {
                        }
                    }
                };
            }
            {
                // 10. SupplyDelivery.occurrence[x]
                this.Element_Occurrence = new ElementDefinitionInfo
                {
                    Name = "Element_Occurrence",
                    Path= "SupplyDelivery.occurrence[x]",
                    Id = "SupplyDelivery.occurrence[x]",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Period
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Timing
                        {
                        }
                    }
                };
            }
            {
                // 11. SupplyDelivery.supplier
                this.Element_Supplier = new ElementDefinitionInfo
                {
                    Name = "Element_Supplier",
                    Path= "SupplyDelivery.supplier",
                    Id = "SupplyDelivery.supplier",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                "http://hl7.org/fhir/StructureDefinition/Organization"
                            }
                        }
                    }
                };
            }
            {
                // 12. SupplyDelivery.destination
                this.Element_Destination = new ElementDefinitionInfo
                {
                    Name = "Element_Destination",
                    Path= "SupplyDelivery.destination",
                    Id = "SupplyDelivery.destination",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Location"
                            }
                        }
                    }
                };
            }
            {
                // 13. SupplyDelivery.receiver
                this.Element_Receiver = new ElementDefinitionInfo
                {
                    Name = "Element_Receiver",
                    Path= "SupplyDelivery.receiver",
                    Id = "SupplyDelivery.receiver",
                    Min = 0,
                    Max = -1,
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
            this.Name = "SupplyDelivery";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/SupplyDelivery";
        }
    }
}
