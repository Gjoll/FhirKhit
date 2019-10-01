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
    #endregion                                                                                                                              // MakerGen.cs:461
    /// <summary>
    /// Fhir resource 'Invoice'
    /// </summary>
    // 0. Invoice
    public class Invoice : FhirKhit.Maker.Common.Resource.ResourceBase                                                                      // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        public class Invoice_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                         // MakerGen.cs:385
        {                                                                                                                                   // MakerGen.cs:386
            // 8. Invoice.participant
            public class Type_Participant : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_Participant_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                        // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 9. Invoice.participant.role
                    public ElementDefinitionInfo Role;                                                                                      // MakerGen.cs:216
                    // 10. Invoice.participant.actor
                    public ElementDefinitionInfo Actor;                                                                                     // MakerGen.cs:216
                    public Type_Participant_Elements()                                                                                      // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 9. Invoice.participant.role
                            this.Role = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Role",                                                                                              // MakerGen.cs:235
                                Path= "Invoice.participant.role",                                                                           // MakerGen.cs:236
                                Id = "Invoice.participant.role",                                                                            // MakerGen.cs:237
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
                            // 10. Invoice.participant.actor
                            this.Actor = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Actor",                                                                                             // MakerGen.cs:235
                                Path= "Invoice.participant.actor",                                                                          // MakerGen.cs:236
                                Id = "Invoice.participant.actor",                                                                           // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",                                         // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/Organization",                                         // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/Patient",                                              // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                     // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/Device",                                               // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                         // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Role.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Actor.Write(sDef);                                                                                                  // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_Participant_Elements Elements { get; }                                                                          // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_Participant()                                                                                                   // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_Participant_Elements();                                                                        // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 13. Invoice.lineItem
            public class Type_LineItem : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_LineItem_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                           // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 16. Invoice.lineItem.priceComponent
                    public class Type_PriceComponent : FhirKhit.Maker.Common.Complex.ComplexBase                                            // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        public class Type_PriceComponent_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                             // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:386
                            // 17. Invoice.lineItem.priceComponent.type
                            public ElementDefinitionInfo Type;                                                                              // MakerGen.cs:216
                            // 18. Invoice.lineItem.priceComponent.code
                            public ElementDefinitionInfo Code;                                                                              // MakerGen.cs:216
                            // 19. Invoice.lineItem.priceComponent.factor
                            public ElementDefinitionInfo Factor;                                                                            // MakerGen.cs:216
                            // 20. Invoice.lineItem.priceComponent.amount
                            public ElementDefinitionInfo Amount;                                                                            // MakerGen.cs:216
                            public Type_PriceComponent_Elements()                                                                           // MakerGen.cs:407
                            {                                                                                                               // MakerGen.cs:408
                                {                                                                                                           // MakerGen.cs:231
                                    // 17. Invoice.lineItem.priceComponent.type
                                    this.Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Type",                                                                                      // MakerGen.cs:235
                                        Path= "Invoice.lineItem.priceComponent.type",                                                       // MakerGen.cs:236
                                        Id = "Invoice.lineItem.priceComponent.type",                                                        // MakerGen.cs:237
                                        Min = 1,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.Code                                                        // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 18. Invoice.lineItem.priceComponent.code
                                    this.Code = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Code",                                                                                      // MakerGen.cs:235
                                        Path= "Invoice.lineItem.priceComponent.code",                                                       // MakerGen.cs:236
                                        Id = "Invoice.lineItem.priceComponent.code",                                                        // MakerGen.cs:237
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
                                    // 19. Invoice.lineItem.priceComponent.factor
                                    this.Factor = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Factor",                                                                                    // MakerGen.cs:235
                                        Path= "Invoice.lineItem.priceComponent.factor",                                                     // MakerGen.cs:236
                                        Id = "Invoice.lineItem.priceComponent.factor",                                                      // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.Decimal                                                     // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 20. Invoice.lineItem.priceComponent.amount
                                    this.Amount = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Amount",                                                                                    // MakerGen.cs:235
                                        Path= "Invoice.lineItem.priceComponent.amount",                                                     // MakerGen.cs:236
                                        Id = "Invoice.lineItem.priceComponent.amount",                                                      // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.Money                                                         // MakerGen.cs:358
                                            {                                                                                               // MakerGen.cs:359
                                            }                                                                                               // MakerGen.cs:360
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:427
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:412
                            {                                                                                                               // MakerGen.cs:413
                                base.Write(sDef);                                                                                           // MakerGen.cs:414
                                Type.Write(sDef);                                                                                           // MakerGen.cs:220
                                Code.Write(sDef);                                                                                           // MakerGen.cs:220
                                Factor.Write(sDef);                                                                                         // MakerGen.cs:220
                                Amount.Write(sDef);                                                                                         // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:431
                        }                                                                                                                   // MakerGen.cs:391
                        public Type_PriceComponent_Elements Elements { get; }                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                        public Type_PriceComponent()                                                                                        // MakerGen.cs:394
                        {                                                                                                                   // MakerGen.cs:395
                            this.Elements = new Type_PriceComponent_Elements();                                                             // MakerGen.cs:396
                        }                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:399
                        {                                                                                                                   // MakerGen.cs:400
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:401
                        }                                                                                                                   // MakerGen.cs:402
                    }                                                                                                                       // MakerGen.cs:403
                    // 14. Invoice.lineItem.sequence
                    public ElementDefinitionInfo Sequence;                                                                                  // MakerGen.cs:216
                    // 15. Invoice.lineItem.chargeItem[x]
                    public ElementDefinitionInfo ChargeItem;                                                                                // MakerGen.cs:216
                    // 16. Invoice.lineItem.priceComponent
                    public ElementDefinitionInfo PriceComponent;                                                                            // MakerGen.cs:216
                    public Type_LineItem_Elements()                                                                                         // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 14. Invoice.lineItem.sequence
                            this.Sequence = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Sequence",                                                                                          // MakerGen.cs:235
                                Path= "Invoice.lineItem.sequence",                                                                          // MakerGen.cs:236
                                Id = "Invoice.lineItem.sequence",                                                                           // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 15. Invoice.lineItem.chargeItem[x]
                            this.ChargeItem = new ElementDefinitionInfo                                                                     // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "ChargeItem",                                                                                        // MakerGen.cs:235
                                Path= "Invoice.lineItem.chargeItem[x]",                                                                     // MakerGen.cs:236
                                Id = "Invoice.lineItem.chargeItem[x]",                                                                      // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/ChargeItem"                                            // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    },                                                                                                      // MakerGen.cs:350
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 16. Invoice.lineItem.priceComponent
                            this.PriceComponent = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "PriceComponent",                                                                                    // MakerGen.cs:235
                                Path= "Invoice.lineItem.priceComponent",                                                                    // MakerGen.cs:236
                                Id = "Invoice.lineItem.priceComponent",                                                                     // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_PriceComponent                                                                                 // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Sequence.Write(sDef);                                                                                               // MakerGen.cs:220
                        ChargeItem.Write(sDef);                                                                                             // MakerGen.cs:220
                        PriceComponent.Write(sDef);                                                                                         // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_LineItem_Elements Elements { get; }                                                                             // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_LineItem()                                                                                                      // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_LineItem_Elements();                                                                           // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 1. Invoice.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 2. Invoice.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:216
            // 3. Invoice.cancelledReason
            public ElementDefinitionInfo CancelledReason;                                                                                   // MakerGen.cs:216
            // 4. Invoice.type
            public ElementDefinitionInfo Type;                                                                                              // MakerGen.cs:216
            // 5. Invoice.subject
            public ElementDefinitionInfo Subject;                                                                                           // MakerGen.cs:216
            // 6. Invoice.recipient
            public ElementDefinitionInfo Recipient;                                                                                         // MakerGen.cs:216
            // 7. Invoice.date
            public ElementDefinitionInfo Date;                                                                                              // MakerGen.cs:216
            // 8. Invoice.participant
            public ElementDefinitionInfo Participant;                                                                                       // MakerGen.cs:216
            // 11. Invoice.issuer
            public ElementDefinitionInfo Issuer;                                                                                            // MakerGen.cs:216
            // 12. Invoice.account
            public ElementDefinitionInfo Account;                                                                                           // MakerGen.cs:216
            // 13. Invoice.lineItem
            public ElementDefinitionInfo LineItem;                                                                                          // MakerGen.cs:216
            // 21. Invoice.totalPriceComponent
            public ElementDefinitionInfo TotalPriceComponent;                                                                               // MakerGen.cs:216
            // 22. Invoice.totalNet
            public ElementDefinitionInfo TotalNet;                                                                                          // MakerGen.cs:216
            // 23. Invoice.totalGross
            public ElementDefinitionInfo TotalGross;                                                                                        // MakerGen.cs:216
            // 24. Invoice.paymentTerms
            public ElementDefinitionInfo PaymentTerms;                                                                                      // MakerGen.cs:216
            // 25. Invoice.note
            public ElementDefinitionInfo Note;                                                                                              // MakerGen.cs:216
            public Invoice_Elements()                                                                                                       // MakerGen.cs:407
            {                                                                                                                               // MakerGen.cs:408
                {                                                                                                                           // MakerGen.cs:231
                    // 1. Invoice.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "Invoice.identifier",                                                                                         // MakerGen.cs:236
                        Id = "Invoice.identifier",                                                                                          // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 2. Invoice.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Status",                                                                                                    // MakerGen.cs:235
                        Path= "Invoice.status",                                                                                             // MakerGen.cs:236
                        Id = "Invoice.status",                                                                                              // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 3. Invoice.cancelledReason
                    this.CancelledReason = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "CancelledReason",                                                                                           // MakerGen.cs:235
                        Path= "Invoice.cancelledReason",                                                                                    // MakerGen.cs:236
                        Id = "Invoice.cancelledReason",                                                                                     // MakerGen.cs:237
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
                    // 4. Invoice.type
                    this.Type = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Type",                                                                                                      // MakerGen.cs:235
                        Path= "Invoice.type",                                                                                               // MakerGen.cs:236
                        Id = "Invoice.type",                                                                                                // MakerGen.cs:237
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
                    // 5. Invoice.subject
                    this.Subject = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Subject",                                                                                                   // MakerGen.cs:235
                        Path= "Invoice.subject",                                                                                            // MakerGen.cs:236
                        Id = "Invoice.subject",                                                                                             // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Group"                                                         // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 6. Invoice.recipient
                    this.Recipient = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Recipient",                                                                                                 // MakerGen.cs:235
                        Path= "Invoice.recipient",                                                                                          // MakerGen.cs:236
                        Id = "Invoice.recipient",                                                                                           // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                                 // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 7. Invoice.date
                    this.Date = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Date",                                                                                                      // MakerGen.cs:235
                        Path= "Invoice.date",                                                                                               // MakerGen.cs:236
                        Id = "Invoice.date",                                                                                                // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 8. Invoice.participant
                    this.Participant = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Participant",                                                                                               // MakerGen.cs:235
                        Path= "Invoice.participant",                                                                                        // MakerGen.cs:236
                        Id = "Invoice.participant",                                                                                         // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Participant                                                                                            // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 11. Invoice.issuer
                    this.Issuer = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Issuer",                                                                                                    // MakerGen.cs:235
                        Path= "Invoice.issuer",                                                                                             // MakerGen.cs:236
                        Id = "Invoice.issuer",                                                                                              // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 12. Invoice.account
                    this.Account = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Account",                                                                                                   // MakerGen.cs:235
                        Path= "Invoice.account",                                                                                            // MakerGen.cs:236
                        Id = "Invoice.account",                                                                                             // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Account"                                                       // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 13. Invoice.lineItem
                    this.LineItem = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "LineItem",                                                                                                  // MakerGen.cs:235
                        Path= "Invoice.lineItem",                                                                                           // MakerGen.cs:236
                        Id = "Invoice.lineItem",                                                                                            // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_LineItem                                                                                               // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 21. Invoice.totalPriceComponent
                    this.TotalPriceComponent = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "TotalPriceComponent",                                                                                       // MakerGen.cs:235
                        Path= "Invoice.totalPriceComponent",                                                                                // MakerGen.cs:236
                        Id = "Invoice.totalPriceComponent",                                                                                 // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 22. Invoice.totalNet
                    this.TotalNet = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "TotalNet",                                                                                                  // MakerGen.cs:235
                        Path= "Invoice.totalNet",                                                                                           // MakerGen.cs:236
                        Id = "Invoice.totalNet",                                                                                            // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Money                                                                         // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 23. Invoice.totalGross
                    this.TotalGross = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "TotalGross",                                                                                                // MakerGen.cs:235
                        Path= "Invoice.totalGross",                                                                                         // MakerGen.cs:236
                        Id = "Invoice.totalGross",                                                                                          // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Money                                                                         // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 24. Invoice.paymentTerms
                    this.PaymentTerms = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "PaymentTerms",                                                                                              // MakerGen.cs:235
                        Path= "Invoice.paymentTerms",                                                                                       // MakerGen.cs:236
                        Id = "Invoice.paymentTerms",                                                                                        // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Markdown                                                                    // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 25. Invoice.note
                    this.Note = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Note",                                                                                                      // MakerGen.cs:235
                        Path= "Invoice.note",                                                                                               // MakerGen.cs:236
                        Id = "Invoice.note",                                                                                                // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Annotation                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:427
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:412
            {                                                                                                                               // MakerGen.cs:413
                base.Write(sDef);                                                                                                           // MakerGen.cs:414
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:220
                Status.Write(sDef);                                                                                                         // MakerGen.cs:220
                CancelledReason.Write(sDef);                                                                                                // MakerGen.cs:220
                Type.Write(sDef);                                                                                                           // MakerGen.cs:220
                Subject.Write(sDef);                                                                                                        // MakerGen.cs:220
                Recipient.Write(sDef);                                                                                                      // MakerGen.cs:220
                Date.Write(sDef);                                                                                                           // MakerGen.cs:220
                Participant.Write(sDef);                                                                                                    // MakerGen.cs:220
                Issuer.Write(sDef);                                                                                                         // MakerGen.cs:220
                Account.Write(sDef);                                                                                                        // MakerGen.cs:220
                LineItem.Write(sDef);                                                                                                       // MakerGen.cs:220
                TotalPriceComponent.Write(sDef);                                                                                            // MakerGen.cs:220
                TotalNet.Write(sDef);                                                                                                       // MakerGen.cs:220
                TotalGross.Write(sDef);                                                                                                     // MakerGen.cs:220
                PaymentTerms.Write(sDef);                                                                                                   // MakerGen.cs:220
                Note.Write(sDef);                                                                                                           // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:431
        }                                                                                                                                   // MakerGen.cs:391
        public Invoice_Elements Elements { get; }                                                                                           // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
        public Invoice()                                                                                                                    // MakerGen.cs:394
        {                                                                                                                                   // MakerGen.cs:395
            this.Elements = new Invoice_Elements();                                                                                         // MakerGen.cs:396
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:399
        {                                                                                                                                   // MakerGen.cs:400
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:401
        }                                                                                                                                   // MakerGen.cs:402
    }                                                                                                                                       // MakerGen.cs:403
}                                                                                                                                           // MakerGen.cs:466
