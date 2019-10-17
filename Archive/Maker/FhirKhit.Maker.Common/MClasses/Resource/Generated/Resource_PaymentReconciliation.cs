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
    #endregion                                                                                                                              // MakerGen.cs:444
    /// <summary>
    /// Fhir resource 'PaymentReconciliation'
    /// </summary>
    // 0. PaymentReconciliation
    public partial class Resource_PaymentReconciliation : FhirKhit.Maker.Common.Resource.Resource_DomainResource                            // MakerGen.cs:381
    {                                                                                                                                       // MakerGen.cs:382
        // 13. PaymentReconciliation.detail
        public partial class Type_Detail : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 14. PaymentReconciliation.detail.identifier
            public ElementDefinitionInfo Element_Identifier;                                                                                // MakerGen.cs:217
            // 15. PaymentReconciliation.detail.predecessor
            public ElementDefinitionInfo Element_Predecessor;                                                                               // MakerGen.cs:217
            // 16. PaymentReconciliation.detail.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:217
            // 17. PaymentReconciliation.detail.request
            public ElementDefinitionInfo Element_Request;                                                                                   // MakerGen.cs:217
            // 18. PaymentReconciliation.detail.submitter
            public ElementDefinitionInfo Element_Submitter;                                                                                 // MakerGen.cs:217
            // 19. PaymentReconciliation.detail.response
            public ElementDefinitionInfo Element_Response;                                                                                  // MakerGen.cs:217
            // 20. PaymentReconciliation.detail.date
            public ElementDefinitionInfo Element_Date;                                                                                      // MakerGen.cs:217
            // 21. PaymentReconciliation.detail.responsible
            public ElementDefinitionInfo Element_Responsible;                                                                               // MakerGen.cs:217
            // 22. PaymentReconciliation.detail.payee
            public ElementDefinitionInfo Element_Payee;                                                                                     // MakerGen.cs:217
            // 23. PaymentReconciliation.detail.amount
            public ElementDefinitionInfo Element_Amount;                                                                                    // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "PaymentReconciliation.detail",                                                                                  // MakerGen.cs:393
                    ElementId = "PaymentReconciliation.detail"                                                                              // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_Identifier.Write(sDef);                                                                                             // MakerGen.cs:221
                Element_Predecessor.Write(sDef);                                                                                            // MakerGen.cs:221
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:221
                Element_Request.Write(sDef);                                                                                                // MakerGen.cs:221
                Element_Submitter.Write(sDef);                                                                                              // MakerGen.cs:221
                Element_Response.Write(sDef);                                                                                               // MakerGen.cs:221
                Element_Date.Write(sDef);                                                                                                   // MakerGen.cs:221
                Element_Responsible.Write(sDef);                                                                                            // MakerGen.cs:221
                Element_Payee.Write(sDef);                                                                                                  // MakerGen.cs:221
                Element_Amount.Write(sDef);                                                                                                 // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_Detail()                                                                                                            // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 14. PaymentReconciliation.detail.identifier
                    this.Element_Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Identifier",                                                                                        // MakerGen.cs:236
                        Path= "PaymentReconciliation.detail.identifier",                                                                    // MakerGen.cs:237
                        Id = "PaymentReconciliation.detail.identifier",                                                                     // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Identifier                                                               // MakerGen.cs:356
                            {                                                                                                               // MakerGen.cs:357
                            }                                                                                                               // MakerGen.cs:358
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 15. PaymentReconciliation.detail.predecessor
                    this.Element_Predecessor = new ElementDefinitionInfo                                                                    // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Predecessor",                                                                                       // MakerGen.cs:236
                        Path= "PaymentReconciliation.detail.predecessor",                                                                   // MakerGen.cs:237
                        Id = "PaymentReconciliation.detail.predecessor",                                                                    // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Identifier                                                               // MakerGen.cs:356
                            {                                                                                                               // MakerGen.cs:357
                            }                                                                                                               // MakerGen.cs:358
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 16. PaymentReconciliation.detail.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Type",                                                                                              // MakerGen.cs:236
                        Path= "PaymentReconciliation.detail.type",                                                                          // MakerGen.cs:237
                        Id = "PaymentReconciliation.detail.type",                                                                           // MakerGen.cs:238
                        Min = 1,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:316
                            {                                                                                                               // MakerGen.cs:317
                            }                                                                                                               // MakerGen.cs:320
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 17. PaymentReconciliation.detail.request
                    this.Element_Request = new ElementDefinitionInfo                                                                        // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Request",                                                                                           // MakerGen.cs:236
                        Path= "PaymentReconciliation.detail.request",                                                                       // MakerGen.cs:237
                        Id = "PaymentReconciliation.detail.request",                                                                        // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:344
                            {                                                                                                               // MakerGen.cs:345
                                TargetProfile = new String[]                                                                                // MakerGen.cs:347
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Resource"                                                      // MakerGen.cs:347
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:348
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 18. PaymentReconciliation.detail.submitter
                    this.Element_Submitter = new ElementDefinitionInfo                                                                      // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Submitter",                                                                                         // MakerGen.cs:236
                        Path= "PaymentReconciliation.detail.submitter",                                                                     // MakerGen.cs:237
                        Id = "PaymentReconciliation.detail.submitter",                                                                      // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:344
                            {                                                                                                               // MakerGen.cs:345
                                TargetProfile = new String[]                                                                                // MakerGen.cs:347
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:347
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:347
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:347
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:348
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 19. PaymentReconciliation.detail.response
                    this.Element_Response = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Response",                                                                                          // MakerGen.cs:236
                        Path= "PaymentReconciliation.detail.response",                                                                      // MakerGen.cs:237
                        Id = "PaymentReconciliation.detail.response",                                                                       // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:344
                            {                                                                                                               // MakerGen.cs:345
                                TargetProfile = new String[]                                                                                // MakerGen.cs:347
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Resource"                                                      // MakerGen.cs:347
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:348
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 20. PaymentReconciliation.detail.date
                    this.Element_Date = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Date",                                                                                              // MakerGen.cs:236
                        Path= "PaymentReconciliation.detail.date",                                                                          // MakerGen.cs:237
                        Id = "PaymentReconciliation.detail.date",                                                                           // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Date                                                              // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 21. PaymentReconciliation.detail.responsible
                    this.Element_Responsible = new ElementDefinitionInfo                                                                    // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Responsible",                                                                                       // MakerGen.cs:236
                        Path= "PaymentReconciliation.detail.responsible",                                                                   // MakerGen.cs:237
                        Id = "PaymentReconciliation.detail.responsible",                                                                    // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:344
                            {                                                                                                               // MakerGen.cs:345
                                TargetProfile = new String[]                                                                                // MakerGen.cs:347
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                              // MakerGen.cs:347
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:348
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 22. PaymentReconciliation.detail.payee
                    this.Element_Payee = new ElementDefinitionInfo                                                                          // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Payee",                                                                                             // MakerGen.cs:236
                        Path= "PaymentReconciliation.detail.payee",                                                                         // MakerGen.cs:237
                        Id = "PaymentReconciliation.detail.payee",                                                                          // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:344
                            {                                                                                                               // MakerGen.cs:345
                                TargetProfile = new String[]                                                                                // MakerGen.cs:347
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:347
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:347
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:347
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:348
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 23. PaymentReconciliation.detail.amount
                    this.Element_Amount = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Amount",                                                                                            // MakerGen.cs:236
                        Path= "PaymentReconciliation.detail.amount",                                                                        // MakerGen.cs:237
                        Id = "PaymentReconciliation.detail.amount",                                                                         // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Money                                                                    // MakerGen.cs:356
                            {                                                                                                               // MakerGen.cs:357
                            }                                                                                                               // MakerGen.cs:358
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 25. PaymentReconciliation.processNote
        public partial class Type_ProcessNote : FhirKhit.Maker.Common.Complex.ComplexBase                                                   // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 26. PaymentReconciliation.processNote.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:217
            // 27. PaymentReconciliation.processNote.text
            public ElementDefinitionInfo Element_Text;                                                                                      // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "PaymentReconciliation.processNote",                                                                             // MakerGen.cs:393
                    ElementId = "PaymentReconciliation.processNote"                                                                         // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:221
                Element_Text.Write(sDef);                                                                                                   // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_ProcessNote()                                                                                                       // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 26. PaymentReconciliation.processNote.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Type",                                                                                              // MakerGen.cs:236
                        Path= "PaymentReconciliation.processNote.type",                                                                     // MakerGen.cs:237
                        Id = "PaymentReconciliation.processNote.type",                                                                      // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                              // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 27. PaymentReconciliation.processNote.text
                    this.Element_Text = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Text",                                                                                              // MakerGen.cs:236
                        Path= "PaymentReconciliation.processNote.text",                                                                     // MakerGen.cs:237
                        Id = "PaymentReconciliation.processNote.text",                                                                      // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 1. PaymentReconciliation.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:217
        // 2. PaymentReconciliation.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:217
        // 3. PaymentReconciliation.period
        public ElementDefinitionInfo Element_Period;                                                                                        // MakerGen.cs:217
        // 4. PaymentReconciliation.created
        public ElementDefinitionInfo Element_Created;                                                                                       // MakerGen.cs:217
        // 5. PaymentReconciliation.paymentIssuer
        public ElementDefinitionInfo Element_PaymentIssuer;                                                                                 // MakerGen.cs:217
        // 6. PaymentReconciliation.request
        public ElementDefinitionInfo Element_Request;                                                                                       // MakerGen.cs:217
        // 7. PaymentReconciliation.requestor
        public ElementDefinitionInfo Element_Requestor;                                                                                     // MakerGen.cs:217
        // 8. PaymentReconciliation.outcome
        public ElementDefinitionInfo Element_Outcome;                                                                                       // MakerGen.cs:217
        // 9. PaymentReconciliation.disposition
        public ElementDefinitionInfo Element_Disposition;                                                                                   // MakerGen.cs:217
        // 10. PaymentReconciliation.paymentDate
        public ElementDefinitionInfo Element_PaymentDate;                                                                                   // MakerGen.cs:217
        // 11. PaymentReconciliation.paymentAmount
        public ElementDefinitionInfo Element_PaymentAmount;                                                                                 // MakerGen.cs:217
        // 12. PaymentReconciliation.paymentIdentifier
        public ElementDefinitionInfo Element_PaymentIdentifier;                                                                             // MakerGen.cs:217
        // 13. PaymentReconciliation.detail
        public ElementDefinitionInfo Element_Detail;                                                                                        // MakerGen.cs:217
        // 24. PaymentReconciliation.formCode
        public ElementDefinitionInfo Element_FormCode;                                                                                      // MakerGen.cs:217
        // 25. PaymentReconciliation.processNote
        public ElementDefinitionInfo Element_ProcessNote;                                                                                   // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:388
        {                                                                                                                                   // MakerGen.cs:389
            base.Write(sDef);                                                                                                               // MakerGen.cs:390
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:391
            {                                                                                                                               // MakerGen.cs:392
                Path = "PaymentReconciliation",                                                                                             // MakerGen.cs:393
                ElementId = "PaymentReconciliation"                                                                                         // MakerGen.cs:394
            });                                                                                                                             // MakerGen.cs:395
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:221
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_Period.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_Created.Write(sDef);                                                                                                    // MakerGen.cs:221
            Element_PaymentIssuer.Write(sDef);                                                                                              // MakerGen.cs:221
            Element_Request.Write(sDef);                                                                                                    // MakerGen.cs:221
            Element_Requestor.Write(sDef);                                                                                                  // MakerGen.cs:221
            Element_Outcome.Write(sDef);                                                                                                    // MakerGen.cs:221
            Element_Disposition.Write(sDef);                                                                                                // MakerGen.cs:221
            Element_PaymentDate.Write(sDef);                                                                                                // MakerGen.cs:221
            Element_PaymentAmount.Write(sDef);                                                                                              // MakerGen.cs:221
            Element_PaymentIdentifier.Write(sDef);                                                                                          // MakerGen.cs:221
            Element_Detail.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_FormCode.Write(sDef);                                                                                                   // MakerGen.cs:221
            Element_ProcessNote.Write(sDef);                                                                                                // MakerGen.cs:221
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
        public Resource_PaymentReconciliation()                                                                                             // MakerGen.cs:400
        {                                                                                                                                   // MakerGen.cs:401
            {                                                                                                                               // MakerGen.cs:232
                // 1. PaymentReconciliation.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:236
                    Path= "PaymentReconciliation.identifier",                                                                               // MakerGen.cs:237
                    Id = "PaymentReconciliation.identifier",                                                                                // MakerGen.cs:238
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
                // 2. PaymentReconciliation.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Status",                                                                                                // MakerGen.cs:236
                    Path= "PaymentReconciliation.status",                                                                                   // MakerGen.cs:237
                    Id = "PaymentReconciliation.status",                                                                                    // MakerGen.cs:238
                    Min = 1,                                                                                                                // MakerGen.cs:239
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
                // 3. PaymentReconciliation.period
                this.Element_Period = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Period",                                                                                                // MakerGen.cs:236
                    Path= "PaymentReconciliation.period",                                                                                   // MakerGen.cs:237
                    Id = "PaymentReconciliation.period",                                                                                    // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Period                                                                       // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 4. PaymentReconciliation.created
                this.Element_Created = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Created",                                                                                               // MakerGen.cs:236
                    Path= "PaymentReconciliation.created",                                                                                  // MakerGen.cs:237
                    Id = "PaymentReconciliation.created",                                                                                   // MakerGen.cs:238
                    Min = 1,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 5. PaymentReconciliation.paymentIssuer
                this.Element_PaymentIssuer = new ElementDefinitionInfo                                                                      // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_PaymentIssuer",                                                                                         // MakerGen.cs:236
                    Path= "PaymentReconciliation.paymentIssuer",                                                                            // MakerGen.cs:237
                    Id = "PaymentReconciliation.paymentIssuer",                                                                             // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 6. PaymentReconciliation.request
                this.Element_Request = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Request",                                                                                               // MakerGen.cs:236
                    Path= "PaymentReconciliation.request",                                                                                  // MakerGen.cs:237
                    Id = "PaymentReconciliation.request",                                                                                   // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Task"                                                              // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 7. PaymentReconciliation.requestor
                this.Element_Requestor = new ElementDefinitionInfo                                                                          // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Requestor",                                                                                             // MakerGen.cs:236
                    Path= "PaymentReconciliation.requestor",                                                                                // MakerGen.cs:237
                    Id = "PaymentReconciliation.requestor",                                                                                 // MakerGen.cs:238
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
                // 8. PaymentReconciliation.outcome
                this.Element_Outcome = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Outcome",                                                                                               // MakerGen.cs:236
                    Path= "PaymentReconciliation.outcome",                                                                                  // MakerGen.cs:237
                    Id = "PaymentReconciliation.outcome",                                                                                   // MakerGen.cs:238
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
                // 9. PaymentReconciliation.disposition
                this.Element_Disposition = new ElementDefinitionInfo                                                                        // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Disposition",                                                                                           // MakerGen.cs:236
                    Path= "PaymentReconciliation.disposition",                                                                              // MakerGen.cs:237
                    Id = "PaymentReconciliation.disposition",                                                                               // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 10. PaymentReconciliation.paymentDate
                this.Element_PaymentDate = new ElementDefinitionInfo                                                                        // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_PaymentDate",                                                                                           // MakerGen.cs:236
                    Path= "PaymentReconciliation.paymentDate",                                                                              // MakerGen.cs:237
                    Id = "PaymentReconciliation.paymentDate",                                                                               // MakerGen.cs:238
                    Min = 1,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Date                                                                  // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 11. PaymentReconciliation.paymentAmount
                this.Element_PaymentAmount = new ElementDefinitionInfo                                                                      // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_PaymentAmount",                                                                                         // MakerGen.cs:236
                    Path= "PaymentReconciliation.paymentAmount",                                                                            // MakerGen.cs:237
                    Id = "PaymentReconciliation.paymentAmount",                                                                             // MakerGen.cs:238
                    Min = 1,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Money                                                                        // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 12. PaymentReconciliation.paymentIdentifier
                this.Element_PaymentIdentifier = new ElementDefinitionInfo                                                                  // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_PaymentIdentifier",                                                                                     // MakerGen.cs:236
                    Path= "PaymentReconciliation.paymentIdentifier",                                                                        // MakerGen.cs:237
                    Id = "PaymentReconciliation.paymentIdentifier",                                                                         // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 13. PaymentReconciliation.detail
                this.Element_Detail = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Detail",                                                                                                // MakerGen.cs:236
                    Path= "PaymentReconciliation.detail",                                                                                   // MakerGen.cs:237
                    Id = "PaymentReconciliation.detail",                                                                                    // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_Detail                                                                                                     // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 24. PaymentReconciliation.formCode
                this.Element_FormCode = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_FormCode",                                                                                              // MakerGen.cs:236
                    Path= "PaymentReconciliation.formCode",                                                                                 // MakerGen.cs:237
                    Id = "PaymentReconciliation.formCode",                                                                                  // MakerGen.cs:238
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
                // 25. PaymentReconciliation.processNote
                this.Element_ProcessNote = new ElementDefinitionInfo                                                                        // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_ProcessNote",                                                                                           // MakerGen.cs:236
                    Path= "PaymentReconciliation.processNote",                                                                              // MakerGen.cs:237
                    Id = "PaymentReconciliation.processNote",                                                                               // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_ProcessNote                                                                                                // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            this.Name = "PaymentReconciliation";                                                                                            // MakerGen.cs:468
            this.Uri = "http://hl7.org/fhir/StructureDefinition/PaymentReconciliation";                                                     // MakerGen.cs:469
        }                                                                                                                                   // MakerGen.cs:403
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:449
