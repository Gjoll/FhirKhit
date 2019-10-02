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
      "id": "Invoice",
      "url": "http://hl7.org/fhir/StructureDefinition/Invoice",
      "version": "4.0.0",
      "name": "Invoice",
      "status": "draft",
      "publisher": "Health Level Seven International (Financial Management)",
      "description": "Invoice containing collected ChargeItems from an Account with calculated individual and total price for Billing purpose.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Invoice",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Invoice",
            "path": "Invoice",
            "short": "Invoice containing ChargeItems from an Account",
            "definition": "Invoice containing collected ChargeItems from an Account with calculated individual and total price for Billing purpose.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Invoice.identifier",
            "path": "Invoice.identifier",
            "short": "Business Identifier for item",
            "definition": "Identifier of this Invoice, often used for reference in correspondence about this invoice or for tracking of payments.",
            "requirements": "Allows Identification of this Invoice instance.",
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
            "id": "Invoice.status",
            "path": "Invoice.status",
            "short": "draft | issued | balanced | cancelled | entered-in-error",
            "definition": "The current state of the Invoice.",
            "min": 1,
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
                  "valueString": "InvoiceStatus"
                }
              ],
              "strength": "required",
              "description": "Codes identifying the lifecycle stage of an Invoice.",
              "valueSet": "http://hl7.org/fhir/ValueSet/invoice-status|4.0.0"
            }
          },
          {
            "id": "Invoice.cancelledReason",
            "path": "Invoice.cancelledReason",
            "short": "Reason for cancellation of this Invoice",
            "definition": "In case of Invoice cancellation a reason must be given (entered in error, superseded by corrected invoice etc.).",
            "comment": "Derived Profiles may choose to add invariants requiring this field to be populated if either priceOverride or factorOverride have been filled.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": false
          },
          {
            "id": "Invoice.type",
            "path": "Invoice.type",
            "short": "Type of Invoice",
            "definition": "Type of Invoice depending on domain, realm an usage (e.g. internal/external, dental, preliminary).",
            "alias": [
              "type"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Invoice.subject",
            "path": "Invoice.subject",
            "short": "Recipient(s) of goods and services",
            "definition": "The individual or set of individuals receiving the goods and services billed in this invoice.",
            "requirements": "Links the event to the Patient context.",
            "alias": [
              "patient"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Group"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Invoice.recipient",
            "path": "Invoice.recipient",
            "short": "Recipient of this invoice",
            "definition": "The individual or Organization responsible for balancing of this invoice.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Invoice.date",
            "path": "Invoice.date",
            "short": "Invoice date / posting date",
            "definition": "Date/time(s) of when this Invoice was posted.",
            "comment": "The list of types may be constrained as appropriate for the type of charge item.",
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
            "id": "Invoice.participant",
            "path": "Invoice.participant",
            "short": "Participant in creation of this Invoice",
            "definition": "Indicates who or what performed or participated in the charged service.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": false
          },
          {
            "id": "Invoice.participant.role",
            "path": "Invoice.participant.role",
            "short": "Type of involvement in creation of this Invoice",
            "definition": "Describes the type of involvement (e.g. transcriptionist, creator etc.). If the invoice has been created automatically, the Participant may be a billing engine or another kind of device.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": false
          },
          {
            "id": "Invoice.participant.actor",
            "path": "Invoice.participant.actor",
            "short": "Individual who was involved",
            "definition": "The device, practitioner, etc. who performed or participated in the service.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                ]
              }
            ],
            "isSummary": false
          },
          {
            "id": "Invoice.issuer",
            "path": "Invoice.issuer",
            "short": "Issuing Organization of Invoice",
            "definition": "The organizationissuing the Invoice.",
            "comment": "Practitioners and Devices can be associated with multiple organizations. It has to be made clear, on behalf of which Organization the services have been rendered.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ],
            "isSummary": false
          },
          {
            "id": "Invoice.account",
            "path": "Invoice.account",
            "short": "Account that is being balanced",
            "definition": "Account which is supposed to be balanced with this Invoice.",
            "comment": "Systems posting the ChargeItems might not always be able to determine, which accounts the Items need to be places into. It is up to the potprocessing Financial System to apply internal rules to decide based on the Encounter/EpisodeOfCare/Patient/Coverage context and the type of ChargeItem, which Account is appropriate.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Account"
                ]
              }
            ],
            "isSummary": false
          },
          {
            "id": "Invoice.lineItem",
            "path": "Invoice.lineItem",
            "short": "Line items of this Invoice",
            "definition": "Each line item represents one charge for goods and services rendered. Details such as date, code and amount are found in the referenced ChargeItem resource.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": false
          },
          {
            "id": "Invoice.lineItem.sequence",
            "path": "Invoice.lineItem.sequence",
            "short": "Sequence number of line item",
            "definition": "Sequence in which the items appear on the invoice.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              }
            ],
            "isSummary": false
          },
          {
            "id": "Invoice.lineItem.chargeItem[x]",
            "path": "Invoice.lineItem.chargeItem[x]",
            "short": "Reference to ChargeItem containing details of this line item or an inline billing code",
            "definition": "The ChargeItem contains information such as the billing code, date, amount etc. If no further details are required for the lineItem, inline billing codes can be added using the CodeableConcept data type instead of the Reference.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ChargeItem"
                ]
              },
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": false
          },
          {
            "id": "Invoice.lineItem.priceComponent",
            "path": "Invoice.lineItem.priceComponent",
            "short": "Components of total line item price",
            "definition": "The price for a ChargeItem may be calculated as a base price with surcharges/deductions that apply in certain conditions. A ChargeItemDefinition resource that defines the prices, factors and conditions that apply to a billing code is currently under development. The priceComponent element can be used to offer transparency to the recipient of the Invoice as to how the prices have been calculated.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": false
          },
          {
            "id": "Invoice.lineItem.priceComponent.type",
            "path": "Invoice.lineItem.priceComponent.type",
            "short": "base | surcharge | deduction | discount | tax | informational",
            "definition": "This code identifies the type of the component.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isSummary": false,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "InvoicePriceComponentType"
                }
              ],
              "strength": "required",
              "description": "Codes indicating the kind of the price component.",
              "valueSet": "http://hl7.org/fhir/ValueSet/invoice-priceComponentType|4.0.0"
            }
          },
          {
            "id": "Invoice.lineItem.priceComponent.code",
            "path": "Invoice.lineItem.priceComponent.code",
            "short": "Code identifying the specific component",
            "definition": "A code that identifies the component. Codes may be used to differentiate between kinds of taxes, surcharges, discounts etc.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": false
          },
          {
            "id": "Invoice.lineItem.priceComponent.factor",
            "path": "Invoice.lineItem.priceComponent.factor",
            "short": "Factor used for calculating this component",
            "definition": "The factor that has been applied on the base price for calculating this component.",
            "comment": "There is no reason to carry the price in the instance of a ChargeItem unless circumstances require a manual override. The list prices or are usually defined in a back catalogue of the billing codes  (see ChargeItem.definition). Derived profiles may require a ChargeItem.overrideReason to be provided if either factor or price are manually overridden.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ],
            "isSummary": false
          },
          {
            "id": "Invoice.lineItem.priceComponent.amount",
            "path": "Invoice.lineItem.priceComponent.amount",
            "short": "Monetary amount associated with this component",
            "definition": "The amount calculated for this component.",
            "comment": "There is no reason to carry the price in the instance of a ChargeItem unless circumstances require a manual override. The list prices or are usually defined in a back catalogue of the billing codes  (see ChargeItem.definition). Derived profiles may require a ChargeItem.overrideReason to be provided if either factor or price are manually overridden.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Money"
              }
            ],
            "isSummary": false
          },
          {
            "id": "Invoice.totalPriceComponent",
            "path": "Invoice.totalPriceComponent",
            "short": "Components of Invoice total",
            "definition": "The total amount for the Invoice may be calculated as the sum of the line items with surcharges/deductions that apply in certain conditions.  The priceComponent element can be used to offer transparency to the recipient of the Invoice of how the total price was calculated.",
            "min": 0,
            "max": "*",
            "contentReference": "#Invoice.lineItem.priceComponent",
            "isSummary": false
          },
          {
            "id": "Invoice.totalNet",
            "path": "Invoice.totalNet",
            "short": "Net total of this Invoice",
            "definition": "Invoice total , taxes excluded.",
            "comment": "There is no reason to carry the price in the instance of a ChargeItem unless circumstances require a manual override. The list prices or are usually defined in a back catalogue of the billing codes  (see ChargeItem.definition). Derived profiles may require a ChargeItem.overrideReason to be provided if either factor or price are manually overridden.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Money"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Invoice.totalGross",
            "path": "Invoice.totalGross",
            "short": "Gross total of this Invoice",
            "definition": "Invoice total, tax included.",
            "comment": "There is no reason to carry the price in the instance of a ChargeItem unless circumstances require a manual override. The list prices or are usually defined in a back catalogue of the billing codes  (see ChargeItem.definition). Derived profiles may require a ChargeItem.overrideReason to be provided if either factor or price are manually overridden.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Money"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Invoice.paymentTerms",
            "path": "Invoice.paymentTerms",
            "short": "Payment details",
            "definition": "Payment details such as banking details, period of payment, deductibles, methods of payment.",
            "comment": "Derived Profiles may chose to add invariants requiring this field to be populated if either priceOverride or factorOverride have been filled.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ],
            "isSummary": false
          },
          {
            "id": "Invoice.note",
            "path": "Invoice.note",
            "short": "Comments made about the invoice",
            "definition": "Comments made about the invoice by the issuer, subject, or other participants.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Annotation"
              }
            ],
            "isSummary": false
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir resource 'Invoice'
    /// </summary>
    // 0. Invoice
    public class Resource_Invoice : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 8. Invoice.participant
        public class Type_Participant : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 9. Invoice.participant.role
            public ElementDefinitionInfo Element_Role;
            // 10. Invoice.participant.actor
            public ElementDefinitionInfo Element_Actor;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Invoice.participant",
                    ElementId = "Invoice.participant"
                });
                Element_Role.Write(sDef);
                Element_Actor.Write(sDef);
            }
            
            public Type_Participant()
            {
                {
                    // 9. Invoice.participant.role
                    this.Element_Role = new ElementDefinitionInfo
                    {
                        Name = "Element_Role",
                        Path= "Invoice.participant.role",
                        Id = "Invoice.participant.role",
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
                    // 10. Invoice.participant.actor
                    this.Element_Actor = new ElementDefinitionInfo
                    {
                        Name = "Element_Actor",
                        Path= "Invoice.participant.actor",
                        Id = "Invoice.participant.actor",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                    "http://hl7.org/fhir/StructureDefinition/Organization",
                                    "http://hl7.org/fhir/StructureDefinition/Patient",
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                    "http://hl7.org/fhir/StructureDefinition/Device",
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                                }
                            }
                        }
                    };
                }
            }
        }
        // 13. Invoice.lineItem
        public class Type_LineItem : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 16. Invoice.lineItem.priceComponent
            public class Type_PriceComponent : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 17. Invoice.lineItem.priceComponent.type
                public ElementDefinitionInfo Element_Type;
                // 18. Invoice.lineItem.priceComponent.code
                public ElementDefinitionInfo Element_Code;
                // 19. Invoice.lineItem.priceComponent.factor
                public ElementDefinitionInfo Element_Factor;
                // 20. Invoice.lineItem.priceComponent.amount
                public ElementDefinitionInfo Element_Amount;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "Invoice.lineItem.priceComponent",
                        ElementId = "Invoice.lineItem.priceComponent"
                    });
                    Element_Type.Write(sDef);
                    Element_Code.Write(sDef);
                    Element_Factor.Write(sDef);
                    Element_Amount.Write(sDef);
                }
                
                public Type_PriceComponent()
                {
                    {
                        // 17. Invoice.lineItem.priceComponent.type
                        this.Element_Type = new ElementDefinitionInfo
                        {
                            Name = "Element_Type",
                            Path= "Invoice.lineItem.priceComponent.type",
                            Id = "Invoice.lineItem.priceComponent.type",
                            Min = 1,
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
                        // 18. Invoice.lineItem.priceComponent.code
                        this.Element_Code = new ElementDefinitionInfo
                        {
                            Name = "Element_Code",
                            Path= "Invoice.lineItem.priceComponent.code",
                            Id = "Invoice.lineItem.priceComponent.code",
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
                        // 19. Invoice.lineItem.priceComponent.factor
                        this.Element_Factor = new ElementDefinitionInfo
                        {
                            Name = "Element_Factor",
                            Path= "Invoice.lineItem.priceComponent.factor",
                            Id = "Invoice.lineItem.priceComponent.factor",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                                {
                                }
                            }
                        };
                    }
                    {
                        // 20. Invoice.lineItem.priceComponent.amount
                        this.Element_Amount = new ElementDefinitionInfo
                        {
                            Name = "Element_Amount",
                            Path= "Invoice.lineItem.priceComponent.amount",
                            Id = "Invoice.lineItem.priceComponent.amount",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_Money
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 14. Invoice.lineItem.sequence
            public ElementDefinitionInfo Element_Sequence;
            // 15. Invoice.lineItem.chargeItem[x]
            public ElementDefinitionInfo Element_ChargeItem;
            // 16. Invoice.lineItem.priceComponent
            public ElementDefinitionInfo Element_PriceComponent;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Invoice.lineItem",
                    ElementId = "Invoice.lineItem"
                });
                Element_Sequence.Write(sDef);
                Element_ChargeItem.Write(sDef);
                Element_PriceComponent.Write(sDef);
            }
            
            public Type_LineItem()
            {
                {
                    // 14. Invoice.lineItem.sequence
                    this.Element_Sequence = new ElementDefinitionInfo
                    {
                        Name = "Element_Sequence",
                        Path= "Invoice.lineItem.sequence",
                        Id = "Invoice.lineItem.sequence",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt
                            {
                            }
                        }
                    };
                }
                {
                    // 15. Invoice.lineItem.chargeItem[x]
                    this.Element_ChargeItem = new ElementDefinitionInfo
                    {
                        Name = "Element_ChargeItem",
                        Path= "Invoice.lineItem.chargeItem[x]",
                        Id = "Invoice.lineItem.chargeItem[x]",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/ChargeItem"
                                }
                            },
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                            {
                            }
                        }
                    };
                }
                {
                    // 16. Invoice.lineItem.priceComponent
                    this.Element_PriceComponent = new ElementDefinitionInfo
                    {
                        Name = "Element_PriceComponent",
                        Path= "Invoice.lineItem.priceComponent",
                        Id = "Invoice.lineItem.priceComponent",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_PriceComponent
                            {
                            }
                        }
                    };
                }
            }
        }
        // 1. Invoice.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. Invoice.status
        public ElementDefinitionInfo Element_Status;
        // 3. Invoice.cancelledReason
        public ElementDefinitionInfo Element_CancelledReason;
        // 4. Invoice.type
        public ElementDefinitionInfo Element_Type;
        // 5. Invoice.subject
        public ElementDefinitionInfo Element_Subject;
        // 6. Invoice.recipient
        public ElementDefinitionInfo Element_Recipient;
        // 7. Invoice.date
        public ElementDefinitionInfo Element_Date;
        // 8. Invoice.participant
        public ElementDefinitionInfo Element_Participant;
        // 11. Invoice.issuer
        public ElementDefinitionInfo Element_Issuer;
        // 12. Invoice.account
        public ElementDefinitionInfo Element_Account;
        // 13. Invoice.lineItem
        public ElementDefinitionInfo Element_LineItem;
        // 21. Invoice.totalPriceComponent
        public ElementDefinitionInfo Element_TotalPriceComponent;
        // 22. Invoice.totalNet
        public ElementDefinitionInfo Element_TotalNet;
        // 23. Invoice.totalGross
        public ElementDefinitionInfo Element_TotalGross;
        // 24. Invoice.paymentTerms
        public ElementDefinitionInfo Element_PaymentTerms;
        // 25. Invoice.note
        public ElementDefinitionInfo Element_Note;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "Invoice",
                ElementId = "Invoice"
            });
            Element_Identifier.Write(sDef);
            Element_Status.Write(sDef);
            Element_CancelledReason.Write(sDef);
            Element_Type.Write(sDef);
            Element_Subject.Write(sDef);
            Element_Recipient.Write(sDef);
            Element_Date.Write(sDef);
            Element_Participant.Write(sDef);
            Element_Issuer.Write(sDef);
            Element_Account.Write(sDef);
            Element_LineItem.Write(sDef);
            Element_TotalPriceComponent.Write(sDef);
            Element_TotalNet.Write(sDef);
            Element_TotalGross.Write(sDef);
            Element_PaymentTerms.Write(sDef);
            Element_Note.Write(sDef);
        }
        
        public Resource_Invoice()
        {
            {
                // 1. Invoice.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "Invoice.identifier",
                    Id = "Invoice.identifier",
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
                // 2. Invoice.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "Invoice.status",
                    Id = "Invoice.status",
                    Min = 1,
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
                // 3. Invoice.cancelledReason
                this.Element_CancelledReason = new ElementDefinitionInfo
                {
                    Name = "Element_CancelledReason",
                    Path= "Invoice.cancelledReason",
                    Id = "Invoice.cancelledReason",
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
                // 4. Invoice.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "Invoice.type",
                    Id = "Invoice.type",
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
                // 5. Invoice.subject
                this.Element_Subject = new ElementDefinitionInfo
                {
                    Name = "Element_Subject",
                    Path= "Invoice.subject",
                    Id = "Invoice.subject",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/Group"
                            }
                        }
                    }
                };
            }
            {
                // 6. Invoice.recipient
                this.Element_Recipient = new ElementDefinitionInfo
                {
                    Name = "Element_Recipient",
                    Path= "Invoice.recipient",
                    Id = "Invoice.recipient",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Organization",
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                            }
                        }
                    }
                };
            }
            {
                // 7. Invoice.date
                this.Element_Date = new ElementDefinitionInfo
                {
                    Name = "Element_Date",
                    Path= "Invoice.date",
                    Id = "Invoice.date",
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
                // 8. Invoice.participant
                this.Element_Participant = new ElementDefinitionInfo
                {
                    Name = "Element_Participant",
                    Path= "Invoice.participant",
                    Id = "Invoice.participant",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Participant
                        {
                        }
                    }
                };
            }
            {
                // 11. Invoice.issuer
                this.Element_Issuer = new ElementDefinitionInfo
                {
                    Name = "Element_Issuer",
                    Path= "Invoice.issuer",
                    Id = "Invoice.issuer",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Organization"
                            }
                        }
                    }
                };
            }
            {
                // 12. Invoice.account
                this.Element_Account = new ElementDefinitionInfo
                {
                    Name = "Element_Account",
                    Path= "Invoice.account",
                    Id = "Invoice.account",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Account"
                            }
                        }
                    }
                };
            }
            {
                // 13. Invoice.lineItem
                this.Element_LineItem = new ElementDefinitionInfo
                {
                    Name = "Element_LineItem",
                    Path= "Invoice.lineItem",
                    Id = "Invoice.lineItem",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_LineItem
                        {
                        }
                    }
                };
            }
            {
                // 21. Invoice.totalPriceComponent
                this.Element_TotalPriceComponent = new ElementDefinitionInfo
                {
                    Name = "Element_TotalPriceComponent",
                    Path= "Invoice.totalPriceComponent",
                    Id = "Invoice.totalPriceComponent",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                    }
                };
            }
            {
                // 22. Invoice.totalNet
                this.Element_TotalNet = new ElementDefinitionInfo
                {
                    Name = "Element_TotalNet",
                    Path= "Invoice.totalNet",
                    Id = "Invoice.totalNet",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Money
                        {
                        }
                    }
                };
            }
            {
                // 23. Invoice.totalGross
                this.Element_TotalGross = new ElementDefinitionInfo
                {
                    Name = "Element_TotalGross",
                    Path= "Invoice.totalGross",
                    Id = "Invoice.totalGross",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Money
                        {
                        }
                    }
                };
            }
            {
                // 24. Invoice.paymentTerms
                this.Element_PaymentTerms = new ElementDefinitionInfo
                {
                    Name = "Element_PaymentTerms",
                    Path= "Invoice.paymentTerms",
                    Id = "Invoice.paymentTerms",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Markdown
                        {
                        }
                    }
                };
            }
            {
                // 25. Invoice.note
                this.Element_Note = new ElementDefinitionInfo
                {
                    Name = "Element_Note",
                    Path= "Invoice.note",
                    Id = "Invoice.note",
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
            this.Name = "Invoice";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Invoice";
        }
    }
}
