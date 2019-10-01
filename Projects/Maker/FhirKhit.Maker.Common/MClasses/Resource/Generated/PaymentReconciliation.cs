using System;                                                                                                                               // MakerGen.cs:462
using System.Diagnostics;                                                                                                                   // MakerGen.cs:463
using System.IO;                                                                                                                            // MakerGen.cs:464
using System.Linq;                                                                                                                          // MakerGen.cs:465
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:466
                                                                                                                                            // MakerGen.cs:467
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:468
{                                                                                                                                           // MakerGen.cs:469
    #region Json                                                                                                                            // MakerGen.cs:470
    #if NEVER                                                                                                                               // MakerGen.cs:471
    {
      "resourceType": "StructureDefinition",
      "id": "PaymentReconciliation",
      "url": "http://hl7.org/fhir/StructureDefinition/PaymentReconciliation",
      "version": "4.0.0",
      "name": "PaymentReconciliation",
      "status": "draft",
      "publisher": "Health Level Seven International (Financial Management)",
      "description": "This resource provides the details including amount of a payment and allocates the payment items being paid.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "PaymentReconciliation",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "PaymentReconciliation",
            "path": "PaymentReconciliation",
            "short": "PaymentReconciliation resource",
            "definition": "This resource provides the details including amount of a payment and allocates the payment items being paid.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "PaymentReconciliation.identifier",
            "path": "PaymentReconciliation.identifier",
            "short": "Business Identifier for a payment reconciliation",
            "definition": "A unique identifier assigned to this payment reconciliation.",
            "requirements": "Allows payment reconciliations to be distinguished and referenced.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ]
          },
          {
            "id": "PaymentReconciliation.status",
            "path": "PaymentReconciliation.status",
            "short": "active | cancelled | draft | entered-in-error",
            "definition": "The status of the resource instance.",
            "comment": "This element is labeled as a modifier because the status contains codes that mark the resource as not currently valid.",
            "requirements": "Need to track the status of the resource as 'draft' resources may undergo further edits while 'active' resources are immutable and may only have their status changed to 'cancelled'.",
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
                  "valueString": "PaymentReconciliationStatus"
                }
              ],
              "strength": "required",
              "description": "A code specifying the state of the resource instance.",
              "valueSet": "http://hl7.org/fhir/ValueSet/fm-status|4.0.0"
            }
          },
          {
            "id": "PaymentReconciliation.period",
            "path": "PaymentReconciliation.period",
            "short": "Period covered",
            "definition": "The period of time for which payments have been gathered into this bulk payment for settlement.",
            "requirements": "Needed to allow receivers to monitor and reconcile payment issuer schedules.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ],
            "isSummary": true
          },
          {
            "id": "PaymentReconciliation.created",
            "path": "PaymentReconciliation.created",
            "short": "Creation date",
            "definition": "The date when the resource was created.",
            "requirements": "Need to record a timestamp for use by both the recipient and the issuer.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ],
            "isSummary": true
          },
          {
            "id": "PaymentReconciliation.paymentIssuer",
            "path": "PaymentReconciliation.paymentIssuer",
            "short": "Party generating payment",
            "definition": "The party who generated the payment.",
            "comment": "This party is also responsible for the reconciliation.",
            "requirements": "Need to identify the party resonsible for the payment and this resource.",
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
            "isSummary": true
          },
          {
            "id": "PaymentReconciliation.request",
            "path": "PaymentReconciliation.request",
            "short": "Reference to requesting resource",
            "definition": "Original request resource reference.",
            "requirements": "Needed to allow the response to be linked to the request.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Task"
                ]
              }
            ]
          },
          {
            "id": "PaymentReconciliation.requestor",
            "path": "PaymentReconciliation.requestor",
            "short": "Responsible practitioner",
            "definition": "The practitioner who is responsible for the services rendered to the patient.",
            "requirements": "Need to identify the party responsible for the request.",
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
            "id": "PaymentReconciliation.outcome",
            "path": "PaymentReconciliation.outcome",
            "short": "queued | complete | error | partial",
            "definition": "The outcome of a request for a reconciliation.",
            "comment": "The resource may be used to indicate that: the request has been held (queued) for processing; that it has been processed and errors found (error); that no errors were found and that some of the adjudication has been undertaken (partial) or that all of the adjudication has been undertaken (complete).",
            "requirements": "To advise the requestor of an overall processing outcome.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "RemittanceOutcome"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "required",
              "description": "The outcome of the processing.",
              "valueSet": "http://hl7.org/fhir/ValueSet/remittance-outcome|4.0.0"
            }
          },
          {
            "id": "PaymentReconciliation.disposition",
            "path": "PaymentReconciliation.disposition",
            "short": "Disposition message",
            "definition": "A human readable description of the status of the request for the reconciliation.",
            "requirements": "Provided for user display.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "PaymentReconciliation.paymentDate",
            "path": "PaymentReconciliation.paymentDate",
            "short": "When payment issued",
            "definition": "The date of payment as indicated on the financial instrument.",
            "requirements": "To advise the payee when payment can be expected.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "date"
              }
            ],
            "isSummary": true
          },
          {
            "id": "PaymentReconciliation.paymentAmount",
            "path": "PaymentReconciliation.paymentAmount",
            "short": "Total amount of Payment",
            "definition": "Total payment amount as indicated on the financial instrument.",
            "requirements": "Needed to provide the actual payment amount.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Money"
              }
            ],
            "isSummary": true
          },
          {
            "id": "PaymentReconciliation.paymentIdentifier",
            "path": "PaymentReconciliation.paymentIdentifier",
            "short": "Business identifier for the payment",
            "definition": "Issuer's unique identifier for the payment instrument.",
            "comment": "For example: EFT number or check number.",
            "requirements": "Enable the receiver to reconcile when payment is received.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Identifier"
              }
            ]
          },
          {
            "id": "PaymentReconciliation.detail",
            "path": "PaymentReconciliation.detail",
            "short": "Settlement particulars",
            "definition": "Distribution of the payment amount for a previously acknowledged payable.",
            "requirements": "Needed to show how the payment amount is distributed across the payables.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "PaymentReconciliation.detail.identifier",
            "path": "PaymentReconciliation.detail.identifier",
            "short": "Business identifier of the payment detail",
            "definition": "Unique identifier for the current payment item for the referenced payable.",
            "requirements": "Needed for reconciliation of payments.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Identifier"
              }
            ]
          },
          {
            "id": "PaymentReconciliation.detail.predecessor",
            "path": "PaymentReconciliation.detail.predecessor",
            "short": "Business identifier of the prior payment detail",
            "definition": "Unique identifier for the prior payment item for the referenced payable.",
            "requirements": "Needed for reconciliation of payments.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Identifier"
              }
            ]
          },
          {
            "id": "PaymentReconciliation.detail.type",
            "path": "PaymentReconciliation.detail.type",
            "short": "Category of payment",
            "definition": "Code to indicate the nature of the payment.",
            "comment": "For example: payment, adjustment, funds advance, etc.",
            "requirements": "Needed to provide context for the amount.",
            "min": 1,
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
                  "valueString": "PaymentType"
                }
              ],
              "strength": "example",
              "description": "The reason for the amount: payment, adjustment, advance.",
              "valueSet": "http://hl7.org/fhir/ValueSet/payment-type"
            }
          },
          {
            "id": "PaymentReconciliation.detail.request",
            "path": "PaymentReconciliation.detail.request",
            "short": "Request giving rise to the payment",
            "definition": "A resource, such as a Claim, the evaluation of which could lead to payment.",
            "requirements": "Needed to provide a linkage  to the original request.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ]
          },
          {
            "id": "PaymentReconciliation.detail.submitter",
            "path": "PaymentReconciliation.detail.submitter",
            "short": "Submitter of the request",
            "definition": "The party which submitted the claim or financial transaction.",
            "requirements": "Needed for audit and validation.",
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
            "id": "PaymentReconciliation.detail.response",
            "path": "PaymentReconciliation.detail.response",
            "short": "Response committing to a payment",
            "definition": "A resource, such as a ClaimResponse, which contains a commitment to payment.",
            "requirements": "Needed to provide a linkage to the payment commitment.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ]
          },
          {
            "id": "PaymentReconciliation.detail.date",
            "path": "PaymentReconciliation.detail.date",
            "short": "Date of commitment to pay",
            "definition": "The date from the response resource containing a commitment to pay.",
            "requirements": "Needed for audit and validation.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "date"
              }
            ]
          },
          {
            "id": "PaymentReconciliation.detail.responsible",
            "path": "PaymentReconciliation.detail.responsible",
            "short": "Contact for the response",
            "definition": "A reference to the individual who is responsible for inquiries regarding the response and its payment.",
            "requirements": "To provide contact information.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                ]
              }
            ]
          },
          {
            "id": "PaymentReconciliation.detail.payee",
            "path": "PaymentReconciliation.detail.payee",
            "short": "Recipient of the payment",
            "definition": "The party which is receiving the payment.",
            "requirements": "Needed for audit and validation.",
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
            "id": "PaymentReconciliation.detail.amount",
            "path": "PaymentReconciliation.detail.amount",
            "short": "Amount allocated to this payable",
            "definition": "The monetary amount allocated from the total payment to the payable.",
            "requirements": "Needed to explain the distribution of the payment to the payables.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Money"
              }
            ]
          },
          {
            "id": "PaymentReconciliation.formCode",
            "path": "PaymentReconciliation.formCode",
            "short": "Printed form identifier",
            "definition": "A code for the form to be used for printing the content.",
            "comment": "May be needed to identify specific jurisdictional forms.",
            "requirements": "Needed to specify the specific form used for producing output for this response.",
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
                  "valueString": "Forms"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "example",
              "description": "The forms codes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/forms"
            }
          },
          {
            "id": "PaymentReconciliation.processNote",
            "path": "PaymentReconciliation.processNote",
            "short": "Note concerning processing",
            "definition": "A note that describes or explains the processing in a human readable form.",
            "requirements": "Provides the specific textual explanations associated with the processing.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "PaymentReconciliation.processNote.type",
            "path": "PaymentReconciliation.processNote.type",
            "short": "display | print | printoper",
            "definition": "The business purpose of the note text.",
            "requirements": "To convey the expectation for when the text is used.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "NoteType"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "required",
              "description": "The presentation types of notes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/note-type|4.0.0"
            }
          },
          {
            "id": "PaymentReconciliation.processNote.text",
            "path": "PaymentReconciliation.processNote.text",
            "short": "Note explanatory text",
            "definition": "The explanation or description associated with the processing.",
            "requirements": "Required to provide human readable explanation.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:474
    /// <summary>
    /// Fhir resource 'PaymentReconciliation'
    /// </summary>
    // 0. PaymentReconciliation
    public class PaymentReconciliation : FhirKhit.Maker.Common.Resource.ResourceBase                                                        // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        public class PaymentReconciliation_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                           // MakerGen.cs:386
        {                                                                                                                                   // MakerGen.cs:387
            // 13. PaymentReconciliation.detail
            public class Type_Detail : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_Detail_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                             // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 14. PaymentReconciliation.detail.identifier
                    public ElementDefinitionInfo Identifier;                                                                                // MakerGen.cs:216
                    // 15. PaymentReconciliation.detail.predecessor
                    public ElementDefinitionInfo Predecessor;                                                                               // MakerGen.cs:216
                    // 16. PaymentReconciliation.detail.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:216
                    // 17. PaymentReconciliation.detail.request
                    public ElementDefinitionInfo Request;                                                                                   // MakerGen.cs:216
                    // 18. PaymentReconciliation.detail.submitter
                    public ElementDefinitionInfo Submitter;                                                                                 // MakerGen.cs:216
                    // 19. PaymentReconciliation.detail.response
                    public ElementDefinitionInfo Response;                                                                                  // MakerGen.cs:216
                    // 20. PaymentReconciliation.detail.date
                    public ElementDefinitionInfo Date;                                                                                      // MakerGen.cs:216
                    // 21. PaymentReconciliation.detail.responsible
                    public ElementDefinitionInfo Responsible;                                                                               // MakerGen.cs:216
                    // 22. PaymentReconciliation.detail.payee
                    public ElementDefinitionInfo Payee;                                                                                     // MakerGen.cs:216
                    // 23. PaymentReconciliation.detail.amount
                    public ElementDefinitionInfo Amount;                                                                                    // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_Detail_Elements()                                                                                           // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 14. PaymentReconciliation.detail.identifier
                            this.Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Identifier",                                                                                        // MakerGen.cs:235
                                Path= "PaymentReconciliation.detail.identifier",                                                            // MakerGen.cs:236
                                Id = "PaymentReconciliation.detail.identifier",                                                             // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Identifier                                                            // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 15. PaymentReconciliation.detail.predecessor
                            this.Predecessor = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Predecessor",                                                                                       // MakerGen.cs:235
                                Path= "PaymentReconciliation.detail.predecessor",                                                           // MakerGen.cs:236
                                Id = "PaymentReconciliation.detail.predecessor",                                                            // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Identifier                                                            // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 16. PaymentReconciliation.detail.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Type",                                                                                              // MakerGen.cs:235
                                Path= "PaymentReconciliation.detail.type",                                                                  // MakerGen.cs:236
                                Id = "PaymentReconciliation.detail.type",                                                                   // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
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
                            // 17. PaymentReconciliation.detail.request
                            this.Request = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Request",                                                                                           // MakerGen.cs:235
                                Path= "PaymentReconciliation.detail.request",                                                               // MakerGen.cs:236
                                Id = "PaymentReconciliation.detail.request",                                                                // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Resource"                                              // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 18. PaymentReconciliation.detail.submitter
                            this.Submitter = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Submitter",                                                                                         // MakerGen.cs:235
                                Path= "PaymentReconciliation.detail.submitter",                                                             // MakerGen.cs:236
                                Id = "PaymentReconciliation.detail.submitter",                                                              // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",                                         // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                     // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/Organization"                                          // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 19. PaymentReconciliation.detail.response
                            this.Response = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Response",                                                                                          // MakerGen.cs:235
                                Path= "PaymentReconciliation.detail.response",                                                              // MakerGen.cs:236
                                Id = "PaymentReconciliation.detail.response",                                                               // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Resource"                                              // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 20. PaymentReconciliation.detail.date
                            this.Date = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Date",                                                                                              // MakerGen.cs:235
                                Path= "PaymentReconciliation.detail.date",                                                                  // MakerGen.cs:236
                                Id = "PaymentReconciliation.detail.date",                                                                   // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Date                                                                // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 21. PaymentReconciliation.detail.responsible
                            this.Responsible = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Responsible",                                                                                       // MakerGen.cs:235
                                Path= "PaymentReconciliation.detail.responsible",                                                           // MakerGen.cs:236
                                Id = "PaymentReconciliation.detail.responsible",                                                            // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                      // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 22. PaymentReconciliation.detail.payee
                            this.Payee = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Payee",                                                                                             // MakerGen.cs:235
                                Path= "PaymentReconciliation.detail.payee",                                                                 // MakerGen.cs:236
                                Id = "PaymentReconciliation.detail.payee",                                                                  // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",                                         // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                     // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/Organization"                                          // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 23. PaymentReconciliation.detail.amount
                            this.Amount = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Amount",                                                                                            // MakerGen.cs:235
                                Path= "PaymentReconciliation.detail.amount",                                                                // MakerGen.cs:236
                                Id = "PaymentReconciliation.detail.amount",                                                                 // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Money                                                                 // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        Identifier.Write(sDef);                                                                                             // MakerGen.cs:220
                        Predecessor.Write(sDef);                                                                                            // MakerGen.cs:220
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Request.Write(sDef);                                                                                                // MakerGen.cs:220
                        Submitter.Write(sDef);                                                                                              // MakerGen.cs:220
                        Response.Write(sDef);                                                                                               // MakerGen.cs:220
                        Date.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Responsible.Write(sDef);                                                                                            // MakerGen.cs:220
                        Payee.Write(sDef);                                                                                                  // MakerGen.cs:220
                        Amount.Write(sDef);                                                                                                 // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_Detail_Elements Elements                                                                                        // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_Detail_Elements();                                                                     // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_Detail_Elements elements;                                                                                              // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_Detail()                                                                                                        // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "PaymentReconciliation.detail",                                                                              // MakerGen.cs:428
                        ElementId = "PaymentReconciliation.detail"                                                                          // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 25. PaymentReconciliation.processNote
            public class Type_ProcessNote : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_ProcessNote_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                        // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 26. PaymentReconciliation.processNote.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:216
                    // 27. PaymentReconciliation.processNote.text
                    public ElementDefinitionInfo Text;                                                                                      // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_ProcessNote_Elements()                                                                                      // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 26. PaymentReconciliation.processNote.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Type",                                                                                              // MakerGen.cs:235
                                Path= "PaymentReconciliation.processNote.type",                                                             // MakerGen.cs:236
                                Id = "PaymentReconciliation.processNote.type",                                                              // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 27. PaymentReconciliation.processNote.text
                            this.Text = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Text",                                                                                              // MakerGen.cs:235
                                Path= "PaymentReconciliation.processNote.text",                                                             // MakerGen.cs:236
                                Id = "PaymentReconciliation.processNote.text",                                                              // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Text.Write(sDef);                                                                                                   // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_ProcessNote_Elements Elements                                                                                   // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_ProcessNote_Elements();                                                                // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_ProcessNote_Elements elements;                                                                                         // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_ProcessNote()                                                                                                   // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "PaymentReconciliation.processNote",                                                                         // MakerGen.cs:428
                        ElementId = "PaymentReconciliation.processNote"                                                                     // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 1. PaymentReconciliation.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 2. PaymentReconciliation.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:216
            // 3. PaymentReconciliation.period
            public ElementDefinitionInfo Period;                                                                                            // MakerGen.cs:216
            // 4. PaymentReconciliation.created
            public ElementDefinitionInfo Created;                                                                                           // MakerGen.cs:216
            // 5. PaymentReconciliation.paymentIssuer
            public ElementDefinitionInfo PaymentIssuer;                                                                                     // MakerGen.cs:216
            // 6. PaymentReconciliation.request
            public ElementDefinitionInfo Request;                                                                                           // MakerGen.cs:216
            // 7. PaymentReconciliation.requestor
            public ElementDefinitionInfo Requestor;                                                                                         // MakerGen.cs:216
            // 8. PaymentReconciliation.outcome
            public ElementDefinitionInfo Outcome;                                                                                           // MakerGen.cs:216
            // 9. PaymentReconciliation.disposition
            public ElementDefinitionInfo Disposition;                                                                                       // MakerGen.cs:216
            // 10. PaymentReconciliation.paymentDate
            public ElementDefinitionInfo PaymentDate;                                                                                       // MakerGen.cs:216
            // 11. PaymentReconciliation.paymentAmount
            public ElementDefinitionInfo PaymentAmount;                                                                                     // MakerGen.cs:216
            // 12. PaymentReconciliation.paymentIdentifier
            public ElementDefinitionInfo PaymentIdentifier;                                                                                 // MakerGen.cs:216
            // 13. PaymentReconciliation.detail
            public ElementDefinitionInfo Detail;                                                                                            // MakerGen.cs:216
            // 24. PaymentReconciliation.formCode
            public ElementDefinitionInfo FormCode;                                                                                          // MakerGen.cs:216
            // 25. PaymentReconciliation.processNote
            public ElementDefinitionInfo ProcessNote;                                                                                       // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
            public PaymentReconciliation_Elements()                                                                                         // MakerGen.cs:392
            {                                                                                                                               // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:231
                    // 1. PaymentReconciliation.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "PaymentReconciliation.identifier",                                                                           // MakerGen.cs:236
                        Id = "PaymentReconciliation.identifier",                                                                            // MakerGen.cs:237
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
                    // 2. PaymentReconciliation.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Status",                                                                                                    // MakerGen.cs:235
                        Path= "PaymentReconciliation.status",                                                                               // MakerGen.cs:236
                        Id = "PaymentReconciliation.status",                                                                                // MakerGen.cs:237
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
                    // 3. PaymentReconciliation.period
                    this.Period = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Period",                                                                                                    // MakerGen.cs:235
                        Path= "PaymentReconciliation.period",                                                                               // MakerGen.cs:236
                        Id = "PaymentReconciliation.period",                                                                                // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 4. PaymentReconciliation.created
                    this.Created = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Created",                                                                                                   // MakerGen.cs:235
                        Path= "PaymentReconciliation.created",                                                                              // MakerGen.cs:236
                        Id = "PaymentReconciliation.created",                                                                               // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
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
                    // 5. PaymentReconciliation.paymentIssuer
                    this.PaymentIssuer = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "PaymentIssuer",                                                                                             // MakerGen.cs:235
                        Path= "PaymentReconciliation.paymentIssuer",                                                                        // MakerGen.cs:236
                        Id = "PaymentReconciliation.paymentIssuer",                                                                         // MakerGen.cs:237
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
                    // 6. PaymentReconciliation.request
                    this.Request = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Request",                                                                                                   // MakerGen.cs:235
                        Path= "PaymentReconciliation.request",                                                                              // MakerGen.cs:236
                        Id = "PaymentReconciliation.request",                                                                               // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Task"                                                          // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 7. PaymentReconciliation.requestor
                    this.Requestor = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Requestor",                                                                                                 // MakerGen.cs:235
                        Path= "PaymentReconciliation.requestor",                                                                            // MakerGen.cs:236
                        Id = "PaymentReconciliation.requestor",                                                                             // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 8. PaymentReconciliation.outcome
                    this.Outcome = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Outcome",                                                                                                   // MakerGen.cs:235
                        Path= "PaymentReconciliation.outcome",                                                                              // MakerGen.cs:236
                        Id = "PaymentReconciliation.outcome",                                                                               // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
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
                    // 9. PaymentReconciliation.disposition
                    this.Disposition = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Disposition",                                                                                               // MakerGen.cs:235
                        Path= "PaymentReconciliation.disposition",                                                                          // MakerGen.cs:236
                        Id = "PaymentReconciliation.disposition",                                                                           // MakerGen.cs:237
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
                    // 10. PaymentReconciliation.paymentDate
                    this.PaymentDate = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "PaymentDate",                                                                                               // MakerGen.cs:235
                        Path= "PaymentReconciliation.paymentDate",                                                                          // MakerGen.cs:236
                        Id = "PaymentReconciliation.paymentDate",                                                                           // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Date                                                                        // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 11. PaymentReconciliation.paymentAmount
                    this.PaymentAmount = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "PaymentAmount",                                                                                             // MakerGen.cs:235
                        Path= "PaymentReconciliation.paymentAmount",                                                                        // MakerGen.cs:236
                        Id = "PaymentReconciliation.paymentAmount",                                                                         // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
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
                    // 12. PaymentReconciliation.paymentIdentifier
                    this.PaymentIdentifier = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "PaymentIdentifier",                                                                                         // MakerGen.cs:235
                        Path= "PaymentReconciliation.paymentIdentifier",                                                                    // MakerGen.cs:236
                        Id = "PaymentReconciliation.paymentIdentifier",                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 13. PaymentReconciliation.detail
                    this.Detail = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Detail",                                                                                                    // MakerGen.cs:235
                        Path= "PaymentReconciliation.detail",                                                                               // MakerGen.cs:236
                        Id = "PaymentReconciliation.detail",                                                                                // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Detail                                                                                                 // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 24. PaymentReconciliation.formCode
                    this.FormCode = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "FormCode",                                                                                                  // MakerGen.cs:235
                        Path= "PaymentReconciliation.formCode",                                                                             // MakerGen.cs:236
                        Id = "PaymentReconciliation.formCode",                                                                              // MakerGen.cs:237
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
                    // 25. PaymentReconciliation.processNote
                    this.ProcessNote = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ProcessNote",                                                                                               // MakerGen.cs:235
                        Path= "PaymentReconciliation.processNote",                                                                          // MakerGen.cs:236
                        Id = "PaymentReconciliation.processNote",                                                                           // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_ProcessNote                                                                                            // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:398
            {                                                                                                                               // MakerGen.cs:399
                base.Write(sDef);                                                                                                           // MakerGen.cs:400
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:220
                Status.Write(sDef);                                                                                                         // MakerGen.cs:220
                Period.Write(sDef);                                                                                                         // MakerGen.cs:220
                Created.Write(sDef);                                                                                                        // MakerGen.cs:220
                PaymentIssuer.Write(sDef);                                                                                                  // MakerGen.cs:220
                Request.Write(sDef);                                                                                                        // MakerGen.cs:220
                Requestor.Write(sDef);                                                                                                      // MakerGen.cs:220
                Outcome.Write(sDef);                                                                                                        // MakerGen.cs:220
                Disposition.Write(sDef);                                                                                                    // MakerGen.cs:220
                PaymentDate.Write(sDef);                                                                                                    // MakerGen.cs:220
                PaymentAmount.Write(sDef);                                                                                                  // MakerGen.cs:220
                PaymentIdentifier.Write(sDef);                                                                                              // MakerGen.cs:220
                Detail.Write(sDef);                                                                                                         // MakerGen.cs:220
                FormCode.Write(sDef);                                                                                                       // MakerGen.cs:220
                ProcessNote.Write(sDef);                                                                                                    // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:402
        }                                                                                                                                   // MakerGen.cs:404
        public PaymentReconciliation_Elements Elements                                                                                      // MakerGen.cs:406
        {                                                                                                                                   // MakerGen.cs:407
            get                                                                                                                             // MakerGen.cs:408
            {                                                                                                                               // MakerGen.cs:409
                if (this.elements == null)                                                                                                  // MakerGen.cs:410
                    this.elements = new PaymentReconciliation_Elements();                                                                   // MakerGen.cs:411
                return this.elements;                                                                                                       // MakerGen.cs:412
            }                                                                                                                               // MakerGen.cs:413
        }                                                                                                                                   // MakerGen.cs:414
        PaymentReconciliation_Elements elements;                                                                                            // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
        public PaymentReconciliation()                                                                                                      // MakerGen.cs:418
        {                                                                                                                                   // MakerGen.cs:419
            this.Name = "PaymentReconciliation";                                                                                            // MakerGen.cs:492
            this.Uri = "http://hl7.org/fhir/StructureDefinition/PaymentReconciliation";                                                     // MakerGen.cs:493
        }                                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:424
        {                                                                                                                                   // MakerGen.cs:425
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:426
            {                                                                                                                               // MakerGen.cs:427
                Path = "PaymentReconciliation",                                                                                             // MakerGen.cs:428
                ElementId = "PaymentReconciliation"                                                                                         // MakerGen.cs:429
            });                                                                                                                             // MakerGen.cs:430
            if (this.elements != null)                                                                                                      // MakerGen.cs:431
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:432
        }                                                                                                                                   // MakerGen.cs:433
    }                                                                                                                                       // MakerGen.cs:434
}                                                                                                                                           // MakerGen.cs:479
