using System;                                                                                                                               // MakerGen.cs:451
using System.Diagnostics;                                                                                                                   // MakerGen.cs:452
using System.IO;                                                                                                                            // MakerGen.cs:453
using System.Linq;                                                                                                                          // MakerGen.cs:454
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:455
                                                                                                                                            // MakerGen.cs:456
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:457
{                                                                                                                                           // MakerGen.cs:458
    #region Json                                                                                                                            // MakerGen.cs:459
    #if NEVER                                                                                                                               // MakerGen.cs:460
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
    #endregion                                                                                                                              // MakerGen.cs:463
    /// <summary>
    /// Fhir resource 'PaymentReconciliation'
    /// </summary>
    // 0. PaymentReconciliation
    public class PaymentReconciliation : FhirKhit.Maker.Common.Resource.ResourceBase                                                        // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class PaymentReconciliation_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                           // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 13. PaymentReconciliation.detail
            public class Type_Detail : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Detail_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                             // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 14. PaymentReconciliation.detail.identifier
                    public ElementDefinitionInfo Identifier;                                                                                // MakerGen.cs:236
                    // 15. PaymentReconciliation.detail.predecessor
                    public ElementDefinitionInfo Predecessor;                                                                               // MakerGen.cs:236
                    // 16. PaymentReconciliation.detail.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:236
                    // 17. PaymentReconciliation.detail.request
                    public ElementDefinitionInfo Request;                                                                                   // MakerGen.cs:236
                    // 18. PaymentReconciliation.detail.submitter
                    public ElementDefinitionInfo Submitter;                                                                                 // MakerGen.cs:236
                    // 19. PaymentReconciliation.detail.response
                    public ElementDefinitionInfo Response;                                                                                  // MakerGen.cs:236
                    // 20. PaymentReconciliation.detail.date
                    public ElementDefinitionInfo Date;                                                                                      // MakerGen.cs:236
                    // 21. PaymentReconciliation.detail.responsible
                    public ElementDefinitionInfo Responsible;                                                                               // MakerGen.cs:236
                    // 22. PaymentReconciliation.detail.payee
                    public ElementDefinitionInfo Payee;                                                                                     // MakerGen.cs:236
                    // 23. PaymentReconciliation.detail.amount
                    public ElementDefinitionInfo Amount;                                                                                    // MakerGen.cs:236
                    public Type_Detail_Elements()                                                                                           // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 14. PaymentReconciliation.detail.identifier
                            this.Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Identifier",                                                                                        // MakerGen.cs:255
                                Path= "PaymentReconciliation.detail.identifier",                                                            // MakerGen.cs:256
                                Id = "PaymentReconciliation.detail.identifier",                                                             // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Identifier                                                            // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 15. PaymentReconciliation.detail.predecessor
                            this.Predecessor = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Predecessor",                                                                                       // MakerGen.cs:255
                                Path= "PaymentReconciliation.detail.predecessor",                                                           // MakerGen.cs:256
                                Id = "PaymentReconciliation.detail.predecessor",                                                            // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Identifier                                                            // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 16. PaymentReconciliation.detail.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Type",                                                                                              // MakerGen.cs:255
                                Path= "PaymentReconciliation.detail.type",                                                                  // MakerGen.cs:256
                                Id = "PaymentReconciliation.detail.type",                                                                   // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 17. PaymentReconciliation.detail.request
                            this.Request = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Request",                                                                                           // MakerGen.cs:255
                                Path= "PaymentReconciliation.detail.request",                                                               // MakerGen.cs:256
                                Id = "PaymentReconciliation.detail.request",                                                                // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Resource"                                              // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 18. PaymentReconciliation.detail.submitter
                            this.Submitter = new ElementDefinitionInfo                                                                      // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Submitter",                                                                                         // MakerGen.cs:255
                                Path= "PaymentReconciliation.detail.submitter",                                                             // MakerGen.cs:256
                                Id = "PaymentReconciliation.detail.submitter",                                                              // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",                                         // MakerGen.cs:348
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                     // MakerGen.cs:348
                                            "http://hl7.org/fhir/StructureDefinition/Organization"                                          // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 19. PaymentReconciliation.detail.response
                            this.Response = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Response",                                                                                          // MakerGen.cs:255
                                Path= "PaymentReconciliation.detail.response",                                                              // MakerGen.cs:256
                                Id = "PaymentReconciliation.detail.response",                                                               // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Resource"                                              // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 20. PaymentReconciliation.detail.date
                            this.Date = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Date",                                                                                              // MakerGen.cs:255
                                Path= "PaymentReconciliation.detail.date",                                                                  // MakerGen.cs:256
                                Id = "PaymentReconciliation.detail.date",                                                                   // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Date                                                                // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 21. PaymentReconciliation.detail.responsible
                            this.Responsible = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Responsible",                                                                                       // MakerGen.cs:255
                                Path= "PaymentReconciliation.detail.responsible",                                                           // MakerGen.cs:256
                                Id = "PaymentReconciliation.detail.responsible",                                                            // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                      // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 22. PaymentReconciliation.detail.payee
                            this.Payee = new ElementDefinitionInfo                                                                          // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Payee",                                                                                             // MakerGen.cs:255
                                Path= "PaymentReconciliation.detail.payee",                                                                 // MakerGen.cs:256
                                Id = "PaymentReconciliation.detail.payee",                                                                  // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",                                         // MakerGen.cs:348
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                     // MakerGen.cs:348
                                            "http://hl7.org/fhir/StructureDefinition/Organization"                                          // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 23. PaymentReconciliation.detail.amount
                            this.Amount = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Amount",                                                                                            // MakerGen.cs:255
                                Path= "PaymentReconciliation.detail.amount",                                                                // MakerGen.cs:256
                                Id = "PaymentReconciliation.detail.amount",                                                                 // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Money                                                                 // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Identifier.Write(sDef);                                                                                             // MakerGen.cs:240
                        Predecessor.Write(sDef);                                                                                            // MakerGen.cs:240
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Request.Write(sDef);                                                                                                // MakerGen.cs:240
                        Submitter.Write(sDef);                                                                                              // MakerGen.cs:240
                        Response.Write(sDef);                                                                                               // MakerGen.cs:240
                        Date.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Responsible.Write(sDef);                                                                                            // MakerGen.cs:240
                        Payee.Write(sDef);                                                                                                  // MakerGen.cs:240
                        Amount.Write(sDef);                                                                                                 // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Detail_Elements Elements { get; }                                                                               // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Detail()                                                                                                        // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Detail_Elements();                                                                             // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 25. PaymentReconciliation.processNote
            public class Type_ProcessNote : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_ProcessNote_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                        // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 26. PaymentReconciliation.processNote.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:236
                    // 27. PaymentReconciliation.processNote.text
                    public ElementDefinitionInfo Text;                                                                                      // MakerGen.cs:236
                    public Type_ProcessNote_Elements()                                                                                      // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 26. PaymentReconciliation.processNote.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Type",                                                                                              // MakerGen.cs:255
                                Path= "PaymentReconciliation.processNote.type",                                                             // MakerGen.cs:256
                                Id = "PaymentReconciliation.processNote.type",                                                              // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 27. PaymentReconciliation.processNote.text
                            this.Text = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Text",                                                                                              // MakerGen.cs:255
                                Path= "PaymentReconciliation.processNote.text",                                                             // MakerGen.cs:256
                                Id = "PaymentReconciliation.processNote.text",                                                              // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Text.Write(sDef);                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_ProcessNote_Elements Elements { get; }                                                                          // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_ProcessNote()                                                                                                   // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_ProcessNote_Elements();                                                                        // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 1. PaymentReconciliation.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:236
            // 2. PaymentReconciliation.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:236
            // 3. PaymentReconciliation.period
            public ElementDefinitionInfo Period;                                                                                            // MakerGen.cs:236
            // 4. PaymentReconciliation.created
            public ElementDefinitionInfo Created;                                                                                           // MakerGen.cs:236
            // 5. PaymentReconciliation.paymentIssuer
            public ElementDefinitionInfo PaymentIssuer;                                                                                     // MakerGen.cs:236
            // 6. PaymentReconciliation.request
            public ElementDefinitionInfo Request;                                                                                           // MakerGen.cs:236
            // 7. PaymentReconciliation.requestor
            public ElementDefinitionInfo Requestor;                                                                                         // MakerGen.cs:236
            // 8. PaymentReconciliation.outcome
            public ElementDefinitionInfo Outcome;                                                                                           // MakerGen.cs:236
            // 9. PaymentReconciliation.disposition
            public ElementDefinitionInfo Disposition;                                                                                       // MakerGen.cs:236
            // 10. PaymentReconciliation.paymentDate
            public ElementDefinitionInfo PaymentDate;                                                                                       // MakerGen.cs:236
            // 11. PaymentReconciliation.paymentAmount
            public ElementDefinitionInfo PaymentAmount;                                                                                     // MakerGen.cs:236
            // 12. PaymentReconciliation.paymentIdentifier
            public ElementDefinitionInfo PaymentIdentifier;                                                                                 // MakerGen.cs:236
            // 24. PaymentReconciliation.formCode
            public ElementDefinitionInfo FormCode;                                                                                          // MakerGen.cs:236
            public PaymentReconciliation_Elements()                                                                                         // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. PaymentReconciliation.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Identifier",                                                                                                // MakerGen.cs:255
                        Path= "PaymentReconciliation.identifier",                                                                           // MakerGen.cs:256
                        Id = "PaymentReconciliation.identifier",                                                                            // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 2. PaymentReconciliation.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Status",                                                                                                    // MakerGen.cs:255
                        Path= "PaymentReconciliation.status",                                                                               // MakerGen.cs:256
                        Id = "PaymentReconciliation.status",                                                                                // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 3. PaymentReconciliation.period
                    this.Period = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Period",                                                                                                    // MakerGen.cs:255
                        Path= "PaymentReconciliation.period",                                                                               // MakerGen.cs:256
                        Id = "PaymentReconciliation.period",                                                                                // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 4. PaymentReconciliation.created
                    this.Created = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Created",                                                                                                   // MakerGen.cs:255
                        Path= "PaymentReconciliation.created",                                                                              // MakerGen.cs:256
                        Id = "PaymentReconciliation.created",                                                                               // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 5. PaymentReconciliation.paymentIssuer
                    this.PaymentIssuer = new ElementDefinitionInfo                                                                          // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "PaymentIssuer",                                                                                             // MakerGen.cs:255
                        Path= "PaymentReconciliation.paymentIssuer",                                                                        // MakerGen.cs:256
                        Id = "PaymentReconciliation.paymentIssuer",                                                                         // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 6. PaymentReconciliation.request
                    this.Request = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Request",                                                                                                   // MakerGen.cs:255
                        Path= "PaymentReconciliation.request",                                                                              // MakerGen.cs:256
                        Id = "PaymentReconciliation.request",                                                                               // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Task"                                                          // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 7. PaymentReconciliation.requestor
                    this.Requestor = new ElementDefinitionInfo                                                                              // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Requestor",                                                                                                 // MakerGen.cs:255
                        Path= "PaymentReconciliation.requestor",                                                                            // MakerGen.cs:256
                        Id = "PaymentReconciliation.requestor",                                                                             // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 8. PaymentReconciliation.outcome
                    this.Outcome = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Outcome",                                                                                                   // MakerGen.cs:255
                        Path= "PaymentReconciliation.outcome",                                                                              // MakerGen.cs:256
                        Id = "PaymentReconciliation.outcome",                                                                               // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 9. PaymentReconciliation.disposition
                    this.Disposition = new ElementDefinitionInfo                                                                            // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Disposition",                                                                                               // MakerGen.cs:255
                        Path= "PaymentReconciliation.disposition",                                                                          // MakerGen.cs:256
                        Id = "PaymentReconciliation.disposition",                                                                           // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 10. PaymentReconciliation.paymentDate
                    this.PaymentDate = new ElementDefinitionInfo                                                                            // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "PaymentDate",                                                                                               // MakerGen.cs:255
                        Path= "PaymentReconciliation.paymentDate",                                                                          // MakerGen.cs:256
                        Id = "PaymentReconciliation.paymentDate",                                                                           // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Date                                                                        // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 11. PaymentReconciliation.paymentAmount
                    this.PaymentAmount = new ElementDefinitionInfo                                                                          // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "PaymentAmount",                                                                                             // MakerGen.cs:255
                        Path= "PaymentReconciliation.paymentAmount",                                                                        // MakerGen.cs:256
                        Id = "PaymentReconciliation.paymentAmount",                                                                         // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Money                                                                         // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 12. PaymentReconciliation.paymentIdentifier
                    this.PaymentIdentifier = new ElementDefinitionInfo                                                                      // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "PaymentIdentifier",                                                                                         // MakerGen.cs:255
                        Path= "PaymentReconciliation.paymentIdentifier",                                                                    // MakerGen.cs:256
                        Id = "PaymentReconciliation.paymentIdentifier",                                                                     // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 24. PaymentReconciliation.formCode
                    this.FormCode = new ElementDefinitionInfo                                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "FormCode",                                                                                                  // MakerGen.cs:255
                        Path= "PaymentReconciliation.formCode",                                                                             // MakerGen.cs:256
                        Id = "PaymentReconciliation.formCode",                                                                              // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:429
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:240
                Status.Write(sDef);                                                                                                         // MakerGen.cs:240
                Period.Write(sDef);                                                                                                         // MakerGen.cs:240
                Created.Write(sDef);                                                                                                        // MakerGen.cs:240
                PaymentIssuer.Write(sDef);                                                                                                  // MakerGen.cs:240
                Request.Write(sDef);                                                                                                        // MakerGen.cs:240
                Requestor.Write(sDef);                                                                                                      // MakerGen.cs:240
                Outcome.Write(sDef);                                                                                                        // MakerGen.cs:240
                Disposition.Write(sDef);                                                                                                    // MakerGen.cs:240
                PaymentDate.Write(sDef);                                                                                                    // MakerGen.cs:240
                PaymentAmount.Write(sDef);                                                                                                  // MakerGen.cs:240
                PaymentIdentifier.Write(sDef);                                                                                              // MakerGen.cs:240
                FormCode.Write(sDef);                                                                                                       // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public PaymentReconciliation_Elements Elements { get; }                                                                             // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public PaymentReconciliation()                                                                                                      // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new PaymentReconciliation_Elements();                                                                           // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:468
