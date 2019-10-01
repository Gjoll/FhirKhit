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
      "id": "PaymentNotice",
      "url": "http://hl7.org/fhir/StructureDefinition/PaymentNotice",
      "version": "4.0.0",
      "name": "PaymentNotice",
      "status": "draft",
      "publisher": "Health Level Seven International (Financial Management)",
      "description": "This resource provides the status of the payment for goods and services rendered, and the request and response resource references.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "PaymentNotice",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "PaymentNotice",
            "path": "PaymentNotice",
            "short": "PaymentNotice request",
            "definition": "This resource provides the status of the payment for goods and services rendered, and the request and response resource references.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "PaymentNotice.identifier",
            "path": "PaymentNotice.identifier",
            "short": "Business Identifier for the payment noctice",
            "definition": "A unique identifier assigned to this payment notice.",
            "requirements": "Allows payment notices to be distinguished and referenced.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ]
          },
          {
            "id": "PaymentNotice.status",
            "path": "PaymentNotice.status",
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
                  "valueString": "PaymentNoticeStatus"
                }
              ],
              "strength": "required",
              "description": "A code specifying the state of the resource instance.",
              "valueSet": "http://hl7.org/fhir/ValueSet/fm-status|4.0.0"
            }
          },
          {
            "id": "PaymentNotice.request",
            "path": "PaymentNotice.request",
            "short": "Request reference",
            "definition": "Reference of resource for which payment is being made.",
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
            "id": "PaymentNotice.response",
            "path": "PaymentNotice.response",
            "short": "Response reference",
            "definition": "Reference of response to resource for which payment is being made.",
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
            "id": "PaymentNotice.created",
            "path": "PaymentNotice.created",
            "short": "Creation date",
            "definition": "The date when this resource was created.",
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
            "id": "PaymentNotice.provider",
            "path": "PaymentNotice.provider",
            "short": "Responsible practitioner",
            "definition": "The practitioner who is responsible for the services rendered to the patient.",
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
            "id": "PaymentNotice.payment",
            "path": "PaymentNotice.payment",
            "short": "Payment reference",
            "definition": "A reference to the payment which is the subject of this notice.",
            "requirements": "Need to identify the actual payment.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/PaymentReconciliation"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "PaymentNotice.paymentDate",
            "path": "PaymentNotice.paymentDate",
            "short": "Payment or clearing date",
            "definition": "The date when the above payment action occurred.",
            "requirements": "Need to convey the date when the action being notified occurred.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "date"
              }
            ]
          },
          {
            "id": "PaymentNotice.payee",
            "path": "PaymentNotice.payee",
            "short": "Party being paid",
            "definition": "The party who will receive or has received payment that is the subject of this notification.",
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
            "id": "PaymentNotice.recipient",
            "path": "PaymentNotice.recipient",
            "short": "Party being notified",
            "definition": "The party who is notified of the payment status.",
            "requirements": "Need to identified the recipient of the notification.",
            "min": 1,
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
            "id": "PaymentNotice.amount",
            "path": "PaymentNotice.amount",
            "short": "Monetary amount of the payment",
            "definition": "The amount sent to the payee.",
            "requirements": "Provided for validation purposes.",
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
            "id": "PaymentNotice.paymentStatus",
            "path": "PaymentNotice.paymentStatus",
            "short": "Issued or cleared Status of the payment",
            "definition": "A code indicating whether payment has been sent or cleared.",
            "comment": "Typically paid: payment sent, cleared: payment received.",
            "requirements": "The purpose of the notification.",
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
                  "valueString": "PaymentStatus"
                }
              ],
              "strength": "example",
              "description": "The payment conveyance status codes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/payment-status"
            }
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:461
    /// <summary>
    /// Fhir resource 'PaymentNotice'
    /// </summary>
    // 0. PaymentNotice
    public class PaymentNotice : FhirKhit.Maker.Common.Resource.ResourceBase                                                                // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        public class PaymentNotice_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                   // MakerGen.cs:385
        {                                                                                                                                   // MakerGen.cs:386
            // 1. PaymentNotice.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 2. PaymentNotice.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:216
            // 3. PaymentNotice.request
            public ElementDefinitionInfo Request;                                                                                           // MakerGen.cs:216
            // 4. PaymentNotice.response
            public ElementDefinitionInfo Response;                                                                                          // MakerGen.cs:216
            // 5. PaymentNotice.created
            public ElementDefinitionInfo Created;                                                                                           // MakerGen.cs:216
            // 6. PaymentNotice.provider
            public ElementDefinitionInfo Provider;                                                                                          // MakerGen.cs:216
            // 7. PaymentNotice.payment
            public ElementDefinitionInfo Payment;                                                                                           // MakerGen.cs:216
            // 8. PaymentNotice.paymentDate
            public ElementDefinitionInfo PaymentDate;                                                                                       // MakerGen.cs:216
            // 9. PaymentNotice.payee
            public ElementDefinitionInfo Payee;                                                                                             // MakerGen.cs:216
            // 10. PaymentNotice.recipient
            public ElementDefinitionInfo Recipient;                                                                                         // MakerGen.cs:216
            // 11. PaymentNotice.amount
            public ElementDefinitionInfo Amount;                                                                                            // MakerGen.cs:216
            // 12. PaymentNotice.paymentStatus
            public ElementDefinitionInfo PaymentStatus;                                                                                     // MakerGen.cs:216
            public PaymentNotice_Elements()                                                                                                 // MakerGen.cs:407
            {                                                                                                                               // MakerGen.cs:408
                {                                                                                                                           // MakerGen.cs:231
                    // 1. PaymentNotice.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "PaymentNotice.identifier",                                                                                   // MakerGen.cs:236
                        Id = "PaymentNotice.identifier",                                                                                    // MakerGen.cs:237
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
                    // 2. PaymentNotice.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Status",                                                                                                    // MakerGen.cs:235
                        Path= "PaymentNotice.status",                                                                                       // MakerGen.cs:236
                        Id = "PaymentNotice.status",                                                                                        // MakerGen.cs:237
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
                    // 3. PaymentNotice.request
                    this.Request = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Request",                                                                                                   // MakerGen.cs:235
                        Path= "PaymentNotice.request",                                                                                      // MakerGen.cs:236
                        Id = "PaymentNotice.request",                                                                                       // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Resource"                                                      // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 4. PaymentNotice.response
                    this.Response = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Response",                                                                                                  // MakerGen.cs:235
                        Path= "PaymentNotice.response",                                                                                     // MakerGen.cs:236
                        Id = "PaymentNotice.response",                                                                                      // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Resource"                                                      // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 5. PaymentNotice.created
                    this.Created = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Created",                                                                                                   // MakerGen.cs:235
                        Path= "PaymentNotice.created",                                                                                      // MakerGen.cs:236
                        Id = "PaymentNotice.created",                                                                                       // MakerGen.cs:237
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
                    // 6. PaymentNotice.provider
                    this.Provider = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Provider",                                                                                                  // MakerGen.cs:235
                        Path= "PaymentNotice.provider",                                                                                     // MakerGen.cs:236
                        Id = "PaymentNotice.provider",                                                                                      // MakerGen.cs:237
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
                    // 7. PaymentNotice.payment
                    this.Payment = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Payment",                                                                                                   // MakerGen.cs:235
                        Path= "PaymentNotice.payment",                                                                                      // MakerGen.cs:236
                        Id = "PaymentNotice.payment",                                                                                       // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/PaymentReconciliation"                                         // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 8. PaymentNotice.paymentDate
                    this.PaymentDate = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "PaymentDate",                                                                                               // MakerGen.cs:235
                        Path= "PaymentNotice.paymentDate",                                                                                  // MakerGen.cs:236
                        Id = "PaymentNotice.paymentDate",                                                                                   // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
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
                    // 9. PaymentNotice.payee
                    this.Payee = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Payee",                                                                                                     // MakerGen.cs:235
                        Path= "PaymentNotice.payee",                                                                                        // MakerGen.cs:236
                        Id = "PaymentNotice.payee",                                                                                         // MakerGen.cs:237
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
                    // 10. PaymentNotice.recipient
                    this.Recipient = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Recipient",                                                                                                 // MakerGen.cs:235
                        Path= "PaymentNotice.recipient",                                                                                    // MakerGen.cs:236
                        Id = "PaymentNotice.recipient",                                                                                     // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
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
                    // 11. PaymentNotice.amount
                    this.Amount = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Amount",                                                                                                    // MakerGen.cs:235
                        Path= "PaymentNotice.amount",                                                                                       // MakerGen.cs:236
                        Id = "PaymentNotice.amount",                                                                                        // MakerGen.cs:237
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
                    // 12. PaymentNotice.paymentStatus
                    this.PaymentStatus = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "PaymentStatus",                                                                                             // MakerGen.cs:235
                        Path= "PaymentNotice.paymentStatus",                                                                                // MakerGen.cs:236
                        Id = "PaymentNotice.paymentStatus",                                                                                 // MakerGen.cs:237
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
            }                                                                                                                               // MakerGen.cs:427
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:412
            {                                                                                                                               // MakerGen.cs:413
                base.Write(sDef);                                                                                                           // MakerGen.cs:414
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:220
                Status.Write(sDef);                                                                                                         // MakerGen.cs:220
                Request.Write(sDef);                                                                                                        // MakerGen.cs:220
                Response.Write(sDef);                                                                                                       // MakerGen.cs:220
                Created.Write(sDef);                                                                                                        // MakerGen.cs:220
                Provider.Write(sDef);                                                                                                       // MakerGen.cs:220
                Payment.Write(sDef);                                                                                                        // MakerGen.cs:220
                PaymentDate.Write(sDef);                                                                                                    // MakerGen.cs:220
                Payee.Write(sDef);                                                                                                          // MakerGen.cs:220
                Recipient.Write(sDef);                                                                                                      // MakerGen.cs:220
                Amount.Write(sDef);                                                                                                         // MakerGen.cs:220
                PaymentStatus.Write(sDef);                                                                                                  // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:431
        }                                                                                                                                   // MakerGen.cs:391
        public PaymentNotice_Elements Elements { get; }                                                                                     // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
        public PaymentNotice()                                                                                                              // MakerGen.cs:394
        {                                                                                                                                   // MakerGen.cs:395
            this.Elements = new PaymentNotice_Elements();                                                                                   // MakerGen.cs:396
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:399
        {                                                                                                                                   // MakerGen.cs:400
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:401
        }                                                                                                                                   // MakerGen.cs:402
    }                                                                                                                                       // MakerGen.cs:403
}                                                                                                                                           // MakerGen.cs:466
