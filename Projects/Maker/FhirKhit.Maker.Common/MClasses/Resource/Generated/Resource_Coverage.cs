using System;                                                                                                                               // MakerGen.cs:435
using System.Diagnostics;                                                                                                                   // MakerGen.cs:436
using System.IO;                                                                                                                            // MakerGen.cs:437
using System.Linq;                                                                                                                          // MakerGen.cs:438
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:439
                                                                                                                                            // MakerGen.cs:440
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:441
{                                                                                                                                           // MakerGen.cs:442
    #region Json                                                                                                                            // MakerGen.cs:443
    #if NEVER                                                                                                                               // MakerGen.cs:444
    {
      "resourceType": "StructureDefinition",
      "id": "Coverage",
      "url": "http://hl7.org/fhir/StructureDefinition/Coverage",
      "version": "4.0.0",
      "name": "Coverage",
      "status": "draft",
      "publisher": "Health Level Seven International (Financial Management)",
      "description": "Financial instrument which may be used to reimburse or pay for health care products and services. Includes both insurance and self-payment.",
      "purpose": "Coverage provides a link between covered parties (patients) and the payors of their healthcare costs (both insurance and self-pay).",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Coverage",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Coverage",
            "path": "Coverage",
            "short": "Insurance or medical plan or a payment agreement",
            "definition": "Financial instrument which may be used to reimburse or pay for health care products and services. Includes both insurance and self-payment.",
            "comment": "The Coverage resource contains the insurance card level information, which is customary to provide on claims and other communications between providers and insurers.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Coverage.identifier",
            "path": "Coverage.identifier",
            "short": "Business Identifier for the coverage",
            "definition": "A unique identifier assigned to this coverage.",
            "comment": "The main (and possibly only) identifier for the coverage - often referred to as a Member Id, Certificate number, Personal Health Number or Case ID. May be constructed as the concatenation of the Coverage.SubscriberID and the Coverage.dependant.",
            "requirements": "Allows coverages to be distinguished and referenced.",
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
            "id": "Coverage.status",
            "path": "Coverage.status",
            "short": "active | cancelled | draft | entered-in-error",
            "definition": "The status of the resource instance.",
            "comment": "This element is labeled as a modifier because the status contains the code entered-in-error that marks the coverage as not currently valid.",
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
                  "valueString": "CoverageStatus"
                }
              ],
              "strength": "required",
              "description": "A code specifying the state of the resource instance.",
              "valueSet": "http://hl7.org/fhir/ValueSet/fm-status|4.0.0"
            }
          },
          {
            "id": "Coverage.type",
            "path": "Coverage.type",
            "short": "Coverage category such as medical or accident",
            "definition": "The type of coverage: social program, medical plan, accident coverage (workers compensation, auto), group health or payment by an individual or organization.",
            "requirements": "The order of application of coverages is dependent on the types of coverage.",
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
                  "valueString": "CoverageType"
                }
              ],
              "strength": "preferred",
              "description": "The type of insurance: public health, worker compensation; private accident, auto, private health, etc.) or a direct payment by an individual or organization.",
              "valueSet": "http://hl7.org/fhir/ValueSet/coverage-type"
            }
          },
          {
            "id": "Coverage.policyHolder",
            "path": "Coverage.policyHolder",
            "short": "Owner of the policy",
            "definition": "The party who 'owns' the insurance policy.",
            "comment": "For example: may be an individual, corporation or the subscriber's employer.",
            "requirements": "This provides employer information in the case of Worker's Compensation and other policies.",
            "min": 0,
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
            ],
            "isSummary": true
          },
          {
            "id": "Coverage.subscriber",
            "path": "Coverage.subscriber",
            "short": "Subscriber to the policy",
            "definition": "The party who has signed-up for or 'owns' the contractual relationship to the policy or to whom the benefit of the policy for services rendered to them or their family is due.",
            "comment": "May be self or a parent in the case of dependants.",
            "requirements": "This is the party who is entitled to the benfits under the policy.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Coverage.subscriberId",
            "path": "Coverage.subscriberId",
            "short": "ID assigned to the subscriber",
            "definition": "The insurer assigned ID for the Subscriber.",
            "requirements": "The insurer requires this identifier on correspondance and claims (digital and otherwise).",
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
            "id": "Coverage.beneficiary",
            "path": "Coverage.beneficiary",
            "short": "Plan beneficiary",
            "definition": "The party who benefits from the insurance coverage; the patient when products and/or services are provided.",
            "requirements": "This is the party who receives treatment for which the costs are reimbursed under the coverage.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Coverage.dependent",
            "path": "Coverage.dependent",
            "short": "Dependent number",
            "definition": "A unique identifier for a dependent under the coverage.",
            "comment": "Periodically the member number is constructed from the subscriberId and the dependant number.",
            "requirements": "For some coverages a single identifier is issued to the Subscriber and then a unique dependent number is issued to each beneficiary.",
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
            "id": "Coverage.relationship",
            "path": "Coverage.relationship",
            "short": "Beneficiary relationship to the subscriber",
            "definition": "The relationship of beneficiary (patient) to the subscriber.",
            "comment": "Typically, an individual uses policies which are theirs (relationship='self') before policies owned by others.",
            "requirements": "To determine relationship between the patient and the subscriber to determine coordination of benefits.",
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
                  "valueString": "Relationship"
                }
              ],
              "strength": "extensible",
              "description": "The relationship between the Subscriber and the Beneficiary (insured/covered party/patient).",
              "valueSet": "http://hl7.org/fhir/ValueSet/subscriber-relationship"
            }
          },
          {
            "id": "Coverage.period",
            "path": "Coverage.period",
            "short": "Coverage start and end dates",
            "definition": "Time period during which the coverage is in force. A missing start date indicates the start date isn't known, a missing end date means the coverage is continuing to be in force.",
            "requirements": "Some insurers require the submission of the coverage term.",
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
            "id": "Coverage.payor",
            "path": "Coverage.payor",
            "short": "Issuer of the policy",
            "definition": "The program or plan underwriter or payor including both insurance and non-insurance agreements, such as patient-pay agreements.",
            "comment": "May provide multiple identifiers such as insurance company identifier or business identifier (BIN number).\nFor selfpay it may provide multiple paying persons and/or organizations.",
            "requirements": "Need to identify the issuer to target for claim processing and for coordination of benefit processing.",
            "min": 1,
            "max": "*",
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
            "id": "Coverage.class",
            "path": "Coverage.class",
            "short": "Additional coverage classifications",
            "definition": "A suite of underwriter specific classifiers.",
            "comment": "For example may be used to identify a class of coverage or employer group, Policy, Plan.",
            "requirements": "The codes provided on the health card which identify or confirm the specific policy for the insurer.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Coverage.class.type",
            "path": "Coverage.class.type",
            "short": "Type of class such as 'group' or 'plan'",
            "definition": "The type of classification for which an insurer-specific class label or number and optional name is provided, for example may be used to identify a class of coverage or employer group, Policy, Plan.",
            "requirements": "The insurer issued label for a specific health card value.",
            "min": 1,
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
                  "valueString": "CoverageClass"
                }
              ],
              "strength": "extensible",
              "description": "The policy classifications, eg. Group, Plan, Class, etc.",
              "valueSet": "http://hl7.org/fhir/ValueSet/coverage-class"
            }
          },
          {
            "id": "Coverage.class.value",
            "path": "Coverage.class.value",
            "short": "Value associated with the type",
            "definition": "The alphanumeric string value associated with the insurer issued label.",
            "comment": "For example, the Group or Plan number.",
            "requirements": "The insurer issued label and value are necessary to identify the specific policy.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Coverage.class.name",
            "path": "Coverage.class.name",
            "short": "Human readable description of the type and value",
            "definition": "A short description for the class.",
            "requirements": "Used to provide a meaningful description in correspondence to the patient.",
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
            "id": "Coverage.order",
            "path": "Coverage.order",
            "short": "Relative order of the coverage",
            "definition": "The order of applicability of this coverage relative to other coverages which are currently in force. Note, there may be gaps in the numbering and this does not imply primary, secondary etc. as the specific positioning of coverages depends upon the episode of care.",
            "requirements": "Used in managing the coordination of benefits.",
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
            "id": "Coverage.network",
            "path": "Coverage.network",
            "short": "Insurer network",
            "definition": "The insurer-specific identifier for the insurer-defined network of providers to which the beneficiary may seek treatment which will be covered at the 'in-network' rate, otherwise 'out of network' terms and conditions apply.",
            "requirements": "Used in referral for treatment and in claims processing.",
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
            "id": "Coverage.costToBeneficiary",
            "path": "Coverage.costToBeneficiary",
            "short": "Patient payments for services/products",
            "definition": "A suite of codes indicating the cost category and associated amount which have been detailed in the policy and may have been  included on the health card.",
            "comment": "For example by knowing the patient visit co-pay, the provider can collect the amount prior to undertaking treatment.",
            "requirements": "Required by providers to manage financial transaction with the patient.",
            "alias": [
              "CoPay",
              "Deductible",
              "Exceptions"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Coverage.costToBeneficiary.type",
            "path": "Coverage.costToBeneficiary.type",
            "short": "Cost category",
            "definition": "The category of patient centric costs associated with treatment.",
            "comment": "For example visit, specialist visits, emergency, inpatient care, etc.",
            "requirements": "Needed to identify the category associated with the amount for the patient.",
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
                  "valueString": "CopayTypes"
                }
              ],
              "strength": "extensible",
              "description": "The types of services to which patient copayments are specified.",
              "valueSet": "http://hl7.org/fhir/ValueSet/coverage-copay-type"
            }
          },
          {
            "id": "Coverage.costToBeneficiary.value[x]",
            "path": "Coverage.costToBeneficiary.value[x]",
            "short": "The amount or percentage due from the beneficiary",
            "definition": "The amount due from the patient for the cost category.",
            "comment": "Amount may be expressed as a percentage of the service/product cost or a fixed amount of currency.",
            "requirements": "Needed to identify the amount for the patient associated with the category.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Quantity",
                "profile": [
                  "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
                ]
              },
              {
                "code": "Money"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Coverage.costToBeneficiary.exception",
            "path": "Coverage.costToBeneficiary.exception",
            "short": "Exceptions for patient payments",
            "definition": "A suite of codes indicating exceptions or reductions to patient costs and their effective periods.",
            "requirements": "Required by providers to manage financial transaction with the patient.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Coverage.costToBeneficiary.exception.type",
            "path": "Coverage.costToBeneficiary.exception.type",
            "short": "Exception category",
            "definition": "The code for the specific exception.",
            "requirements": "Needed to identify the exception associated with the amount for the patient.",
            "min": 1,
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
                  "valueString": "CoverageFinancialException"
                }
              ],
              "strength": "example",
              "description": "The types of exceptions from the part or full value of financial obligations such as copays.",
              "valueSet": "http://hl7.org/fhir/ValueSet/coverage-financial-exception"
            }
          },
          {
            "id": "Coverage.costToBeneficiary.exception.period",
            "path": "Coverage.costToBeneficiary.exception.period",
            "short": "The effective period of the exception",
            "definition": "The timeframe during when the exception is in force.",
            "requirements": "Needed to identify the applicable timeframe for the exception for the correct calculation of patient costs.",
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
            "id": "Coverage.subrogation",
            "path": "Coverage.subrogation",
            "short": "Reimbursement to insurer",
            "definition": "When 'subrogation=true' this insurance instance has been included not for adjudication but to provide insurers with the details to recover costs.",
            "comment": "Typically, automotive and worker's compensation policies would be flagged with 'subrogation=true' to enable healthcare payors to collect against accident claims.",
            "requirements": "See definition for when to be used.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "Coverage.contract",
            "path": "Coverage.contract",
            "short": "Contract details",
            "definition": "The policy(s) which constitute this insurance coverage.",
            "requirements": "To reference the legally binding contract between the policy holder and the insurer.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Contract"
                ]
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:447
    /// <summary>
    /// Fhir resource 'Coverage'
    /// </summary>
    // 0. Coverage
    public class Resource_Coverage : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                                 // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        // 12. Coverage.class
        public class Type_Class : FhirKhit.Maker.Common.Complex.ComplexBase                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 13. Coverage.class.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:219
            // 14. Coverage.class.value
            public ElementDefinitionInfo Element_Value;                                                                                     // MakerGen.cs:219
            // 15. Coverage.class.name
            public ElementDefinitionInfo Element_Name;                                                                                      // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "Coverage.class",                                                                                                // MakerGen.cs:395
                    ElementId = "Coverage.class"                                                                                            // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:223
                Element_Value.Write(sDef);                                                                                                  // MakerGen.cs:223
                Element_Name.Write(sDef);                                                                                                   // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Class()                                                                                                             // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 13. Coverage.class.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Type",                                                                                              // MakerGen.cs:238
                        Path= "Coverage.class.type",                                                                                        // MakerGen.cs:239
                        Id = "Coverage.class.type",                                                                                         // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 14. Coverage.class.value
                    this.Element_Value = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Value",                                                                                             // MakerGen.cs:238
                        Path= "Coverage.class.value",                                                                                       // MakerGen.cs:239
                        Id = "Coverage.class.value",                                                                                        // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 15. Coverage.class.name
                    this.Element_Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Name",                                                                                              // MakerGen.cs:238
                        Path= "Coverage.class.name",                                                                                        // MakerGen.cs:239
                        Id = "Coverage.class.name",                                                                                         // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 18. Coverage.costToBeneficiary
        public class Type_CostToBeneficiary : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 21. Coverage.costToBeneficiary.exception
            public class Type_Exception : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                // 22. Coverage.costToBeneficiary.exception.type
                public ElementDefinitionInfo Element_Type;                                                                                  // MakerGen.cs:219
                // 23. Coverage.costToBeneficiary.exception.period
                public ElementDefinitionInfo Element_Period;                                                                                // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:390
                {                                                                                                                           // MakerGen.cs:391
                    base.Write(sDef);                                                                                                       // MakerGen.cs:392
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        Path = "Coverage.costToBeneficiary.exception",                                                                      // MakerGen.cs:395
                        ElementId = "Coverage.costToBeneficiary.exception"                                                                  // MakerGen.cs:396
                    });                                                                                                                     // MakerGen.cs:397
                    Element_Type.Write(sDef);                                                                                               // MakerGen.cs:223
                    Element_Period.Write(sDef);                                                                                             // MakerGen.cs:223
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
                public Type_Exception()                                                                                                     // MakerGen.cs:402
                {                                                                                                                           // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:234
                        // 22. Coverage.costToBeneficiary.exception.type
                        this.Element_Type = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Type",                                                                                          // MakerGen.cs:238
                            Path= "Coverage.costToBeneficiary.exception.type",                                                              // MakerGen.cs:239
                            Id = "Coverage.costToBeneficiary.exception.type",                                                               // MakerGen.cs:240
                            Min = 1,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:318
                                {                                                                                                           // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:322
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 23. Coverage.costToBeneficiary.exception.period
                        this.Element_Period = new ElementDefinitionInfo                                                                     // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Period",                                                                                        // MakerGen.cs:238
                            Path= "Coverage.costToBeneficiary.exception.period",                                                            // MakerGen.cs:239
                            Id = "Coverage.costToBeneficiary.exception.period",                                                             // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_Period                                                               // MakerGen.cs:358
                                {                                                                                                           // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:360
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                }                                                                                                                           // MakerGen.cs:405
            }                                                                                                                               // MakerGen.cs:407
            // 19. Coverage.costToBeneficiary.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:219
            // 20. Coverage.costToBeneficiary.value[x]
            public ElementDefinitionInfo Element_Value;                                                                                     // MakerGen.cs:219
            // 21. Coverage.costToBeneficiary.exception
            public ElementDefinitionInfo Element_Exception;                                                                                 // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "Coverage.costToBeneficiary",                                                                                    // MakerGen.cs:395
                    ElementId = "Coverage.costToBeneficiary"                                                                                // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:223
                Element_Value.Write(sDef);                                                                                                  // MakerGen.cs:223
                Element_Exception.Write(sDef);                                                                                              // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_CostToBeneficiary()                                                                                                 // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 19. Coverage.costToBeneficiary.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Type",                                                                                              // MakerGen.cs:238
                        Path= "Coverage.costToBeneficiary.type",                                                                            // MakerGen.cs:239
                        Id = "Coverage.costToBeneficiary.type",                                                                             // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 20. Coverage.costToBeneficiary.value[x]
                    this.Element_Value = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Value",                                                                                             // MakerGen.cs:238
                        Path= "Coverage.costToBeneficiary.value[x]",                                                                        // MakerGen.cs:239
                        Id = "Coverage.costToBeneficiary.value[x]",                                                                         // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            },                                                                                                              // MakerGen.cs:360
                            new FhirKhit.Maker.Common.Complex.Type_Money                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 21. Coverage.costToBeneficiary.exception
                    this.Element_Exception = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Exception",                                                                                         // MakerGen.cs:238
                        Path= "Coverage.costToBeneficiary.exception",                                                                       // MakerGen.cs:239
                        Id = "Coverage.costToBeneficiary.exception",                                                                        // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new Type_Exception                                                                                              // MakerGen.cs:262
                            {                                                                                                               // MakerGen.cs:263
                            }                                                                                                               // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 1. Coverage.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:219
        // 2. Coverage.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:219
        // 3. Coverage.type
        public ElementDefinitionInfo Element_Type;                                                                                          // MakerGen.cs:219
        // 4. Coverage.policyHolder
        public ElementDefinitionInfo Element_PolicyHolder;                                                                                  // MakerGen.cs:219
        // 5. Coverage.subscriber
        public ElementDefinitionInfo Element_Subscriber;                                                                                    // MakerGen.cs:219
        // 6. Coverage.subscriberId
        public ElementDefinitionInfo Element_SubscriberId;                                                                                  // MakerGen.cs:219
        // 7. Coverage.beneficiary
        public ElementDefinitionInfo Element_Beneficiary;                                                                                   // MakerGen.cs:219
        // 8. Coverage.dependent
        public ElementDefinitionInfo Element_Dependent;                                                                                     // MakerGen.cs:219
        // 9. Coverage.relationship
        public ElementDefinitionInfo Element_Relationship;                                                                                  // MakerGen.cs:219
        // 10. Coverage.period
        public ElementDefinitionInfo Element_Period;                                                                                        // MakerGen.cs:219
        // 11. Coverage.payor
        public ElementDefinitionInfo Element_Payor;                                                                                         // MakerGen.cs:219
        // 12. Coverage.class
        public ElementDefinitionInfo Element_Class;                                                                                         // MakerGen.cs:219
        // 16. Coverage.order
        public ElementDefinitionInfo Element_Order;                                                                                         // MakerGen.cs:219
        // 17. Coverage.network
        public ElementDefinitionInfo Element_Network;                                                                                       // MakerGen.cs:219
        // 18. Coverage.costToBeneficiary
        public ElementDefinitionInfo Element_CostToBeneficiary;                                                                             // MakerGen.cs:219
        // 24. Coverage.subrogation
        public ElementDefinitionInfo Element_Subrogation;                                                                                   // MakerGen.cs:219
        // 25. Coverage.contract
        public ElementDefinitionInfo Element_Contract;                                                                                      // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:390
        {                                                                                                                                   // MakerGen.cs:391
            base.Write(sDef);                                                                                                               // MakerGen.cs:392
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                Path = "Coverage",                                                                                                          // MakerGen.cs:395
                ElementId = "Coverage"                                                                                                      // MakerGen.cs:396
            });                                                                                                                             // MakerGen.cs:397
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_Type.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_PolicyHolder.Write(sDef);                                                                                               // MakerGen.cs:223
            Element_Subscriber.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_SubscriberId.Write(sDef);                                                                                               // MakerGen.cs:223
            Element_Beneficiary.Write(sDef);                                                                                                // MakerGen.cs:223
            Element_Dependent.Write(sDef);                                                                                                  // MakerGen.cs:223
            Element_Relationship.Write(sDef);                                                                                               // MakerGen.cs:223
            Element_Period.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_Payor.Write(sDef);                                                                                                      // MakerGen.cs:223
            Element_Class.Write(sDef);                                                                                                      // MakerGen.cs:223
            Element_Order.Write(sDef);                                                                                                      // MakerGen.cs:223
            Element_Network.Write(sDef);                                                                                                    // MakerGen.cs:223
            Element_CostToBeneficiary.Write(sDef);                                                                                          // MakerGen.cs:223
            Element_Subrogation.Write(sDef);                                                                                                // MakerGen.cs:223
            Element_Contract.Write(sDef);                                                                                                   // MakerGen.cs:223
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
        public Resource_Coverage()                                                                                                          // MakerGen.cs:402
        {                                                                                                                                   // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:234
                // 1. Coverage.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:238
                    Path= "Coverage.identifier",                                                                                            // MakerGen.cs:239
                    Id = "Coverage.identifier",                                                                                             // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 2. Coverage.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Status",                                                                                                // MakerGen.cs:238
                    Path= "Coverage.status",                                                                                                // MakerGen.cs:239
                    Id = "Coverage.status",                                                                                                 // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 3. Coverage.type
                this.Element_Type = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:238
                    Path= "Coverage.type",                                                                                                  // MakerGen.cs:239
                    Id = "Coverage.type",                                                                                                   // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 4. Coverage.policyHolder
                this.Element_PolicyHolder = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_PolicyHolder",                                                                                          // MakerGen.cs:238
                    Path= "Coverage.policyHolder",                                                                                          // MakerGen.cs:239
                    Id = "Coverage.policyHolder",                                                                                           // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Patient",                                                          // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                                    // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 5. Coverage.subscriber
                this.Element_Subscriber = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Subscriber",                                                                                            // MakerGen.cs:238
                    Path= "Coverage.subscriber",                                                                                            // MakerGen.cs:239
                    Id = "Coverage.subscriber",                                                                                             // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Patient",                                                          // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                                     // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 6. Coverage.subscriberId
                this.Element_SubscriberId = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_SubscriberId",                                                                                          // MakerGen.cs:238
                    Path= "Coverage.subscriberId",                                                                                          // MakerGen.cs:239
                    Id = "Coverage.subscriberId",                                                                                           // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 7. Coverage.beneficiary
                this.Element_Beneficiary = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Beneficiary",                                                                                           // MakerGen.cs:238
                    Path= "Coverage.beneficiary",                                                                                           // MakerGen.cs:239
                    Id = "Coverage.beneficiary",                                                                                            // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Patient"                                                           // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 8. Coverage.dependent
                this.Element_Dependent = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Dependent",                                                                                             // MakerGen.cs:238
                    Path= "Coverage.dependent",                                                                                             // MakerGen.cs:239
                    Id = "Coverage.dependent",                                                                                              // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 9. Coverage.relationship
                this.Element_Relationship = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Relationship",                                                                                          // MakerGen.cs:238
                    Path= "Coverage.relationship",                                                                                          // MakerGen.cs:239
                    Id = "Coverage.relationship",                                                                                           // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 10. Coverage.period
                this.Element_Period = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Period",                                                                                                // MakerGen.cs:238
                    Path= "Coverage.period",                                                                                                // MakerGen.cs:239
                    Id = "Coverage.period",                                                                                                 // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Period                                                                       // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 11. Coverage.payor
                this.Element_Payor = new ElementDefinitionInfo                                                                              // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Payor",                                                                                                 // MakerGen.cs:238
                    Path= "Coverage.payor",                                                                                                 // MakerGen.cs:239
                    Id = "Coverage.payor",                                                                                                  // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Organization",                                                     // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Patient",                                                          // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                                     // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 12. Coverage.class
                this.Element_Class = new ElementDefinitionInfo                                                                              // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Class",                                                                                                 // MakerGen.cs:238
                    Path= "Coverage.class",                                                                                                 // MakerGen.cs:239
                    Id = "Coverage.class",                                                                                                  // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Class                                                                                                      // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 16. Coverage.order
                this.Element_Order = new ElementDefinitionInfo                                                                              // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Order",                                                                                                 // MakerGen.cs:238
                    Path= "Coverage.order",                                                                                                 // MakerGen.cs:239
                    Id = "Coverage.order",                                                                                                  // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt                                                           // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 17. Coverage.network
                this.Element_Network = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Network",                                                                                               // MakerGen.cs:238
                    Path= "Coverage.network",                                                                                               // MakerGen.cs:239
                    Id = "Coverage.network",                                                                                                // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 18. Coverage.costToBeneficiary
                this.Element_CostToBeneficiary = new ElementDefinitionInfo                                                                  // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_CostToBeneficiary",                                                                                     // MakerGen.cs:238
                    Path= "Coverage.costToBeneficiary",                                                                                     // MakerGen.cs:239
                    Id = "Coverage.costToBeneficiary",                                                                                      // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_CostToBeneficiary                                                                                          // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 24. Coverage.subrogation
                this.Element_Subrogation = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Subrogation",                                                                                           // MakerGen.cs:238
                    Path= "Coverage.subrogation",                                                                                           // MakerGen.cs:239
                    Id = "Coverage.subrogation",                                                                                            // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                               // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 25. Coverage.contract
                this.Element_Contract = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Contract",                                                                                              // MakerGen.cs:238
                    Path= "Coverage.contract",                                                                                              // MakerGen.cs:239
                    Id = "Coverage.contract",                                                                                               // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Contract"                                                          // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            this.Name = "Coverage";                                                                                                         // MakerGen.cs:471
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Coverage";                                                                  // MakerGen.cs:472
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:407
}                                                                                                                                           // MakerGen.cs:452
