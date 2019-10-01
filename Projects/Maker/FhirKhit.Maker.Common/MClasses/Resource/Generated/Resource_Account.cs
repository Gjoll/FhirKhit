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
      "id": "Account",
      "url": "http://hl7.org/fhir/StructureDefinition/Account",
      "version": "4.0.0",
      "name": "Account",
      "status": "draft",
      "publisher": "Health Level Seven International (Patient Administration)",
      "description": "A financial tool for tracking value accrued for a particular purpose.  In the healthcare field, used to track charges for a patient, cost centers, etc.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Account",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Account",
            "path": "Account",
            "short": "Tracks balance, charges, for patient or cost center",
            "definition": "A financial tool for tracking value accrued for a particular purpose.  In the healthcare field, used to track charges for a patient, cost centers, etc.",
            "alias": [
              "Cost center",
              "Record"
            ],
            "min": 0,
            "max": "*"
          },
          {
            "id": "Account.identifier",
            "path": "Account.identifier",
            "short": "Account number",
            "definition": "Unique identifier used to reference the account.  Might or might not be intended for human use (e.g. credit card number).",
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
            "id": "Account.status",
            "path": "Account.status",
            "short": "active | inactive | entered-in-error | on-hold | unknown",
            "definition": "Indicates whether the account is presently used/usable or not.",
            "comment": "This element is labeled as a modifier because the status contains the codes inactive and entered-in-error that mark the Account as not currently valid.",
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
                  "valueString": "AccountStatus"
                }
              ],
              "strength": "required",
              "description": "Indicates whether the account is available to be used.",
              "valueSet": "http://hl7.org/fhir/ValueSet/account-status|4.0.0"
            }
          },
          {
            "id": "Account.type",
            "path": "Account.type",
            "short": "E.g. patient, expense, depreciation",
            "definition": "Categorizes the account for reporting and searching purposes.",
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
                  "valueString": "AccountType"
                }
              ],
              "strength": "example",
              "description": "The usage type of this account, permits categorization of accounts.",
              "valueSet": "http://hl7.org/fhir/ValueSet/account-type"
            }
          },
          {
            "id": "Account.name",
            "path": "Account.name",
            "short": "Human-readable label",
            "definition": "Name used for the account when displaying it to humans in reports, etc.",
            "alias": [
              "Title"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Account.subject",
            "path": "Account.subject",
            "short": "The entity that caused the expenses",
            "definition": "Identifies the entity which incurs the expenses. While the immediate recipients of services or goods might be entities related to the subject, the expenses were ultimately incurred by the subject of the Account.",
            "comment": "Accounts can be applied to non-patients for tracking other non-patient related activities, such as group services (patients not tracked, and costs charged to another body), or might not be allocated.",
            "alias": [
              "target"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Location",
                  "http://hl7.org/fhir/StructureDefinition/HealthcareService",
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Account.servicePeriod",
            "path": "Account.servicePeriod",
            "short": "Transaction window",
            "definition": "The date range of services associated with this account.",
            "comment": "It is possible for transactions to be posted outside the service period, as long as the service was provided within the defined service period.",
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
            "id": "Account.coverage",
            "path": "Account.coverage",
            "short": "The party(s) that are responsible for covering the payment of this account, and what order should they be applied to the account",
            "definition": "The party(s) that are responsible for covering the payment of this account, and what order should they be applied to the account.",
            "comment": "Typically. this may be some form of insurance, internal charges, or self-pay.\n\nLocal or jurisdictional business rules may determine which coverage covers which types of billable items charged to the account, and in which order.\nWhere the order is important, a local/jurisdictional extension may be defined to specify the order for the type of charge.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Account.coverage.coverage",
            "path": "Account.coverage.coverage",
            "short": "The party(s), such as insurances, that may contribute to the payment of this account",
            "definition": "The party(s) that contribute to payment (or part of) of the charges applied to this account (including self-pay).\n\nA coverage may only be responsible for specific types of charges, and the sequence of the coverages in the account could be important when processing billing.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Coverage"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Account.coverage.priority",
            "path": "Account.coverage.priority",
            "short": "The priority of the coverage in the context of this account",
            "definition": "The priority of the coverage in the context of this account.",
            "comment": "It is common in some jurisdictions for there to be multiple coverages allocated to an account, and a sequence is required to order the settling of the account (often with insurance claiming).",
            "alias": [
              "coordination of benefit priority"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Account.owner",
            "path": "Account.owner",
            "short": "Entity managing the Account",
            "definition": "Indicates the service area, hospital, department, etc. with responsibility for managing the Account.",
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
            "id": "Account.description",
            "path": "Account.description",
            "short": "Explanation of purpose/use",
            "definition": "Provides additional information about what the account tracks and how it is used.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Account.guarantor",
            "path": "Account.guarantor",
            "short": "The parties ultimately responsible for balancing the Account",
            "definition": "The parties responsible for balancing the account if other payment options fall short.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Account.guarantor.party",
            "path": "Account.guarantor.party",
            "short": "Responsible entity",
            "definition": "The entity who is responsible.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ]
          },
          {
            "id": "Account.guarantor.onHold",
            "path": "Account.guarantor.onHold",
            "short": "Credit or other hold applied",
            "definition": "A guarantor may be placed on credit hold or otherwise have their role temporarily suspended.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "Account.guarantor.period",
            "path": "Account.guarantor.period",
            "short": "Guarantee account during",
            "definition": "The timeframe during which the guarantor accepts responsibility for the account.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ]
          },
          {
            "id": "Account.partOf",
            "path": "Account.partOf",
            "short": "Reference to a parent Account",
            "definition": "Reference to a parent Account.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Account"
                ]
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:440
    /// <summary>
    /// Fhir resource 'Account'
    /// </summary>
    // 0. Account
    public class Resource_Account : FhirKhit.Maker.Common.Resource.ResourceBase                                                             // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 7. Account.coverage
        public class Type_Coverage : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 8. Account.coverage.coverage
            public ElementDefinitionInfo Element_Coverage;                                                                                  // MakerGen.cs:212
            // 9. Account.coverage.priority
            public ElementDefinitionInfo Element_Priority;                                                                                  // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "Account.coverage",                                                                                              // MakerGen.cs:388
                    ElementId = "Account.coverage"                                                                                          // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Coverage.Write(sDef);                                                                                               // MakerGen.cs:216
                Element_Priority.Write(sDef);                                                                                               // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Coverage()                                                                                                          // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 8. Account.coverage.coverage
                    this.Element_Coverage = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Coverage",                                                                                          // MakerGen.cs:231
                        Path= "Account.coverage.coverage",                                                                                  // MakerGen.cs:232
                        Id = "Account.coverage.coverage",                                                                                   // MakerGen.cs:233
                        Min = 1,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:339
                            {                                                                                                               // MakerGen.cs:340
                                TargetProfile = new String[]                                                                                // MakerGen.cs:342
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Coverage"                                                      // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:343
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 9. Account.coverage.priority
                    this.Element_Priority = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Priority",                                                                                          // MakerGen.cs:231
                        Path= "Account.coverage.priority",                                                                                  // MakerGen.cs:232
                        Id = "Account.coverage.priority",                                                                                   // MakerGen.cs:233
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
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 12. Account.guarantor
        public class Type_Guarantor : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 13. Account.guarantor.party
            public ElementDefinitionInfo Element_Party;                                                                                     // MakerGen.cs:212
            // 14. Account.guarantor.onHold
            public ElementDefinitionInfo Element_OnHold;                                                                                    // MakerGen.cs:212
            // 15. Account.guarantor.period
            public ElementDefinitionInfo Element_Period;                                                                                    // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "Account.guarantor",                                                                                             // MakerGen.cs:388
                    ElementId = "Account.guarantor"                                                                                         // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Party.Write(sDef);                                                                                                  // MakerGen.cs:216
                Element_OnHold.Write(sDef);                                                                                                 // MakerGen.cs:216
                Element_Period.Write(sDef);                                                                                                 // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Guarantor()                                                                                                         // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 13. Account.guarantor.party
                    this.Element_Party = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Party",                                                                                             // MakerGen.cs:231
                        Path= "Account.guarantor.party",                                                                                    // MakerGen.cs:232
                        Id = "Account.guarantor.party",                                                                                     // MakerGen.cs:233
                        Min = 1,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:339
                            {                                                                                                               // MakerGen.cs:340
                                TargetProfile = new String[]                                                                                // MakerGen.cs:342
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                                // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:343
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 14. Account.guarantor.onHold
                    this.Element_OnHold = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_OnHold",                                                                                            // MakerGen.cs:231
                        Path= "Account.guarantor.onHold",                                                                                   // MakerGen.cs:232
                        Id = "Account.guarantor.onHold",                                                                                    // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                           // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 15. Account.guarantor.period
                    this.Element_Period = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Period",                                                                                            // MakerGen.cs:231
                        Path= "Account.guarantor.period",                                                                                   // MakerGen.cs:232
                        Id = "Account.guarantor.period",                                                                                    // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Period                                                                   // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            }                                                                                                               // MakerGen.cs:353
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 1. Account.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:212
        // 2. Account.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:212
        // 3. Account.type
        public ElementDefinitionInfo Element_Type;                                                                                          // MakerGen.cs:212
        // 4. Account.name
        public ElementDefinitionInfo Element_Name;                                                                                          // MakerGen.cs:212
        // 5. Account.subject
        public ElementDefinitionInfo Element_Subject;                                                                                       // MakerGen.cs:212
        // 6. Account.servicePeriod
        public ElementDefinitionInfo Element_ServicePeriod;                                                                                 // MakerGen.cs:212
        // 7. Account.coverage
        public ElementDefinitionInfo Element_Coverage;                                                                                      // MakerGen.cs:212
        // 10. Account.owner
        public ElementDefinitionInfo Element_Owner;                                                                                         // MakerGen.cs:212
        // 11. Account.description
        public ElementDefinitionInfo Element_Description;                                                                                   // MakerGen.cs:212
        // 12. Account.guarantor
        public ElementDefinitionInfo Element_Guarantor;                                                                                     // MakerGen.cs:212
        // 16. Account.partOf
        public ElementDefinitionInfo Element_PartOf;                                                                                        // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "Account",                                                                                                           // MakerGen.cs:388
                ElementId = "Account"                                                                                                       // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Type.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Name.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Subject.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_ServicePeriod.Write(sDef);                                                                                              // MakerGen.cs:216
            Element_Coverage.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_Owner.Write(sDef);                                                                                                      // MakerGen.cs:216
            Element_Description.Write(sDef);                                                                                                // MakerGen.cs:216
            Element_Guarantor.Write(sDef);                                                                                                  // MakerGen.cs:216
            Element_PartOf.Write(sDef);                                                                                                     // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Resource_Account()                                                                                                           // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. Account.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:231
                    Path= "Account.identifier",                                                                                             // MakerGen.cs:232
                    Id = "Account.identifier",                                                                                              // MakerGen.cs:233
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
                // 2. Account.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Status",                                                                                                // MakerGen.cs:231
                    Path= "Account.status",                                                                                                 // MakerGen.cs:232
                    Id = "Account.status",                                                                                                  // MakerGen.cs:233
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
                // 3. Account.type
                this.Element_Type = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:231
                    Path= "Account.type",                                                                                                   // MakerGen.cs:232
                    Id = "Account.type",                                                                                                    // MakerGen.cs:233
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
                // 4. Account.name
                this.Element_Name = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Name",                                                                                                  // MakerGen.cs:231
                    Path= "Account.name",                                                                                                   // MakerGen.cs:232
                    Id = "Account.name",                                                                                                    // MakerGen.cs:233
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
                // 5. Account.subject
                this.Element_Subject = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Subject",                                                                                               // MakerGen.cs:231
                    Path= "Account.subject",                                                                                                // MakerGen.cs:232
                    Id = "Account.subject",                                                                                                 // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Patient",                                                          // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Device",                                                           // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                                 // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Location",                                                         // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/HealthcareService",                                                // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 6. Account.servicePeriod
                this.Element_ServicePeriod = new ElementDefinitionInfo                                                                      // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_ServicePeriod",                                                                                         // MakerGen.cs:231
                    Path= "Account.servicePeriod",                                                                                          // MakerGen.cs:232
                    Id = "Account.servicePeriod",                                                                                           // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Period                                                                       // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 7. Account.coverage
                this.Element_Coverage = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Coverage",                                                                                              // MakerGen.cs:231
                    Path= "Account.coverage",                                                                                               // MakerGen.cs:232
                    Id = "Account.coverage",                                                                                                // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Coverage                                                                                                   // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 10. Account.owner
                this.Element_Owner = new ElementDefinitionInfo                                                                              // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Owner",                                                                                                 // MakerGen.cs:231
                    Path= "Account.owner",                                                                                                  // MakerGen.cs:232
                    Id = "Account.owner",                                                                                                   // MakerGen.cs:233
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
                // 11. Account.description
                this.Element_Description = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Description",                                                                                           // MakerGen.cs:231
                    Path= "Account.description",                                                                                            // MakerGen.cs:232
                    Id = "Account.description",                                                                                             // MakerGen.cs:233
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
                // 12. Account.guarantor
                this.Element_Guarantor = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Guarantor",                                                                                             // MakerGen.cs:231
                    Path= "Account.guarantor",                                                                                              // MakerGen.cs:232
                    Id = "Account.guarantor",                                                                                               // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Guarantor                                                                                                  // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 16. Account.partOf
                this.Element_PartOf = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_PartOf",                                                                                                // MakerGen.cs:231
                    Path= "Account.partOf",                                                                                                 // MakerGen.cs:232
                    Id = "Account.partOf",                                                                                                  // MakerGen.cs:233
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
            this.Name = "Account";                                                                                                          // MakerGen.cs:458
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Account";                                                                   // MakerGen.cs:459
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:445
