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
      "id": "ChargeItem",
      "url": "http://hl7.org/fhir/StructureDefinition/ChargeItem",
      "version": "4.0.0",
      "name": "ChargeItem",
      "status": "draft",
      "publisher": "Health Level Seven International (Patient Administration)",
      "description": "The resource ChargeItem describes the provision of healthcare provider products for a certain patient, therefore referring not only to the product, but containing in addition details of the provision, like date, time, amounts and participating organizations and persons. Main Usage of the ChargeItem is to enable the billing process and internal cost allocation.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "ChargeItem",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "ChargeItem",
            "path": "ChargeItem",
            "short": "Item containing charge code(s) associated with the provision of healthcare provider products",
            "definition": "The resource ChargeItem describes the provision of healthcare provider products for a certain patient, therefore referring not only to the product, but containing in addition details of the provision, like date, time, amounts and participating organizations and persons. Main Usage of the ChargeItem is to enable the billing process and internal cost allocation.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "ChargeItem.identifier",
            "path": "ChargeItem.identifier",
            "short": "Business Identifier for item",
            "definition": "Identifiers assigned to this event performer or other systems.",
            "requirements": "Allows identification of the charge Item as it is known by various participating systems and in a way that remains consistent across servers.",
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
            "id": "ChargeItem.definitionUri",
            "path": "ChargeItem.definitionUri",
            "short": "Defining information about the code of this charge item",
            "definition": "References the (external) source of pricing information, rules of application for the code this ChargeItem uses.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "uri"
              }
            ],
            "isSummary": false
          },
          {
            "id": "ChargeItem.definitionCanonical",
            "path": "ChargeItem.definitionCanonical",
            "short": "Resource defining the code of this ChargeItem",
            "definition": "References the source of pricing information, rules of application for the code this ChargeItem uses.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ChargeItemDefinition"
                ]
              }
            ],
            "isSummary": false
          },
          {
            "id": "ChargeItem.status",
            "path": "ChargeItem.status",
            "short": "planned | billable | not-billable | aborted | billed | entered-in-error | unknown",
            "definition": "The current state of the ChargeItem.",
            "comment": "Unknown does not represent \"other\" - one of the defined statuses must apply.  Unknown is used when the authoring system is not sure what the current status is.\n\nThis element is labeled as a modifier because the status contains the code entered-in-error that marks the charge item as not currently valid.",
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
                  "valueString": "ChargeItemStatus"
                }
              ],
              "strength": "required",
              "description": "Codes identifying the lifecycle stage of a ChargeItem.",
              "valueSet": "http://hl7.org/fhir/ValueSet/chargeitem-status|4.0.0"
            }
          },
          {
            "id": "ChargeItem.partOf",
            "path": "ChargeItem.partOf",
            "short": "Part of referenced ChargeItem",
            "definition": "ChargeItems can be grouped to larger ChargeItems covering the whole set.",
            "requirements": "E.g. Drug administration as part of a procedure, procedure as part of observation, etc.",
            "alias": [
              "container"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ChargeItem"
                ]
              }
            ],
            "isSummary": false
          },
          {
            "id": "ChargeItem.code",
            "path": "ChargeItem.code",
            "short": "A code that identifies the charge, like a billing code",
            "definition": "A code that identifies the charge, like a billing code.",
            "alias": [
              "type"
            ],
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
                  "valueString": "ChargeItemCode"
                }
              ],
              "strength": "example",
              "description": "Example set of codes that can be used for billing purposes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/chargeitem-billingcodes"
            }
          },
          {
            "id": "ChargeItem.subject",
            "path": "ChargeItem.subject",
            "short": "Individual service was done for/to",
            "definition": "The individual or set of individuals the action is being or was performed on.",
            "requirements": "Links the event to the Patient context.",
            "alias": [
              "patient"
            ],
            "min": 1,
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
            "id": "ChargeItem.context",
            "path": "ChargeItem.context",
            "short": "Encounter / Episode associated with event",
            "definition": "The encounter or episode of care that establishes the context for this event.",
            "requirements": "Links the request to the Encounter context.",
            "alias": [
              "encounter"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Encounter",
                  "http://hl7.org/fhir/StructureDefinition/EpisodeOfCare"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ChargeItem.occurrence[x]",
            "path": "ChargeItem.occurrence[x]",
            "short": "When the charged service was applied",
            "definition": "Date/time(s) or duration when the charged service was applied.",
            "comment": "The list of types may be constrained as appropriate for the type of charge item.",
            "alias": [
              "timing"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              },
              {
                "code": "Period"
              },
              {
                "code": "Timing"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ChargeItem.performer",
            "path": "ChargeItem.performer",
            "short": "Who performed charged service",
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
            "id": "ChargeItem.performer.function",
            "path": "ChargeItem.performer.function",
            "short": "What type of performance was done",
            "definition": "Describes the type of performance or participation(e.g. primary surgeon, anesthesiologiest, etc.).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": false,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ChargeItemPerformerFunction"
                }
              ],
              "strength": "example",
              "description": "Codes describing the types of functional roles performers can take on when performing events.",
              "valueSet": "http://hl7.org/fhir/ValueSet/performer-role"
            }
          },
          {
            "id": "ChargeItem.performer.actor",
            "path": "ChargeItem.performer.actor",
            "short": "Individual who was performing",
            "definition": "The device, practitioner, etc. who performed or participated in the service.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/CareTeam",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                ]
              }
            ],
            "isSummary": false
          },
          {
            "id": "ChargeItem.performingOrganization",
            "path": "ChargeItem.performingOrganization",
            "short": "Organization providing the charged service",
            "definition": "The organization requesting the service.",
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
            "id": "ChargeItem.requestingOrganization",
            "path": "ChargeItem.requestingOrganization",
            "short": "Organization requesting the charged service",
            "definition": "The organization performing the service.",
            "comment": "The rendered Service might not be associated with a Request. This property indicates which Organization requested the services to be rendered. (In many cases, this may just be the Department associated with the Encounter.location).",
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
            "id": "ChargeItem.costCenter",
            "path": "ChargeItem.costCenter",
            "short": "Organization that has ownership of the (potential, future) revenue",
            "definition": "The financial cost center permits the tracking of charge attribution.",
            "comment": "The costCenter could either be given as a reference to an Organization(Role) resource or as the identifier of the cost center determined by Reference.identifier.value and Reference.identifier.system, depending on use case requirements.",
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
            "id": "ChargeItem.quantity",
            "path": "ChargeItem.quantity",
            "short": "Quantity of which the charge item has been serviced",
            "definition": "Quantity of which the charge item has been serviced.",
            "comment": "In many cases this may just be a value, if the underlying units are implicit in the definition of the charge item code.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ChargeItem.bodysite",
            "path": "ChargeItem.bodysite",
            "short": "Anatomical location, if relevant",
            "definition": "The anatomical location where the related service has been applied.",
            "comment": "Only used if not implicit in code found in Condition.code. If the use case requires attributes from the BodySite resource (e.g. to identify and track separately) then use the standard extension [bodySite](extension-bodysite.html).  May be a summary code, or a reference to a very precise definition of the location, or both.",
            "min": 0,
            "max": "*",
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
                  "valueString": "BodySite"
                }
              ],
              "strength": "example",
              "description": "Codes describing anatomical locations. May include laterality.",
              "valueSet": "http://hl7.org/fhir/ValueSet/body-site"
            }
          },
          {
            "id": "ChargeItem.factorOverride",
            "path": "ChargeItem.factorOverride",
            "short": "Factor overriding the associated rules",
            "definition": "Factor overriding the factor determined by the rules associated with the code.",
            "comment": "There is no reason to carry the factor in the instance of a ChargeItem unless special circumstances require a manual override. The factors are usually defined by a set of rules in a back catalogue of the billing codes  (see ChargeItem.definition). Derived profiles may require a ChargeItem.overrideReason to be provided if either factor or price are manually overridden.",
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
            "id": "ChargeItem.priceOverride",
            "path": "ChargeItem.priceOverride",
            "short": "Price overriding the associated rules",
            "definition": "Total price of the charge overriding the list price associated with the code.",
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
            "id": "ChargeItem.overrideReason",
            "path": "ChargeItem.overrideReason",
            "short": "Reason for overriding the list price/factor",
            "definition": "If the list price or the rule-based factor associated with the code is overridden, this attribute can capture a text to indicate the  reason for this action.",
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
            "id": "ChargeItem.enterer",
            "path": "ChargeItem.enterer",
            "short": "Individual who was entering",
            "definition": "The device, practitioner, etc. who entered the charge item.",
            "comment": "The enterer is also the person considered responsible for factor/price overrides if applicable.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ChargeItem.enteredDate",
            "path": "ChargeItem.enteredDate",
            "short": "Date the charge item was entered",
            "definition": "Date the charge item was entered.",
            "comment": "The actual date when the service associated with the charge has been rendered is captured in occurrence[x].",
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
            "id": "ChargeItem.reason",
            "path": "ChargeItem.reason",
            "short": "Why was the charged  service rendered?",
            "definition": "Describes why the event occurred in coded or textual form.",
            "comment": "If the application of the charge item requires a reason to be given, it can be captured here. Textual reasons can be captured using reasonCode.text.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": false,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ChargeItemReason"
                }
              ],
              "strength": "example",
              "description": "Example binding for reason.",
              "valueSet": "http://hl7.org/fhir/ValueSet/icd-10"
            }
          },
          {
            "id": "ChargeItem.service",
            "path": "ChargeItem.service",
            "short": "Which rendered service is being charged?",
            "definition": "Indicated the rendered service that caused this charge.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",
                  "http://hl7.org/fhir/StructureDefinition/ImagingStudy",
                  "http://hl7.org/fhir/StructureDefinition/Immunization",
                  "http://hl7.org/fhir/StructureDefinition/MedicationAdministration",
                  "http://hl7.org/fhir/StructureDefinition/MedicationDispense",
                  "http://hl7.org/fhir/StructureDefinition/Observation",
                  "http://hl7.org/fhir/StructureDefinition/Procedure",
                  "http://hl7.org/fhir/StructureDefinition/SupplyDelivery"
                ]
              }
            ],
            "isSummary": false
          },
          {
            "id": "ChargeItem.product[x]",
            "path": "ChargeItem.product[x]",
            "short": "Product charged",
            "definition": "Identifies the device, food, drug or other product being charged either by type code or reference to an instance.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/Medication",
                  "http://hl7.org/fhir/StructureDefinition/Substance"
                ]
              },
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": false,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ChargeItemProduct"
                }
              ],
              "strength": "example",
              "description": "Example binding for product type.",
              "valueSet": "http://hl7.org/fhir/ValueSet/device-kind"
            }
          },
          {
            "id": "ChargeItem.account",
            "path": "ChargeItem.account",
            "short": "Account to place this charge",
            "definition": "Account into which this ChargeItems belongs.",
            "comment": "Systems posting the ChargeItems might not always be able to determine, which accounts the Items need to be places into. It is up to the postprocessing Financial System to apply internal rules to decide based on the Encounter/EpisodeOfCare/Patient/Coverage context and the type of ChargeItem, which Account is appropriate.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Account"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ChargeItem.note",
            "path": "ChargeItem.note",
            "short": "Comments made about the ChargeItem",
            "definition": "Comments made about the event by the performer, subject or other participants.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Annotation"
              }
            ],
            "isSummary": false
          },
          {
            "id": "ChargeItem.supportingInformation",
            "path": "ChargeItem.supportingInformation",
            "short": "Further information supporting this charge",
            "definition": "Further information supporting this charge.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ],
            "isSummary": false
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir resource 'ChargeItem'
    /// </summary>
    // 0. ChargeItem
    public partial class Resource_ChargeItem : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 10. ChargeItem.performer
        public partial class Type_Performer : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 11. ChargeItem.performer.function
            public ElementDefinitionInfo Element_Function;
            // 12. ChargeItem.performer.actor
            public ElementDefinitionInfo Element_Actor;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ChargeItem.performer",
                    ElementId = "ChargeItem.performer"
                });
                Element_Function.Write(sDef);
                Element_Actor.Write(sDef);
            }
            
            public Type_Performer()
            {
                {
                    // 11. ChargeItem.performer.function
                    this.Element_Function = new ElementDefinitionInfo
                    {
                        Name = "Element_Function",
                        Path= "ChargeItem.performer.function",
                        Id = "ChargeItem.performer.function",
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
                    // 12. ChargeItem.performer.actor
                    this.Element_Actor = new ElementDefinitionInfo
                    {
                        Name = "Element_Actor",
                        Path= "ChargeItem.performer.actor",
                        Id = "ChargeItem.performer.actor",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                    "http://hl7.org/fhir/StructureDefinition/Organization",
                                    "http://hl7.org/fhir/StructureDefinition/CareTeam",
                                    "http://hl7.org/fhir/StructureDefinition/Patient",
                                    "http://hl7.org/fhir/StructureDefinition/Device",
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                                }
                            }
                        }
                    };
                }
            }
        }
        // 1. ChargeItem.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. ChargeItem.definitionUri
        public ElementDefinitionInfo Element_DefinitionUri;
        // 3. ChargeItem.definitionCanonical
        public ElementDefinitionInfo Element_DefinitionCanonical;
        // 4. ChargeItem.status
        public ElementDefinitionInfo Element_Status;
        // 5. ChargeItem.partOf
        public ElementDefinitionInfo Element_PartOf;
        // 6. ChargeItem.code
        public ElementDefinitionInfo Element_Code;
        // 7. ChargeItem.subject
        public ElementDefinitionInfo Element_Subject;
        // 8. ChargeItem.context
        public ElementDefinitionInfo Element_Context;
        // 9. ChargeItem.occurrence[x]
        public ElementDefinitionInfo Element_Occurrence;
        // 10. ChargeItem.performer
        public ElementDefinitionInfo Element_Performer;
        // 13. ChargeItem.performingOrganization
        public ElementDefinitionInfo Element_PerformingOrganization;
        // 14. ChargeItem.requestingOrganization
        public ElementDefinitionInfo Element_RequestingOrganization;
        // 15. ChargeItem.costCenter
        public ElementDefinitionInfo Element_CostCenter;
        // 16. ChargeItem.quantity
        public ElementDefinitionInfo Element_Quantity;
        // 17. ChargeItem.bodysite
        public ElementDefinitionInfo Element_Bodysite;
        // 18. ChargeItem.factorOverride
        public ElementDefinitionInfo Element_FactorOverride;
        // 19. ChargeItem.priceOverride
        public ElementDefinitionInfo Element_PriceOverride;
        // 20. ChargeItem.overrideReason
        public ElementDefinitionInfo Element_OverrideReason;
        // 21. ChargeItem.enterer
        public ElementDefinitionInfo Element_Enterer;
        // 22. ChargeItem.enteredDate
        public ElementDefinitionInfo Element_EnteredDate;
        // 23. ChargeItem.reason
        public ElementDefinitionInfo Element_Reason;
        // 24. ChargeItem.service
        public ElementDefinitionInfo Element_Service;
        // 25. ChargeItem.product[x]
        public ElementDefinitionInfo Element_Product;
        // 26. ChargeItem.account
        public ElementDefinitionInfo Element_Account;
        // 27. ChargeItem.note
        public ElementDefinitionInfo Element_Note;
        // 28. ChargeItem.supportingInformation
        public ElementDefinitionInfo Element_SupportingInformation;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "ChargeItem",
                ElementId = "ChargeItem"
            });
            Element_Identifier.Write(sDef);
            Element_DefinitionUri.Write(sDef);
            Element_DefinitionCanonical.Write(sDef);
            Element_Status.Write(sDef);
            Element_PartOf.Write(sDef);
            Element_Code.Write(sDef);
            Element_Subject.Write(sDef);
            Element_Context.Write(sDef);
            Element_Occurrence.Write(sDef);
            Element_Performer.Write(sDef);
            Element_PerformingOrganization.Write(sDef);
            Element_RequestingOrganization.Write(sDef);
            Element_CostCenter.Write(sDef);
            Element_Quantity.Write(sDef);
            Element_Bodysite.Write(sDef);
            Element_FactorOverride.Write(sDef);
            Element_PriceOverride.Write(sDef);
            Element_OverrideReason.Write(sDef);
            Element_Enterer.Write(sDef);
            Element_EnteredDate.Write(sDef);
            Element_Reason.Write(sDef);
            Element_Service.Write(sDef);
            Element_Product.Write(sDef);
            Element_Account.Write(sDef);
            Element_Note.Write(sDef);
            Element_SupportingInformation.Write(sDef);
        }
        
        public Resource_ChargeItem()
        {
            {
                // 1. ChargeItem.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "ChargeItem.identifier",
                    Id = "ChargeItem.identifier",
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
                // 2. ChargeItem.definitionUri
                this.Element_DefinitionUri = new ElementDefinitionInfo
                {
                    Name = "Element_DefinitionUri",
                    Path= "ChargeItem.definitionUri",
                    Id = "ChargeItem.definitionUri",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uri
                        {
                        }
                    }
                };
            }
            {
                // 3. ChargeItem.definitionCanonical
                this.Element_DefinitionCanonical = new ElementDefinitionInfo
                {
                    Name = "Element_DefinitionCanonical",
                    Path= "ChargeItem.definitionCanonical",
                    Id = "ChargeItem.definitionCanonical",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Canonical
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/ChargeItemDefinition"
                            }
                        }
                    }
                };
            }
            {
                // 4. ChargeItem.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "ChargeItem.status",
                    Id = "ChargeItem.status",
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
                // 5. ChargeItem.partOf
                this.Element_PartOf = new ElementDefinitionInfo
                {
                    Name = "Element_PartOf",
                    Path= "ChargeItem.partOf",
                    Id = "ChargeItem.partOf",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/ChargeItem"
                            }
                        }
                    }
                };
            }
            {
                // 6. ChargeItem.code
                this.Element_Code = new ElementDefinitionInfo
                {
                    Name = "Element_Code",
                    Path= "ChargeItem.code",
                    Id = "ChargeItem.code",
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
                // 7. ChargeItem.subject
                this.Element_Subject = new ElementDefinitionInfo
                {
                    Name = "Element_Subject",
                    Path= "ChargeItem.subject",
                    Id = "ChargeItem.subject",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/Group"
                            }
                        }
                    }
                };
            }
            {
                // 8. ChargeItem.context
                this.Element_Context = new ElementDefinitionInfo
                {
                    Name = "Element_Context",
                    Path= "ChargeItem.context",
                    Id = "ChargeItem.context",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Encounter",
                                "http://hl7.org/fhir/StructureDefinition/EpisodeOfCare"
                            }
                        }
                    }
                };
            }
            {
                // 9. ChargeItem.occurrence[x]
                this.Element_Occurrence = new ElementDefinitionInfo
                {
                    Name = "Element_Occurrence",
                    Path= "ChargeItem.occurrence[x]",
                    Id = "ChargeItem.occurrence[x]",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Period
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Timing
                        {
                        }
                    }
                };
            }
            {
                // 10. ChargeItem.performer
                this.Element_Performer = new ElementDefinitionInfo
                {
                    Name = "Element_Performer",
                    Path= "ChargeItem.performer",
                    Id = "ChargeItem.performer",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Performer
                        {
                        }
                    }
                };
            }
            {
                // 13. ChargeItem.performingOrganization
                this.Element_PerformingOrganization = new ElementDefinitionInfo
                {
                    Name = "Element_PerformingOrganization",
                    Path= "ChargeItem.performingOrganization",
                    Id = "ChargeItem.performingOrganization",
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
                // 14. ChargeItem.requestingOrganization
                this.Element_RequestingOrganization = new ElementDefinitionInfo
                {
                    Name = "Element_RequestingOrganization",
                    Path= "ChargeItem.requestingOrganization",
                    Id = "ChargeItem.requestingOrganization",
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
                // 15. ChargeItem.costCenter
                this.Element_CostCenter = new ElementDefinitionInfo
                {
                    Name = "Element_CostCenter",
                    Path= "ChargeItem.costCenter",
                    Id = "ChargeItem.costCenter",
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
                // 16. ChargeItem.quantity
                this.Element_Quantity = new ElementDefinitionInfo
                {
                    Name = "Element_Quantity",
                    Path= "ChargeItem.quantity",
                    Id = "ChargeItem.quantity",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Quantity
                        {
                        }
                    }
                };
            }
            {
                // 17. ChargeItem.bodysite
                this.Element_Bodysite = new ElementDefinitionInfo
                {
                    Name = "Element_Bodysite",
                    Path= "ChargeItem.bodysite",
                    Id = "ChargeItem.bodysite",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                        {
                        }
                    }
                };
            }
            {
                // 18. ChargeItem.factorOverride
                this.Element_FactorOverride = new ElementDefinitionInfo
                {
                    Name = "Element_FactorOverride",
                    Path= "ChargeItem.factorOverride",
                    Id = "ChargeItem.factorOverride",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                        {
                        }
                    }
                };
            }
            {
                // 19. ChargeItem.priceOverride
                this.Element_PriceOverride = new ElementDefinitionInfo
                {
                    Name = "Element_PriceOverride",
                    Path= "ChargeItem.priceOverride",
                    Id = "ChargeItem.priceOverride",
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
            {
                // 20. ChargeItem.overrideReason
                this.Element_OverrideReason = new ElementDefinitionInfo
                {
                    Name = "Element_OverrideReason",
                    Path= "ChargeItem.overrideReason",
                    Id = "ChargeItem.overrideReason",
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
                // 21. ChargeItem.enterer
                this.Element_Enterer = new ElementDefinitionInfo
                {
                    Name = "Element_Enterer",
                    Path= "ChargeItem.enterer",
                    Id = "ChargeItem.enterer",
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
                                "http://hl7.org/fhir/StructureDefinition/Organization",
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/Device",
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                            }
                        }
                    }
                };
            }
            {
                // 22. ChargeItem.enteredDate
                this.Element_EnteredDate = new ElementDefinitionInfo
                {
                    Name = "Element_EnteredDate",
                    Path= "ChargeItem.enteredDate",
                    Id = "ChargeItem.enteredDate",
                    Min = 0,
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
                // 23. ChargeItem.reason
                this.Element_Reason = new ElementDefinitionInfo
                {
                    Name = "Element_Reason",
                    Path= "ChargeItem.reason",
                    Id = "ChargeItem.reason",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                        {
                        }
                    }
                };
            }
            {
                // 24. ChargeItem.service
                this.Element_Service = new ElementDefinitionInfo
                {
                    Name = "Element_Service",
                    Path= "ChargeItem.service",
                    Id = "ChargeItem.service",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",
                                "http://hl7.org/fhir/StructureDefinition/ImagingStudy",
                                "http://hl7.org/fhir/StructureDefinition/Immunization",
                                "http://hl7.org/fhir/StructureDefinition/MedicationAdministration",
                                "http://hl7.org/fhir/StructureDefinition/MedicationDispense",
                                "http://hl7.org/fhir/StructureDefinition/Observation",
                                "http://hl7.org/fhir/StructureDefinition/Procedure",
                                "http://hl7.org/fhir/StructureDefinition/SupplyDelivery"
                            }
                        }
                    }
                };
            }
            {
                // 25. ChargeItem.product[x]
                this.Element_Product = new ElementDefinitionInfo
                {
                    Name = "Element_Product",
                    Path= "ChargeItem.product[x]",
                    Id = "ChargeItem.product[x]",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Device",
                                "http://hl7.org/fhir/StructureDefinition/Medication",
                                "http://hl7.org/fhir/StructureDefinition/Substance"
                            }
                        },
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                        {
                        }
                    }
                };
            }
            {
                // 26. ChargeItem.account
                this.Element_Account = new ElementDefinitionInfo
                {
                    Name = "Element_Account",
                    Path= "ChargeItem.account",
                    Id = "ChargeItem.account",
                    Min = 0,
                    Max = -1,
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
            {
                // 27. ChargeItem.note
                this.Element_Note = new ElementDefinitionInfo
                {
                    Name = "Element_Note",
                    Path= "ChargeItem.note",
                    Id = "ChargeItem.note",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Annotation
                        {
                        }
                    }
                };
            }
            {
                // 28. ChargeItem.supportingInformation
                this.Element_SupportingInformation = new ElementDefinitionInfo
                {
                    Name = "Element_SupportingInformation",
                    Path= "ChargeItem.supportingInformation",
                    Id = "ChargeItem.supportingInformation",
                    Min = 0,
                    Max = -1,
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
            this.Name = "ChargeItem";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/ChargeItem";
        }
    }
}
