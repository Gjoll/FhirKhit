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
      "id": "SupplyRequest",
      "url": "http://hl7.org/fhir/StructureDefinition/SupplyRequest",
      "version": "4.0.0",
      "name": "SupplyRequest",
      "status": "draft",
      "publisher": "Health Level Seven International (Orders and Observations)",
      "description": "A record of a request for a medication, substance or device used in the healthcare setting.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "SupplyRequest",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "SupplyRequest",
            "path": "SupplyRequest",
            "short": "Request for a medication, substance or device",
            "definition": "A record of a request for a medication, substance or device used in the healthcare setting.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "SupplyRequest.identifier",
            "path": "SupplyRequest.identifier",
            "short": "Business Identifier for SupplyRequest",
            "definition": "Business identifiers assigned to this SupplyRequest by the author and/or other systems. These identifiers remain constant as the resource is updated and propagates from server to server.",
            "comment": "The identifier.type element is used to distinguish between the identifiers assigned by the requester/placer and the performer/filler.",
            "requirements": "Allows identification of the request as it is known by various participating systems and in a way that remains consistent across servers.",
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
            "id": "SupplyRequest.status",
            "path": "SupplyRequest.status",
            "short": "draft | active | suspended +",
            "definition": "Status of the supply request.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element is labeled as a modifier because it is a status element that contains status entered-in-error which means that the resource should not be treated as valid",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "SupplyRequestStatus"
                }
              ],
              "strength": "required",
              "description": "Status of the supply request.",
              "valueSet": "http://hl7.org/fhir/ValueSet/supplyrequest-status|4.0.0"
            }
          },
          {
            "id": "SupplyRequest.category",
            "path": "SupplyRequest.category",
            "short": "The kind of supply (central, non-stock, etc.)",
            "definition": "Category of supply, e.g.  central, non-stock, etc. This is used to support work flows associated with the supply process.",
            "alias": [
              "kind"
            ],
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
                  "valueString": "SupplyRequestKind"
                }
              ],
              "strength": "example",
              "description": "Category of supply request.",
              "valueSet": "http://hl7.org/fhir/ValueSet/supplyrequest-kind"
            }
          },
          {
            "id": "SupplyRequest.priority",
            "path": "SupplyRequest.priority",
            "short": "routine | urgent | asap | stat",
            "definition": "Indicates how quickly this SupplyRequest should be addressed with respect to other requests.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "meaningWhenMissing": "If missing, this task should be performed with normal priority",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "RequestPriority"
                }
              ],
              "strength": "required",
              "description": "Identifies the level of importance to be assigned to actioning the request.",
              "valueSet": "http://hl7.org/fhir/ValueSet/request-priority|4.0.0"
            }
          },
          {
            "id": "SupplyRequest.item[x]",
            "path": "SupplyRequest.item[x]",
            "short": "Medication, Substance, or Device requested to be supplied",
            "definition": "The item that is requested to be supplied. This is either a link to a resource representing the details of the item or a code that identifies the item from a known list.",
            "comment": "Note that there's a difference between a prescription - an instruction to take a medication, along with a (sometimes) implicit supply, and an explicit request to supply, with no explicit instructions.",
            "min": 1,
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
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "SupplyRequestItem"
                }
              ],
              "strength": "example",
              "description": "The item that was requested.",
              "valueSet": "http://hl7.org/fhir/ValueSet/supply-item"
            }
          },
          {
            "id": "SupplyRequest.quantity",
            "path": "SupplyRequest.quantity",
            "short": "The requested amount of the item indicated",
            "definition": "The amount that is being ordered of the indicated item.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Quantity"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SupplyRequest.parameter",
            "path": "SupplyRequest.parameter",
            "short": "Ordered item details",
            "definition": "Specific parameters for the ordered item.  For example, the size of the indicated item.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "SupplyRequest.parameter.code",
            "path": "SupplyRequest.parameter.code",
            "short": "Item detail",
            "definition": "A code or string that identifies the device detail being asserted.",
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
                  "valueString": "ParameterCode"
                }
              ],
              "strength": "example",
              "description": "A code that identifies the device detail."
            }
          },
          {
            "id": "SupplyRequest.parameter.value[x]",
            "path": "SupplyRequest.parameter.value[x]",
            "short": "Value of detail",
            "definition": "The value of the device detail.",
            "comment": "Range means device should have a value that falls somewhere within the specified range.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              },
              {
                "code": "Quantity"
              },
              {
                "code": "Range"
              },
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "SupplyRequest.occurrence[x]",
            "path": "SupplyRequest.occurrence[x]",
            "short": "When the request should be fulfilled",
            "definition": "When the request should be fulfilled.",
            "alias": [
              "when",
              "timing"
            ],
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
            "id": "SupplyRequest.authoredOn",
            "path": "SupplyRequest.authoredOn",
            "short": "When the request was made",
            "definition": "When the request was made.",
            "alias": [
              "date",
              "createdOn",
              "signedOn"
            ],
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
            "id": "SupplyRequest.requester",
            "path": "SupplyRequest.requester",
            "short": "Individual making the request",
            "definition": "The device, practitioner, etc. who initiated the request.",
            "alias": [
              "author",
              "source"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/Device"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "SupplyRequest.supplier",
            "path": "SupplyRequest.supplier",
            "short": "Who is intended to fulfill the request",
            "definition": "Who is intended to fulfill the request.",
            "alias": [
              "performer"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/HealthcareService"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "SupplyRequest.reasonCode",
            "path": "SupplyRequest.reasonCode",
            "short": "The reason why the supply item was requested",
            "definition": "The reason why the supply item was requested.",
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
                  "valueString": "SupplyRequestReason"
                }
              ],
              "strength": "example",
              "description": "The reason why the supply item was requested.",
              "valueSet": "http://hl7.org/fhir/ValueSet/supplyrequest-reason"
            }
          },
          {
            "id": "SupplyRequest.reasonReference",
            "path": "SupplyRequest.reasonReference",
            "short": "The reason why the supply item was requested",
            "definition": "The reason why the supply item was requested.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Condition",
                  "http://hl7.org/fhir/StructureDefinition/Observation",
                  "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",
                  "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                ]
              }
            ]
          },
          {
            "id": "SupplyRequest.deliverFrom",
            "path": "SupplyRequest.deliverFrom",
            "short": "The origin of the supply",
            "definition": "Where the supply is expected to come from.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/Location"
                ]
              }
            ]
          },
          {
            "id": "SupplyRequest.deliverTo",
            "path": "SupplyRequest.deliverTo",
            "short": "The destination of the supply",
            "definition": "Where the supply is destined to go.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/Location",
                  "http://hl7.org/fhir/StructureDefinition/Patient"
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
    /// Fhir resource 'SupplyRequest'
    /// </summary>
    // 0. SupplyRequest
    public class Resource_SupplyRequest : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 7. SupplyRequest.parameter
        public class Type_Parameter : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 8. SupplyRequest.parameter.code
            public ElementDefinitionInfo Element_Code;
            // 9. SupplyRequest.parameter.value[x]
            public ElementDefinitionInfo Element_Value;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "SupplyRequest.parameter",
                    ElementId = "SupplyRequest.parameter"
                });
                Element_Code.Write(sDef);
                Element_Value.Write(sDef);
            }
            
            public Type_Parameter()
            {
                {
                    // 8. SupplyRequest.parameter.code
                    this.Element_Code = new ElementDefinitionInfo
                    {
                        Name = "Element_Code",
                        Path= "SupplyRequest.parameter.code",
                        Id = "SupplyRequest.parameter.code",
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
                    // 9. SupplyRequest.parameter.value[x]
                    this.Element_Value = new ElementDefinitionInfo
                    {
                        Name = "Element_Value",
                        Path= "SupplyRequest.parameter.value[x]",
                        Id = "SupplyRequest.parameter.value[x]",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Quantity
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Range
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_Boolean
                            {
                            }
                        }
                    };
                }
            }
        }
        // 1. SupplyRequest.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. SupplyRequest.status
        public ElementDefinitionInfo Element_Status;
        // 3. SupplyRequest.category
        public ElementDefinitionInfo Element_Category;
        // 4. SupplyRequest.priority
        public ElementDefinitionInfo Element_Priority;
        // 5. SupplyRequest.item[x]
        public ElementDefinitionInfo Element_Item;
        // 6. SupplyRequest.quantity
        public ElementDefinitionInfo Element_Quantity;
        // 7. SupplyRequest.parameter
        public ElementDefinitionInfo Element_Parameter;
        // 10. SupplyRequest.occurrence[x]
        public ElementDefinitionInfo Element_Occurrence;
        // 11. SupplyRequest.authoredOn
        public ElementDefinitionInfo Element_AuthoredOn;
        // 12. SupplyRequest.requester
        public ElementDefinitionInfo Element_Requester;
        // 13. SupplyRequest.supplier
        public ElementDefinitionInfo Element_Supplier;
        // 14. SupplyRequest.reasonCode
        public ElementDefinitionInfo Element_ReasonCode;
        // 15. SupplyRequest.reasonReference
        public ElementDefinitionInfo Element_ReasonReference;
        // 16. SupplyRequest.deliverFrom
        public ElementDefinitionInfo Element_DeliverFrom;
        // 17. SupplyRequest.deliverTo
        public ElementDefinitionInfo Element_DeliverTo;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "SupplyRequest",
                ElementId = "SupplyRequest"
            });
            Element_Identifier.Write(sDef);
            Element_Status.Write(sDef);
            Element_Category.Write(sDef);
            Element_Priority.Write(sDef);
            Element_Item.Write(sDef);
            Element_Quantity.Write(sDef);
            Element_Parameter.Write(sDef);
            Element_Occurrence.Write(sDef);
            Element_AuthoredOn.Write(sDef);
            Element_Requester.Write(sDef);
            Element_Supplier.Write(sDef);
            Element_ReasonCode.Write(sDef);
            Element_ReasonReference.Write(sDef);
            Element_DeliverFrom.Write(sDef);
            Element_DeliverTo.Write(sDef);
        }
        
        public Resource_SupplyRequest()
        {
            {
                // 1. SupplyRequest.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "SupplyRequest.identifier",
                    Id = "SupplyRequest.identifier",
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
                // 2. SupplyRequest.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "SupplyRequest.status",
                    Id = "SupplyRequest.status",
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
                // 3. SupplyRequest.category
                this.Element_Category = new ElementDefinitionInfo
                {
                    Name = "Element_Category",
                    Path= "SupplyRequest.category",
                    Id = "SupplyRequest.category",
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
                // 4. SupplyRequest.priority
                this.Element_Priority = new ElementDefinitionInfo
                {
                    Name = "Element_Priority",
                    Path= "SupplyRequest.priority",
                    Id = "SupplyRequest.priority",
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
                // 5. SupplyRequest.item[x]
                this.Element_Item = new ElementDefinitionInfo
                {
                    Name = "Element_Item",
                    Path= "SupplyRequest.item[x]",
                    Id = "SupplyRequest.item[x]",
                    Min = 1,
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
            {
                // 6. SupplyRequest.quantity
                this.Element_Quantity = new ElementDefinitionInfo
                {
                    Name = "Element_Quantity",
                    Path= "SupplyRequest.quantity",
                    Id = "SupplyRequest.quantity",
                    Min = 1,
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
                // 7. SupplyRequest.parameter
                this.Element_Parameter = new ElementDefinitionInfo
                {
                    Name = "Element_Parameter",
                    Path= "SupplyRequest.parameter",
                    Id = "SupplyRequest.parameter",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Parameter
                        {
                        }
                    }
                };
            }
            {
                // 10. SupplyRequest.occurrence[x]
                this.Element_Occurrence = new ElementDefinitionInfo
                {
                    Name = "Element_Occurrence",
                    Path= "SupplyRequest.occurrence[x]",
                    Id = "SupplyRequest.occurrence[x]",
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
                // 11. SupplyRequest.authoredOn
                this.Element_AuthoredOn = new ElementDefinitionInfo
                {
                    Name = "Element_AuthoredOn",
                    Path= "SupplyRequest.authoredOn",
                    Id = "SupplyRequest.authoredOn",
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
                // 12. SupplyRequest.requester
                this.Element_Requester = new ElementDefinitionInfo
                {
                    Name = "Element_Requester",
                    Path= "SupplyRequest.requester",
                    Id = "SupplyRequest.requester",
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
                                "http://hl7.org/fhir/StructureDefinition/Organization",
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                                "http://hl7.org/fhir/StructureDefinition/Device"
                            }
                        }
                    }
                };
            }
            {
                // 13. SupplyRequest.supplier
                this.Element_Supplier = new ElementDefinitionInfo
                {
                    Name = "Element_Supplier",
                    Path= "SupplyRequest.supplier",
                    Id = "SupplyRequest.supplier",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Organization",
                                "http://hl7.org/fhir/StructureDefinition/HealthcareService"
                            }
                        }
                    }
                };
            }
            {
                // 14. SupplyRequest.reasonCode
                this.Element_ReasonCode = new ElementDefinitionInfo
                {
                    Name = "Element_ReasonCode",
                    Path= "SupplyRequest.reasonCode",
                    Id = "SupplyRequest.reasonCode",
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
                // 15. SupplyRequest.reasonReference
                this.Element_ReasonReference = new ElementDefinitionInfo
                {
                    Name = "Element_ReasonReference",
                    Path= "SupplyRequest.reasonReference",
                    Id = "SupplyRequest.reasonReference",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Condition",
                                "http://hl7.org/fhir/StructureDefinition/Observation",
                                "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",
                                "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                            }
                        }
                    }
                };
            }
            {
                // 16. SupplyRequest.deliverFrom
                this.Element_DeliverFrom = new ElementDefinitionInfo
                {
                    Name = "Element_DeliverFrom",
                    Path= "SupplyRequest.deliverFrom",
                    Id = "SupplyRequest.deliverFrom",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Organization",
                                "http://hl7.org/fhir/StructureDefinition/Location"
                            }
                        }
                    }
                };
            }
            {
                // 17. SupplyRequest.deliverTo
                this.Element_DeliverTo = new ElementDefinitionInfo
                {
                    Name = "Element_DeliverTo",
                    Path= "SupplyRequest.deliverTo",
                    Id = "SupplyRequest.deliverTo",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Organization",
                                "http://hl7.org/fhir/StructureDefinition/Location",
                                "http://hl7.org/fhir/StructureDefinition/Patient"
                            }
                        }
                    }
                };
            }
            this.Name = "SupplyRequest";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/SupplyRequest";
        }
    }
}
