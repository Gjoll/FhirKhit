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
    #endregion
    /// <summary>
    /// Fhir resource 'PaymentReconciliation'
    /// </summary>
    // 0. PaymentReconciliation
    public partial class Resource_PaymentReconciliation : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 13. PaymentReconciliation.detail
        public partial class Type_Detail : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 14. PaymentReconciliation.detail.identifier
            public ElementDefinitionInfo Element_Identifier;
            // 15. PaymentReconciliation.detail.predecessor
            public ElementDefinitionInfo Element_Predecessor;
            // 16. PaymentReconciliation.detail.type
            public ElementDefinitionInfo Element_Type;
            // 17. PaymentReconciliation.detail.request
            public ElementDefinitionInfo Element_Request;
            // 18. PaymentReconciliation.detail.submitter
            public ElementDefinitionInfo Element_Submitter;
            // 19. PaymentReconciliation.detail.response
            public ElementDefinitionInfo Element_Response;
            // 20. PaymentReconciliation.detail.date
            public ElementDefinitionInfo Element_Date;
            // 21. PaymentReconciliation.detail.responsible
            public ElementDefinitionInfo Element_Responsible;
            // 22. PaymentReconciliation.detail.payee
            public ElementDefinitionInfo Element_Payee;
            // 23. PaymentReconciliation.detail.amount
            public ElementDefinitionInfo Element_Amount;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "PaymentReconciliation.detail",
                    ElementId = "PaymentReconciliation.detail"
                });
                Element_Identifier.Write(sDef);
                Element_Predecessor.Write(sDef);
                Element_Type.Write(sDef);
                Element_Request.Write(sDef);
                Element_Submitter.Write(sDef);
                Element_Response.Write(sDef);
                Element_Date.Write(sDef);
                Element_Responsible.Write(sDef);
                Element_Payee.Write(sDef);
                Element_Amount.Write(sDef);
            }
            
            public Type_Detail()
            {
                {
                    // 14. PaymentReconciliation.detail.identifier
                    this.Element_Identifier = new ElementDefinitionInfo
                    {
                        Name = "Element_Identifier",
                        Path= "PaymentReconciliation.detail.identifier",
                        Id = "PaymentReconciliation.detail.identifier",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Identifier
                            {
                            }
                        }
                    };
                }
                {
                    // 15. PaymentReconciliation.detail.predecessor
                    this.Element_Predecessor = new ElementDefinitionInfo
                    {
                        Name = "Element_Predecessor",
                        Path= "PaymentReconciliation.detail.predecessor",
                        Id = "PaymentReconciliation.detail.predecessor",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Identifier
                            {
                            }
                        }
                    };
                }
                {
                    // 16. PaymentReconciliation.detail.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "PaymentReconciliation.detail.type",
                        Id = "PaymentReconciliation.detail.type",
                        Min = 1,
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
                    // 17. PaymentReconciliation.detail.request
                    this.Element_Request = new ElementDefinitionInfo
                    {
                        Name = "Element_Request",
                        Path= "PaymentReconciliation.detail.request",
                        Id = "PaymentReconciliation.detail.request",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Resource"
                                }
                            }
                        }
                    };
                }
                {
                    // 18. PaymentReconciliation.detail.submitter
                    this.Element_Submitter = new ElementDefinitionInfo
                    {
                        Name = "Element_Submitter",
                        Path= "PaymentReconciliation.detail.submitter",
                        Id = "PaymentReconciliation.detail.submitter",
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
                    // 19. PaymentReconciliation.detail.response
                    this.Element_Response = new ElementDefinitionInfo
                    {
                        Name = "Element_Response",
                        Path= "PaymentReconciliation.detail.response",
                        Id = "PaymentReconciliation.detail.response",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Resource"
                                }
                            }
                        }
                    };
                }
                {
                    // 20. PaymentReconciliation.detail.date
                    this.Element_Date = new ElementDefinitionInfo
                    {
                        Name = "Element_Date",
                        Path= "PaymentReconciliation.detail.date",
                        Id = "PaymentReconciliation.detail.date",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Date
                            {
                            }
                        }
                    };
                }
                {
                    // 21. PaymentReconciliation.detail.responsible
                    this.Element_Responsible = new ElementDefinitionInfo
                    {
                        Name = "Element_Responsible",
                        Path= "PaymentReconciliation.detail.responsible",
                        Id = "PaymentReconciliation.detail.responsible",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                                }
                            }
                        }
                    };
                }
                {
                    // 22. PaymentReconciliation.detail.payee
                    this.Element_Payee = new ElementDefinitionInfo
                    {
                        Name = "Element_Payee",
                        Path= "PaymentReconciliation.detail.payee",
                        Id = "PaymentReconciliation.detail.payee",
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
                    // 23. PaymentReconciliation.detail.amount
                    this.Element_Amount = new ElementDefinitionInfo
                    {
                        Name = "Element_Amount",
                        Path= "PaymentReconciliation.detail.amount",
                        Id = "PaymentReconciliation.detail.amount",
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
        // 25. PaymentReconciliation.processNote
        public partial class Type_ProcessNote : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 26. PaymentReconciliation.processNote.type
            public ElementDefinitionInfo Element_Type;
            // 27. PaymentReconciliation.processNote.text
            public ElementDefinitionInfo Element_Text;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "PaymentReconciliation.processNote",
                    ElementId = "PaymentReconciliation.processNote"
                });
                Element_Type.Write(sDef);
                Element_Text.Write(sDef);
            }
            
            public Type_ProcessNote()
            {
                {
                    // 26. PaymentReconciliation.processNote.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "PaymentReconciliation.processNote.type",
                        Id = "PaymentReconciliation.processNote.type",
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
                    // 27. PaymentReconciliation.processNote.text
                    this.Element_Text = new ElementDefinitionInfo
                    {
                        Name = "Element_Text",
                        Path= "PaymentReconciliation.processNote.text",
                        Id = "PaymentReconciliation.processNote.text",
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
            }
        }
        // 1. PaymentReconciliation.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. PaymentReconciliation.status
        public ElementDefinitionInfo Element_Status;
        // 3. PaymentReconciliation.period
        public ElementDefinitionInfo Element_Period;
        // 4. PaymentReconciliation.created
        public ElementDefinitionInfo Element_Created;
        // 5. PaymentReconciliation.paymentIssuer
        public ElementDefinitionInfo Element_PaymentIssuer;
        // 6. PaymentReconciliation.request
        public ElementDefinitionInfo Element_Request;
        // 7. PaymentReconciliation.requestor
        public ElementDefinitionInfo Element_Requestor;
        // 8. PaymentReconciliation.outcome
        public ElementDefinitionInfo Element_Outcome;
        // 9. PaymentReconciliation.disposition
        public ElementDefinitionInfo Element_Disposition;
        // 10. PaymentReconciliation.paymentDate
        public ElementDefinitionInfo Element_PaymentDate;
        // 11. PaymentReconciliation.paymentAmount
        public ElementDefinitionInfo Element_PaymentAmount;
        // 12. PaymentReconciliation.paymentIdentifier
        public ElementDefinitionInfo Element_PaymentIdentifier;
        // 13. PaymentReconciliation.detail
        public ElementDefinitionInfo Element_Detail;
        // 24. PaymentReconciliation.formCode
        public ElementDefinitionInfo Element_FormCode;
        // 25. PaymentReconciliation.processNote
        public ElementDefinitionInfo Element_ProcessNote;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "PaymentReconciliation",
                ElementId = "PaymentReconciliation"
            });
            Element_Identifier.Write(sDef);
            Element_Status.Write(sDef);
            Element_Period.Write(sDef);
            Element_Created.Write(sDef);
            Element_PaymentIssuer.Write(sDef);
            Element_Request.Write(sDef);
            Element_Requestor.Write(sDef);
            Element_Outcome.Write(sDef);
            Element_Disposition.Write(sDef);
            Element_PaymentDate.Write(sDef);
            Element_PaymentAmount.Write(sDef);
            Element_PaymentIdentifier.Write(sDef);
            Element_Detail.Write(sDef);
            Element_FormCode.Write(sDef);
            Element_ProcessNote.Write(sDef);
        }
        
        public Resource_PaymentReconciliation()
        {
            {
                // 1. PaymentReconciliation.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "PaymentReconciliation.identifier",
                    Id = "PaymentReconciliation.identifier",
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
                // 2. PaymentReconciliation.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "PaymentReconciliation.status",
                    Id = "PaymentReconciliation.status",
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
                // 3. PaymentReconciliation.period
                this.Element_Period = new ElementDefinitionInfo
                {
                    Name = "Element_Period",
                    Path= "PaymentReconciliation.period",
                    Id = "PaymentReconciliation.period",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Period
                        {
                        }
                    }
                };
            }
            {
                // 4. PaymentReconciliation.created
                this.Element_Created = new ElementDefinitionInfo
                {
                    Name = "Element_Created",
                    Path= "PaymentReconciliation.created",
                    Id = "PaymentReconciliation.created",
                    Min = 1,
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
                // 5. PaymentReconciliation.paymentIssuer
                this.Element_PaymentIssuer = new ElementDefinitionInfo
                {
                    Name = "Element_PaymentIssuer",
                    Path= "PaymentReconciliation.paymentIssuer",
                    Id = "PaymentReconciliation.paymentIssuer",
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
                // 6. PaymentReconciliation.request
                this.Element_Request = new ElementDefinitionInfo
                {
                    Name = "Element_Request",
                    Path= "PaymentReconciliation.request",
                    Id = "PaymentReconciliation.request",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Task"
                            }
                        }
                    }
                };
            }
            {
                // 7. PaymentReconciliation.requestor
                this.Element_Requestor = new ElementDefinitionInfo
                {
                    Name = "Element_Requestor",
                    Path= "PaymentReconciliation.requestor",
                    Id = "PaymentReconciliation.requestor",
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
                // 8. PaymentReconciliation.outcome
                this.Element_Outcome = new ElementDefinitionInfo
                {
                    Name = "Element_Outcome",
                    Path= "PaymentReconciliation.outcome",
                    Id = "PaymentReconciliation.outcome",
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
                // 9. PaymentReconciliation.disposition
                this.Element_Disposition = new ElementDefinitionInfo
                {
                    Name = "Element_Disposition",
                    Path= "PaymentReconciliation.disposition",
                    Id = "PaymentReconciliation.disposition",
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
                // 10. PaymentReconciliation.paymentDate
                this.Element_PaymentDate = new ElementDefinitionInfo
                {
                    Name = "Element_PaymentDate",
                    Path= "PaymentReconciliation.paymentDate",
                    Id = "PaymentReconciliation.paymentDate",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Date
                        {
                        }
                    }
                };
            }
            {
                // 11. PaymentReconciliation.paymentAmount
                this.Element_PaymentAmount = new ElementDefinitionInfo
                {
                    Name = "Element_PaymentAmount",
                    Path= "PaymentReconciliation.paymentAmount",
                    Id = "PaymentReconciliation.paymentAmount",
                    Min = 1,
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
                // 12. PaymentReconciliation.paymentIdentifier
                this.Element_PaymentIdentifier = new ElementDefinitionInfo
                {
                    Name = "Element_PaymentIdentifier",
                    Path= "PaymentReconciliation.paymentIdentifier",
                    Id = "PaymentReconciliation.paymentIdentifier",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Identifier
                        {
                        }
                    }
                };
            }
            {
                // 13. PaymentReconciliation.detail
                this.Element_Detail = new ElementDefinitionInfo
                {
                    Name = "Element_Detail",
                    Path= "PaymentReconciliation.detail",
                    Id = "PaymentReconciliation.detail",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Detail
                        {
                        }
                    }
                };
            }
            {
                // 24. PaymentReconciliation.formCode
                this.Element_FormCode = new ElementDefinitionInfo
                {
                    Name = "Element_FormCode",
                    Path= "PaymentReconciliation.formCode",
                    Id = "PaymentReconciliation.formCode",
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
                // 25. PaymentReconciliation.processNote
                this.Element_ProcessNote = new ElementDefinitionInfo
                {
                    Name = "Element_ProcessNote",
                    Path= "PaymentReconciliation.processNote",
                    Id = "PaymentReconciliation.processNote",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_ProcessNote
                        {
                        }
                    }
                };
            }
            this.Name = "PaymentReconciliation";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/PaymentReconciliation";
        }
    }
}
