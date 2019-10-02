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
    #endregion
    /// <summary>
    /// Fhir resource 'Account'
    /// </summary>
    // 0. Account
    public partial class Resource_Account : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 7. Account.coverage
        public partial class Type_Coverage : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 8. Account.coverage.coverage
            public ElementDefinitionInfo Element_Coverage;
            // 9. Account.coverage.priority
            public ElementDefinitionInfo Element_Priority;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Account.coverage",
                    ElementId = "Account.coverage"
                });
                Element_Coverage.Write(sDef);
                Element_Priority.Write(sDef);
            }
            
            public Type_Coverage()
            {
                {
                    // 8. Account.coverage.coverage
                    this.Element_Coverage = new ElementDefinitionInfo
                    {
                        Name = "Element_Coverage",
                        Path= "Account.coverage.coverage",
                        Id = "Account.coverage.coverage",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Coverage"
                                }
                            }
                        }
                    };
                }
                {
                    // 9. Account.coverage.priority
                    this.Element_Priority = new ElementDefinitionInfo
                    {
                        Name = "Element_Priority",
                        Path= "Account.coverage.priority",
                        Id = "Account.coverage.priority",
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
            }
        }
        // 12. Account.guarantor
        public partial class Type_Guarantor : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 13. Account.guarantor.party
            public ElementDefinitionInfo Element_Party;
            // 14. Account.guarantor.onHold
            public ElementDefinitionInfo Element_OnHold;
            // 15. Account.guarantor.period
            public ElementDefinitionInfo Element_Period;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Account.guarantor",
                    ElementId = "Account.guarantor"
                });
                Element_Party.Write(sDef);
                Element_OnHold.Write(sDef);
                Element_Period.Write(sDef);
            }
            
            public Type_Guarantor()
            {
                {
                    // 13. Account.guarantor.party
                    this.Element_Party = new ElementDefinitionInfo
                    {
                        Name = "Element_Party",
                        Path= "Account.guarantor.party",
                        Id = "Account.guarantor.party",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Patient",
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                                    "http://hl7.org/fhir/StructureDefinition/Organization"
                                }
                            }
                        }
                    };
                }
                {
                    // 14. Account.guarantor.onHold
                    this.Element_OnHold = new ElementDefinitionInfo
                    {
                        Name = "Element_OnHold",
                        Path= "Account.guarantor.onHold",
                        Id = "Account.guarantor.onHold",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Boolean
                            {
                            }
                        }
                    };
                }
                {
                    // 15. Account.guarantor.period
                    this.Element_Period = new ElementDefinitionInfo
                    {
                        Name = "Element_Period",
                        Path= "Account.guarantor.period",
                        Id = "Account.guarantor.period",
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
            }
        }
        // 1. Account.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. Account.status
        public ElementDefinitionInfo Element_Status;
        // 3. Account.type
        public ElementDefinitionInfo Element_Type;
        // 4. Account.name
        public ElementDefinitionInfo Element_Name;
        // 5. Account.subject
        public ElementDefinitionInfo Element_Subject;
        // 6. Account.servicePeriod
        public ElementDefinitionInfo Element_ServicePeriod;
        // 7. Account.coverage
        public ElementDefinitionInfo Element_Coverage;
        // 10. Account.owner
        public ElementDefinitionInfo Element_Owner;
        // 11. Account.description
        public ElementDefinitionInfo Element_Description;
        // 12. Account.guarantor
        public ElementDefinitionInfo Element_Guarantor;
        // 16. Account.partOf
        public ElementDefinitionInfo Element_PartOf;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "Account",
                ElementId = "Account"
            });
            Element_Identifier.Write(sDef);
            Element_Status.Write(sDef);
            Element_Type.Write(sDef);
            Element_Name.Write(sDef);
            Element_Subject.Write(sDef);
            Element_ServicePeriod.Write(sDef);
            Element_Coverage.Write(sDef);
            Element_Owner.Write(sDef);
            Element_Description.Write(sDef);
            Element_Guarantor.Write(sDef);
            Element_PartOf.Write(sDef);
        }
        
        public Resource_Account()
        {
            {
                // 1. Account.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "Account.identifier",
                    Id = "Account.identifier",
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
                // 2. Account.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "Account.status",
                    Id = "Account.status",
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
                // 3. Account.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "Account.type",
                    Id = "Account.type",
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
                // 4. Account.name
                this.Element_Name = new ElementDefinitionInfo
                {
                    Name = "Element_Name",
                    Path= "Account.name",
                    Id = "Account.name",
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
                // 5. Account.subject
                this.Element_Subject = new ElementDefinitionInfo
                {
                    Name = "Element_Subject",
                    Path= "Account.subject",
                    Id = "Account.subject",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/Device",
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                "http://hl7.org/fhir/StructureDefinition/Location",
                                "http://hl7.org/fhir/StructureDefinition/HealthcareService",
                                "http://hl7.org/fhir/StructureDefinition/Organization"
                            }
                        }
                    }
                };
            }
            {
                // 6. Account.servicePeriod
                this.Element_ServicePeriod = new ElementDefinitionInfo
                {
                    Name = "Element_ServicePeriod",
                    Path= "Account.servicePeriod",
                    Id = "Account.servicePeriod",
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
                // 7. Account.coverage
                this.Element_Coverage = new ElementDefinitionInfo
                {
                    Name = "Element_Coverage",
                    Path= "Account.coverage",
                    Id = "Account.coverage",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Coverage
                        {
                        }
                    }
                };
            }
            {
                // 10. Account.owner
                this.Element_Owner = new ElementDefinitionInfo
                {
                    Name = "Element_Owner",
                    Path= "Account.owner",
                    Id = "Account.owner",
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
                // 11. Account.description
                this.Element_Description = new ElementDefinitionInfo
                {
                    Name = "Element_Description",
                    Path= "Account.description",
                    Id = "Account.description",
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
                // 12. Account.guarantor
                this.Element_Guarantor = new ElementDefinitionInfo
                {
                    Name = "Element_Guarantor",
                    Path= "Account.guarantor",
                    Id = "Account.guarantor",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Guarantor
                        {
                        }
                    }
                };
            }
            {
                // 16. Account.partOf
                this.Element_PartOf = new ElementDefinitionInfo
                {
                    Name = "Element_PartOf",
                    Path= "Account.partOf",
                    Id = "Account.partOf",
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
            this.Name = "Account";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Account";
        }
    }
}
