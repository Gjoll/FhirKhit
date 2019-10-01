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
    #endregion                                                                                                                              // MakerGen.cs:440
    /// <summary>
    /// Fhir resource 'Invoice'
    /// </summary>
    // 0. Invoice
    public class Resource_Invoice : FhirKhit.Maker.Common.Resource.ResourceBase                                                             // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 8. Invoice.participant
        public class Type_Participant : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 9. Invoice.participant.role
            public ElementDefinitionInfo Element_Role;                                                                                      // MakerGen.cs:212
            // 10. Invoice.participant.actor
            public ElementDefinitionInfo Element_Actor;                                                                                     // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "Invoice.participant",                                                                                           // MakerGen.cs:388
                    ElementId = "Invoice.participant"                                                                                       // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Role.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_Actor.Write(sDef);                                                                                                  // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Participant()                                                                                                       // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 9. Invoice.participant.role
                    this.Element_Role = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Role",                                                                                              // MakerGen.cs:231
                        Path= "Invoice.participant.role",                                                                                   // MakerGen.cs:232
                        Id = "Invoice.participant.role",                                                                                    // MakerGen.cs:233
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
                    // 10. Invoice.participant.actor
                    this.Element_Actor = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Actor",                                                                                             // MakerGen.cs:231
                        Path= "Invoice.participant.actor",                                                                                  // MakerGen.cs:232
                        Id = "Invoice.participant.actor",                                                                                   // MakerGen.cs:233
                        Min = 1,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:339
                            {                                                                                                               // MakerGen.cs:340
                                TargetProfile = new String[]                                                                                // MakerGen.cs:342
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/Organization",                                                 // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/Device",                                                       // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                                 // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:343
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 13. Invoice.lineItem
        public class Type_LineItem : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 16. Invoice.lineItem.priceComponent
            public class Type_PriceComponent : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                // 17. Invoice.lineItem.priceComponent.type
                public ElementDefinitionInfo Element_Type;                                                                                  // MakerGen.cs:212
                // 18. Invoice.lineItem.priceComponent.code
                public ElementDefinitionInfo Element_Code;                                                                                  // MakerGen.cs:212
                // 19. Invoice.lineItem.priceComponent.factor
                public ElementDefinitionInfo Element_Factor;                                                                                // MakerGen.cs:212
                // 20. Invoice.lineItem.priceComponent.amount
                public ElementDefinitionInfo Element_Amount;                                                                                // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:383
                {                                                                                                                           // MakerGen.cs:384
                    base.Write(sDef);                                                                                                       // MakerGen.cs:385
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:386
                    {                                                                                                                       // MakerGen.cs:387
                        Path = "Invoice.lineItem.priceComponent",                                                                           // MakerGen.cs:388
                        ElementId = "Invoice.lineItem.priceComponent"                                                                       // MakerGen.cs:389
                    });                                                                                                                     // MakerGen.cs:390
                    Element_Type.Write(sDef);                                                                                               // MakerGen.cs:216
                    Element_Code.Write(sDef);                                                                                               // MakerGen.cs:216
                    Element_Factor.Write(sDef);                                                                                             // MakerGen.cs:216
                    Element_Amount.Write(sDef);                                                                                             // MakerGen.cs:216
                }                                                                                                                           // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
                public Type_PriceComponent()                                                                                                // MakerGen.cs:395
                {                                                                                                                           // MakerGen.cs:396
                    {                                                                                                                       // MakerGen.cs:227
                        // 17. Invoice.lineItem.priceComponent.type
                        this.Element_Type = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Type",                                                                                          // MakerGen.cs:231
                            Path= "Invoice.lineItem.priceComponent.type",                                                                   // MakerGen.cs:232
                            Id = "Invoice.lineItem.priceComponent.type",                                                                    // MakerGen.cs:233
                            Min = 1,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                          // MakerGen.cs:296
                                {                                                                                                           // MakerGen.cs:297
                                }                                                                                                           // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 18. Invoice.lineItem.priceComponent.code
                        this.Element_Code = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Code",                                                                                          // MakerGen.cs:231
                            Path= "Invoice.lineItem.priceComponent.code",                                                                   // MakerGen.cs:232
                            Id = "Invoice.lineItem.priceComponent.code",                                                                    // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:311
                                {                                                                                                           // MakerGen.cs:312
                                }                                                                                                           // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 19. Invoice.lineItem.priceComponent.factor
                        this.Element_Factor = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Factor",                                                                                        // MakerGen.cs:231
                            Path= "Invoice.lineItem.priceComponent.factor",                                                                 // MakerGen.cs:232
                            Id = "Invoice.lineItem.priceComponent.factor",                                                                  // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                       // MakerGen.cs:296
                                {                                                                                                           // MakerGen.cs:297
                                }                                                                                                           // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 20. Invoice.lineItem.priceComponent.amount
                        this.Element_Amount = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Amount",                                                                                        // MakerGen.cs:231
                            Path= "Invoice.lineItem.priceComponent.amount",                                                                 // MakerGen.cs:232
                            Id = "Invoice.lineItem.priceComponent.amount",                                                                  // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Complex.Type_Money                                                                // MakerGen.cs:351
                                {                                                                                                           // MakerGen.cs:352
                                }                                                                                                           // MakerGen.cs:353
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                }                                                                                                                           // MakerGen.cs:398
            }                                                                                                                               // MakerGen.cs:400
            // 14. Invoice.lineItem.sequence
            public ElementDefinitionInfo Element_Sequence;                                                                                  // MakerGen.cs:212
            // 15. Invoice.lineItem.chargeItem[x]
            public ElementDefinitionInfo Element_ChargeItem;                                                                                // MakerGen.cs:212
            // 16. Invoice.lineItem.priceComponent
            public ElementDefinitionInfo Element_PriceComponent;                                                                            // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "Invoice.lineItem",                                                                                              // MakerGen.cs:388
                    ElementId = "Invoice.lineItem"                                                                                          // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Sequence.Write(sDef);                                                                                               // MakerGen.cs:216
                Element_ChargeItem.Write(sDef);                                                                                             // MakerGen.cs:216
                Element_PriceComponent.Write(sDef);                                                                                         // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_LineItem()                                                                                                          // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 14. Invoice.lineItem.sequence
                    this.Element_Sequence = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Sequence",                                                                                          // MakerGen.cs:231
                        Path= "Invoice.lineItem.sequence",                                                                                  // MakerGen.cs:232
                        Id = "Invoice.lineItem.sequence",                                                                                   // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt                                                       // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 15. Invoice.lineItem.chargeItem[x]
                    this.Element_ChargeItem = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_ChargeItem",                                                                                        // MakerGen.cs:231
                        Path= "Invoice.lineItem.chargeItem[x]",                                                                             // MakerGen.cs:232
                        Id = "Invoice.lineItem.chargeItem[x]",                                                                              // MakerGen.cs:233
                        Min = 1,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:339
                            {                                                                                                               // MakerGen.cs:340
                                TargetProfile = new String[]                                                                                // MakerGen.cs:342
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ChargeItem"                                                    // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            },                                                                                                              // MakerGen.cs:343
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 16. Invoice.lineItem.priceComponent
                    this.Element_PriceComponent = new ElementDefinitionInfo                                                                 // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_PriceComponent",                                                                                    // MakerGen.cs:231
                        Path= "Invoice.lineItem.priceComponent",                                                                            // MakerGen.cs:232
                        Id = "Invoice.lineItem.priceComponent",                                                                             // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new Type_PriceComponent                                                                                         // MakerGen.cs:255
                            {                                                                                                               // MakerGen.cs:256
                            }                                                                                                               // MakerGen.cs:257
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 1. Invoice.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:212
        // 2. Invoice.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:212
        // 3. Invoice.cancelledReason
        public ElementDefinitionInfo Element_CancelledReason;                                                                               // MakerGen.cs:212
        // 4. Invoice.type
        public ElementDefinitionInfo Element_Type;                                                                                          // MakerGen.cs:212
        // 5. Invoice.subject
        public ElementDefinitionInfo Element_Subject;                                                                                       // MakerGen.cs:212
        // 6. Invoice.recipient
        public ElementDefinitionInfo Element_Recipient;                                                                                     // MakerGen.cs:212
        // 7. Invoice.date
        public ElementDefinitionInfo Element_Date;                                                                                          // MakerGen.cs:212
        // 8. Invoice.participant
        public ElementDefinitionInfo Element_Participant;                                                                                   // MakerGen.cs:212
        // 11. Invoice.issuer
        public ElementDefinitionInfo Element_Issuer;                                                                                        // MakerGen.cs:212
        // 12. Invoice.account
        public ElementDefinitionInfo Element_Account;                                                                                       // MakerGen.cs:212
        // 13. Invoice.lineItem
        public ElementDefinitionInfo Element_LineItem;                                                                                      // MakerGen.cs:212
        // 21. Invoice.totalPriceComponent
        public ElementDefinitionInfo Element_TotalPriceComponent;                                                                           // MakerGen.cs:212
        // 22. Invoice.totalNet
        public ElementDefinitionInfo Element_TotalNet;                                                                                      // MakerGen.cs:212
        // 23. Invoice.totalGross
        public ElementDefinitionInfo Element_TotalGross;                                                                                    // MakerGen.cs:212
        // 24. Invoice.paymentTerms
        public ElementDefinitionInfo Element_PaymentTerms;                                                                                  // MakerGen.cs:212
        // 25. Invoice.note
        public ElementDefinitionInfo Element_Note;                                                                                          // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "Invoice",                                                                                                           // MakerGen.cs:388
                ElementId = "Invoice"                                                                                                       // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_CancelledReason.Write(sDef);                                                                                            // MakerGen.cs:216
            Element_Type.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Subject.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Recipient.Write(sDef);                                                                                                  // MakerGen.cs:216
            Element_Date.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Participant.Write(sDef);                                                                                                // MakerGen.cs:216
            Element_Issuer.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Account.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_LineItem.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_TotalPriceComponent.Write(sDef);                                                                                        // MakerGen.cs:216
            Element_TotalNet.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_TotalGross.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_PaymentTerms.Write(sDef);                                                                                               // MakerGen.cs:216
            Element_Note.Write(sDef);                                                                                                       // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Resource_Invoice()                                                                                                           // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. Invoice.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:231
                    Path= "Invoice.identifier",                                                                                             // MakerGen.cs:232
                    Id = "Invoice.identifier",                                                                                              // MakerGen.cs:233
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
                // 2. Invoice.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Status",                                                                                                // MakerGen.cs:231
                    Path= "Invoice.status",                                                                                                 // MakerGen.cs:232
                    Id = "Invoice.status",                                                                                                  // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
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
                // 3. Invoice.cancelledReason
                this.Element_CancelledReason = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_CancelledReason",                                                                                       // MakerGen.cs:231
                    Path= "Invoice.cancelledReason",                                                                                        // MakerGen.cs:232
                    Id = "Invoice.cancelledReason",                                                                                         // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 4. Invoice.type
                this.Element_Type = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:231
                    Path= "Invoice.type",                                                                                                   // MakerGen.cs:232
                    Id = "Invoice.type",                                                                                                    // MakerGen.cs:233
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
                // 5. Invoice.subject
                this.Element_Subject = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Subject",                                                                                               // MakerGen.cs:231
                    Path= "Invoice.subject",                                                                                                // MakerGen.cs:232
                    Id = "Invoice.subject",                                                                                                 // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Patient",                                                          // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Group"                                                             // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 6. Invoice.recipient
                this.Element_Recipient = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Recipient",                                                                                             // MakerGen.cs:231
                    Path= "Invoice.recipient",                                                                                              // MakerGen.cs:232
                    Id = "Invoice.recipient",                                                                                               // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Organization",                                                     // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Patient",                                                          // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                                     // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 7. Invoice.date
                this.Element_Date = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Date",                                                                                                  // MakerGen.cs:231
                    Path= "Invoice.date",                                                                                                   // MakerGen.cs:232
                    Id = "Invoice.date",                                                                                                    // MakerGen.cs:233
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
                // 8. Invoice.participant
                this.Element_Participant = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Participant",                                                                                           // MakerGen.cs:231
                    Path= "Invoice.participant",                                                                                            // MakerGen.cs:232
                    Id = "Invoice.participant",                                                                                             // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Participant                                                                                                // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 11. Invoice.issuer
                this.Element_Issuer = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Issuer",                                                                                                // MakerGen.cs:231
                    Path= "Invoice.issuer",                                                                                                 // MakerGen.cs:232
                    Id = "Invoice.issuer",                                                                                                  // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 12. Invoice.account
                this.Element_Account = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Account",                                                                                               // MakerGen.cs:231
                    Path= "Invoice.account",                                                                                                // MakerGen.cs:232
                    Id = "Invoice.account",                                                                                                 // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Account"                                                           // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 13. Invoice.lineItem
                this.Element_LineItem = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_LineItem",                                                                                              // MakerGen.cs:231
                    Path= "Invoice.lineItem",                                                                                               // MakerGen.cs:232
                    Id = "Invoice.lineItem",                                                                                                // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_LineItem                                                                                                   // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 21. Invoice.totalPriceComponent
                this.Element_TotalPriceComponent = new ElementDefinitionInfo                                                                // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_TotalPriceComponent",                                                                                   // MakerGen.cs:231
                    Path= "Invoice.totalPriceComponent",                                                                                    // MakerGen.cs:232
                    Id = "Invoice.totalPriceComponent",                                                                                     // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 22. Invoice.totalNet
                this.Element_TotalNet = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_TotalNet",                                                                                              // MakerGen.cs:231
                    Path= "Invoice.totalNet",                                                                                               // MakerGen.cs:232
                    Id = "Invoice.totalNet",                                                                                                // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Money                                                                        // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 23. Invoice.totalGross
                this.Element_TotalGross = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_TotalGross",                                                                                            // MakerGen.cs:231
                    Path= "Invoice.totalGross",                                                                                             // MakerGen.cs:232
                    Id = "Invoice.totalGross",                                                                                              // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Money                                                                        // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 24. Invoice.paymentTerms
                this.Element_PaymentTerms = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_PaymentTerms",                                                                                          // MakerGen.cs:231
                    Path= "Invoice.paymentTerms",                                                                                           // MakerGen.cs:232
                    Id = "Invoice.paymentTerms",                                                                                            // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                              // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 25. Invoice.note
                this.Element_Note = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Note",                                                                                                  // MakerGen.cs:231
                    Path= "Invoice.note",                                                                                                   // MakerGen.cs:232
                    Id = "Invoice.note",                                                                                                    // MakerGen.cs:233
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
            this.Name = "Invoice";                                                                                                          // MakerGen.cs:458
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Invoice";                                                                   // MakerGen.cs:459
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:445
